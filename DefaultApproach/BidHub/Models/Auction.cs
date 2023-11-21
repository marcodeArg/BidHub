using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BidHub.Models
{
    [Table("Auctions")]
    public class Auction
    {
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
        public DateTime AuctionEnd { get; set; }
        public string Seller { get; set; }
        public string? Winner { get; set; }
        public decimal ReservePrice { get; set; } = 0;
        public decimal? SoldAmount { get; set; }
        public decimal? CurrentHighBid { get; set; }
        public Status Status { get; set; } = Status.Live;
        public Item Item { get; set; }
    }
}