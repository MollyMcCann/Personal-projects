namespace NetWorthCalculator
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
            this.Titlelbl = new System.Windows.Forms.Label();
            this.assetlbl = new System.Windows.Forms.Label();
            this.Liabilitieslbl = new System.Windows.Forms.Label();
            this.fundslbl = new System.Windows.Forms.Label();
            this.propertiesLbl = new System.Windows.Forms.Label();
            this.retirementlbl = new System.Windows.Forms.Label();
            this.debtLbl = new System.Windows.Forms.Label();
            this.mortgageLbl = new System.Windows.Forms.Label();
            this.billLbl = new System.Windows.Forms.Label();
            this.fundsTextBox = new System.Windows.Forms.TextBox();
            this.propertiesTextBox = new System.Windows.Forms.TextBox();
            this.retirementTextbox = new System.Windows.Forms.TextBox();
            this.debtTextBox = new System.Windows.Forms.TextBox();
            this.mortgageTextbox = new System.Windows.Forms.TextBox();
            this.billsTextBox = new System.Windows.Forms.TextBox();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.caculatebtn = new System.Windows.Forms.Button();
            this.netWorthLbL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Titlelbl
            // 
            this.Titlelbl.AutoSize = true;
            this.Titlelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titlelbl.Location = new System.Drawing.Point(254, 9);
            this.Titlelbl.Name = "Titlelbl";
            this.Titlelbl.Size = new System.Drawing.Size(262, 25);
            this.Titlelbl.TabIndex = 0;
            this.Titlelbl.Text = "Let\'s Find Your net Worth!";
            // 
            // assetlbl
            // 
            this.assetlbl.AutoSize = true;
            this.assetlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assetlbl.Location = new System.Drawing.Point(46, 60);
            this.assetlbl.Name = "assetlbl";
            this.assetlbl.Size = new System.Drawing.Size(65, 24);
            this.assetlbl.TabIndex = 1;
            this.assetlbl.Text = "Assets";
            // 
            // Liabilitieslbl
            // 
            this.Liabilitieslbl.AutoSize = true;
            this.Liabilitieslbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Liabilitieslbl.Location = new System.Drawing.Point(573, 60);
            this.Liabilitieslbl.Name = "Liabilitieslbl";
            this.Liabilitieslbl.Size = new System.Drawing.Size(85, 24);
            this.Liabilitieslbl.TabIndex = 2;
            this.Liabilitieslbl.Text = "Liabilities";
            // 
            // fundslbl
            // 
            this.fundslbl.AutoSize = true;
            this.fundslbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fundslbl.Location = new System.Drawing.Point(12, 103);
            this.fundslbl.Name = "fundslbl";
            this.fundslbl.Size = new System.Drawing.Size(141, 20);
            this.fundslbl.TabIndex = 3;
            this.fundslbl.Text = "Funds in Accounts";
            // 
            // propertiesLbl
            // 
            this.propertiesLbl.AutoSize = true;
            this.propertiesLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.propertiesLbl.Location = new System.Drawing.Point(12, 152);
            this.propertiesLbl.Name = "propertiesLbl";
            this.propertiesLbl.Size = new System.Drawing.Size(81, 20);
            this.propertiesLbl.TabIndex = 4;
            this.propertiesLbl.Text = "Properties";
            // 
            // retirementlbl
            // 
            this.retirementlbl.AutoSize = true;
            this.retirementlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retirementlbl.Location = new System.Drawing.Point(12, 205);
            this.retirementlbl.Name = "retirementlbl";
            this.retirementlbl.Size = new System.Drawing.Size(148, 20);
            this.retirementlbl.TabIndex = 5;
            this.retirementlbl.Text = "Retirement Savings";
            // 
            // debtLbl
            // 
            this.debtLbl.AutoSize = true;
            this.debtLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debtLbl.Location = new System.Drawing.Point(444, 103);
            this.debtLbl.Name = "debtLbl";
            this.debtLbl.Size = new System.Drawing.Size(44, 20);
            this.debtLbl.TabIndex = 6;
            this.debtLbl.Text = "Debt";
            // 
            // mortgageLbl
            // 
            this.mortgageLbl.AutoSize = true;
            this.mortgageLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mortgageLbl.Location = new System.Drawing.Point(444, 152);
            this.mortgageLbl.Name = "mortgageLbl";
            this.mortgageLbl.Size = new System.Drawing.Size(77, 20);
            this.mortgageLbl.TabIndex = 7;
            this.mortgageLbl.Text = "Mortgage";
            // 
            // billLbl
            // 
            this.billLbl.AutoSize = true;
            this.billLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billLbl.Location = new System.Drawing.Point(444, 205);
            this.billLbl.Name = "billLbl";
            this.billLbl.Size = new System.Drawing.Size(37, 20);
            this.billLbl.TabIndex = 8;
            this.billLbl.Text = "Bills";
            // 
            // fundsTextBox
            // 
            this.fundsTextBox.Location = new System.Drawing.Point(201, 103);
            this.fundsTextBox.Name = "fundsTextBox";
            this.fundsTextBox.Size = new System.Drawing.Size(100, 20);
            this.fundsTextBox.TabIndex = 9;
            // 
            // propertiesTextBox
            // 
            this.propertiesTextBox.Location = new System.Drawing.Point(201, 154);
            this.propertiesTextBox.Name = "propertiesTextBox";
            this.propertiesTextBox.Size = new System.Drawing.Size(100, 20);
            this.propertiesTextBox.TabIndex = 10;
            // 
            // retirementTextbox
            // 
            this.retirementTextbox.Location = new System.Drawing.Point(201, 205);
            this.retirementTextbox.Name = "retirementTextbox";
            this.retirementTextbox.Size = new System.Drawing.Size(100, 20);
            this.retirementTextbox.TabIndex = 11;
            // 
            // debtTextBox
            // 
            this.debtTextBox.Location = new System.Drawing.Point(577, 103);
            this.debtTextBox.Name = "debtTextBox";
            this.debtTextBox.Size = new System.Drawing.Size(100, 20);
            this.debtTextBox.TabIndex = 12;
            // 
            // mortgageTextbox
            // 
            this.mortgageTextbox.Location = new System.Drawing.Point(577, 152);
            this.mortgageTextbox.Name = "mortgageTextbox";
            this.mortgageTextbox.Size = new System.Drawing.Size(100, 20);
            this.mortgageTextbox.TabIndex = 13;
            // 
            // billsTextBox
            // 
            this.billsTextBox.Location = new System.Drawing.Point(577, 205);
            this.billsTextBox.Name = "billsTextBox";
            this.billsTextBox.Size = new System.Drawing.Size(100, 20);
            this.billsTextBox.TabIndex = 14;
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(156, 338);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(110, 32);
            this.ClearBtn.TabIndex = 15;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // caculatebtn
            // 
            this.caculatebtn.Location = new System.Drawing.Point(16, 338);
            this.caculatebtn.Name = "caculatebtn";
            this.caculatebtn.Size = new System.Drawing.Size(110, 32);
            this.caculatebtn.TabIndex = 16;
            this.caculatebtn.Text = "Calculate";
            this.caculatebtn.UseVisualStyleBackColor = true;
            this.caculatebtn.Click += new System.EventHandler(this.caculatebtn_Click);
            // 
            // netWorthLbL
            // 
            this.netWorthLbL.AutoSize = true;
            this.netWorthLbL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.netWorthLbL.Location = new System.Drawing.Point(526, 346);
            this.netWorthLbL.Name = "netWorthLbL";
            this.netWorthLbL.Size = new System.Drawing.Size(94, 24);
            this.netWorthLbL.TabIndex = 17;
            this.netWorthLbL.Text = "Net Worth";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.netWorthLbL);
            this.Controls.Add(this.caculatebtn);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.billsTextBox);
            this.Controls.Add(this.mortgageTextbox);
            this.Controls.Add(this.debtTextBox);
            this.Controls.Add(this.retirementTextbox);
            this.Controls.Add(this.propertiesTextBox);
            this.Controls.Add(this.fundsTextBox);
            this.Controls.Add(this.billLbl);
            this.Controls.Add(this.mortgageLbl);
            this.Controls.Add(this.debtLbl);
            this.Controls.Add(this.retirementlbl);
            this.Controls.Add(this.propertiesLbl);
            this.Controls.Add(this.fundslbl);
            this.Controls.Add(this.Liabilitieslbl);
            this.Controls.Add(this.assetlbl);
            this.Controls.Add(this.Titlelbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titlelbl;
        private System.Windows.Forms.Label assetlbl;
        private System.Windows.Forms.Label Liabilitieslbl;
        private System.Windows.Forms.Label fundslbl;
        private System.Windows.Forms.Label propertiesLbl;
        private System.Windows.Forms.Label retirementlbl;
        private System.Windows.Forms.Label debtLbl;
        private System.Windows.Forms.Label mortgageLbl;
        private System.Windows.Forms.Label billLbl;
        private System.Windows.Forms.TextBox fundsTextBox;
        private System.Windows.Forms.TextBox propertiesTextBox;
        private System.Windows.Forms.TextBox retirementTextbox;
        private System.Windows.Forms.TextBox debtTextBox;
        private System.Windows.Forms.TextBox mortgageTextbox;
        private System.Windows.Forms.TextBox billsTextBox;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button caculatebtn;
        private System.Windows.Forms.Label netWorthLbL;
    }
}

