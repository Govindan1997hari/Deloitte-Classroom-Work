using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ConsoleApplication1
{
    class Pdetails
    {
        [Key]
        [Required]
        public int pizzaid { get; set; }
        [Required]
        public string pizzaname { get; set; }
        [Required]
        public string  toppings { get; set; }
        [Required]
        public string pizzatype { get; set; }
        [Required]
        public char pizzasize { get; set; }
        [Required]
        public int price{ get; set; }
    }
}
