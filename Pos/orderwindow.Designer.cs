namespace Pos
{
    partial class Orderwindow
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Orderwindow));
            this.lv_Order = new System.Windows.Forms.ListView();
            this.Number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Menu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Total = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Bigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_AllCancle = new System.Windows.Forms.Button();
            this.btn_SelectCancle = new System.Windows.Forms.Button();
            this.btn_Discount = new System.Windows.Forms.Button();
            this.btn_QuantityChange = new System.Windows.Forms.Button();
            this.btn_Minus = new System.Windows.Forms.Button();
            this.btn_Plus = new System.Windows.Forms.Button();
            this.btn_Up = new System.Windows.Forms.Button();
            this.btn_Down = new System.Windows.Forms.Button();
            this.btn_PaymentInfo = new System.Windows.Forms.Button();
            this.btn_PaymentBreakdown = new System.Windows.Forms.Button();
            this.btn_MemberInfo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_Total = new System.Windows.Forms.TextBox();
            this.tb_Discount = new System.Windows.Forms.TextBox();
            this.tb_SumCash = new System.Windows.Forms.TextBox();
            this.tb_Cash = new System.Windows.Forms.TextBox();
            this.tb_Change = new System.Windows.Forms.TextBox();
            this.btn_Calculator7 = new System.Windows.Forms.Button();
            this.btn_Calculator8 = new System.Windows.Forms.Button();
            this.btn_Calculator9 = new System.Windows.Forms.Button();
            this.btn_Calculator4 = new System.Windows.Forms.Button();
            this.btn_Calculator5 = new System.Windows.Forms.Button();
            this.btn_Calculator6 = new System.Windows.Forms.Button();
            this.btn_Calculator1 = new System.Windows.Forms.Button();
            this.btn_Calculator2 = new System.Windows.Forms.Button();
            this.btn_Calculator3 = new System.Windows.Forms.Button();
            this.btn_Calculator0 = new System.Windows.Forms.Button();
            this.btn_Calculator00 = new System.Windows.Forms.Button();
            this.btn_CalculatorClear = new System.Windows.Forms.Button();
            this.btn_CalculatorBackspace = new System.Windows.Forms.Button();
            this.btn_Order = new System.Windows.Forms.Button();
            this.btn_Cash = new System.Windows.Forms.Button();
            this.btn_Card = new System.Windows.Forms.Button();
            this.btn_CalculatorEnter = new System.Windows.Forms.Button();
            this.orderWin_date = new System.Windows.Forms.DateTimePicker();
            this.tab_Munu = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_Menu2_1 = new System.Windows.Forms.Button();
            this.btn_Menu2_2 = new System.Windows.Forms.Button();
            this.btn_Menu2_3 = new System.Windows.Forms.Button();
            this.btn_Menu2_5 = new System.Windows.Forms.Button();
            this.btn_Menu2_6 = new System.Windows.Forms.Button();
            this.btn_Menu2_7 = new System.Windows.Forms.Button();
            this.btn_Menu2_9 = new System.Windows.Forms.Button();
            this.btn_Menu2_10 = new System.Windows.Forms.Button();
            this.btn_Menu2_11 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btn_Menu3_1 = new System.Windows.Forms.Button();
            this.btn_Menu3_2 = new System.Windows.Forms.Button();
            this.btn_Menu3_3 = new System.Windows.Forms.Button();
            this.btn_Menu3_5 = new System.Windows.Forms.Button();
            this.btn_Menu3_6 = new System.Windows.Forms.Button();
            this.btn_Menu3_7 = new System.Windows.Forms.Button();
            this.btn_Menu3_9 = new System.Windows.Forms.Button();
            this.btn_Menu3_10 = new System.Windows.Forms.Button();
            this.btn_Menu3_11 = new System.Windows.Forms.Button();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.btn_Menu6_1 = new System.Windows.Forms.Button();
            this.btn_Menu6_2 = new System.Windows.Forms.Button();
            this.btn_Menu6_3 = new System.Windows.Forms.Button();
            this.btn_Menu6_5 = new System.Windows.Forms.Button();
            this.btn_Menu6_6 = new System.Windows.Forms.Button();
            this.btn_Menu6_7 = new System.Windows.Forms.Button();
            this.btn_Menu6_9 = new System.Windows.Forms.Button();
            this.btn_Menu6_10 = new System.Windows.Forms.Button();
            this.btn_Menu6_11 = new System.Windows.Forms.Button();
            this.tab_Munu.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.SuspendLayout();
            // 
            // lv_Order
            // 
            this.lv_Order.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Number,
            this.Menu,
            this.Price,
            this.Quantity,
            this.Total,
            this.Bigo});
            this.lv_Order.GridLines = true;
            this.lv_Order.HideSelection = false;
            this.lv_Order.Location = new System.Drawing.Point(13, 12);
            this.lv_Order.Name = "lv_Order";
            this.lv_Order.Size = new System.Drawing.Size(587, 237);
            this.lv_Order.TabIndex = 0;
            this.lv_Order.UseCompatibleStateImageBehavior = false;
            this.lv_Order.View = System.Windows.Forms.View.Details;
            // 
            // Number
            // 
            this.Number.Text = "No";
            this.Number.Width = 32;
            // 
            // Menu
            // 
            this.Menu.Text = "메뉴명";
            this.Menu.Width = 125;
            // 
            // Price
            // 
            this.Price.Text = "단가";
            this.Price.Width = 94;
            // 
            // Quantity
            // 
            this.Quantity.Text = "수량";
            this.Quantity.Width = 44;
            // 
            // Total
            // 
            this.Total.Text = "금액";
            this.Total.Width = 114;
            // 
            // Bigo
            // 
            this.Bigo.Text = "비고";
            this.Bigo.Width = 72;
            // 
            // btn_AllCancle
            // 
            this.btn_AllCancle.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_AllCancle.Location = new System.Drawing.Point(12, 271);
            this.btn_AllCancle.Name = "btn_AllCancle";
            this.btn_AllCancle.Size = new System.Drawing.Size(52, 61);
            this.btn_AllCancle.TabIndex = 2;
            this.btn_AllCancle.Text = "전체\r\n삭제";
            this.btn_AllCancle.UseVisualStyleBackColor = true;
            this.btn_AllCancle.Click += new System.EventHandler(this.btn_AllCancle_Click);
            // 
            // btn_SelectCancle
            // 
            this.btn_SelectCancle.Location = new System.Drawing.Point(89, 271);
            this.btn_SelectCancle.Name = "btn_SelectCancle";
            this.btn_SelectCancle.Size = new System.Drawing.Size(52, 61);
            this.btn_SelectCancle.TabIndex = 2;
            this.btn_SelectCancle.Text = "선택\r\n삭제\r\n";
            this.btn_SelectCancle.UseVisualStyleBackColor = true;
            this.btn_SelectCancle.Click += new System.EventHandler(this.btn_SelectCancle_Click);
            // 
            // btn_Discount
            // 
            this.btn_Discount.Location = new System.Drawing.Point(166, 271);
            this.btn_Discount.Name = "btn_Discount";
            this.btn_Discount.Size = new System.Drawing.Size(52, 61);
            this.btn_Discount.TabIndex = 2;
            this.btn_Discount.Text = "할인\r\n처리\r\n";
            this.btn_Discount.UseVisualStyleBackColor = true;
            this.btn_Discount.Click += new System.EventHandler(this.btn_Discount_Click);
            // 
            // btn_QuantityChange
            // 
            this.btn_QuantityChange.Location = new System.Drawing.Point(243, 271);
            this.btn_QuantityChange.Name = "btn_QuantityChange";
            this.btn_QuantityChange.Size = new System.Drawing.Size(52, 61);
            this.btn_QuantityChange.TabIndex = 2;
            this.btn_QuantityChange.Text = "수량\r\n변경\r\n";
            this.btn_QuantityChange.UseVisualStyleBackColor = true;
            this.btn_QuantityChange.Click += new System.EventHandler(this.btn_QuantityChange_Click);
            // 
            // btn_Minus
            // 
            this.btn_Minus.Location = new System.Drawing.Point(316, 271);
            this.btn_Minus.Name = "btn_Minus";
            this.btn_Minus.Size = new System.Drawing.Size(52, 61);
            this.btn_Minus.TabIndex = 2;
            this.btn_Minus.Text = "-";
            this.btn_Minus.UseVisualStyleBackColor = true;
            this.btn_Minus.Click += new System.EventHandler(this.btn_Minus_Click);
            // 
            // btn_Plus
            // 
            this.btn_Plus.Location = new System.Drawing.Point(393, 271);
            this.btn_Plus.Name = "btn_Plus";
            this.btn_Plus.Size = new System.Drawing.Size(52, 61);
            this.btn_Plus.TabIndex = 2;
            this.btn_Plus.Text = "+";
            this.btn_Plus.UseVisualStyleBackColor = true;
            this.btn_Plus.Click += new System.EventHandler(this.btn_Plus_Click);
            // 
            // btn_Up
            // 
            this.btn_Up.Location = new System.Drawing.Point(470, 271);
            this.btn_Up.Name = "btn_Up";
            this.btn_Up.Size = new System.Drawing.Size(52, 61);
            this.btn_Up.TabIndex = 2;
            this.btn_Up.Text = "△";
            this.btn_Up.UseVisualStyleBackColor = true;
            this.btn_Up.Click += new System.EventHandler(this.btn_Up_Click);
            // 
            // btn_Down
            // 
            this.btn_Down.Location = new System.Drawing.Point(547, 271);
            this.btn_Down.Name = "btn_Down";
            this.btn_Down.Size = new System.Drawing.Size(52, 61);
            this.btn_Down.TabIndex = 2;
            this.btn_Down.Text = "▽";
            this.btn_Down.UseVisualStyleBackColor = true;
            this.btn_Down.Click += new System.EventHandler(this.btn_Down_Click);
            // 
            // btn_PaymentInfo
            // 
            this.btn_PaymentInfo.Location = new System.Drawing.Point(12, 352);
            this.btn_PaymentInfo.Name = "btn_PaymentInfo";
            this.btn_PaymentInfo.Size = new System.Drawing.Size(77, 43);
            this.btn_PaymentInfo.TabIndex = 3;
            this.btn_PaymentInfo.Text = "결제정보";
            this.btn_PaymentInfo.UseVisualStyleBackColor = true;
            // 
            // btn_PaymentBreakdown
            // 
            this.btn_PaymentBreakdown.Location = new System.Drawing.Point(89, 352);
            this.btn_PaymentBreakdown.Name = "btn_PaymentBreakdown";
            this.btn_PaymentBreakdown.Size = new System.Drawing.Size(77, 43);
            this.btn_PaymentBreakdown.TabIndex = 3;
            this.btn_PaymentBreakdown.Text = "결제내역";
            this.btn_PaymentBreakdown.UseVisualStyleBackColor = true;
            // 
            // btn_MemberInfo
            // 
            this.btn_MemberInfo.Location = new System.Drawing.Point(166, 352);
            this.btn_MemberInfo.Name = "btn_MemberInfo";
            this.btn_MemberInfo.Size = new System.Drawing.Size(77, 43);
            this.btn_MemberInfo.TabIndex = 3;
            this.btn_MemberInfo.Text = "회원정보";
            this.btn_MemberInfo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(10, 409);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "총 금 액";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(10, 440);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "할인금액";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(9, 471);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "받을금액";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(9, 502);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 31);
            this.label4.TabIndex = 4;
            this.label4.Text = "받은금액";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(9, 533);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 31);
            this.label5.TabIndex = 4;
            this.label5.Text = "거스름돈";
            // 
            // tb_Total
            // 
            this.tb_Total.Location = new System.Drawing.Point(110, 409);
            this.tb_Total.Name = "tb_Total";
            this.tb_Total.Size = new System.Drawing.Size(133, 21);
            this.tb_Total.TabIndex = 5;
            this.tb_Total.Text = resources.GetString("tb_Total.Text");
            this.tb_Total.TextChanged += new System.EventHandler(this.tb_Total_TextChanged);
            // 
            // tb_Discount
            // 
            this.tb_Discount.Location = new System.Drawing.Point(109, 440);
            this.tb_Discount.Name = "tb_Discount";
            this.tb_Discount.Size = new System.Drawing.Size(133, 21);
            this.tb_Discount.TabIndex = 5;
            this.tb_Discount.Text = "0";
            // 
            // tb_SumCash
            // 
            this.tb_SumCash.Location = new System.Drawing.Point(109, 471);
            this.tb_SumCash.Name = "tb_SumCash";
            this.tb_SumCash.Size = new System.Drawing.Size(133, 21);
            this.tb_SumCash.TabIndex = 5;
            this.tb_SumCash.TextChanged += new System.EventHandler(this.tb_SumCash_TextChanged);
            // 
            // tb_Cash
            // 
            this.tb_Cash.Location = new System.Drawing.Point(109, 502);
            this.tb_Cash.Name = "tb_Cash";
            this.tb_Cash.Size = new System.Drawing.Size(133, 21);
            this.tb_Cash.TabIndex = 5;
            // 
            // tb_Change
            // 
            this.tb_Change.Location = new System.Drawing.Point(109, 533);
            this.tb_Change.Name = "tb_Change";
            this.tb_Change.Size = new System.Drawing.Size(133, 21);
            this.tb_Change.TabIndex = 5;
            this.tb_Change.TextChanged += new System.EventHandler(this.tb_Change_TextChanged);
            // 
            // btn_Calculator7
            // 
            this.btn_Calculator7.Location = new System.Drawing.Point(269, 352);
            this.btn_Calculator7.Name = "btn_Calculator7";
            this.btn_Calculator7.Size = new System.Drawing.Size(52, 51);
            this.btn_Calculator7.TabIndex = 2;
            this.btn_Calculator7.Text = "7";
            this.btn_Calculator7.UseVisualStyleBackColor = true;
            this.btn_Calculator7.Click += new System.EventHandler(this.btn_Calculator7_Click);
            // 
            // btn_Calculator8
            // 
            this.btn_Calculator8.Location = new System.Drawing.Point(327, 352);
            this.btn_Calculator8.Name = "btn_Calculator8";
            this.btn_Calculator8.Size = new System.Drawing.Size(52, 51);
            this.btn_Calculator8.TabIndex = 2;
            this.btn_Calculator8.Text = "8";
            this.btn_Calculator8.UseVisualStyleBackColor = true;
            this.btn_Calculator8.Click += new System.EventHandler(this.btn_Calculator8_Click);
            // 
            // btn_Calculator9
            // 
            this.btn_Calculator9.Location = new System.Drawing.Point(385, 352);
            this.btn_Calculator9.Name = "btn_Calculator9";
            this.btn_Calculator9.Size = new System.Drawing.Size(52, 51);
            this.btn_Calculator9.TabIndex = 2;
            this.btn_Calculator9.Text = "9";
            this.btn_Calculator9.UseVisualStyleBackColor = true;
            this.btn_Calculator9.Click += new System.EventHandler(this.btn_Calculator9_Click);
            // 
            // btn_Calculator4
            // 
            this.btn_Calculator4.Location = new System.Drawing.Point(269, 409);
            this.btn_Calculator4.Name = "btn_Calculator4";
            this.btn_Calculator4.Size = new System.Drawing.Size(52, 51);
            this.btn_Calculator4.TabIndex = 2;
            this.btn_Calculator4.Text = "4";
            this.btn_Calculator4.UseVisualStyleBackColor = true;
            this.btn_Calculator4.Click += new System.EventHandler(this.btn_Calculator4_Click);
            // 
            // btn_Calculator5
            // 
            this.btn_Calculator5.Location = new System.Drawing.Point(327, 409);
            this.btn_Calculator5.Name = "btn_Calculator5";
            this.btn_Calculator5.Size = new System.Drawing.Size(52, 51);
            this.btn_Calculator5.TabIndex = 2;
            this.btn_Calculator5.Text = "5";
            this.btn_Calculator5.UseVisualStyleBackColor = true;
            this.btn_Calculator5.Click += new System.EventHandler(this.btn_Calculator5_Click);
            // 
            // btn_Calculator6
            // 
            this.btn_Calculator6.Location = new System.Drawing.Point(385, 409);
            this.btn_Calculator6.Name = "btn_Calculator6";
            this.btn_Calculator6.Size = new System.Drawing.Size(52, 51);
            this.btn_Calculator6.TabIndex = 2;
            this.btn_Calculator6.Text = "6";
            this.btn_Calculator6.UseVisualStyleBackColor = true;
            this.btn_Calculator6.Click += new System.EventHandler(this.btn_Calculator6_Click);
            // 
            // btn_Calculator1
            // 
            this.btn_Calculator1.Location = new System.Drawing.Point(269, 466);
            this.btn_Calculator1.Name = "btn_Calculator1";
            this.btn_Calculator1.Size = new System.Drawing.Size(52, 51);
            this.btn_Calculator1.TabIndex = 2;
            this.btn_Calculator1.Text = "1";
            this.btn_Calculator1.UseVisualStyleBackColor = true;
            this.btn_Calculator1.Click += new System.EventHandler(this.btn_Calculator1_Click);
            // 
            // btn_Calculator2
            // 
            this.btn_Calculator2.Location = new System.Drawing.Point(327, 466);
            this.btn_Calculator2.Name = "btn_Calculator2";
            this.btn_Calculator2.Size = new System.Drawing.Size(52, 51);
            this.btn_Calculator2.TabIndex = 2;
            this.btn_Calculator2.Text = "2";
            this.btn_Calculator2.UseVisualStyleBackColor = true;
            this.btn_Calculator2.Click += new System.EventHandler(this.btn_Calculator2_Click);
            // 
            // btn_Calculator3
            // 
            this.btn_Calculator3.Location = new System.Drawing.Point(385, 466);
            this.btn_Calculator3.Name = "btn_Calculator3";
            this.btn_Calculator3.Size = new System.Drawing.Size(52, 51);
            this.btn_Calculator3.TabIndex = 2;
            this.btn_Calculator3.Text = "3";
            this.btn_Calculator3.UseVisualStyleBackColor = true;
            this.btn_Calculator3.Click += new System.EventHandler(this.btn_Calculator3_Click);
            // 
            // btn_Calculator0
            // 
            this.btn_Calculator0.Location = new System.Drawing.Point(269, 523);
            this.btn_Calculator0.Name = "btn_Calculator0";
            this.btn_Calculator0.Size = new System.Drawing.Size(52, 51);
            this.btn_Calculator0.TabIndex = 2;
            this.btn_Calculator0.Text = "0";
            this.btn_Calculator0.UseVisualStyleBackColor = true;
            this.btn_Calculator0.Click += new System.EventHandler(this.btn_Calculator0_Click);
            // 
            // btn_Calculator00
            // 
            this.btn_Calculator00.Location = new System.Drawing.Point(327, 523);
            this.btn_Calculator00.Name = "btn_Calculator00";
            this.btn_Calculator00.Size = new System.Drawing.Size(52, 51);
            this.btn_Calculator00.TabIndex = 2;
            this.btn_Calculator00.Text = "00";
            this.btn_Calculator00.UseVisualStyleBackColor = true;
            this.btn_Calculator00.Click += new System.EventHandler(this.btn_Calculator00_Click);
            // 
            // btn_CalculatorClear
            // 
            this.btn_CalculatorClear.Location = new System.Drawing.Point(385, 523);
            this.btn_CalculatorClear.Name = "btn_CalculatorClear";
            this.btn_CalculatorClear.Size = new System.Drawing.Size(52, 51);
            this.btn_CalculatorClear.TabIndex = 2;
            this.btn_CalculatorClear.Text = "C";
            this.btn_CalculatorClear.UseVisualStyleBackColor = true;
            this.btn_CalculatorClear.Click += new System.EventHandler(this.btn_CalculatorClear_Click);
            // 
            // btn_CalculatorBackspace
            // 
            this.btn_CalculatorBackspace.Location = new System.Drawing.Point(440, 352);
            this.btn_CalculatorBackspace.Name = "btn_CalculatorBackspace";
            this.btn_CalculatorBackspace.Size = new System.Drawing.Size(52, 108);
            this.btn_CalculatorBackspace.TabIndex = 2;
            this.btn_CalculatorBackspace.Text = "<";
            this.btn_CalculatorBackspace.UseVisualStyleBackColor = true;
            this.btn_CalculatorBackspace.Click += new System.EventHandler(this.btn_CalculatorBackspace_Click);
            // 
            // btn_Order
            // 
            this.btn_Order.Location = new System.Drawing.Point(643, 434);
            this.btn_Order.Name = "btn_Order";
            this.btn_Order.Size = new System.Drawing.Size(168, 135);
            this.btn_Order.TabIndex = 2;
            this.btn_Order.Text = "주문";
            this.btn_Order.UseVisualStyleBackColor = true;
            this.btn_Order.Click += new System.EventHandler(this.btn_Order_Click);
            // 
            // btn_Cash
            // 
            this.btn_Cash.Location = new System.Drawing.Point(834, 434);
            this.btn_Cash.Name = "btn_Cash";
            this.btn_Cash.Size = new System.Drawing.Size(72, 135);
            this.btn_Cash.TabIndex = 2;
            this.btn_Cash.Text = "현금";
            this.btn_Cash.UseVisualStyleBackColor = true;
            this.btn_Cash.Click += new System.EventHandler(this.btn_Cash_Click);
            // 
            // btn_Card
            // 
            this.btn_Card.Location = new System.Drawing.Point(931, 434);
            this.btn_Card.Name = "btn_Card";
            this.btn_Card.Size = new System.Drawing.Size(72, 135);
            this.btn_Card.TabIndex = 2;
            this.btn_Card.Text = "카드";
            this.btn_Card.UseVisualStyleBackColor = true;
            this.btn_Card.Click += new System.EventHandler(this.btn_Card_Click);
            // 
            // btn_CalculatorEnter
            // 
            this.btn_CalculatorEnter.Location = new System.Drawing.Point(440, 466);
            this.btn_CalculatorEnter.Name = "btn_CalculatorEnter";
            this.btn_CalculatorEnter.Size = new System.Drawing.Size(52, 108);
            this.btn_CalculatorEnter.TabIndex = 2;
            this.btn_CalculatorEnter.Text = "Enter";
            this.btn_CalculatorEnter.UseVisualStyleBackColor = true;
            this.btn_CalculatorEnter.Click += new System.EventHandler(this.btn_CalculatorEnter_Click);
            // 
            // orderWin_date
            // 
            this.orderWin_date.CustomFormat = "MM-dd";
            this.orderWin_date.Enabled = false;
            this.orderWin_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.orderWin_date.Location = new System.Drawing.Point(937, 575);
            this.orderWin_date.Name = "orderWin_date";
            this.orderWin_date.Size = new System.Drawing.Size(66, 21);
            this.orderWin_date.TabIndex = 6;
            // 
            // tab_Munu
            // 
            this.tab_Munu.Controls.Add(this.tabPage2);
            this.tab_Munu.Controls.Add(this.tabPage3);
            this.tab_Munu.Controls.Add(this.tabPage6);
            this.tab_Munu.ItemSize = new System.Drawing.Size(96, 35);
            this.tab_Munu.Location = new System.Drawing.Point(606, 12);
            this.tab_Munu.Name = "tab_Munu";
            this.tab_Munu.SelectedIndex = 0;
            this.tab_Munu.Size = new System.Drawing.Size(418, 416);
            this.tab_Munu.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tab_Munu.TabIndex = 69;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightGray;
            this.tabPage2.Controls.Add(this.btn_Menu2_1);
            this.tabPage2.Controls.Add(this.btn_Menu2_2);
            this.tabPage2.Controls.Add(this.btn_Menu2_3);
            this.tabPage2.Controls.Add(this.btn_Menu2_5);
            this.tabPage2.Controls.Add(this.btn_Menu2_6);
            this.tabPage2.Controls.Add(this.btn_Menu2_7);
            this.tabPage2.Controls.Add(this.btn_Menu2_9);
            this.tabPage2.Controls.Add(this.btn_Menu2_10);
            this.tabPage2.Controls.Add(this.btn_Menu2_11);
            this.tabPage2.Location = new System.Drawing.Point(4, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(410, 373);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "메인 메뉴";
            // 
            // btn_Menu2_1
            // 
            this.btn_Menu2_1.BackColor = System.Drawing.Color.LightBlue;
            this.btn_Menu2_1.Font = new System.Drawing.Font("굴림", 13F, System.Drawing.FontStyle.Bold);
            this.btn_Menu2_1.ForeColor = System.Drawing.Color.Black;
            this.btn_Menu2_1.Location = new System.Drawing.Point(24, 16);
            this.btn_Menu2_1.Name = "btn_Menu2_1";
            this.btn_Menu2_1.Size = new System.Drawing.Size(110, 110);
            this.btn_Menu2_1.TabIndex = 149;
            this.btn_Menu2_1.Text = "떡볶이\r\n\r\n2000원";
            this.btn_Menu2_1.UseVisualStyleBackColor = false;
            // 
            // btn_Menu2_2
            // 
            this.btn_Menu2_2.BackColor = System.Drawing.Color.LightBlue;
            this.btn_Menu2_2.Font = new System.Drawing.Font("굴림", 13F, System.Drawing.FontStyle.Bold);
            this.btn_Menu2_2.ForeColor = System.Drawing.Color.Black;
            this.btn_Menu2_2.Location = new System.Drawing.Point(149, 16);
            this.btn_Menu2_2.Name = "btn_Menu2_2";
            this.btn_Menu2_2.Size = new System.Drawing.Size(110, 110);
            this.btn_Menu2_2.TabIndex = 148;
            this.btn_Menu2_2.Text = "떡볶이\r\n\r\n3000원";
            this.btn_Menu2_2.UseVisualStyleBackColor = false;
            // 
            // btn_Menu2_3
            // 
            this.btn_Menu2_3.BackColor = System.Drawing.Color.LightBlue;
            this.btn_Menu2_3.Font = new System.Drawing.Font("굴림", 13F, System.Drawing.FontStyle.Bold);
            this.btn_Menu2_3.ForeColor = System.Drawing.Color.Black;
            this.btn_Menu2_3.Location = new System.Drawing.Point(274, 16);
            this.btn_Menu2_3.Name = "btn_Menu2_3";
            this.btn_Menu2_3.Size = new System.Drawing.Size(110, 110);
            this.btn_Menu2_3.TabIndex = 147;
            this.btn_Menu2_3.Text = "순대\r\n\r\n3500원";
            this.btn_Menu2_3.UseVisualStyleBackColor = false;
            // 
            // btn_Menu2_5
            // 
            this.btn_Menu2_5.BackColor = System.Drawing.Color.LightBlue;
            this.btn_Menu2_5.Font = new System.Drawing.Font("굴림", 13F, System.Drawing.FontStyle.Bold);
            this.btn_Menu2_5.ForeColor = System.Drawing.Color.Black;
            this.btn_Menu2_5.Location = new System.Drawing.Point(24, 132);
            this.btn_Menu2_5.Name = "btn_Menu2_5";
            this.btn_Menu2_5.Size = new System.Drawing.Size(110, 110);
            this.btn_Menu2_5.TabIndex = 145;
            this.btn_Menu2_5.Text = "메뉴 5";
            this.btn_Menu2_5.UseVisualStyleBackColor = false;
            // 
            // btn_Menu2_6
            // 
            this.btn_Menu2_6.BackColor = System.Drawing.Color.LightBlue;
            this.btn_Menu2_6.Font = new System.Drawing.Font("굴림", 13F, System.Drawing.FontStyle.Bold);
            this.btn_Menu2_6.ForeColor = System.Drawing.Color.Black;
            this.btn_Menu2_6.Location = new System.Drawing.Point(149, 132);
            this.btn_Menu2_6.Name = "btn_Menu2_6";
            this.btn_Menu2_6.Size = new System.Drawing.Size(110, 110);
            this.btn_Menu2_6.TabIndex = 144;
            this.btn_Menu2_6.Text = "메뉴 6";
            this.btn_Menu2_6.UseVisualStyleBackColor = false;
            // 
            // btn_Menu2_7
            // 
            this.btn_Menu2_7.BackColor = System.Drawing.Color.LightBlue;
            this.btn_Menu2_7.Font = new System.Drawing.Font("굴림", 13F, System.Drawing.FontStyle.Bold);
            this.btn_Menu2_7.ForeColor = System.Drawing.Color.Black;
            this.btn_Menu2_7.Location = new System.Drawing.Point(274, 132);
            this.btn_Menu2_7.Name = "btn_Menu2_7";
            this.btn_Menu2_7.Size = new System.Drawing.Size(110, 110);
            this.btn_Menu2_7.TabIndex = 143;
            this.btn_Menu2_7.Text = "메뉴 7";
            this.btn_Menu2_7.UseVisualStyleBackColor = false;
            // 
            // btn_Menu2_9
            // 
            this.btn_Menu2_9.BackColor = System.Drawing.Color.LightBlue;
            this.btn_Menu2_9.Font = new System.Drawing.Font("굴림", 13F, System.Drawing.FontStyle.Bold);
            this.btn_Menu2_9.ForeColor = System.Drawing.Color.Black;
            this.btn_Menu2_9.Location = new System.Drawing.Point(24, 248);
            this.btn_Menu2_9.Name = "btn_Menu2_9";
            this.btn_Menu2_9.Size = new System.Drawing.Size(110, 110);
            this.btn_Menu2_9.TabIndex = 141;
            this.btn_Menu2_9.Text = "메뉴 9";
            this.btn_Menu2_9.UseVisualStyleBackColor = false;
            // 
            // btn_Menu2_10
            // 
            this.btn_Menu2_10.BackColor = System.Drawing.Color.LightBlue;
            this.btn_Menu2_10.Font = new System.Drawing.Font("굴림", 13F, System.Drawing.FontStyle.Bold);
            this.btn_Menu2_10.ForeColor = System.Drawing.Color.Black;
            this.btn_Menu2_10.Location = new System.Drawing.Point(149, 248);
            this.btn_Menu2_10.Name = "btn_Menu2_10";
            this.btn_Menu2_10.Size = new System.Drawing.Size(110, 110);
            this.btn_Menu2_10.TabIndex = 140;
            this.btn_Menu2_10.Text = "메뉴 10";
            this.btn_Menu2_10.UseVisualStyleBackColor = false;
            // 
            // btn_Menu2_11
            // 
            this.btn_Menu2_11.BackColor = System.Drawing.Color.LightBlue;
            this.btn_Menu2_11.Font = new System.Drawing.Font("굴림", 13F, System.Drawing.FontStyle.Bold);
            this.btn_Menu2_11.ForeColor = System.Drawing.Color.Black;
            this.btn_Menu2_11.Location = new System.Drawing.Point(274, 248);
            this.btn_Menu2_11.Name = "btn_Menu2_11";
            this.btn_Menu2_11.Size = new System.Drawing.Size(110, 110);
            this.btn_Menu2_11.TabIndex = 139;
            this.btn_Menu2_11.Text = "메뉴 11";
            this.btn_Menu2_11.UseVisualStyleBackColor = false;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.LightGray;
            this.tabPage3.Controls.Add(this.btn_Menu3_1);
            this.tabPage3.Controls.Add(this.btn_Menu3_2);
            this.tabPage3.Controls.Add(this.btn_Menu3_3);
            this.tabPage3.Controls.Add(this.btn_Menu3_5);
            this.tabPage3.Controls.Add(this.btn_Menu3_6);
            this.tabPage3.Controls.Add(this.btn_Menu3_7);
            this.tabPage3.Controls.Add(this.btn_Menu3_9);
            this.tabPage3.Controls.Add(this.btn_Menu3_10);
            this.tabPage3.Controls.Add(this.btn_Menu3_11);
            this.tabPage3.Location = new System.Drawing.Point(4, 39);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(410, 373);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "튀김";
            // 
            // btn_Menu3_1
            // 
            this.btn_Menu3_1.BackColor = System.Drawing.Color.LightBlue;
            this.btn_Menu3_1.Font = new System.Drawing.Font("굴림", 14F, System.Drawing.FontStyle.Bold);
            this.btn_Menu3_1.ForeColor = System.Drawing.Color.Black;
            this.btn_Menu3_1.Location = new System.Drawing.Point(23, 17);
            this.btn_Menu3_1.Name = "btn_Menu3_1";
            this.btn_Menu3_1.Size = new System.Drawing.Size(110, 110);
            this.btn_Menu3_1.TabIndex = 149;
            this.btn_Menu3_1.Text = "튀김어묵(6)\r\n\r\n1500원";
            this.btn_Menu3_1.UseVisualStyleBackColor = false;
            // 
            // btn_Menu3_2
            // 
            this.btn_Menu3_2.BackColor = System.Drawing.Color.LightBlue;
            this.btn_Menu3_2.Font = new System.Drawing.Font("굴림", 14F, System.Drawing.FontStyle.Bold);
            this.btn_Menu3_2.ForeColor = System.Drawing.Color.Black;
            this.btn_Menu3_2.Location = new System.Drawing.Point(156, 17);
            this.btn_Menu3_2.Name = "btn_Menu3_2";
            this.btn_Menu3_2.Size = new System.Drawing.Size(110, 110);
            this.btn_Menu3_2.TabIndex = 148;
            this.btn_Menu3_2.Text = "튀김만두(3)\r\n\r\n1500원";
            this.btn_Menu3_2.UseVisualStyleBackColor = false;
            // 
            // btn_Menu3_3
            // 
            this.btn_Menu3_3.BackColor = System.Drawing.Color.LightBlue;
            this.btn_Menu3_3.Font = new System.Drawing.Font("굴림", 14F, System.Drawing.FontStyle.Bold);
            this.btn_Menu3_3.ForeColor = System.Drawing.Color.Black;
            this.btn_Menu3_3.Location = new System.Drawing.Point(283, 17);
            this.btn_Menu3_3.Name = "btn_Menu3_3";
            this.btn_Menu3_3.Size = new System.Drawing.Size(110, 110);
            this.btn_Menu3_3.TabIndex = 147;
            this.btn_Menu3_3.Text = "김말이(3)\r\n\r\n1500원";
            this.btn_Menu3_3.UseVisualStyleBackColor = false;
            // 
            // btn_Menu3_5
            // 
            this.btn_Menu3_5.BackColor = System.Drawing.Color.LightBlue;
            this.btn_Menu3_5.Font = new System.Drawing.Font("굴림", 14F, System.Drawing.FontStyle.Bold);
            this.btn_Menu3_5.ForeColor = System.Drawing.Color.Black;
            this.btn_Menu3_5.Location = new System.Drawing.Point(23, 129);
            this.btn_Menu3_5.Name = "btn_Menu3_5";
            this.btn_Menu3_5.Size = new System.Drawing.Size(110, 110);
            this.btn_Menu3_5.TabIndex = 145;
            this.btn_Menu3_5.Text = "치킨링(10)\r\n\r\n2000원\r\n";
            this.btn_Menu3_5.UseVisualStyleBackColor = false;
            // 
            // btn_Menu3_6
            // 
            this.btn_Menu3_6.BackColor = System.Drawing.Color.LightBlue;
            this.btn_Menu3_6.Font = new System.Drawing.Font("굴림", 14F, System.Drawing.FontStyle.Bold);
            this.btn_Menu3_6.ForeColor = System.Drawing.Color.Black;
            this.btn_Menu3_6.Location = new System.Drawing.Point(156, 133);
            this.btn_Menu3_6.Name = "btn_Menu3_6";
            this.btn_Menu3_6.Size = new System.Drawing.Size(110, 110);
            this.btn_Menu3_6.TabIndex = 144;
            this.btn_Menu3_6.Text = "메뉴 6";
            this.btn_Menu3_6.UseVisualStyleBackColor = false;
            // 
            // btn_Menu3_7
            // 
            this.btn_Menu3_7.BackColor = System.Drawing.Color.LightBlue;
            this.btn_Menu3_7.Font = new System.Drawing.Font("굴림", 14F, System.Drawing.FontStyle.Bold);
            this.btn_Menu3_7.ForeColor = System.Drawing.Color.Black;
            this.btn_Menu3_7.Location = new System.Drawing.Point(283, 129);
            this.btn_Menu3_7.Name = "btn_Menu3_7";
            this.btn_Menu3_7.Size = new System.Drawing.Size(110, 110);
            this.btn_Menu3_7.TabIndex = 143;
            this.btn_Menu3_7.Text = "메뉴 7";
            this.btn_Menu3_7.UseVisualStyleBackColor = false;
            // 
            // btn_Menu3_9
            // 
            this.btn_Menu3_9.BackColor = System.Drawing.Color.LightBlue;
            this.btn_Menu3_9.Font = new System.Drawing.Font("굴림", 14F, System.Drawing.FontStyle.Bold);
            this.btn_Menu3_9.ForeColor = System.Drawing.Color.Black;
            this.btn_Menu3_9.Location = new System.Drawing.Point(23, 245);
            this.btn_Menu3_9.Name = "btn_Menu3_9";
            this.btn_Menu3_9.Size = new System.Drawing.Size(110, 110);
            this.btn_Menu3_9.TabIndex = 141;
            this.btn_Menu3_9.Text = "메뉴 9";
            this.btn_Menu3_9.UseVisualStyleBackColor = false;
            // 
            // btn_Menu3_10
            // 
            this.btn_Menu3_10.BackColor = System.Drawing.Color.LightBlue;
            this.btn_Menu3_10.Font = new System.Drawing.Font("굴림", 14F, System.Drawing.FontStyle.Bold);
            this.btn_Menu3_10.ForeColor = System.Drawing.Color.Black;
            this.btn_Menu3_10.Location = new System.Drawing.Point(156, 245);
            this.btn_Menu3_10.Name = "btn_Menu3_10";
            this.btn_Menu3_10.Size = new System.Drawing.Size(110, 110);
            this.btn_Menu3_10.TabIndex = 140;
            this.btn_Menu3_10.Text = "메뉴 10";
            this.btn_Menu3_10.UseVisualStyleBackColor = false;
            // 
            // btn_Menu3_11
            // 
            this.btn_Menu3_11.BackColor = System.Drawing.Color.LightBlue;
            this.btn_Menu3_11.Font = new System.Drawing.Font("굴림", 14F, System.Drawing.FontStyle.Bold);
            this.btn_Menu3_11.ForeColor = System.Drawing.Color.Black;
            this.btn_Menu3_11.Location = new System.Drawing.Point(283, 245);
            this.btn_Menu3_11.Name = "btn_Menu3_11";
            this.btn_Menu3_11.Size = new System.Drawing.Size(110, 110);
            this.btn_Menu3_11.TabIndex = 139;
            this.btn_Menu3_11.Text = "메뉴 11";
            this.btn_Menu3_11.UseVisualStyleBackColor = false;
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.Color.LightGray;
            this.tabPage6.Controls.Add(this.btn_Menu6_1);
            this.tabPage6.Controls.Add(this.btn_Menu6_2);
            this.tabPage6.Controls.Add(this.btn_Menu6_3);
            this.tabPage6.Controls.Add(this.btn_Menu6_5);
            this.tabPage6.Controls.Add(this.btn_Menu6_6);
            this.tabPage6.Controls.Add(this.btn_Menu6_7);
            this.tabPage6.Controls.Add(this.btn_Menu6_9);
            this.tabPage6.Controls.Add(this.btn_Menu6_10);
            this.tabPage6.Controls.Add(this.btn_Menu6_11);
            this.tabPage6.Location = new System.Drawing.Point(4, 39);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(410, 373);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "음료";
            // 
            // btn_Menu6_1
            // 
            this.btn_Menu6_1.BackColor = System.Drawing.Color.LightBlue;
            this.btn_Menu6_1.Font = new System.Drawing.Font("굴림", 14F, System.Drawing.FontStyle.Bold);
            this.btn_Menu6_1.ForeColor = System.Drawing.Color.Black;
            this.btn_Menu6_1.Location = new System.Drawing.Point(24, 10);
            this.btn_Menu6_1.Name = "btn_Menu6_1";
            this.btn_Menu6_1.Size = new System.Drawing.Size(110, 110);
            this.btn_Menu6_1.TabIndex = 149;
            this.btn_Menu6_1.Text = "콜라\r\n\r\n1000원";
            this.btn_Menu6_1.UseVisualStyleBackColor = false;
            // 
            // btn_Menu6_2
            // 
            this.btn_Menu6_2.BackColor = System.Drawing.Color.LightBlue;
            this.btn_Menu6_2.Font = new System.Drawing.Font("굴림", 14F, System.Drawing.FontStyle.Bold);
            this.btn_Menu6_2.ForeColor = System.Drawing.Color.Black;
            this.btn_Menu6_2.Location = new System.Drawing.Point(149, 10);
            this.btn_Menu6_2.Name = "btn_Menu6_2";
            this.btn_Menu6_2.Size = new System.Drawing.Size(110, 110);
            this.btn_Menu6_2.TabIndex = 148;
            this.btn_Menu6_2.Text = "제로콜라\r\n\r\n1000원";
            this.btn_Menu6_2.UseVisualStyleBackColor = false;
            // 
            // btn_Menu6_3
            // 
            this.btn_Menu6_3.BackColor = System.Drawing.Color.LightBlue;
            this.btn_Menu6_3.Font = new System.Drawing.Font("굴림", 14F, System.Drawing.FontStyle.Bold);
            this.btn_Menu6_3.ForeColor = System.Drawing.Color.Black;
            this.btn_Menu6_3.Location = new System.Drawing.Point(274, 6);
            this.btn_Menu6_3.Name = "btn_Menu6_3";
            this.btn_Menu6_3.Size = new System.Drawing.Size(110, 110);
            this.btn_Menu6_3.TabIndex = 147;
            this.btn_Menu6_3.Text = "환타파인\r\n\r\n1000원";
            this.btn_Menu6_3.UseVisualStyleBackColor = false;
            // 
            // btn_Menu6_5
            // 
            this.btn_Menu6_5.BackColor = System.Drawing.Color.LightBlue;
            this.btn_Menu6_5.Font = new System.Drawing.Font("굴림", 14F, System.Drawing.FontStyle.Bold);
            this.btn_Menu6_5.ForeColor = System.Drawing.Color.Black;
            this.btn_Menu6_5.Location = new System.Drawing.Point(24, 126);
            this.btn_Menu6_5.Name = "btn_Menu6_5";
            this.btn_Menu6_5.Size = new System.Drawing.Size(110, 110);
            this.btn_Menu6_5.TabIndex = 145;
            this.btn_Menu6_5.Text = "사이다\r\n\r\n1000원";
            this.btn_Menu6_5.UseVisualStyleBackColor = false;
            // 
            // btn_Menu6_6
            // 
            this.btn_Menu6_6.BackColor = System.Drawing.Color.LightBlue;
            this.btn_Menu6_6.Font = new System.Drawing.Font("굴림", 14F, System.Drawing.FontStyle.Bold);
            this.btn_Menu6_6.ForeColor = System.Drawing.Color.Black;
            this.btn_Menu6_6.Location = new System.Drawing.Point(149, 126);
            this.btn_Menu6_6.Name = "btn_Menu6_6";
            this.btn_Menu6_6.Size = new System.Drawing.Size(110, 110);
            this.btn_Menu6_6.TabIndex = 144;
            this.btn_Menu6_6.Text = "메뉴 6";
            this.btn_Menu6_6.UseVisualStyleBackColor = false;
            // 
            // btn_Menu6_7
            // 
            this.btn_Menu6_7.BackColor = System.Drawing.Color.LightBlue;
            this.btn_Menu6_7.Font = new System.Drawing.Font("굴림", 14F, System.Drawing.FontStyle.Bold);
            this.btn_Menu6_7.ForeColor = System.Drawing.Color.Black;
            this.btn_Menu6_7.Location = new System.Drawing.Point(274, 122);
            this.btn_Menu6_7.Name = "btn_Menu6_7";
            this.btn_Menu6_7.Size = new System.Drawing.Size(110, 110);
            this.btn_Menu6_7.TabIndex = 143;
            this.btn_Menu6_7.Text = "메뉴 7";
            this.btn_Menu6_7.UseVisualStyleBackColor = false;
            // 
            // btn_Menu6_9
            // 
            this.btn_Menu6_9.BackColor = System.Drawing.Color.LightBlue;
            this.btn_Menu6_9.Font = new System.Drawing.Font("굴림", 14F, System.Drawing.FontStyle.Bold);
            this.btn_Menu6_9.ForeColor = System.Drawing.Color.Black;
            this.btn_Menu6_9.Location = new System.Drawing.Point(24, 242);
            this.btn_Menu6_9.Name = "btn_Menu6_9";
            this.btn_Menu6_9.Size = new System.Drawing.Size(110, 110);
            this.btn_Menu6_9.TabIndex = 141;
            this.btn_Menu6_9.Text = "메뉴 9";
            this.btn_Menu6_9.UseVisualStyleBackColor = false;
            // 
            // btn_Menu6_10
            // 
            this.btn_Menu6_10.BackColor = System.Drawing.Color.LightBlue;
            this.btn_Menu6_10.Font = new System.Drawing.Font("굴림", 14F, System.Drawing.FontStyle.Bold);
            this.btn_Menu6_10.ForeColor = System.Drawing.Color.Black;
            this.btn_Menu6_10.Location = new System.Drawing.Point(149, 242);
            this.btn_Menu6_10.Name = "btn_Menu6_10";
            this.btn_Menu6_10.Size = new System.Drawing.Size(110, 110);
            this.btn_Menu6_10.TabIndex = 140;
            this.btn_Menu6_10.Text = "메뉴 10";
            this.btn_Menu6_10.UseVisualStyleBackColor = false;
            // 
            // btn_Menu6_11
            // 
            this.btn_Menu6_11.BackColor = System.Drawing.Color.LightBlue;
            this.btn_Menu6_11.Font = new System.Drawing.Font("굴림", 14F, System.Drawing.FontStyle.Bold);
            this.btn_Menu6_11.ForeColor = System.Drawing.Color.Black;
            this.btn_Menu6_11.Location = new System.Drawing.Point(274, 242);
            this.btn_Menu6_11.Name = "btn_Menu6_11";
            this.btn_Menu6_11.Size = new System.Drawing.Size(110, 110);
            this.btn_Menu6_11.TabIndex = 139;
            this.btn_Menu6_11.Text = "메뉴 11";
            this.btn_Menu6_11.UseVisualStyleBackColor = false;
            // 
            // Orderwindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1036, 600);
            this.Controls.Add(this.tab_Munu);
            this.Controls.Add(this.orderWin_date);
            this.Controls.Add(this.tb_Change);
            this.Controls.Add(this.tb_Cash);
            this.Controls.Add(this.tb_SumCash);
            this.Controls.Add(this.tb_Discount);
            this.Controls.Add(this.tb_Total);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_MemberInfo);
            this.Controls.Add(this.btn_PaymentBreakdown);
            this.Controls.Add(this.btn_PaymentInfo);
            this.Controls.Add(this.btn_Down);
            this.Controls.Add(this.btn_Up);
            this.Controls.Add(this.btn_CalculatorClear);
            this.Controls.Add(this.btn_Calculator3);
            this.Controls.Add(this.btn_Calculator6);
            this.Controls.Add(this.btn_CalculatorEnter);
            this.Controls.Add(this.btn_Card);
            this.Controls.Add(this.btn_Cash);
            this.Controls.Add(this.btn_Order);
            this.Controls.Add(this.btn_CalculatorBackspace);
            this.Controls.Add(this.btn_Calculator9);
            this.Controls.Add(this.btn_Calculator00);
            this.Controls.Add(this.btn_Calculator0);
            this.Controls.Add(this.btn_Calculator2);
            this.Controls.Add(this.btn_Calculator1);
            this.Controls.Add(this.btn_Calculator5);
            this.Controls.Add(this.btn_Calculator4);
            this.Controls.Add(this.btn_Calculator8);
            this.Controls.Add(this.btn_Calculator7);
            this.Controls.Add(this.btn_QuantityChange);
            this.Controls.Add(this.btn_Plus);
            this.Controls.Add(this.btn_Discount);
            this.Controls.Add(this.btn_Minus);
            this.Controls.Add(this.btn_SelectCancle);
            this.Controls.Add(this.btn_AllCancle);
            this.Controls.Add(this.lv_Order);
            this.Name = "Orderwindow";
            this.Text = "주문";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tab_Munu.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lv_Order;
        private System.Windows.Forms.ColumnHeader Menu;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.ColumnHeader Quantity;
        private System.Windows.Forms.ColumnHeader Total;
        private System.Windows.Forms.ColumnHeader Bigo;
        private System.Windows.Forms.Button btn_AllCancle;
        private System.Windows.Forms.Button btn_SelectCancle;
        private System.Windows.Forms.Button btn_Discount;
        private System.Windows.Forms.Button btn_QuantityChange;
        private System.Windows.Forms.Button btn_Minus;
        private System.Windows.Forms.Button btn_Plus;
        private System.Windows.Forms.Button btn_Up;
        private System.Windows.Forms.Button btn_Down;
        private System.Windows.Forms.Button btn_PaymentInfo;
        private System.Windows.Forms.Button btn_PaymentBreakdown;
        private System.Windows.Forms.Button btn_MemberInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_Total;
        private System.Windows.Forms.TextBox tb_Discount;
        private System.Windows.Forms.TextBox tb_SumCash;
        private System.Windows.Forms.TextBox tb_Cash;
        private System.Windows.Forms.TextBox tb_Change;
        private System.Windows.Forms.Button btn_Calculator7;
        private System.Windows.Forms.Button btn_Calculator8;
        private System.Windows.Forms.Button btn_Calculator9;
        private System.Windows.Forms.Button btn_Calculator4;
        private System.Windows.Forms.Button btn_Calculator5;
        private System.Windows.Forms.Button btn_Calculator6;
        private System.Windows.Forms.Button btn_Calculator1;
        private System.Windows.Forms.Button btn_Calculator2;
        private System.Windows.Forms.Button btn_Calculator3;
        private System.Windows.Forms.Button btn_Calculator0;
        private System.Windows.Forms.Button btn_Calculator00;
        private System.Windows.Forms.Button btn_CalculatorClear;
        private System.Windows.Forms.Button btn_CalculatorBackspace;
        private System.Windows.Forms.Button btn_Order;
        private System.Windows.Forms.Button btn_Cash;
        private System.Windows.Forms.Button btn_Card;
        private System.Windows.Forms.ColumnHeader Number;
        private System.Windows.Forms.Button btn_CalculatorEnter;
        private System.Windows.Forms.DateTimePicker orderWin_date;
        private System.Windows.Forms.TabControl tab_Munu;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_Menu2_1;
        private System.Windows.Forms.Button btn_Menu2_2;
        private System.Windows.Forms.Button btn_Menu2_3;
        private System.Windows.Forms.Button btn_Menu2_5;
        private System.Windows.Forms.Button btn_Menu2_6;
        private System.Windows.Forms.Button btn_Menu2_7;
        private System.Windows.Forms.Button btn_Menu2_9;
        private System.Windows.Forms.Button btn_Menu2_10;
        private System.Windows.Forms.Button btn_Menu2_11;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btn_Menu3_1;
        private System.Windows.Forms.Button btn_Menu3_2;
        private System.Windows.Forms.Button btn_Menu3_3;
        private System.Windows.Forms.Button btn_Menu3_5;
        private System.Windows.Forms.Button btn_Menu3_6;
        private System.Windows.Forms.Button btn_Menu3_7;
        private System.Windows.Forms.Button btn_Menu3_9;
        private System.Windows.Forms.Button btn_Menu3_10;
        private System.Windows.Forms.Button btn_Menu3_11;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Button btn_Menu6_1;
        private System.Windows.Forms.Button btn_Menu6_2;
        private System.Windows.Forms.Button btn_Menu6_3;
        private System.Windows.Forms.Button btn_Menu6_5;
        private System.Windows.Forms.Button btn_Menu6_6;
        private System.Windows.Forms.Button btn_Menu6_7;
        private System.Windows.Forms.Button btn_Menu6_9;
        private System.Windows.Forms.Button btn_Menu6_10;
        private System.Windows.Forms.Button btn_Menu6_11;
    }
}

