namespace prepare_oracle
{
    partial class ControlOracle
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.StartOracle = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.OracleStatus = new System.Windows.Forms.Label();
            this.GetTable = new System.Windows.Forms.Button();
            this.ResultText = new System.Windows.Forms.TextBox();
            this.GetColName = new System.Windows.Forms.Button();
            this.colname = new System.Windows.Forms.CheckedListBox();
            this.Table_Name = new System.Windows.Forms.TextBox();
            this.TNameSelecter = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // StartOracle
            // 
            this.StartOracle.Location = new System.Drawing.Point(658, 358);
            this.StartOracle.Name = "StartOracle";
            this.StartOracle.Size = new System.Drawing.Size(130, 80);
            this.StartOracle.TabIndex = 0;
            this.StartOracle.Text = "SartOracle";
            this.StartOracle.UseVisualStyleBackColor = true;
            this.StartOracle.Click += new System.EventHandler(this.bt_StartOracle_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(522, 358);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 80);
            this.button1.TabIndex = 1;
            this.button1.Text = "ControlOracle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.bt_StoptOracle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(549, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Status:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // OracleStatus
            // 
            this.OracleStatus.Location = new System.Drawing.Point(612, 41);
            this.OracleStatus.Name = "OracleStatus";
            this.OracleStatus.Size = new System.Drawing.Size(104, 18);
            this.OracleStatus.TabIndex = 3;
            this.OracleStatus.Text = "label2";
            this.OracleStatus.Click += new System.EventHandler(this.label2_Click);
            // 
            // GetTable
            // 
            this.GetTable.Location = new System.Drawing.Point(522, 315);
            this.GetTable.Name = "GetTable";
            this.GetTable.Size = new System.Drawing.Size(266, 37);
            this.GetTable.TabIndex = 4;
            this.GetTable.Text = "GetTable";
            this.GetTable.UseVisualStyleBackColor = true;
            this.GetTable.Click += new System.EventHandler(this.bt_GetTable_Click);
            // 
            // ResultText
            // 
            this.ResultText.Location = new System.Drawing.Point(12, 194);
            this.ResultText.Multiline = true;
            this.ResultText.Name = "ResultText";
            this.ResultText.Size = new System.Drawing.Size(504, 244);
            this.ResultText.TabIndex = 5;
            this.ResultText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // GetColName
            // 
            this.GetColName.Location = new System.Drawing.Point(522, 272);
            this.GetColName.Name = "GetColName";
            this.GetColName.Size = new System.Drawing.Size(266, 37);
            this.GetColName.TabIndex = 6;
            this.GetColName.Text = "Get Col Name";
            this.GetColName.UseVisualStyleBackColor = true;
            this.GetColName.Click += new System.EventHandler(this.GetColName_Click);
            // 
            // colname
            // 
            this.colname.FormattingEnabled = true;
            this.colname.Location = new System.Drawing.Point(12, 12);
            this.colname.Name = "colname";
            this.colname.Size = new System.Drawing.Size(237, 158);
            this.colname.TabIndex = 7;
            this.colname.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // Table_Name
            // 
            this.Table_Name.Location = new System.Drawing.Point(522, 241);
            this.Table_Name.Name = "Table_Name";
            this.Table_Name.Size = new System.Drawing.Size(266, 25);
            this.Table_Name.TabIndex = 8;
            this.Table_Name.Text = "emp";
            this.Table_Name.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // TNameSelecter
            // 
            this.TNameSelecter.FormattingEnabled = true;
            this.TNameSelecter.Location = new System.Drawing.Point(522, 209);
            this.TNameSelecter.Name = "TNameSelecter";
            this.TNameSelecter.Size = new System.Drawing.Size(266, 26);
            this.TNameSelecter.TabIndex = 9;
            this.TNameSelecter.SelectedIndexChanged += new System.EventHandler(this.TNameSelecter_SelectedIndexChanged);
            // 
            // ControlOracle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TNameSelecter);
            this.Controls.Add(this.Table_Name);
            this.Controls.Add(this.colname);
            this.Controls.Add(this.GetColName);
            this.Controls.Add(this.ResultText);
            this.Controls.Add(this.GetTable);
            this.Controls.Add(this.OracleStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.StartOracle);
            this.Name = "ControlOracle";
            this.Text = "Prepare Oracle";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartOracle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label OracleStatus;
        private System.Windows.Forms.Button GetTable;
        private System.Windows.Forms.TextBox ResultText;
        private System.Windows.Forms.Button GetColName;
        private System.Windows.Forms.CheckedListBox colname;
        private System.Windows.Forms.TextBox Table_Name;
        private System.Windows.Forms.ComboBox TNameSelecter;
    }
}

