using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Abstract;
using GameProject.Entity;

namespace GameProject.Concrete
{
    class CustomerCheckManager:ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            if ((!string.IsNullOrEmpty(customer.FirstName))
                && (!string.IsNullOrEmpty(customer.LastName))
                && customer.NationalityId.Length == 11
                && customer.DateOfBirth.Year > 1920
                && customer.DateOfBirth.Year < 2022)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
