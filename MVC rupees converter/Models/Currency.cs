using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVC_rupees_converter.Models
{
    [Table("tbl_Currencys")]
    public class Currency
    {
        [Key]
        public int Id { get; set; }


        [Required(ErrorMessage = "Value is required.")]
        [RegularExpression("[^0-9]", ErrorMessage = "Only Numbers  allowed.")]
        public decimal Input { get; set; }

        public string Output { get; set; }


    }
}