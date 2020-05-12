using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CSEFTPCStrategyCore
{
    public abstract class BillingDetail
    {
        public Guid Id { get; set; }
        public string Owner { get; set; }
        public string Number { get; set; }
    }
}
