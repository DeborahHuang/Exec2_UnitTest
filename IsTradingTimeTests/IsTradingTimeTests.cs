using IspanUtilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsTradingTimeTests
{
	internal class IsTradingTimeTests
	{
		[Test]
		public void IsTradingTime_交易時間為星期六早上十點 ()
		{
			var time = new TaiwainStockUtility();
			DateTime dt = new DateTime(2022, 10, 22,10,0,0);
			bool expected=true;
			bool actual=time.IsTradingTime(dt);
			Assert.AreEqual(expected,actual);
		}

		[Test]
		public void IsTradingTime_交易時間為星期五下午兩點()
		{
			var time = new TaiwainStockUtility();
			DateTime dt = new DateTime(2022, 10, 21, 14, 0, 0);
			bool expected = true;
			bool actual = time.IsTradingTime(dt);
			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void IsTradingTime_交易時間為星期三早上九點()
		{
			var time = new TaiwainStockUtility();
			DateTime dt = new DateTime(2022, 10, 19, 9, 0, 0);
			bool expected = true;
			bool actual = time.IsTradingTime(dt);
			Assert.AreEqual(expected, actual);
		}
	}
}
