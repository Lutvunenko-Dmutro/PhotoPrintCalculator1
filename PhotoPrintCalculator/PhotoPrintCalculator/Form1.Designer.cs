namespace PhotoPrintCalculator
{
    partial class Form1
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
            // Звільнення ресурсів форми
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
            // Ініціалізація компонентів форми
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            // label2: підпис для поля кількості фотографій
            label2 = new Label();
            // label3: додатковий label (не використовується)
            label3 = new Label();
            // radioButton1: вибір розміру 9x12
            radioButton1 = new RadioButton();
            // radioButton2: вибір розміру 12x15
            radioButton2 = new RadioButton();
            // radioButton3: вибір розміру 18x24
            radioButton3 = new RadioButton();
            // numericUpDown1: поле для введення кількості фотографій
            numericUpDown1 = new NumericUpDown();
            // button1: кнопка для розрахунку вартості
            button1 = new Button();
            // label4: інформація про знижку
            label4 = new Label();
            // pictureBox1: зображення для розміру 9x12
            pictureBox1 = new PictureBox();
            // pictureBox2: зображення для розміру 12x15
            pictureBox2 = new PictureBox();
            // pictureBox3: зображення для розміру 18x24
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(439, 354);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(127, 15);
            label2.TabIndex = 1;
            label2.Text = "Кількість фотографій:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(169, 172);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 2;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(293, 219);
            radioButton1.Margin = new Padding(2);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(48, 19);
            radioButton1.TabIndex = 3;
            radioButton1.TabStop = true;
            radioButton1.Text = "9х12";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(569, 219);
            radioButton2.Margin = new Padding(2);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(54, 19);
            radioButton2.TabIndex = 4;
            radioButton2.TabStop = true;
            radioButton2.Text = "12х15";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(874, 219);
            radioButton3.Margin = new Padding(2);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(54, 19);
            radioButton3.TabIndex = 5;
            radioButton3.TabStop = true;
            radioButton3.Text = "18х24";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(440, 327);
            numericUpDown1.Margin = new Padding(2);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(126, 23);
            numericUpDown1.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new Point(411, 297);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(183, 26);
            button1.TabIndex = 9;
            button1.Text = "Розрахувати вартість";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(0, 192, 0);
            label4.Location = new Point(298, 421);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(358, 15);
            label4.TabIndex = 10;
            label4.Text = "Якщо кількість фотографій більше 20, то надається знижка 10%";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(66, 39);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(275, 176);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(345, 32);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(278, 183);
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(627, 52);
            pictureBox3.Margin = new Padding(2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(301, 163);
            pictureBox3.TabIndex = 13;
            pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(957, 445);
            // Додаємо елементи на форму
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(numericUpDown1);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label3);
            Controls.Add(label2);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Розрахунок вартості замовлення друку фотографій";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        // label2: підпис для кількості
        private Label label2;
        // label3: додатковий label (не використовується)
        private Label label3;
        // radioButton1: вибір 9x12
        private RadioButton radioButton1;
        // radioButton2: вибір 12x15
        private RadioButton radioButton2;
        // radioButton3: вибір 18x24
        private RadioButton radioButton3;
        // numericUpDown1: кількість фотографій
        private NumericUpDown numericUpDown1;
        // button1: розрахунок вартості
        private Button button1;
        // label4: інформація про знижку
        private Label label4;
        // pictureBox1: фото 9x12
        private PictureBox pictureBox1;
        // pictureBox2: фото 12x15
        private PictureBox pictureBox2;
        // pictureBox3: фото 18x24
        private PictureBox pictureBox3;
    }
}
