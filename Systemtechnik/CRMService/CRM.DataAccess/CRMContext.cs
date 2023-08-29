namespace CRM.DataAccess
{
    using CRM.DataAccess.Model;
    using Microsoft.EntityFrameworkCore;

    /// <summary>
    /// Data model context class.
    /// </summary>
    public class CRMContext : DbContext
    {
        /// <summary>
        /// Gets or sets the DatabaseSet for customers.
        /// </summary>
        public DbSet<Customer> Customers { get; set; }

        /// <summary>
        /// Gets or sets the DatabaseSet for companies.
        /// </summary>
        public DbSet<Company> Companies { get; set; }

        /// <inheritdoc/>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("InMemoryDatabase");
        }
    }
}
