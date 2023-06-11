namespace CarPricePrediction
{
    partial class MainForm
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
            this.listBoxCars = new System.Windows.Forms.ListBox();
            this.buttonSaveCar = new System.Windows.Forms.Button();
            this.buttonClearCar = new System.Windows.Forms.Button();
            this.buttonRemoveCar = new System.Windows.Forms.Button();
            this.buttonEditCar = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.labelOwners = new System.Windows.Forms.Label();
            this.textBoxOwner = new System.Windows.Forms.TextBox();
            this.labelKms = new System.Windows.Forms.Label();
            this.textBoxKmsDriven = new System.Windows.Forms.TextBox();
            this.labelYear = new System.Windows.Forms.Label();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBoxCars
            // 
            this.listBoxCars.FormattingEnabled = true;
            this.listBoxCars.ItemHeight = 20;
            this.listBoxCars.Location = new System.Drawing.Point(0, 0);
            this.listBoxCars.Name = "listBoxCars";
            this.listBoxCars.Size = new System.Drawing.Size(954, 284);
            this.listBoxCars.TabIndex = 0;
            // 
            // buttonSaveCar
            // 
            this.buttonSaveCar.Location = new System.Drawing.Point(527, 556);
            this.buttonSaveCar.Name = "buttonSaveCar";
            this.buttonSaveCar.Size = new System.Drawing.Size(146, 35);
            this.buttonSaveCar.TabIndex = 1;
            this.buttonSaveCar.Text = "Зберегти";
            this.buttonSaveCar.UseVisualStyleBackColor = true;
            // 
            // buttonClearCar
            // 
            this.buttonClearCar.Location = new System.Drawing.Point(679, 556);
            this.buttonClearCar.Name = "buttonClearCar";
            this.buttonClearCar.Size = new System.Drawing.Size(146, 35);
            this.buttonClearCar.TabIndex = 2;
            this.buttonClearCar.Text = "Очистити";
            this.buttonClearCar.UseVisualStyleBackColor = true;
            // 
            // buttonRemoveCar
            // 
            this.buttonRemoveCar.Location = new System.Drawing.Point(28, 321);
            this.buttonRemoveCar.Name = "buttonRemoveCar";
            this.buttonRemoveCar.Size = new System.Drawing.Size(146, 62);
            this.buttonRemoveCar.TabIndex = 3;
            this.buttonRemoveCar.Text = "Видалити авто";
            this.buttonRemoveCar.UseVisualStyleBackColor = true;
            // 
            // buttonEditCar
            // 
            this.buttonEditCar.Location = new System.Drawing.Point(28, 420);
            this.buttonEditCar.Name = "buttonEditCar";
            this.buttonEditCar.Size = new System.Drawing.Size(146, 62);
            this.buttonEditCar.TabIndex = 4;
            this.buttonEditCar.Text = "Редагувати дані про авто";
            this.buttonEditCar.UseVisualStyleBackColor = true;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(519, 356);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(306, 26);
            this.textBoxName.TabIndex = 5;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(417, 359);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(96, 20);
            this.labelName.TabIndex = 6;
            this.labelName.Text = "Назва авто";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(417, 391);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(42, 20);
            this.labelPrice.TabIndex = 8;
            this.labelPrice.Text = "Ціна";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(519, 388);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(306, 26);
            this.textBoxPrice.TabIndex = 7;
            // 
            // labelOwners
            // 
            this.labelOwners.AutoSize = true;
            this.labelOwners.Location = new System.Drawing.Point(417, 459);
            this.labelOwners.Name = "labelOwners";
            this.labelOwners.Size = new System.Drawing.Size(82, 20);
            this.labelOwners.TabIndex = 12;
            this.labelOwners.Text = "Власники";
            // 
            // textBoxOwner
            // 
            this.textBoxOwner.Location = new System.Drawing.Point(519, 456);
            this.textBoxOwner.Name = "textBoxOwner";
            this.textBoxOwner.Size = new System.Drawing.Size(306, 26);
            this.textBoxOwner.TabIndex = 11;
            // 
            // labelKms
            // 
            this.labelKms.AutoSize = true;
            this.labelKms.Location = new System.Drawing.Point(417, 427);
            this.labelKms.Name = "labelKms";
            this.labelKms.Size = new System.Drawing.Size(61, 20);
            this.labelKms.TabIndex = 10;
            this.labelKms.Text = "Км/год";
            // 
            // textBoxKmsDriven
            // 
            this.textBoxKmsDriven.Location = new System.Drawing.Point(519, 424);
            this.textBoxKmsDriven.Name = "textBoxKmsDriven";
            this.textBoxKmsDriven.Size = new System.Drawing.Size(306, 26);
            this.textBoxKmsDriven.TabIndex = 9;
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Location = new System.Drawing.Point(417, 491);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(91, 20);
            this.labelYear.TabIndex = 14;
            this.labelYear.Text = "Рік випуску";
            // 
            // textBoxYear
            // 
            this.textBoxYear.Location = new System.Drawing.Point(519, 488);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(306, 26);
            this.textBoxYear.TabIndex = 13;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 623);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.labelOwners);
            this.Controls.Add(this.textBoxOwner);
            this.Controls.Add(this.labelKms);
            this.Controls.Add(this.textBoxKmsDriven);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.buttonEditCar);
            this.Controls.Add(this.buttonRemoveCar);
            this.Controls.Add(this.buttonClearCar);
            this.Controls.Add(this.buttonSaveCar);
            this.Controls.Add(this.listBoxCars);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxCars;
        private System.Windows.Forms.Button buttonSaveCar;
        private System.Windows.Forms.Button buttonClearCar;
        private System.Windows.Forms.Button buttonRemoveCar;
        private System.Windows.Forms.Button buttonEditCar;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label labelOwners;
        private System.Windows.Forms.TextBox textBoxOwner;
        private System.Windows.Forms.Label labelKms;
        private System.Windows.Forms.TextBox textBoxKmsDriven;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.TextBox textBoxYear;
    }
}

