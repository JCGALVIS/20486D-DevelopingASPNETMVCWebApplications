using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ActorsRazorPages.Models;

namespace ActorsRazorPages.Pages.Actors
{
    public class IndexModel : PageModel
    {
        private IData _Data;
        public IList<Actor> Actors { get; set; }

        public IndexModel(IData data) {
            this._Data = data;
        }

        public void OnGet()
        {
            Actors = this._Data.ActorsInitializeData();
        }
    }
}