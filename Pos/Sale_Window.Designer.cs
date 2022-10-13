namespace Pos
{
    partial class Sale_Window
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
            this.btn_move = new System.Windows.Forms.Button();
            this.btn_receipt_mangement = new System.Windows.Forms.Button();
            this.btn_sale_status = new System.Windows.Forms.Button();
            this.btn_order_receipt = new System.Windows.Forms.Button();
            this.tb_hidden = new System.Windows.Forms.TextBox();
            this.TodayDate = new System.Windows.Forms.DateTimePicker();
            this.btn_Down = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_move
            // 
            this.btn_move.Location = new System.Drawing.Point(639, 45);
            this.btn_move.Name = "btn_move";
            this.btn_move.Size = new System.Drawing.Size(107, 74);
            this.btn_move.TabIndex = 0;
            this.btn_move.Text = "이동";
            this.btn_move.UseVisualStyleBackColor = true;
            this.btn_move.Click += new System.EventHandler(this.btn_mone_Click);
            // 
            // btn_receipt_mangement
            // 
            this.btn_receipt_mangement.Location = new System.Drawing.Point(639, 125);
            this.btn_receipt_mangement.Name = "btn_receipt_mangement";
            this.btn_receipt_mangement.Size = new System.Drawing.Size(107, 74);
            this.btn_receipt_mangement.TabIndex = 1;
            this.btn_receipt_mangement.Text = "영수증 관리";
            this.btn_receipt_mangement.UseVisualStyleBackColor = true;
            this.btn_receipt_mangement.Click += new System.EventHandler(this.btn_receipt_mangement_Click);
            // 
            // btn_sale_status
            // 
            this.btn_sale_status.Location = new System.Drawing.Point(639, 205);
            this.btn_sale_status.Name = "btn_sale_status";
            this.btn_sale_status.Size = new System.Drawing.Size(107, 74);
            this.btn_sale_status.TabIndex = 2;
            this.btn_sale_status.Text = "매출 현황";
            this.btn_sale_status.UseVisualStyleBackColor = true;
            this.btn_sale_status.Click += new System.EventHandler(this.btn_sale_status_Click);
            // 
            // btn_order_receipt
            // 
            this.btn_order_receipt.Location = new System.Drawing.Point(639, 285);
            this.btn_order_receipt.Name = "btn_order_receipt";
            this.btn_order_receipt.Size = new System.Drawing.Size(107, 74);
            this.btn_order_receipt.TabIndex = 3;
            this.btn_order_receipt.Text = "주문서 조회";
            this.btn_order_receipt.UseVisualStyleBackColor = true;
            this.btn_order_receipt.Click += new System.EventHandler(this.btn_order_receipt_Click);
            // 
            // tb_hidden
            // 
            this.tb_hidden.Location = new System.Drawing.Point(639, 12);
            this.tb_hidden.Multiline = true;
            this.tb_hidden.Name = "tb_hidden";
            this.tb_hidden.Size = new System.Drawing.Size(100, 21);
            this.tb_hidden.TabIndex = 6;
            this.tb_hidden.Visible = false;
            // 
            // TodayDate
            // 
            this.TodayDate.CustomFormat = "MM-dd";
            this.TodayDate.Enabled = false;
            this.TodayDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TodayDate.Location = new System.Drawing.Point(653, 365);
            this.TodayDate.Name = "TodayDate";
            this.TodayDate.Size = new System.Drawing.Size(86, 21);
            this.TodayDate.TabIndex = 8;
            // 
            // btn_Down
            // 
            this.btn_Down.BackColor = System.Drawing.Color.DarkGray;
            this.btn_Down.Font = new System.Drawing.Font("돋움", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Down.Location = new System.Drawing.Point(639, 392);
            this.btn_Down.Name = "btn_Down";
            this.btn_Down.Size = new System.Drawing.Size(107, 46);
            this.btn_Down.TabIndex = 74;
            this.btn_Down.Text = "이전화면";
            this.btn_Down.UseVisualStyleBackColor = false;
            this.btn_Down.Click += new System.EventHandler(this.btn_Down_Click);
            // 
            // Sale_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Down);
            this.Controls.Add(this.TodayDate);
            this.Controls.Add(this.tb_hidden);
            this.Controls.Add(this.btn_order_receipt);
            this.Controls.Add(this.btn_sale_status);
            this.Controls.Add(this.btn_receipt_mangement);
            this.Controls.Add(this.btn_move);
            this.Name = "Sale_Window";
            this.Text = "판매";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Sale_Window_FormClosing);
            this.Load += new System.EventHandler(this.Sale_Window_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_move;
        private System.Windows.Forms.Button btn_receipt_mangement;
        private System.Windows.Forms.Button btn_sale_status;
        private System.Windows.Forms.Button btn_order_receipt;
        private System.Windows.Forms.TextBox tb_hidden;
        private System.Windows.Forms.DateTimePicker TodayDate;
        private System.Windows.Forms.Button btn_Down;
    }
}