using DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo.DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        protected private AppDbcontext _context;
        public UnitOfWork(AppDbcontext context)
        {
            _context = context;
           
            Products = new Repository<Product>(context);
			Categories = new Repository<Category>(context);

		}
       
        public IRepository<Product> Products { get; }

		public IRepository<Category> Categories { get; }

		public void Dispose()
        {
            _context.Dispose();
        }

        public int Save()
        {
            return _context.SaveChanges();  
        }
    }
}
