using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PhotoPrintCalculator
{
    public partial class Form1 : Form
    {
        // Константа знижки, застосовується якщо кількість фотографій > 20
        private const double discount = 0.1;

        // Словник для зберігання відповідності RadioButton -> (розмір, ціна)
        private readonly Dictionary<RadioButton, (string size, double price)> photoOptions;

        public Form1()
        {
            InitializeComponent();
            // Ініціалізація словника розмірів та цін
            photoOptions = new Dictionary<RadioButton, (string, double)>
            {
                { radioButton1, ("9x12", 1.5) },
                { radioButton2, ("12x15", 2.0) },
                { radioButton3, ("18x24", 3.0) }
            };
        }

        /// <summary>
        /// Обробник натискання кнопки "Розрахувати вартість".
        /// Перевіряє вибір розміру, кількість, викликає розрахунок та показує результат.
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            string size = null;
            double photoPrice = 0;

            // Визначаємо вибраний розмір та ціну
            foreach (var kvp in photoOptions)
            {
                if (kvp.Key.Checked)
                {
                    size = kvp.Value.size;
                    photoPrice = kvp.Value.price;
                    break;
                }
            }

            // Якщо розмір не вибрано — повідомлення про помилку
            if (size == null)
            {
                MessageBox.Show("Оберіть розмір фотографії!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int quantity = (int)numericUpDown1.Value;
            // Перевірка кількості
            if (quantity <= 0)
            {
                MessageBox.Show("Введіть кількість фотографій більше нуля!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Розрахунок вартості та перевірка наявності знижки
            var (totalCost, hasDiscount) = CalculateOrder(photoPrice, quantity);

            // Формування результату для виводу
            string result = $"Розмір: {size}\n" +
                            $"Кількість: {quantity}\n" +
                            $"Ціна за 1 шт: ${photoPrice:0.00}\n";
            if (hasDiscount)
                result += "Знижка: 10%\n";
            result += $"Сума до сплати: ${totalCost:0.00}";

            // Вивід результату користувачу
            MessageBox.Show(result, "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Розраховує загальну вартість замовлення та визначає, чи застосовано знижку.
        /// </summary>
        /// <param name="price">Ціна за одну фотографію</param>
        /// <param name="qty">Кількість фотографій</param>
        /// <returns>Кортеж: (загальна сума, чи застосовано знижку)</returns>
        private (double total, bool discountApplied) CalculateOrder(double price, int qty)
        {
            double total = price * qty;
            bool discountApplied = false;
            // Якщо кількість > 20, застосовується знижка
            if (qty > 20)
            {
                total *= (1 - discount);
                discountApplied = true;
            }
            return (total, discountApplied);
        }
    }
}
