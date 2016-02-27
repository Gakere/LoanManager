﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoanManager.Models
{
    public class Loan
    {
        public int Id { get; set; }
        [Required]
        [DisplayFormat(DataFormatString = "{0:C0}")]
        public decimal Principal { get; set; }
        [Required]
        [DisplayFormat(DataFormatString = "{0:C0}")]
        public decimal Interest { get; set; }
        [Required]
        [ReadOnly(true)]
        public bool Cleared { get; set; }
        [Remote("IsAsset_Encumbered", "Validation")]
        public int AssetId { get; set; }

        public Loan()
        {
            Transactions = new List<Transaction>();
        }

        public virtual Asset Asset { get; set; }
        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}