
namespace PolatOtoGaleri
{
    partial class FormAracKaydıEkle
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
            this.BtnEkle = new System.Windows.Forms.Button();
            this.txtHasarFiyati = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtAlimFiyati = new System.Windows.Forms.TextBox();
            this.txtKm = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtHasarDurumu = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dtAlimTarihi = new System.Windows.Forms.DateTimePicker();
            this.txtRenk = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbVites = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.numMotorHacmi = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numMotorGucu = new System.Windows.Forms.NumericUpDown();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numYil = new System.Windows.Forms.NumericUpDown();
            this.cbKasa = new System.Windows.Forms.ComboBox();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numMotorHacmi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMotorGucu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYil)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnEkle
            // 
            this.BtnEkle.BackColor = System.Drawing.Color.Yellow;
            this.BtnEkle.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnEkle.Location = new System.Drawing.Point(523, 133);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(96, 83);
            this.BtnEkle.TabIndex = 58;
            this.BtnEkle.Text = "Ekle";
            this.BtnEkle.UseVisualStyleBackColor = false;
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // txtHasarFiyati
            // 
            this.txtHasarFiyati.Location = new System.Drawing.Point(523, 70);
            this.txtHasarFiyati.Name = "txtHasarFiyati";
            this.txtHasarFiyati.Size = new System.Drawing.Size(100, 20);
            this.txtHasarFiyati.TabIndex = 56;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(436, 73);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 13);
            this.label14.TabIndex = 57;
            this.label14.Text = "Hasar Fiyatı";
            // 
            // txtAlimFiyati
            // 
            this.txtAlimFiyati.Location = new System.Drawing.Point(523, 10);
            this.txtAlimFiyati.Name = "txtAlimFiyati";
            this.txtAlimFiyati.Size = new System.Drawing.Size(100, 20);
            this.txtAlimFiyati.TabIndex = 55;
            // 
            // txtKm
            // 
            this.txtKm.Location = new System.Drawing.Point(523, 96);
            this.txtKm.Name = "txtKm";
            this.txtKm.Size = new System.Drawing.Size(100, 20);
            this.txtKm.TabIndex = 53;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(463, 100);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(21, 13);
            this.label13.TabIndex = 54;
            this.label13.Text = "km";
            // 
            // txtHasarDurumu
            // 
            this.txtHasarDurumu.Location = new System.Drawing.Point(523, 36);
            this.txtHasarDurumu.Name = "txtHasarDurumu";
            this.txtHasarDurumu.Size = new System.Drawing.Size(100, 20);
            this.txtHasarDurumu.TabIndex = 51;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(419, 40);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 13);
            this.label12.TabIndex = 52;
            this.label12.Text = "Hasar Durumu ( % )";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(464, 14);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 50;
            this.label11.Text = "Alım Fiyatı";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(231, 133);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 49;
            this.label10.Text = "Alım Tarihi";
            // 
            // dtAlimTarihi
            // 
            this.dtAlimTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtAlimTarihi.Location = new System.Drawing.Point(296, 129);
            this.dtAlimTarihi.Name = "dtAlimTarihi";
            this.dtAlimTarihi.Size = new System.Drawing.Size(100, 20);
            this.dtAlimTarihi.TabIndex = 48;
            // 
            // txtRenk
            // 
            this.txtRenk.Location = new System.Drawing.Point(296, 81);
            this.txtRenk.Name = "txtRenk";
            this.txtRenk.Size = new System.Drawing.Size(100, 20);
            this.txtRenk.TabIndex = 46;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(236, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 47;
            this.label9.Text = "Renk";
            // 
            // cbVites
            // 
            this.cbVites.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVites.FormattingEnabled = true;
            this.cbVites.Items.AddRange(new object[] {
            "manuel",
            "yarı otomatik",
            "otomatik"});
            this.cbVites.Location = new System.Drawing.Point(296, 40);
            this.cbVites.Name = "cbVites";
            this.cbVites.Size = new System.Drawing.Size(100, 21);
            this.cbVites.TabIndex = 45;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(237, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 44;
            this.label8.Text = "Vites";
            // 
            // numMotorHacmi
            // 
            this.numMotorHacmi.Location = new System.Drawing.Point(296, 9);
            this.numMotorHacmi.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numMotorHacmi.Name = "numMotorHacmi";
            this.numMotorHacmi.Size = new System.Drawing.Size(100, 20);
            this.numMotorHacmi.TabIndex = 43;
            this.numMotorHacmi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(219, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 42;
            this.label6.Text = "Motor Hacmi";
            // 
            // numMotorGucu
            // 
            this.numMotorGucu.Location = new System.Drawing.Point(86, 131);
            this.numMotorGucu.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numMotorGucu.Name = "numMotorGucu";
            this.numMotorGucu.Size = new System.Drawing.Size(100, 20);
            this.numMotorGucu.TabIndex = 41;
            this.numMotorGucu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(86, 35);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(100, 20);
            this.txtModel.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Yıl";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "Motor Gücü";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Model";
            // 
            // numYil
            // 
            this.numYil.Location = new System.Drawing.Point(86, 63);
            this.numYil.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numYil.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numYil.Name = "numYil";
            this.numYil.Size = new System.Drawing.Size(100, 20);
            this.numYil.TabIndex = 38;
            this.numYil.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numYil.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // cbKasa
            // 
            this.cbKasa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKasa.FormattingEnabled = true;
            this.cbKasa.Items.AddRange(new object[] {
            "sedan",
            "hatchback",
            "station wagon",
            "suv",
            "pick-up",
            "minivan",
            "panelvan",
            "coupe",
            "cabrio"});
            this.cbKasa.Location = new System.Drawing.Point(86, 99);
            this.cbKasa.Name = "cbKasa";
            this.cbKasa.Size = new System.Drawing.Size(100, 21);
            this.cbKasa.TabIndex = 39;
            // 
            // txtMarka
            // 
            this.txtMarka.Location = new System.Drawing.Point(86, 9);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(100, 20);
            this.txtMarka.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Marka";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Kasa Tipi";
            // 
            // FormAracKaydıEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 239);
            this.Controls.Add(this.BtnEkle);
            this.Controls.Add(this.txtHasarFiyati);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtAlimFiyati);
            this.Controls.Add(this.txtKm);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtHasarDurumu);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dtAlimTarihi);
            this.Controls.Add(this.txtRenk);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbVites);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.numMotorHacmi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numMotorGucu);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numYil);
            this.Controls.Add(this.cbKasa);
            this.Controls.Add(this.txtMarka);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAracKaydıEkle";
            this.Text = "Araç Kaydı Ekle - Polat Oto";
            ((System.ComponentModel.ISupportInitialize)(this.numMotorHacmi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMotorGucu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnEkle;
        private System.Windows.Forms.TextBox txtHasarFiyati;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtAlimFiyati;
        private System.Windows.Forms.TextBox txtKm;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtHasarDurumu;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtAlimTarihi;
        private System.Windows.Forms.TextBox txtRenk;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbVites;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numMotorHacmi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numMotorGucu;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numYil;
        private System.Windows.Forms.ComboBox cbKasa;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
    }
}