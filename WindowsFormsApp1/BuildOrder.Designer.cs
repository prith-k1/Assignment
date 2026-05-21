namespace WindowsFormsApp1
{
    partial class BuildOrder
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DGavailable = new System.Windows.Forms.DataGridView();
            this.DGorder = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AddOrder = new System.Windows.Forms.Button();
            this.RemoveOrder = new System.Windows.Forms.Button();
            this.SaveOrder = new System.Windows.Forms.Button();
            this.LoadOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGavailable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGorder)).BeginInit();
            this.SuspendLayout();
            // 
            // DGavailable
            // 
            this.DGavailable.BackgroundColor = System.Drawing.Color.White;
            this.DGavailable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGavailable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGavailable.EnableHeadersVisualStyles = false;
            this.DGavailable.Location = new System.Drawing.Point(44, 44);
            this.DGavailable.Name = "DGavailable";
            this.DGavailable.RowHeadersVisible = false;
            this.DGavailable.Size = new System.Drawing.Size(250, 410);
            this.DGavailable.TabIndex = 0;
            this.DGavailable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.DGavailable.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DGavailable_MouseDown);
            // 
            // DGorder
            // 
            this.DGorder.BackgroundColor = System.Drawing.Color.White;
            this.DGorder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGorder.EnableHeadersVisualStyles = false;
            this.DGorder.Location = new System.Drawing.Point(326, 44);
            this.DGorder.Name = "DGorder";
            this.DGorder.RowHeadersVisible = false;
            this.DGorder.Size = new System.Drawing.Size(570, 410);
            this.DGorder.TabIndex = 0;
            this.DGorder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGorder_CellContentClick);
            this.DGorder.DragDrop += new System.Windows.Forms.DragEventHandler(this.DGorder_DragDrop);
            this.DGorder.DragEnter += new System.Windows.Forms.DragEventHandler(this.DGorder_DragEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.label1.Location = new System.Drawing.Point(940, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBox1.Location = new System.Drawing.Point(940, 136);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 25);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBox2.Location = new System.Drawing.Point(940, 218);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(150, 25);
            this.textBox2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.label2.Location = new System.Drawing.Point(940, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Order name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.label3.Location = new System.Drawing.Point(940, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Order Description";
            // 
            // AddOrder
            // 
            this.AddOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.AddOrder.FlatAppearance.BorderSize = 0;
            this.AddOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddOrder.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.AddOrder.ForeColor = System.Drawing.Color.White;
            this.AddOrder.Location = new System.Drawing.Point(44, 486);
            this.AddOrder.Name = "AddOrder";
            this.AddOrder.Size = new System.Drawing.Size(120, 36);
            this.AddOrder.TabIndex = 6;
            this.AddOrder.Text = "Add to Order";
            this.AddOrder.UseVisualStyleBackColor = false;
            this.AddOrder.Click += new System.EventHandler(this.AddOrder_Click);
            // 
            // RemoveOrder
            // 
            this.RemoveOrder.BackColor = System.Drawing.Color.White;
            this.RemoveOrder.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.RemoveOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveOrder.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.RemoveOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.RemoveOrder.Location = new System.Drawing.Point(180, 486);
            this.RemoveOrder.Name = "RemoveOrder";
            this.RemoveOrder.Size = new System.Drawing.Size(140, 36);
            this.RemoveOrder.TabIndex = 7;
            this.RemoveOrder.Text = "Remove";
            this.RemoveOrder.UseVisualStyleBackColor = false;
            // 
            // SaveOrder
            // 
            this.SaveOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.SaveOrder.FlatAppearance.BorderSize = 0;
            this.SaveOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveOrder.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.SaveOrder.ForeColor = System.Drawing.Color.White;
            this.SaveOrder.Location = new System.Drawing.Point(620, 486);
            this.SaveOrder.Name = "SaveOrder";
            this.SaveOrder.Size = new System.Drawing.Size(120, 36);
            this.SaveOrder.TabIndex = 8;
            this.SaveOrder.Text = "Save Order";
            this.SaveOrder.UseVisualStyleBackColor = false;
            // 
            // LoadOrder
            // 
            this.LoadOrder.BackColor = System.Drawing.Color.White;
            this.LoadOrder.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.LoadOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadOrder.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LoadOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.LoadOrder.Location = new System.Drawing.Point(776, 486);
            this.LoadOrder.Name = "LoadOrder";
            this.LoadOrder.Size = new System.Drawing.Size(120, 36);
            this.LoadOrder.TabIndex = 9;
            this.LoadOrder.Text = "Load Order";
            this.LoadOrder.UseVisualStyleBackColor = false;
            // 
            // BuildOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.Controls.Add(this.LoadOrder);
            this.Controls.Add(this.SaveOrder);
            this.Controls.Add(this.RemoveOrder);
            this.Controls.Add(this.AddOrder);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGorder);
            this.Controls.Add(this.DGavailable);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Name = "BuildOrder";
            this.Size = new System.Drawing.Size(1138, 609);
            ((System.ComponentModel.ISupportInitialize)(this.DGavailable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGorder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGavailable;
        private System.Windows.Forms.DataGridView DGorder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddOrder;
        private System.Windows.Forms.Button RemoveOrder;
        private System.Windows.Forms.Button SaveOrder;
        private System.Windows.Forms.Button LoadOrder;
    }
}
