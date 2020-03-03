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
    public partial class Form3 : Form
    {
        string ConnectionString = "Server = 176.104.0.164; Database=Lavriv;User Id = u_student;Password=u_student;";
        public Form3()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form2 fr2 = new Form2();
            fr2.Show();
            Hide();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       
        private void LoadCalls()
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();

            SqlCommand comRead = new SqlCommand("SELECT * FROM Call", con);

            SqlDataReader DR = comRead.ExecuteReader();

            comboBox3.Items.Clear();

            while (DR.Read())
            {
                Calls Cl = new Calls();
                Cl.id = (int)DR[0];
                Cl.Inf = DR[4].ToString();
                comboBox3.Items.Add(Cl);
                comboBox3.DisplayMember = "Inf";
            }
            con.Close();
        }
        private void LoadHotlines()
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();

            SqlCommand comRead = new SqlCommand("SELECT * FROM Hotlines", con);

            SqlDataReader DR = comRead.ExecuteReader();


            comboBox1.Items.Clear();

            while (DR.Read())
            {
                Hotlines HL = new Hotlines();
                HL.id = (int)DR[0];
                HL.Name = DR[1].ToString();
                comboBox1.Items.Add(HL);
                comboBox1.DisplayMember = "Name";
            }
            con.Close();
        }
        private void LoadHotlinesReport2()
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();

            SqlCommand comRead = new SqlCommand("SELECT * FROM Hotlines", con);

            SqlDataReader DR = comRead.ExecuteReader();


            comboBox4.Items.Clear();

            while (DR.Read())
            {
                Hotlines HL = new Hotlines();
                HL.id = (int)DR[0];
                HL.Name = DR[1].ToString();
                comboBox4.Items.Add(HL);
                comboBox4.DisplayMember = "Name";
            }
            con.Close();
        }
        private void LoadOperators()
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();

            SqlCommand comRead = new SqlCommand("SELECT ID, Name, Surname FROM Operators", con);

            SqlDataReader DR = comRead.ExecuteReader();


            comboBox2.Items.Clear();

            while (DR.Read())
            {
                Operators OP = new Operators();
                OP.id = (int)DR[0];
                OP.Name = DR[1].ToString();
                comboBox2.Items.Add(OP);
                comboBox2.DisplayMember = "Name";
            }
            con.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            LoadHotlines();
            LoadOperators();
            LoadCalls();
            LoadHotlinesReport2();
        }

        private void Report1_Click(object sender, EventArgs e)
        {
            try
            {
                Hotlines hl = (Hotlines)comboBox1.SelectedItem;
                Operators oper = (Operators)comboBox2.SelectedItem;
                if (comboBox1.SelectedItem is null)
                {
                    MessageBox.Show("Виберіть Гарячу Лінію");
                    return;
                }
                if (comboBox2.SelectedItem is null)
                {
                    MessageBox.Show("Виберіть Оператора");
                    return;
                }

                string DateF = DateFrom.Value.Year.ToString() + "-" + DateFrom.Value.Month.ToString() + "-" + DateFrom.Value.Day.ToString();
                string DateT = DateTo.Value.Year.ToString() + "-" + DateTo.Value.Month.ToString() + "-" + DateTo.Value.Day.ToString();

                SqlConnection con = new SqlConnection(ConnectionString);
                con.Open();


                string Query = "SELECT  COUNT(Call.ID) AS Counter, Operators.Name, Operators.Surname, Hotlines.ID, Hotlines.Name FROM Call, Call_Fixation, Hotlines, Operators WHERE Call_Fixation.id_call = Call.ID AND Call_Fixation.id_operator = Operators.ID AND Hotlines.ID = Call_Fixation.id_hotline AND Hotlines.Name = '" + hl.Name.ToString() + "' AND Operators.Name = '" + oper.Name.ToString() + "' AND Call.Date_of_Call BETWEEN '" + DateF + "' AND '" + DateT + "' GROUP BY Call.ID, Hotlines.ID, Hotlines.Name, Operators.Name,Operators.Surname";

                SqlCommand com = new SqlCommand(Query, con);

                SqlDataReader DR = com.ExecuteReader();

                DataTable DT = new DataTable();
                DT.Load(DR);

                DataView.DataSource = DT;
                DataView.Refresh();
                con.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message.ToString());
            }
            LoadHotlines();
            LoadOperators();

        }

        private void Report2_Click(object sender, EventArgs e)
        {
            try
            {
                Hotlines hl = (Hotlines)comboBox4.SelectedItem;
                Calls cl = (Calls)comboBox3.SelectedItem;

                if (comboBox3.SelectedItem is null)
                {
                    MessageBox.Show("Виберіть  Статус Дзвінка");
                    return;
                }
                if (comboBox4.SelectedItem is null)
                {
                    MessageBox.Show("Виберіть Гарячу Лінію");
                    return;
                }

                SqlConnection con = new SqlConnection(ConnectionString);
                con.Open();

                string DateF = DateFrom.Value.Year.ToString() + "-" + DateFrom.Value.Month.ToString() + "-" + DateFrom.Value.Day.ToString();
                string DateT = DateTo.Value.Year.ToString() + "-" + DateTo.Value.Month.ToString() + "-" + DateTo.Value.Day.ToString();

                string Query = "SELECT  Hotlines.Name,Operators.Name, Operators.Surname, COUNT(Call.ID) FROM Call, Call_Edit, Hotlines, Operators WHERE Call_Edit.ID = Call.ID AND Call_Edit.id_operator = Operators.ID AND Call_Edit.id_call = Call.ID AND Hotlines.Name = '" + hl.Name.ToString() + "' AND(Call.Type_of_the_Call = '" +cl.Inf.ToString()+"') GROUP BY Hotlines.Name, Operators.Name, Operators.Surname, Call.ID";

                SqlCommand com = new SqlCommand(Query, con);

                SqlDataReader DR = com.ExecuteReader();

                DataTable DT = new DataTable();
                DT.Load(DR);

                DataView.DataSource = DT;
                DataView.Refresh();
                con.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message.ToString());
            }
            LoadHotlines();
            LoadCalls();
        }

        private void ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Report3_Click(object sender, EventArgs e)
        {
            try
            {
                Hotlines hl = (Hotlines)comboBox1.SelectedItem;
                Operators oper = (Operators)comboBox2.SelectedItem;

                SqlConnection con = new SqlConnection(ConnectionString);
                con.Open();

                string StartTime = Report3Time.Value.Hour.ToString() + ":" + Report3Time.Value.Minute.ToString() + ":" + Report3Time.Value.Second.ToString();
                string FinishTime = Report3TimeTo.Value.Hour.ToString() + ":" + Report3TimeTo.Value.Minute.ToString() + ":" + Report3TimeTo.Value.Second.ToString();

                string Query = "SELECT Hotlines.Name, Count(Call.ID) AS 'COUNT' FROM Call, Call_Fixation, Hotlines WHERE Call.ID = Call_Fixation.id_call AND Call_Fixation.id_hotline = Hotlines.ID AND Call.Time_of_Call BETWEEN '"+ StartTime + "'AND '"+ FinishTime + "' GROUP BY  Hotlines.Name";

                SqlCommand com = new SqlCommand(Query, con);

                SqlDataReader DR = com.ExecuteReader();

                DataTable DT = new DataTable();
                DT.Load(DR);

                DataView.DataSource = DT;
                DataView.Refresh();
                con.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message.ToString());
            }
        }
    }
}


