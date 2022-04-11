using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzeriaBackend.Models
{
    public class IngredientsModel
    {
        public int IngredientsId { get; set; }
        public string Type { get; set; }
        public int Price { get; set; }
        public string Img { get; set; }
    }
}
