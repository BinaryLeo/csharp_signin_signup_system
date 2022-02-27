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
using Npgsql;
namespace Login_and_Register_System
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();


        }
     
        NpgsqlConnection conn = new  NpgsqlConnection(ConfigurationManager.AppSettings.Get("MyConnection"));
        NpgsqlCommand cmd = new NpgsqlCommand();
        NpgsqlDataAdapter da = new NpgsqlDataAdapter();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void registrationButton_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text == "" && txtPassword.Text == "" && txtComPassword.Text == "")
            {
                MessageBox.Show("Username and Password fields are empty", "Sign Up Failed", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else if(txtPassword.Text == txtComPassword.Text)
            {
                try
                {
                 conn.Open();
                    MessageBox.Show("Connection opened");
                    string register = "INSERT INTO csharp_user (username,password) VALUES ('" + txtUsername.Text+"','"+txtPassword.Text+"')";
                    cmd = new NpgsqlCommand( register, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
