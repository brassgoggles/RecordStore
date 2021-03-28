using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWuld.Models
{
    class Sale
    {
        public int Id { get; set; }
        public int SalesPersonId { get; set; }
        public decimal? Total { get; set; }
        public DateTime SaleDateTime { get; set; }

        public Sale(int id, int salesPersonId, 
            decimal? total, DateTime saleDateTime)
        {
            Id = id;
            SalesPersonId = salesPersonId;
            Total = total;
            SaleDateTime = saleDateTime;
        }
    }
}
