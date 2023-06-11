namespace CarPricePrediction.WinApp
{
    partial class EditCarForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.labelYear = new System.Windows.Forms.Label();
            this.textBoxOwner = new System.Windows.Forms.TextBox();
            this.labelOwner = new System.Windows.Forms.Label();
            this.textBoxKmsDriven = new System.Windows.Forms.TextBox();
            this.labelKmsDriven = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.buttonClearCar = new System.Windows.Forms.Button();
            this.buttonSaveCar = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxYear
            // 
            this.textBoxYear.Location = new System.Drawing.Point(144, 177);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(441, 31);
            this.textBoxYear.TabIndex = 26;
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Location = new System.Drawing.Point(33, 183);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(105, 25);
            this.labelYear.TabIndex = 25;
            this.labelYear.Text = "Рік випуску";
            // 
            // textBoxOwner
            // 
            this.textBoxOwner.Location = new System.Drawing.Point(126, 140);
            this.textBoxOwner.Name = "textBoxOwner";
            this.textBoxOwner.Size = new System.Drawing.Size(459, 31);
            this.textBoxOwner.TabIndex = 24;
            // 
            // labelOwner
            // 
            this.labelOwner.AutoSize = true;
            this.labelOwner.Location = new System.Drawing.Point(33, 146);
            this.labelOwner.Name = "labelOwner";
            this.labelOwner.Size = new System.Drawing.Size(87, 25);
            this.labelOwner.TabIndex = 23;
            this.labelOwner.Text = "Власники";
            // 
            // textBoxKmsDriven
            // 
            this.textBoxKmsDriven.Location = new System.Drawing.Point(109, 103);
            this.textBoxKmsDriven.Name = "textBoxKmsDriven";
            this.textBoxKmsDriven.Size = new System.Drawing.Size(476, 31);
            this.textBoxKmsDriven.TabIndex = 22;
            // 
            // labelKmsDriven
            // 
            this.labelKmsDriven.AutoSize = true;
            this.labelKmsDriven.Location = new System.Drawing.Point(33, 109);
            this.labelKmsDriven.Name = "labelKmsDriven";
            this.labelKmsDriven.Size = new System.Drawing.Size(70, 25);
            this.labelKmsDriven.TabIndex = 21;
            this.labelKmsDriven.Text = "Км/год";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(87, 66);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(498, 31);
            this.textBoxPrice.TabIndex = 20;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(33, 72);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(48, 25);
            this.labelPrice.TabIndex = 19;
            this.labelPrice.Text = "Ціна";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(198, 29);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(387, 31);
            this.textBoxName.TabIndex = 18;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(33, 35);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(159, 25);
            this.labelName.TabIndex = 17;
            this.labelName.Text = "Назва автомобіля";
            // 
            // buttonClearCar
            // 
            this.buttonClearCar.Location = new System.Drawing.Point(221, 224);
            this.buttonClearCar.Name = "buttonClearCar";
            this.buttonClearCar.Size = new System.Drawing.Size(179, 45);
            this.buttonClearCar.TabIndex = 16;
            this.buttonClearCar.Text = "Очистити";
            this.buttonClearCar.UseVisualStyleBackColor = true;
            this.buttonClearCar.Click += new System.EventHandler(this.buttonClearCar_Click);
            // 
            // buttonSaveCar
            // 
            this.buttonSaveCar.Location = new System.Drawing.Point(36, 224);
            this.buttonSaveCar.Name = "buttonSaveCar";
            this.buttonSaveCar.Size = new System.Drawing.Size(179, 45);
            this.buttonSaveCar.TabIndex = 15;
            this.buttonSaveCar.Text = "Зберегти";
            this.buttonSaveCar.UseVisualStyleBackColor = true;
            this.buttonSaveCar.Click += new System.EventHandler(this.buttonSaveCar_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(406, 224);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(179, 45);
            this.buttonCancel.TabIndex = 27;
            this.buttonCancel.Text = "Відмінити";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // EditCarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 295);
            this.Controls.Add(this.buttonCancel);
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
            this.Controls.Add(this.buttonClearCar);
            this.Controls.Add(this.buttonSaveCar);
            this.Name = "EditCarForm";
            this.Text = "Змінити дані про автомобіль";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxYear;
        private Label labelYear;
        private TextBox textBoxOwner;
        private Label labelOwner;
        private TextBox textBoxKmsDriven;
        private Label labelKmsDriven;
        private TextBox textBoxPrice;
        private Label labelPrice;
        private TextBox textBoxName;
        private Label labelName;
        private Button buttonClearCar;
        private Button buttonSaveCar;
        private Button buttonCancel;
    }
}