using PizzeriaApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzeriaBackend.Models
{
    public class CartItemModel
    {
        public int CartItemId { get; set; }
        public List<Pizza>? PizzaOption { get; set; }

        public List<Ingredients>? PizzaIngredients { get; set; }
    }
}
