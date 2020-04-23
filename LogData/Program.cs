using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogData
{
    class Program
    {
        Logger logger = LogManager.GetCurrentClassLogger();
        static void Main(string[] args)
        {
            Logger logger = LogManager.GetCurrentClassLogger();
            try
            {
                int zero = 0;
                int result = 5 / zero;
            }
            catch (Exception ex)
            {
                logger.Error(ex,ex.Message);
            }
        }
    }
}
