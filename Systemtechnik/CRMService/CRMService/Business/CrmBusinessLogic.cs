namespace CRMService.Business
{
    using CRM.DataAccess;
    using CRM.DataAccess.Model;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    using System.Text.Json;
    using System.Xml;

    public class CrmBusinessLogic
    {
        private ICRMRepository _cRMRepository;
        private Validation _validation = new Validation();

        public CrmBusinessLogic()
        {
            CRMContext cRMContext = new CRMContext();
            _cRMRepository = new CRMRepository(cRMContext);
        }

        internal ActionResult<string> GetCustomerById(string id)
        {
            int unique = -1;
            if (!string.IsNullOrWhiteSpace(id))
            {
                if (int.TryParse(id, out unique))
                {
                    if (unique >= 0)
                    {
                        var customer = _cRMRepository.GetEntityByID<Customer>(unique);
                        if (customer != null)
                        {
                            this.CreateJasonString<Customer>(customer);
                        }
                    }
                }
            }

            return string.Empty;
        }

        internal ActionResult<string> GetCustomerByName(string name)
        {
            if (!string.IsNullOrWhiteSpace(name))
            {
                var customer = _cRMRepository.GetTEntity<Customer>().Where(x => x.Firname == name).ToList();
                if (customer != null && customer.Any())
                {
                    this.CreateJasonString<Customer>(customer.First());
                }
            }

            return string.Empty;
        }

        internal ActionResult<string> SetCompany(string companyAsJson)
        {
            if (!string.IsNullOrWhiteSpace(companyAsJson))
            {
                var company = JsonSerializer.Deserialize<Company>(companyAsJson);
                
                if (company != null) 
                {
                    _cRMRepository.InsertEntity<Company>(company);
                    _cRMRepository.SaveChanges();
                    return "OK";
                }
            }

            return "NOK";
        }

        internal ActionResult<string> SetCustomer(string customerAsJson)
        {
            if (!string.IsNullOrWhiteSpace(customerAsJson))
            {
                var customer = JsonSerializer.Deserialize<Customer>(customerAsJson);

                if (customer != null)
                {
                    _validation.ProcessCreditLimitation(customer);
                    var validResult = ValidationValues(customer);
                    
                    if (string.IsNullOrEmpty(validResult))
                    {
                        _cRMRepository.InsertEntity<Customer>(customer);
                        _cRMRepository.SaveChanges();
                        return "OK";
                    }
                    else
                    {
                        return validResult;
                    }
                }
            }

            return "NOK";
        }

        private string ValidationValues(Customer customer)
        {
            if (!_validation.CheckEmail(customer.Email))
            {
                return "No valid email address!";
            }

            if (_validation.CheckAge(customer.Age))
            {
                return "No valid age, must be 21!";
            }

            if (_validation.CheckCreditLimit(customer.CreditLimit))
            {
                return "Customers credit limit is unter 500 and not valid!";
            }

            return string.Empty;
        }


        private string CreateJasonString<T>(T objectToJson)
            where T : class
        {
            var jsonString = JsonSerializer.Serialize<T>(objectToJson);
            if (jsonString != null)
            {
                return jsonString;
            }

            return string.Empty;
        }
    }
}