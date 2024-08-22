using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestStoredProcedures.Helper
{
    public class HelperSQLBuilder
    {
        private const string execKeyword = "exec";
        public static string ExecQueryWithParam(string procName, Dictionary<string, object> parameter)
        {
            string result = "";

            try
            {
                result = $"{execKeyword} {procName} {ParamIntoString(parameter)};";
            } catch (Exception ex)
            {
                HelperLog.logAction.Invoke("Perform ExecQueryWithParam fail.", ex);
            }

            return result;
        }

        public static string ExecQuery(string procName)
        {
            string result = "";

            try
            {
                result = $"{execKeyword} {procName};";
            }
            catch (Exception ex)
            {
                HelperLog.logAction.Invoke("Perform ExecQuery fail.", ex);
            }

            return result;
        }

        private static string ParamIntoString(Dictionary<string, object> parameter)
        {
            string result = "";
            try
            {
                result = string.Join(", ", parameter.Values.Select(value => $"'{value}'"));
            } catch (Exception ex)
            {
                HelperLog.logAction.Invoke("Perform ParamIntoString fail.", ex);
            }

            return result;
        }
    }
}
