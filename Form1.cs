using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace VehicleLicenseTaxCalculator
{
    public partial class Form1 : Form
    {
        #region 資料設定與宣告

        // 小客車資料
        private string[] displacementCarAry = {
            "500cc 以下 / 38HP以下(38.6PS以下)", "501cc - 600cc / 38.1-56HP(38.7-56.8PS)", 
            "601cc - 1200cc / 56.1-83HP(56.9-84.2PS)", "1201cc - 1800cc / 83.1-182HP(84.3-184.7PS)",
            "1801cc - 2400cc / 182.1-262HP(184.8-265.9PS)", "2401cc - 3000cc / 262.1-322HP(266-326.8PS)",
            "3001cc - 4200cc / 322.1-414HP(326.9-420.2PS", "4201cc - 5400cc / 414.1-469HP(420.3-476.0PS)",
            "5401cc - 6600cc / 469.1-509HP(476.1-516.6PS)", "6601cc - 7800cc / 509.1HP以上(516.7PS以上)", 
            "7801cc以上"
        };
        private int[] selfCarTaxAry = { 1620, 2160, 4320, 7120, 11230, 15210, 28220, 46170, 69690, 117000, 151200 };
        private int[] businessCarTaxAry = { 900, 1260, 2160, 3060, 6480, 9900, 16380, 24300, 33660, 44460, 56700 };

        // 大客車和貨車資料
        private string[] displacementBigCarAry = {
            "500cc 以下", "501cc - 600cc", "601cc - 1200cc", "1201cc - 1800cc",
            "1801cc - 2400cc", "2401cc - 3000cc / 138HP以下(140.1PS以下)", "3001cc - 3600cc",
            "3601cc - 4200cc / 138.1-200HP(140.2-203.0PS)", "4201cc - 4800cc", 
            "4801cc - 5400cc / 200.1-247HP(203.1-250.7PS)", "5401cc - 6000cc",
            "6001cc - 6600cc / 247.1-286HP(250.8-290.3PS)","6601cc - 7200cc", 
            "7201cc - 7800cc / 286.1-336HP(290.4-341.0PS)", "7801cc - 8400cc",
            "8401cc - 9000cc / 336.1-361HP(341.1-366.4PS)","9001cc - 9600cc", 
            "9601cc - 10200cc / 361.1HP以上(366.5PS以上)", "10201以上"
        };
        private int[] bigCarTaxAry = {
            0, 1080, 1800, 2700, 3600, 4500, 5400, 6300, 7200, 8100,
            9000, 9900, 10800, 11700, 12600, 13500, 14400, 15300, 16200
        };
        private int[] truckTaxAry = {
            900, 1080, 1800, 2700, 3600, 4500, 5400, 6300, 7200, 8100,
            9000, 9900, 10800, 11700, 12600, 13500, 14400, 15300, 16200
        };

        // 機車資料
        private string[] displacementMotorAry = {
            "150cc 以下 / 12HP以下(12.2PS以下)", "151cc - 250cc / 12.1 - 20HP(12.3 - 20.3PS)",
            "251cc - 500cc / 20.1HP以上(20.4PS以上)", "501cc - 600cc",
            "601cc - 1200cc", "1201cc - 1800cc", "1801cc以上"
        };
        private int[] motorTaxAry = { 0, 800, 1620, 2160, 3600, 4320, 7120, 11230 };

        // 各種車型字典資料宣告
        private Dictionary<string, int> selfUseCarDic = new Dictionary<string, int>();
        private Dictionary<string, int> businessUseCarDic = new Dictionary<string, int>();
        private Dictionary<string, int> bigCarDic = new Dictionary<string, int>();
        private Dictionary<string, int> truckDic = new Dictionary<string, int>();
        private Dictionary<string, int> motorDic = new Dictionary<string, int>();

        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        #region Event

        private void Form1_Load(object sender, EventArgs e)
        {
            this.init();
        }

        private void rbtnYear_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnYear.Checked)
                this.calendarPanel.Visible = false;
        }

        private void rbtnRange_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnRange.Checked)
                this.calendarPanel.Visible = true;
        }

        private void cbxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbxType.SelectedItem)
            {
                case "自用小客車":
                    this.cbxDisplacement.Items.Clear();
                    this.cbxDisplacement.Items.AddRange(displacementCarAry);
                    break;
                case "營業用小客車":
                    this.cbxDisplacement.Items.Clear();
                    this.cbxDisplacement.Items.AddRange(displacementCarAry);
                    break;
                case "大客車":
                    this.cbxDisplacement.Items.Clear();
                    this.cbxDisplacement.Items.AddRange(displacementBigCarAry);
                    break;
                case "貨車":
                    this.cbxDisplacement.Items.Clear();
                    this.cbxDisplacement.Items.AddRange(displacementBigCarAry);
                    break;
                case "機車":
                    this.cbxDisplacement.Items.Clear();
                    this.cbxDisplacement.Items.AddRange(displacementMotorAry);
                    break; 
            }
            this.cbxDisplacement.SelectedIndex = 0;
        }

        private void dtPickerFrom_ValueChanged(object sender, EventArgs e)
        {
            // 結束日期不可比開始日期前面
            dtPickerTo.MinDate = dtPickerFrom.Value;
        }


        // 計算的按鈕事件
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string type = cbxType.SelectedItem.ToString();
            string displacement = cbxDisplacement.SelectedItem.ToString();

            // 藉由用途類型和汽缸數取得對應的年額度
            int tax = getTax(type, displacement);
            
            // 判斷是全年度還是區間
            DateTime dateFrom, dateTo;
            if (rbtnYear.Checked)
            {
                int thisYear = DateTime.Now.Year;
                dateFrom = new DateTime(thisYear, 1, 1);
                dateTo = new DateTime(thisYear, 12, 31);
            }
            else
            {
                dateFrom = dtPickerFrom.Value.Date;
                dateTo = dtPickerTo.Value.Date;
            }

            // 處理可能有跨年份的問題
            int count = dateTo.Year - dateFrom.Year + 1;    // 跨年份的數量
            int[] years = new int[count];                   // 所跨的年份 ex: {2019, 2020, 2021}
            int[] totalDaysInYear = new int[count];         // 每一年的天數，可能有潤年
            DateTime[,] intervals = new DateTime[count, 2]; // 每一年的區間頭尾日期
            int[] days = new int[count];                    // 每年區間的天數
            int[] results = new int[count];                 // 根據天數算出的每年稅額

            // 所跨的年份
            for (int i = 0; i < count; i++)
                years[i] = dateFrom.Year + i;

            // 每一年的天數
            totalDaysInYear = daysInYear(years);

            // 每一年的區間頭尾日期
            intervals = getInterval(dateFrom, dateTo);

            // 每年區間的天數
            days = getDaysInInterval(intervals);

            // 根據天數算出的每年稅額
            for (int i = 0; i < days.Length; i++)
                results[i] = calculateTax(tax, days[i], totalDaysInYear[i]); // 小數部分捨棄

            // 將結果寫成字串
            string resultText = "";
            for (int i = 0; i < count; i++)
            {
                resultText +=
                    $"使用期間: {intervals[i, 0].ToString("yyyy-MM-dd")} ~ {intervals[i, 1].ToString("yyyy-MM-dd")}"
                        + Environment.NewLine +
                    $"使用天數: {days[i]} 天" + Environment.NewLine +
                    $"用途: {type}" + Environment.NewLine +
                    $"汽缸cc數: {displacement}" + Environment.NewLine +
                    $"計算公式: {tax} * {days[i]} / {totalDaysInYear[i]} = {results[i]} 元" + Environment.NewLine +
                    $"應納稅額: {results[i]}" + Environment.NewLine + Environment.NewLine;
            }

            // 如果不只一筆要寫總金額
            if (count > 1)
            {
                int total = 0;
                foreach (int item in results)
                    total += item;
                resultText += $"全部應納稅額: {total} 元" + Environment.NewLine + Environment.NewLine;
            }
            txtResult.Text = resultText;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            initTheComponent();
        }

        #endregion



        #region Custom method

        private void init()
        {
            // 車型資料加入字典
            for (int i = 0; i < displacementCarAry.Length; i++)
            {
                selfUseCarDic.Add(displacementCarAry[i], selfCarTaxAry[i]);
                businessUseCarDic.Add(displacementCarAry[i], businessCarTaxAry[i]);
            }
            for (int i = 0; i < displacementBigCarAry.Length; i++)
            {
                bigCarDic.Add(displacementBigCarAry[i], bigCarTaxAry[i]);
                truckDic.Add(displacementBigCarAry[i], truckTaxAry[i]);
            }
            for (int i = 0; i < displacementMotorAry.Length; i++)
            {
                motorDic.Add(displacementMotorAry[i], motorTaxAry[i]);
            }

            initTheComponent();
        }
        private void initTheComponent()
        {
            this.calendarPanel.Visible = false;
            this.cbxType.SelectedIndex = 0;
            this.cbxDisplacement.SelectedIndex = 0;
            this.rbtnYear.Checked = true;
            this.dtPickerFrom.Value = DateTime.Now;
            this.dtPickerTo.Value = DateTime.Now;
            this.dtPickerTo.MinDate = DateTime.Now; // 結束日期不可比起始日期小
            this.txtResult.Text = "";
            this.cbxDisplacement.DropDownWidth = 360;
        }

        // 藉由用途類型和汽缸數取得對應的年額度
        private int getTax(string type, string displacement)
        {
            switch (type)
            {
                case "自用小客車":
                    return selfUseCarDic[displacement];
                case "營業用小客車":
                    return businessUseCarDic[displacement];
                case "大客車":
                    return bigCarDic[displacement];
                case "貨車":
                    return truckDic[displacement];
                case "機車":
                    return motorDic[displacement];
                default:
                    return 0;
            }
        }

        // 將每年的計算區間切割並回傳
        private DateTime[,] getInterval(DateTime start, DateTime end)
        {
            int count = end.Year - start.Year + 1;
            DateTime[,] intervals = new DateTime[count, 2];

            for(int i = 0; i < count; i++)
            {
                // 每年的起始日
                if (i == 0)
                    intervals[i, 0] = start;
                else
                    intervals[i, 0] = new DateTime(start.Year + i, 1, 1);
                
                // 每年的結束日
                if (i == count - 1)
                    intervals[i, 1] = end;
                else
                    intervals[i, 1] = new DateTime(start.Year + i, 12, 31);
            }
            return intervals;
        }

        // 計算切割出的區間的天數
        private int[] getDaysInInterval(DateTime[,] intervals)
        {
            int count = intervals.GetLength(0);
            int[] days = new int[count];
            for (int i = 0; i < count; i++)
            {
                days[i] = (intervals[i, 1] - intervals[i, 0]).Days + 1;    // 頭尾都要算所以加一天
            }
            return days;
        }

        // 計算稅額
        private int calculateTax(int price, int days, int daysInYear)
        {
            return price * days / daysInYear;
        }

        // 判斷是否閏年，回傳天數
        private int[] daysInYear(int[] years)
        {
            int[] result = new int[years.Length];
            for (int i = 0; i < years.Length; i++)
            {
                if (DateTime.IsLeapYear(years[i]))
                    result[i] = 366;
                else
                    result[i] = 365;
            }
            return result;
        }

        #endregion
    }
}
