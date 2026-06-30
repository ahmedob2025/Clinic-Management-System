using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicMangementSystem.BL;
using ClinicMangementSystem.Models;

namespace ClinicMangementSystem.PL
{

    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtUsername.Text) ||
                    string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    lblError.Text = "الرجاء إدخال اسم المستخدم وكلمة المرور";
                    lblError.Visible = true;
                    return;
                }

                UserBL usr = new UserBL();

                DataTable dt = usr.VerifyUser(
                    txtUsername.Text.Trim(),
                    txtPassword.Text.Trim());

                if (dt != null && dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];

                    Program.CurrentUser = new UserModel()
                    {
                        UserID = Convert.ToInt32(row["UserID"]),
                        Username = row["Username"].ToString(),
                        Role = row["Role"].ToString()
                    };

                    lblError.Visible = false;

                    if (Program.CurrentUser.Role == "Admin")
                    {
                        AdminDashboard frm = new AdminDashboard();
                        frm.Show();
                    }
                    else if (Program.CurrentUser.Role == "Reception")
                    {
                        ReceptionDashboard frm = new ReceptionDashboard();
                        frm.Show();
                    }
                    else
                    {
                        MessageBox.Show(
                            "الدور الموجود في قاعدة البيانات غير معروف: "
                            + Program.CurrentUser.Role);
                        return;
                    }

                    this.Hide();
                }
                else
                {
                    lblError.Text = "اسم المستخدم أو كلمة المرور غير صحيحة";
                    lblError.Visible = true;
                    txtPassword.Clear();
                    txtPassword.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.ToString(),
                    "خطأ أثناء تسجيل الدخول",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}   

