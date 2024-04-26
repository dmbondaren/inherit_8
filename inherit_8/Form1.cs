using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inherit_8
{
    public partial class Form1 : Form
    {
        // Коллекция для хранения продуктов
        private List<Product> products = new List<Product>();

        public Form1()
        {
            InitializeComponent();
            InitializeProducts(); // Инициализация продуктов
        }

        private void InitializeProducts()
        {
            // Добавление примеров продуктов
            products.Add(new Vegetable("Морковь", 500, 150));
            products.Add(new Fruit("Яблоко", 300, 200));
            products.Add(new Dessert("Шоколадный торт", 500, 70));

            // Заполнение ListBox названиями продуктов
            foreach (Product product in products)
            {
                listBox1.Items.Add(product.Name);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Проверка выбранного продукта
            if (listBox1.SelectedIndex >= 0 && listBox1.SelectedIndex < products.Count)
            {
                Product selectedProduct = products[listBox1.SelectedIndex];
                string result = selectedProduct.Cook();
                label1.Text = $"Результат приготовления: {result}";
            }
            else
            {
                MessageBox.Show("Выберите продукт для приготовления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Этот метод можно оставить пустым или добавить нужную логику
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Этот метод можно оставить пустым или добавить нужную логику
        }
    }
}
