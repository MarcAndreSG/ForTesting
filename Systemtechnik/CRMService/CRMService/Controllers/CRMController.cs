namespace CRMService.Controllers
{
    using CRM.DataAccess.Model;
    using CRMService.Business;
    using Microsoft.AspNetCore.Mvc;
    using System.Xml.Linq;
    using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

    /// <summary>
    /// CRM Controller.
    /// </summary>
    public class CRMController : Controller
    {
        private CrmBusinessLogic _crmBusinessLogic = new CrmBusinessLogic();

        /// <summary>
        /// Set the company.
        /// </summary>
        /// <param name="company"></param>
        /// <returns>Error string if then.</returns>
        [HttpPost("/SetCompany/")]
        public ActionResult<string> SetCompany(string company)
        {
            return _crmBusinessLogic.SetCompany(company);
        }

        /// <summary>
        /// Set the customer.
        /// </summary>
        /// <param name="customer"></param>
        /// <returns>Error string if then.</returns>
        [HttpPost("/SetCustomer/")]
        public ActionResult<string> SetCustomer(string customer)
        {
            return _crmBusinessLogic.SetCustomer(customer);
        }

        [HttpPost("/GetCustomerByName/")]
        public ActionResult<string> GetCustomerByName(string name)
        {
            return _crmBusinessLogic.GetCustomerByName(name);
        }

        [HttpPost("/GetCustomerById/")]
        public ActionResult<string> GetCustomerById(string id)
        {
            return _crmBusinessLogic.GetCustomerById(id);
        }
    }
}
