using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data.Entity.Core.Metadata.Edm;

namespace UhlSportDataAccessLayer
{

   
    public class Settings
    {
   

        public static void WriteToEventLog(Exception ex, EventLogEntryType LogName)
        {
            string sourceName = "UhlSport";


            // Create the event source if it does not exist
            if (!EventLog.SourceExists(sourceName))
            {
                EventLog.CreateEventSource(sourceName, "Application");
             
            }


            // Log an information event
            EventLog.WriteEntry(sourceName, ex.ToString(),LogName);

        }
        public static string connectionStringForSqlite = $"Data Source=DatabaseFile/FaislDb.db";
        public static void AccessDenied()
        {
            MessageBox.Show("انت محظور من الوصول الي هنا يرجي التواصل مع مستر مبارك ");
        }
    
    }
}
