using System;
using System.Collections.Generic;

#nullable disable

namespace GymManager.Models
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
    }
    
    [AclTableName("discounts")]
    public partial class Discount: BaseEntity
    {
        public string DiscountName { get; set; }
        public string DiscountValue { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string DiscountDescription { get; set; }
        public string DiscountCode { get; set; }
    }
}
