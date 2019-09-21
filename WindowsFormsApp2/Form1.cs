using System;
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
                int pricePadik = (int)(priceShippingPerKg * (weightMatras + weightFurniture) / 10 + 0.99999) * 10;
                if (pricePadik < 400)
                {
                    pricePadik = 400;
                }

                int priceEdinolichnik = (int)(priceShippingPerKg * (weightMatras + weightFurniture) / 10 + 0.99999) * 10;
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
            shippingTextBox.Text = individDostRadioButton.Text.Replace("(", "").Replace(" рублей)", "").ToString();
            CalculateCost();
        }

        /// <summary>
        /// Выбрана совместная доставка
        /// </summary>
        private void sovmDostavkaClick(object sender, EventArgs e)
        {
            shippingTextBox.Text = sovmDostRadioButton.Text.Replace("(", "").Replace(" рублей)", "").ToString();
            CalculateCost();
        }

        /// <summary>
        /// Межгород
        /// </summary>
        private void mezhgorodDostavkaClick(object sender, EventArgs e)
        {           
            shippingTextBox.Text = mezhgorodRadioButton.Text.Replace("(", "").Replace(" рублей)", "").ToString();
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
            complectTextBox.Text = furnitureTextBox.Text;
        }

        private void RasstTextBox_TextChanged(object sender, EventArgs e)
        {
            CalculatePodiomCost();
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
    }
}
