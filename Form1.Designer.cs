namespace WeatherApp
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
            label1 = new Label();
            label2 = new Label();
            searchTextBox = new TextBox();
            button1 = new Button();
            label3 = new Label();
            locationLabel = new Label();
            label5 = new Label();
            currentTempLabel = new Label();
            label7 = new Label();
            currentConditionLabel = new Label();
            label10 = new Label();
            label11 = new Label();
            temperatureLabel = new Label();
            label13 = new Label();
            descriptionLabel = new Label();
            label15 = new Label();
            windSpeedLabel = new Label();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            label21 = new Label();
            label22 = new Label();
            label23 = new Label();
            label24 = new Label();
            label25 = new Label();
            label26 = new Label();
            label27 = new Label();
            label28 = new Label();
            label29 = new Label();
            label30 = new Label();
            label31 = new Label();
            label32 = new Label();
            label33 = new Label();
            label34 = new Label();
            label35 = new Label();
            label36 = new Label();
            label37 = new Label();
            label38 = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 22);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 0;
            label1.Text = "Weather App";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(87, 104);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 1;
            label2.Text = "City";
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(144, 96);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(100, 23);
            searchTextBox.TabIndex = 2;
            searchTextBox.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(278, 96);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(87, 175);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 4;
            label3.Text = "Location: ";
            // 
            // locationLabel
            // 
            locationLabel.AutoSize = true;
            locationLabel.Location = new Point(179, 175);
            locationLabel.Name = "locationLabel";
            locationLabel.Size = new Size(38, 15);
            locationLabel.TabIndex = 5;
            locationLabel.Text = "label4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(87, 213);
            label5.Name = "label5";
            label5.Size = new Size(119, 15);
            label5.TabIndex = 6;
            label5.Text = "Current Temperature:";
            label5.Click += label5_Click;
            // 
            // currentTempLabel
            // 
            currentTempLabel.AutoSize = true;
            currentTempLabel.Location = new Point(212, 213);
            currentTempLabel.Name = "currentTempLabel";
            currentTempLabel.Size = new Size(38, 15);
            currentTempLabel.TabIndex = 7;
            currentTempLabel.Text = "label6";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(87, 252);
            label7.Name = "label7";
            label7.Size = new Size(66, 15);
            label7.TabIndex = 8;
            label7.Text = "Condition: ";
            // 
            // currentConditionLabel
            // 
            currentConditionLabel.AutoSize = true;
            currentConditionLabel.Location = new Point(179, 252);
            currentConditionLabel.Name = "currentConditionLabel";
            currentConditionLabel.Size = new Size(38, 15);
            currentConditionLabel.TabIndex = 9;
            currentConditionLabel.Text = "label8";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(314, 175);
            label10.Name = "label10";
            label10.Size = new Size(39, 15);
            label10.TabIndex = 11;
            label10.Text = "Day 1:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(514, 370);
            label11.Name = "label11";
            label11.Size = new Size(39, 15);
            label11.TabIndex = 12;
            label11.Text = "Day 2:";
            // 
            // temperatureLabel
            // 
            temperatureLabel.AutoSize = true;
            temperatureLabel.Location = new Point(388, 175);
            temperatureLabel.Name = "temperatureLabel";
            temperatureLabel.Size = new Size(44, 15);
            temperatureLabel.TabIndex = 13;
            temperatureLabel.Text = "label12";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(588, 370);
            label13.Name = "label13";
            label13.Size = new Size(44, 15);
            label13.TabIndex = 14;
            label13.Text = "label13";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new Point(470, 175);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(44, 15);
            descriptionLabel.TabIndex = 15;
            descriptionLabel.Text = "label14";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(670, 370);
            label15.Name = "label15";
            label15.Size = new Size(44, 15);
            label15.TabIndex = 16;
            label15.Text = "label15";
            label15.Click += label15_Click;
            // 
            // windSpeedLabel
            // 
            windSpeedLabel.AutoSize = true;
            windSpeedLabel.Location = new Point(588, 175);
            windSpeedLabel.Name = "windSpeedLabel";
            windSpeedLabel.Size = new Size(44, 15);
            windSpeedLabel.TabIndex = 17;
            windSpeedLabel.Text = "label16";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(742, 370);
            label17.Name = "label17";
            label17.Size = new Size(44, 15);
            label17.TabIndex = 18;
            label17.Text = "label17";
            label17.Click += label17_Click;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(87, 319);
            label18.Name = "label18";
            label18.Size = new Size(54, 15);
            label18.TabIndex = 19;
            label18.Text = "Forecast:";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(742, 424);
            label19.Name = "label19";
            label19.Size = new Size(44, 15);
            label19.TabIndex = 27;
            label19.Text = "label19";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(742, 396);
            label20.Name = "label20";
            label20.Size = new Size(44, 15);
            label20.TabIndex = 26;
            label20.Text = "label20";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(670, 424);
            label21.Name = "label21";
            label21.Size = new Size(44, 15);
            label21.TabIndex = 25;
            label21.Text = "label21";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(670, 396);
            label22.Name = "label22";
            label22.Size = new Size(44, 15);
            label22.TabIndex = 24;
            label22.Text = "label22";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(588, 424);
            label23.Name = "label23";
            label23.Size = new Size(44, 15);
            label23.TabIndex = 23;
            label23.Text = "label23";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(588, 396);
            label24.Name = "label24";
            label24.Size = new Size(44, 15);
            label24.TabIndex = 22;
            label24.Text = "label24";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(514, 424);
            label25.Name = "label25";
            label25.Size = new Size(39, 15);
            label25.TabIndex = 21;
            label25.Text = "Day 4:";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(514, 396);
            label26.Name = "label26";
            label26.Size = new Size(39, 15);
            label26.TabIndex = 20;
            label26.Text = "Day 3:";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new Point(742, 478);
            label27.Name = "label27";
            label27.Size = new Size(44, 15);
            label27.TabIndex = 35;
            label27.Text = "label27";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Location = new Point(742, 451);
            label28.Name = "label28";
            label28.Size = new Size(44, 15);
            label28.TabIndex = 34;
            label28.Text = "label28";
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Location = new Point(670, 478);
            label29.Name = "label29";
            label29.Size = new Size(44, 15);
            label29.TabIndex = 33;
            label29.Text = "label29";
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Location = new Point(670, 451);
            label30.Name = "label30";
            label30.Size = new Size(44, 15);
            label30.TabIndex = 32;
            label30.Text = "label30";
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Location = new Point(588, 478);
            label31.Name = "label31";
            label31.Size = new Size(44, 15);
            label31.TabIndex = 31;
            label31.Text = "label31";
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Location = new Point(588, 451);
            label32.Name = "label32";
            label32.Size = new Size(44, 15);
            label32.TabIndex = 30;
            label32.Text = "label32";
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Location = new Point(514, 478);
            label33.Name = "label33";
            label33.Size = new Size(39, 15);
            label33.TabIndex = 29;
            label33.Text = "Day 6:";
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.Location = new Point(514, 451);
            label34.Name = "label34";
            label34.Size = new Size(39, 15);
            label34.TabIndex = 28;
            label34.Text = "Day 5:";
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.Location = new Point(742, 503);
            label35.Name = "label35";
            label35.Size = new Size(44, 15);
            label35.TabIndex = 39;
            label35.Text = "label35";
            // 
            // label36
            // 
            label36.AutoSize = true;
            label36.Location = new Point(670, 503);
            label36.Name = "label36";
            label36.Size = new Size(44, 15);
            label36.TabIndex = 38;
            label36.Text = "label36";
            // 
            // label37
            // 
            label37.AutoSize = true;
            label37.Location = new Point(588, 503);
            label37.Name = "label37";
            label37.Size = new Size(44, 15);
            label37.TabIndex = 37;
            label37.Text = "label37";
            // 
            // label38
            // 
            label38.AutoSize = true;
            label38.Location = new Point(514, 503);
            label38.Name = "label38";
            label38.Size = new Size(39, 15);
            label38.TabIndex = 36;
            label38.Text = "Day 7:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(87, 353);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(388, 202);
            dataGridView1.TabIndex = 40;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(936, 567);
            Controls.Add(dataGridView1);
            Controls.Add(label35);
            Controls.Add(label36);
            Controls.Add(label37);
            Controls.Add(label38);
            Controls.Add(label27);
            Controls.Add(label28);
            Controls.Add(label29);
            Controls.Add(label30);
            Controls.Add(label31);
            Controls.Add(label32);
            Controls.Add(label33);
            Controls.Add(label34);
            Controls.Add(label19);
            Controls.Add(label20);
            Controls.Add(label21);
            Controls.Add(label22);
            Controls.Add(label23);
            Controls.Add(label24);
            Controls.Add(label25);
            Controls.Add(label26);
            Controls.Add(label18);
            Controls.Add(label17);
            Controls.Add(windSpeedLabel);
            Controls.Add(label15);
            Controls.Add(descriptionLabel);
            Controls.Add(label13);
            Controls.Add(temperatureLabel);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(currentConditionLabel);
            Controls.Add(label7);
            Controls.Add(currentTempLabel);
            Controls.Add(label5);
            Controls.Add(locationLabel);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(searchTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox searchTextBox;
        private Button button1;
        private Label label3;
        private Label locationLabel;
        private Label label5;
        private Label currentTempLabel;
        private Label label7;
        private Label currentConditionLabel;
        private Label label10;
        private Label label11;
        private Label temperatureLabel;
        private Label label13;
        private Label descriptionLabel;
        private Label label15;
        private Label windSpeedLabel;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label20;
        private Label label21;
        private Label label22;
        private Label label23;
        private Label label24;
        private Label label25;
        private Label label26;
        private Label label27;
        private Label label28;
        private Label label29;
        private Label label30;
        private Label label31;
        private Label label32;
        private Label label33;
        private Label label34;
        private Label label35;
        private Label label36;
        private Label label37;
        private Label label38;
        private DataGridView dataGridView1;
    }
}
