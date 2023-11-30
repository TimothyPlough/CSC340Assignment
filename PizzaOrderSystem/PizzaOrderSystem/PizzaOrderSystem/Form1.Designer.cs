namespace PizzaOrderSystem
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnOrderHis = new System.Windows.Forms.Button();
            this.btnEditAcc = new System.Windows.Forms.Button();
            this.btnAccSign = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAccSubmit = new System.Windows.Forms.Button();
            this.btnAccCancel = new System.Windows.Forms.Button();
            this.Passtxt = new System.Windows.Forms.TextBox();
            this.UNametxt = new System.Windows.Forms.TextBox();
            this.Phonetxt = new System.Windows.Forms.TextBox();
            this.Addtxt = new System.Windows.Forms.TextBox();
            this.Nametxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.DDOrderStatus = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtPriceStatus = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnstatReturn = new System.Windows.Forms.Button();
            this.StatusTxt = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.HistoryBoxList = new System.Windows.Forms.ListBox();
            this.btnReOrder = new System.Windows.Forms.Button();
            this.DDOrderHis = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.button11 = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.OrderSizeDD = new System.Windows.Forms.ComboBox();
            this.btnOrderNow = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.OrderListtxt = new System.Windows.Forms.ListBox();
            this.OrderPizzaDD = new System.Windows.Forms.ComboBox();
            this.btnAccLog = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnLogSubmit = new System.Windows.Forms.Button();
            this.btnLogCancel = new System.Windows.Forms.Button();
            this.txtLogPassword = new System.Windows.Forms.TextBox();
            this.txtLogEmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtEditPass = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnEditSubmit = new System.Windows.Forms.Button();
            this.btnEditCancel = new System.Windows.Forms.Button();
            this.txtEditPhone = new System.Windows.Forms.TextBox();
            this.txtEditAdd = new System.Windows.Forms.TextBox();
            this.txtEditName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txtOrderPriceTotal = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.txtReOrderPrice = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnOrder);
            this.panel1.Controls.Add(this.btnCheck);
            this.panel1.Controls.Add(this.btnOrderHis);
            this.panel1.Controls.Add(this.btnEditAcc);
            this.panel1.Location = new System.Drawing.Point(59, 74);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(224, 391);
            this.panel1.TabIndex = 0;
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(33, 30);
            this.btnOrder.Margin = new System.Windows.Forms.Padding(4);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(153, 52);
            this.btnOrder.TabIndex = 5;
            this.btnOrder.Text = "Order Pizza";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.orderPizza_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(33, 110);
            this.btnCheck.Margin = new System.Windows.Forms.Padding(4);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(153, 52);
            this.btnCheck.TabIndex = 4;
            this.btnCheck.Text = "Check Order Status";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.orderStatus_Click);
            // 
            // btnOrderHis
            // 
            this.btnOrderHis.Location = new System.Drawing.Point(33, 206);
            this.btnOrderHis.Margin = new System.Windows.Forms.Padding(4);
            this.btnOrderHis.Name = "btnOrderHis";
            this.btnOrderHis.Size = new System.Drawing.Size(153, 52);
            this.btnOrderHis.TabIndex = 3;
            this.btnOrderHis.Text = "Check Order Histoty";
            this.btnOrderHis.UseVisualStyleBackColor = true;
            this.btnOrderHis.Click += new System.EventHandler(this.orderHistory_Click);
            // 
            // btnEditAcc
            // 
            this.btnEditAcc.Location = new System.Drawing.Point(33, 295);
            this.btnEditAcc.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditAcc.Name = "btnEditAcc";
            this.btnEditAcc.Size = new System.Drawing.Size(153, 52);
            this.btnEditAcc.TabIndex = 1;
            this.btnEditAcc.Text = "Edit Account";
            this.btnEditAcc.UseVisualStyleBackColor = true;
            this.btnEditAcc.Click += new System.EventHandler(this.editAccount_Click);
            // 
            // btnAccSign
            // 
            this.btnAccSign.Location = new System.Drawing.Point(173, 487);
            this.btnAccSign.Margin = new System.Windows.Forms.Padding(4);
            this.btnAccSign.Name = "btnAccSign";
            this.btnAccSign.Size = new System.Drawing.Size(153, 52);
            this.btnAccSign.TabIndex = 2;
            this.btnAccSign.Text = "Account SignUp";
            this.btnAccSign.UseVisualStyleBackColor = true;
            this.btnAccSign.Click += new System.EventHandler(this.accountCreate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(343, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome to Pizza Chain";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel2.Controls.Add(this.btnAccSubmit);
            this.panel2.Controls.Add(this.btnAccCancel);
            this.panel2.Controls.Add(this.Passtxt);
            this.panel2.Controls.Add(this.UNametxt);
            this.panel2.Controls.Add(this.Phonetxt);
            this.panel2.Controls.Add(this.Addtxt);
            this.panel2.Controls.Add(this.Nametxt);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(392, 74);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(539, 465);
            this.panel2.TabIndex = 2;
            // 
            // btnAccSubmit
            // 
            this.btnAccSubmit.Location = new System.Drawing.Point(279, 372);
            this.btnAccSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.btnAccSubmit.Name = "btnAccSubmit";
            this.btnAccSubmit.Size = new System.Drawing.Size(137, 44);
            this.btnAccSubmit.TabIndex = 12;
            this.btnAccSubmit.Text = "Submit";
            this.btnAccSubmit.UseVisualStyleBackColor = true;
            this.btnAccSubmit.Click += new System.EventHandler(this.appSubmit_Click);
            // 
            // btnAccCancel
            // 
            this.btnAccCancel.Location = new System.Drawing.Point(103, 372);
            this.btnAccCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnAccCancel.Name = "btnAccCancel";
            this.btnAccCancel.Size = new System.Drawing.Size(137, 44);
            this.btnAccCancel.TabIndex = 11;
            this.btnAccCancel.Text = "Cancel";
            this.btnAccCancel.UseVisualStyleBackColor = true;
            this.btnAccCancel.Click += new System.EventHandler(this.appCancel_Click);
            // 
            // Passtxt
            // 
            this.Passtxt.Location = new System.Drawing.Point(193, 288);
            this.Passtxt.Margin = new System.Windows.Forms.Padding(4);
            this.Passtxt.Name = "Passtxt";
            this.Passtxt.Size = new System.Drawing.Size(221, 22);
            this.Passtxt.TabIndex = 10;
            // 
            // UNametxt
            // 
            this.UNametxt.Location = new System.Drawing.Point(193, 236);
            this.UNametxt.Margin = new System.Windows.Forms.Padding(4);
            this.UNametxt.Name = "UNametxt";
            this.UNametxt.Size = new System.Drawing.Size(221, 22);
            this.UNametxt.TabIndex = 9;
            // 
            // Phonetxt
            // 
            this.Phonetxt.Location = new System.Drawing.Point(193, 190);
            this.Phonetxt.Margin = new System.Windows.Forms.Padding(4);
            this.Phonetxt.Name = "Phonetxt";
            this.Phonetxt.Size = new System.Drawing.Size(221, 22);
            this.Phonetxt.TabIndex = 8;
            // 
            // Addtxt
            // 
            this.Addtxt.Location = new System.Drawing.Point(193, 140);
            this.Addtxt.Margin = new System.Windows.Forms.Padding(4);
            this.Addtxt.Name = "Addtxt";
            this.Addtxt.Size = new System.Drawing.Size(221, 22);
            this.Addtxt.TabIndex = 7;
            // 
            // Nametxt
            // 
            this.Nametxt.Location = new System.Drawing.Point(193, 92);
            this.Nametxt.Margin = new System.Windows.Forms.Padding(4);
            this.Nametxt.Name = "Nametxt";
            this.Nametxt.Size = new System.Drawing.Size(221, 22);
            this.Nametxt.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(104, 290);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(71, 193);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Phone Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(115, 144);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 240);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Email - User Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 96);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Member Application Form";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel4.Controls.Add(this.DDOrderStatus);
            this.panel4.Controls.Add(this.label21);
            this.panel4.Controls.Add(this.txtPriceStatus);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.btnstatReturn);
            this.panel4.Controls.Add(this.StatusTxt);
            this.panel4.Location = new System.Drawing.Point(391, 75);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(539, 465);
            this.panel4.TabIndex = 14;
            // 
            // DDOrderStatus
            // 
            this.DDOrderStatus.AutoCompleteCustomSource.AddRange(new string[] {
            "Cheese",
            "Sausage",
            "Pepperoni"});
            this.DDOrderStatus.FormattingEnabled = true;
            this.DDOrderStatus.Location = new System.Drawing.Point(23, 114);
            this.DDOrderStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DDOrderStatus.Name = "DDOrderStatus";
            this.DDOrderStatus.Size = new System.Drawing.Size(500, 24);
            this.DDOrderStatus.TabIndex = 44;
            this.DDOrderStatus.SelectedIndexChanged += new System.EventHandler(this.DDOrderStatus_SelectedIndexChanged);
            // 
            // label21
            // 
            this.label21.Cursor = System.Windows.Forms.Cursors.Default;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Maroon;
            this.label21.Location = new System.Drawing.Point(113, 271);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(344, 57);
            this.label21.TabIndex = 42;
            this.label21.Text = "[Pay at Store]";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPriceStatus
            // 
            this.txtPriceStatus.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtPriceStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPriceStatus.ForeColor = System.Drawing.Color.Maroon;
            this.txtPriceStatus.Location = new System.Drawing.Point(113, 226);
            this.txtPriceStatus.Name = "txtPriceStatus";
            this.txtPriceStatus.Size = new System.Drawing.Size(344, 57);
            this.txtPriceStatus.TabIndex = 41;
            this.txtPriceStatus.Text = "[ENTER PRICE HERE]";
            this.txtPriceStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(109, 42);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(339, 39);
            this.label14.TabIndex = 13;
            this.label14.Text = "Current Order Status:";
            // 
            // btnstatReturn
            // 
            this.btnstatReturn.Location = new System.Drawing.Point(208, 407);
            this.btnstatReturn.Margin = new System.Windows.Forms.Padding(4);
            this.btnstatReturn.Name = "btnstatReturn";
            this.btnstatReturn.Size = new System.Drawing.Size(137, 44);
            this.btnstatReturn.TabIndex = 12;
            this.btnstatReturn.Text = "Return";
            this.btnstatReturn.UseVisualStyleBackColor = true;
            this.btnstatReturn.Click += new System.EventHandler(this.statusReturn_Click);
            // 
            // StatusTxt
            // 
            this.StatusTxt.Cursor = System.Windows.Forms.Cursors.Default;
            this.StatusTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusTxt.ForeColor = System.Drawing.Color.Maroon;
            this.StatusTxt.Location = new System.Drawing.Point(113, 165);
            this.StatusTxt.Name = "StatusTxt";
            this.StatusTxt.Size = new System.Drawing.Size(344, 57);
            this.StatusTxt.TabIndex = 40;
            this.StatusTxt.Text = "[ENTER STATUS HERE]";
            this.StatusTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel5.Controls.Add(this.label22);
            this.panel5.Controls.Add(this.txtReOrderPrice);
            this.panel5.Controls.Add(this.HistoryBoxList);
            this.panel5.Controls.Add(this.btnReOrder);
            this.panel5.Controls.Add(this.DDOrderHis);
            this.panel5.Controls.Add(this.label17);
            this.panel5.Controls.Add(this.button11);
            this.panel5.Location = new System.Drawing.Point(392, 74);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(539, 465);
            this.panel5.TabIndex = 41;
            // 
            // HistoryBoxList
            // 
            this.HistoryBoxList.FormattingEnabled = true;
            this.HistoryBoxList.ItemHeight = 16;
            this.HistoryBoxList.Location = new System.Drawing.Point(20, 164);
            this.HistoryBoxList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HistoryBoxList.Name = "HistoryBoxList";
            this.HistoryBoxList.Size = new System.Drawing.Size(501, 164);
            this.HistoryBoxList.TabIndex = 45;
            // 
            // btnReOrder
            // 
            this.btnReOrder.Location = new System.Drawing.Point(279, 407);
            this.btnReOrder.Margin = new System.Windows.Forms.Padding(4);
            this.btnReOrder.Name = "btnReOrder";
            this.btnReOrder.Size = new System.Drawing.Size(137, 44);
            this.btnReOrder.TabIndex = 44;
            this.btnReOrder.Text = "Reorder";
            this.btnReOrder.UseVisualStyleBackColor = true;
            this.btnReOrder.Click += new System.EventHandler(this.historyReOrder_Click);
            // 
            // DDOrderHis
            // 
            this.DDOrderHis.FormattingEnabled = true;
            this.DDOrderHis.Location = new System.Drawing.Point(21, 84);
            this.DDOrderHis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DDOrderHis.Name = "DDOrderHis";
            this.DDOrderHis.Size = new System.Drawing.Size(500, 24);
            this.DDOrderHis.TabIndex = 43;
            this.DDOrderHis.SelectedIndexChanged += new System.EventHandler(this.DDOrderHis_SelectedIndexChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(163, 25);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(227, 39);
            this.label17.TabIndex = 13;
            this.label17.Text = "Order History:";
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(131, 407);
            this.button11.Margin = new System.Windows.Forms.Padding(4);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(137, 44);
            this.button11.TabIndex = 12;
            this.button11.Text = "Cancel";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.historyCancel_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel6.Controls.Add(this.label20);
            this.panel6.Controls.Add(this.txtOrderPriceTotal);
            this.panel6.Controls.Add(this.btnAddOrder);
            this.panel6.Controls.Add(this.OrderSizeDD);
            this.panel6.Controls.Add(this.btnOrderNow);
            this.panel6.Controls.Add(this.label16);
            this.panel6.Controls.Add(this.btnCancel);
            this.panel6.Controls.Add(this.OrderListtxt);
            this.panel6.Controls.Add(this.OrderPizzaDD);
            this.panel6.Location = new System.Drawing.Point(391, 74);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(539, 465);
            this.panel6.TabIndex = 45;
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Location = new System.Drawing.Point(208, 407);
            this.btnAddOrder.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(137, 44);
            this.btnAddOrder.TabIndex = 47;
            this.btnAddOrder.Text = "Add to Order";
            this.btnAddOrder.UseVisualStyleBackColor = true;
            this.btnAddOrder.Click += new System.EventHandler(this.AddOrder_Click);
            // 
            // OrderSizeDD
            // 
            this.OrderSizeDD.AutoCompleteCustomSource.AddRange(new string[] {
            "Small",
            "Medeum",
            "Large"});
            this.OrderSizeDD.FormattingEnabled = true;
            this.OrderSizeDD.Items.AddRange(new object[] {
            "Small - $6",
            "Medium - $12",
            "Large - $16"});
            this.OrderSizeDD.Location = new System.Drawing.Point(187, 150);
            this.OrderSizeDD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OrderSizeDD.Name = "OrderSizeDD";
            this.OrderSizeDD.Size = new System.Drawing.Size(175, 24);
            this.OrderSizeDD.TabIndex = 45;
            // 
            // btnOrderNow
            // 
            this.btnOrderNow.Location = new System.Drawing.Point(384, 407);
            this.btnOrderNow.Margin = new System.Windows.Forms.Padding(4);
            this.btnOrderNow.Name = "btnOrderNow";
            this.btnOrderNow.Size = new System.Drawing.Size(137, 44);
            this.btnOrderNow.TabIndex = 44;
            this.btnOrderNow.Text = "Order Now";
            this.btnOrderNow.UseVisualStyleBackColor = true;
            this.btnOrderNow.Click += new System.EventHandler(this.OrderNow_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(180, 16);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(195, 39);
            this.label16.TabIndex = 13;
            this.label16.Text = "Order Here:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(21, 407);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(137, 44);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.orderCancel_Click);
            // 
            // OrderListtxt
            // 
            this.OrderListtxt.FormattingEnabled = true;
            this.OrderListtxt.ItemHeight = 16;
            this.OrderListtxt.Location = new System.Drawing.Point(3, 194);
            this.OrderListtxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OrderListtxt.Name = "OrderListtxt";
            this.OrderListtxt.Size = new System.Drawing.Size(533, 116);
            this.OrderListtxt.TabIndex = 46;
            // 
            // OrderPizzaDD
            // 
            this.OrderPizzaDD.AutoCompleteCustomSource.AddRange(new string[] {
            "Cheese",
            "Sausage",
            "Pepperoni"});
            this.OrderPizzaDD.FormattingEnabled = true;
            this.OrderPizzaDD.Items.AddRange(new object[] {
            "Cheese",
            "Sausage",
            "Pepperoni"});
            this.OrderPizzaDD.Location = new System.Drawing.Point(21, 103);
            this.OrderPizzaDD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OrderPizzaDD.Name = "OrderPizzaDD";
            this.OrderPizzaDD.Size = new System.Drawing.Size(500, 24);
            this.OrderPizzaDD.TabIndex = 43;
            // 
            // btnAccLog
            // 
            this.btnAccLog.Location = new System.Drawing.Point(13, 487);
            this.btnAccLog.Margin = new System.Windows.Forms.Padding(4);
            this.btnAccLog.Name = "btnAccLog";
            this.btnAccLog.Size = new System.Drawing.Size(153, 52);
            this.btnAccLog.TabIndex = 46;
            this.btnAccLog.Text = "Account Login";
            this.btnAccLog.UseVisualStyleBackColor = true;
            this.btnAccLog.Click += new System.EventHandler(this.accountLogin_Click_1);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel8.Controls.Add(this.btnLogSubmit);
            this.panel8.Controls.Add(this.btnLogCancel);
            this.panel8.Controls.Add(this.txtLogPassword);
            this.panel8.Controls.Add(this.txtLogEmail);
            this.panel8.Controls.Add(this.label8);
            this.panel8.Controls.Add(this.label11);
            this.panel8.Controls.Add(this.label13);
            this.panel8.Location = new System.Drawing.Point(392, 75);
            this.panel8.Margin = new System.Windows.Forms.Padding(4);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(539, 465);
            this.panel8.TabIndex = 13;
            // 
            // btnLogSubmit
            // 
            this.btnLogSubmit.Location = new System.Drawing.Point(279, 372);
            this.btnLogSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogSubmit.Name = "btnLogSubmit";
            this.btnLogSubmit.Size = new System.Drawing.Size(137, 44);
            this.btnLogSubmit.TabIndex = 12;
            this.btnLogSubmit.Text = "Submit";
            this.btnLogSubmit.UseVisualStyleBackColor = true;
            this.btnLogSubmit.Click += new System.EventHandler(this.LogSubmit_Click);
            // 
            // btnLogCancel
            // 
            this.btnLogCancel.Location = new System.Drawing.Point(103, 372);
            this.btnLogCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogCancel.Name = "btnLogCancel";
            this.btnLogCancel.Size = new System.Drawing.Size(137, 44);
            this.btnLogCancel.TabIndex = 11;
            this.btnLogCancel.Text = "Cancel";
            this.btnLogCancel.UseVisualStyleBackColor = true;
            this.btnLogCancel.Click += new System.EventHandler(this.LogCancel_Click);
            // 
            // txtLogPassword
            // 
            this.txtLogPassword.Location = new System.Drawing.Point(195, 231);
            this.txtLogPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtLogPassword.Name = "txtLogPassword";
            this.txtLogPassword.Size = new System.Drawing.Size(221, 22);
            this.txtLogPassword.TabIndex = 10;
            // 
            // txtLogEmail
            // 
            this.txtLogEmail.Location = new System.Drawing.Point(195, 137);
            this.txtLogEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtLogEmail.Name = "txtLogEmail";
            this.txtLogEmail.Size = new System.Drawing.Size(221, 22);
            this.txtLogEmail.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(109, 234);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 17);
            this.label8.TabIndex = 5;
            this.label8.Text = "Password";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(59, 140);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(126, 17);
            this.label11.TabIndex = 2;
            this.label11.Text = "Email - User Name";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(209, 25);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(134, 17);
            this.label13.TabIndex = 0;
            this.label13.Text = "Member Login Form";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel3.Controls.Add(this.txtEditPass);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.btnEditSubmit);
            this.panel3.Controls.Add(this.btnEditCancel);
            this.panel3.Controls.Add(this.txtEditPhone);
            this.panel3.Controls.Add(this.txtEditAdd);
            this.panel3.Controls.Add(this.txtEditName);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label18);
            this.panel3.Controls.Add(this.label19);
            this.panel3.Location = new System.Drawing.Point(392, 74);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(539, 465);
            this.panel3.TabIndex = 13;
            // 
            // txtEditPass
            // 
            this.txtEditPass.Location = new System.Drawing.Point(193, 238);
            this.txtEditPass.Margin = new System.Windows.Forms.Padding(4);
            this.txtEditPass.Name = "txtEditPass";
            this.txtEditPass.Size = new System.Drawing.Size(221, 22);
            this.txtEditPass.TabIndex = 16;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(100, 241);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(69, 17);
            this.label15.TabIndex = 15;
            this.label15.Text = "Password";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(-144, 217);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 17);
            this.label9.TabIndex = 14;
            this.label9.Text = "Password";
            // 
            // btnEditSubmit
            // 
            this.btnEditSubmit.Location = new System.Drawing.Point(279, 372);
            this.btnEditSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditSubmit.Name = "btnEditSubmit";
            this.btnEditSubmit.Size = new System.Drawing.Size(137, 44);
            this.btnEditSubmit.TabIndex = 12;
            this.btnEditSubmit.Text = "Submit";
            this.btnEditSubmit.UseVisualStyleBackColor = true;
            this.btnEditSubmit.Click += new System.EventHandler(this.editSubmit_Click);
            // 
            // btnEditCancel
            // 
            this.btnEditCancel.Location = new System.Drawing.Point(103, 372);
            this.btnEditCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditCancel.Name = "btnEditCancel";
            this.btnEditCancel.Size = new System.Drawing.Size(137, 44);
            this.btnEditCancel.TabIndex = 11;
            this.btnEditCancel.Text = "Cancel";
            this.btnEditCancel.UseVisualStyleBackColor = true;
            this.btnEditCancel.Click += new System.EventHandler(this.editCancel_Click);
            // 
            // txtEditPhone
            // 
            this.txtEditPhone.Location = new System.Drawing.Point(193, 190);
            this.txtEditPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtEditPhone.Name = "txtEditPhone";
            this.txtEditPhone.Size = new System.Drawing.Size(221, 22);
            this.txtEditPhone.TabIndex = 8;
            // 
            // txtEditAdd
            // 
            this.txtEditAdd.Location = new System.Drawing.Point(193, 140);
            this.txtEditAdd.Margin = new System.Windows.Forms.Padding(4);
            this.txtEditAdd.Name = "txtEditAdd";
            this.txtEditAdd.Size = new System.Drawing.Size(221, 22);
            this.txtEditAdd.TabIndex = 7;
            // 
            // txtEditName
            // 
            this.txtEditName.Location = new System.Drawing.Point(193, 92);
            this.txtEditName.Margin = new System.Windows.Forms.Padding(4);
            this.txtEditName.Name = "txtEditName";
            this.txtEditName.Size = new System.Drawing.Size(221, 22);
            this.txtEditName.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(71, 193);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 17);
            this.label10.TabIndex = 4;
            this.label10.Text = "Phone Number";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(115, 144);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 17);
            this.label12.TabIndex = 3;
            this.label12.Text = "Address";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(128, 96);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(45, 17);
            this.label18.TabIndex = 1;
            this.label18.Text = "Name";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(211, 25);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(123, 17);
            this.label19.TabIndex = 0;
            this.label19.Text = "Member Edit Form";
            // 
            // label20
            // 
            this.label20.Cursor = System.Windows.Forms.Cursors.Default;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Maroon;
            this.label20.Location = new System.Drawing.Point(275, 320);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(190, 57);
            this.label20.TabIndex = 49;
            this.label20.Text = "[Pay at Store]";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtOrderPriceTotal
            // 
            this.txtOrderPriceTotal.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtOrderPriceTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderPriceTotal.ForeColor = System.Drawing.Color.Maroon;
            this.txtOrderPriceTotal.Location = new System.Drawing.Point(52, 339);
            this.txtOrderPriceTotal.Name = "txtOrderPriceTotal";
            this.txtOrderPriceTotal.Size = new System.Drawing.Size(269, 38);
            this.txtOrderPriceTotal.TabIndex = 48;
            this.txtOrderPriceTotal.Text = "[ENTER PRICE HERE]";
            this.txtOrderPriceTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label22
            // 
            this.label22.Cursor = System.Windows.Forms.Cursors.Default;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Maroon;
            this.label22.Location = new System.Drawing.Point(326, 334);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(201, 57);
            this.label22.TabIndex = 47;
            this.label22.Text = "[Pay at Store]";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtReOrderPrice
            // 
            this.txtReOrderPrice.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtReOrderPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReOrderPrice.ForeColor = System.Drawing.Color.Maroon;
            this.txtReOrderPrice.Location = new System.Drawing.Point(17, 334);
            this.txtReOrderPrice.Name = "txtReOrderPrice";
            this.txtReOrderPrice.Size = new System.Drawing.Size(278, 57);
            this.txtReOrderPrice.TabIndex = 46;
            this.txtReOrderPrice.Text = "[ENTER PRICE HERE]";
            this.txtReOrderPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnAccLog);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAccSign);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel6);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "PizzaChain.org";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEditAcc;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnOrderHis;
        private System.Windows.Forms.Button btnAccSign;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAccCancel;
        private System.Windows.Forms.TextBox Passtxt;
        private System.Windows.Forms.TextBox UNametxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAccSubmit;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnstatReturn;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label StatusTxt;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.ComboBox DDOrderHis;
        private System.Windows.Forms.Button btnReOrder;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ComboBox OrderSizeDD;
        private System.Windows.Forms.Button btnOrderNow;
        private System.Windows.Forms.ComboBox OrderPizzaDD;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ListBox OrderListtxt;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.Button btnAccLog;
        private System.Windows.Forms.TextBox Phonetxt;
        private System.Windows.Forms.TextBox Addtxt;
        private System.Windows.Forms.TextBox Nametxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnLogSubmit;
        private System.Windows.Forms.Button btnLogCancel;
        private System.Windows.Forms.TextBox txtLogPassword;
        private System.Windows.Forms.TextBox txtLogEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnEditSubmit;
        private System.Windows.Forms.Button btnEditCancel;
        private System.Windows.Forms.TextBox txtEditPhone;
        private System.Windows.Forms.TextBox txtEditAdd;
        private System.Windows.Forms.TextBox txtEditName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtEditPass;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ListBox HistoryBoxList;
        private System.Windows.Forms.Label txtPriceStatus;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox DDOrderStatus;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label txtOrderPriceTotal;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label txtReOrderPrice;
    }
}

