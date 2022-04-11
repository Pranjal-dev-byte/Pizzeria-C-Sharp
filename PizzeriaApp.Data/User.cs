using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzeriaApp.Data
{
    //public class User
    //{
    //    public int UserId { get; set; }
    //    [Required]
    //    public string Email { get; set; }
    //    public List<CartItem> Cart { get; set; }
    //}



    public class Pizza
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

    public class Ingredients
    {
        public int IngredientsId { get; set; }
        public string Type { get; set; }
        public int Price { get; set; }
        public string Img { get; set; }
    }
    public class CartItem
    {
        public int CartItemId { get; set; }

        [ForeignKey("Email")]
        public string Email { get; set; }


        //[ForeignKey("PizzaId")]
        public List<Pizza>? PizzaOption { get; set; }

        //[ForeignKey("IngredientsId")]
        public List<Ingredients>? PizzaIngredients { get; set; }
    }
}
