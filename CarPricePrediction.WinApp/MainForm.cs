using CarPricePrediction.Core.Entities;
using CarPricePrediction.Repositories;
using CarPricePrediction.Core.Context;
using System.Text.RegularExpressions;

namespace CarPricePrediction.WinApp
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
            listBoxCars.SelectedIndexChanged += new EventHandler(listBoxCars_SelectedIndexChanged);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Отримуємо список автомобілів з бази даних та оновлюємо елементи керування форми
            updateCarList();
        }

        private void updateCarList()
        {
            var cars = carRepository.GetAll().ToList();
            listBoxCars.Items.Clear();

            for (int i = 0; i < cars.Count; i++)
            {
                var car = cars[i];
                string ownerInfo = string.IsNullOrWhiteSpace(car.Owner) || car.Owner == "0" ? "немає" : Regex.Replace(car.Owner, "[^0-9]", "");
                string carInfo = $"{i + 1}. {car.Name} - | Ціна: {car.Price} | Км/год: {car.Kms_driven} | Власники: {ownerInfo} | Рік: {car.Year}";
                listBoxCars.Items.Add(carInfo);
            }
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
                MessageBox.Show("Будь ласка, введіть коректне значення км/год автомобіля.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            var newCar = new Car
            {
                Id = Guid.NewGuid(),
                Name = textBoxName.Text,
                Price = price,
                Kms_driven = kmsDriven,
                Owner = owner.ToString(),
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
                string carInfo = listBoxCars.SelectedItem.ToString();
                string[] parts = carInfo.Split(new string[] { ". " }, StringSplitOptions.RemoveEmptyEntries);
                int carIndex = int.Parse(parts[0]) - 1;

                var cars = carRepository.GetAll().ToList();
                if (carIndex >= 0 && carIndex < cars.Count)
                {
                    Car car = cars[carIndex];
                    var dialogResult = MessageBox.Show($"Ви справді хочете видалити автомобіль {car.Name}?", "Видалення", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.OK)
                    {
                        carRepository.Delete(car);
                        dbContext.SaveChanges(); // Зберігаємо зміни в базу даних

                        updateCarList();
                    }
                }
            }
        }
        private void buttonEditCar_Click(object sender, EventArgs e)
        {
            if (listBoxCars.SelectedItem != null)
            {
                string carInfo = listBoxCars.SelectedItem.ToString();
                string[] parts = carInfo.Split(new string[] { ". " }, StringSplitOptions.RemoveEmptyEntries);
                int carIndex = int.Parse(parts[0]) - 1;

                var cars = carRepository.GetAll().ToList();
                if (carIndex >= 0 && carIndex < cars.Count)
                {
                    Car car = cars[carIndex];
                    var form = new EditCarForm(car);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        carRepository.Update(form.Car);
                        dbContext.SaveChanges(); // Зберігаємо зміни в базу даних

                        updateCarList(); // Оновлюємо список автомобілів
                    }
                }
            }
        }
    }
}