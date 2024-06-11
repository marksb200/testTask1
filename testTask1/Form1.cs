using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Configuration.Provider;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using System.Deployment.Internal;
namespace testTask1
{
    public partial class Form1 : Form
    {
        static public SqlConnection sqlConnection = null;
        private SqlDataAdapter adapter = null;
        private DataTable table = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["TestDB"].ConnectionString);
            sqlConnection.Open();
            if (sqlConnection.State == ConnectionState.Open)
            {
                MessageBox.Show("The connection is established!");
            }
            else 
            {
                MessageBox.Show("Connection is NOT established!");
            }
            adapter = new SqlDataAdapter("SELECT * FROM PersonT2", sqlConnection);
            table = new DataTable();
            adapter.Fill(table);
            adapter = new SqlDataAdapter("SELECT COUNT(*) FROM PersonT2", sqlConnection);
            dataGW.DataSource = table;
            outData.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            outData.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            numericUpDown1.Maximum = dataGW.RowCount - 1;
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand(
                "INSERT INTO [PersonT2] (Name, Weight, Height, Age, Vision, Bed_habits, Disease_therapist, Psychiatrist_disease) VALUES (@Name, @Weight, @Height, @Age, @Vision, @Bed_habits, @Disease_therapist, @Psychiatrist_disease)",
                sqlConnection);

            command.Parameters.AddWithValue("Name", NamePerson.Text);

            bool resBW = int.TryParse(Weight.Text, out int resW);

            if (!resBW || resW < 0) 
            {
                MessageBox.Show("Error in filling in the field: Weight. This is not a positive integer!");
                return;
            }
            command.Parameters.AddWithValue("Weight", resW);

            bool resBH = int.TryParse(Height.Text, out int resH);
            if (!resBH || resH < 0)
            {
                MessageBox.Show("Error in filling in the field: Height. This is not a positive integer!");
                return;
            }
            command.Parameters.AddWithValue("Height", resH);

            bool resBA = int.TryParse(Age.Text, out int resA);
            if (!resBA || resA < 0)
            {
                MessageBox.Show("Error in filling in the field: Age. This is not a positive integer!");
                return;
            }
            command.Parameters.AddWithValue("Age", resA);

            bool resBV = float.TryParse(Vision.Text, out float resV);
            if (!resBV || resV < 0 || resV > 1)
            {
                MessageBox.Show("Error in filling in the field: Vision. This is not float 0.0 - 1.0!");
                return;
            }
            command.Parameters.AddWithValue("Vision", resV);

            command.Parameters.AddWithValue("Bed_habits", Bed_habits.Text);

            string sChek1 = String.Join(" ", Disease_therapist.CheckedItems.Cast<object>().Select(p => p.ToString()).ToArray());
            string sChek2 = String.Join(" ", Psychiatrist_disease.CheckedItems.Cast<object>().Select(p => p.ToString()).ToArray());
            command.Parameters.AddWithValue("Disease_therapist", sChek1);
            command.Parameters.AddWithValue("Psychiatrist_disease", sChek2);

