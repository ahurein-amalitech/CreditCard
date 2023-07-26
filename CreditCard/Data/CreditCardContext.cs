using CreditCard.Model;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace CreditCard.Data
{
    public class CreditCardContext : DbContext
    {
        public CreditCardContext(DbContextOptions options) : base(options)
        { }

        public DbSet<Card> CreditCards { get; set; }
    }
}