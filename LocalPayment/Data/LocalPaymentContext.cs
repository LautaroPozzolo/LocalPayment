using LocalPayment.Models;
using Microsoft.EntityFrameworkCore;

namespace LocalPayment.Data
{
    public class LocalPaymentContext : DbContext
    {

        public LocalPaymentContext(DbContextOptions<LocalPaymentContext> options) : base(options)
        {

        }

        //entities
        public DbSet<Card> Cards { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
