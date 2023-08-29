using CRM.DataAccess.Model;
using System.Diagnostics;
using System.Net.Mail;

namespace CRMService.Business
{
    public class Validation
    {
        /// <summary>
        /// Check the age over 20.
        /// </summary>
        /// <param name="age">The age for check.</param>
        /// <returns>Flag of cheking.</returns>
        public bool CheckAge(int age)
        {
            if (age >= 21)
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Check valid e-mail address.
        /// </summary>
        /// <param name="email">The e-mail adress to check.</param>
        /// <returns>Flag of cheking.</returns>
        public bool CheckEmail(string email) 
        {
            var result = true;

            try
            {
                var emailAddress = new MailAddress(email);
            }
            catch
            {
                result = false;
            }

            return result;
        }

        /// <summary>
        /// Check credit limit.
        /// </summary>
        /// <param name="email">Credit limit to check.</param>
        /// <returns>Flag of cheking.</returns>
        public bool CheckCreditLimit(int creditLimit) 
        {
            if (creditLimit < 500) 
            {
                return false;
            }

            return true;
        }

        public void ProcessCreditLimitation(Customer customer)
        {
            if (customer.CreditClassificationVIP)
            {
              customer.HasCreditLimit  = false;
              return;
            }

            if (customer.CreditClassificationNonImportantperson)
            {
                var ceditLimit = this.GetCreditLimit(customer);
                customer.CreditLimit = ceditLimit * 2;
            }
            else
            {
                var ceditLimit = this.GetCreditLimit(customer);
                customer.CreditLimit = ceditLimit;
            }
        }

        private int GetCreditLimit(Customer customer)
        {
            return 500;
        }

    }
}
