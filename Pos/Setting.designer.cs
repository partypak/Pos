namespace Pos
{
    partial class Setting
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
            this.components = new System.ComponentModel.Container();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_MenuSet = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_Past = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(384, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 32);
            this.label6.TabIndex = 14;
            this.label6.Text = "POS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(307, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 32);
            this.label5.TabIndex = 13;
            this.label5.Text = "YES";
            // 
            // btn_MenuSet
            // 
            this.btn_MenuSet.Font = new System.Drawing.Font("돋움", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_MenuSet.Location = new System.Drawing.Point(288, 210);
            this.btn_MenuSet.Name = "btn_MenuSet";
            this.btn_MenuSet.Size = new System.Drawing.Size(205, 46);
            this.btn_MenuSet.TabIndex = 16;
            this.btn_MenuSet.Text = "메뉴 수정";
            this.btn_MenuSet.UseVisualStyleBackColor = true;
            this.btn_MenuSet.Click += new System.EventHandler(this.btn_MenuSet_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("돋움", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button2.Location = new System.Drawing.Point(288, 276);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(205, 46);
            this.button2.TabIndex = 17;
            this.button2.Text = "테이블 수정";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_Past
            // 
            this.btn_Past.BackColor = System.Drawing.Color.DarkGray;
            this.btn_Past.Font = new System.Drawing.Font("돋움", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Past.Location = new System.Drawing.Point(318, 150);
            this.btn_Past.Name = "btn_Past";
            this.btn_Past.Size = new System.Drawing.Size(148, 42);
            this.btn_Past.TabIndex = 18;
            this.btn_Past.Text = "Home";
            this.btn_Past.UseVisualStyleBackColor = false;
            this.btn_Past.Click += new System.EventHandler(this.btn_Past_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label4.Location = new System.Drawing.Point(203, 388);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 19);
            this.label4.TabIndex = 19;
            this.label4.Text = "Time";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_Past);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_MenuSet);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Name = "Setting";
            this.Text = "환경설정";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_MenuSet;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_Past;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
    }
}