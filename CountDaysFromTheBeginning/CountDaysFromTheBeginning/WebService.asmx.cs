using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace CountDaysFromTheBeginning
{
    /// <summary>
    /// Service which count days from the beginning of our Era
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService : System.Web.Services.WebService
    {
        /// <summary>
        /// Method, which count amount of days from the beginning
        /// </summary>
        /// <param name="paramDateInStringFormat">
        /// param date in string format
        /// </param>
        /// <returns>
        /// amount days from the beginning
        /// </returns>
        [WebMethod]
        public int CountAmountOfDaysFromTheBeginning(string paramDateInStringFormat)
        {
            DateTime date = DateTime.Parse(paramDateInStringFormat);
            DateTime beginningDate = new DateTime(0001, 01, 01);
            return (int)(date - beginningDate).TotalDays;
        }
    }
}
