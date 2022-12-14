using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaProject.Models
{
    public class DataBaseServices
    {
        public Dictionary<string, int> pizzaSize = new Dictionary<string, int>();
        public Dictionary<string, int> pizzaTopping = new Dictionary<string, int>();

        public DataBaseServices() {
            pizzaSize["Small"] = 80;
            pizzaSize["Medium"] = 120;
            pizzaSize["Large"] = 150;
            pizzaTopping["Extra Cheese"] = 40;
            pizzaTopping["Pepporni"] = 80;
            pizzaTopping["Artichoke"] = 60;
            pizzaTopping["Anchovy"] = 120;
        }
    }
}
