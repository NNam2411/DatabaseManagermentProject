
namespace CoffeeShop
{
    partial class Customer
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_Cname = new System.Windows.Forms.TextBox();
            this.tb_Address = new System.Windows.Forms.TextBox();
            this.tb_TotalPay = new System.Windows.Forms.TextBox();
            this.tb_Phone = new System.Windows.Forms.TextBox();
            this.bt_Search = new System.Windows.Forms.Button();
            this.bt_Create = new System.Windows.Forms.Button();
            this.tb_Search = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTotalPayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btdel = new System.Windows.Forms.Button();
            this.tbC_ID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(37, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(37, 374);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phone:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(37, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Address:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(37, 447);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Total Pay:";
            // 
            // tb_Cname
            // 
            this.tb_Cname.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tb_Cname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Cname.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tb_Cname.Location = new System.Drawing.Point(297, 210);
            this.tb_Cname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_Cname.Name = "tb_Cname";
            this.tb_Cname.Size = new System.Drawing.Size(199, 30);
            this.tb_Cname.TabIndex = 6;
            // 
            // tb_Address
            // 
            this.tb_Address.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tb_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Address.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tb_Address.Location = new System.Drawing.Point(297, 264);
            this.tb_Address.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_Address.Multiline = true;
            this.tb_Address.Name = "tb_Address";
            this.tb_Address.Size = new System.Drawing.Size(199, 88);
            this.tb_Address.TabIndex = 7;
            this.tb_Address.TextChanged += new System.EventHandler(this.tb_Address_TextChanged);
            // 
            // tb_TotalPay
            // 
            this.tb_TotalPay.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tb_TotalPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_TotalPay.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tb_TotalPay.Location = new System.Drawing.Point(297, 447);
            this.tb_TotalPay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_TotalPay.Name = "tb_TotalPay";
            this.tb_TotalPay.Size = new System.Drawing.Size(199, 30);
            this.tb_TotalPay.TabIndex = 9;
            // 
            // tb_Phone
            // 
            this.tb_Phone.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tb_Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Phone.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tb_Phone.Location = new System.Drawing.Point(297, 370);
            this.tb_Phone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_Phone.Name = "tb_Phone";
            this.tb_Phone.Size = new System.Drawing.Size(199, 30);
            this.tb_Phone.TabIndex = 8;
            // 
            // bt_Search
            // 
            this.bt_Search.BackColor = System.Drawing.SystemColors.ControlDark;
            this.bt_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Search.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Search.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_Search.Location = new System.Drawing.Point(73, 17);
            this.bt_Search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bt_Search.Name = "bt_Search";
            this.bt_Search.Size = new System.Drawing.Size(150, 54);
            this.bt_Search.TabIndex = 10;
            this.bt_Search.Text = "Search";
            this.bt_Search.UseVisualStyleBackColor = false;
            this.bt_Search.Click += new System.EventHandler(this.bt_Search_Click);
            // 
            // bt_Create
            // 
            this.bt_Create.BackColor = System.Drawing.SystemColors.ControlDark;
            this.bt_Create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Create.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Create.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_Create.Location = new System.Drawing.Point(41, 501);
            this.bt_Create.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bt_Create.Name = "bt_Create";
            this.bt_Create.Size = new System.Drawing.Size(223, 71);
            this.bt_Create.TabIndex = 11;
            this.bt_Create.Text = "Create New";
            this.bt_Create.UseVisualStyleBackColor = false;
            this.bt_Create.Click += new System.EventHandler(this.bt_Create_Click);
            // 
            // tb_Search
            // 
            this.tb_Search.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tb_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Search.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tb_Search.Location = new System.Drawing.Point(297, 17);
            this.tb_Search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_Search.Name = "tb_Search";
            this.tb_Search.Size = new System.Drawing.Size(199, 30);
            this.tb_Search.TabIndex = 12;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cIDDataGridViewTextBoxColumn,
            this.cNameDataGridViewTextBoxColumn,
            this.cPhoneDataGridViewTextBoxColumn,
            this.cAddressDataGridViewTextBoxColumn,
            this.cTotalPayDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.customerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(543, 39);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(657, 471);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // cIDDataGridViewTextBoxColumn
            // 
            this.cIDDataGridViewTextBoxColumn.DataPropertyName = "C_ID";
            this.cIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.cIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cIDDataGridViewTextBoxColumn.Name = "cIDDataGridViewTextBoxColumn";
            this.cIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cNameDataGridViewTextBoxColumn
            // 
            this.cNameDataGridViewTextBoxColumn.DataPropertyName = "C_Name";
            this.cNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.cNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cNameDataGridViewTextBoxColumn.Name = "cNameDataGridViewTextBoxColumn";
            // 
            // cPhoneDataGridViewTextBoxColumn
            // 
            this.cPhoneDataGridViewTextBoxColumn.DataPropertyName = "C_Phone";
            this.cPhoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.cPhoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cPhoneDataGridViewTextBoxColumn.Name = "cPhoneDataGridViewTextBoxColumn";
            // 
            // cAddressDataGridViewTextBoxColumn
            // 
            this.cAddressDataGridViewTextBoxColumn.DataPropertyName = "C_Address";
            this.cAddressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.cAddressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cAddressDataGridViewTextBoxColumn.Name = "cAddressDataGridViewTextBoxColumn";
            // 
            // cTotalPayDataGridViewTextBoxColumn
            // 
            this.cTotalPayDataGridViewTextBoxColumn.DataPropertyName = "C_TotalPay";
            this.cTotalPayDataGridViewTextBoxColumn.HeaderText = "TotalPay";
            this.cTotalPayDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cTotalPayDataGridViewTextBoxColumn.Name = "cTotalPayDataGridViewTextBoxColumn";
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            // 
            // cafeManagerDataSet4
            // 
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(1050, 518);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 54);
            this.button1.TabIndex = 14;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // customerTableAdapter
            // 
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(171, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 50);
            this.label1.TabIndex = 15;
            this.label1.Text = "New Customer";
            // 
            // btdel
            // 
            this.btdel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btdel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btdel.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btdel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btdel.Location = new System.Drawing.Point(314, 501);
            this.btdel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btdel.Name = "btdel";
            this.btdel.Size = new System.Drawing.Size(223, 71);
            this.btdel.TabIndex = 16;
            this.btdel.Text = "Delete";
            this.btdel.UseVisualStyleBackColor = false;
            this.btdel.Click += new System.EventHandler(this.btdel_Click);
            // 
            // tbC_ID
            // 
            this.tbC_ID.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tbC_ID.Enabled = false;
            this.tbC_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbC_ID.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbC_ID.Location = new System.Drawing.Point(297, 149);
            this.tbC_ID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbC_ID.Name = "tbC_ID";
            this.tbC_ID.ReadOnly = true;
            this.tbC_ID.Size = new System.Drawing.Size(199, 30);
            this.tbC_ID.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(37, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 22);
            this.label6.TabIndex = 17;
            this.label6.Text = "Customer ID:";
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1234, 589);
            this.Controls.Add(this.tbC_ID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btdel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tb_Search);
            this.Controls.Add(this.bt_Create);
            this.Controls.Add(this.bt_Search);
            this.Controls.Add(this.tb_Phone);
            this.Controls.Add(this.tb_TotalPay);
            this.Controls.Add(this.tb_Address);
            this.Controls.Add(this.tb_Cname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.Customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_Cname;
        private System.Windows.Forms.TextBox tb_Address;
        private System.Windows.Forms.TextBox tb_TotalPay;
        private System.Windows.Forms.TextBox tb_Phone;
        private System.Windows.Forms.Button bt_Search;
        private System.Windows.Forms.Button bt_Create;
        private System.Windows.Forms.TextBox tb_Search;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTotalPayDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btdel;
        private System.Windows.Forms.TextBox tbC_ID;
        private System.Windows.Forms.Label label6;
    }
}