using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleLicenseTaxCalculator
{
    class VehicleTax
    {
        //
        // Summary:
        //     依起始年和結束年切割出的區間數量
        //
        // Returns:
        //     區間數量
        private int _count;
        //
        // Summary:
        //     年稅額
        //
        // Returns:
        //     年稅額
        public int tax { get; set; }
        //
        // Summary:
        //     起始年
        //
        // Returns:
        //     起始年
        public DateTime startDate { get; set; }
        //
        // Summary:
        //     結束年
        //
        // Returns:
        //     結束年
        public DateTime endDate { get; set; }


        public VehicleTax (int t)
        {
            this.tax = t;
            this.startDate = new DateTime(DateTime.Now.Year, 1, 1);
            this.endDate = new DateTime(DateTime.Now.Year, 12, 31);
            this._count = 1;
        }

        public VehicleTax(int t, DateTime st, DateTime en)
        {
            this.tax = t;
            this.startDate = st.Date;
            this.endDate = en.Date;
            this._count = en.Year - st.Year + 1;
        }

        public int GetCount()
        {
            return _count;
        }

        public int[] getYears()
        {
            int[] years = new int[_count];
            for (int i = 0; i < _count; i++)
                years[i] = startDate.Year + i;
            return years;
        }

        // 判斷是否閏年，回傳天數
        public int[] getDaysInYears()
        {
            int[] years = getYears();
            int[] result = new int[_count];
            for (int i = 0; i < _count; i++)
            {
                if (DateTime.IsLeapYear(years[i]))
                    result[i] = 366;
                else
                    result[i] = 365;
            }
            return result;
        }

        // 將每年的計算區間切割並回傳
        public DateTime[,] getIntervals()
        {
            DateTime[,] intervals = new DateTime[_count, 2];

            for (int i = 0; i < _count; i++)
            {
                // 每年的起始日
                if (i == 0)
                    intervals[i, 0] = startDate;
                else
                    intervals[i, 0] = new DateTime(startDate.Year + i, 1, 1);

                // 每年的結束日
                if (i == _count - 1)
                    intervals[i, 1] = endDate;
                else
                    intervals[i, 1] = new DateTime(startDate.Year + i, 12, 31);
            }
            return intervals;
        }

        // 計算切割出的區間的天數
        public int[] getDaysInIntervals()
        {
            DateTime[,] intervals = getIntervals();
            int count = intervals.GetLength(0);
            int[] days = new int[count];
            for (int i = 0; i < count; i++)
            {
                days[i] = (intervals[i, 1] - intervals[i, 0]).Days + 1;    // 頭尾都要算所以加一天
            }
            return days;
        }

        // 計算稅額
        public int[] TaxEveryYear()
        {
            int[] daysInItervals = getDaysInIntervals();
            int[] daysInYears = getDaysInYears();

            int[] result = new int[_count];
            for(int i = 0; i < _count; i++)
            {
                result[i] = this.tax * daysInItervals[i] / daysInYears[i];
            }
            return result;
        }
        
        // 總金額
        public int TotalTax()
        {
            int sum = 0;
            int[] taxs = TaxEveryYear();
            foreach (int item in taxs)
                sum += item;
            return sum;
        }
    }
}
