﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DataLayer
{
    public class RevHausDbContext : IdentityDbContext<User>
    {

        public RevHausDbContext() : base() { }

        public RevHausDbContext(DbContextOptions options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-G098CJK\\SQLEXPRESS;Database=RevHaus;Trusted_Connection=True;");
            }
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<AuctionListing> AuctionListings { get; set; }

        public DbSet<Bid> Bids { get; set; }
        
        public DbSet<Car> Cars { get; set; }
        
        public DbSet<Listing> Listings { get; set; }

        public DbSet<Image> Image { get; set; }

    }
}
