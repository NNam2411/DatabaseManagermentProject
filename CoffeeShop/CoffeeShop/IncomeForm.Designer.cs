
namespace CoffeeShop
{
    partial class IncomeForm
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.bt_Check = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bt_Next = new System.Windows.Forms.Button();
            this.bt_Previous = new System.Windows.Forms.Button();
            this.lb_Total = new System.Windows.Forms.Label();
            this.bt_Checkmonth = new System.Windows.Forms.Button();
            this.btclose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dateTimePicker1.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(217, 60);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(466, 51);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // bt_Check
            // 
            this.bt_Check.BackColor = System.Drawing.SystemColors.ControlDark;
            this.bt_Check.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Check.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Check.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_Check.Location = new System.Drawing.Point(217, 117);
            this.bt_Check.Name = "bt_Check";
            this.bt_Check.Size = new System.Drawing.Size(210, 39);
            this.bt_Check.TabIndex = 1;
            this.bt_Check.Text = "Check Day Income";
            this.bt_Check.UseVisualStyleBackColor = false;
            this.bt_Check.Click += new System.EventHandler(this.bt_Check_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 175);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(885, 307);
            this.dataGridView1.TabIndex = 2;
            // 
            // bt_Next
            // 
            this.bt_Next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Next.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Next.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_Next.Location = new System.Drawing.Point(689, 60);
            this.bt_Next.Name = "bt_Next";
            this.bt_Next.Size = new System.Drawing.Size(60, 40);
            this.bt_Next.TabIndex = 3;
            this.bt_Next.Text = ">>";
            this.bt_Next.UseVisualStyleBackColor = true;
            this.bt_Next.Click += new System.EventHandler(this.bt_Next_Click);
            // 
            // bt_Previous
            // 
            this.bt_Previous.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Previous.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Previous.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_Previous.Location = new System.Drawing.Point(151, 60);
            this.bt_Previous.Name = "bt_Previous";
            this.bt_Previous.Size = new System.Drawing.Size(60, 40);
            this.bt_Previous.TabIndex = 4;
            this.bt_Previous.Text = "<<";
            this.bt_Previous.UseVisualStyleBackColor = true;
            this.bt_Previous.Click += new System.EventHandler(this.bt_Previous_Click);
            // 
            // lb_Total
            // 
            this.lb_Total.AutoSize = true;
            this.lb_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Total.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_Total.Location = new System.Drawing.Point(26, 509);
            this.lb_Total.Name = "lb_Total";
            this.lb_Total.Size = new System.Drawing.Size(94, 32);
            this.lb_Total.TabIndex = 5;
            this.lb_Total.Text = "Total: ";
            // 
            // bt_Checkmonth
            // 
            this.bt_Checkmonth.BackColor = System.Drawing.SystemColors.ControlDark;
            this.bt_Checkmonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Checkmonth.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Checkmonth.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_Checkmonth.Location = new System.Drawing.Point(473, 117);
            this.bt_Checkmonth.Name = "bt_Checkmonth";
            this.bt_Checkmonth.Size = new System.Drawing.Size(210, 39);
            this.bt_Checkmonth.TabIndex = 6;
            this.bt_Checkmonth.Text = "Check Month Income";
            this.bt_Checkmonth.UseVisualStyleBackColor = false;
            this.bt_Checkmonth.Click += new System.EventHandler(this.bt_Checkmonth_Click);
            // 
            // btclose
            // 
            this.btclose.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btclose.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btclose.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btclose.Location = new System.Drawing.Point(689, 509);
            this.btclose.Name = "btclose";
            this.btclose.Size = new System.Drawing.Size(210, 39);
            this.btclose.TabIndex = 7;
            this.btclose.Text = "Close";
            this.btclose.UseVisualStyleBackColor = false;
            this.btclose.Click += new System.EventHandler(this.btclose_Click);
            // 
            // IncomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(937, 589);
            this.Controls.Add(this.btclose);
            this.Controls.Add(this.bt_Checkmonth);
            this.Controls.Add(this.lb_Total);
            this.Controls.Add(this.bt_Previous);
            this.Controls.Add(this.bt_Next);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bt_Check);
            this.Controls.Add(this.dateTimePicker1);
            this.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IncomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IncomeForm";
            this.Load += new System.EventHandler(this.IncomeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button bt_Check;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bt_Next;
        private System.Windows.Forms.Button bt_Previous;
        private System.Windows.Forms.Label lb_Total;
        private System.Windows.Forms.Button bt_Checkmonth;
        private System.Windows.Forms.Button btclose;
    }
}