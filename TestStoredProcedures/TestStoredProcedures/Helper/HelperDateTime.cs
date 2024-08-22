using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestStoredProcedures.Helper
{
    public class HelperDateTime
    {
        public const string format_yyyyMMddTHHmmss = "yyyy-MM-ddTHH:mm:ss";

        public static DateTime GetUtcNow()
        {
            return DateTime.UtcNow;
        }

        public static DateTime GetDefaultDateTime()
        {
            return new DateTime(2000, 1, 1, 0, 0, 0, DateTimeKind.Utc);
        }

        public static string GetDateTimeInFormat(DateTime dtValue, string format)
        {
            string value = "";

            try
            {
                value = dtValue.ToString(format);
            }
            catch (Exception ex)
            {
                HelperLog.logAction.Invoke("Perform GetDateTimeInFormat fail.", ex);
            }

            return value;
        }
    }
}
