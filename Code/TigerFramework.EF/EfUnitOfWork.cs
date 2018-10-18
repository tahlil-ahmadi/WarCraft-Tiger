using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TigerFramework.Core;

namespace TigerFramework.EF
{
    public class EfUnitOfWork : IUnitOfWork
    {
        private readonly DbContext _context;
        public EfUnitOfWork(DbContext context)
        {
            this._context = context;
        }

        public void Begin()
        {
            _context.Database.BeginTransaction(IsolationLevel.ReadCommitted);
        }

        public void Commit()
        {
            _context.SaveChanges();
            _context.Database.CurrentTransaction.Commit();
        }

        public void Rollback()
        {
            _context.Database.CurrentTransaction.Rollback();
        }
    }
}
