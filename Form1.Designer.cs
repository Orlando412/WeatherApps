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
            label18 = new Label();
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
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(87, 319);
            label18.Name = "label18";
            label18.Size = new Size(54, 15);
            label18.TabIndex = 19;
            label18.Text = "Forecast:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(84, 353);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(537, 202);
            dataGridView1.TabIndex = 40;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(936, 567);
            Controls.Add(dataGridView1);
            Controls.Add(label18);
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
        private Label label18;
        private DataGridView dataGridView1;
    }
}
