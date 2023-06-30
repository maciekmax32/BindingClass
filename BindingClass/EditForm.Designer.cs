namespace BindingClass
{
    partial class EditForm
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
            txtTytul = new TextBox();
            txtRezyserAutor = new TextBox();
            dtpDataWydania = new DateTimePicker();
            txtWydawcaStudio = new TextBox();
            txtNosnik = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtDlugosc = new TextBox();
            label6 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtTytul
            // 
            txtTytul.Location = new Point(7, 48);
            txtTytul.Name = "txtTytul";
            txtTytul.Size = new Size(198, 23);
            txtTytul.TabIndex = 0;
            // 
            // txtRezyserAutor
            // 
            txtRezyserAutor.Location = new Point(7, 97);
            txtRezyserAutor.Name = "txtRezyserAutor";
            txtRezyserAutor.Size = new Size(198, 23);
            txtRezyserAutor.TabIndex = 1;
            // 
            // dtpDataWydania
            // 
            dtpDataWydania.Location = new Point(317, 97);
            dtpDataWydania.Name = "dtpDataWydania";
            dtpDataWydania.Size = new Size(200, 23);
            dtpDataWydania.TabIndex = 2;
            // 
            // txtWydawcaStudio
            // 
            txtWydawcaStudio.Location = new Point(7, 145);
            txtWydawcaStudio.Name = "txtWydawcaStudio";
            txtWydawcaStudio.Size = new Size(198, 23);
            txtWydawcaStudio.TabIndex = 3;
            // 
            // txtNosnik
            // 
            txtNosnik.Location = new Point(7, 189);
            txtNosnik.Name = "txtNosnik";
            txtNosnik.Size = new Size(198, 23);
            txtNosnik.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 30);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 5;
            label1.Text = "Tytuł";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 79);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 6;
            label2.Text = "Reżyser Autor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 123);
            label3.Name = "label3";
            label3.Size = new Size(97, 15);
            label3.TabIndex = 7;
            label3.Text = "Wydawca/Studio";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 171);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 8;
            label4.Text = "Nośnik";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 215);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 9;
            label5.Text = "Długość";
            // 
            // txtDlugosc
            // 
            txtDlugosc.Location = new Point(7, 242);
            txtDlugosc.Name = "txtDlugosc";
            txtDlugosc.Size = new Size(198, 23);
            txtDlugosc.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(317, 79);
            label6.Name = "label6";
            label6.Size = new Size(80, 15);
            label6.TabIndex = 11;
            label6.Text = "Data Wydania";
            // 
            // button1
            // 
            button1.Location = new Point(522, 215);
            button1.Name = "button1";
            button1.Size = new Size(157, 59);
            button1.TabIndex = 12;
            button1.Text = "Zapisz";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // EditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(txtDlugosc);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNosnik);
            Controls.Add(txtWydawcaStudio);
            Controls.Add(dtpDataWydania);
            Controls.Add(txtRezyserAutor);
            Controls.Add(txtTytul);
            Name = "EditForm";
            Text = "EditForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTytul;
        private TextBox txtRezyserAutor;
        private DateTimePicker dtpDataWydania;
        private TextBox txtWydawcaStudio;
        private TextBox txtNosnik;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtDlugosc;
        private Label label6;
        private Button button1;
    }
}