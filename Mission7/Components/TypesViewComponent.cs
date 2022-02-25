using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Mission7.Models;

namespace Mission7.Components
{
    public class TypesViewComponent : ViewComponent
    {
        private IBooksRepository repo { get; set; }

        public TypesViewComponent (IBooksRepository temp)
        {
            repo = temp;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.Selected = RouteData?.Values["bookCategory"];

            var types = repo.Books.Select(x => x.Category).Distinct().OrderBy(x => x);

            return View(types);
        }
    }
}
