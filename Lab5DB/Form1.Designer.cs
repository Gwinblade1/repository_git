namespace Lab5DB
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.HLNameChange = new System.Windows.Forms.TextBox();
            this.Lname = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.DateOfOpening = new System.Windows.Forms.DateTimePicker();
            this.HLFinishTime = new System.Windows.Forms.DateTimePicker();
            this.HLStartTime = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.AddHL = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.HotLineName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.UpdateOpNameAndSurname = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.OperSurnameChange = new System.Windows.Forms.TextBox();
            this.OperNameChange = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.Workplace_Number = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.OperatorSurname = new System.Windows.Forms.TextBox();
            this.OperatorName = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.DataView1 = new System.Windows.Forms.DataGridView();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataView1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.button2);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.button3);
            this.splitContainer1.Panel2.Controls.Add(this.DataView1);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.SplitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(859, 637);
            this.splitContainer1.SplitterDistance = 286;
            this.splitContainer1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(150, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 38);
            this.button2.TabIndex = 4;
            this.button2.Text = "Show Table Hotlines";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 38);
            this.button1.TabIndex = 3;
            this.button1.Text = "Show Table Operators";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.HLNameChange);
            this.groupBox2.Controls.Add(this.Lname);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.DateOfOpening);
            this.groupBox2.Controls.Add(this.HLFinishTime);
            this.groupBox2.Controls.Add(this.HLStartTime);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.AddHL);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.HotLineName);
            this.groupBox2.Location = new System.Drawing.Point(12, 320);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(258, 305);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Додати Гарячу Лінію";
            // 
            // HLNameChange
            // 
            this.HLNameChange.Location = new System.Drawing.Point(152, 109);
            this.HLNameChange.Name = "HLNameChange";
            this.HLNameChange.Size = new System.Drawing.Size(100, 20);
            this.HLNameChange.TabIndex = 14;
            // 
            // Lname
            // 
            this.Lname.AutoSize = true;
            this.Lname.Location = new System.Drawing.Point(172, 92);
            this.Lname.Name = "Lname";
            this.Lname.Size = new System.Drawing.Size(79, 13);
            this.Lname.TabIndex = 13;
            this.Lname.Text = "Змінити назву";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(175, 135);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 12;
            this.button6.Text = "Змінити";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // DateOfOpening
            // 
            this.DateOfOpening.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateOfOpening.Location = new System.Drawing.Point(7, 216);
            this.DateOfOpening.Name = "DateOfOpening";
            this.DateOfOpening.Size = new System.Drawing.Size(96, 20);
            this.DateOfOpening.TabIndex = 11;
            this.DateOfOpening.ValueChanged += new System.EventHandler(this.DateOfOpening_ValueChanged);
            // 
            // HLFinishTime
            // 
            this.HLFinishTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.HLFinishTime.Location = new System.Drawing.Point(7, 164);
            this.HLFinishTime.Name = "HLFinishTime";
            this.HLFinishTime.Size = new System.Drawing.Size(96, 20);
            this.HLFinishTime.TabIndex = 10;
            this.HLFinishTime.ValueChanged += new System.EventHandler(this.HLFinishTime_ValueChanged);
            // 
            // HLStartTime
            // 
            this.HLStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.HLStartTime.Location = new System.Drawing.Point(7, 109);
            this.HLStartTime.Name = "HLStartTime";
            this.HLStartTime.Size = new System.Drawing.Size(96, 20);
            this.HLStartTime.TabIndex = 9;
            this.HLStartTime.ValueChanged += new System.EventHandler(this.HLStartTime_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Дата Відкриття";
            // 
            // AddHL
            // 
            this.AddHL.Location = new System.Drawing.Point(6, 263);
            this.AddHL.Name = "AddHL";
            this.AddHL.Size = new System.Drawing.Size(75, 23);
            this.AddHL.TabIndex = 6;
            this.AddHL.Text = "Add";
            this.AddHL.UseVisualStyleBackColor = true;
            this.AddHL.Click += new System.EventHandler(this.AddHL_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Кінець роботи";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Початок Роботи";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Назва";
            // 
            // HotLineName
            // 
            this.HotLineName.Location = new System.Drawing.Point(7, 50);
            this.HotLineName.Name = "HotLineName";
            this.HotLineName.Size = new System.Drawing.Size(96, 20);
            this.HotLineName.TabIndex = 0;
            this.HotLineName.TextChanged += new System.EventHandler(this.HotLineName_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.UpdateOpNameAndSurname);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.OperSurnameChange);
            this.groupBox1.Controls.Add(this.OperNameChange);
            this.groupBox1.Controls.Add(this.AddButton);
            this.groupBox1.Controls.Add(this.Workplace_Number);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.OperatorSurname);
            this.groupBox1.Controls.Add(this.OperatorName);
            this.groupBox1.Location = new System.Drawing.Point(12, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 258);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Додати Оператора";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(142, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Виберіть Оператора";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(155, 38);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(96, 21);
            this.comboBox1.TabIndex = 13;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // UpdateOpNameAndSurname
            // 
            this.UpdateOpNameAndSurname.Location = new System.Drawing.Point(177, 211);
            this.UpdateOpNameAndSurname.Name = "UpdateOpNameAndSurname";
            this.UpdateOpNameAndSurname.Size = new System.Drawing.Size(75, 23);
            this.UpdateOpNameAndSurname.TabIndex = 12;
            this.UpdateOpNameAndSurname.Text = "Змінити";
            this.UpdateOpNameAndSurname.UseVisualStyleBackColor = true;
            this.UpdateOpNameAndSurname.Click += new System.EventHandler(this.UpdateOpNameAndSurname_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(159, 151);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Змінити Прізвище";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(184, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Змінити ім\'я";
            // 
            // OperSurnameChange
            // 
            this.OperSurnameChange.Location = new System.Drawing.Point(155, 167);
            this.OperSurnameChange.Name = "OperSurnameChange";
            this.OperSurnameChange.Size = new System.Drawing.Size(100, 20);
            this.OperSurnameChange.TabIndex = 9;
            // 
            // OperNameChange
            // 
            this.OperNameChange.Location = new System.Drawing.Point(152, 102);
            this.OperNameChange.Name = "OperNameChange";
            this.OperNameChange.Size = new System.Drawing.Size(100, 20);
            this.OperNameChange.TabIndex = 8;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(6, 211);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 6;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // Workplace_Number
            // 
            this.Workplace_Number.Location = new System.Drawing.Point(6, 167);
            this.Workplace_Number.Name = "Workplace_Number";
            this.Workplace_Number.Size = new System.Drawing.Size(97, 20);
            this.Workplace_Number.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Номер робочого місця";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Прізвище";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ім\'я";
            // 
            // OperatorSurname
            // 
            this.OperatorSurname.Location = new System.Drawing.Point(7, 102);
            this.OperatorSurname.Name = "OperatorSurname";
            this.OperatorSurname.Size = new System.Drawing.Size(96, 20);
            this.OperatorSurname.TabIndex = 1;
            // 
            // OperatorName
            // 
            this.OperatorName.Location = new System.Drawing.Point(7, 39);
            this.OperatorName.Name = "OperatorName";
            this.OperatorName.Size = new System.Drawing.Size(96, 20);
            this.OperatorName.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(377, 572);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(180, 53);
            this.button3.TabIndex = 1;
            this.button3.Text = "Next Form";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // DataView1
            // 
            this.DataView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataView1.Location = new System.Drawing.Point(0, 0);
            this.DataView1.Name = "DataView1";
            this.DataView1.Size = new System.Drawing.Size(569, 637);
            this.DataView1.TabIndex = 0;
            this.DataView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataView1_CellContentClick);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(154, 49);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(96, 21);
            this.comboBox2.TabIndex = 15;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.ComboBox2_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(170, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Виберіть Лінію";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 637);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Operator&HotlinesAdding";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView DataView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox OperatorSurname;
        private System.Windows.Forms.TextBox OperatorName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox Workplace_Number;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button AddHL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox HotLineName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker HLStartTime;
        private System.Windows.Forms.DateTimePicker DateOfOpening;
        private System.Windows.Forms.DateTimePicker HLFinishTime;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox HLNameChange;
        private System.Windows.Forms.Label Lname;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button UpdateOpNameAndSurname;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox OperSurnameChange;
        private System.Windows.Forms.TextBox OperNameChange;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label11;
    }
}

