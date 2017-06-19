using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UmbracoChequeApplication.Model
{
    public class ChequeList
    {
        public string Name { get; set; }
        public string ChequeNo { get; set; }
        public string Date { get; set; }
        public string Amount { get; set; }
        public Boolean Show { get; set; }

    }
}