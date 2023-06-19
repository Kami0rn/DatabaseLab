using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace TrainBook3
{
    public partial class registerTab : Form
    {
        MySqlConnection con = new MySqlConnection("host=localhost;user=root;password=;database=trainproject");
        MySqlCommand comm;
        public static String fname ;

        public registerTab()
        {
            InitializeComponent();

        }

        
        private void clear_data_regis()
        {
            firstName_txt.Text = "";
            lastName_txt.Text = "";
            gender_comboBox.SelectedIndex = 0;
            Age_txt.Text = "";

        }
        private void open_connection()
        {

            con.Open();
            //MessageBox.Show($"MySQL version : {con.ServerVersion}");
        }
        private void clear_Btn_Regis_Click(object sender, EventArgs e)
        {
            clear_data_regis();
        }
        private void Register_Load(object sender, EventArgs e)
        {
            open_connection();
            clear_data_regis();
        }
        

        private void lastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void firstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var f_name = firstName_txt.Text;
            var l_name = lastName_txt.Text;
            var age = Age_txt.Text;
            var gender = gender_comboBox.SelectedIndex;


            comm = con.CreateCommand();
            comm.CommandText = "INSERT INTO `trainproject`.`register` (`register_id`, `first_name`, `last_name`, `age`, `gender`) " +
                   "VALUES (null, @first_name, @last_name, @age, @gender)";


            comm.Parameters.AddWithValue("@first_name", f_name);
            comm.Parameters.AddWithValue("@last_name", l_name);
            comm.Parameters.AddWithValue("@age", age);
            comm.Parameters.AddWithValue("@gender", gender);


            try
            {
                int rowsAffected = comm.ExecuteNonQuery();
                MessageBox.Show("Save Data Completed!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Form2 f2 = new Form2();

            clear_data_regis();
            f2.Show();
        }
    }
}