            MessageBox.Show(command.ExecuteNonQuery().ToString() + " request has been sent to the database");
        }

        private void upData_Click(object sender, EventArgs e)
        {
            table.Clear();
            adapter.Fill(table);
            dataGW.DataSource = table;
        }
        static class Standards 
        {
            static public string standartWeight(int weight) 
            {
                if (weight >= 75 && weight <= 90) 
                {
                    return "good";
                }
                if ((weight >= 70 && weight < 75) || (weight > 90 && weight <= 100))
                {
                    return "satisfactory";
                }
                if (weight > 100 || weight < 70)
                {
                    return "unsatisfactory";
                }
                return "undefined";
            }
            static public string standartHight(int hight)
            {
                if (hight >= 170 && hight <= 185)
                {
                    return "good";
                }
                if ((hight >= 160 && hight < 170) || (hight > 185 && hight <= 190))
                {
                    return "satisfactory";
                }
                if (hight > 190 || hight < 160)
                {
                    return "unsatisfactory";
                }
                return "undefined";
            }
            static public string standartAge(int age)
            {
                if (age >= 25 && age <= 35)
                {
                    return "good";
                }
                if ((age >= 23 && age < 25) || (age > 35 && age <= 37))
                {
                    return "satisfactory";
                }
                if (age > 37 || age < 23)
                {
                    return "unsatisfactory";
                }
                return "undefined";
            }
            static public string standartVision(float vision)
            {
                if (vision == 1)
                {
                    return "good";
                }
                if (vision < 1)
                {
                    return "unsatisfactory";
                }
                return "undefined";
            }
            static public string standartBadHabits(string bh)
            {
                if (!bh.Contains("smoke"))
                {
                    return "good";
                }
                if (bh.Contains("smoke"))
                {
                    return "unsatisfactory";
                }
                return "undefined";
            }
            static public string standartTherapistDisease(string td)
            {
                string[] w = td.Split(' ');
                if (w.Count() <= 2)
                {
                    return "good";
                }
                if (w.Count() == 3)
                {
                    return "satisfactory";
                }
                if (w.Count() > 3)
                {
                    return "unsatisfactory";
                }
                return "undefined";
            }
            static public string standartPsychiatristDisease(string pd)
            {
                string[] w = pd.Split(' ');
                if (w.Count() == 0)
                {
                    return "good";
                }
                if (w.Count() == 1)
                {
                    return "satisfactory";
                }
                if (w.Count() > 1)
                {
                    return "unsatisfactory";
                }
                return "undefined";
            }
        }
        private void resTests_Click(object sender, EventArgs e)
        {
            int numeric = (int)numericUpDown1.Value;
            outData.Rows[0].Cells[0].Value = numeric;
            int countSat = 0;
            int countUnSat = 0;
            testWeightBH(numeric);
            testStrange(numeric);
            testMathematical(numeric);
            testCommon(numeric);
            if (countSat < 3 && countUnSat == 0)
            {
                MessageBox.Show("Condidat suitable!");
            }
            else
            {
                MessageBox.Show("Condidat unsuitable! He have unsatisfactory result or satisfactory result > 3");
            }
            void testWeightBH(int id)
            {
                SqlCommand command = new SqlCommand(
                $"SELECT Weight, Bed_habits, Name, Disease_therapist FROM PersonT2 WHERE id = {id}",
                sqlConnection);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    string name = reader["Name"].ToString();
                    int weight = Convert.ToInt32(reader["Weight"]);
                    string bedHabits = reader["Bed_habits"].ToString();
                    string therapistDisease = reader["Disease_therapist"].ToString();
                    if ((therapistDisease.Contains("cold") || therapistDisease.Contains("virus")) && weight > 110 && !bedHabits.Contains("smoke") && weight < 120)
                    {
                        outData.Rows[0].Cells[1].Value = $"Condidat {name} have a problem! Problems: weight = {weight} > 110; Disease_therapist: {therapistDisease}(cold/virus)";
                        countSat++;
                    }
                    if ((therapistDisease.Contains("cold") || therapistDisease.Contains("virus")) && bedHabits.Contains("smoke") && (weight > 120 || weight < 60)) 
                    {
                        outData.Rows[0].Cells[1].Value = $"Condidat {name} is NOT suitable! Problems: Disease_therapist: {therapistDisease}(cold/virus); Bed_habits: {bedHabits}(smoke); Weight: {weight} >120 or <60";
                        countUnSat++;
                    }
                    else
                    {
                        outData.Rows[0].Cells[1].Value = $"Condidat {name} is suitable";
                    }
                }
                reader.Close();
            }
            void testStrange(int id)
            {
                SqlCommand command = new SqlCommand(
                $"SELECT Name, Age FROM PersonT2 WHERE id = {id}",
                sqlConnection);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    string name = reader["Name"].ToString();
                    int age = Convert.ToInt32(reader["Age"]);
                    if (name[0] == 'П')
                    {
                        outData.Rows[0].Cells[2].Value = $"Condidat {name} is suitable";
                    }
                    if (name[0] != 'П' && age > 68)
                    {
                        outData.Rows[0].Cells[2].Value = $"Condidat {name} have a problems. Problems: Name = {Name} does not begin with П; Age : {age} > 68";
                        countSat++;
                    }
                    else 
                    {
                        outData.Rows[0].Cells[2].Value = $"Condidat {name} is NOT suitable! Problems: does not satisfy well and satisfactorily";
                        countUnSat++;
                    }
                }
                reader.Close();
            }
            void testMathematical(int id) 
            {
                SqlCommand command = new SqlCommand(
                $"SELECT Name, Height, Disease_therapist FROM PersonT2 WHERE id = {id}",
                sqlConnection);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    string name = reader["Name"].ToString();
                    int height = Convert.ToInt32(reader["Height"]);
                    string therapistDisease = reader["Disease_therapist"].ToString();
                    if (height % 2 == 0 && height % 3 != 0 && !therapistDisease.Contains("cold"))
                    {
                        outData.Rows[0].Cells[3].Value = $"Condidat {name} is suitable";
                    }
                    if (height % 3 == 0 && therapistDisease.Contains("cold"))
                    {
                        outData.Rows[0].Cells[3].Value = $"Condidat {name} is NOT suitable! Problems: Height = {height} % 3 = 0; Disease_therapist: {therapistDisease}(cold)";
                        countUnSat++;
                    }
                    else
                    {
                        outData.Rows[0].Cells[3].Value = $"Condidat {name} have a problems. Problems: height % 2 != 0";
                        countSat++;
                    }
                }
                reader.Close();
            }
            void testCommon(int id) 
            {
                SqlCommand command = new SqlCommand(
                $"SELECT Name, Height, Weight, Age, Vision, Bed_habits, Disease_therapist, Psychiatrist_disease FROM PersonT2 WHERE id = {id}",
                sqlConnection);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    string name = reader["Name"].ToString();
                    int height = Convert.ToInt32(reader["Height"]);
                    int weight = Convert.ToInt32(reader["Weight"]);
                    int age = Convert.ToInt32(reader["Age"]);
                    float vision = Convert.ToInt32(reader["Vision"]);
                    string bedHabits = reader["Bed_habits"].ToString(); 
                    string psychiatristDisease = reader["Psychiatrist_disease"].ToString();
                    string therapistDisease = reader["Disease_therapist"].ToString();
                    Dictionary<string, string> commonAnsw = new Dictionary<string, string>
                    {
                        { "Height", Standards.standartHight(height) },
                        { "Weight", Standards.standartWeight(weight) },
                        { "Age", Standards.standartAge(age) },
                        { "Vision", Standards.standartVision(vision) },
                        { "Bed_habits", Standards.standartBadHabits(bedHabits) },
                        { "Psychiatrist_disease", Standards.standartPsychiatristDisease(psychiatristDisease) },
                        { "Disease_therapist", Standards.standartTherapistDisease(therapistDisease) }
                    };
                    Dictionary<string, int> valueCounts = new Dictionary<string, int>();
                    foreach (var kvp in commonAnsw)
                    {
                        string value = kvp.Value;
                        if (valueCounts.ContainsKey(value))
                        {
                            valueCounts[value]++;
                        }
                        else
                        {
                            valueCounts[value] = 1;
                        }
                    }
                    foreach (var kvp in valueCounts)
                    {
                        if (kvp.Key == "satisfactory") 
                        {
                            countSat += kvp.Value;
                        }
                        if(kvp.Key == "unsatisfactory")
                        {
                            countUnSat += kvp.Value;
                        }
                    }
                    StringBuilder a = new StringBuilder();
                    foreach (var el in commonAnsw) 
                    {
                        a.Append($"{ el.Key} : { el.Value};\n");
                    }
                    outData.Rows[0].Cells[4].Value = a.ToString();
                }
                reader.Close();
            }
        }
    }
}