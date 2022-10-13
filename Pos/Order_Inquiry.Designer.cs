namespace Pos
{
    partial class Order_Inquiry
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
            this.lv_Order_Inquiry = new System.Windows.Forms.ListView();
            this.Order_Number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Table_Number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Menu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Check = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_Complete = new System.Windows.Forms.Button();
            this.btn_Order_Close = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_alldelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lv_Order_Inquiry
            // 
            this.lv_Order_Inquiry.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Order_Number,
            this.Table_Number,
            this.Menu,
            this.Check});
            this.lv_Order_Inquiry.HideSelection = false;
            this.lv_Order_Inquiry.Location = new System.Drawing.Point(12, 12);
            this.lv_Order_Inquiry.Name = "lv_Order_Inquiry";
            this.lv_Order_Inquiry.Size = new System.Drawing.Size(394, 491);
            this.lv_Order_Inquiry.TabIndex = 0;
            this.lv_Order_Inquiry.UseCompatibleStateImageBehavior = false;
            this.lv_Order_Inquiry.View = System.Windows.Forms.View.Details;
            // 
            // Order_Number
            // 
            this.Order_Number.Text = "번호";
            this.Order_Number.Width = 40;
            // 
            // Table_Number
            // 
            this.Table_Number.Text = "테이블";
            // 
            // Menu
            // 
            this.Menu.Text = "메뉴";
            this.Menu.Width = 250;
            // 
            // Check
            // 
            this.Check.Text = "완료";
            // 
            // btn_Complete
            // 
            this.btn_Complete.Location = new System.Drawing.Point(77, 509);
            this.btn_Complete.Name = "btn_Complete";
            this.btn_Complete.Size = new System.Drawing.Size(75, 41);
            this.btn_Complete.TabIndex = 1;
            this.btn_Complete.Text = "주문서출력";
            this.btn_Complete.UseVisualStyleBackColor = true;
            this.btn_Complete.Click += new System.EventHandler(this.btn_Complete_Click);
            // 
            // btn_Order_Close
            // 
            this.btn_Order_Close.Location = new System.Drawing.Point(331, 509);
            this.btn_Order_Close.Name = "btn_Order_Close";
            this.btn_Order_Close.Size = new System.Drawing.Size(75, 41);
            this.btn_Order_Close.TabIndex = 3;
            this.btn_Order_Close.Text = "닫기";
            this.btn_Order_Close.UseVisualStyleBackColor = true;
            this.btn_Order_Close.Click += new System.EventHandler(this.btn_Order_Close_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(250, 509);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 41);
            this.btn_delete.TabIndex = 4;
            this.btn_delete.Text = "주문삭제";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_alldelete
            // 
            this.btn_alldelete.Location = new System.Drawing.Point(158, 509);
            this.btn_alldelete.Name = "btn_alldelete";
            this.btn_alldelete.Size = new System.Drawing.Size(86, 41);
            this.btn_alldelete.TabIndex = 5;
            this.btn_alldelete.Text = "모든주문삭제";
            this.btn_alldelete.UseVisualStyleBackColor = true;
            this.btn_alldelete.Click += new System.EventHandler(this.button1_Click);
            // 
            // Order_Inquiry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 562);
            this.Controls.Add(this.btn_alldelete);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_Order_Close);
            this.Controls.Add(this.btn_Complete);
            this.Controls.Add(this.lv_Order_Inquiry);
            this.Name = "Order_Inquiry";
            this.Text = "주문 내역";
            this.Load += new System.EventHandler(this.Order_Inquiry_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lv_Order_Inquiry;
        private System.Windows.Forms.ColumnHeader Order_Number;
        private System.Windows.Forms.ColumnHeader Table_Number;
        private System.Windows.Forms.ColumnHeader Menu;
        private System.Windows.Forms.ColumnHeader Check;
        private System.Windows.Forms.Button btn_Complete;
        private System.Windows.Forms.Button btn_Order_Close;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_alldelete;
    }
}