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
        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            shippingTextBox.Text = "0";
            CalculateCost();
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            int weightMatras = 40 * Convert.ToInt32(matrasTextBox.Text);
            int weightFurniture = Convert.ToInt32(weightTextBox.Text);
            int priceShippingPerKg = 2;
            int price = priceShippingPerKg * (weightMatras + weightFurniture);
            if (price < 3000)
            {
                price = 3000;
            }

            shippingTextBox.Text = price.ToString();
            CalculateCost();
        }
        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            int weightMatras = 40 * Convert.ToInt32(matrasTextBox.Text);
            int weightFurniture = Convert.ToInt32(weightTextBox.Text);
            int priceShippingPerKg = 2;
            int pricePadik = priceShippingPerKg * (weightMatras + weightFurniture);
            if (pricePadik < 400)
            {
                pricePadik = 400;
            }

            shippingTextBox.Text = pricePadik.ToString();
            CalculateCost();
        }

        private void RadioButton4_CheckedChanged(object sender, EventArgs e)
        {
           
            shippingTextBox.Text = "666";
            CalculateCost();
        }


        #endregion

        private void FurnitureTextBox_TextChanged(object sender, EventArgs e)
        {
            CalculateCost();
        }

        /// <summary>
        /// Считаем стоимость
        /// </summary>
        void CalculateCost()
        {
            totalTextBox.Text = "Итого: " + (
                Convert.ToInt32(furnitureTextBox.Text) +
                Convert.ToInt32(shippingTextBox.Text) +
                Convert.ToInt32(podyomTextBox.Text) +
                Convert.ToInt32(complectTextBox.Text)).ToString();
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

    }
}
