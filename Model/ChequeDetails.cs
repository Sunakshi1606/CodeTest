using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UmbracoChequeApplication.Model
{
    public class ChequeDetails
    {
            public string Name { get; set; }
            public string ChequeNo { get; set; }
            public string Date { get; set; }
            public decimal Amount { get; set; }
            public string AmountInWords { get; set; }

       
    }
}