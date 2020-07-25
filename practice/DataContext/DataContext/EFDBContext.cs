using DataContext.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataContext.DataContext
{
   public class EFDBContext :DbContext
    {
        public EFDBContext()
        {

        }

        public EFDBContext(DbContextOptions<EFDBContext> options) : base(options)
        {

        }

        public DbSet<Product> Product { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"data source=tcp:sqlpracticeanshu.database.windows.net,1433; initial catalog=practicedb;persist security info=True;user id=anshu;password=rajesh*1234;");
            }
            //Server=tcp:sqlpracticeanshu.database.windows.net,1433;Initial Catalog=practicedb;Persist Security Info=False;User ID=anshu;Password={your_password};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;
            base.OnConfiguring(optionsBuilder);
        }
    }
}
