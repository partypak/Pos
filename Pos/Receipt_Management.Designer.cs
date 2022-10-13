namespace Pos
{
    partial class Receipt_Management
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
            this.lb_business_day = new System.Windows.Forms.Label();
            this.lb_receipt_number = new System.Windows.Forms.Label();
            this.tb_receipt_number = new System.Windows.Forms.TextBox();
            this.tb_business_day = new System.Windows.Forms.TextBox();
            this.lv_receipt_list = new System.Windows.Forms.ListView();
            this.receipt_number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.payment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cash = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Card = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.refund = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tb_receipt = new System.Windows.Forms.TextBox();
            this.btn_reprint = new System.Windows.Forms.Button();
            this.btn_refund = new System.Windows.Forms.Button();
            this.receipt_Date = new System.Windows.Forms.DateTimePicker();
            this.btn_receipt_close = new System.Windows.Forms.Button();
            this.btn_Sreach = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_business_day
            // 
            this.lb_business_day.AutoSize = true;
            this.lb_business_day.Location = new System.Drawing.Point(35, 37);
            this.lb_business_day.Name = "lb_business_day";
            this.lb_business_day.Size = new System.Drawing.Size(53, 12);
            this.lb_business_day.TabIndex = 0;
            this.lb_business_day.Text = "영업일자";
            // 
            // lb_receipt_number
            // 
            this.lb_receipt_number.AutoSize = true;
            this.lb_receipt_number.Location = new System.Drawing.Point(35, 94);
            this.lb_receipt_number.Name = "lb_receipt_number";
            this.lb_receipt_number.Size = new System.Drawing.Size(69, 12);
            this.lb_receipt_number.TabIndex = 2;
            this.lb_receipt_number.Text = "영수증 번호";
            // 
            // tb_receipt_number
            // 
            this.tb_receipt_number.Location = new System.Drawing.Point(119, 91);
            this.tb_receipt_number.Name = "tb_receipt_number";
            this.tb_receipt_number.Size = new System.Drawing.Size(100, 21);
            this.tb_receipt_number.TabIndex = 3;
            this.tb_receipt_number.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tb_business_day
            // 
            this.tb_business_day.Enabled = false;
            this.tb_business_day.Location = new System.Drawing.Point(103, 34);
            this.tb_business_day.Name = "tb_business_day";
            this.tb_business_day.Size = new System.Drawing.Size(152, 21);
            this.tb_business_day.TabIndex = 4;
            this.tb_business_day.TextChanged += new System.EventHandler(this.tb_business_day_TextChanged);
            // 
            // lv_receipt_list
            // 
            this.lv_receipt_list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.receipt_number,
            this.payment,
            this.cash,
            this.Card,
            this.refund});
            this.lv_receipt_list.HideSelection = false;
            this.lv_receipt_list.Location = new System.Drawing.Point(12, 148);
            this.lv_receipt_list.Name = "lv_receipt_list";
            this.lv_receipt_list.Size = new System.Drawing.Size(512, 213);
            this.lv_receipt_list.TabIndex = 6;
            this.lv_receipt_list.UseCompatibleStateImageBehavior = false;
            this.lv_receipt_list.View = System.Windows.Forms.View.Details;
            this.lv_receipt_list.SelectedIndexChanged += new System.EventHandler(this.lv_receipt_list_SelectedIndexChanged);
            // 
            // receipt_number
            // 
            this.receipt_number.Text = "영수번호";
            // 
            // payment
            // 
            this.payment.Text = "결제금액";
            // 
            // cash
            // 
            this.cash.Text = "현금";
            // 
            // Card
            // 
            this.Card.Text = "카드";
            // 
            // refund
            // 
            this.refund.Text = "환불";
            // 
            // tb_receipt
            // 
            this.tb_receipt.Location = new System.Drawing.Point(12, 387);
            this.tb_receipt.Multiline = true;
            this.tb_receipt.Name = "tb_receipt";
            this.tb_receipt.Size = new System.Drawing.Size(512, 193);
            this.tb_receipt.TabIndex = 7;
            // 
            // btn_reprint
            // 
            this.btn_reprint.Location = new System.Drawing.Point(89, 607);
            this.btn_reprint.Name = "btn_reprint";
            this.btn_reprint.Size = new System.Drawing.Size(114, 33);
            this.btn_reprint.TabIndex = 8;
            this.btn_reprint.Text = "재출력";
            this.btn_reprint.UseVisualStyleBackColor = true;
            this.btn_reprint.Click += new System.EventHandler(this.btn_reprint_Click);
            // 
            // btn_refund
            // 
            this.btn_refund.Location = new System.Drawing.Point(229, 607);
            this.btn_refund.Name = "btn_refund";
            this.btn_refund.Size = new System.Drawing.Size(114, 33);
            this.btn_refund.TabIndex = 9;
            this.btn_refund.Text = "환불";
            this.btn_refund.UseVisualStyleBackColor = true;
            this.btn_refund.Click += new System.EventHandler(this.btn_refund_Click);
            // 
            // receipt_Date
            // 
            this.receipt_Date.CustomFormat = "MM-dd";
            this.receipt_Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.receipt_Date.Location = new System.Drawing.Point(270, 34);
            this.receipt_Date.Name = "receipt_Date";
            this.receipt_Date.Size = new System.Drawing.Size(200, 21);
            this.receipt_Date.TabIndex = 10;
            this.receipt_Date.ValueChanged += new System.EventHandler(this.receipt_Date_ValueChanged);
            // 
            // btn_receipt_close
            // 
            this.btn_receipt_close.Location = new System.Drawing.Point(369, 607);
            this.btn_receipt_close.Name = "btn_receipt_close";
            this.btn_receipt_close.Size = new System.Drawing.Size(114, 33);
            this.btn_receipt_close.TabIndex = 11;
            this.btn_receipt_close.Text = "닫기";
            this.btn_receipt_close.UseVisualStyleBackColor = true;
            this.btn_receipt_close.Click += new System.EventHandler(this.btn_receipt_close_Click);
            // 
            // btn_Sreach
            // 
            this.btn_Sreach.Location = new System.Drawing.Point(246, 84);
            this.btn_Sreach.Name = "btn_Sreach";
            this.btn_Sreach.Size = new System.Drawing.Size(64, 33);
            this.btn_Sreach.TabIndex = 12;
            this.btn_Sreach.Text = "검색";
            this.btn_Sreach.UseVisualStyleBackColor = true;
            this.btn_Sreach.Click += new System.EventHandler(this.btn_Sreach_Click);
            // 
            // Receipt_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 652);
            this.Controls.Add(this.btn_Sreach);
            this.Controls.Add(this.btn_receipt_close);
            this.Controls.Add(this.receipt_Date);
            this.Controls.Add(this.btn_refund);
            this.Controls.Add(this.btn_reprint);
            this.Controls.Add(this.tb_receipt);
            this.Controls.Add(this.lv_receipt_list);
            this.Controls.Add(this.tb_business_day);
            this.Controls.Add(this.tb_receipt_number);
            this.Controls.Add(this.lb_receipt_number);
            this.Controls.Add(this.lb_business_day);
            this.Name = "Receipt_Management";
            this.Text = "영수증 내역";
            this.Load += new System.EventHandler(this.Receipt_Management_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_business_day;
        private System.Windows.Forms.Label lb_receipt_number;
        private System.Windows.Forms.TextBox tb_receipt_number;
        private System.Windows.Forms.TextBox tb_business_day;
        private System.Windows.Forms.ListView lv_receipt_list;
        private System.Windows.Forms.ColumnHeader receipt_number;
        private System.Windows.Forms.ColumnHeader payment;
        private System.Windows.Forms.ColumnHeader cash;
        private System.Windows.Forms.ColumnHeader Card;
        private System.Windows.Forms.ColumnHeader refund;
        private System.Windows.Forms.TextBox tb_receipt;
        private System.Windows.Forms.Button btn_reprint;
        private System.Windows.Forms.Button btn_refund;
        private System.Windows.Forms.DateTimePicker receipt_Date;
        private System.Windows.Forms.Button btn_receipt_close;
        private System.Windows.Forms.Button btn_Sreach;
    }
}