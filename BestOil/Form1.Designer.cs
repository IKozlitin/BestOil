namespace BestOil
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Gas = new System.Windows.Forms.GroupBox();
            this.sumGas = new System.Windows.Forms.Label();
            this.gasLitRub = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.countRubles = new System.Windows.Forms.TextBox();
            this.countLitres = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioRubles = new System.Windows.Forms.RadioButton();
            this.radioLitres = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.priceGas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gasName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.priceCola = new System.Windows.Forms.TextBox();
            this.countCola = new System.Windows.Forms.TextBox();
            this.checkCola = new System.Windows.Forms.CheckBox();
            this.priceFries = new System.Windows.Forms.TextBox();
            this.countFries = new System.Windows.Forms.TextBox();
            this.checkFries = new System.Windows.Forms.CheckBox();
            this.priceHamburger = new System.Windows.Forms.TextBox();
            this.countHamburger = new System.Windows.Forms.TextBox();
            this.checkHamburger = new System.Windows.Forms.CheckBox();
            this.priceHotdog = new System.Windows.Forms.TextBox();
            this.countHotdog = new System.Windows.Forms.TextBox();
            this.checkHotdog = new System.Windows.Forms.CheckBox();
            this.countProd = new System.Windows.Forms.Label();
            this.priceProd = new System.Windows.Forms.Label();
            this.Cafe = new System.Windows.Forms.GroupBox();
            this.sumCafe = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.all = new System.Windows.Forms.GroupBox();
            this.sumAll = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonSumAll = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.Gas.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.Cafe.SuspendLayout();
            this.all.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Gas);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.countRubles);
            this.groupBox1.Controls.Add(this.countLitres);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.priceGas);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.gasName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 366);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Автозаправка";
            // 
            // Gas
            // 
            this.Gas.Controls.Add(this.sumGas);
            this.Gas.Controls.Add(this.gasLitRub);
            this.Gas.Location = new System.Drawing.Point(25, 250);
            this.Gas.Name = "Gas";
            this.Gas.Size = new System.Drawing.Size(301, 100);
            this.Gas.TabIndex = 10;
            this.Gas.TabStop = false;
            this.Gas.Text = "К оплате:";
            // 
            // sumGas
            // 
            this.sumGas.AutoSize = true;
            this.sumGas.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sumGas.Location = new System.Drawing.Point(187, 32);
            this.sumGas.Name = "sumGas";
            this.sumGas.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.sumGas.Size = new System.Drawing.Size(51, 55);
            this.sumGas.TabIndex = 12;
            this.sumGas.Text = "0";
            this.sumGas.Click += new System.EventHandler(this.sumGas_Click);
            // 
            // gasLitRub
            // 
            this.gasLitRub.AutoSize = true;
            this.gasLitRub.Location = new System.Drawing.Point(244, 60);
            this.gasLitRub.Name = "gasLitRub";
            this.gasLitRub.Size = new System.Drawing.Size(38, 20);
            this.gasLitRub.TabIndex = 10;
            this.gasLitRub.Text = "руб.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(288, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "руб.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(288, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "л";
            // 
            // countRubles
            // 
            this.countRubles.Enabled = false;
            this.countRubles.Location = new System.Drawing.Point(184, 199);
            this.countRubles.Name = "countRubles";
            this.countRubles.Size = new System.Drawing.Size(84, 26);
            this.countRubles.TabIndex = 7;
            this.countRubles.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // countLitres
            // 
            this.countLitres.Enabled = false;
            this.countLitres.Location = new System.Drawing.Point(184, 167);
            this.countLitres.Name = "countLitres";
            this.countLitres.Size = new System.Drawing.Size(84, 26);
            this.countLitres.TabIndex = 6;
            this.countLitres.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioRubles);
            this.groupBox2.Controls.Add(this.radioLitres);
            this.groupBox2.Location = new System.Drawing.Point(25, 143);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(141, 100);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // radioRubles
            // 
            this.radioRubles.AutoSize = true;
            this.radioRubles.Location = new System.Drawing.Point(7, 56);
            this.radioRubles.Name = "radioRubles";
            this.radioRubles.Size = new System.Drawing.Size(76, 24);
            this.radioRubles.TabIndex = 1;
            this.radioRubles.TabStop = true;
            this.radioRubles.Text = "Сумма";
            this.radioRubles.UseVisualStyleBackColor = true;
            this.radioRubles.CheckedChanged += new System.EventHandler(this.radioRubles_CheckedChanged);
            // 
            // radioLitres
            // 
            this.radioLitres.AutoSize = true;
            this.radioLitres.Location = new System.Drawing.Point(7, 26);
            this.radioLitres.Name = "radioLitres";
            this.radioLitres.Size = new System.Drawing.Size(118, 24);
            this.radioLitres.TabIndex = 0;
            this.radioLitres.TabStop = true;
            this.radioLitres.Text = "Количество";
            this.radioLitres.UseVisualStyleBackColor = true;
            this.radioLitres.CheckedChanged += new System.EventHandler(this.radioLitres_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(288, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "руб.";
            // 
            // priceGas
            // 
            this.priceGas.Enabled = false;
            this.priceGas.Location = new System.Drawing.Point(117, 92);
            this.priceGas.Name = "priceGas";
            this.priceGas.Size = new System.Drawing.Size(151, 26);
            this.priceGas.TabIndex = 3;
            this.priceGas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Цена";
            // 
            // gasName
            // 
            this.gasName.FormattingEnabled = true;
            this.gasName.Items.AddRange(new object[] {
            "Аи-92",
            "Аи-95",
            "Аи-98",
            "Дт"});
            this.gasName.Location = new System.Drawing.Point(117, 37);
            this.gasName.Name = "gasName";
            this.gasName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gasName.Size = new System.Drawing.Size(151, 28);
            this.gasName.TabIndex = 1;
            this.gasName.SelectedIndexChanged += new System.EventHandler(this.gasName_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Бензин";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.priceCola);
            this.groupBox4.Controls.Add(this.countCola);
            this.groupBox4.Controls.Add(this.checkCola);
            this.groupBox4.Controls.Add(this.priceFries);
            this.groupBox4.Controls.Add(this.countFries);
            this.groupBox4.Controls.Add(this.checkFries);
            this.groupBox4.Controls.Add(this.priceHamburger);
            this.groupBox4.Controls.Add(this.countHamburger);
            this.groupBox4.Controls.Add(this.checkHamburger);
            this.groupBox4.Controls.Add(this.priceHotdog);
            this.groupBox4.Controls.Add(this.countHotdog);
            this.groupBox4.Controls.Add(this.checkHotdog);
            this.groupBox4.Controls.Add(this.countProd);
            this.groupBox4.Controls.Add(this.priceProd);
            this.groupBox4.Controls.Add(this.Cafe);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox4.Location = new System.Drawing.Point(412, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(346, 366);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Мини-кафе";
            // 
            // priceCola
            // 
            this.priceCola.Enabled = false;
            this.priceCola.Location = new System.Drawing.Point(139, 171);
            this.priceCola.Name = "priceCola";
            this.priceCola.Size = new System.Drawing.Size(84, 26);
            this.priceCola.TabIndex = 24;
            this.priceCola.Text = "120";
            this.priceCola.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // countCola
            // 
            this.countCola.Enabled = false;
            this.countCola.Location = new System.Drawing.Point(244, 171);
            this.countCola.Name = "countCola";
            this.countCola.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.countCola.Size = new System.Drawing.Size(84, 26);
            this.countCola.TabIndex = 23;
            this.countCola.Text = "0";
            // 
            // checkCola
            // 
            this.checkCola.AutoSize = true;
            this.checkCola.Location = new System.Drawing.Point(25, 170);
            this.checkCola.Name = "checkCola";
            this.checkCola.Size = new System.Drawing.Size(105, 24);
            this.checkCola.TabIndex = 22;
            this.checkCola.Text = "Кока-кола";
            this.checkCola.UseVisualStyleBackColor = true;
            this.checkCola.CheckedChanged += new System.EventHandler(this.checkCola_CheckedChanged);
            // 
            // priceFries
            // 
            this.priceFries.Enabled = false;
            this.priceFries.Location = new System.Drawing.Point(139, 134);
            this.priceFries.Name = "priceFries";
            this.priceFries.Size = new System.Drawing.Size(84, 26);
            this.priceFries.TabIndex = 21;
            this.priceFries.Text = "80";
            this.priceFries.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // countFries
            // 
            this.countFries.Enabled = false;
            this.countFries.Location = new System.Drawing.Point(244, 134);
            this.countFries.Name = "countFries";
            this.countFries.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.countFries.Size = new System.Drawing.Size(84, 26);
            this.countFries.TabIndex = 20;
            this.countFries.Text = "0";
            // 
            // checkFries
            // 
            this.checkFries.AutoSize = true;
            this.checkFries.Location = new System.Drawing.Point(25, 134);
            this.checkFries.Name = "checkFries";
            this.checkFries.Size = new System.Drawing.Size(107, 24);
            this.checkFries.TabIndex = 19;
            this.checkFries.Text = "Карт.-фри";
            this.checkFries.UseVisualStyleBackColor = true;
            this.checkFries.CheckedChanged += new System.EventHandler(this.checkFries_CheckedChanged);
            // 
            // priceHamburger
            // 
            this.priceHamburger.Enabled = false;
            this.priceHamburger.Location = new System.Drawing.Point(139, 95);
            this.priceHamburger.Name = "priceHamburger";
            this.priceHamburger.Size = new System.Drawing.Size(84, 26);
            this.priceHamburger.TabIndex = 18;
            this.priceHamburger.Text = "180";
            this.priceHamburger.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // countHamburger
            // 
            this.countHamburger.Enabled = false;
            this.countHamburger.Location = new System.Drawing.Point(244, 95);
            this.countHamburger.Name = "countHamburger";
            this.countHamburger.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.countHamburger.Size = new System.Drawing.Size(84, 26);
            this.countHamburger.TabIndex = 17;
            this.countHamburger.Text = "0";
            // 
            // checkHamburger
            // 
            this.checkHamburger.AutoSize = true;
            this.checkHamburger.Location = new System.Drawing.Point(25, 95);
            this.checkHamburger.Name = "checkHamburger";
            this.checkHamburger.Size = new System.Drawing.Size(107, 24);
            this.checkHamburger.TabIndex = 16;
            this.checkHamburger.Text = "Гамбургер";
            this.checkHamburger.UseVisualStyleBackColor = true;
            this.checkHamburger.CheckedChanged += new System.EventHandler(this.checkHamburger_CheckedChanged);
            // 
            // priceHotdog
            // 
            this.priceHotdog.Enabled = false;
            this.priceHotdog.Location = new System.Drawing.Point(139, 59);
            this.priceHotdog.Name = "priceHotdog";
            this.priceHotdog.Size = new System.Drawing.Size(84, 26);
            this.priceHotdog.TabIndex = 15;
            this.priceHotdog.Text = "150";
            this.priceHotdog.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // countHotdog
            // 
            this.countHotdog.Enabled = false;
            this.countHotdog.Location = new System.Drawing.Point(244, 59);
            this.countHotdog.Name = "countHotdog";
            this.countHotdog.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.countHotdog.Size = new System.Drawing.Size(84, 26);
            this.countHotdog.TabIndex = 14;
            this.countHotdog.Text = "0";
            // 
            // checkHotdog
            // 
            this.checkHotdog.AutoSize = true;
            this.checkHotdog.Location = new System.Drawing.Point(25, 59);
            this.checkHotdog.Name = "checkHotdog";
            this.checkHotdog.Size = new System.Drawing.Size(89, 24);
            this.checkHotdog.TabIndex = 13;
            this.checkHotdog.Text = "Хот-дог";
            this.checkHotdog.UseVisualStyleBackColor = true;
            this.checkHotdog.CheckedChanged += new System.EventHandler(this.checkHotdog_CheckedChanged);
            // 
            // countProd
            // 
            this.countProd.AutoSize = true;
            this.countProd.Location = new System.Drawing.Point(240, 26);
            this.countProd.Name = "countProd";
            this.countProd.Size = new System.Drawing.Size(100, 20);
            this.countProd.TabIndex = 12;
            this.countProd.Text = "Количество";
            // 
            // priceProd
            // 
            this.priceProd.AutoSize = true;
            this.priceProd.Location = new System.Drawing.Point(159, 26);
            this.priceProd.Name = "priceProd";
            this.priceProd.Size = new System.Drawing.Size(48, 20);
            this.priceProd.TabIndex = 11;
            this.priceProd.Text = "Цена";
            // 
            // Cafe
            // 
            this.Cafe.Controls.Add(this.sumCafe);
            this.Cafe.Controls.Add(this.label7);
            this.Cafe.Location = new System.Drawing.Point(25, 250);
            this.Cafe.Name = "Cafe";
            this.Cafe.Size = new System.Drawing.Size(301, 100);
            this.Cafe.TabIndex = 10;
            this.Cafe.TabStop = false;
            this.Cafe.Text = "К оплате:";
            // 
            // sumCafe
            // 
            this.sumCafe.AutoSize = true;
            this.sumCafe.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sumCafe.Location = new System.Drawing.Point(181, 32);
            this.sumCafe.Name = "sumCafe";
            this.sumCafe.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.sumCafe.Size = new System.Drawing.Size(51, 55);
            this.sumCafe.TabIndex = 11;
            this.sumCafe.Text = "0";
            this.sumCafe.Click += new System.EventHandler(this.sumCafe_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(238, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "руб.";
            // 
            // all
            // 
            this.all.Controls.Add(this.sumAll);
            this.all.Controls.Add(this.pictureBox1);
            this.all.Controls.Add(this.label8);
            this.all.Controls.Add(this.buttonSumAll);
            this.all.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.all.Location = new System.Drawing.Point(13, 386);
            this.all.Name = "all";
            this.all.Size = new System.Drawing.Size(745, 113);
            this.all.TabIndex = 2;
            this.all.TabStop = false;
            this.all.Text = "Всего к оплате";
            // 
            // sumAll
            // 
            this.sumAll.AutoSize = true;
            this.sumAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sumAll.Location = new System.Drawing.Point(630, 42);
            this.sumAll.Name = "sumAll";
            this.sumAll.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.sumAll.Size = new System.Drawing.Size(51, 55);
            this.sumAll.TabIndex = 12;
            this.sumAll.Text = "0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BestOil.Properties.Resources.local_gas_station_FILL0_wght400_GRAD0_opsz48;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(57, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 55);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(687, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "руб.";
            // 
            // buttonSumAll
            // 
            this.buttonSumAll.Location = new System.Drawing.Point(150, 35);
            this.buttonSumAll.Name = "buttonSumAll";
            this.buttonSumAll.Size = new System.Drawing.Size(176, 55);
            this.buttonSumAll.TabIndex = 0;
            this.buttonSumAll.Text = "Посчитать";
            this.buttonSumAll.UseVisualStyleBackColor = true;
            this.buttonSumAll.Click += new System.EventHandler(this.buttonSumAll_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(784, 511);
            this.Controls.Add(this.all);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(800, 550);
            this.MinimumSize = new System.Drawing.Size(800, 550);
            this.Name = "Form1";
            this.Text = "BestOil";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Gas.ResumeLayout(false);
            this.Gas.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.Cafe.ResumeLayout(false);
            this.Cafe.PerformLayout();
            this.all.ResumeLayout(false);
            this.all.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox priceGas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox countRubles;
        private System.Windows.Forms.TextBox countLitres;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioRubles;
        private System.Windows.Forms.RadioButton radioLitres;
        private System.Windows.Forms.GroupBox Gas;
        private System.Windows.Forms.GroupBox Cafe;
        private System.Windows.Forms.Label countProd;
        private System.Windows.Forms.Label priceProd;
        private System.Windows.Forms.TextBox priceCola;
        private System.Windows.Forms.TextBox countCola;
        private System.Windows.Forms.CheckBox checkCola;
        private System.Windows.Forms.TextBox priceFries;
        private System.Windows.Forms.TextBox countFries;
        private System.Windows.Forms.CheckBox checkFries;
        private System.Windows.Forms.TextBox priceHamburger;
        private System.Windows.Forms.TextBox countHamburger;
        private System.Windows.Forms.CheckBox checkHamburger;
        private System.Windows.Forms.GroupBox all;
        private System.Windows.Forms.Label gasLitRub;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonSumAll;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label sumGas;
        private System.Windows.Forms.Label sumAll;
        private System.Windows.Forms.ComboBox gasName;
        private System.Windows.Forms.Label sumCafe;
        private System.Windows.Forms.CheckBox checkHotdog;
        private System.Windows.Forms.TextBox priceHotdog;
        private System.Windows.Forms.TextBox countHotdog;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}

