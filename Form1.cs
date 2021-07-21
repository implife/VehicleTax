using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace VehicleLicenseTaxCalculator
{
    public partial class Form1 : Form
    {
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
            string type = cbxType.SelectedItem.ToString();
            string[] dis = VehicleTaxData.getDisplacementAry(type);
            if (dis[0] != "null")
            {
                this.cbxDisplacement.Items.Clear();
                this.cbxDisplacement.Items.AddRange(dis);
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
            // 取得類型、汽缸數和年額度
            string type = cbxType.SelectedItem.ToString();
            string displacement = cbxDisplacement.SelectedItem.ToString();
            int tax = VehicleTaxData.getTax(type, displacement);

            // 判斷是全年度或區間
            VehicleTax vTax;
            if (rbtnYear.Checked)
                vTax = new VehicleTax(tax);
            else
                vTax = new VehicleTax(tax, dtPickerFrom.Value, dtPickerTo.Value);


            // 將結果寫成字串
            string resultText = "";
            for (int i = 0; i < vTax.GetCount(); i++)
            {
                resultText +=
                    $"使用期間: {vTax.getIntervals()[i, 0].ToString("yyyy-MM-dd")}" +
                    $" ~ {vTax.getIntervals()[i, 1].ToString("yyyy-MM-dd")}" + Environment.NewLine +
                    $"使用天數: {vTax.getDaysInIntervals()[i]} 天" + Environment.NewLine +
                    $"用途: {type}" + Environment.NewLine +
                    $"汽缸cc數: {displacement}" + Environment.NewLine +
                    $"計算公式: {vTax.tax} * {vTax.getDaysInIntervals()[i]} / {vTax.getDaysInYears()[i]} = {vTax.TaxEveryYear()[i]} 元" + Environment.NewLine +
                    $"應納稅額: {vTax.TaxEveryYear()[i]}" + Environment.NewLine + Environment.NewLine;
            }

            // 如果不只一筆要寫總金額
            if (vTax.GetCount() > 1)
            {
                resultText += $"共{vTax.GetCount()}筆，全部應納稅額: {vTax.TotalTax()} 元";
            }

            txtResult.Text = resultText;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.init();
        }

        #endregion


        #region Custom method

        private void init()
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

        #endregion
    }
}
