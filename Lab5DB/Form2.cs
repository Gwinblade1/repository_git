using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5DB
{
    public partial class Form2 : Form
    {
        string ConnectionString = "Server = 176.104.0.164; Database=Lavriv;User Id = u_student;Password=u_student;";
        public Form2()
        {
            InitializeComponent();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void SplitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GetResult_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();

            SqlCommand comRead2 = new SqlCommand("SELECT * FROM Users", con);

            SqlDataReader DR = comRead2.ExecuteReader();

            DataTable DT = new DataTable();
            DT.Load(DR);

            DataView.DataSource = DT;
            DataView.Refresh();

            con.Close();
        }

        private void UserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddUser_Click(object sender, EventArgs e)
        {
            try
            {
                if (UserName.Text.ToString() == "")
                {
                    MessageBox.Show("Введiть Ім'я");
                    return;
                }
                if (UserSurname.Text.ToString() == "")
                {
                    MessageBox.Show("Введiть Прізвище");
                    return;
                }
                if (PhoneNumber.Text.ToString() == "")
                {
                    MessageBox.Show("Введiть номер телефону");
                    return;
                }


                SqlConnection con = new SqlConnection(ConnectionString);
                con.Open();
                
                string Query = "INSERT INTO Users (Name, Surname, Phone_Number ) VALUES('" + UserName.Text.ToString() + "','" + UserSurname.Text.ToString() + "','" + PhoneNumber.Text.ToString() + "')";

                SqlCommand comAdd = new SqlCommand(Query, con);
                comAdd.ExecuteNonQuery();

                MessageBox.Show("Користувач доданий");

                con.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message.ToString());
            }
            LoadUsers();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (Topic_Of_The_Call.Text.ToString() == "")
                {
                    MessageBox.Show("Введiть тему дзвінку");
                    return;
                }
                if (Type_of_the_Call.Text.ToString() == "")
                {
                    MessageBox.Show("Введiть статус дзвінку");
                    return;
                }
                

                SqlConnection con = new SqlConnection(ConnectionString);
                con.Open();

                string Time = Time_Of_The_Call.Value.Hour.ToString() + ":" + Time_Of_The_Call.Value.Minute.ToString() + ":" + Time_Of_The_Call.Value.Second.ToString();
                string Date = Date_Of_The_Call.Value.Year.ToString() + "-" + Date_Of_The_Call.Value.Month.ToString() + "-" + Date_Of_The_Call.Value.Day.ToString();

                string Query = "INSERT INTO Call (Date_of_Call, Time_of_Call, Topic_of_the_Call, Type_of_the_Call) VALUES('"+Date+"','"+Time+"','"+Topic_Of_The_Call.Text.ToString()+"','"+Type_of_the_Call.Text.ToString() +"')";

                SqlCommand comAdd = new SqlCommand(Query, con);
                comAdd.ExecuteNonQuery();

                MessageBox.Show("Дзвінок доданий");

                con.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message.ToString());
            }
            LoadCalls();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form1 fr1 = new Form1();
            fr1.Show();
            Hide();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();

            SqlCommand comRead3 = new SqlCommand("SELECT * FROM Call", con);

            SqlDataReader DR = comRead3.ExecuteReader();

            DataTable DT = new DataTable();
            DT.Load(DR);

            DataView.DataSource = DT;
            DataView.Refresh();

            con.Close();
        }

        private void PhoneNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            LoadUsers();
            LoadCalls();
        }

        private void LoadUsers()
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();

            SqlCommand comRead = new SqlCommand("SELECT ID, Name, Surname FROM Users", con);

            SqlDataReader DR = comRead.ExecuteReader();


            comboBox1.Items.Clear();

            while (DR.Read())
            {
                Users Us = new Users();
                Us.id = (int)DR[0];
                Us.Name = DR[1].ToString() + " " + DR[2].ToString();
                comboBox1.Items.Add(Us);
                comboBox1.DisplayMember = "Name";
            }
            con.Close();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (UsNewName.Text.ToString() == "")
                {
                    MessageBox.Show("Введiть нове Ім'я");
                    return;
                }
                if (UsNewSurname.Text.ToString() == "")
                {
                    MessageBox.Show("Введiть нове Прізвище");
                    return;
                }
                if (UsNewNumber.Text.ToString() == "")
                {
                    MessageBox.Show("Введiть новий номер телефону");
                    return;
                }


                SqlConnection con = new SqlConnection(ConnectionString);
                con.Open();

                Users us = (Users)comboBox1.SelectedItem;

                if (comboBox1.SelectedItem is null)
                {
                    MessageBox.Show("Виберіть Користувача");
                    return;
                }

                SqlDataAdapter DA = new SqlDataAdapter("UPDATE Users SET Name = '" + UsNewName.Text.ToString() + "', Surname = '" + UsNewSurname.Text.ToString() + "', Phone_Number ='"+UsNewNumber.Text.ToString() + "' WHERE ID = " + us.id.ToString(), con);

                DataSet DS = new DataSet();
                DA.Fill(DS, "Operators");

                MessageBox.Show("Операція зміни виконана");

                con.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message.ToString());
            }
        }

        private void LoadCalls()
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();

            SqlCommand comRead = new SqlCommand("SELECT * FROM Call", con);

            SqlDataReader DR = comRead.ExecuteReader();

            comboBox2.Items.Clear();
           
            while (DR.Read())
            {
                Calls Cl = new Calls();
                Cl.id = (int)DR[0];
                Cl.Inf = DR[3].ToString() + "-" + DR[4].ToString() ;
                comboBox2.Items.Add(Cl) ;
                comboBox2.DisplayMember = "Inf";
            }
            con.Close();
        }

        private void CallUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (TopicOfTheCall.Text.ToString() == "")
                {
                    MessageBox.Show("Введiть нову тему дзвінку");
                    return;
                }
                if (StatusOfTheCall.Text.ToString() == "")
                {
                    MessageBox.Show("Введiть новий статус дзвінку");
                    return;
                }

                SqlConnection con = new SqlConnection(ConnectionString);
                con.Open();

                Calls cl = (Calls)comboBox2.SelectedItem;

                if (comboBox2.SelectedItem is null)
                {
                    MessageBox.Show("Виберіть Дзвінок");
                    return;
                }

                SqlDataAdapter DA = new SqlDataAdapter("UPDATE Call SET Topic_of_the_Call = '" + TopicOfTheCall.Text.ToString() + "', Type_of_the_Call = '" + StatusOfTheCall.Text.ToString() + "' WHERE ID = " + cl.id.ToString(), con);

                DataSet DS = new DataSet();
                DA.Fill(DS, "Operators");

                MessageBox.Show("Операція зміни виконана");

                con.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message.ToString());
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Form3 fr3 = new Form3();
            fr3.Show();
            Hide();
        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
