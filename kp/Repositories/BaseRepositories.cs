using kp.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace kp.Repositories
{
    public class BaseRepositories : IDisposable
    {
        protected AnaliticEntities1 _context;

        private bool disposed = false;

        public BaseRepositories() { }

        public BaseRepositories(AnaliticEntities1 context)
        {
            _context = context;
        }

        protected virtual void Dispose(bool disposed)
        {
            if (!this.disposed)
            {
                if (disposed)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
