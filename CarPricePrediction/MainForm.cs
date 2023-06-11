using CarPricePrediction.Core.Entities;
using CarPricePrediction.Repositories;
using CarPricePrediction.Core.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CarPricePrediction
{
    public partial class MainForm : Form
    {
        private Repository<Car, Guid> carRepository;
        private CarsContext dbContext;

        public MainForm()
        {
            InitializeComponent();
            dbContext = new CarsContext(); // Ініціалізуємо контекст бази даних
            carRepository = new Repository<Car, Guid>(dbContext); // Ініціалізуємо репозиторій для сутності Car
            listBoxCars.SelectedIndexChanged += new EventHandler(listBoxClients_SelectedIndexChanged);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Отримуємо список автомобілів з бази даних та оновлюємо елементи керування форми
            updateCarList();
        }

        private void updateCarList()
        {
            var cars = carRepository.GetAll().ToList();
            listBoxCars.Items.Clear();
            listBoxCars.Items.AddRange(cars.ToArray());
        }

        private void buttonSaveCar_Click(object sender, EventArgs e)
        {
            // Перевірка, чи були введені всі дані автомобіля
            if (string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                MessageBox.Show("Будь ласка, введіть назву автомобіля.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!double.TryParse(textBoxPrice.Text, out double price))
            {
                MessageBox.Show("Будь ласка, введіть коректну ціну автомобіля.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!double.TryParse(textBoxKmsDriven.Text, out double kmsDriven))
            {
                MessageBox.Show("Будь ласка, введіть коректну пробіг автомобіля.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(textBoxOwner.Text))
            {
                MessageBox.Show("Будь ласка, введіть власника автомобіля.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!int.TryParse(textBoxYear.Text, out int year))
            {
                MessageBox.Show("Будь ласка, введіть коректний рік випуску автомобіля.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var newCar = new Car
            {
                Id = Guid.NewGuid(),
                Name = textBoxName.Text,
                Price = price,
                Kms_driven = kmsDriven,
                Owner = textBoxOwner.Text,
                Year = year
            };

            carRepository.Create(newCar);
            dbContext.SaveChanges(); // Зберігаємо зміни в базу даних

            updateCarList();

            textBoxName.Text = string.Empty;
            textBoxPrice.Text = string.Empty;
            textBoxKmsDriven.Text = string.Empty;
            textBoxOwner.Text = string.Empty;
            textBoxYear.Text = string.Empty;
        }

        private void buttonClearCar_Click(object sender, EventArgs e)
        {
            textBoxName.Text = string.Empty;
            textBoxPrice.Text = string.Empty;
            textBoxKmsDriven.Text = string.Empty;
            textBoxOwner.Text = string.Empty;
            textBoxYear.Text = string.Empty;
        }

        private void listBoxCars_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonRemoveCar.Enabled = listBoxCars.SelectedIndex != -1;
            buttonEditCar.Enabled = listBoxCars.SelectedIndex != -1;
        }

        private void buttonRemoveCar_Click(object sender, EventArgs e)
        {
            if (listBoxCars.SelectedItem != null)
            {
                Car car = (Car)listBoxCars.SelectedItem;
                var dialogResult = MessageBox.Show($"Ви справді хочете видалити автомобіль {car.Name}?", "Видалення", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.OK)
                {
                    carRepository.Delete(car);
                    dbContext.SaveChanges(); // Зберігаємо зміни в базу даних

                    updateCarList();
                }
            }
        }

        private void buttonEditCar_Click(object sender, EventArgs e)
        {
            if (listBoxCars.SelectedItem != null)
            {
                Car car = (Car)listBoxCars.SelectedItem;
                var form = new EditCarForm(car);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    carRepository.Update(form.Car);
                    dbContext.SaveChanges(); // Зберігаємо зміни в базу даних

                    listBoxCars.SelectedItem = form.Car;
                    updateCarList();
                }
            }
        }
    }
}
