namespace Pos
{
    partial class Sale_Status
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
            this.lb_Sale_cost = new System.Windows.Forms.Label();
            this.lb_profit = new System.Windows.Forms.Label();
            this.tb_Sale_cost = new System.Windows.Forms.TextBox();
            this.tb_profit = new System.Windows.Forms.TextBox();
            this.btn_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_Sale_cost
            // 
            this.lb_Sale_cost.AutoSize = true;
            this.lb_Sale_cost.Font = new System.Drawing.Font("굴림", 13F);
            this.lb_Sale_cost.Location = new System.Drawing.Point(21, 75);
            this.lb_Sale_cost.Name = "lb_Sale_cost";
            this.lb_Sale_cost.Size = new System.Drawing.Size(62, 18);
            this.lb_Sale_cost.TabIndex = 0;
            this.lb_Sale_cost.Text = "매출액";
            // 
            // lb_profit
            // 
            this.lb_profit.AutoSize = true;
            this.lb_profit.Font = new System.Drawing.Font("굴림", 13F);
            this.lb_profit.Location = new System.Drawing.Point(228, 75);
            this.lb_profit.Name = "lb_profit";
            this.lb_profit.Size = new System.Drawing.Size(62, 18);
            this.lb_profit.TabIndex = 1;
            this.lb_profit.Text = "순이익";
            // 
            // tb_Sale_cost
            // 
            this.tb_Sale_cost.Location = new System.Drawing.Point(89, 77);
            this.tb_Sale_cost.Name = "tb_Sale_cost";
            this.tb_Sale_cost.Size = new System.Drawing.Size(123, 21);
            this.tb_Sale_cost.TabIndex = 2;
            // 
            // tb_profit
            // 
            this.tb_profit.Location = new System.Drawing.Point(296, 77);
            this.tb_profit.Name = "tb_profit";
            this.tb_profit.Size = new System.Drawing.Size(123, 21);
            this.tb_profit.TabIndex = 3;
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(177, 138);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(113, 44);
            this.btn_close.TabIndex = 4;
            this.btn_close.Text = "닫기";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // Sale_Status
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 194);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.tb_profit);
            this.Controls.Add(this.tb_Sale_cost);
            this.Controls.Add(this.lb_profit);
            this.Controls.Add(this.lb_Sale_cost);
            this.Name = "Sale_Status";
            this.Text = "매출 현황";
            this.Load += new System.EventHandler(this.Sale_Status_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Sale_cost;
        private System.Windows.Forms.Label lb_profit;
        private System.Windows.Forms.TextBox tb_Sale_cost;
        private System.Windows.Forms.TextBox tb_profit;
        private System.Windows.Forms.Button btn_close;
    }
}