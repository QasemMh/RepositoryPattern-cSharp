using AppCore_DomainModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCore_DomainModel.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {

        IBaseRepository<Employee> Employees { get; }
        int Complete();
    }
}
