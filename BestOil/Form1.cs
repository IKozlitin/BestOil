using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BestOil
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //************************КАФЕ*************************

        //Выбор Хот-дога
        private void checkHotdog_CheckedChanged(object sender, EventArgs e)
        {
            if (checkHotdog.Checked)
            {
                countHotdog.Enabled = true;
            }
            else
            {
                countHotdog.Enabled = false;
                countHotdog.Text = "0";
            }
        }
        //Выбор Бургера
        private void checkHamburger_CheckedChanged(object sender, EventArgs e)
        {
            if (checkHamburger.Checked)
            {
                countHamburger.Enabled = true;
            }
            else
            {
                countHamburger.Enabled = false;
                countHamburger.Text = "0";
            }
        }
        //Выбор Фри
        private void checkFries_CheckedChanged(object sender, EventArgs e)
        {
            if (checkFries.Checked)
            {
                countFries.Enabled = true;
            }
            else
            {
                countFries.Enabled = false;
                countFries.Text = "0";
            }
        }
        //Выбор Колы
        private void checkCola_CheckedChanged(object sender, EventArgs e)
        {
            if (checkCola.Checked)
            {
                countCola.Enabled = true;
            }
            else
            {
                countCola.Enabled = false;
                countCola.Text = "0";
            }
        }
        //Сумма Хот-дога
        public int hotdogSum()
        {
            if (checkHotdog.Checked)
            {
                countHotdog.Enabled = true;
            }
            else
            {
                countHotdog.Enabled = false;
                countHotdog.Text = "0";
            }

            int sumHotdog = Convert.ToInt32(countHotdog.Text) * Convert.ToInt32(priceHotdog.Text);
            return sumHotdog;

        }
        //Сумма Гамбургера
        public int hamburgerSum()
        {
            if (checkHamburger.Checked)
            {
                countHamburger.Enabled = true;
            }
            else
            {
                countHamburger.Enabled = false;
                countHamburger.Text = "0";
            }
            int sumHamburger = Convert.ToInt32(countHamburger.Text) * Convert.ToInt32(priceHamburger.Text);
            return sumHamburger;

        }
        //Сумма Фри
        public int friesSum()
        {
            if (checkFries.Checked)
            {
                countFries.Enabled = true;
            }
            else
            {
                countFries.Enabled = false;
                countFries.Text = "0";
            }
            int sumFries = Convert.ToInt32(countFries.Text) * Convert.ToInt32(priceFries.Text);
            return sumFries;

        }
        //Сумма Колы
        public int colaSum()
        {
            if (checkCola.Checked)
            {
                countCola.Enabled = true;
            }
            else
            {
                countCola.Enabled = false;
                countCola.Text = "0";
            }
            int sumCola = Convert.ToInt32(countCola.Text) * Convert.ToInt32(priceCola.Text);
            return sumCola;
        }
        //Сумма Кафе
        public int SumAllCafe()
        {
            int genSum = hotdogSum() + hamburgerSum() + friesSum() + colaSum();
            return genSum;
        }
        private void sumCafe_Click(object sender, EventArgs e)
        {
            sumCafe.Text = Convert.ToString(SumAllCafe());
        }

        //**********************Автозаправка*********************

        //Выбор топлива
        private void gasName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (gasName.SelectedIndex == 0)
            {
                priceGas.Text = "48";
            }
            else if (gasName.SelectedIndex == 1)
            {
                priceGas.Text = "52";
            }
            else if (gasName.SelectedIndex == 2)
            {
                priceGas.Text = "62";
            }
            else if (gasName.SelectedIndex == 3)
            {
                priceGas.Text = "59";
            }
        }

        //Выбор количества литров        
        private void radioLitres_CheckedChanged(object sender, EventArgs e)
        {
            if (radioLitres.Checked)
            {
                countLitres.Enabled = true;
                countRubles.Enabled = false;
                Gas.Text = "К оплате:";
                gasLitRub.Text = "руб";
            }
            else
            {
                countLitres.Enabled = false;
                countLitres.Text = "";
            }

        }

        //Выбор суммы в рублях
        private void radioRubles_CheckedChanged(object sender, EventArgs e)
        {
            if (radioRubles.Checked)
            {
                countRubles.Enabled = true;
                countLitres.Enabled = false;
                Gas.Text = "Количество литров:";
                gasLitRub.Text = "л";
            }
            else
            {
                countRubles.Enabled = false;
                countRubles.Text = "";
            }
        }

        //Заправить кол-во литров 92
        public int litresGas92()
        {
            int countL_92 = Convert.ToInt32(countLitres.Text) * Convert.ToInt32(priceGas.Text);
            return countL_92;
        }
        //Заправить на сумму 92
        public int rublesGas92()
        {
            int countR_92 = Convert.ToInt32(countRubles.Text) / Convert.ToInt32(priceGas.Text);
            return countR_92;
        }
         //Заправить кол-во литров 95
        public int litresGas95()
        {
            int countL_95 = Convert.ToInt32(countLitres.Text) * Convert.ToInt32(priceGas.Text);
            return countL_95;
        }
        //Заправить на сумму 95
        public int rublesGas95()
        {
            int countR_95 = Convert.ToInt32(countRubles.Text) / Convert.ToInt32(priceGas.Text);
            return countR_95;
        }
         //Заправить кол-во литров 98
        public int litresGas98()
        {
            int countL_98 = Convert.ToInt32(countLitres.Text) * Convert.ToInt32(priceGas.Text);
            return countL_98;
        }
        //Заправить на сумму 98
        public int rublesGas98()
        {
            int countR_98 = Convert.ToInt32(countRubles.Text) / Convert.ToInt32(priceGas.Text);
            return countR_98;
        }
         //Заправить кол-во литров ДТ
        public int litresGasDT()
        {
            int countL_DT = Convert.ToInt32(countLitres.Text) * Convert.ToInt32(priceGas.Text);
            return countL_DT;
        }
        //Заправить на сумму ДТ
        public int rublesGasDT()
        {
            int countR_DT = Convert.ToInt32(countRubles.Text) / Convert.ToInt32(priceGas.Text);
            return countR_DT;
        }
        //Сумма за литры
        public int litresSumGas()
        {
            if (gasName.SelectedIndex == 0)
            {
                return litresGas92();
            }
            else if (gasName.SelectedIndex == 1)
            {
                return litresGas95();
            }
            else if (gasName.SelectedIndex == 2)
            {
                return litresGas98();
            }
            else if (gasName.SelectedIndex == 3)
            {
                return litresGasDT();
            }
            return 1;
        }
        //Сумма за рубли
        public int rublesSumGas()
        {
            if (gasName.SelectedIndex == 0)
            {
                return rublesGas92();
            }
            else if (gasName.SelectedIndex == 1)
            {
                return rublesGas95();
            }
            else if (gasName.SelectedIndex == 2)
            {
                return rublesGas98();
            }
            else if (gasName.SelectedIndex == 3)
            {
                return rublesGasDT();
            }
            return 1;
        }

        private void sumGas_Click(object sender, EventArgs e)
        {
            if (radioLitres.Checked)
            {
                sumGas.Text = litresSumGas().ToString();
            }
            else if (radioRubles.Checked)
            {
                sumGas.Text = rublesSumGas().ToString();
            }
        }
        
        private int countRub()
        {
            int countR = Convert.ToInt32(countRubles.Text);
            return countR;
        }
        
        //*************************Общая сумма************************

        private void buttonSumAll_Click(object sender, EventArgs e)
        {
            if (radioLitres.Checked)
            {
                sumAll.Text = (litresSumGas()+SumAllCafe()).ToString();
            }
            else if (radioRubles.Checked)
            {
                sumAll.Text = (countRub()+SumAllCafe()).ToString();
            }
        }
        
    }
}
