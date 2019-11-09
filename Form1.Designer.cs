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
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.individDostRadioButton = new System.Windows.Forms.RadioButton();
            this.shippingTextBox = new System.Windows.Forms.TextBox();
            this.sovmDostRadioButton = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.mezhgorodRadioButton = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bezLiftaRadioButton = new System.Windows.Forms.RadioButton();
            this.sLiftomRadioButton = new System.Windows.Forms.RadioButton();
            this.bezPodyomaRadioButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.complectTextBox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.podyomTextBox = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.rasstTextBox = new System.Windows.Forms.MaskedTextBox();
            this.kreplenieBox = new System.Windows.Forms.MaskedTextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.MaskedTextBox();
            this.textBox4 = new System.Windows.Forms.MaskedTextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.MaskedTextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.MaskedTextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.furnitureTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.weightTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.etajTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.matrasComboBox = new ns1.BunifuDropdown();
            this.dateTimePicker1 = new ns1.BunifuDatepicker();
            this.Sborka2RadioButton = new System.Windows.Forms.RadioButton();
            this.Sborka1RadioButton = new System.Windows.Forms.RadioButton();
            this.label17 = new System.Windows.Forms.Label();
            this.bezSborkiRadioButton = new System.Windows.Forms.RadioButton();
            this.label19 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.nextButton = new ns1.BunifuFlatButton();
            this.prevButton = new ns1.BunifuFlatButton();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(66)))), ((int)(((byte)(131)))));
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.ForeColor = System.Drawing.Color.Transparent;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(535, 521);
            this.panel4.TabIndex = 34;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(66)))), ((int)(((byte)(131)))));
            this.panel5.Controls.Add(this.prevButton);
            this.panel5.Controls.Add(this.nextButton);
            this.panel5.Controls.Add(this.totalTextBox);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 478);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(535, 43);
            this.panel5.TabIndex = 39;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel5_Paint);
            // 
            // totalTextBox
            // 
            this.totalTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.totalTextBox.BackColor = System.Drawing.Color.White;
            this.totalTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalTextBox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.totalTextBox.Location = new System.Drawing.Point(12, 6);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.Size = new System.Drawing.Size(112, 29);
            this.totalTextBox.TabIndex = 14;
            this.totalTextBox.TextChanged += new System.EventHandler(this.totalTextBox_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label33);
            this.panel1.Controls.Add(this.label24);
            this.panel1.Controls.Add(this.rasstTextBox);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.mezhgorodRadioButton);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.sovmDostRadioButton);
            this.panel1.Controls.Add(this.shippingTextBox);
            this.panel1.Controls.Add(this.individDostRadioButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(568, 169);
            this.panel1.TabIndex = 29;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // individDostRadioButton
            // 
            this.individDostRadioButton.AutoSize = true;
            this.individDostRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.individDostRadioButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.individDostRadioButton.Location = new System.Drawing.Point(12, 104);
            this.individDostRadioButton.Name = "individDostRadioButton";
            this.individDostRadioButton.Size = new System.Drawing.Size(121, 22);
            this.individDostRadioButton.TabIndex = 13;
            this.individDostRadioButton.Text = "(3000 рублей)";
            this.individDostRadioButton.UseVisualStyleBackColor = true;
            this.individDostRadioButton.CheckedChanged += new System.EventHandler(this.individDostavkaClick);
            // 
            // shippingTextBox
            // 
            this.shippingTextBox.Location = new System.Drawing.Point(474, 141);
            this.shippingTextBox.Name = "shippingTextBox";
            this.shippingTextBox.Size = new System.Drawing.Size(90, 25);
            this.shippingTextBox.TabIndex = 11;
            this.shippingTextBox.Text = "0";
            this.shippingTextBox.Visible = false;
            // 
            // sovmDostRadioButton
            // 
            this.sovmDostRadioButton.AutoSize = true;
            this.sovmDostRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sovmDostRadioButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.sovmDostRadioButton.Location = new System.Drawing.Point(12, 79);
            this.sovmDostRadioButton.Name = "sovmDostRadioButton";
            this.sovmDostRadioButton.Size = new System.Drawing.Size(113, 22);
            this.sovmDostRadioButton.TabIndex = 28;
            this.sovmDostRadioButton.Text = "(400 рублей)";
            this.sovmDostRadioButton.UseVisualStyleBackColor = true;
            this.sovmDostRadioButton.CheckedChanged += new System.EventHandler(this.sovmDostavkaClick);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton1.ForeColor = System.Drawing.Color.Gainsboro;
            this.radioButton1.ImageKey = "(отсутствует)";
            this.radioButton1.Location = new System.Drawing.Point(13, 55);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(97, 22);
            this.radioButton1.TabIndex = 12;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "(0 рублей)";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.samovyvozDostavkaClick);
            // 
            // mezhgorodRadioButton
            // 
            this.mezhgorodRadioButton.AutoSize = true;
            this.mezhgorodRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mezhgorodRadioButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.mezhgorodRadioButton.Location = new System.Drawing.Point(12, 130);
            this.mezhgorodRadioButton.Name = "mezhgorodRadioButton";
            this.mezhgorodRadioButton.Size = new System.Drawing.Size(113, 22);
            this.mezhgorodRadioButton.TabIndex = 29;
            this.mezhgorodRadioButton.Text = "(400 рублей)";
            this.mezhgorodRadioButton.UseVisualStyleBackColor = true;
            this.mezhgorodRadioButton.CheckedChanged += new System.EventHandler(this.mezhgorodDostavkaClick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.Gainsboro;
            this.label11.Location = new System.Drawing.Point(148, 56);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 18);
            this.label11.TabIndex = 30;
            this.label11.Text = "Самовывоз";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.ForeColor = System.Drawing.Color.Gainsboro;
            this.label12.Location = new System.Drawing.Point(147, 82);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(491, 18);
            this.label12.TabIndex = 31;
            this.label12.Text = "Совместная доставка до подъезда по г.Ульяновск c 9 до 15 в будни";
            this.label12.Click += new System.EventHandler(this.Label12_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.ForeColor = System.Drawing.Color.Gainsboro;
            this.label13.Location = new System.Drawing.Point(148, 107);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(399, 18);
            this.label13.TabIndex = 32;
            this.label13.Text = "Индивидуальная доставка до подъезда по г.Ульяновск";
            this.label13.Click += new System.EventHandler(this.Label13_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.ForeColor = System.Drawing.Color.Gainsboro;
            this.label14.Location = new System.Drawing.Point(148, 131);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(286, 18);
            this.label14.TabIndex = 33;
            this.label14.Text = "Доставка за пределы г.Ульяновска, км";
            this.label14.Click += new System.EventHandler(this.Label14_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.label32);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.complectTextBox);
            this.panel3.Controls.Add(this.podyomTextBox);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.bezPodyomaRadioButton);
            this.panel3.Controls.Add(this.sLiftomRadioButton);
            this.panel3.Controls.Add(this.bezLiftaRadioButton);
            this.panel3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel3.Location = new System.Drawing.Point(3, 170);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(560, 124);
            this.panel3.TabIndex = 32;
            // 
            // bezLiftaRadioButton
            // 
            this.bezLiftaRadioButton.AutoSize = true;
            this.bezLiftaRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.bezLiftaRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bezLiftaRadioButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.bezLiftaRadioButton.Location = new System.Drawing.Point(10, 56);
            this.bezLiftaRadioButton.Name = "bezLiftaRadioButton";
            this.bezLiftaRadioButton.Size = new System.Drawing.Size(121, 24);
            this.bezLiftaRadioButton.TabIndex = 13;
            this.bezLiftaRadioButton.Text = "(300 рублей)";
            this.bezLiftaRadioButton.UseVisualStyleBackColor = false;
            this.bezLiftaRadioButton.CheckedChanged += new System.EventHandler(this.BezLiftaRadioButton_CheckedChanged);
            // 
            // sLiftomRadioButton
            // 
            this.sLiftomRadioButton.AutoSize = true;
            this.sLiftomRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.sLiftomRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sLiftomRadioButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.sLiftomRadioButton.Location = new System.Drawing.Point(10, 84);
            this.sLiftomRadioButton.Name = "sLiftomRadioButton";
            this.sLiftomRadioButton.Size = new System.Drawing.Size(121, 24);
            this.sLiftomRadioButton.TabIndex = 28;
            this.sLiftomRadioButton.Text = "(300 рублей)";
            this.sLiftomRadioButton.UseVisualStyleBackColor = false;
            this.sLiftomRadioButton.CheckedChanged += new System.EventHandler(this.SLiftomRadioButton_CheckedChanged);
            // 
            // bezPodyomaRadioButton
            // 
            this.bezPodyomaRadioButton.AutoSize = true;
            this.bezPodyomaRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.bezPodyomaRadioButton.Checked = true;
            this.bezPodyomaRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bezPodyomaRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bezPodyomaRadioButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.bezPodyomaRadioButton.Location = new System.Drawing.Point(12, 28);
            this.bezPodyomaRadioButton.Name = "bezPodyomaRadioButton";
            this.bezPodyomaRadioButton.Size = new System.Drawing.Size(102, 24);
            this.bezPodyomaRadioButton.TabIndex = 12;
            this.bezPodyomaRadioButton.TabStop = true;
            this.bezPodyomaRadioButton.Text = "(0 рублей)";
            this.bezPodyomaRadioButton.UseVisualStyleBackColor = false;
            this.bezPodyomaRadioButton.CheckedChanged += new System.EventHandler(this.BezPodyomaRadioButton_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(139, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "Без подъема";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.ForeColor = System.Drawing.Color.Gainsboro;
            this.label15.Location = new System.Drawing.Point(139, 86);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(223, 20);
            this.label15.TabIndex = 32;
            this.label15.Text = "Подъем на грузовом лифте";
            this.label15.Click += new System.EventHandler(this.Label15_Click);
            // 
            // complectTextBox
            // 
            this.complectTextBox.Location = new System.Drawing.Point(391, 194);
            this.complectTextBox.Name = "complectTextBox";
            this.complectTextBox.Size = new System.Drawing.Size(90, 25);
            this.complectTextBox.TabIndex = 38;
            this.complectTextBox.Text = "0";
            this.complectTextBox.Visible = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.ForeColor = System.Drawing.Color.Gainsboro;
            this.label16.Location = new System.Drawing.Point(139, 56);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(158, 20);
            this.label16.TabIndex = 33;
            this.label16.Text = "Подъем без лифта";
            this.label16.Click += new System.EventHandler(this.Label16_Click);
            // 
            // podyomTextBox
            // 
            this.podyomTextBox.Location = new System.Drawing.Point(467, 66);
            this.podyomTextBox.Name = "podyomTextBox";
            this.podyomTextBox.Size = new System.Drawing.Size(90, 25);
            this.podyomTextBox.TabIndex = 35;
            this.podyomTextBox.Text = "0";
            this.podyomTextBox.Visible = false;
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.Location = new System.Drawing.Point(143, 356);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(111, 26);
            this.label18.TabIndex = 33;
            this.label18.Text = "Без сборки";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label18.Click += new System.EventHandler(this.Label18_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(116)))), ((int)(((byte)(247)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(535, 10);
            this.panel2.TabIndex = 34;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.Gainsboro;
            this.label8.Location = new System.Drawing.Point(110, 184);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Адрес доставки";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(109, 21);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Номер договора";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.Gainsboro;
            this.label10.Location = new System.Drawing.Point(98, 354);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(154, 20);
            this.label10.TabIndex = 20;
            this.label10.Text = "Стоимость мебели";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(380, 309);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Дата";
            this.label6.Click += new System.EventHandler(this.Label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.Gainsboro;
            this.label7.Location = new System.Drawing.Point(145, 101);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "ФИО";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(314, 236);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Количество матрасов";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(376, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Вес";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(372, 145);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Этаж";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.Gainsboro;
            this.label9.Location = new System.Drawing.Point(128, 275);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "Телефоны";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label31);
            this.panel6.Controls.Add(this.label19);
            this.panel6.Controls.Add(this.label23);
            this.panel6.Controls.Add(this.Sborka2RadioButton);
            this.panel6.Controls.Add(this.Sborka1RadioButton);
            this.panel6.Controls.Add(this.kreplenieBox);
            this.panel6.Controls.Add(this.label22);
            this.panel6.Controls.Add(this.bezSborkiRadioButton);
            this.panel6.Controls.Add(this.panel1);
            this.panel6.Controls.Add(this.label17);
            this.panel6.Controls.Add(this.label18);
            this.panel6.Controls.Add(this.panel3);
            this.panel6.ForeColor = System.Drawing.Color.Gainsboro;
            this.panel6.Location = new System.Drawing.Point(13, 16);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(568, 464);
            this.panel6.TabIndex = 40;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(66)))), ((int)(((byte)(131)))));
            this.panel7.Controls.Add(this.dateTimePicker1);
            this.panel7.Controls.Add(this.matrasComboBox);
            this.panel7.Controls.Add(this.etajTextBox);
            this.panel7.Controls.Add(this.label30);
            this.panel7.Controls.Add(this.weightTextBox);
            this.panel7.Controls.Add(this.label29);
            this.panel7.Controls.Add(this.furnitureTextBox);
            this.panel7.Controls.Add(this.label28);
            this.panel7.Controls.Add(this.textBox5);
            this.panel7.Controls.Add(this.label27);
            this.panel7.Controls.Add(this.textBox6);
            this.panel7.Controls.Add(this.label26);
            this.panel7.Controls.Add(this.textBox4);
            this.panel7.Controls.Add(this.label25);
            this.panel7.Controls.Add(this.textBox3);
            this.panel7.Controls.Add(this.label21);
            this.panel7.Controls.Add(this.label8);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Controls.Add(this.label10);
            this.panel7.Controls.Add(this.label6);
            this.panel7.Controls.Add(this.label7);
            this.panel7.Controls.Add(this.label9);
            this.panel7.Controls.Add(this.label3);
            this.panel7.Controls.Add(this.label4);
            this.panel7.Controls.Add(this.label2);
            this.panel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel7.ForeColor = System.Drawing.Color.Gainsboro;
            this.panel7.Location = new System.Drawing.Point(-1, 17);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(625, 422);
            this.panel7.TabIndex = 41;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label20.ForeColor = System.Drawing.Color.Gainsboro;
            this.label20.Location = new System.Drawing.Point(148, 30);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(260, 18);
            this.label20.TabIndex = 36;
            this.label20.Text = "Расстояние за пределы ульяновска";
            // 
            // rasstTextBox
            // 
            this.rasstTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(66)))), ((int)(((byte)(131)))));
            this.rasstTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rasstTextBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.rasstTextBox.Location = new System.Drawing.Point(14, 26);
            this.rasstTextBox.Name = "rasstTextBox";
            this.rasstTextBox.Size = new System.Drawing.Size(118, 18);
            this.rasstTextBox.TabIndex = 37;
            // 
            // kreplenieBox
            // 
            this.kreplenieBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(66)))), ((int)(((byte)(131)))));
            this.kreplenieBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.kreplenieBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.kreplenieBox.Location = new System.Drawing.Point(9, 320);
            this.kreplenieBox.Name = "kreplenieBox";
            this.kreplenieBox.Size = new System.Drawing.Size(122, 18);
            this.kreplenieBox.TabIndex = 39;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Enabled = false;
            this.label22.ForeColor = System.Drawing.Color.Gainsboro;
            this.label22.Location = new System.Drawing.Point(6, 326);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(128, 17);
            this.label22.TabIndex = 38;
            this.label22.Text = "_______________";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label23.ForeColor = System.Drawing.Color.Gainsboro;
            this.label23.Location = new System.Drawing.Point(139, 325);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(260, 18);
            this.label23.TabIndex = 38;
            this.label23.Text = "Расстояние за пределы ульяновска";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Enabled = false;
            this.label24.ForeColor = System.Drawing.Color.Gainsboro;
            this.label24.Location = new System.Drawing.Point(10, 31);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(112, 17);
            this.label24.TabIndex = 40;
            this.label24.Text = "_____________";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Enabled = false;
            this.label21.ForeColor = System.Drawing.SystemColors.Control;
            this.label21.Location = new System.Drawing.Point(34, 50);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(264, 18);
            this.label21.TabIndex = 42;
            this.label21.Text = "________________________________";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(66)))), ((int)(((byte)(131)))));
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.ForeColor = System.Drawing.Color.Gainsboro;
            this.textBox3.Location = new System.Drawing.Point(37, 45);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(254, 17);
            this.textBox3.TabIndex = 41;
            this.textBox3.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.textBox3_MaskInputRejected);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(66)))), ((int)(((byte)(131)))));
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.ForeColor = System.Drawing.Color.Gainsboro;
            this.textBox4.Location = new System.Drawing.Point(37, 122);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(254, 17);
            this.textBox4.TabIndex = 43;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Enabled = false;
            this.label25.ForeColor = System.Drawing.SystemColors.Control;
            this.label25.Location = new System.Drawing.Point(34, 127);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(264, 18);
            this.label25.TabIndex = 44;
            this.label25.Text = "________________________________";
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(66)))), ((int)(((byte)(131)))));
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.ForeColor = System.Drawing.Color.Gainsboro;
            this.textBox6.Location = new System.Drawing.Point(38, 207);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(254, 17);
            this.textBox6.TabIndex = 45;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Enabled = false;
            this.label26.ForeColor = System.Drawing.SystemColors.Control;
            this.label26.Location = new System.Drawing.Point(35, 212);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(264, 18);
            this.label26.TabIndex = 46;
            this.label26.Text = "________________________________";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(66)))), ((int)(((byte)(131)))));
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.ForeColor = System.Drawing.Color.Gainsboro;
            this.textBox5.Location = new System.Drawing.Point(37, 295);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(254, 17);
            this.textBox5.TabIndex = 47;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Enabled = false;
            this.label27.ForeColor = System.Drawing.SystemColors.Control;
            this.label27.Location = new System.Drawing.Point(32, 300);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(264, 18);
            this.label27.TabIndex = 48;
            this.label27.Text = "________________________________";
            // 
            // furnitureTextBox
            // 
            this.furnitureTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(66)))), ((int)(((byte)(131)))));
            this.furnitureTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.furnitureTextBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.furnitureTextBox.Location = new System.Drawing.Point(36, 380);
            this.furnitureTextBox.Name = "furnitureTextBox";
            this.furnitureTextBox.Size = new System.Drawing.Size(254, 17);
            this.furnitureTextBox.TabIndex = 49;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Enabled = false;
            this.label28.ForeColor = System.Drawing.SystemColors.Control;
            this.label28.Location = new System.Drawing.Point(31, 385);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(264, 18);
            this.label28.TabIndex = 50;
            this.label28.Text = "________________________________";
            // 
            // weightTextBox
            // 
            this.weightTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(66)))), ((int)(((byte)(131)))));
            this.weightTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.weightTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.weightTextBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.weightTextBox.Location = new System.Drawing.Point(312, 89);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(169, 19);
            this.weightTextBox.TabIndex = 51;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Enabled = false;
            this.label29.ForeColor = System.Drawing.SystemColors.Control;
            this.label29.Location = new System.Drawing.Point(309, 93);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(176, 18);
            this.label29.TabIndex = 52;
            this.label29.Text = "_____________________";
            // 
            // etajTextBox
            // 
            this.etajTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(66)))), ((int)(((byte)(131)))));
            this.etajTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.etajTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.etajTextBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.etajTextBox.Location = new System.Drawing.Point(312, 175);
            this.etajTextBox.Name = "etajTextBox";
            this.etajTextBox.Size = new System.Drawing.Size(169, 19);
            this.etajTextBox.TabIndex = 53;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Enabled = false;
            this.label30.ForeColor = System.Drawing.SystemColors.Control;
            this.label30.Location = new System.Drawing.Point(309, 177);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(176, 18);
            this.label30.TabIndex = 54;
            this.label30.Text = "_____________________";
            // 
            // matrasComboBox
            // 
            this.matrasComboBox.BackColor = System.Drawing.Color.Transparent;
            this.matrasComboBox.BorderRadius = 3;
            this.matrasComboBox.ForeColor = System.Drawing.Color.White;
            this.matrasComboBox.Items = new string[] {
        "1",
        "2",
        "3",
        "4",
        "5"};
            this.matrasComboBox.Location = new System.Drawing.Point(318, 265);
            this.matrasComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.matrasComboBox.Name = "matrasComboBox";
            this.matrasComboBox.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(76)))), ((int)(((byte)(161)))));
            this.matrasComboBox.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(76)))), ((int)(((byte)(161)))));
            this.matrasComboBox.selectedIndex = -1;
            this.matrasComboBox.Size = new System.Drawing.Size(170, 30);
            this.matrasComboBox.TabIndex = 55;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(76)))), ((int)(((byte)(161)))));
            this.dateTimePicker1.BorderRadius = 0;
            this.dateTimePicker1.ForeColor = System.Drawing.Color.White;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateTimePicker1.FormatCustom = null;
            this.dateTimePicker1.Location = new System.Drawing.Point(318, 335);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(170, 31);
            this.dateTimePicker1.TabIndex = 56;
            this.dateTimePicker1.Value = new System.DateTime(2019, 11, 8, 13, 30, 32, 273);
            // 
            // Sborka2RadioButton
            // 
            this.Sborka2RadioButton.AutoSize = true;
            this.Sborka2RadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sborka2RadioButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.Sborka2RadioButton.Location = new System.Drawing.Point(13, 419);
            this.Sborka2RadioButton.Name = "Sborka2RadioButton";
            this.Sborka2RadioButton.Size = new System.Drawing.Size(121, 24);
            this.Sborka2RadioButton.TabIndex = 28;
            this.Sborka2RadioButton.Text = "(700 рублей)";
            this.Sborka2RadioButton.UseVisualStyleBackColor = true;
            this.Sborka2RadioButton.CheckedChanged += new System.EventHandler(this.Sborka2RadioButton_CheckedChanged);
            // 
            // Sborka1RadioButton
            // 
            this.Sborka1RadioButton.AutoSize = true;
            this.Sborka1RadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sborka1RadioButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.Sborka1RadioButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Sborka1RadioButton.Location = new System.Drawing.Point(14, 388);
            this.Sborka1RadioButton.Name = "Sborka1RadioButton";
            this.Sborka1RadioButton.Size = new System.Drawing.Size(121, 24);
            this.Sborka1RadioButton.TabIndex = 13;
            this.Sborka1RadioButton.Text = "(700 рублей)";
            this.Sborka1RadioButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.Sborka1RadioButton.UseVisualStyleBackColor = true;
            this.Sborka1RadioButton.CheckedChanged += new System.EventHandler(this.Sborka1RadioButton_CheckedChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(143, 391);
            this.label17.Margin = new System.Windows.Forms.Padding(3);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(68, 20);
            this.label17.TabIndex = 32;
            this.label17.Text = "Сборка ";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label17.Click += new System.EventHandler(this.Label17_Click_1);
            // 
            // bezSborkiRadioButton
            // 
            this.bezSborkiRadioButton.AutoSize = true;
            this.bezSborkiRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.bezSborkiRadioButton.Checked = true;
            this.bezSborkiRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bezSborkiRadioButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.bezSborkiRadioButton.Location = new System.Drawing.Point(16, 357);
            this.bezSborkiRadioButton.Name = "bezSborkiRadioButton";
            this.bezSborkiRadioButton.Size = new System.Drawing.Size(103, 24);
            this.bezSborkiRadioButton.TabIndex = 12;
            this.bezSborkiRadioButton.TabStop = true;
            this.bezSborkiRadioButton.Text = "(0 рублей)";
            this.bezSborkiRadioButton.UseVisualStyleBackColor = false;
            this.bezSborkiRadioButton.CheckedChanged += new System.EventHandler(this.BezSborkiRadioButton_CheckedChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label19.Location = new System.Drawing.Point(143, 423);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(243, 20);
            this.label19.TabIndex = 34;
            this.label19.Text = "Сборка с креплением к стенам";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label19.Click += new System.EventHandler(this.Label19_Click);
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label31.ForeColor = System.Drawing.Color.Silver;
            this.label31.Location = new System.Drawing.Point(219, 290);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(88, 24);
            this.label31.TabIndex = 41;
            this.label31.Text = "СБОРКА";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label32.ForeColor = System.Drawing.Color.Silver;
            this.label32.Location = new System.Drawing.Point(213, -1);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(95, 24);
            this.label32.TabIndex = 42;
            this.label32.Text = "ПОДЪЕМ";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label33.ForeColor = System.Drawing.Color.Silver;
            this.label33.Location = new System.Drawing.Point(204, 1);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(114, 24);
            this.label33.TabIndex = 43;
            this.label33.Text = "ДОСТАВКА";
            // 
            // nextButton
            // 
            this.nextButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(173)))));
            this.nextButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(173)))));
            this.nextButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.nextButton.BorderRadius = 0;
            this.nextButton.ButtonText = "Далее";
            this.nextButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nextButton.DisabledColor = System.Drawing.Color.Gray;
            this.nextButton.Iconcolor = System.Drawing.Color.Transparent;
            this.nextButton.Iconimage = null;
            this.nextButton.Iconimage_right = null;
            this.nextButton.Iconimage_right_Selected = null;
            this.nextButton.Iconimage_Selected = null;
            this.nextButton.IconMarginLeft = 0;
            this.nextButton.IconMarginRight = 0;
            this.nextButton.IconRightVisible = true;
            this.nextButton.IconRightZoom = 0D;
            this.nextButton.IconVisible = true;
            this.nextButton.IconZoom = 90D;
            this.nextButton.IsTab = false;
            this.nextButton.Location = new System.Drawing.Point(401, 3);
            this.nextButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nextButton.Name = "nextButton";
            this.nextButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(173)))));
            this.nextButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(150)))), ((int)(((byte)(163)))));
            this.nextButton.OnHoverTextColor = System.Drawing.Color.White;
            this.nextButton.selected = false;
            this.nextButton.Size = new System.Drawing.Size(124, 34);
            this.nextButton.TabIndex = 42;
            this.nextButton.Text = "Далее";
            this.nextButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nextButton.Textcolor = System.Drawing.Color.White;
            this.nextButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // prevButton
            // 
            this.prevButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(173)))));
            this.prevButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(173)))));
            this.prevButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.prevButton.BorderRadius = 0;
            this.prevButton.ButtonText = "Назад";
            this.prevButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.prevButton.DisabledColor = System.Drawing.Color.Gray;
            this.prevButton.Iconcolor = System.Drawing.Color.Transparent;
            this.prevButton.Iconimage = null;
            this.prevButton.Iconimage_right = null;
            this.prevButton.Iconimage_right_Selected = null;
            this.prevButton.Iconimage_Selected = null;
            this.prevButton.IconMarginLeft = 0;
            this.prevButton.IconMarginRight = 0;
            this.prevButton.IconRightVisible = true;
            this.prevButton.IconRightZoom = 0D;
            this.prevButton.IconVisible = true;
            this.prevButton.IconZoom = 90D;
            this.prevButton.IsTab = false;
            this.prevButton.Location = new System.Drawing.Point(268, 4);
            this.prevButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.prevButton.Name = "prevButton";
            this.prevButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(173)))));
            this.prevButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(150)))), ((int)(((byte)(163)))));
            this.prevButton.OnHoverTextColor = System.Drawing.Color.White;
            this.prevButton.selected = false;
            this.prevButton.Size = new System.Drawing.Size(122, 32);
            this.prevButton.TabIndex = 43;
            this.prevButton.Text = "Назад";
            this.prevButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.prevButton.Textcolor = System.Drawing.Color.White;
            this.prevButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prevButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(48)))), ((int)(((byte)(95)))));
            this.ClientSize = new System.Drawing.Size(535, 521);
            this.Controls.Add(this.panel4);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox podyomTextBox;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox complectTextBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton bezPodyomaRadioButton;
        private System.Windows.Forms.RadioButton sLiftomRadioButton;
        private System.Windows.Forms.RadioButton bezLiftaRadioButton;
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
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.MaskedTextBox rasstTextBox;
        private System.Windows.Forms.Label label20;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.MaskedTextBox kreplenieBox;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.MaskedTextBox textBox3;
        private System.Windows.Forms.MaskedTextBox furnitureTextBox;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.MaskedTextBox textBox5;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.MaskedTextBox textBox6;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.MaskedTextBox textBox4;
        private System.Windows.Forms.Label label25;
        private ns1.BunifuDatepicker dateTimePicker1;
        private ns1.BunifuDropdown matrasComboBox;
        private System.Windows.Forms.MaskedTextBox etajTextBox;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.MaskedTextBox weightTextBox;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.RadioButton Sborka2RadioButton;
        private System.Windows.Forms.RadioButton Sborka1RadioButton;
        private System.Windows.Forms.RadioButton bezSborkiRadioButton;
        private System.Windows.Forms.Label label17;
        private ns1.BunifuFlatButton nextButton;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label32;
        private ns1.BunifuFlatButton prevButton;
    }
}

