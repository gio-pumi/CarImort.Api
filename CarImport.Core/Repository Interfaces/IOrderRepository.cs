using CarImport.Core.Interfaces;
using CarImport.Core.Repository;
using CarImport.Domain.DbEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarImport.Core.Repository_Interfaces
{
    public interface IOrderRepository<T> : IBaseRepository<Order>
    {

    }
}
