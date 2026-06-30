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
    public partial class UsersForm : Form
    {
        private UserBL userBL = new UserBL();
        private int currentUserId = 0;

        public UsersForm()
        {
            InitializeComponent();
            
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;

            LoadAllUsers();
        }
        private void LoadAllUsers()
        {
            DataTable dt = userBL.GetAllUsers();
            dgvUsers.DataSource = dt;
            dgvUsers.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void dgvUsers_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count > 0)
            {
                currentUserId = Convert.ToInt32(dgvUsers.SelectedRows[0].Cells["UserID"].Value);
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
            }
            else
            {
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (UserEntryForm userEntryForm = new UserEntryForm(null))
            {
                if (userEntryForm.ShowDialog() == DialogResult.OK)
                {
                    LoadAllUsers();
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (currentUserId == 0)
            {
                MessageBox.Show("الرجاء اختيار مستخدم للتعديل", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DataTable dt = userBL.GetUserById(currentUserId);
            if (dt.Rows.Count > 0)
            {
                UserModel userToEdit = new UserModel
                {
                    UserID = Convert.ToInt32(dt.Rows[0]["UserID"]),
                    Username = dt.Rows[0]["Username"].ToString(),
                    Password = dt.Rows[0]["Password"].ToString(),
                    FullName = dt.Rows[0]["FullName"].ToString(),
                    Role = dt.Rows[0]["Role"].ToString(),
                    IsActive = Convert.ToBoolean(dt.Rows[0]["IsActive"]),
                    CreatedDate = Convert.ToDateTime(dt.Rows[0]["CreatedDate"])
                };
                using (UserEntryForm userEntryForm = new UserEntryForm(userToEdit))
                {
                    if (userEntryForm.ShowDialog() == DialogResult.OK)
                    {
                        LoadAllUsers();
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (currentUserId == 0)
            {
                MessageBox.Show("الرجاء اختيار مستخدم للحذف", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult result = MessageBox.Show("هل أنت متأكد من حذف المستخدم المحدد؟", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                userBL.DeleteUser(currentUserId);
                MessageBox.Show("تم حذف المستخدم بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadAllUsers();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            string Keyword = txtSearch.Text.Trim();
            if (string.IsNullOrEmpty(Keyword))
            {
                LoadAllUsers();
            }
            else
            {
                DataTable dt = userBL.SearchUsers(Keyword);
                dgvUsers.DataSource = dt;
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("لا توجد نتائج مطابقة للبحث", "معلومات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
