namespace Lab5DB
{
    partial class Form2
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.GetResult2 = new System.Windows.Forms.Button();
            this.GetResult = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Time_Of_The_Call = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.Type_of_the_Call = new System.Windows.Forms.TextBox();
            this.Date_Of_The_Call = new System.Windows.Forms.DateTimePicker();
            this.AddButton = new System.Windows.Forms.Button();
            this.Topic_Of_The_Call = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AddUser = new System.Windows.Forms.Button();
            this.PhoneNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UserSurname = new System.Windows.Forms.TextBox();
            this.UserName = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.DataView = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.UsNewName = new System.Windows.Forms.TextBox();
            this.UsNewSurname = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.UsNewNumber = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.TopicOfTheCall = new System.Windows.Forms.TextBox();
            this.StatusOfTheCall = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.CallUpdate = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataView)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.GetResult2);
            this.splitContainer1.Panel1.Controls.Add(this.GetResult);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.button3);
            this.splitContainer1.Panel2.Controls.Add(this.button2);
            this.splitContainer1.Panel2.Controls.Add(this.DataView);
            this.splitContainer1.Size = new System.Drawing.Size(859, 622);
            this.splitContainer1.SplitterDistance = 285;
            this.splitContainer1.TabIndex = 0;
            // 
            // GetResult2
            // 
            this.GetResult2.Location = new System.Drawing.Point(165, 12);
            this.GetResult2.Name = "GetResult2";
            this.GetResult2.Size = new System.Drawing.Size(105, 47);
            this.GetResult2.TabIndex = 5;
            this.GetResult2.Text = "Show Table Calls";
            this.GetResult2.UseVisualStyleBackColor = true;
            this.GetResult2.Click += new System.EventHandler(this.Button1_Click);
            // 
            // GetResult
            // 
            this.GetResult.Location = new System.Drawing.Point(12, 12);
            this.GetResult.Name = "GetResult";
            this.GetResult.Size = new System.Drawing.Size(105, 47);
            this.GetResult.TabIndex = 4;
            this.GetResult.Text = "Show Table Users";
            this.GetResult.UseVisualStyleBackColor = true;
            this.GetResult.Click += new System.EventHandler(this.GetResult_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CallUpdate);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.StatusOfTheCall);
            this.groupBox2.Controls.Add(this.TopicOfTheCall);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.Time_Of_The_Call);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.Type_of_the_Call);
            this.groupBox2.Controls.Add(this.Date_Of_The_Call);
            this.groupBox2.Controls.Add(this.AddButton);
            this.groupBox2.Controls.Add(this.Topic_Of_The_Call);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(12, 347);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(258, 263);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Додати Дзвінок";
            // 
            // Time_Of_The_Call
            // 
            this.Time_Of_The_Call.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.Time_Of_The_Call.Location = new System.Drawing.Point(18, 97);
            this.Time_Of_The_Call.Name = "Time_Of_The_Call";
            this.Time_Of_The_Call.Size = new System.Drawing.Size(94, 20);
            this.Time_Of_The_Call.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Статус Дзвінку";
            // 
            // Type_of_the_Call
            // 
            this.Type_of_the_Call.Location = new System.Drawing.Point(18, 205);
            this.Type_of_the_Call.Name = "Type_of_the_Call";
            this.Type_of_the_Call.Size = new System.Drawing.Size(94, 20);
            this.Type_of_the_Call.TabIndex = 8;
            // 
            // Date_Of_The_Call
            // 
            this.Date_Of_The_Call.Location = new System.Drawing.Point(18, 49);
            this.Date_Of_The_Call.Name = "Date_Of_The_Call";
            this.Date_Of_The_Call.Size = new System.Drawing.Size(94, 20);
            this.Date_Of_The_Call.TabIndex = 7;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(18, 234);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 6;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // Topic_Of_The_Call
            // 
            this.Topic_Of_The_Call.Location = new System.Drawing.Point(18, 157);
            this.Topic_Of_The_Call.Name = "Topic_Of_The_Call";
            this.Topic_Of_The_Call.Size = new System.Drawing.Size(94, 20);
            this.Topic_Of_The_Call.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Тема Дзвінку";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Час Дзвінку";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Час Дзвінку";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Дата дзвінку\r\n";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.UsNewNumber);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.UsNewSurname);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.UsNewName);
            this.groupBox1.Controls.Add(this.AddUser);
            this.groupBox1.Controls.Add(this.PhoneNumber);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.UserSurname);
            this.groupBox1.Controls.Add(this.UserName);
            this.groupBox1.Location = new System.Drawing.Point(12, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 228);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Додати Користувача";
            // 
            // AddUser
            // 
            this.AddUser.Location = new System.Drawing.Point(17, 199);
            this.AddUser.Name = "AddUser";
            this.AddUser.Size = new System.Drawing.Size(71, 23);
            this.AddUser.TabIndex = 6;
            this.AddUser.Text = "Add";
            this.AddUser.UseVisualStyleBackColor = true;
            this.AddUser.Click += new System.EventHandler(this.AddUser_Click);
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.Location = new System.Drawing.Point(18, 167);
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Size = new System.Drawing.Size(94, 20);
            this.PhoneNumber.TabIndex = 5;
            this.PhoneNumber.TextChanged += new System.EventHandler(this.PhoneNumber_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Номер Телефону";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Прізвище";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ім\'я";
            // 
            // UserSurname
            // 
            this.UserSurname.Location = new System.Drawing.Point(18, 102);
            this.UserSurname.Name = "UserSurname";
            this.UserSurname.Size = new System.Drawing.Size(94, 20);
            this.UserSurname.TabIndex = 1;
            // 
            // UserName
            // 
            this.UserName.Location = new System.Drawing.Point(18, 39);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(94, 20);
            this.UserName.TabIndex = 0;
            this.UserName.TextChanged += new System.EventHandler(this.UserName_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(406, 545);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 65);
            this.button2.TabIndex = 1;
            this.button2.Text = "Back To Previous Form";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // DataView
            // 
            this.DataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataView.Location = new System.Drawing.Point(0, 0);
            this.DataView.Name = "DataView";
            this.DataView.Size = new System.Drawing.Size(570, 622);
            this.DataView.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(138, 38);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(114, 21);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged_1);
            // 
            // UsNewName
            // 
            this.UsNewName.Location = new System.Drawing.Point(153, 86);
            this.UsNewName.Name = "UsNewName";
            this.UsNewName.Size = new System.Drawing.Size(97, 20);
            this.UsNewName.TabIndex = 9;
            // 
            // UsNewSurname
            // 
            this.UsNewSurname.Location = new System.Drawing.Point(153, 128);
            this.UsNewSurname.Name = "UsNewSurname";
            this.UsNewSurname.Size = new System.Drawing.Size(96, 20);
            this.UsNewSurname.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(135, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Виберіть користувача";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(196, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Нове ім\'я";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(166, 109);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Нове прізвище";
            // 
            // UsNewNumber
            // 
            this.UsNewNumber.Location = new System.Drawing.Point(153, 167);
            this.UsNewNumber.Name = "UsNewNumber";
            this.UsNewNumber.Size = new System.Drawing.Size(96, 20);
            this.UsNewNumber.TabIndex = 14;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(127, 151);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(125, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "Новий номер телефону";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(173, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Змінити";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(143, 96);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(109, 21);
            this.comboBox2.TabIndex = 11;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.ComboBox2_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(157, 80);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "Виберіть Дзвінок";
            // 
            // TopicOfTheCall
            // 
            this.TopicOfTheCall.Location = new System.Drawing.Point(142, 148);
            this.TopicOfTheCall.Name = "TopicOfTheCall";
            this.TopicOfTheCall.Size = new System.Drawing.Size(108, 20);
            this.TopicOfTheCall.TabIndex = 13;
            // 
            // StatusOfTheCall
            // 
            this.StatusOfTheCall.Location = new System.Drawing.Point(131, 205);
            this.StatusOfTheCall.Name = "StatusOfTheCall";
            this.StatusOfTheCall.Size = new System.Drawing.Size(121, 20);
            this.StatusOfTheCall.TabIndex = 14;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(135, 132);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(117, 13);
            this.label14.TabIndex = 15;
            this.label14.Text = "Змінити тему Дзвінку";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(128, 189);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(124, 13);
            this.label15.TabIndex = 16;
            this.label15.Text = "Змінити статус дзвінка";
            // 
            // CallUpdate
            // 
            this.CallUpdate.Location = new System.Drawing.Point(177, 234);
            this.CallUpdate.Name = "CallUpdate";
            this.CallUpdate.Size = new System.Drawing.Size(75, 23);
            this.CallUpdate.TabIndex = 17;
            this.CallUpdate.Text = "Змінити";
            this.CallUpdate.UseVisualStyleBackColor = true;
            this.CallUpdate.Click += new System.EventHandler(this.CallUpdate_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(406, 479);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(152, 60);
            this.button3.TabIndex = 2;
            this.button3.Text = "Next Form";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 622);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form2";
            this.Text = "User&CallAdding";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button GetResult;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker Time_Of_The_Call;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Type_of_the_Call;
        private System.Windows.Forms.DateTimePicker Date_Of_The_Call;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox Topic_Of_The_Call;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button AddUser;
        private System.Windows.Forms.TextBox PhoneNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UserSurname;
        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.DataGridView DataView;
        private System.Windows.Forms.Button GetResult2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox UsNewSurname;
        private System.Windows.Forms.TextBox UsNewName;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox UsNewNumber;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button CallUpdate;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox StatusOfTheCall;
        private System.Windows.Forms.TextBox TopicOfTheCall;
        private System.Windows.Forms.Button button3;
    }
}