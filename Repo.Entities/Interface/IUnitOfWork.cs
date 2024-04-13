using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public interface IUnitOfWork:IDisposable
    {
       
        IRepository<Product> Products { get; }
		IRepository<Category> Categories { get; }
		 
		int Save();

    }
}
