using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStoredProcedures.Helper;
using TestStoredProcedures.Model;

namespace TestStoredProcedures.Controller
{
    public class HelperCar
    {
        HelperDBConn helperDBConn = new HelperDBConn();

        public static String GetAllCarQuery()
        {
            string result = "";
            try
            {
                result = HelperSQLBuilder.ExecQuery("GetAllCar");

            }
            catch (Exception ex)
            {
                HelperLog.logAction.Invoke("HelperCar.GetAllCarQuery() perform fail.", ex);
            }

            return result;
        }

        public void AddCar(ModelCar modelCar)
        {
            try
            {
                string sql = HelperSQLBuilder.ExecQueryWithParam("InsertCar", modelCar.ToAddDict());
                helperDBConn.ExecuteQuery(sql);
            }
            catch (Exception ex)
            {
                HelperLog.logAction.Invoke("HelperCar.AddCar() perform fail.", ex);
            }
        }

        public void DeleteCarById(int carId)
        {
            try
            {
                string sql = HelperSQLBuilder.ExecQueryWithParam("DeleteCarById", new Dictionary<string, object>{
                    {"CarId", carId},
                });
                helperDBConn.ExecuteQuery(sql);
            }
            catch (Exception ex)
            {
                HelperLog.logAction.Invoke("HelperCar.DeleteCar() perform fail.", ex);
            }
        }

        public void UpdateCarById(int carId, string brand, string model, DateTime manufactureDate)
        {
            try
            {
                string sql = HelperSQLBuilder.ExecQueryWithParam("UpdateCar", new Dictionary<string, object>{
                    {"CarId", carId},
                    {"LupdDateTime", HelperDateTime.GetDateTimeInFormat(HelperDateTime.GetUtcNow(), HelperDateTime.format_yyyyMMddTHHmmss)},
                    {"Brand", brand},
                    {"Model", model},
                    {"ManufactureDate", HelperDateTime.GetDateTimeInFormat(manufactureDate, HelperDateTime.format_yyyyMMddTHHmmss)},
                    {"DelStatus", 'N'},
                    {"DelDateTime", HelperDateTime.GetDateTimeInFormat(HelperDateTime.GetDefaultDateTime(), HelperDateTime.format_yyyyMMddTHHmmss)},
                });
                helperDBConn.ExecuteQuery(sql);
            }
            catch (Exception ex)
            {
                HelperLog.logAction.Invoke("HelperCar.UpdateCar() perform fail.", ex);
            }
        }
    }
}
