using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Lab5DB
{
    public partial class Form1 : Form
    {
        string ConnectionString = "Server = 176.104.0.164; Database=Lavriv;User Id = u_student;Password=u_student;";

        public Form1()
        {
            InitializeComponent();
        }

        private void SplitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GetResult_Click(object sender, EventArgs e)
        {
            
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Add_Click();
        }
        private void Add_Click()
        {
            try
            {
                if (OperatorName.Text.ToString() == "")
                {
                    MessageBox.Show("Введiть ім'я");
                    return;
                }
                if (OperatorSurname.Text.ToString() == "")
                {
                    MessageBox.Show("Введiть прiзвище");
                    return;
                }
                if (Workplace_Number.Text.ToString() == "")
                {
                    MessageBox.Show("Введiть номер робочого мiсця");
                    return;
                }

                SqlConnection con = new SqlConnection(ConnectionString);
                con.Open();

                string Query = "INSERT INTO Operators (Name, Surname, Workplace_Number) VALUES('" + OperatorName.Text.ToString() + "','" + OperatorSurname.Text.ToString() + "','" + Workplace_Number.Text.ToString() + "')";

                SqlCommand comAdd = new SqlCommand(Query, con);
                comAdd.ExecuteNonQuery();

                MessageBox.Show("Оператор доданий");

                con.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message.ToString());
            }
            LoadOperators();
        }

        private void AddHL_Click(object sender, EventArgs e)
        {
            try
            {
                if (HotLineName.Text.ToString() == "")
                {
                    MessageBox.Show("Введiть нову назву");
                    return;
                }
               
                SqlConnection con = new SqlConnection(ConnectionString);
                con.Open();

                string StartTime = HLStartTime.Value.Hour.ToString() + ":" + HLStartTime.Value.Minute.ToString() + ":" + HLStartTime.Value.Second.ToString();               
                string FinishTime = HLFinishTime.Value.Hour.ToString() + ":" + HLFinishTime.Value.Minute.ToString() + ":" + HLFinishTime.Value.Second.ToString();         
                string Date = DateOfOpening.Value.Year.ToString() + "-" + DateOfOpening.Value.Month.ToString() + "-" + DateOfOpening.Value.Day.ToString();          

                string Query = "INSERT INTO Hotlines (Name, Work_start_time, Work_end_time, Date_of_opening) VALUES('" + HotLineName.Text.ToString() + "','" + StartTime + "','" + FinishTime + "','" + Date + "')";

                SqlCommand comAdd = new SqlCommand(Query, con);
                comAdd.ExecuteNonQuery();

                MessageBox.Show("Гаряча лiнiя додана");

                con.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message.ToString());
            }
            LoadHotlines();
        }

        private void HotLineName_TextChanged(object sender, EventArgs e)
        {

        }

        private void HLStartTime_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();

            SqlCommand comRead1 = new SqlCommand("SELECT * FROM Operators", con);

            SqlDataReader DR = comRead1.ExecuteReader();

            DataTable Op = new DataTable();
            Op.Load(DR);

            DataView1.DataSource = Op;
            DataView1.Refresh();

            con.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();

            SqlCommand comRead2 = new SqlCommand("SELECT * FROM Hotlines", con);

            SqlDataReader DR = comRead2.ExecuteReader();

            DataTable Hl = new DataTable();
            Hl.Load(DR);

            DataView1.DataSource = Hl;
            DataView1.Refresh();

            con.Close();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Form2 fr2 = new Form2();
            fr2.Show();
            Hide();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
           
        }

        private void DateOfOpening_ValueChanged(object sender, EventArgs e)
        {

        }

        private void UpdateOpNameAndSurname_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (OperNameChange.Text.ToString() == "")
                {
                    MessageBox.Show("Введiть нове ім'я ");
                    return;
                }
                
                if (OperSurnameChange.Text.ToString() == "")
                {
                    MessageBox.Show("Введiть нове прізвище");
                    return;
                }
                SqlConnection con = new SqlConnection(ConnectionString);
                con.Open();

                Operators oper = (Operators)comboBox1.SelectedItem;

                if (comboBox1.SelectedItem is null)
                {
                    MessageBox.Show("Виберіть Оператора");
                    return;
                }

                SqlDataAdapter DA = new SqlDataAdapter("UPDATE Operators SET Name = '"+ OperNameChange.Text.ToString() +"', Surname = '"+ OperSurnameChange.Text.ToString() +"' WHERE ID = " + oper.id.ToString(), con);

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

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadOperators();
            LoadHotlines();
        }

        private void LoadOperators()
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();

            SqlCommand comRead = new SqlCommand("SELECT ID, Name, Surname FROM Operators", con);

            SqlDataReader DR = comRead.ExecuteReader();


            comboBox1.Items.Clear();

            while (DR.Read())
            {
                Operators OP = new Operators();
                OP.id = (int)DR[0];
                OP.Name = DR[1].ToString() + " " + DR[2].ToString();
                comboBox1.Items.Add(OP);
                comboBox1.DisplayMember = "Name";
            }
            con.Close();
        }

        private void DataView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Label11_Click(object sender, EventArgs e)
        {

        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
         
        private void LoadHotlines()
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();

            SqlCommand comRead = new SqlCommand("SELECT * FROM Hotlines", con);

            SqlDataReader DR = comRead.ExecuteReader();


            comboBox2.Items.Clear();

            while (DR.Read())
            {
                Hotlines HL = new Hotlines();
                HL.id = (int)DR[0];
                HL.Name = DR[1].ToString();
                comboBox2.Items.Add(HL);
                comboBox2.DisplayMember = "Name";
            }
            con.Close();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            try
            {
                Hotlines hl = (Hotlines)comboBox2.SelectedItem;
                if (comboBox2.SelectedItem is null)
                {
                    MessageBox.Show("Виберіть Гарячу Лінію");
                    return;
                }
                if (HLNameChange.Text.ToString() == "")
                {
                    MessageBox.Show("Введiть назву");
                    return;
                }
                
                SqlConnection con = new SqlConnection(ConnectionString);
                con.Open();

                SqlDataAdapter DA = new SqlDataAdapter("UPDATE Hotlines SET Name = '" + HLNameChange.Text.ToString() +"'  WHERE ID = " + hl.id.ToString(), con);

                DataSet DS = new DataSet();
                DA.Fill(DS, "Hotlines");

                MessageBox.Show("Операція зміни виконана");

                con.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message.ToString());
            }
        }

        private void HLFinishTime_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
