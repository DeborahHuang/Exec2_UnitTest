using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IspanUtilities
{
    public class TaiwainStockUtility
    {
        public bool IsTradingTime(DateTime dt)
        {
			if ((int)dt.DayOfWeek <6 && (int)dt.DayOfWeek >0
               &&dt.Hour >= 9 && dt.Hour <= 13.5)return true;
            else return false;
        }
	}
}
