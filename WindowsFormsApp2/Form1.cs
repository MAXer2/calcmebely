﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                int weightMatras = (int)(40 * Convert.ToDouble(matrasTextBox.Text));
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
            CalculatePodiomCost();
            CalculateShippingCost();
            CalculateCost();
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
        private void RadioButton6_CheckedChanged(object sender, EventArgs e)
        {
            podyomTextBox.Text = "0";
            CalculateCost();
        }
        private void RadioButton7_CheckedChanged(object sender, EventArgs e)
        {
            podyomTextBox.Text = "500";
            CalculateCost();
        }
        private void RadioButton8_CheckedChanged(object sender, EventArgs e)
        {
            podyomTextBox.Text = "1500";
            CalculateCost();
        }
        #endregion

        #region Сборка
        private void RadioButton5_CheckedChanged(object sender, EventArgs e)
        {
            complectTextBox.Text = "0";
            CalculateCost();
        }
        private void RadioButton10_CheckedChanged(object sender, EventArgs e)
        {
            complectTextBox.Text = "100";
            CalculateCost();
        }

        private void RadioButton9_CheckedChanged(object sender, EventArgs e)
        {
            complectTextBox.Text = "300";
            CalculateCost();
        }
        #endregion

        /// <summary>
        /// Стоимость подъема
        /// </summary>
        void CalculatePodiomCost()
        {
            try
            {
                int etaj = Convert.ToInt32(etajTextBox.Text);

                int weightMatras = (int)(40 * Convert.ToDouble(matrasTextBox.Text));
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
        /// <summary>
        /// Стоимость сборки
        /// </summary>
        void CalculateComplectCost()
        {
            try
            {
                int etaj = Convert.ToInt32(etajTextBox.Text);
                int rasst = Convert.ToInt32(rasstTextBox.Text);
                int weightMatras = (int)(40 * Convert.ToDouble(matrasTextBox.Text));
                double weightFurniture = Convert.ToDouble(weightTextBox.Text);
                int pricePodyomPerKg = 1;
                int price6Pr = Round10(Convert.ToInt32(furnitureTextBox.Text) * 0.06);
                int priceSborkaCena = Round10(Convert.ToInt32(furnitureTextBox.Text) * 0.07);
                int priceSborkaVes10 = Round10(Convert.ToInt32(weightTextBox.Text) * 15);

                int priceSborkaVes = (priceSborkaCena > priceSborkaVes10) ? priceSborkaVes10 : priceSborkaCena;
                int priceSborkaUlyanovsk = (priceSborkaVes > price6Pr) ? priceSborkaVes : price6Pr;

                int priceSborkaNeUlyanovsk = Round10(Convert.ToInt32(priceSborkaUlyanovsk) + 22 * rasst);
          
               


             

                //bezLiftaRadioButton.Text = "(" + pricePod.ToString() + " рублей)";
                //sLiftomRadioButton.Text = "(" + priceLift.ToString() + " рублей)";
            }
            catch (Exception) { }

            CalculateCost();

        }

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
    }
}
