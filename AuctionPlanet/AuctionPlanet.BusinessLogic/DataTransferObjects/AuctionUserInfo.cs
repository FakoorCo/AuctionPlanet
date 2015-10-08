﻿using System;
using System.Collections.Generic;
using AuctionPlanet.DataAccess.Entities;
using AuctionPlanet.DataAccess.Identity;

namespace AuctionPlanet.BusinessLogic.DataTransferObjects
{
    public class AuctionUserInfo
    {
        public Guid Id { get; set; }

        public bool BannedFlag { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }

        public virtual ICollection<Lot> PublishedLots { get; set; }

        public virtual ICollection<Lot> AcquiredLots { get; set; }
    }
}
