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
            this.etajTextBox = new System.Windows.Forms.TextBox();
            this.rasstTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bezPodyomaRadioButton = new System.Windows.Forms.RadioButton();
            this.sLiftomRadioButton = new System.Windows.Forms.RadioButton();
            this.bezLiftaRadioButton = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.bunifuDatepicker1 = new ns1.BunifuDatepicker();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.mezhgorodRadioButton = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.sovmDostRadioButton = new System.Windows.Forms.RadioButton();
            this.shippingTextBox = new System.Windows.Forms.TextBox();
            this.individDostRadioButton = new System.Windows.Forms.RadioButton();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.podyomTextBox = new System.Windows.Forms.TextBox();
            this.complectTextBox = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // furnitureTextBox
            // 
            this.furnitureTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.furnitureTextBox.Location = new System.Drawing.Point(166, 181);
            this.furnitureTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.furnitureTextBox.Name = "furnitureTextBox";
            this.furnitureTextBox.Size = new System.Drawing.Size(332, 25);
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
            this.label3.Size = new System.Drawing.Size(93, 34);
            this.label3.TabIndex = 3;
            this.label3.Text = "количество матрасов";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 277);
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
            this.textBox2.Location = new System.Drawing.Point(3, 313);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(156, 43);
            this.textBox2.TabIndex = 6;
            this.textBox2.Text = "расстояние за  пределы ульяновска";
            // 
            // textBox3
            // 
            this.textBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox3.Location = new System.Drawing.Point(166, 4);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(332, 25);
            this.textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            this.textBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox4.Location = new System.Drawing.Point(166, 82);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(332, 25);
            this.textBox4.TabIndex = 8;
            // 
            // textBox5
            // 
            this.textBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox5.Location = new System.Drawing.Point(166, 115);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(332, 25);
            this.textBox5.TabIndex = 9;
            // 
            // textBox6
            // 
            this.textBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox6.Location = new System.Drawing.Point(166, 148);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(332, 25);
            this.textBox6.TabIndex = 10;
            // 
            // totalTextBox
            // 
            this.totalTextBox.BackColor = System.Drawing.Color.White;
            this.totalTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.totalTextBox.Location = new System.Drawing.Point(229, 7);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.Size = new System.Drawing.Size(130, 18);
            this.totalTextBox.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(4, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 33);
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
            this.label6.Size = new System.Drawing.Size(154, 45);
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
            this.label7.Size = new System.Drawing.Size(154, 33);
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
            this.label9.Size = new System.Drawing.Size(154, 33);
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
            this.weightTextBox.Location = new System.Drawing.Point(166, 214);
            this.weightTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(332, 25);
            this.weightTextBox.TabIndex = 22;
            this.weightTextBox.TextChanged += new System.EventHandler(this.WeightTextBox_TextChanged);
            // 
            // matrasTextBox
            // 
            this.matrasTextBox.Location = new System.Drawing.Point(166, 247);
            this.matrasTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.matrasTextBox.Name = "matrasTextBox";
            this.matrasTextBox.Size = new System.Drawing.Size(332, 25);
            this.matrasTextBox.TabIndex = 23;
            this.matrasTextBox.TextChanged += new System.EventHandler(this.MatrasTextBox_TextChanged);
            // 
            // etajTextBox
            // 
            this.etajTextBox.Location = new System.Drawing.Point(166, 281);
            this.etajTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.etajTextBox.Name = "etajTextBox";
            this.etajTextBox.Size = new System.Drawing.Size(332, 25);
            this.etajTextBox.TabIndex = 24;
            this.etajTextBox.TextChanged += new System.EventHandler(this.textBox9_TextChanged_1);
            // 
            // rasstTextBox
            // 
            this.rasstTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rasstTextBox.Location = new System.Drawing.Point(166, 314);
            this.rasstTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.rasstTextBox.Name = "rasstTextBox";
            this.rasstTextBox.Size = new System.Drawing.Size(332, 25);
            this.rasstTextBox.TabIndex = 25;
            this.rasstTextBox.Text = "0";
            this.rasstTextBox.TextChanged += new System.EventHandler(this.RasstTextBox_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.label17);
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
            this.radioButton6.Size = new System.Drawing.Size(121, 27);
            this.radioButton6.TabIndex = 12;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "(0 рублей)";
            this.radioButton6.UseVisualStyleBackColor = false;
            this.radioButton6.CheckedChanged += new System.EventHandler(this.RadioButton6_CheckedChanged);
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton7.Location = new System.Drawing.Point(12, 60);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(121, 27);
            this.radioButton7.TabIndex = 28;
            this.radioButton7.Text = "(0 рублей)";
            this.radioButton7.UseVisualStyleBackColor = true;
            this.radioButton7.CheckedChanged += new System.EventHandler(this.RadioButton7_CheckedChanged);
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.radioButton8.Location = new System.Drawing.Point(12, 35);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(121, 27);
            this.radioButton8.TabIndex = 13;
            this.radioButton8.Text = "(0 рублей)";
            this.radioButton8.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.radioButton8.UseVisualStyleBackColor = true;
            this.radioButton8.CheckedChanged += new System.EventHandler(this.RadioButton8_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.podyomTextBox);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.bezPodyomaRadioButton);
            this.panel3.Controls.Add(this.sLiftomRadioButton);
            this.panel3.Controls.Add(this.bezLiftaRadioButton);
            this.panel3.Location = new System.Drawing.Point(16, 111);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(543, 114);
            this.panel3.TabIndex = 31;
            // 
            // bezPodyomaRadioButton
            // 
            this.bezPodyomaRadioButton.AutoSize = true;
            this.bezPodyomaRadioButton.Checked = true;
            this.bezPodyomaRadioButton.Location = new System.Drawing.Point(12, 9);
            this.bezPodyomaRadioButton.Name = "bezPodyomaRadioButton";
            this.bezPodyomaRadioButton.Size = new System.Drawing.Size(96, 21);
            this.bezPodyomaRadioButton.TabIndex = 12;
            this.bezPodyomaRadioButton.TabStop = true;
            this.bezPodyomaRadioButton.Text = "(0 рублей)";
            this.bezPodyomaRadioButton.UseVisualStyleBackColor = true;
            this.bezPodyomaRadioButton.CheckedChanged += new System.EventHandler(this.RadioButton5_CheckedChanged);
            // 
            // sLiftomRadioButton
            // 
            this.sLiftomRadioButton.AutoSize = true;
            this.sLiftomRadioButton.Location = new System.Drawing.Point(12, 60);
            this.sLiftomRadioButton.Name = "sLiftomRadioButton";
            this.sLiftomRadioButton.Size = new System.Drawing.Size(96, 21);
            this.sLiftomRadioButton.TabIndex = 28;
            this.sLiftomRadioButton.Text = "(0 рублей)";
            this.sLiftomRadioButton.UseVisualStyleBackColor = true;
            this.sLiftomRadioButton.CheckedChanged += new System.EventHandler(this.RadioButton9_CheckedChanged);
            // 
            // bezLiftaRadioButton
            // 
            this.bezLiftaRadioButton.AutoSize = true;
            this.bezLiftaRadioButton.Location = new System.Drawing.Point(12, 35);
            this.bezLiftaRadioButton.Name = "bezLiftaRadioButton";
            this.bezLiftaRadioButton.Size = new System.Drawing.Size(96, 21);
            this.bezLiftaRadioButton.TabIndex = 13;
            this.bezLiftaRadioButton.Text = "(0 рублей)";
            this.bezLiftaRadioButton.UseVisualStyleBackColor = true;
            this.bezLiftaRadioButton.CheckedChanged += new System.EventHandler(this.RadioButton10_CheckedChanged);
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
            this.tableLayoutPanel1.Controls.Add(this.etajTextBox, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.matrasTextBox, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.textBox5, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.weightTextBox, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.textBox6, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.furnitureTextBox, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.textBox2, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.bunifuDatepicker1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 4);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(502, 396);
            this.tableLayoutPanel1.TabIndex = 32;
            // 
            // bunifuDatepicker1
            // 
            this.bunifuDatepicker1.BackColor = System.Drawing.Color.Orange;
            this.bunifuDatepicker1.BorderRadius = 0;
            this.bunifuDatepicker1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuDatepicker1.ForeColor = System.Drawing.Color.White;
            this.bunifuDatepicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.bunifuDatepicker1.FormatCustom = null;
            this.bunifuDatepicker1.Location = new System.Drawing.Point(166, 37);
            this.bunifuDatepicker1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuDatepicker1.Name = "bunifuDatepicker1";
            this.bunifuDatepicker1.Size = new System.Drawing.Size(332, 37);
            this.bunifuDatepicker1.TabIndex = 30;
            this.bunifuDatepicker1.Value = new System.DateTime(2019, 9, 21, 16, 36, 35, 669);
            this.bunifuDatepicker1.onValueChanged += new System.EventHandler(this.BunifuDatepicker1_onValueChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(26, 46);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(516, 432);
            this.tabControl1.TabIndex = 33;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(508, 402);
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
            this.tabPage2.Size = new System.Drawing.Size(299, 402);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Доставка";
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
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(170, 92);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(275, 17);
            this.label14.TabIndex = 33;
            this.label14.Text = "Доставка за пределы г.Ульяновска, км";
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
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(170, 38);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(471, 17);
            this.label12.TabIndex = 31;
            this.label12.Text = "Совместная доставка до подъезда по г.Ульяновск c 9 до 15 в будни";
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
            // shippingTextBox
            // 
            this.shippingTextBox.Location = new System.Drawing.Point(473, 103);
            this.shippingTextBox.Name = "shippingTextBox";
            this.shippingTextBox.Size = new System.Drawing.Size(90, 25);
            this.shippingTextBox.TabIndex = 11;
            this.shippingTextBox.Text = "0";
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
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panel3);
            this.tabPage3.ForeColor = System.Drawing.Color.Black;
            this.tabPage3.Location = new System.Drawing.Point(4, 26);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(508, 402);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Подьем";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.comboBox1);
            this.tabPage4.Controls.Add(this.complectTextBox);
            this.tabPage4.Controls.Add(this.panel2);
            this.tabPage4.Controls.Add(this.textBox12);
            this.tabPage4.ForeColor = System.Drawing.Color.Black;
            this.tabPage4.Location = new System.Drawing.Point(4, 26);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(508, 402);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Сборка";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // textBox12
            // 
            this.textBox12.BackColor = System.Drawing.Color.White;
            this.textBox12.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox12.Location = new System.Drawing.Point(15, 76);
            this.textBox12.Multiline = true;
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(217, 32);
            this.textBox12.TabIndex = 27;
            this.textBox12.Text = "Крепление к стенам (кол-во отверстий)";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Orange;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Location = new System.Drawing.Point(-67, -23);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(861, 63);
            this.panel4.TabIndex = 34;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkOrange;
            this.panel5.Controls.Add(this.totalTextBox);
            this.panel5.Location = new System.Drawing.Point(0, 484);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(755, 93);
            this.panel5.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 31;
            this.label1.Text = "Без сборки";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(121, 70);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(75, 17);
            this.label15.TabIndex = 32;
            this.label15.Text = "Подъем 2";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(121, 40);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(75, 17);
            this.label16.TabIndex = 33;
            this.label16.Text = "Подъем 1";
            // 
            // podyomTextBox
            // 
            this.podyomTextBox.Location = new System.Drawing.Point(226, 45);
            this.podyomTextBox.Name = "podyomTextBox";
            this.podyomTextBox.Size = new System.Drawing.Size(90, 25);
            this.podyomTextBox.TabIndex = 34;
            this.podyomTextBox.Text = "0";
            // 
            // complectTextBox
            // 
            this.complectTextBox.Location = new System.Drawing.Point(227, 297);
            this.complectTextBox.Name = "complectTextBox";
            this.complectTextBox.Size = new System.Drawing.Size(90, 25);
            this.complectTextBox.TabIndex = 31;
            this.complectTextBox.Text = "0";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(120, 37);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(707, 22);
            this.label17.TabIndex = 32;
            this.label17.Text = "Подъем (занос) мебели по этажам без грузового лифта, либо частично на лифте";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(120, 11);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(197, 22);
            this.label18.TabIndex = 33;
            this.label18.Text = "Без подъема и заноса";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(121, 62);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(377, 22);
            this.label19.TabIndex = 34;
            this.label19.Text = "Подъем (занос) мебели на грузовом лифте";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBox1.Location = new System.Drawing.Point(238, 73);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 25);
            this.comboBox1.TabIndex = 32;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(563, 521);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TextBox etajTextBox;
        private System.Windows.Forms.TextBox rasstTextBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton bezPodyomaRadioButton;
        private System.Windows.Forms.RadioButton sLiftomRadioButton;
        private System.Windows.Forms.RadioButton bezLiftaRadioButton;
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
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox podyomTextBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox complectTextBox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

