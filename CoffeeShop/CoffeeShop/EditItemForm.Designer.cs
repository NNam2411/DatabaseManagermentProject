
namespace CoffeeShop
{
    partial class EditItemForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_ItemID = new System.Windows.Forms.TextBox();
            this.tb_ItemName = new System.Windows.Forms.TextBox();
            this.tb_Price = new System.Windows.Forms.TextBox();
            this.bt_add = new System.Windows.Forms.Button();
            this.bt_edit = new System.Windows.Forms.Button();
            this.bt_remove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(555, 575);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(634, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Item ID: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(634, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Item Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(634, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "Price:";
            // 
            // tb_ItemID
            // 
            this.tb_ItemID.Enabled = false;
            this.tb_ItemID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ItemID.Location = new System.Drawing.Point(802, 131);
            this.tb_ItemID.Name = "tb_ItemID";
            this.tb_ItemID.Size = new System.Drawing.Size(248, 27);
            this.tb_ItemID.TabIndex = 4;
            // 
            // tb_ItemName
            // 
            this.tb_ItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ItemName.Location = new System.Drawing.Point(802, 222);
            this.tb_ItemName.Name = "tb_ItemName";
            this.tb_ItemName.Size = new System.Drawing.Size(248, 27);
            this.tb_ItemName.TabIndex = 5;
            // 
            // tb_Price
            // 
            this.tb_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Price.Location = new System.Drawing.Point(802, 312);
            this.tb_Price.Name = "tb_Price";
            this.tb_Price.Size = new System.Drawing.Size(248, 27);
            this.tb_Price.TabIndex = 6;
            // 
            // bt_add
            // 
            this.bt_add.Font = new System.Drawing.Font("MS Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_add.Location = new System.Drawing.Point(928, 368);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(104, 42);
            this.bt_add.TabIndex = 7;
            this.bt_add.Text = "Add";
            this.bt_add.UseVisualStyleBackColor = true;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // bt_edit
            // 
            this.bt_edit.Font = new System.Drawing.Font("MS Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_edit.Location = new System.Drawing.Point(802, 368);
            this.bt_edit.Name = "bt_edit";
            this.bt_edit.Size = new System.Drawing.Size(104, 42);
            this.bt_edit.TabIndex = 8;
            this.bt_edit.Text = "Edit";
            this.bt_edit.UseVisualStyleBackColor = true;
            this.bt_edit.Click += new System.EventHandler(this.bt_edit_Click);
            // 
            // bt_remove
            // 
            this.bt_remove.Font = new System.Drawing.Font("MS Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_remove.Location = new System.Drawing.Point(661, 368);
            this.bt_remove.Name = "bt_remove";
            this.bt_remove.Size = new System.Drawing.Size(104, 42);
            this.bt_remove.TabIndex = 9;
            this.bt_remove.Text = "Remove";
            this.bt_remove.UseVisualStyleBackColor = true;
            this.bt_remove.Click += new System.EventHandler(this.bt_remove_Click);
            // 
            // EditItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 582);
            this.Controls.Add(this.bt_remove);
            this.Controls.Add(this.bt_edit);
            this.Controls.Add(this.bt_add);
            this.Controls.Add(this.tb_Price);
            this.Controls.Add(this.tb_ItemName);
            this.Controls.Add(this.tb_ItemID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "EditItemForm";
            this.Text = "EditItemForm";
            this.Load += new System.EventHandler(this.EditItemForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_ItemID;
        private System.Windows.Forms.TextBox tb_ItemName;
        private System.Windows.Forms.TextBox tb_Price;
        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.Button bt_edit;
        private System.Windows.Forms.Button bt_remove;
    }
}