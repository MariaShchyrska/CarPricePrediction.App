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
            dbContext = new CarsContext(); // ���������� �������� ���� �����
            carRepository = new Repository<Car, Guid>(dbContext); // ���������� ���������� ��� ������� Car
            listBoxCars.SelectedIndexChanged += new EventHandler(listBoxCars_SelectedIndexChanged);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // �������� ������ ��������� � ���� ����� �� ��������� �������� ��������� �����
            updateCarList();
        }

        private void updateCarList()
        {
            var cars = carRepository.GetAll().ToList();
            listBoxCars.Items.Clear();

            for (int i = 0; i < cars.Count; i++)
            {
                var car = cars[i];
                string ownerInfo = string.IsNullOrWhiteSpace(car.Owner) || car.Owner == "0" ? "����" : Regex.Replace(car.Owner, "[^0-9]", "");
                string carInfo = $"{i + 1}. {car.Name} - | ֳ��: {car.Price} | ��/���: {car.Kms_driven} | ��������: {ownerInfo} | г�: {car.Year}";
                listBoxCars.Items.Add(carInfo);
            }
        }



        private void buttonSaveCar_Click(object sender, EventArgs e)
        {
            // ��������, �� ���� ������ �� ��� ���������
            if (string.IsNullOrWhiteSpace(textBoxName.Text) || textBoxName.Text.Length < 10)
            {
                MessageBox.Show("���� �����, ������ ����� ��������� (����� 10 �������).", "�������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!double.TryParse(textBoxPrice.Text, out double price))
            {
                MessageBox.Show("���� �����, ������ �������� ���� ���������.", "�������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!double.TryParse(textBoxKmsDriven.Text, out double kmsDriven))
            {
                MessageBox.Show("���� �����, ������ �������� �������� ��/��� ���������.", "�������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(textBoxOwner.Text) || !int.TryParse(textBoxOwner.Text, out int owner) || textBoxOwner.Text.Length != 1)
            {
                MessageBox.Show("���� �����, ������ ���������� �������� ��������� (���� �����).", "�������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!int.TryParse(textBoxYear.Text, out int year) || year > 2023 || year <= 0)
            {
                MessageBox.Show("���� �����, ������ ��������� �� ������� ��������� (�� ����� 2023).", "�������", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            dbContext.SaveChanges(); // �������� ���� � ���� �����

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
                    var dialogResult = MessageBox.Show($"�� ������ ������ �������� ��������� {car.Name}?", "���������", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.OK)
                    {
                        carRepository.Delete(car);
                        dbContext.SaveChanges(); // �������� ���� � ���� �����

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
                        dbContext.SaveChanges(); // �������� ���� � ���� �����

                        updateCarList(); // ��������� ������ ���������
                    }
                }
            }
        }
    }
}