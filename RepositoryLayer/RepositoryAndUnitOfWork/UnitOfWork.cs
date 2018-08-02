using ContextLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer
{
    public class UnitOfWork : IDisposable
    {
        private bool disposed = false;
        #region declarations
        private HajjManagementSystemEntities context = null;
        public UnitOfWork()
        {
            context = new HajjManagementSystemEntities();
        }

        #endregion


        #region PrivateFields Declareation 

        //Repository<Club> clubRepo = null;

        //public Repository<Club> ClubRepo
        //{
        //    get
        //    {
        //        if (clubRepo == null)
        //        {
        //            clubRepo = new Repository<Club>(context);
        //        }
        //        return clubRepo;
        //    }
        //}

        #endregion


        #region Database

        public bool Save()
        {
            try
            {

                context.SaveChanges();
                return true;

            }

            catch (Exception ex)
            {

                return false;
            }
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        #endregion
    }
}
