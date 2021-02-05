using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Entity;

namespace GameProject.Abstract
{
    public interface ISalesService
    {
        string Sale(Customer customer, Game game, Campaign campaign);
    }
}
