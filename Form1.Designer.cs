
namespace VehicleLicenseTaxCalculator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnRange = new System.Windows.Forms.RadioButton();
            this.rbtnYear = new System.Windows.Forms.RadioButton();
            this.calendarPanel = new System.Windows.Forms.Panel();
            this.dtPickerTo = new System.Windows.Forms.DateTimePicker();
            this.dtPickerFrom = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxType = new System.Windows.Forms.ComboBox();
            this.cbxDisplacement = new System.Windows.Forms.ComboBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.calendarPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "使用期間";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(139, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "用途";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "汽缸cc數/馬達馬力";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(62, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "試算結果";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnRange);
            this.groupBox1.Controls.Add(this.rbtnYear);
            this.groupBox1.Location = new System.Drawing.Point(216, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(210, 58);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "請選擇";
            // 
            // rbtnRange
            // 
            this.rbtnRange.AutoSize = true;
            this.rbtnRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnRange.Location = new System.Drawing.Point(114, 19);
            this.rbtnRange.Name = "rbtnRange";
            this.rbtnRange.Size = new System.Drawing.Size(75, 24);
            this.rbtnRange.TabIndex = 1;
            this.rbtnRange.TabStop = true;
            this.rbtnRange.Text = "依期間";
            this.rbtnRange.UseVisualStyleBackColor = true;
            this.rbtnRange.CheckedChanged += new System.EventHandler(this.rbtnRange_CheckedChanged);
            // 
            // rbtnYear
            // 
            this.rbtnYear.AutoSize = true;
            this.rbtnYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnYear.Location = new System.Drawing.Point(19, 20);
            this.rbtnYear.Name = "rbtnYear";
            this.rbtnYear.Size = new System.Drawing.Size(75, 24);
            this.rbtnYear.TabIndex = 0;
            this.rbtnYear.TabStop = true;
            this.rbtnYear.Text = "全年度";
            this.rbtnYear.UseVisualStyleBackColor = true;
            this.rbtnYear.CheckedChanged += new System.EventHandler(this.rbtnYear_CheckedChanged);
            // 
            // calendarPanel
            // 
            this.calendarPanel.Controls.Add(this.dtPickerTo);
            this.calendarPanel.Controls.Add(this.dtPickerFrom);
            this.calendarPanel.Controls.Add(this.label6);
            this.calendarPanel.Controls.Add(this.label5);
            this.calendarPanel.Location = new System.Drawing.Point(432, 25);
            this.calendarPanel.Name = "calendarPanel";
            this.calendarPanel.Size = new System.Drawing.Size(239, 84);
            this.calendarPanel.TabIndex = 5;
            // 
            // dtPickerTo
            // 
            this.dtPickerTo.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPickerTo.CustomFormat = "           yyyy - MM - dd";
            this.dtPickerTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPickerTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPickerTo.Location = new System.Drawing.Point(43, 50);
            this.dtPickerTo.Name = "dtPickerTo";
            this.dtPickerTo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtPickerTo.Size = new System.Drawing.Size(168, 22);
            this.dtPickerTo.TabIndex = 3;
            // 
            // dtPickerFrom
            // 
            this.dtPickerFrom.CustomFormat = "           yyyy - MM - dd";
            this.dtPickerFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPickerFrom.Location = new System.Drawing.Point(43, 18);
            this.dtPickerFrom.Name = "dtPickerFrom";
            this.dtPickerFrom.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtPickerFrom.Size = new System.Drawing.Size(168, 22);
            this.dtPickerFrom.TabIndex = 2;
            this.dtPickerFrom.ValueChanged += new System.EventHandler(this.dtPickerFrom_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "至";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "從";
            // 
            // cbxType
            // 
            this.cbxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxType.FormattingEnabled = true;
            this.cbxType.Items.AddRange(new object[] {
            "自用小客車",
            "營業用小客車",
            "大客車",
            "貨車",
            "機車"});
            this.cbxType.Location = new System.Drawing.Point(216, 114);
            this.cbxType.Name = "cbxType";
            this.cbxType.Size = new System.Drawing.Size(210, 28);
            this.cbxType.TabIndex = 6;
            this.cbxType.SelectedIndexChanged += new System.EventHandler(this.cbxType_SelectedIndexChanged);
            // 
            // cbxDisplacement
            // 
            this.cbxDisplacement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDisplacement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxDisplacement.FormattingEnabled = true;
            this.cbxDisplacement.Location = new System.Drawing.Point(216, 178);
            this.cbxDisplacement.Name = "cbxDisplacement";
            this.cbxDisplacement.Size = new System.Drawing.Size(210, 28);
            this.cbxDisplacement.TabIndex = 4;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(462, 159);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(86, 47);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "試算";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(585, 159);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(86, 47);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "重填";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txtResult
            // 
            this.txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.Location = new System.Drawing.Point(80, 304);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResult.Size = new System.Drawing.Size(541, 237);
            this.txtResult.TabIndex = 10;
            this.txtResult.Text = " ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 589);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.cbxDisplacement);
            this.Controls.Add(this.cbxType);
            this.Controls.Add(this.calendarPanel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = " Vehicle Tax Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.calendarPanel.ResumeLayout(false);
            this.calendarPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnRange;
        private System.Windows.Forms.RadioButton rbtnYear;
        private System.Windows.Forms.Panel calendarPanel;
        private System.Windows.Forms.DateTimePicker dtPickerFrom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtPickerTo;
        private System.Windows.Forms.ComboBox cbxType;
        private System.Windows.Forms.ComboBox cbxDisplacement;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtResult;
    }
}

