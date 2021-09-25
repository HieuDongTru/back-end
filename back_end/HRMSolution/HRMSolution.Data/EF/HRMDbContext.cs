using HRMSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace HRMSolution.Data.EF
{
    public class HRMDbContext : DbContext
    {
        public HRMDbContext( DbContextOptions options) : base(options)
        {
            
        }
        public DbSet<HopDong> HopDongs { get; set; }
        
    }
}
