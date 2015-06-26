using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PartialViewsDemo.Models
{
    public class Entree
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<Ingredient> Ingredients { get; set; }

        public Entree()
        {
            Ingredients = new List<Ingredient>();
        }
    }
}