using CarPricePrediction.Core.Entities;
using CarPricePrediction.Repositories;
using CarPricePrediction.Core.Context;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CarPricePrediction.WinApp
{
    public partial class EditCarForm : Form
    {
        public Car Car { get; private set; }
        private Repository<Car, Guid> carRepository;
        private CarsContext dbContext;

        public EditCarForm(Car car)
        {
            InitializeComponent();
            dbContext = new CarsContext();
            carRepository = new Repository<Car, Guid>(dbContext);
            Car = car;

            // Встановлюємо початкові значення полів форми на основі переданого автомобіля
            textBoxName.Text = Car.Name;
            textBoxPrice.Text = Car.Price.ToString();
            textBoxKmsDriven.Text = Car.Kms_driven.ToString();
            textBoxOwner.Text = Car.Owner;
            textBoxYear.Text = Car.Year.ToString();
        }

        private void buttonSaveCar_Click(object sender, EventArgs e)
        {
            // Перевірка, чи були введені всі дані автомобіля
            if (string.IsNullOrWhiteSpace(textBoxName.Text) || textBoxName.Text.Length < 10)
            {
                MessageBox.Show("Будь ласка, введіть назву автомобіля (мінімум 10 символів).", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!double.TryParse(textBoxPrice.Text, out double price))
            {
                MessageBox.Show("Будь ласка, введіть коректну ціну автомобіля.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!double.TryParse(textBoxKmsDriven.Text, out double kmsDriven))
            {
                MessageBox.Show("Будь ласка, введіть коректний пробіг автомобіля.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(textBoxOwner.Text) || !int.TryParse(textBoxOwner.Text, out int owner) || textBoxOwner.Text.Length != 1)
            {
                MessageBox.Show("Будь ласка, введіть коректного власника автомобіля (одна цифра).", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!int.TryParse(textBoxYear.Text, out int year) || year > 2023 || year <= 0)
            {
                MessageBox.Show("Будь ласка, введіть коректний рік випуску автомобіля (не більше 2023).", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Car.Name = textBoxName.Text;
            Car.Price = price;
            Car.Kms_driven = kmsDriven;
            Car.Owner = owner.ToString();
            Car.Year = year;

            carRepository.Update(Car);
            dbContext.SaveChanges(); // Зберігаємо зміни в базу даних

            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonClearCar_Click(object sender, EventArgs e)
        {
            textBoxName.Text = string.Empty;
            textBoxPrice.Text = string.Empty;
            textBoxKmsDriven.Text = string.Empty;
            textBoxOwner.Text = string.Empty;
            textBoxYear.Text = string.Empty;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
