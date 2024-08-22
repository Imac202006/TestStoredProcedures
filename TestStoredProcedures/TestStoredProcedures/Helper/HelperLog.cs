using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestStoredProcedures.Helper
{
    public class HelperLog
    {
        public const string LogTypeError = "Error";

        public delegate void LogCallback(string msg, Exception ex);

        public static LogCallback logAction;
    }
}
