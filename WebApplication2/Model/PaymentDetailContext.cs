using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebApplication2.Model
{
    public class PaymentDetailContext: DbContext
    {
        public PaymentDetailContext(DbContextOptions<PaymentDetailContext> options):base(options)
        {
                
        }
        public DbSet<PaymentDetail> paymentdetails { get; set; }
        public DbSet<UserDetails> UserDetails { get; set; }
    }
}
