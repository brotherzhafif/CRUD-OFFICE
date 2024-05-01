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

namespace CRUD_CRUD_CRUD
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();

        }
        SqlConnection cnn = new SqlConnection(@"Data Source=BROTHERZHAFIF\SQLEXPRESS;Initial Catalog=esemka_laundry;Integrated Security=True");

        private void Login_Load(object sender, EventArgs e)
        {
           
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(user_txt.Text) && !String.IsNullOrEmpty(pass_txt.Text))
            {
                if (!string.IsNullOrEmpty(cnn.ConnectionString))
                {
                    
                    string query = "SELECT * FROM employee WHERE email_employee='" + user_txt.Text + "' OR name_employee='" + user_txt.Text + "' AND password_employee='" + pass_txt.Text + "'";
                    SqlDataAdapter da = new SqlDataAdapter(query, cnn);
                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {   
                        MessageBox.Show("Login Berhasil");
                        Home home = new Home(user_txt.Text);
                        home.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Login Gagal");
                    }

                }
                else
                {
                    MessageBox.Show("Konekasi Gagal");
                }
            }
            else
            {
                MessageBox.Show("Tolong isi semua kolom");
            }
            
        }
    }
}
