namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.furnitureTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.matrasTextBox = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.rasstTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.podyomTextBox = new System.Windows.Forms.TextBox();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.complectTextBox = new System.Windows.Forms.TextBox();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.individDostRadioButton = new System.Windows.Forms.RadioButton();
            this.shippingTextBox = new System.Windows.Forms.TextBox();
            this.sovmDostRadioButton = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.mezhgorodRadioButton = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.bunifuDatepicker1 = new ns1.BunifuDatepicker();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // furnitureTextBox
            // 
            this.furnitureTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.furnitureTextBox.Location = new System.Drawing.Point(184, 181);
            this.furnitureTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.furnitureTextBox.Name = "furnitureTextBox";
            this.furnitureTextBox.Size = new System.Drawing.Size(367, 25);
            this.furnitureTextBox.TabIndex = 1;
            this.furnitureTextBox.Text = "0";
            this.furnitureTextBox.TextChanged += new System.EventHandler(this.FurnitureTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 210);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Вес";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 243);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "количество матрасов";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 276);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Этаж";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox2.Location = new System.Drawing.Point(3, 312);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(174, 43);
            this.textBox2.TabIndex = 6;
            this.textBox2.Text = "расстояние за  пределы ульяновска";
            // 
            // textBox3
            // 
            this.textBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox3.Location = new System.Drawing.Point(184, 4);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(367, 25);
            this.textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            this.textBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox4.Location = new System.Drawing.Point(184, 82);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(367, 25);
            this.textBox4.TabIndex = 8;
            // 
            // textBox5
            // 
            this.textBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox5.Location = new System.Drawing.Point(184, 115);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(367, 25);
            this.textBox5.TabIndex = 9;
            // 
            // textBox6
            // 
            this.textBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox6.Location = new System.Drawing.Point(184, 148);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(367, 25);
            this.textBox6.TabIndex = 10;
            // 
            // totalTextBox
            // 
            this.totalTextBox.BackColor = System.Drawing.Color.DarkOrange;
            this.totalTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.totalTextBox.Location = new System.Drawing.Point(135, 484);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.Size = new System.Drawing.Size(500, 18);
            this.totalTextBox.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(4, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 33);
            this.label5.TabIndex = 15;
            this.label5.Text = "Номер договора";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(4, 33);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 45);
            this.label6.TabIndex = 16;
            this.label6.Text = "Дата";
            this.label6.Click += new System.EventHandler(this.Label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(4, 78);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(172, 33);
            this.label7.TabIndex = 17;
            this.label7.Text = "ФИО";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 144);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "Адрес доставки";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Location = new System.Drawing.Point(4, 111);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(172, 33);
            this.label9.TabIndex = 19;
            this.label9.Text = "Телефоны";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 177);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(140, 17);
            this.label10.TabIndex = 20;
            this.label10.Text = "Стоимость мебели";
            // 
            // weightTextBox
            // 
            this.weightTextBox.Location = new System.Drawing.Point(184, 214);
            this.weightTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(192, 25);
            this.weightTextBox.TabIndex = 22;
            this.weightTextBox.TextChanged += new System.EventHandler(this.WeightTextBox_TextChanged);
            // 
            // matrasTextBox
            // 
            this.matrasTextBox.Location = new System.Drawing.Point(184, 247);
            this.matrasTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.matrasTextBox.Name = "matrasTextBox";
            this.matrasTextBox.Size = new System.Drawing.Size(192, 25);
            this.matrasTextBox.TabIndex = 23;
            this.matrasTextBox.TextChanged += new System.EventHandler(this.MatrasTextBox_TextChanged);
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(184, 280);
            this.textBox9.Margin = new System.Windows.Forms.Padding(4);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(192, 25);
            this.textBox9.TabIndex = 24;
            // 
            // rasstTextBox
            // 
            this.rasstTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rasstTextBox.Location = new System.Drawing.Point(184, 313);
            this.rasstTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.rasstTextBox.Name = "rasstTextBox";
            this.rasstTextBox.Size = new System.Drawing.Size(367, 25);
            this.rasstTextBox.TabIndex = 25;
            this.rasstTextBox.Text = "0";
            this.rasstTextBox.TextChanged += new System.EventHandler(this.RasstTextBox_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radioButton6);
            this.panel2.Controls.Add(this.radioButton7);
            this.panel2.Controls.Add(this.radioButton8);
            this.panel2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel2.Location = new System.Drawing.Point(3, 124);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(583, 98);
            this.panel2.TabIndex = 30;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.BackColor = System.Drawing.Color.Transparent;
            this.radioButton6.Checked = true;
            this.radioButton6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton6.ForeColor = System.Drawing.Color.Black;
            this.radioButton6.Location = new System.Drawing.Point(12, 9);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(221, 27);
            this.radioButton6.TabIndex = 12;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Без подъема и заноса";
            this.radioButton6.UseVisualStyleBackColor = false;
            this.radioButton6.CheckedChanged += new System.EventHandler(this.RadioButton6_CheckedChanged);
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton7.Location = new System.Drawing.Point(12, 60);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(401, 27);
            this.radioButton7.TabIndex = 28;
            this.radioButton7.Text = "Подъем (занос) мебели на грузовом лифте";
            this.radioButton7.UseVisualStyleBackColor = true;
            this.radioButton7.CheckedChanged += new System.EventHandler(this.RadioButton7_CheckedChanged);
            // 
            // podyomTextBox
            // 
            this.podyomTextBox.Location = new System.Drawing.Point(203, 339);
            this.podyomTextBox.Name = "podyomTextBox";
            this.podyomTextBox.Size = new System.Drawing.Size(90, 25);
            this.podyomTextBox.TabIndex = 11;
            this.podyomTextBox.Text = "0";
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.radioButton8.Location = new System.Drawing.Point(12, 35);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(731, 27);
            this.radioButton8.TabIndex = 13;
            this.radioButton8.Text = "Подъем (занос) мебели по этажам без грузового лифта, либо частично на лифте";
            this.radioButton8.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.radioButton8.UseVisualStyleBackColor = true;
            this.radioButton8.CheckedChanged += new System.EventHandler(this.RadioButton8_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.radioButton5);
            this.panel3.Controls.Add(this.radioButton9);
            this.panel3.Controls.Add(this.complectTextBox);
            this.panel3.Controls.Add(this.radioButton10);
            this.panel3.Location = new System.Drawing.Point(16, 111);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(543, 114);
            this.panel3.TabIndex = 31;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Checked = true;
            this.radioButton5.Location = new System.Drawing.Point(12, 9);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(103, 21);
            this.radioButton5.TabIndex = 12;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Без сборки";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.RadioButton5_CheckedChanged);
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Location = new System.Drawing.Point(12, 60);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(445, 38);
            this.radioButton9.TabIndex = 28;
            this.radioButton9.Text = "Подъ\"Сборка + Крепление к стенам \n(см кол-во отверстий)\"ем (занос) мебели на груз" +
    "овом лифте";
            this.radioButton9.UseVisualStyleBackColor = true;
            this.radioButton9.CheckedChanged += new System.EventHandler(this.RadioButton9_CheckedChanged);
            // 
            // complectTextBox
            // 
            this.complectTextBox.Location = new System.Drawing.Point(474, 62);
            this.complectTextBox.Name = "complectTextBox";
            this.complectTextBox.Size = new System.Drawing.Size(90, 25);
            this.complectTextBox.TabIndex = 11;
            this.complectTextBox.Text = "0";
            // 
            // radioButton10
            // 
            this.radioButton10.AutoSize = true;
            this.radioButton10.Location = new System.Drawing.Point(12, 35);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(249, 21);
            this.radioButton10.TabIndex = 13;
            this.radioButton10.Text = "Сборка без крепления к стенам";
            this.radioButton10.UseVisualStyleBackColor = true;
            this.radioButton10.CheckedChanged += new System.EventHandler(this.RadioButton10_CheckedChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.43243F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.56757F));
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox4, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.rasstTextBox, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBox9, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.matrasTextBox, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.textBox5, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.weightTextBox, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.textBox6, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.furnitureTextBox, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.textBox2, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.bunifuDatepicker1, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 11;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(555, 396);
            this.tableLayoutPanel1.TabIndex = 32;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(146, 46);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(569, 432);
            this.tabControl1.TabIndex = 33;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(561, 402);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Главная";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(492, 402);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Доставка";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panel3);
            this.tabPage3.ForeColor = System.Drawing.Color.Black;
            this.tabPage3.Location = new System.Drawing.Point(4, 26);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(492, 402);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Подьем";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.panel2);
            this.tabPage4.Controls.Add(this.textBox11);
            this.tabPage4.Controls.Add(this.podyomTextBox);
            this.tabPage4.Controls.Add(this.textBox12);
            this.tabPage4.ForeColor = System.Drawing.Color.Black;
            this.tabPage4.Location = new System.Drawing.Point(4, 26);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(492, 402);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Сборка";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // individDostRadioButton
            // 
            this.individDostRadioButton.AutoSize = true;
            this.individDostRadioButton.Location = new System.Drawing.Point(11, 63);
            this.individDostRadioButton.Name = "individDostRadioButton";
            this.individDostRadioButton.Size = new System.Drawing.Size(120, 21);
            this.individDostRadioButton.TabIndex = 13;
            this.individDostRadioButton.Text = "(3000 рублей)";
            this.individDostRadioButton.UseVisualStyleBackColor = true;
            this.individDostRadioButton.CheckedChanged += new System.EventHandler(this.individDostavkaClick);
            // 
            // shippingTextBox
            // 
            this.shippingTextBox.Location = new System.Drawing.Point(473, 103);
            this.shippingTextBox.Name = "shippingTextBox";
            this.shippingTextBox.Size = new System.Drawing.Size(90, 25);
            this.shippingTextBox.TabIndex = 11;
            this.shippingTextBox.Text = "0";
            // 
            // sovmDostRadioButton
            // 
            this.sovmDostRadioButton.AutoSize = true;
            this.sovmDostRadioButton.Location = new System.Drawing.Point(11, 36);
            this.sovmDostRadioButton.Name = "sovmDostRadioButton";
            this.sovmDostRadioButton.Size = new System.Drawing.Size(112, 21);
            this.sovmDostRadioButton.TabIndex = 28;
            this.sovmDostRadioButton.Text = "(400 рублей)";
            this.sovmDostRadioButton.UseVisualStyleBackColor = true;
            this.sovmDostRadioButton.CheckedChanged += new System.EventHandler(this.sovmDostavkaClick);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(12, 9);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(96, 21);
            this.radioButton1.TabIndex = 12;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "(0 рублей)";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.samovyvozDostavkaClick);
            // 
            // mezhgorodRadioButton
            // 
            this.mezhgorodRadioButton.AutoSize = true;
            this.mezhgorodRadioButton.Location = new System.Drawing.Point(12, 90);
            this.mezhgorodRadioButton.Name = "mezhgorodRadioButton";
            this.mezhgorodRadioButton.Size = new System.Drawing.Size(112, 21);
            this.mezhgorodRadioButton.TabIndex = 29;
            this.mezhgorodRadioButton.Text = "(700 рублей)";
            this.mezhgorodRadioButton.UseVisualStyleBackColor = true;
            this.mezhgorodRadioButton.CheckedChanged += new System.EventHandler(this.mezhgorodDostavkaClick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(114, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 17);
            this.label11.TabIndex = 30;
            this.label11.Text = " Самовывоз";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(170, 38);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(471, 17);
            this.label12.TabIndex = 31;
            this.label12.Text = "Совместная доставка до подъезда по г.Ульяновск c 9 до 15 в будни";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(170, 65);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(386, 17);
            this.label13.TabIndex = 32;
            this.label13.Text = "Индивидуальная доставка до подъезда по г.Ульяновск";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(170, 92);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(275, 17);
            this.label14.TabIndex = 33;
            this.label14.Text = "Доставка за пределы г.Ульяновска, км";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.mezhgorodRadioButton);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.sovmDostRadioButton);
            this.panel1.Controls.Add(this.shippingTextBox);
            this.panel1.Controls.Add(this.individDostRadioButton);
            this.panel1.Location = new System.Drawing.Point(6, 118);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(627, 177);
            this.panel1.TabIndex = 29;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Orange;
            this.panel4.Location = new System.Drawing.Point(-67, -23);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(861, 63);
            this.panel4.TabIndex = 34;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkOrange;
            this.panel5.Location = new System.Drawing.Point(0, 508);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(755, 69);
            this.panel5.TabIndex = 35;
            // 
            // bunifuDatepicker1
            // 
            this.bunifuDatepicker1.BackColor = System.Drawing.Color.Orange;
            this.bunifuDatepicker1.BorderRadius = 0;
            this.bunifuDatepicker1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuDatepicker1.ForeColor = System.Drawing.Color.White;
            this.bunifuDatepicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.bunifuDatepicker1.FormatCustom = null;
            this.bunifuDatepicker1.Location = new System.Drawing.Point(184, 37);
            this.bunifuDatepicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuDatepicker1.Name = "bunifuDatepicker1";
            this.bunifuDatepicker1.Size = new System.Drawing.Size(367, 37);
            this.bunifuDatepicker1.TabIndex = 30;
            this.bunifuDatepicker1.Value = new System.DateTime(2019, 9, 21, 16, 36, 35, 669);
            this.bunifuDatepicker1.onValueChanged += new System.EventHandler(this.BunifuDatepicker1_onValueChanged);
            // 
            // textBox12
            // 
            this.textBox12.BackColor = System.Drawing.Color.White;
            this.textBox12.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox12.Location = new System.Drawing.Point(3, 18);
            this.textBox12.Multiline = true;
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(217, 32);
            this.textBox12.TabIndex = 27;
            this.textBox12.Text = "Крепление к стенам (кол-во отверстий)";
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(227, 21);
            this.textBox11.Margin = new System.Windows.Forms.Padding(4);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(255, 25);
            this.textBox11.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(738, 521);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.totalTextBox);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox furnitureTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.TextBox matrasTextBox;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox rasstTextBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.TextBox podyomTextBox;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.TextBox complectTextBox;
        private System.Windows.Forms.RadioButton radioButton10;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton mezhgorodRadioButton;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton sovmDostRadioButton;
        private System.Windows.Forms.TextBox shippingTextBox;
        private System.Windows.Forms.RadioButton individDostRadioButton;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private ns1.BunifuDatepicker bunifuDatepicker1;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
    }
}

