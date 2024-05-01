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
    public partial class Home : Form
    {
        public Home(String Value)
        {
            InitializeComponent();
            lbl_name_home.Text = Value;         
        }

        public void employee_read()
        {
            string sql_read = "SELECT id_job ,id_emploee ,password_employee " +
                    ",name_employee ,email_employee ,address_employee ,phone_number_employee " +
                    ",date_of_birth_employee ,salary_employee FROM employee";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql_read, cnn);
            da.Fill(dt);

            DGV_employee.DataSource = dt;
        }

        private void Home_Load(object sender, EventArgs e)
        {

            employee_read();
            lbl_time.Text = DateTime.Now.ToString();
        }

        SqlConnection cnn = new SqlConnection(@"Data Source=BROTHERZHAFIF\SQLEXPRESS;Initial Catalog=esemka_laundry;Integrated Security=True");

        string metode;

        private void method(object sender, EventArgs e)
        {
            // Buat Label

            lbl_address.Visible = true;
            lbl_confirm_password.Visible = true;
            lbl_email.Visible = true;
            lbl_job.Visible = true;
            lbl_name.Visible = true;
            lbl_password.Visible = true;
            lbl_phone_number.Visible = true;
            lbl_salary.Visible = true;
            lbl_birth_DTP.Visible = true;

            // Buat INPUT SEMUA

            txt_address.Visible = true;
            txt_confirm_password.Visible = true;
            txt_email.Visible = true;
            txt_job.Visible = true;
            txt_name.Visible = true;
            txt_password.Visible = true;
            txt_phone_number.Visible = true;
            txt_salary.Visible = true;
            txt_birth_DTP.Visible = true;

            // INI BUAT BUTTON

            btn_save.Visible = true;
            btn_cancel.Visible = true;

            // YANG DI HIDE

            btn_update.Visible = false;
            btn_insert.Visible = false;
            btn_delete.Visible = false;

            if (sender == btn_insert)
            {
                metode = "Insert";
            }
            else if (sender == btn_delete)
            {
                metode = "Delete";
            }
            else if (sender == btn_update)
            {
                metode = "Update";
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            // DEKLARASI TEXT BUAT INPUT

            string address = txt_address.Text.ToString();
            string confirm_password = txt_confirm_password.Text.ToString();
            string email = txt_email.Text.ToString();
            string job = txt_job.Text.ToString();
            string name = txt_name.Text.ToString();
            string password = txt_password.Text.ToString();
            string phone_number = txt_phone_number.Text.ToString();
            string salary = txt_salary.Text.ToString();
            string birth = txt_birth_DTP.Text.ToString();

            // JIKA ISINYA NULL

            if (!string.IsNullOrEmpty(txt_address.Text) 
                && !string.IsNullOrEmpty(txt_confirm_password.Text)
                && !string.IsNullOrEmpty(txt_email.Text)
                && !string.IsNullOrEmpty(txt_job.Text)
                && !string.IsNullOrEmpty(txt_name.Text)
                && !string.IsNullOrEmpty(txt_password.Text)
                && !string.IsNullOrEmpty(txt_phone_number.Text)
                && !string.IsNullOrEmpty(txt_salary.Text) 
                && !string.IsNullOrEmpty(txt_birth_DTP.Text))
            {
                if (metode == "Insert")
                {
                    string sql_insert = "INSERT INTO employee" +
                        "(id_job, password_employee, name_employee, email_employee, address_employee, " +
                        "phone_number_employee, date_of_birth_employee, salary_employee)" +
                        "VALUES ('" + job + "','" + password + "','" + name + "','" + email + "','" + address + "'," +
                        "'" + phone_number + "','" + birth + "','" + salary + "')";

                    SqlCommand cmd_insert = new SqlCommand(sql_insert, cnn);

                    try
                    {
                        cnn.Open();
                        cmd_insert.ExecuteReader();
                        cnn.Close();

                        DGV_employee.DataSource = null;
                        MessageBox.Show("Insert Data Berhasil");
                        employee_read();
                    }
                    catch (Exception ex)
                    {
                        cnn.Close();
                        MessageBox.Show(ex.Message);
                    }
                }
                else if (metode == "Update")
                {
                    string sql_update = "UPDATE employee " +
                        "SET id_job='" + job + "', password_employee='" + password + "', name_employee='" + name + "', email_employee='" + email + "', address_employee='" + address + "', " +
                        "phone_number_employee='" + phone_number + "', date_of_birth_employee='" + birth + "', salary_employee='" + salary + "' WHERE id_emploee='" + txt_id_employee.Text + "'";
                    SqlCommand cmd_update = new SqlCommand(sql_update, cnn);

                    try
                    {
                        cnn.Open();
                        cmd_update.ExecuteReader();
                        cnn.Close();

                        DGV_employee.DataSource = null;
                        MessageBox.Show("Update Data Berhasil");
                        employee_read();
                    }
                    catch (Exception ex)
                    {
                        cnn.Close();
                        MessageBox.Show(ex.Message);
                    }
                }
                else if (metode == "Delete")
                {
                    string sql_delete = "DELETE FROM employee WHERE id_emploee='" + txt_id_employee.Text + "'";
                    SqlCommand cmd_delete = new SqlCommand(sql_delete, cnn);

                    try
                    {
                        cnn.Open();
                        cmd_delete.ExecuteNonQuery();
                        cnn.Close();

                        DGV_employee.DataSource = null;
                        MessageBox.Show("Hapus Data Berhasil");
                        employee_read();
                    }
                    catch (Exception ex)
                    {
                        cnn.Close();
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Tolong Isi Semua Kolom");
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            // Buat Label

            lbl_address.Visible = false;
            lbl_confirm_password.Visible = false;
            lbl_email.Visible = false;
            lbl_job.Visible = false;
            lbl_name.Visible = false;
            lbl_password.Visible = false;
            lbl_phone_number.Visible = false;
            lbl_salary.Visible = false;
            lbl_birth_DTP.Visible = false;

            // Buat INPUT SEMUA

            txt_address.Visible = false;
            txt_confirm_password.Visible = false;
            txt_email.Visible = false;
            txt_job.Visible = false;
            txt_name.Visible = false;
            txt_password.Visible = false;
            txt_phone_number.Visible = false;
            txt_salary.Visible = false;
            txt_birth_DTP.Visible = false;

            // INI BUAT BUTTON

            btn_save.Visible = false;
            btn_cancel.Visible = false;

            // YANG DI HIDE

            btn_update.Visible = true;
            btn_insert.Visible = true;
            btn_delete.Visible = true;
        }

        private void DGV_employee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
