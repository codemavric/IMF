using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace IMF.Models
{
    public class IMFInventory
    {

        [Required(ErrorMessage = "Please enter in a valid cost price"), ]
        public double costPrice {get; set;}

        [Required(ErrorMessage ="Please enter in a valid markup")]
        public double markup { get; set; }

        public double calcSellingPrice()
        {
            return ((markup / 100) * costPrice) + costPrice;
        }
     
    }
}
