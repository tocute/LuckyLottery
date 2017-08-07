namespace LuckyLottery
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該公開 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改這個方法的內容。
        ///
        /// </summary>
        private void InitializeComponent()
        {
            this._LvRawData = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader("(無)");
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
            this._TbNumOne = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._TbNumTwo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this._TbNumCount = new System.Windows.Forms.TextBox();
            this._TbNewNum2 = new System.Windows.Forms.TextBox();
            this._TbNewNum1 = new System.Windows.Forms.TextBox();
            this._TbNewNum6 = new System.Windows.Forms.TextBox();
            this._TbNewNum5 = new System.Windows.Forms.TextBox();
            this._TbNewNum4 = new System.Windows.Forms.TextBox();
            this._TbNewNum3 = new System.Windows.Forms.TextBox();
            this._TbNewNum7 = new System.Windows.Forms.TextBox();
            this._BtnReadFile = new System.Windows.Forms.Button();
            this._BtnSaveFile = new System.Windows.Forms.Button();
            this._BtnDeleteItem = new System.Windows.Forms.Button();
            this._BtnAddRecord = new System.Windows.Forms.Button();
            this._BtnQuery = new System.Windows.Forms.Button();
            this._LvResultData = new System.Windows.Forms.ListView();
            this.columnHeader10 = new System.Windows.Forms.ColumnHeader("(無)");
            this.columnHeader11 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader12 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader13 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader14 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader15 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader16 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader17 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader18 = new System.Windows.Forms.ColumnHeader();
            this._BtnColored = new System.Windows.Forms.Button();
            this._TbColoredNum = new System.Windows.Forms.TextBox();
            this._RbOrder = new System.Windows.Forms.RadioButton();
            this._RbSize = new System.Windows.Forms.RadioButton();
            this._TbDay = new System.Windows.Forms.TextBox();
            this._TbMonth = new System.Windows.Forms.TextBox();
            this._LbResultDescr = new System.Windows.Forms.Label();
            this._LbResultPredict = new System.Windows.Forms.Label();
            this._BtnIncrease = new System.Windows.Forms.Button();
            this._BtnDecrease = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this._TbNumThree = new System.Windows.Forms.TextBox();
            this._BtnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _LvRawData
            // 
            this._LvRawData.AllowColumnReorder = true;
            this._LvRawData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._LvRawData.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this._LvRawData.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._LvRawData.Location = new System.Drawing.Point(95, 21);
            this._LvRawData.Name = "_LvRawData";
            this._LvRawData.Size = new System.Drawing.Size(388, 500);
            this._LvRawData.TabIndex = 0;
            this._LvRawData.UseCompatibleStateImageBehavior = false;
            this._LvRawData.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "年";
            this.columnHeader1.Width = 40;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "期";
            this.columnHeader2.Width = 46;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "1";
            this.columnHeader3.Width = 40;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "2";
            this.columnHeader4.Width = 40;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "3";
            this.columnHeader5.Width = 40;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "4";
            this.columnHeader6.Width = 40;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "5";
            this.columnHeader7.Width = 40;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "6";
            this.columnHeader8.Width = 40;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "特";
            this.columnHeader9.Width = 40;
            // 
            // _TbNumOne
            // 
            this._TbNumOne.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._TbNumOne.Location = new System.Drawing.Point(19, 53);
            this._TbNumOne.Name = "_TbNumOne";
            this._TbNumOne.Size = new System.Drawing.Size(40, 36);
            this._TbNumOne.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(8, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "數字一";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(7, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "數字二";
            // 
            // _TbNumTwo
            // 
            this._TbNumTwo.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._TbNumTwo.Location = new System.Drawing.Point(18, 135);
            this._TbNumTwo.Name = "_TbNumTwo";
            this._TbNumTwo.Size = new System.Drawing.Size(40, 36);
            this._TbNumTwo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(8, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "往下數";
            // 
            // _TbNumCount
            // 
            this._TbNumCount.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._TbNumCount.Location = new System.Drawing.Point(18, 304);
            this._TbNumCount.Name = "_TbNumCount";
            this._TbNumCount.Size = new System.Drawing.Size(40, 36);
            this._TbNumCount.TabIndex = 7;
            // 
            // _TbNewNum2
            // 
            this._TbNewNum2.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._TbNewNum2.Location = new System.Drawing.Point(207, 540);
            this._TbNewNum2.Name = "_TbNewNum2";
            this._TbNewNum2.Size = new System.Drawing.Size(40, 36);
            this._TbNewNum2.TabIndex = 29;
            // 
            // _TbNewNum1
            // 
            this._TbNewNum1.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._TbNewNum1.Location = new System.Drawing.Point(161, 540);
            this._TbNewNum1.Name = "_TbNewNum1";
            this._TbNewNum1.Size = new System.Drawing.Size(40, 36);
            this._TbNewNum1.TabIndex = 28;
            // 
            // _TbNewNum6
            // 
            this._TbNewNum6.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._TbNewNum6.Location = new System.Drawing.Point(391, 539);
            this._TbNewNum6.Name = "_TbNewNum6";
            this._TbNewNum6.Size = new System.Drawing.Size(40, 36);
            this._TbNewNum6.TabIndex = 33;
            // 
            // _TbNewNum5
            // 
            this._TbNewNum5.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._TbNewNum5.Location = new System.Drawing.Point(345, 540);
            this._TbNewNum5.Name = "_TbNewNum5";
            this._TbNewNum5.Size = new System.Drawing.Size(40, 36);
            this._TbNewNum5.TabIndex = 32;
            // 
            // _TbNewNum4
            // 
            this._TbNewNum4.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._TbNewNum4.Location = new System.Drawing.Point(299, 540);
            this._TbNewNum4.Name = "_TbNewNum4";
            this._TbNewNum4.Size = new System.Drawing.Size(40, 36);
            this._TbNewNum4.TabIndex = 31;
            // 
            // _TbNewNum3
            // 
            this._TbNewNum3.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._TbNewNum3.Location = new System.Drawing.Point(253, 540);
            this._TbNewNum3.Name = "_TbNewNum3";
            this._TbNewNum3.Size = new System.Drawing.Size(40, 36);
            this._TbNewNum3.TabIndex = 30;
            // 
            // _TbNewNum7
            // 
            this._TbNewNum7.BackColor = System.Drawing.Color.LightGreen;
            this._TbNewNum7.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._TbNewNum7.Location = new System.Drawing.Point(437, 540);
            this._TbNewNum7.Name = "_TbNewNum7";
            this._TbNewNum7.Size = new System.Drawing.Size(40, 36);
            this._TbNewNum7.TabIndex = 34;
            // 
            // _BtnReadFile
            // 
            this._BtnReadFile.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._BtnReadFile.Location = new System.Drawing.Point(489, 53);
            this._BtnReadFile.Name = "_BtnReadFile";
            this._BtnReadFile.Size = new System.Drawing.Size(36, 48);
            this._BtnReadFile.TabIndex = 16;
            this._BtnReadFile.Text = "讀";
            this._BtnReadFile.UseVisualStyleBackColor = true;
            this._BtnReadFile.Click += new System.EventHandler(this.ReadFileBtn_Click);
            // 
            // _BtnSaveFile
            // 
            this._BtnSaveFile.Enabled = false;
            this._BtnSaveFile.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._BtnSaveFile.Location = new System.Drawing.Point(489, 135);
            this._BtnSaveFile.Name = "_BtnSaveFile";
            this._BtnSaveFile.Size = new System.Drawing.Size(36, 48);
            this._BtnSaveFile.TabIndex = 17;
            this._BtnSaveFile.Text = "存";
            this._BtnSaveFile.UseVisualStyleBackColor = true;
            this._BtnSaveFile.Click += new System.EventHandler(this.SaveFileBtn_Click);
            // 
            // _BtnDeleteItem
            // 
            this._BtnDeleteItem.Enabled = false;
            this._BtnDeleteItem.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._BtnDeleteItem.Location = new System.Drawing.Point(489, 217);
            this._BtnDeleteItem.Name = "_BtnDeleteItem";
            this._BtnDeleteItem.Size = new System.Drawing.Size(36, 48);
            this._BtnDeleteItem.TabIndex = 18;
            this._BtnDeleteItem.Text = "刪";
            this._BtnDeleteItem.UseVisualStyleBackColor = true;
            this._BtnDeleteItem.Click += new System.EventHandler(this._BtnDeleteItem_Click);
            // 
            // _BtnAddRecord
            // 
            this._BtnAddRecord.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._BtnAddRecord.Location = new System.Drawing.Point(494, 530);
            this._BtnAddRecord.Name = "_BtnAddRecord";
            this._BtnAddRecord.Size = new System.Drawing.Size(36, 48);
            this._BtnAddRecord.TabIndex = 35;
            this._BtnAddRecord.Text = "加";
            this._BtnAddRecord.UseVisualStyleBackColor = true;
            this._BtnAddRecord.Click += new System.EventHandler(this.AddRecordBtn_Click);
            // 
            // _BtnQuery
            // 
            this._BtnQuery.Enabled = false;
            this._BtnQuery.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._BtnQuery.Location = new System.Drawing.Point(10, 364);
            this._BtnQuery.Name = "_BtnQuery";
            this._BtnQuery.Size = new System.Drawing.Size(36, 48);
            this._BtnQuery.TabIndex = 8;
            this._BtnQuery.Text = "查";
            this._BtnQuery.UseVisualStyleBackColor = true;
            this._BtnQuery.Click += new System.EventHandler(this.QueryBtn_Click);
            // 
            // _LvResultData
            // 
            this._LvResultData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._LvResultData.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader16,
            this.columnHeader17,
            this.columnHeader18});
            this._LvResultData.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._LvResultData.Location = new System.Drawing.Point(532, 21);
            this._LvResultData.Name = "_LvResultData";
            this._LvResultData.Size = new System.Drawing.Size(385, 500);
            this._LvResultData.TabIndex = 21;
            this._LvResultData.UseCompatibleStateImageBehavior = false;
            this._LvResultData.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "年";
            this.columnHeader10.Width = 40;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "期";
            this.columnHeader11.Width = 47;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "1";
            this.columnHeader12.Width = 40;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "2";
            this.columnHeader13.Width = 40;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "3";
            this.columnHeader14.Width = 40;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "4";
            this.columnHeader15.Width = 40;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "5";
            this.columnHeader16.Width = 40;
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "6";
            this.columnHeader17.Width = 40;
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "特";
            this.columnHeader18.Width = 40;
            // 
            // _BtnColored
            // 
            this._BtnColored.Enabled = false;
            this._BtnColored.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._BtnColored.Location = new System.Drawing.Point(920, 183);
            this._BtnColored.Name = "_BtnColored";
            this._BtnColored.Size = new System.Drawing.Size(64, 48);
            this._BtnColored.TabIndex = 23;
            this._BtnColored.Text = "上色";
            this._BtnColored.UseVisualStyleBackColor = true;
            this._BtnColored.Click += new System.EventHandler(this.ColoredBtn_Click);
            // 
            // _TbColoredNum
            // 
            this._TbColoredNum.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._TbColoredNum.Location = new System.Drawing.Point(932, 132);
            this._TbColoredNum.Name = "_TbColoredNum";
            this._TbColoredNum.Size = new System.Drawing.Size(40, 36);
            this._TbColoredNum.TabIndex = 22;
            // 
            // _RbOrder
            // 
            this._RbOrder.AutoSize = true;
            this._RbOrder.Checked = true;
            this._RbOrder.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._RbOrder.Location = new System.Drawing.Point(10, 461);
            this._RbOrder.Name = "_RbOrder";
            this._RbOrder.Size = new System.Drawing.Size(70, 25);
            this._RbOrder.TabIndex = 24;
            this._RbOrder.TabStop = true;
            this._RbOrder.Text = "順序";
            this._RbOrder.UseVisualStyleBackColor = true;
            this._RbOrder.CheckedChanged += new System.EventHandler(this._RbOrder_CheckedChanged);
            // 
            // _RbSize
            // 
            this._RbSize.AutoSize = true;
            this._RbSize.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._RbSize.Location = new System.Drawing.Point(10, 492);
            this._RbSize.Name = "_RbSize";
            this._RbSize.Size = new System.Drawing.Size(70, 25);
            this._RbSize.TabIndex = 25;
            this._RbSize.Text = "大小";
            this._RbSize.UseVisualStyleBackColor = true;
            this._RbSize.CheckedChanged += new System.EventHandler(this._RbSize_CheckedChanged);
            // 
            // _TbDay
            // 
            this._TbDay.BackColor = System.Drawing.Color.Yellow;
            this._TbDay.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._TbDay.Location = new System.Drawing.Point(115, 539);
            this._TbDay.Name = "_TbDay";
            this._TbDay.Size = new System.Drawing.Size(40, 36);
            this._TbDay.TabIndex = 27;
            // 
            // _TbMonth
            // 
            this._TbMonth.BackColor = System.Drawing.Color.Yellow;
            this._TbMonth.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._TbMonth.Location = new System.Drawing.Point(69, 539);
            this._TbMonth.Name = "_TbMonth";
            this._TbMonth.Size = new System.Drawing.Size(40, 36);
            this._TbMonth.TabIndex = 26;
            // 
            // _LbResultDescr
            // 
            this._LbResultDescr.AutoSize = true;
            this._LbResultDescr.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._LbResultDescr.Location = new System.Drawing.Point(536, 524);
            this._LbResultDescr.MaximumSize = new System.Drawing.Size(200, 0);
            this._LbResultDescr.Name = "_LbResultDescr";
            this._LbResultDescr.Size = new System.Drawing.Size(52, 21);
            this._LbResultDescr.TabIndex = 28;
            this._LbResultDescr.Text = "描述";
            // 
            // _LbResultPredict
            // 
            this._LbResultPredict.AutoSize = true;
            this._LbResultPredict.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._LbResultPredict.Location = new System.Drawing.Point(770, 524);
            this._LbResultPredict.MaximumSize = new System.Drawing.Size(220, 0);
            this._LbResultPredict.Name = "_LbResultPredict";
            this._LbResultPredict.Size = new System.Drawing.Size(52, 21);
            this._LbResultPredict.TabIndex = 29;
            this._LbResultPredict.Tag = "";
            this._LbResultPredict.Text = "統計";
            // 
            // _BtnIncrease
            // 
            this._BtnIncrease.Enabled = false;
            this._BtnIncrease.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._BtnIncrease.Location = new System.Drawing.Point(744, 527);
            this._BtnIncrease.Name = "_BtnIncrease";
            this._BtnIncrease.Size = new System.Drawing.Size(26, 48);
            this._BtnIncrease.TabIndex = 41;
            this._BtnIncrease.Text = ">";
            this._BtnIncrease.UseVisualStyleBackColor = true;
            this._BtnIncrease.Click += new System.EventHandler(this._BtnIncrease_Click);
            // 
            // _BtnDecrease
            // 
            this._BtnDecrease.Enabled = false;
            this._BtnDecrease.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._BtnDecrease.Location = new System.Drawing.Point(715, 527);
            this._BtnDecrease.Name = "_BtnDecrease";
            this._BtnDecrease.Size = new System.Drawing.Size(26, 48);
            this._BtnDecrease.TabIndex = 40;
            this._BtnDecrease.Text = "<";
            this._BtnDecrease.UseVisualStyleBackColor = true;
            this._BtnDecrease.Click += new System.EventHandler(this._BtnDecrease_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(8, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 21);
            this.label4.TabIndex = 37;
            this.label4.Text = "數字三";
            // 
            // _TbNumThree
            // 
            this._TbNumThree.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._TbNumThree.Location = new System.Drawing.Point(19, 217);
            this._TbNumThree.Name = "_TbNumThree";
            this._TbNumThree.Size = new System.Drawing.Size(40, 36);
            this._TbNumThree.TabIndex = 5;
            // 
            // _BtnClear
            // 
            this._BtnClear.Enabled = false;
            this._BtnClear.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._BtnClear.Location = new System.Drawing.Point(49, 364);
            this._BtnClear.Name = "_BtnClear";
            this._BtnClear.Size = new System.Drawing.Size(36, 48);
            this._BtnClear.TabIndex = 42;
            this._BtnClear.Text = "清";
            this._BtnClear.UseVisualStyleBackColor = true;
            this._BtnClear.Click += new System.EventHandler(this._BtnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 601);
            this.Controls.Add(this._BtnClear);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._TbNumThree);
            this.Controls.Add(this._BtnDecrease);
            this.Controls.Add(this._BtnIncrease);
            this.Controls.Add(this._LbResultPredict);
            this.Controls.Add(this._LbResultDescr);
            this.Controls.Add(this._TbDay);
            this.Controls.Add(this._TbMonth);
            this.Controls.Add(this._RbSize);
            this.Controls.Add(this._RbOrder);
            this.Controls.Add(this._BtnColored);
            this.Controls.Add(this._TbColoredNum);
            this.Controls.Add(this._LvResultData);
            this.Controls.Add(this._BtnQuery);
            this.Controls.Add(this._BtnAddRecord);
            this.Controls.Add(this._BtnDeleteItem);
            this.Controls.Add(this._BtnSaveFile);
            this.Controls.Add(this._BtnReadFile);
            this.Controls.Add(this._TbNewNum7);
            this.Controls.Add(this._TbNewNum6);
            this.Controls.Add(this._TbNewNum5);
            this.Controls.Add(this._TbNewNum4);
            this.Controls.Add(this._TbNewNum3);
            this.Controls.Add(this._TbNewNum2);
            this.Controls.Add(this._TbNewNum1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._TbNumCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._TbNumTwo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._TbNumOne);
            this.Controls.Add(this._LvRawData);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView _LvRawData;
        private System.Windows.Forms.TextBox _TbNumOne;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _TbNumTwo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox _TbNumCount;
        private System.Windows.Forms.TextBox _TbNewNum2;
        private System.Windows.Forms.TextBox _TbNewNum1;
        private System.Windows.Forms.TextBox _TbNewNum6;
        private System.Windows.Forms.TextBox _TbNewNum5;
        private System.Windows.Forms.TextBox _TbNewNum4;
        private System.Windows.Forms.TextBox _TbNewNum3;
        private System.Windows.Forms.TextBox _TbNewNum7;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.Button _BtnReadFile;
        private System.Windows.Forms.Button _BtnSaveFile;
        private System.Windows.Forms.Button _BtnDeleteItem;
        private System.Windows.Forms.Button _BtnAddRecord;
        private System.Windows.Forms.Button _BtnQuery;
        private System.Windows.Forms.ListView _LvResultData;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.Button _BtnColored;
        private System.Windows.Forms.TextBox _TbColoredNum;
        private System.Windows.Forms.RadioButton _RbOrder;
        private System.Windows.Forms.RadioButton _RbSize;
        private System.Windows.Forms.TextBox _TbDay;
        private System.Windows.Forms.TextBox _TbMonth;
        private System.Windows.Forms.Label _LbResultDescr;
        private System.Windows.Forms.Label _LbResultPredict;
        private System.Windows.Forms.Button _BtnIncrease;
        private System.Windows.Forms.Button _BtnDecrease;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox _TbNumThree;
        private System.Windows.Forms.Button _BtnClear;

    }
}

