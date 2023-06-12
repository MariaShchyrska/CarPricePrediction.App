namespace CarPricePrediction.WinApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxCars = new System.Windows.Forms.ListBox();
            this.buttonSaveCar = new System.Windows.Forms.Button();
            this.buttonClearCar = new System.Windows.Forms.Button();
            this.buttonRemoveCar = new System.Windows.Forms.Button();
            this.buttonEditCar = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.textBoxKmsDriven = new System.Windows.Forms.TextBox();
            this.labelKmsDriven = new System.Windows.Forms.Label();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.labelYear = new System.Windows.Forms.Label();
            this.textBoxOwner = new System.Windows.Forms.TextBox();
            this.labelOwner = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxCars
            // 
            this.listBoxCars.FormattingEnabled = true;
            this.listBoxCars.ItemHeight = 25;
            this.listBoxCars.Location = new System.Drawing.Point(24, 48);
            this.listBoxCars.Name = "listBoxCars";
            this.listBoxCars.Size = new System.Drawing.Size(949, 179);
            this.listBoxCars.TabIndex = 0;
            this.listBoxCars.SelectedIndexChanged += new System.EventHandler(this.listBoxCars_SelectedIndexChanged);
            // 
            // buttonSaveCar
            // 
            this.buttonSaveCar.Location = new System.Drawing.Point(371, 470);
            this.buttonSaveCar.Name = "buttonSaveCar";
            this.buttonSaveCar.Size = new System.Drawing.Size(179, 45);
            this.buttonSaveCar.TabIndex = 1;
            this.buttonSaveCar.Text = "Зберегти";
            this.buttonSaveCar.UseVisualStyleBackColor = true;
            this.buttonSaveCar.Click += new System.EventHandler(this.buttonSaveCar_Click);
            // 
            // buttonClearCar
            // 
            this.buttonClearCar.Location = new System.Drawing.Point(556, 470);
            this.buttonClearCar.Name = "buttonClearCar";
            this.buttonClearCar.Size = new System.Drawing.Size(179, 45);
            this.buttonClearCar.TabIndex = 2;
            this.buttonClearCar.Text = "Очистити";
            this.buttonClearCar.UseVisualStyleBackColor = true;
            this.buttonClearCar.Click += new System.EventHandler(this.buttonClearCar_Click);
            // 
            // buttonRemoveCar
            // 
            this.buttonRemoveCar.Enabled = false;
            this.buttonRemoveCar.Location = new System.Drawing.Point(784, 274);
            this.buttonRemoveCar.Name = "buttonRemoveCar";
            this.buttonRemoveCar.Size = new System.Drawing.Size(189, 79);
            this.buttonRemoveCar.TabIndex = 3;
            this.buttonRemoveCar.Text = "Видалити автомобіль";
            this.buttonRemoveCar.UseVisualStyleBackColor = true;
            this.buttonRemoveCar.Click += new System.EventHandler(this.buttonRemoveCar_Click);
            // 
            // buttonEditCar
            // 
            this.buttonEditCar.Enabled = false;
            this.buttonEditCar.Location = new System.Drawing.Point(24, 274);
            this.buttonEditCar.Name = "buttonEditCar";
            this.buttonEditCar.Size = new System.Drawing.Size(189, 79);
            this.buttonEditCar.TabIndex = 4;
            this.buttonEditCar.Text = "Редагувати дані про автомобіль";
            this.buttonEditCar.UseVisualStyleBackColor = true;
            this.buttonEditCar.Click += new System.EventHandler(this.buttonEditCar_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(268, 281);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(159, 25);
            this.labelName.TabIndex = 5;
            this.labelName.Text = "Назва автомобіля";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(433, 275);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(302, 31);
            this.textBoxName.TabIndex = 6;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(322, 312);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(413, 31);
            this.textBoxPrice.TabIndex = 8;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(268, 318);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(48, 25);
            this.labelPrice.TabIndex = 7;
            this.labelPrice.Text = "Ціна";
            // 
            // textBoxKmsDriven
            // 
            this.textBoxKmsDriven.Location = new System.Drawing.Point(344, 349);
            this.textBoxKmsDriven.Name = "textBoxKmsDriven";
            this.textBoxKmsDriven.Size = new System.Drawing.Size(391, 31);
            this.textBoxKmsDriven.TabIndex = 10;
            // 
            // labelKmsDriven
            // 
            this.labelKmsDriven.AutoSize = true;
            this.labelKmsDriven.Location = new System.Drawing.Point(268, 355);
            this.labelKmsDriven.Name = "labelKmsDriven";
            this.labelKmsDriven.Size = new System.Drawing.Size(70, 25);
            this.labelKmsDriven.TabIndex = 9;
            this.labelKmsDriven.Text = "Км/год";
            // 
            // textBoxYear
            // 
            this.textBoxYear.Location = new System.Drawing.Point(379, 423);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(356, 31);
            this.textBoxYear.TabIndex = 14;
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Location = new System.Drawing.Point(268, 429);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(105, 25);
            this.labelYear.TabIndex = 13;
            this.labelYear.Text = "Рік випуску";
            // 
            // textBoxOwner
            // 
            this.textBoxOwner.Location = new System.Drawing.Point(361, 386);
            this.textBoxOwner.Name = "textBoxOwner";
            this.textBoxOwner.Size = new System.Drawing.Size(374, 31);
            this.textBoxOwner.TabIndex = 12;
            // 
            // labelOwner
            // 
            this.labelOwner.AutoSize = true;
            this.labelOwner.Location = new System.Drawing.Point(268, 392);
            this.labelOwner.Name = "labelOwner";
            this.labelOwner.Size = new System.Drawing.Size(87, 25);
            this.labelOwner.TabIndex = 11;
            this.labelOwner.Text = "Власники";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 568);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.textBoxOwner);
            this.Controls.Add(this.labelOwner);
            this.Controls.Add(this.textBoxKmsDriven);
            this.Controls.Add(this.labelKmsDriven);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.buttonEditCar);
            this.Controls.Add(this.buttonRemoveCar);
            this.Controls.Add(this.buttonClearCar);
            this.Controls.Add(this.buttonSaveCar);
            this.Controls.Add(this.listBoxCars);
            this.Name = "MainForm";
            this.Text = "CarPricePredictionApp";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listBoxCars;
        private Button buttonSaveCar;
        private Button buttonClearCar;
        private Button buttonRemoveCar;
        private Button buttonEditCar;
        private Label labelName;
        private TextBox textBoxName;
        private TextBox textBoxPrice;
        private Label labelPrice;
        private TextBox textBoxKmsDriven;
        private Label labelKmsDriven;
        private TextBox textBoxYear;
        private Label labelYear;
        private TextBox textBoxOwner;
        private Label labelOwner;
    }
}