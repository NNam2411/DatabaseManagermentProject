
namespace CoffeeShop
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.bt_Manager = new System.Windows.Forms.Button();
            this.bt_Staff = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_Income = new System.Windows.Forms.Button();
            this.bt_Customer = new System.Windows.Forms.Button();
            this.bt_Checking = new System.Windows.Forms.Button();
            this.panel_Login = new System.Windows.Forms.Panel();
            this.btlogout = new System.Windows.Forms.Button();
            this.rbemployee = new System.Windows.Forms.RadioButton();
            this.rbmanager = new System.Windows.Forms.RadioButton();
            this.bt_Signin = new System.Windows.Forms.Button();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.tb_Account = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_Menu = new System.Windows.Forms.Panel();
            this.tbDes = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.bt_Find = new System.Windows.Forms.Button();
            this.bt_Reset = new System.Windows.Forms.Button();
            this.bt_Remove = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.orderItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_Amount = new System.Windows.Forms.TextBox();
            this.bt_SCart = new System.Windows.Forms.Button();
            this.tb_Phone = new System.Windows.Forms.TextBox();
            this.pn_Menu_dataGridView1 = new System.Windows.Forms.DataGridView();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_CusName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btclose = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel_Login.SuspendLayout();
            this.panel_Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pn_Menu_dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_Manager
            // 
            this.bt_Manager.BackColor = System.Drawing.SystemColors.ControlDark;
            this.bt_Manager.Enabled = false;
            this.bt_Manager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Manager.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Manager.Location = new System.Drawing.Point(7, 52);
            this.bt_Manager.Name = "bt_Manager";
            this.bt_Manager.Size = new System.Drawing.Size(155, 48);
            this.bt_Manager.TabIndex = 0;
            this.bt_Manager.Text = "Manager";
            this.bt_Manager.UseVisualStyleBackColor = false;
            this.bt_Manager.Click += new System.EventHandler(this.bt_Staff_Click);
            // 
            // bt_Staff
            // 
            this.bt_Staff.BackColor = System.Drawing.SystemColors.ControlDark;
            this.bt_Staff.Enabled = false;
            this.bt_Staff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Staff.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Staff.Location = new System.Drawing.Point(7, 136);
            this.bt_Staff.Name = "bt_Staff";
            this.bt_Staff.Size = new System.Drawing.Size(155, 48);
            this.bt_Staff.TabIndex = 1;
            this.bt_Staff.Text = "Staffs";
            this.bt_Staff.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.bt_Staff.UseVisualStyleBackColor = false;
            this.bt_Staff.Click += new System.EventHandler(this.bt_Customer_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.bt_Income);
            this.panel1.Controls.Add(this.bt_Customer);
            this.panel1.Controls.Add(this.bt_Checking);
            this.panel1.Controls.Add(this.bt_Staff);
            this.panel1.Controls.Add(this.bt_Manager);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(169, 578);
            this.panel1.TabIndex = 2;
            // 
            // bt_Income
            // 
            this.bt_Income.BackColor = System.Drawing.SystemColors.ControlDark;
            this.bt_Income.Enabled = false;
            this.bt_Income.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Income.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Income.Location = new System.Drawing.Point(7, 312);
            this.bt_Income.Name = "bt_Income";
            this.bt_Income.Size = new System.Drawing.Size(155, 48);
            this.bt_Income.TabIndex = 4;
            this.bt_Income.Text = "Income";
            this.bt_Income.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.bt_Income.UseVisualStyleBackColor = false;
            this.bt_Income.Click += new System.EventHandler(this.bt_Income_Click);
            // 
            // bt_Customer
            // 
            this.bt_Customer.BackColor = System.Drawing.SystemColors.ControlDark;
            this.bt_Customer.Enabled = false;
            this.bt_Customer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Customer.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Customer.Location = new System.Drawing.Point(7, 223);
            this.bt_Customer.Name = "bt_Customer";
            this.bt_Customer.Size = new System.Drawing.Size(155, 48);
            this.bt_Customer.TabIndex = 3;
            this.bt_Customer.Text = "Customers";
            this.bt_Customer.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.bt_Customer.UseVisualStyleBackColor = false;
            this.bt_Customer.Click += new System.EventHandler(this.bt_Customer_Click_1);
            // 
            // bt_Checking
            // 
            this.bt_Checking.BackColor = System.Drawing.SystemColors.ControlDark;
            this.bt_Checking.Enabled = false;
            this.bt_Checking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Checking.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Checking.Location = new System.Drawing.Point(7, 499);
            this.bt_Checking.Name = "bt_Checking";
            this.bt_Checking.Size = new System.Drawing.Size(155, 48);
            this.bt_Checking.TabIndex = 2;
            this.bt_Checking.Text = "Checking";
            this.bt_Checking.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.bt_Checking.UseVisualStyleBackColor = false;
            this.bt_Checking.Click += new System.EventHandler(this.bt_Checking_Click);
            // 
            // panel_Login
            // 
            this.panel_Login.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Login.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel_Login.Controls.Add(this.btlogout);
            this.panel_Login.Controls.Add(this.rbemployee);
            this.panel_Login.Controls.Add(this.rbmanager);
            this.panel_Login.Controls.Add(this.bt_Signin);
            this.panel_Login.Controls.Add(this.tb_Password);
            this.panel_Login.Controls.Add(this.tb_Account);
            this.panel_Login.Controls.Add(this.label3);
            this.panel_Login.Controls.Add(this.label2);
            this.panel_Login.Controls.Add(this.label1);
            this.panel_Login.Location = new System.Drawing.Point(209, 13);
            this.panel_Login.Name = "panel_Login";
            this.panel_Login.Size = new System.Drawing.Size(359, 249);
            this.panel_Login.TabIndex = 3;
            // 
            // btlogout
            // 
            this.btlogout.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btlogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btlogout.Location = new System.Drawing.Point(9, 202);
            this.btlogout.Name = "btlogout";
            this.btlogout.Size = new System.Drawing.Size(87, 30);
            this.btlogout.TabIndex = 15;
            this.btlogout.Text = "Sign out";
            this.btlogout.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btlogout.UseVisualStyleBackColor = false;
            this.btlogout.Click += new System.EventHandler(this.btlogout_Click);
            // 
            // rbemployee
            // 
            this.rbemployee.AutoSize = true;
            this.rbemployee.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbemployee.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbemployee.Location = new System.Drawing.Point(189, 161);
            this.rbemployee.Name = "rbemployee";
            this.rbemployee.Size = new System.Drawing.Size(104, 26);
            this.rbemployee.TabIndex = 15;
            this.rbemployee.TabStop = true;
            this.rbemployee.Text = "Employee";
            this.rbemployee.UseVisualStyleBackColor = true;
            // 
            // rbmanager
            // 
            this.rbmanager.AutoSize = true;
            this.rbmanager.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbmanager.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbmanager.Location = new System.Drawing.Point(9, 161);
            this.rbmanager.Name = "rbmanager";
            this.rbmanager.Size = new System.Drawing.Size(95, 26);
            this.rbmanager.TabIndex = 6;
            this.rbmanager.TabStop = true;
            this.rbmanager.Text = "Manager";
            this.rbmanager.UseVisualStyleBackColor = true;
            // 
            // bt_Signin
            // 
            this.bt_Signin.BackColor = System.Drawing.SystemColors.ControlDark;
            this.bt_Signin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Signin.Location = new System.Drawing.Point(197, 202);
            this.bt_Signin.Name = "bt_Signin";
            this.bt_Signin.Size = new System.Drawing.Size(87, 30);
            this.bt_Signin.TabIndex = 5;
            this.bt_Signin.Text = "Sign in";
            this.bt_Signin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt_Signin.UseVisualStyleBackColor = false;
            this.bt_Signin.Click += new System.EventHandler(this.bt_Signin_Click);
            // 
            // tb_Password
            // 
            this.tb_Password.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tb_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Password.ForeColor = System.Drawing.SystemColors.Window;
            this.tb_Password.Location = new System.Drawing.Point(133, 113);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.PasswordChar = '*';
            this.tb_Password.Size = new System.Drawing.Size(151, 30);
            this.tb_Password.TabIndex = 4;
            // 
            // tb_Account
            // 
            this.tb_Account.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tb_Account.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Account.ForeColor = System.Drawing.SystemColors.Window;
            this.tb_Account.Location = new System.Drawing.Point(133, 57);
            this.tb_Account.Name = "tb_Account";
            this.tb_Account.Size = new System.Drawing.Size(151, 30);
            this.tb_Account.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Account";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(113, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sign In";
            // 
            // panel_Menu
            // 
            this.panel_Menu.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel_Menu.Controls.Add(this.tbDes);
            this.panel_Menu.Controls.Add(this.label7);
            this.panel_Menu.Controls.Add(this.comboBox1);
            this.panel_Menu.Controls.Add(this.label6);
            this.panel_Menu.Controls.Add(this.button1);
            this.panel_Menu.Controls.Add(this.bt_Find);
            this.panel_Menu.Controls.Add(this.bt_Reset);
            this.panel_Menu.Controls.Add(this.bt_Remove);
            this.panel_Menu.Controls.Add(this.dataGridView1);
            this.panel_Menu.Controls.Add(this.tb_Amount);
            this.panel_Menu.Controls.Add(this.bt_SCart);
            this.panel_Menu.Controls.Add(this.tb_Phone);
            this.panel_Menu.Controls.Add(this.pn_Menu_dataGridView1);
            this.panel_Menu.Controls.Add(this.tb_CusName);
            this.panel_Menu.Controls.Add(this.label4);
            this.panel_Menu.Controls.Add(this.label5);
            this.panel_Menu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel_Menu.Location = new System.Drawing.Point(169, 0);
            this.panel_Menu.Name = "panel_Menu";
            this.panel_Menu.Size = new System.Drawing.Size(946, 578);
            this.panel_Menu.TabIndex = 4;
            this.panel_Menu.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Menu_Paint);
            // 
            // tbDes
            // 
            this.tbDes.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tbDes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbDes.Location = new System.Drawing.Point(206, 147);
            this.tbDes.Name = "tbDes";
            this.tbDes.Size = new System.Drawing.Size(212, 30);
            this.tbDes.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS PGothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(16, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Description:";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(206, 99);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(212, 33);
            this.comboBox1.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS PGothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(16, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Cashier:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(607, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 47);
            this.button1.TabIndex = 14;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // bt_Find
            // 
            this.bt_Find.BackColor = System.Drawing.SystemColors.ControlDark;
            this.bt_Find.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Find.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Find.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_Find.Location = new System.Drawing.Point(434, 12);
            this.bt_Find.Name = "bt_Find";
            this.bt_Find.Size = new System.Drawing.Size(121, 44);
            this.bt_Find.TabIndex = 13;
            this.bt_Find.Text = "Find";
            this.bt_Find.UseVisualStyleBackColor = false;
            this.bt_Find.Click += new System.EventHandler(this.bt_Find_Click);
            // 
            // bt_Reset
            // 
            this.bt_Reset.BackColor = System.Drawing.SystemColors.ControlDark;
            this.bt_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Reset.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Reset.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_Reset.Location = new System.Drawing.Point(829, 85);
            this.bt_Reset.Name = "bt_Reset";
            this.bt_Reset.Size = new System.Drawing.Size(97, 47);
            this.bt_Reset.TabIndex = 12;
            this.bt_Reset.Text = "Reset";
            this.bt_Reset.UseVisualStyleBackColor = false;
            this.bt_Reset.Click += new System.EventHandler(this.bt_Reset_Click);
            // 
            // bt_Remove
            // 
            this.bt_Remove.BackColor = System.Drawing.SystemColors.ControlDark;
            this.bt_Remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Remove.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Remove.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_Remove.Location = new System.Drawing.Point(783, 503);
            this.bt_Remove.Name = "bt_Remove";
            this.bt_Remove.Size = new System.Drawing.Size(143, 46);
            this.bt_Remove.TabIndex = 11;
            this.bt_Remove.Text = "Remove";
            this.bt_Remove.UseVisualStyleBackColor = false;
            this.bt_Remove.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(556, 198);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(370, 298);
            this.dataGridView1.TabIndex = 10;
            // 
            // orderItemBindingSource
            // 
            this.orderItemBindingSource.DataMember = "Order_Item";
            // 
            // tb_Amount
            // 
            this.tb_Amount.BackColor = System.Drawing.Color.Red;
            this.tb_Amount.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tb_Amount.Location = new System.Drawing.Point(734, 53);
            this.tb_Amount.Name = "tb_Amount";
            this.tb_Amount.Size = new System.Drawing.Size(26, 28);
            this.tb_Amount.TabIndex = 9;
            // 
            // bt_SCart
            // 
            this.bt_SCart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_SCart.BackgroundImage")));
            this.bt_SCart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_SCart.Location = new System.Drawing.Point(745, 58);
            this.bt_SCart.Name = "bt_SCart";
            this.bt_SCart.Size = new System.Drawing.Size(78, 73);
            this.bt_SCart.TabIndex = 8;
            this.bt_SCart.UseVisualStyleBackColor = true;
            this.bt_SCart.Click += new System.EventHandler(this.bt_SCart_Click);
            // 
            // tb_Phone
            // 
            this.tb_Phone.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tb_Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Phone.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tb_Phone.Location = new System.Drawing.Point(206, 22);
            this.tb_Phone.Name = "tb_Phone";
            this.tb_Phone.Size = new System.Drawing.Size(212, 30);
            this.tb_Phone.TabIndex = 7;
            // 
            // pn_Menu_dataGridView1
            // 
            this.pn_Menu_dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.pn_Menu_dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.pn_Menu_dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pn_Menu_dataGridView1.Location = new System.Drawing.Point(39, 198);
            this.pn_Menu_dataGridView1.Name = "pn_Menu_dataGridView1";
            this.pn_Menu_dataGridView1.RowHeadersWidth = 51;
            this.pn_Menu_dataGridView1.RowTemplate.Height = 24;
            this.pn_Menu_dataGridView1.Size = new System.Drawing.Size(432, 298);
            this.pn_Menu_dataGridView1.TabIndex = 1;
            this.pn_Menu_dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pn_Menu_dataGridView1_CellContentClick);
            this.pn_Menu_dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pn_Menu_dataGridView1_CellContentDoubleClick);
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataMember = "Item";
            // 
            // tb_CusName
            // 
            this.tb_CusName.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tb_CusName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_CusName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tb_CusName.Location = new System.Drawing.Point(206, 63);
            this.tb_CusName.Name = "tb_CusName";
            this.tb_CusName.Size = new System.Drawing.Size(212, 30);
            this.tb_CusName.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS PGothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(15, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Phone Number:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS PGothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(16, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Customer\'s Name:";
            // 
            // btclose
            // 
            this.btclose.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btclose.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btclose.Location = new System.Drawing.Point(1135, 8);
            this.btclose.Name = "btclose";
            this.btclose.Size = new System.Drawing.Size(121, 42);
            this.btclose.TabIndex = 14;
            this.btclose.Text = "Close";
            this.btclose.UseVisualStyleBackColor = false;
            this.btclose.Click += new System.EventHandler(this.btclose_Click);
            // 
            // HomePage
            // 
            this.AcceptButton = this.bt_Signin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1268, 627);
            this.Controls.Add(this.btclose);
            this.Controls.Add(this.panel_Menu);
            this.Controls.Add(this.panel_Login);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomePage";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.panel1.ResumeLayout(false);
            this.panel_Login.ResumeLayout(false);
            this.panel_Login.PerformLayout();
            this.panel_Menu.ResumeLayout(false);
            this.panel_Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pn_Menu_dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_Manager;
        private System.Windows.Forms.Button bt_Staff;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_Login;
        private System.Windows.Forms.Button bt_Signin;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.TextBox tb_Account;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_Menu;
        private System.Windows.Forms.DataGridView pn_Menu_dataGridView1;
        private System.Windows.Forms.TextBox tb_Phone;
        private System.Windows.Forms.TextBox tb_CusName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_Amount;
        private System.Windows.Forms.Button bt_SCart;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bt_Remove;
        private System.Windows.Forms.Button bt_Checking;
        private System.Windows.Forms.Button bt_Reset;
        private System.Windows.Forms.Button bt_Find;
        private System.Windows.Forms.Button bt_Customer;
        private System.Windows.Forms.Button bt_Income;
        private System.Windows.Forms.Button btclose;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private System.Windows.Forms.BindingSource orderItemBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn itNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox tbDes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn itNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn itQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.RadioButton rbemployee;
        private System.Windows.Forms.RadioButton rbmanager;
        private System.Windows.Forms.Button btlogout;
    }
}