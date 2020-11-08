using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ShopBridge.DataModels.Models
{
    public class Product
    {
        [Key]
        public Guid ProductId { get; set; }
        [Required(ErrorMessage = "Please enter product name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Pleease enter product discription")]
        public string Description { get; set; }
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter valid Price")]
        public int Price { get; set; }
    }
}
