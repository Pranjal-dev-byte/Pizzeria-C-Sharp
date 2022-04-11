using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzeriaBackend.Models
{
    public class UserModel
    {
        public int UserId { get; set; }
        public int Email { get; set; }
        public List<CartItemModel> Cart { get; set; }

    }
}
