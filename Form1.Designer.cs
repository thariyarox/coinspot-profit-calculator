namespace CoinSpotProfitCalculator
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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtBuyingRate = new System.Windows.Forms.TextBox();
            this.txtSellingRate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtInvestmentAmount = new System.Windows.Forms.TextBox();
            this.lblTotalSale = new System.Windows.Forms.Label();
            this.lblTotalProfit = new System.Windows.Forms.Label();
            this.lblGrowthPercentage = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buying Price (Per Coin)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Selling Price (Per Coin)";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(265, 221);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(88, 23);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtBuyingRate
            // 
            this.txtBuyingRate.Location = new System.Drawing.Point(265, 54);
            this.txtBuyingRate.Name = "txtBuyingRate";
            this.txtBuyingRate.Size = new System.Drawing.Size(272, 22);
            this.txtBuyingRate.TabIndex = 3;
            // 
            // txtSellingRate
            // 
            this.txtSellingRate.Location = new System.Drawing.Point(265, 107);
            this.txtSellingRate.Name = "txtSellingRate";
            this.txtSellingRate.Size = new System.Drawing.Size(272, 22);
            this.txtSellingRate.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Investment Amount";
            // 
            // txtInvestmentAmount
            // 
            this.txtInvestmentAmount.Location = new System.Drawing.Point(265, 165);
            this.txtInvestmentAmount.Name = "txtInvestmentAmount";
            this.txtInvestmentAmount.Size = new System.Drawing.Size(272, 22);
            this.txtInvestmentAmount.TabIndex = 6;
            // 
            // lblTotalSale
            // 
            this.lblTotalSale.AutoSize = true;
            this.lblTotalSale.Location = new System.Drawing.Point(262, 284);
            this.lblTotalSale.Name = "lblTotalSale";
            this.lblTotalSale.Size = new System.Drawing.Size(72, 17);
            this.lblTotalSale.TabIndex = 7;
            this.lblTotalSale.Text = "Total Sale";
            // 
            // lblTotalProfit
            // 
            this.lblTotalProfit.AutoSize = true;
            this.lblTotalProfit.Location = new System.Drawing.Point(262, 334);
            this.lblTotalProfit.Name = "lblTotalProfit";
            this.lblTotalProfit.Size = new System.Drawing.Size(77, 17);
            this.lblTotalProfit.TabIndex = 8;
            this.lblTotalProfit.Text = "Total Profit";
            // 
            // lblGrowthPercentage
            // 
            this.lblGrowthPercentage.AutoSize = true;
            this.lblGrowthPercentage.Location = new System.Drawing.Point(262, 379);
            this.lblGrowthPercentage.Name = "lblGrowthPercentage";
            this.lblGrowthPercentage.Size = new System.Drawing.Size(130, 17);
            this.lblGrowthPercentage.TabIndex = 9;
            this.lblGrowthPercentage.Text = "Growth Percentage";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Total Sale";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(83, 334);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Total Profit";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(83, 379);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Growth Percentage";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblGrowthPercentage);
            this.Controls.Add(this.lblTotalProfit);
            this.Controls.Add(this.lblTotalSale);
            this.Controls.Add(this.txtInvestmentAmount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSellingRate);
            this.Controls.Add(this.txtBuyingRate);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "CoinSpot Profit Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtBuyingRate;
        private System.Windows.Forms.TextBox txtSellingRate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtInvestmentAmount;
        private System.Windows.Forms.Label lblTotalSale;
        private System.Windows.Forms.Label lblTotalProfit;
        private System.Windows.Forms.Label lblGrowthPercentage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

