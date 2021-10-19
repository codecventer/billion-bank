using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectMVC.Models
{
    public class TransactionListModels
    {
        public string FromAccount { get; set; }
        public string ToAccount { get; set; }
        public string Amount { get; set; }
        public string TransactionDate { get; set; }
        public string FromUser { get; set; }
    }
}