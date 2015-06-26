using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PartialViewsDemo.ViewModels.Entree
{
    public class EntreeIndexVM
    {
        public List<Models.Entree> Entrees { get; set; }

        public EntreeIndexVM()
        {
            Entrees = new List<Models.Entree>();
        }
    }
}