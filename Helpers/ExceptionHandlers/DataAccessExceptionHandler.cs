using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Common.Helpers.ExceptionHandling
{
    public static class DataAccessExceptionHandler 
    {
        public static bool HandleException(ref System.Exception ex)
        {
            ExceptionManagerSetting.SetExceptionManager();
            //bool rethrow = false;
            //if ((ex is SqlException))
            //{
            //    SqlException dbExp = (SqlException)ex;
            //    if (dbExp.Number >= 50000)
            //    {
            //        rethrow = ExceptionPolicy.HandleException(ex, "DataAccessCustomPolicy");
            //        ex = new DataAccessCustomException(ex.Message);
            //    }
            //    else
            //    {
            //        rethrow = ExceptionPolicy.HandleException(ex, "DataAccessPolicy");
            //        if (rethrow)
            //        {
            //            throw ex;
            //        }
            //    }
            //}

            bool rethrow = false;
            //burda dataaccess ile alakali exceptionslari artirabilirim
            // { Name = "DbUpdateException" FullName = "System.Data.Entity.Infrastructure.DbUpdateException"}
            if ((ex is System.Data.Entity.Infrastructure.DbUpdateException))
            {
                //DbUpdateException 
                DataException dataExp = (DataException)ex;
                //kendi kodumuu yazcam 

                if (dataExp.Data.Count >= 50000)
                {
                    rethrow = ExceptionPolicy.HandleException(ex, "DataAccessCustomPolicy");
                    ex = new DataAccessCustomException(ex.Message);
                }
                else
                {

                    rethrow = ExceptionPolicy.HandleException(ex, "DataAccessPolicy");
                    if (rethrow)
                    {
                        throw ex;
                    }
                }
            }

            else if (ex is System.Exception)
            {
                rethrow = ExceptionPolicy.HandleException(ex, "DataAccessPolicy");
                if (rethrow)
                {
                    throw ex;
                }
            }
            return rethrow;
        }
    }
}

