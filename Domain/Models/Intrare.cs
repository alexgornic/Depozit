using System;

namespace Depozit.Domain.Models
{
    public class Intrare
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string PartnerName { get; set; }
        public string Quantity { get; set; }
        public DateTime Data { get; set; }

        
    }
}
