namespace BindingClass
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            btnAdd = new Button();
            btnEdit = new Button();
            btnRemove = new Button();
            btnImport = new Button();
            btnExport = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(61, 24);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(652, 292);
            dataGridView1.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(61, 322);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(78, 54);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Dodaj";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
        
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(145, 322);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(78, 54);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "Edytuj";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(229, 322);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(78, 54);
            btnRemove.TabIndex = 4;
            btnRemove.Text = "Usuń";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnImport
            // 
            btnImport.Location = new Point(313, 322);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(78, 54);
            btnImport.TabIndex = 5;
            btnImport.Text = "Importuj";
            btnImport.UseVisualStyleBackColor = true;
            btnImport.Click += btnImport_Click;
            // 
            // btnExport
            // 
            btnExport.Location = new Point(397, 322);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(78, 54);
            btnExport.TabIndex = 6;
            btnExport.Text = "Eksportuj";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExport);
            Controls.Add(btnImport);
            Controls.Add(btnRemove);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnAdd;
      
        private Button btnEdit;
        private Button btnRemove;
        private Button btnImport;
        private Button btnExport;
    }
}