using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectMVC.Models
{
    // Combining AccountListModels and TransactionListModels into a single Model in order to use and view them in the same view:
    public class TransactionHistoryModels
    {
        public List<AccountListModels> AccountListModels { get; set; }
        public List<TransactionListModels> TransactionListModels { get; set; }
    }
}