namespace winCleaningServicesScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.grpbxOrderIdetification = new System.Windows.Forms.GroupBox();
            this.dptTimeExpected = new System.Windows.Forms.DateTimePicker();
            this.dtpTimeLeft = new System.Windows.Forms.DateTimePicker();
            this.dtpDateExpected = new System.Windows.Forms.DateTimePicker();
            this.dtpDateleft = new System.Windows.Forms.DateTimePicker();
            this.txtCustomerPhone = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label6AT = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpbxOrderProcesing = new System.Windows.Forms.GroupBox();
            this.txtSubTotal_01 = new System.Windows.Forms.TextBox();
            this.txtSubTotal_02 = new System.Windows.Forms.TextBox();
            this.txtSubTotal_03 = new System.Windows.Forms.TextBox();
            this.txtSubTotal_04 = new System.Windows.Forms.TextBox();
            this.txtSubTotal_05 = new System.Windows.Forms.TextBox();
            this.txtSubTotal_06 = new System.Windows.Forms.TextBox();
            this.txtQty1 = new System.Windows.Forms.TextBox();
            this.txtQty2 = new System.Windows.Forms.TextBox();
            this.txtQty3 = new System.Windows.Forms.TextBox();
            this.txtQty4 = new System.Windows.Forms.TextBox();
            this.txtQty5 = new System.Windows.Forms.TextBox();
            this.txtQty6 = new System.Windows.Forms.TextBox();
            this.txtUnitPrice01 = new System.Windows.Forms.TextBox();
            this.txtUnitPrice02 = new System.Windows.Forms.TextBox();
            this.txtUnitPrice03 = new System.Windows.Forms.TextBox();
            this.txtUnitPrice04 = new System.Windows.Forms.TextBox();
            this.txtUnitPrice05 = new System.Windows.Forms.TextBox();
            this.txtUnitPrice06 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbitemSubCatagory3 = new System.Windows.Forms.ComboBox();
            this.cmbitemSubCatagory2 = new System.Windows.Forms.ComboBox();
            this.cmbitemSubCatagory1 = new System.Windows.Forms.ComboBox();
            this.cmbItemTypeName = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtNetPrice = new System.Windows.Forms.TextBox();
            this.TxtTaxAmount = new System.Windows.Forms.TextBox();
            this.TxtTaxRate = new System.Windows.Forms.TextBox();
            this.txtCleaningTotal = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.grpbxOrderIdetification.SuspendLayout();
            this.grpbxOrderProcesing.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbxOrderIdetification
            // 
            this.grpbxOrderIdetification.Controls.Add(this.dptTimeExpected);
            this.grpbxOrderIdetification.Controls.Add(this.dtpTimeLeft);
            this.grpbxOrderIdetification.Controls.Add(this.dtpDateExpected);
            this.grpbxOrderIdetification.Controls.Add(this.dtpDateleft);
            this.grpbxOrderIdetification.Controls.Add(this.txtCustomerPhone);
            this.grpbxOrderIdetification.Controls.Add(this.txtCustomerName);
            this.grpbxOrderIdetification.Controls.Add(this.label6AT);
            this.grpbxOrderIdetification.Controls.Add(this.label5);
            this.grpbxOrderIdetification.Controls.Add(this.label4);
            this.grpbxOrderIdetification.Controls.Add(this.label3);
            this.grpbxOrderIdetification.Controls.Add(this.label2);
            this.grpbxOrderIdetification.Controls.Add(this.label1);
            this.grpbxOrderIdetification.Location = new System.Drawing.Point(37, 28);
            this.grpbxOrderIdetification.Name = "grpbxOrderIdetification";
            this.grpbxOrderIdetification.Size = new System.Drawing.Size(629, 180);
            this.grpbxOrderIdetification.TabIndex = 0;
            this.grpbxOrderIdetification.TabStop = false;
            this.grpbxOrderIdetification.Text = "Order Identification";
            // 
            // dptTimeExpected
            // 
            this.dptTimeExpected.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dptTimeExpected.Location = new System.Drawing.Point(482, 126);
            this.dptTimeExpected.Name = "dptTimeExpected";
            this.dptTimeExpected.ShowUpDown = true;
            this.dptTimeExpected.Size = new System.Drawing.Size(98, 20);
            this.dptTimeExpected.TabIndex = 4;
            // 
            // dtpTimeLeft
            // 
            this.dtpTimeLeft.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTimeLeft.Location = new System.Drawing.Point(482, 83);
            this.dtpTimeLeft.Name = "dtpTimeLeft";
            this.dtpTimeLeft.ShowUpDown = true;
            this.dtpTimeLeft.Size = new System.Drawing.Size(100, 20);
            this.dtpTimeLeft.TabIndex = 3;
            // 
            // dtpDateExpected
            // 
            this.dtpDateExpected.Location = new System.Drawing.Point(134, 126);
            this.dtpDateExpected.Name = "dtpDateExpected";
            this.dtpDateExpected.Size = new System.Drawing.Size(216, 20);
            this.dtpDateExpected.TabIndex = 12;
            // 
            // dtpDateleft
            // 
            this.dtpDateleft.Location = new System.Drawing.Point(134, 77);
            this.dtpDateleft.Name = "dtpDateleft";
            this.dtpDateleft.Size = new System.Drawing.Size(216, 20);
            this.dtpDateleft.TabIndex = 3;
            // 
            // txtCustomerPhone
            // 
            this.txtCustomerPhone.Location = new System.Drawing.Point(482, 33);
            this.txtCustomerPhone.Name = "txtCustomerPhone";
            this.txtCustomerPhone.Size = new System.Drawing.Size(100, 20);
            this.txtCustomerPhone.TabIndex = 9;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(134, 33);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(216, 20);
            this.txtCustomerName.TabIndex = 6;
            // 
            // label6AT
            // 
            this.label6AT.AutoSize = true;
            this.label6AT.Location = new System.Drawing.Point(381, 133);
            this.label6AT.Name = "label6AT";
            this.label6AT.Size = new System.Drawing.Size(78, 13);
            this.label6AT.TabIndex = 5;
            this.label6AT.Text = "Time Expected";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(381, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Time Left";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(381, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Customer Phone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date Expected";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date Left";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Name";
            // 
            // grpbxOrderProcesing
            // 
            this.grpbxOrderProcesing.Controls.Add(this.txtSubTotal_01);
            this.grpbxOrderProcesing.Controls.Add(this.txtSubTotal_02);
            this.grpbxOrderProcesing.Controls.Add(this.txtSubTotal_03);
            this.grpbxOrderProcesing.Controls.Add(this.txtSubTotal_04);
            this.grpbxOrderProcesing.Controls.Add(this.txtSubTotal_05);
            this.grpbxOrderProcesing.Controls.Add(this.txtSubTotal_06);
            this.grpbxOrderProcesing.Controls.Add(this.txtQty1);
            this.grpbxOrderProcesing.Controls.Add(this.txtQty2);
            this.grpbxOrderProcesing.Controls.Add(this.txtQty3);
            this.grpbxOrderProcesing.Controls.Add(this.txtQty4);
            this.grpbxOrderProcesing.Controls.Add(this.txtQty5);
            this.grpbxOrderProcesing.Controls.Add(this.txtQty6);
            this.grpbxOrderProcesing.Controls.Add(this.txtUnitPrice01);
            this.grpbxOrderProcesing.Controls.Add(this.txtUnitPrice02);
            this.grpbxOrderProcesing.Controls.Add(this.txtUnitPrice03);
            this.grpbxOrderProcesing.Controls.Add(this.txtUnitPrice04);
            this.grpbxOrderProcesing.Controls.Add(this.txtUnitPrice05);
            this.grpbxOrderProcesing.Controls.Add(this.txtUnitPrice06);
            this.grpbxOrderProcesing.Controls.Add(this.label12);
            this.grpbxOrderProcesing.Controls.Add(this.label11);
            this.grpbxOrderProcesing.Controls.Add(this.label10);
            this.grpbxOrderProcesing.Controls.Add(this.cmbitemSubCatagory3);
            this.grpbxOrderProcesing.Controls.Add(this.cmbitemSubCatagory2);
            this.grpbxOrderProcesing.Controls.Add(this.cmbitemSubCatagory1);
            this.grpbxOrderProcesing.Controls.Add(this.cmbItemTypeName);
            this.grpbxOrderProcesing.Controls.Add(this.label9);
            this.grpbxOrderProcesing.Controls.Add(this.label8);
            this.grpbxOrderProcesing.Controls.Add(this.label7);
            this.grpbxOrderProcesing.Location = new System.Drawing.Point(37, 217);
            this.grpbxOrderProcesing.Name = "grpbxOrderProcesing";
            this.grpbxOrderProcesing.Size = new System.Drawing.Size(412, 267);
            this.grpbxOrderProcesing.TabIndex = 1;
            this.grpbxOrderProcesing.TabStop = false;
            this.grpbxOrderProcesing.Text = "Order Processing";
            // 
            // txtSubTotal_01
            // 
            this.txtSubTotal_01.Location = new System.Drawing.Point(338, 64);
            this.txtSubTotal_01.Name = "txtSubTotal_01";
            this.txtSubTotal_01.Size = new System.Drawing.Size(53, 20);
            this.txtSubTotal_01.TabIndex = 37;
            // 
            // txtSubTotal_02
            // 
            this.txtSubTotal_02.Location = new System.Drawing.Point(338, 95);
            this.txtSubTotal_02.Name = "txtSubTotal_02";
            this.txtSubTotal_02.Size = new System.Drawing.Size(53, 20);
            this.txtSubTotal_02.TabIndex = 36;
            // 
            // txtSubTotal_03
            // 
            this.txtSubTotal_03.Location = new System.Drawing.Point(338, 130);
            this.txtSubTotal_03.Name = "txtSubTotal_03";
            this.txtSubTotal_03.Size = new System.Drawing.Size(53, 20);
            this.txtSubTotal_03.TabIndex = 35;
            // 
            // txtSubTotal_04
            // 
            this.txtSubTotal_04.Location = new System.Drawing.Point(338, 161);
            this.txtSubTotal_04.Name = "txtSubTotal_04";
            this.txtSubTotal_04.Size = new System.Drawing.Size(53, 20);
            this.txtSubTotal_04.TabIndex = 34;
            // 
            // txtSubTotal_05
            // 
            this.txtSubTotal_05.Location = new System.Drawing.Point(338, 193);
            this.txtSubTotal_05.Name = "txtSubTotal_05";
            this.txtSubTotal_05.Size = new System.Drawing.Size(53, 20);
            this.txtSubTotal_05.TabIndex = 33;
            // 
            // txtSubTotal_06
            // 
            this.txtSubTotal_06.Location = new System.Drawing.Point(338, 224);
            this.txtSubTotal_06.Name = "txtSubTotal_06";
            this.txtSubTotal_06.Size = new System.Drawing.Size(53, 20);
            this.txtSubTotal_06.TabIndex = 32;
            // 
            // txtQty1
            // 
            this.txtQty1.Location = new System.Drawing.Point(290, 63);
            this.txtQty1.Name = "txtQty1";
            this.txtQty1.Size = new System.Drawing.Size(31, 20);
            this.txtQty1.TabIndex = 31;
            // 
            // txtQty2
            // 
            this.txtQty2.Location = new System.Drawing.Point(290, 94);
            this.txtQty2.Name = "txtQty2";
            this.txtQty2.Size = new System.Drawing.Size(31, 20);
            this.txtQty2.TabIndex = 30;
            // 
            // txtQty3
            // 
            this.txtQty3.Location = new System.Drawing.Point(290, 130);
            this.txtQty3.Name = "txtQty3";
            this.txtQty3.Size = new System.Drawing.Size(31, 20);
            this.txtQty3.TabIndex = 29;
            // 
            // txtQty4
            // 
            this.txtQty4.Location = new System.Drawing.Point(290, 161);
            this.txtQty4.Name = "txtQty4";
            this.txtQty4.Size = new System.Drawing.Size(31, 20);
            this.txtQty4.TabIndex = 28;
            // 
            // txtQty5
            // 
            this.txtQty5.Location = new System.Drawing.Point(290, 193);
            this.txtQty5.Name = "txtQty5";
            this.txtQty5.Size = new System.Drawing.Size(31, 20);
            this.txtQty5.TabIndex = 27;
            // 
            // txtQty6
            // 
            this.txtQty6.Location = new System.Drawing.Point(290, 224);
            this.txtQty6.Name = "txtQty6";
            this.txtQty6.Size = new System.Drawing.Size(31, 20);
            this.txtQty6.TabIndex = 26;
            // 
            // txtUnitPrice01
            // 
            this.txtUnitPrice01.Location = new System.Drawing.Point(223, 63);
            this.txtUnitPrice01.Name = "txtUnitPrice01";
            this.txtUnitPrice01.Size = new System.Drawing.Size(53, 20);
            this.txtUnitPrice01.TabIndex = 25;
            // 
            // txtUnitPrice02
            // 
            this.txtUnitPrice02.Location = new System.Drawing.Point(223, 94);
            this.txtUnitPrice02.Name = "txtUnitPrice02";
            this.txtUnitPrice02.Size = new System.Drawing.Size(53, 20);
            this.txtUnitPrice02.TabIndex = 24;
            // 
            // txtUnitPrice03
            // 
            this.txtUnitPrice03.Location = new System.Drawing.Point(223, 129);
            this.txtUnitPrice03.Name = "txtUnitPrice03";
            this.txtUnitPrice03.Size = new System.Drawing.Size(53, 20);
            this.txtUnitPrice03.TabIndex = 23;
            // 
            // txtUnitPrice04
            // 
            this.txtUnitPrice04.Location = new System.Drawing.Point(223, 160);
            this.txtUnitPrice04.Name = "txtUnitPrice04";
            this.txtUnitPrice04.Size = new System.Drawing.Size(53, 20);
            this.txtUnitPrice04.TabIndex = 22;
            // 
            // txtUnitPrice05
            // 
            this.txtUnitPrice05.Location = new System.Drawing.Point(223, 192);
            this.txtUnitPrice05.Name = "txtUnitPrice05";
            this.txtUnitPrice05.Size = new System.Drawing.Size(53, 20);
            this.txtUnitPrice05.TabIndex = 21;
            // 
            // txtUnitPrice06
            // 
            this.txtUnitPrice06.Location = new System.Drawing.Point(223, 223);
            this.txtUnitPrice06.Name = "txtUnitPrice06";
            this.txtUnitPrice06.Size = new System.Drawing.Size(53, 20);
            this.txtUnitPrice06.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(296, 41);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(23, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "Qty";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(338, 41);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Sub-Total";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(220, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Unit Price";
            // 
            // cmbitemSubCatagory3
            // 
            this.cmbitemSubCatagory3.FormattingEnabled = true;
            this.cmbitemSubCatagory3.Items.AddRange(new object[] {
            "None"});
            this.cmbitemSubCatagory3.Location = new System.Drawing.Point(25, 223);
            this.cmbitemSubCatagory3.Name = "cmbitemSubCatagory3";
            this.cmbitemSubCatagory3.Size = new System.Drawing.Size(186, 21);
            this.cmbitemSubCatagory3.TabIndex = 15;
            // 
            // cmbitemSubCatagory2
            // 
            this.cmbitemSubCatagory2.FormattingEnabled = true;
            this.cmbitemSubCatagory2.Items.AddRange(new object[] {
            "None"});
            this.cmbitemSubCatagory2.Location = new System.Drawing.Point(25, 192);
            this.cmbitemSubCatagory2.Name = "cmbitemSubCatagory2";
            this.cmbitemSubCatagory2.Size = new System.Drawing.Size(186, 21);
            this.cmbitemSubCatagory2.TabIndex = 14;
            // 
            // cmbitemSubCatagory1
            // 
            this.cmbitemSubCatagory1.FormattingEnabled = true;
            this.cmbitemSubCatagory1.Items.AddRange(new object[] {
            "Jacket",
            "T-Shirt",
            "None"});
            this.cmbitemSubCatagory1.Location = new System.Drawing.Point(25, 160);
            this.cmbitemSubCatagory1.Name = "cmbitemSubCatagory1";
            this.cmbitemSubCatagory1.Size = new System.Drawing.Size(186, 21);
            this.cmbitemSubCatagory1.TabIndex = 13;
            // 
            // cmbItemTypeName
            // 
            this.cmbItemTypeName.FormattingEnabled = true;
            this.cmbItemTypeName.Items.AddRange(new object[] {
            "Men\'s Suit2Pc",
            "Ladies Suit 3Pc",
            "None"});
            this.cmbItemTypeName.Location = new System.Drawing.Point(25, 129);
            this.cmbItemTypeName.Name = "cmbItemTypeName";
            this.cmbItemTypeName.Size = new System.Drawing.Size(186, 21);
            this.cmbItemTypeName.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Paints";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Shirts";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Item Type";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.TxtNetPrice);
            this.groupBox3.Controls.Add(this.TxtTaxAmount);
            this.groupBox3.Controls.Add(this.TxtTaxRate);
            this.groupBox3.Controls.Add(this.txtCleaningTotal);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.btnClose);
            this.groupBox3.Controls.Add(this.btnCalculate);
            this.groupBox3.Location = new System.Drawing.Point(468, 217);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(198, 267);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Order Summery";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(177, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "%";
            // 
            // TxtNetPrice
            // 
            this.TxtNetPrice.Location = new System.Drawing.Point(122, 171);
            this.TxtNetPrice.Name = "TxtNetPrice";
            this.TxtNetPrice.Size = new System.Drawing.Size(53, 20);
            this.TxtNetPrice.TabIndex = 26;
            // 
            // TxtTaxAmount
            // 
            this.TxtTaxAmount.Location = new System.Drawing.Point(122, 141);
            this.TxtTaxAmount.Name = "TxtTaxAmount";
            this.TxtTaxAmount.Size = new System.Drawing.Size(53, 20);
            this.TxtTaxAmount.TabIndex = 25;
            // 
            // TxtTaxRate
            // 
            this.TxtTaxRate.Location = new System.Drawing.Point(122, 113);
            this.TxtTaxRate.Name = "TxtTaxRate";
            this.TxtTaxRate.Size = new System.Drawing.Size(53, 20);
            this.TxtTaxRate.TabIndex = 24;
            // 
            // txtCleaningTotal
            // 
            this.txtCleaningTotal.Location = new System.Drawing.Point(122, 83);
            this.txtCleaningTotal.Name = "txtCleaningTotal";
            this.txtCleaningTotal.Size = new System.Drawing.Size(53, 20);
            this.txtCleaningTotal.TabIndex = 20;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(17, 174);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 13);
            this.label15.TabIndex = 23;
            this.label15.Text = "Net Price";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(17, 144);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(64, 13);
            this.label16.TabIndex = 22;
            this.label16.Text = "Tax Amount";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(17, 116);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 13);
            this.label14.TabIndex = 21;
            this.label14.Text = "Tax Rate";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(17, 86);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 13);
            this.label13.TabIndex = 20;
            this.label13.Text = "Cleaning Total";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(20, 209);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(155, 39);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(20, 30);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(155, 39);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // skinEngine1
            // 
            this.skinEngine1.@__DrawButtonFocusRectangle = true;
            this.skinEngine1.DisabledButtonTextColor = System.Drawing.Color.Gray;
            this.skinEngine1.DisabledMenuFontColor = System.Drawing.SystemColors.GrayText;
            this.skinEngine1.InactiveCaptionColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.skinEngine1.SerialNumber = "";
            this.skinEngine1.SkinFile = "C:\\Program Files (x86)\\Sunisoft\\IrisSkin\\Skins\\One\\OneBlue.ssk";
            this.skinEngine1.SkinStreamMain = ((System.IO.Stream)(resources.GetObject("skinEngine1.SkinStreamMain")));
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 514);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grpbxOrderProcesing);
            this.Controls.Add(this.grpbxOrderIdetification);
            this.Name = "Form1";
            this.Text = "Georgetown Cleaning Service";
            this.grpbxOrderIdetification.ResumeLayout(false);
            this.grpbxOrderIdetification.PerformLayout();
            this.grpbxOrderProcesing.ResumeLayout(false);
            this.grpbxOrderProcesing.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbxOrderIdetification;
        private System.Windows.Forms.TextBox txtCustomerPhone;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label6AT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpbxOrderProcesing;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbitemSubCatagory3;
        private System.Windows.Forms.ComboBox cmbitemSubCatagory2;
        private System.Windows.Forms.ComboBox cmbitemSubCatagory1;
        private System.Windows.Forms.ComboBox cmbItemTypeName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox TxtNetPrice;
        private System.Windows.Forms.TextBox TxtTaxAmount;
        private System.Windows.Forms.TextBox TxtTaxRate;
        private System.Windows.Forms.TextBox txtCleaningTotal;
        private System.Windows.Forms.TextBox txtQty1;
        private System.Windows.Forms.TextBox txtQty2;
        private System.Windows.Forms.TextBox txtQty3;
        private System.Windows.Forms.TextBox txtQty4;
        private System.Windows.Forms.TextBox txtQty5;
        private System.Windows.Forms.TextBox txtQty6;
        private System.Windows.Forms.TextBox txtUnitPrice01;
        private System.Windows.Forms.TextBox txtUnitPrice02;
        private System.Windows.Forms.TextBox txtUnitPrice03;
        private System.Windows.Forms.TextBox txtUnitPrice04;
        private System.Windows.Forms.TextBox txtUnitPrice05;
        private System.Windows.Forms.TextBox txtUnitPrice06;
        private System.Windows.Forms.TextBox txtSubTotal_01;
        private System.Windows.Forms.TextBox txtSubTotal_02;
        private System.Windows.Forms.TextBox txtSubTotal_03;
        private System.Windows.Forms.TextBox txtSubTotal_04;
        private System.Windows.Forms.TextBox txtSubTotal_05;
        private System.Windows.Forms.TextBox txtSubTotal_06;
        private System.Windows.Forms.DateTimePicker dtpDateExpected;
        private System.Windows.Forms.DateTimePicker dtpDateleft;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpTimeLeft;
        private System.Windows.Forms.DateTimePicker dptTimeExpected;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
    }
}

