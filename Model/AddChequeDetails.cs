using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace UmbracoChequeApplication.Model
{
    public class AddChequeDetails
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string ChequeNo { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public int Amount { get; set; }

    }
}