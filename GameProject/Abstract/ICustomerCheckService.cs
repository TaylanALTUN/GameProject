using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Entity;

namespace GameProject.Abstract
{
    public interface ICustomerCheckService
    {
        bool CheckIfRealPerson(Customer customer);
    }
}
