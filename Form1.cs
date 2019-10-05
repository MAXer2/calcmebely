﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using System.Reflection;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            matrasComboBox.SelectedIndex = 0;
            kreplenieComboBox.SelectedIndex = 0;
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }
        #region Функции, упрощающие запись
        /// <summary>
        /// Округление с точностью до 10 рублей
        /// </summary>
        int Round10(double price)
        {
            return (int)(price / 10 + 0.99999) * 10;
        }

        /// <summary>
        /// Убираем слово "рублей" из цены
        /// </summary>
        string ReplaceRubles(String price)
        {
            return price.Replace("(", "").Replace(" рублей)", "");
        }
        #endregion



        #region Доставка

        /// <summary>
        /// Считаем стоимость доставки
        /// </summary>
        void CalculateShippingCost()
        {
            try
            {
                int weightMatras = (int)(40 * Convert.ToDouble(matrasComboBox.Text));
                double weightFurniture = Convert.ToDouble(weightTextBox.Text);
                int priceShippingPerKg = 2;
                int pricePadik = Round10(priceShippingPerKg * (weightMatras + weightFurniture));
                if (pricePadik < 400)
                {
                    pricePadik = 400;
                }

                int priceEdinolichnik = Round10(priceShippingPerKg * (weightMatras + weightFurniture));
                if (priceEdinolichnik < 3000)
                {
                    priceEdinolichnik = 3000;
                }

                int rasst = Convert.ToInt32(rasstTextBox.Text);

                sovmDostRadioButton.Text = "(" + pricePadik.ToString() + " рублей)";
                individDostRadioButton.Text = "(" + priceEdinolichnik.ToString() + " рублей)";
                mezhgorodRadioButton.Text = "(" + (pricePadik + 30 * rasst).ToString() + " рублей)";
            }
            catch (Exception) { }

            CalculateCost();
        }

        /// <summary>
        /// Самовывоз
        /// </summary>
        private void samovyvozDostavkaClick(object sender, EventArgs e)
        {
            shippingTextBox.Text = "0";
            CalculateCost();
        }

        /// <summary>
        /// Индивидуальная доставка
        /// </summary>
        private void individDostavkaClick(object sender, EventArgs e)
        {
            shippingTextBox.Text = ReplaceRubles(individDostRadioButton.Text);
            CalculateCost();
        }

        /// <summary>
        /// Выбрана совместная доставка
        /// </summary>
        private void sovmDostavkaClick(object sender, EventArgs e)
        {
            shippingTextBox.Text = ReplaceRubles(sovmDostRadioButton.Text);
            CalculateCost();
        }

        /// <summary>
        /// Межгород
        /// </summary>
        private void mezhgorodDostavkaClick(object sender, EventArgs e)
        {
            shippingTextBox.Text = ReplaceRubles(mezhgorodRadioButton.Text);
            CalculateCost();
        }


        #endregion

        private void FurnitureTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                TextBox tb = (TextBox)sender;
                tb.Text = (Convert.ToInt32(tb.Text)).ToString();
            }
            catch (Exception) { }

            CalculateComplectCost();
            CalculatePodiomCost();
            CalculateShippingCost();
        }

        /// <summary>
        /// Считаем итоговую стоимость
        /// </summary>
        void CalculateCost()
        {
            try
            {
                totalTextBox.Text = "Итого: " + (
                    Convert.ToInt32(furnitureTextBox.Text) +
                    Convert.ToInt32(shippingTextBox.Text) +
                    Convert.ToInt32(podyomTextBox.Text) +
                    Convert.ToInt32(complectTextBox.Text)).ToString();
            }
            catch (Exception) { }
        }

        #region Подъем
        private void bezPodyomaRadioButton_Click(object sender, EventArgs e)
        {
            podyomTextBox.Text = "0";
            CalculateCost();
        }
        private void BezLiftaRadiobutton_Click(object sender, EventArgs e)
        {
            podyomTextBox.Text = ReplaceRubles(bezLiftaRadioButton.Text);
            CalculateCost();
        }

        private void sLiftomRadioButton_Click(object sender, EventArgs e)
        {
            podyomTextBox.Text = ReplaceRubles(sLiftomRadioButton.Text);
            CalculateCost();
        }

        /// <summary>
        /// Стоимость подъема
        /// </summary>
        void CalculatePodiomCost()
        {
            try
            {
                int etaj = Convert.ToInt32(etajTextBox.Text);

                int weightMatras = (int)(40 * Convert.ToDouble(matrasComboBox.Text));
                double weightFurniture = Convert.ToDouble(weightTextBox.Text);
                int pricePodyomPerKg = 1;
                int pricePod = Round10(pricePodyomPerKg * etaj * (2 * weightMatras + weightFurniture));
                if (pricePod < 300)
                {
                    pricePod = 300;
                }

                int priceLift = Round10(3 * pricePodyomPerKg * (2 * weightMatras + weightFurniture));
                if (priceLift < 300)
                {
                    priceLift = 300;
                }

                int rasst = Convert.ToInt32(rasstTextBox.Text);

                bezLiftaRadioButton.Text = "(" + pricePod.ToString() + " рублей)";
                sLiftomRadioButton.Text = "(" + priceLift.ToString() + " рублей)";
            }
            catch (Exception) { }

            CalculateCost();

        }
        #endregion

        #region Сборка

        private void bezSborkiRadioButtonClick(object sender, EventArgs e)
        {
            complectTextBox.Text = "0";
            CalculateCost();
        }
        private void Sborka2RadioButtonClick(object sender, EventArgs e)
        {
            complectTextBox.Text = ReplaceRubles(Sborka1RadioButton.Text);
            CalculateCost();
        }
        private void Sborka1RadioButtonClick(object sender, EventArgs e)
        {
            complectTextBox.Text = ReplaceRubles(Sborka2RadioButton.Text);
            CalculateCost();
        }

        /// <summary>
        /// Стоимость сборки
        /// </summary>
        void CalculateComplectCost()
        {
            try
            {
                int etaj = Convert.ToInt32(etajTextBox.Text);
                int rasst = Convert.ToInt32(rasstTextBox.Text);
                int kreplenie = Convert.ToInt32(kreplenieComboBox.Text);
                int weightMatras = (int)(40 * Convert.ToDouble(matrasComboBox.Text));
                double weightFurniture = Convert.ToDouble(weightTextBox.Text);
                int pricePodyomPerKg = 1;
                int price6Pr = Round10(Convert.ToInt32(furnitureTextBox.Text) * 0.06);
                int priceSborkaCena = Round10(Convert.ToInt32(furnitureTextBox.Text) * 0.10);
                int priceSborkaVes10 = Round10(Convert.ToInt32(weightTextBox.Text) * 15);

                int priceSborkaVes = (priceSborkaCena > priceSborkaVes10) ? priceSborkaVes10 : priceSborkaCena;
                int priceSborkaUlyanovsk = (priceSborkaVes > price6Pr) ? priceSborkaVes : price6Pr;

                int priceSborkaNeUlyanovsk = Round10(Convert.ToInt32(priceSborkaUlyanovsk) + 22 * rasst);

                if (mezhgorodRadioButton.Checked)
                {
                    Sborka1RadioButton.Text = "(" + priceSborkaNeUlyanovsk.ToString() + " рублей)";
                    Sborka2RadioButton.Text = "(" + (priceSborkaNeUlyanovsk + 250 * kreplenie).ToString() + " рублей)";
                }
                else
                {
                    Sborka1RadioButton.Text = "(" + priceSborkaUlyanovsk.ToString() + " рублей)";
                    Sborka2RadioButton.Text = "(" + (priceSborkaUlyanovsk + 250 * kreplenie).ToString() + " рублей)";
                }
            }
            catch (Exception) { }

            CalculateCost();
        }
        #endregion

        private void RasstTextBox_TextChanged(object sender, EventArgs e)
        {
            CalculatePodiomCost();
            CalculateComplectCost();
            CalculateShippingCost();
        }

        private void MatrasTextBox_TextChanged(object sender, EventArgs e)
        {
            CalculatePodiomCost();
            CalculateShippingCost();
        }

        private void WeightTextBox_TextChanged(object sender, EventArgs e)
        {
            CalculatePodiomCost();
            CalculateShippingCost();
        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox9_TextChanged(object sender, EventArgs e)
        {
            CalculatePodiomCost();

        }

        private void BunifuDatepicker1_onValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged_1(object sender, EventArgs e)
        {
            CalculatePodiomCost();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Label18_Click(object sender, EventArgs e)
        {

        }

        private void PodyomTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void BunifuFlatButton1_Click(object sender, EventArgs e)
        {
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            CalculatePodiomCost();
            CalculateComplectCost();
            CalculateShippingCost();

            tabControl1.SelectedIndex = tabControl1.SelectedIndex + 1;
            nextButton.Visible = true;
            prevButton.Visible = true;
            if (tabControl1.SelectedIndex == 3)
            {
                nextButton.Visible = false;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CalculatePodiomCost();
            CalculateComplectCost();
            CalculateShippingCost();

            tabControl1.SelectedIndex = tabControl1.SelectedIndex - 1;
            nextButton.Visible = true;
            prevButton.Visible = true;
            if (tabControl1.SelectedIndex == 0)
            {
                prevButton.Visible = false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            #region Тут создается документ, это магия, в нее лезть не надо
            object oMissing = System.Reflection.Missing.Value;
            object oEndOfDoc = "\\endofdoc"; /* \endofdoc is a predefined bookmark */

            //Start Word and create a new document.
            Word._Application oWord;
            Word._Document oDoc;
            oWord = new Word.Application();
            oWord.Visible = true;
            oDoc = oWord.Documents.Add(ref oMissing, ref oMissing,
            ref oMissing, ref oMissing);
            oDoc.PageSetup.LeftMargin = 15;
            oDoc.PageSetup.RightMargin = 15;
            #endregion

            //Вставляем абзац
            Word.Paragraph oPara2;
            object oRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
            oPara2 = oDoc.Content.Paragraphs.Add(ref oRng);
            oPara2.Range.Text = "Договор оказания дополнительных услуг №1";
            oPara2.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            oPara2.Range.Font.Bold = 2;
            oPara2.Range.Font.Size = 16;
            oPara2.Range.InsertParagraphAfter();

            //Insert another paragraph.
            Word.Paragraph oPara3;
            oRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
            oPara3 = oDoc.Content.Paragraphs.Add(ref oRng);
            oPara3.Range.Text = "г.Ульяновск                                      20 февраля 2019 г.";
            oPara3.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
            oPara3.Range.Font.Bold = 0;
            //oPara2.Range. = 16;
            oPara3.Range.InsertParagraphAfter();


            Word.Paragraph oPara5;
            oRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
            oPara5 = oDoc.Content.Paragraphs.Add(ref oRng);
            oPara5.Range.Text = "Фамилия Имя Очество";
            oPara5.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
            oPara5.Range.Font.Bold = 1;
            oPara5.Range.InsertParagraphAfter();


            //Insert a 3 x 5 table, fill it with data, and make the first row
            //bold and italic.
            Word.Table oTable;
            Word.Range wrdRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
            oTable = oDoc.Tables.Add(wrdRng, 3, 5, ref oMissing, ref oMissing);
            oTable.Range.ParagraphFormat.SpaceAfter = 6;
            int r, c;
            string strText;
            for (r = 1; r <= 3; r++)
                for (c = 1; c <= 5; c++)
                {
                    strText = "r" + r + "c" + c;
                    oTable.Cell(r, c).Range.Text = strText;
                }
            oTable.Rows[1].Range.Font.Bold = 1;
            oTable.Rows[1].Range.Font.Italic = 1;

            //Add some text after the table.
            Word.Paragraph oPara100;
            oRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
            oPara100 = oDoc.Content.Paragraphs.Add(ref oRng);
            oPara100.Range.InsertParagraphBefore();
            oPara100.Range.Text = "And here's another table:";
            oPara100.Format.SpaceAfter = 24;
            oPara100.Range.InsertParagraphAfter();

            //Insert a 5 x 2 table, fill it with data, and change the column widths.
            wrdRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
            oTable = oDoc.Tables.Add(wrdRng, 5, 2, ref oMissing, ref oMissing);
            oTable.Range.ParagraphFormat.SpaceAfter = 6;
            for (r = 1; r <= 5; r++)
                for (c = 1; c <= 2; c++)
                {
                    strText = "r" + r + "c" + c;
                    oTable.Cell(r, c).Range.Text = strText;
                }
            oTable.Columns[1].Width = oWord.InchesToPoints(2); //Change width of columns 1 & 2
            oTable.Columns[2].Width = oWord.InchesToPoints(3);
            
            //Add text after the chart.
            wrdRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
            wrdRng.InsertParagraphAfter();
            wrdRng.InsertAfter("THE END.");
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuThinButton21_Click_1(object sender, EventArgs e)
        {
            
        }

        private void totalTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            CalculatePodiomCost();
            CalculateComplectCost();
            CalculateShippingCost();

            tabControl1.SelectedIndex = tabControl1.SelectedIndex + 1;
            nextButton.Visible = true;
            prevButton.Visible = true;
            if (tabControl1.SelectedIndex == 3)
            {
                nextButton.Visible = false;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            CalculatePodiomCost();
            CalculateComplectCost();
            CalculateShippingCost();

            tabControl1.SelectedIndex = tabControl1.SelectedIndex - 1;
            nextButton.Visible = true;
            prevButton.Visible = true;
            if (tabControl1.SelectedIndex == 0)
            {
                prevButton.Visible = false;
            }
        }
        }
    }

