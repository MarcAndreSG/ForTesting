namespace CRM.DataAccess.Model
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Company Model class.
    /// </summary>
    public class Company
    {
        /// <inheritdoc/>
        [Key]
        [Required]
        public int Id { get; set; }

        /// <inheritdoc/>
        [MaxLength(30)]
        public string Name { get; set; } = string.Empty;

        /// <inheritdoc/>
        [MaxLength(2500)]
        public string Description { get; set; } = string.Empty;

        /// <inheritdoc/>
        [MaxLength(80)]
        public string Street { get; set; } = string.Empty;

        /// <inheritdoc/>
        [MaxLength(50)]
        public string City { get; set; } = string.Empty;

        /// <inheritdoc/>
        [MaxLength(50)]
        public string State { get; set; } = string.Empty;

        /// <inheritdoc/>
        [MaxLength(10)]
        public string PostalCode { get; set; } = string.Empty;

        /// <inheritdoc/>
        public List<Customer> Customers { get; set; } = new List<Customer>();
    }
}