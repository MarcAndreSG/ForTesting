namespace CRM.DataAccess.Model
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Model class customer.
    /// </summary>
    public class Customer
    {
        /// <inheritdoc/>
        [Key]
        [Required]
        public int Id { get; set; }

        /// <inheritdoc/>
        [MaxLength(25)]
        public string Firname { get; set; } = string.Empty;

        /// <inheritdoc/>
        [MaxLength(25)]
        public string Surname { get; set; } = string.Empty;

        /// <inheritdoc/>
        public int Age { get; set; } = 0;

        /// <inheritdoc/>
        [MaxLength(50)]
        public string Email { get; set; } = string.Empty;

        /// <inheritdoc/>
        public DateTime DateOfBirth { get; set; } = default;

        /// <inheritdoc/>
        public bool HasCreditLimit { get; set; } = false;

        /// <inheritdoc/>
        public int CreditLimit { get; set; } = 0;

        /// <inheritdoc/>
        public bool CreditClassificationVIP { get; set; }

        /// <inheritdoc/>
        public bool CreditClassificationNonImportantperson { get; set; }
    }
}
