using ClinicMangementSystem.BL;
using ClinicMangementSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicMangementSystem.PL
{
    public partial class UserEntryForm : Form
    {
        private UserBL userBL = new UserBL();
        private UserModel userModel = null;
        public UserEntryForm()
        {
            InitializeComponent();
        }
        public UserEntryForm(UserModel? userToEdit)
        {
            InitializeComponent();
            this.btnSave.Click += new EventHandler(btnSave_Click);
            this.btnCancel.Click += new EventHandler(btnCancel_Click);
            if (userToEdit != null)
            {
                userModel = userToEdit;
                lblTitle.Text = "تعديل المستخدم";
                txtUsername.Text = userModel.Username;
                txtPassowrd.Text = userModel.Password;
                txtFullName.Text = userModel.FullName;
                cmbRole.SelectedItem = userModel.Role;

            }
            else
            {
                lblTitle.Text = "إضافة مستخدم جديد";
                txtUsername.Clear();
                txtPassowrd.Clear();
                txtFullName.Clear();
                cmbRole.SelectedIndex = -1;
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassowrd.Text) || string.IsNullOrWhiteSpace(txtFullName.Text) || cmbRole.SelectedIndex == -1)
            {
                MessageBox.Show("الرجاء ملء جميع الحقول", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            UserModel user = new UserModel
            {
                Username = txtUsername.Text.Trim(),
                Password = txtPassowrd.Text.Trim(),
                FullName = txtFullName.Text.Trim(),
                Role = cmbRole.Text,
                IsActive = true,
                CreatedDate = DateTime.Now
            };
            try
            {
                if (userModel != null)
                {
                    user.UserID = userModel.UserID;
                    userBL.UpdateUser(user);
                    MessageBox.Show("تم تعديل المستخدم بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    userBL.AddUser(user);
                    MessageBox.Show("تم إضافة المستخدم بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.DialogResult = DialogResult.OK;
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء حفظ المستخدم: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {

        }
    }
}
