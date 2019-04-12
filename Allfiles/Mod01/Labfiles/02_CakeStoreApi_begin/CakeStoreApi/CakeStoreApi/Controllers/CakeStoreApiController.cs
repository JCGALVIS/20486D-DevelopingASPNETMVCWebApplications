using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CakeStoreApi.Models;

namespace CakeStoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CakeStoreApiController : ControllerBase
    {
        private IData _data;

        public CakeStoreApiController(IData data) {
            this._data = data;
        }

        [HttpGet("/api/CakeStore")]
        public ActionResult<List<CakeStore>> GetAll()
        {
            return _data.CakesInitializeData();
        }

        [HttpGet("/api/CakeStore/{id}")]
        public ActionResult<CakeStore> GetById(int? Id) {
            var item = this._data.GetCakeById(Id);

            if (item == null) {
                return NotFound();
            }

            return new ObjectResult(item);
        }
    }
}