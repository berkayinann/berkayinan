namespace Ödev_6___Berkay_İNAN
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
            gbparametreler = new GroupBox();
            txtsifreekranı = new TextBox();
            bturet = new Button();
            numericsifresayisi = new NumericUpDown();
            numericsifreuzunlugu = new NumericUpDown();
            lbsifresayisi = new Label();
            lbsifreuzunlugu = new Label();
            cbkucukharf = new CheckBox();
            cbbuyukharf = new CheckBox();
            cbrakam = new CheckBox();
            cbozelkarakter = new CheckBox();
            gbparametreler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericsifresayisi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericsifreuzunlugu).BeginInit();
            SuspendLayout();
            // 
            // gbparametreler
            // 
            gbparametreler.Controls.Add(cbozelkarakter);
            gbparametreler.Controls.Add(cbrakam);
            gbparametreler.Controls.Add(cbbuyukharf);
            gbparametreler.Controls.Add(cbkucukharf);
            gbparametreler.Controls.Add(lbsifreuzunlugu);
            gbparametreler.Controls.Add(lbsifresayisi);
            gbparametreler.Controls.Add(numericsifreuzunlugu);
            gbparametreler.Controls.Add(numericsifresayisi);
            gbparametreler.Controls.Add(bturet);
            gbparametreler.Location = new Point(12, 12);
            gbparametreler.Name = "gbparametreler";
            gbparametreler.Size = new Size(435, 540);
            gbparametreler.TabIndex = 0;
            gbparametreler.TabStop = false;
            gbparametreler.Text = "PARAMETRELER";
            // 
            // txtsifreekranı
            // 
            txtsifreekranı.Location = new Point(464, 20);
            txtsifreekranı.Multiline = true;
            txtsifreekranı.Name = "txtsifreekranı";
            txtsifreekranı.Size = new Size(429, 532);
            txtsifreekranı.TabIndex = 1;
            // 
            // bturet
            // 
            bturet.Location = new Point(201, 427);
            bturet.Name = "bturet";
            bturet.Size = new Size(202, 83);
            bturet.TabIndex = 0;
            bturet.Text = "ÜRET";
            bturet.UseVisualStyleBackColor = true;
            bturet.Click += bturet_Click;
            // 
            // numericsifresayisi
            // 
            numericsifresayisi.Location = new Point(215, 303);
            numericsifresayisi.Name = "numericsifresayisi";
            numericsifresayisi.Size = new Size(194, 27);
            numericsifresayisi.TabIndex = 1;
            // 
            // numericsifreuzunlugu
            // 
            numericsifreuzunlugu.Location = new Point(215, 353);
            numericsifreuzunlugu.Name = "numericsifreuzunlugu";
            numericsifreuzunlugu.Size = new Size(194, 27);
            numericsifreuzunlugu.TabIndex = 2;
            // 
            // lbsifresayisi
            // 
            lbsifresayisi.AutoSize = true;
            lbsifresayisi.Location = new Point(45, 310);
            lbsifresayisi.Name = "lbsifresayisi";
            lbsifresayisi.Size = new Size(117, 20);
            lbsifresayisi.TabIndex = 3;
            lbsifresayisi.Text = "Şifre sayısı         :";
            // 
            // lbsifreuzunlugu
            // 
            lbsifreuzunlugu.AutoSize = true;
            lbsifreuzunlugu.Location = new Point(45, 360);
            lbsifreuzunlugu.Name = "lbsifreuzunlugu";
            lbsifreuzunlugu.Size = new Size(116, 20);
            lbsifreuzunlugu.TabIndex = 4;
            lbsifreuzunlugu.Text = "Şifre Uzunluğu  :";
            // 
            // cbkucukharf
            // 
            cbkucukharf.AutoSize = true;
            cbkucukharf.Location = new Point(82, 55);
            cbkucukharf.Name = "cbkucukharf";
            cbkucukharf.Size = new Size(103, 24);
            cbkucukharf.TabIndex = 5;
            cbkucukharf.Text = "Küçük Harf";
            cbkucukharf.UseVisualStyleBackColor = true;
            // 
            // cbbuyukharf
            // 
            cbbuyukharf.AutoSize = true;
            cbbuyukharf.Location = new Point(82, 103);
            cbbuyukharf.Name = "cbbuyukharf";
            cbbuyukharf.Size = new Size(103, 24);
            cbbuyukharf.TabIndex = 6;
            cbbuyukharf.Text = "Büyük Harf";
            cbbuyukharf.UseVisualStyleBackColor = true;
            // 
            // cbrakam
            // 
            cbrakam.AutoSize = true;
            cbrakam.Location = new Point(82, 151);
            cbrakam.Name = "cbrakam";
            cbrakam.Size = new Size(76, 24);
            cbrakam.TabIndex = 7;
            cbrakam.Text = "Rakam";
            cbrakam.UseVisualStyleBackColor = true;
            // 
            // cbozelkarakter
            // 
            cbozelkarakter.AutoSize = true;
            cbozelkarakter.Location = new Point(82, 199);
            cbozelkarakter.Name = "cbozelkarakter";
            cbozelkarakter.Size = new Size(120, 24);
            cbozelkarakter.TabIndex = 8;
            cbozelkarakter.Text = "Özel Karakter";
            cbozelkarakter.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(905, 564);
            Controls.Add(txtsifreekranı);
            Controls.Add(gbparametreler);
            Name = "Form1";
            Text = "Form1";
            gbparametreler.ResumeLayout(false);
            gbparametreler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericsifresayisi).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericsifreuzunlugu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbparametreler;
        private NumericUpDown numericsifresayisi;
        private Button bturet;
        private TextBox txtsifreekranı;
        private CheckBox cbozelkarakter;
        private CheckBox cbrakam;
        private CheckBox cbbuyukharf;
        private CheckBox cbkucukharf;
        private Label lbsifreuzunlugu;
        private Label lbsifresayisi;
        private NumericUpDown numericsifreuzunlugu;
    }
}