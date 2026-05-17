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
            this.DGavailable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGavailable.Location = new System.Drawing.Point(106, 52);
            this.DGavailable.Name = "DGavailable";
            this.DGavailable.Size = new System.Drawing.Size(174, 408);
            this.DGavailable.TabIndex = 0;
            this.DGavailable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.DGavailable.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DGavailable_MouseDown);
            // 
            // DGorder
            // 
            this.DGorder.Location = new System.Drawing.Point(324, 52);
            this.DGorder.Name = "DGorder";
            this.DGorder.Size = new System.Drawing.Size(608, 408);
            this.DGorder.TabIndex = 0;
            this.DGorder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGorder_CellContentClick);
            this.DGorder.DragDrop += new System.Windows.Forms.DragEventHandler(this.DGorder_DragDrop);
            this.DGorder.DragEnter += new System.Windows.Forms.DragEventHandler(this.DGorder_DragEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(959, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(965, 142);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(965, 218);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(982, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Order name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(976, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Order Description";
            // 
            // AddOrder
            // 
            this.AddOrder.Location = new System.Drawing.Point(106, 493);
            this.AddOrder.Name = "AddOrder";
            this.AddOrder.Size = new System.Drawing.Size(96, 23);
            this.AddOrder.TabIndex = 6;
            this.AddOrder.Text = "Add to Order";
            this.AddOrder.UseVisualStyleBackColor = true;
            this.AddOrder.Click += new System.EventHandler(this.AddOrder_Click);
            // 
            // RemoveOrder
            // 
            this.RemoveOrder.Location = new System.Drawing.Point(224, 493);
            this.RemoveOrder.Name = "RemoveOrder";
            this.RemoveOrder.Size = new System.Drawing.Size(109, 23);
            this.RemoveOrder.TabIndex = 7;
            this.RemoveOrder.Text = "Remove from order";
            this.RemoveOrder.UseVisualStyleBackColor = true;
            // 
            // SaveOrder
            // 
            this.SaveOrder.Location = new System.Drawing.Point(738, 493);
            this.SaveOrder.Name = "SaveOrder";
            this.SaveOrder.Size = new System.Drawing.Size(75, 23);
            this.SaveOrder.TabIndex = 8;
            this.SaveOrder.Text = "Save order";
            this.SaveOrder.UseVisualStyleBackColor = true;
            // 
            // LoadOrder
            // 
            this.LoadOrder.Location = new System.Drawing.Point(857, 493);
            this.LoadOrder.Name = "LoadOrder";
            this.LoadOrder.Size = new System.Drawing.Size(75, 23);
            this.LoadOrder.TabIndex = 9;
            this.LoadOrder.Text = "Load order";
            this.LoadOrder.UseVisualStyleBackColor = true;
            // 
            // BuildOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
