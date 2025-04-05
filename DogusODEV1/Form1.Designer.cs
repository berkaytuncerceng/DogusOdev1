namespace DogusODEV1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTutar = new System.Windows.Forms.TextBox();
            this.PayButton = new System.Windows.Forms.Button();
            this.comboBoxOdemeYontemleri = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ödeme Şekli:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tutar:";
            // 
            // textBoxTutar
            // 
            this.textBoxTutar.Location = new System.Drawing.Point(175, 105);
            this.textBoxTutar.Name = "textBoxTutar";
            this.textBoxTutar.Size = new System.Drawing.Size(206, 20);
            this.textBoxTutar.TabIndex = 3;
            // 
            // PayButton
            // 
            this.PayButton.Location = new System.Drawing.Point(188, 143);
            this.PayButton.Name = "PayButton";
            this.PayButton.Size = new System.Drawing.Size(193, 34);
            this.PayButton.TabIndex = 4;
            this.PayButton.Text = "Ödemeyi Tamamla";
            this.PayButton.UseVisualStyleBackColor = true;
            this.PayButton.Click += new System.EventHandler(this.PayButton_Click);
            // 
            // comboBoxOdemeYontemleri
            // 
            this.comboBoxOdemeYontemleri.FormattingEnabled = true;
            this.comboBoxOdemeYontemleri.Location = new System.Drawing.Point(175, 69);
            this.comboBoxOdemeYontemleri.Name = "comboBoxOdemeYontemleri";
            this.comboBoxOdemeYontemleri.Size = new System.Drawing.Size(206, 21);
            this.comboBoxOdemeYontemleri.TabIndex = 5;
            this.comboBoxOdemeYontemleri.SelectedIndexChanged += new System.EventHandler(this.comboBoxOdemeYontemleri_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(185, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 393);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxOdemeYontemleri);
            this.Controls.Add(this.PayButton);
            this.Controls.Add(this.textBoxTutar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTutar;
        private System.Windows.Forms.Button PayButton;
        private System.Windows.Forms.ComboBox comboBoxOdemeYontemleri;
        private System.Windows.Forms.Label label3;
    }
}

