using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzeriaBackend.Models
{
    public class PizzaModel
    {
        public int PizzaId { get; set; }

        public string Type { get; set; }
        public int Price { get; set; }
        public string Img { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public string Ingredients { get; set; }
        public string Toppings { get; set; }
    }
}
