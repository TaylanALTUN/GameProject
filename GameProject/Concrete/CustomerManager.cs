using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Abstract;
using GameProject.Entity;

namespace GameProject.Concrete
{
    public class CustomerManager : EntityManagerBase<Customer>, ICustomerService
    {
        private ICustomerCheckService _customerCheckService;
        public CustomerManager(ICustomerCheckService customerCheckServis)
        {
            _customerCheckService = customerCheckServis;
        }

        public override string Add (Customer entity)
        {
            string result = "";
            if (_customerCheckService.CheckIfRealPerson(entity))
            {
                result=base.Add(entity);
            }
            else
            {
                result= "Geçerli bir kişi değil.";
            }
            return result;
        }

        public override string Update(Customer entity)
        {
            string result = "";
            if (_customerCheckService.CheckIfRealPerson(entity))
            {
                result = base.Update(entity);
            }
            else
            {
                result = "Not a valid person.";
            }
            return result;
        }
    }
}
