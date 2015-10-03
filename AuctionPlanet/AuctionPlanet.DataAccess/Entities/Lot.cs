﻿using System;
using AuctionPlanet.DataAccess.Utility;

namespace AuctionPlanet.DataAccess.Entities
{
    public class Lot
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public decimal StartPrice { get; set; }

        public decimal CurrentPrice { get; set; }

        public virtual AuctionUser OriginalOwner { get; set; }

        public virtual AuctionUser NewOwner { get; set; }

        public LotStatus Status { get; set; }
    }
}