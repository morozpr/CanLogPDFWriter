namespace WinFormsApp1
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            textBox5 = new TextBox();
            label5 = new Label();
            textBox6 = new TextBox();
            label6 = new Label();
            label7 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label8 = new Label();
            label9 = new Label();
            saveButton = new Button();
            clearBtn = new Button();
            dataGridView2 = new DataGridView();
            paramName = new DataGridViewTextBoxColumn();
            paramStatus = new DataGridViewCheckBoxColumn();
            dataGridView1 = new DataGridView();
            flagName = new DataGridViewTextBoxColumn();
            flagStatus = new DataGridViewCheckBoxColumn();
            openFileDialog1 = new OpenFileDialog();
            label10 = new Label();
            label11 = new Label();
            loadIMGBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 18);
            label1.Name = "label1";
            label1.Size = new Size(112, 20);
            label1.TabIndex = 0;
            label1.Text = "Марка Модель";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(26, 55);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(26, 131);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 94);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 2;
            label2.Text = "Модуль";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(26, 208);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 171);
            label3.Name = "label3";
            label3.Size = new Size(33, 20);
            label3.TabIndex = 4;
            label3.Text = "Год";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(26, 285);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 248);
            label4.Name = "label4";
            label4.Size = new Size(33, 20);
            label4.TabIndex = 6;
            label4.Text = "Rev";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(26, 361);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 27);
            textBox5.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 324);
            label5.Name = "label5";
            label5.Size = new Size(59, 20);
            label5.TabIndex = 8;
            label5.Text = "Версия";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(26, 438);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(125, 27);
            textBox6.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 401);
            label6.Name = "label6";
            label6.Size = new Size(91, 20);
            label6.TabIndex = 10;
            label6.Text = "Программа";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(24, 480);
            label7.Name = "label7";
            label7.Size = new Size(41, 20);
            label7.TabIndex = 12;
            label7.Text = "Дата";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(26, 515);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(191, 27);
            dateTimePicker1.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(192, 18);
            label8.Name = "label8";
            label8.Size = new Size(51, 20);
            label8.TabIndex = 16;
            label8.Text = "Флаги";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(513, 18);
            label9.Name = "label9";
            label9.Size = new Size(141, 20);
            label9.TabIndex = 17;
            label9.Text = "Общие параметры";
            // 
            // saveButton
            // 
            saveButton.Location = new Point(1022, 537);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(94, 29);
            saveButton.TabIndex = 18;
            saveButton.Text = "Сохранить";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // clearBtn
            // 
            clearBtn.Location = new Point(922, 537);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(94, 29);
            clearBtn.TabIndex = 19;
            clearBtn.Text = "Очистить";
            clearBtn.UseVisualStyleBackColor = true;
            clearBtn.Click += clearBtn_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToOrderColumns = true;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { paramName, paramStatus });
            dataGridView2.Location = new Point(513, 55);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(300, 188);
            dataGridView2.TabIndex = 15;
            // 
            // paramName
            // 
            paramName.HeaderText = "Название";
            paramName.MinimumWidth = 6;
            paramName.Name = "paramName";
            paramName.Width = 125;
            // 
            // paramStatus
            // 
            paramStatus.HeaderText = "Наличие";
            paramStatus.MinimumWidth = 6;
            paramStatus.Name = "paramStatus";
            paramStatus.Width = 125;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { flagName, flagStatus });
            dataGridView1.Location = new Point(192, 54);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(300, 188);
            dataGridView1.TabIndex = 14;
            // 
            // flagName
            // 
            flagName.HeaderText = "Название";
            flagName.MinimumWidth = 6;
            flagName.Name = "flagName";
            flagName.Width = 125;
            // 
            // flagStatus
            // 
            flagStatus.HeaderText = "Наличие";
            flagStatus.MinimumWidth = 6;
            flagStatus.Name = "flagStatus";
            flagStatus.Width = 125;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(192, 248);
            label10.Name = "label10";
            label10.Size = new Size(203, 20);
            label10.TabIndex = 20;
            label10.Text = "Загруженные изображения";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(192, 285);
            label11.Name = "label11";
            label11.Size = new Size(58, 20);
            label11.TabIndex = 21;
            label11.Text = "label11";
            // 
            // loadIMGBtn
            // 
            loadIMGBtn.Location = new Point(401, 248);
            loadIMGBtn.Name = "loadIMGBtn";
            loadIMGBtn.Size = new Size(94, 29);
            loadIMGBtn.TabIndex = 22;
            loadIMGBtn.Text = "Загрузить";
            loadIMGBtn.UseVisualStyleBackColor = true;
            loadIMGBtn.Click += loadIMGBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1128, 578);
            Controls.Add(loadIMGBtn);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(clearBtn);
            Controls.Add(saveButton);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label7);
            Controls.Add(textBox6);
            Controls.Add(label6);
            Controls.Add(textBox5);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox5;
        private Label label5;
        private TextBox textBox6;
        private Label label6;
        private Label label7;
        private DateTimePicker dateTimePicker1;
        private Label label8;
        private Label label9;
        private Button saveButton;
        private Button clearBtn;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn paramName;
        private DataGridViewCheckBoxColumn paramStatus;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn flagName;
        private DataGridViewCheckBoxColumn flagStatus;
        private OpenFileDialog openFileDialog1;
        private Label label10;
        private Label label11;
        private Button loadIMGBtn;
    }
}
