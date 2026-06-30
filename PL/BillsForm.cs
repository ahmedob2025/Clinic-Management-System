
using ClinicMangementSystem.Models;
using ClinicMangementSystem.BL;
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace ClinicMangementSystem.PL
{
    public partial class BillsForm : Form
    {
        private BillBL billBL = new BillBL();
        private int currentBillID = 0;

        public BillsForm()
        {
            InitializeComponent();
            LoadAllBills();
            btnUpdatePayment.Enabled = false;
            btnPrint.Enabled = false;
            FormatGridView();
        }

        private void LoadAllBills()
        {
            DataTable dt = billBL.GetAllBills();
            dgvBills.DataSource = dt;
            btnUpdatePayment.Enabled = false;
            btnPrint.Enabled = false;
        }

        // تنسيق الجدول
        private void FormatGridView()
        {
            if (dgvBills.Columns["BillID"] != null)
                dgvBills.Columns["BillID"].Visible = false;

            if (dgvBills.Columns["PatientName"] != null)
                dgvBills.Columns["PatientName"].HeaderText = "المريض";
            if (dgvBills.Columns["DoctorName"] != null)
                dgvBills.Columns["DoctorName"].HeaderText = "الطبيب";
            if (dgvBills.Columns["Amount"] != null)
            {
                dgvBills.Columns["Amount"].HeaderText = "المبلغ";
                dgvBills.Columns["Amount"].DefaultCellStyle.Format = "N2";
            }
            if (dgvBills.Columns["PaymentStatus"] != null)
                dgvBills.Columns["PaymentStatus"].HeaderText = "الحالة";
            if (dgvBills.Columns["PaymentDate"] != null)
            {
                dgvBills.Columns["PaymentDate"].HeaderText = "تاريخ الدفع";
                dgvBills.Columns["PaymentDate"].DefaultCellStyle.Format = "yyyy-MM-dd";
            }

            dgvBills.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgvBills.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            dgvBills.RowTemplate.Height = 35;
            dgvBills.AllowUserToAddRows = false;
        }

        // حدث تحديد الصف
        private void dgvBills_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvBills.SelectedRows.Count > 0)
            {
                currentBillID = Convert.ToInt32(dgvBills.SelectedRows[0].Cells["BillID"].Value);
                btnUpdatePayment.Enabled = true;
                btnPrint.Enabled = true;
            }
            else
            {
                btnUpdatePayment.Enabled = false;
                btnPrint.Enabled = false;
            }
        }

        // زر تحديث الدفع (تحويل الحالة إلى "مدفوعة")
        private void btnUpdatePayment_Click(object sender, EventArgs e)
        {
            if (currentBillID == 0)
            {
                MessageBox.Show("الرجاء تحديد فاتورة.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // التحقق من أن الفاتورة غير مدفوعة أصلاً
            string currentStatus = dgvBills.SelectedRows[0].Cells["PaymentStatus"].Value.ToString();
            if (currentStatus == "Paid")
            {
                MessageBox.Show("هذه الفاتورة مدفوعة بالفعل!", "معلومات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("تأكيد تحويل الحالة إلى (مدفوعة)؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (billBL.UpdatePaymentStatus(currentBillID))
                {
                    MessageBox.Show("تم تحديث حالة الدفع بنجاح.", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadAllBills(); // تحديث الجدول
                }
            }
        }

        // --- زر الطباعة (المميز) ---
        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (currentBillID == 0)
            {
                MessageBox.Show("الرجاء تحديد فاتورة للطباعة.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // جلب بيانات الفاتورة المحددة
            DataTable dt = billBL.GetBillById(currentBillID);
            if (dt.Rows.Count == 0) return;

            DataRow row = dt.Rows[0];
            string patient = row["PatientName"].ToString();
            string doctor = row["DoctorName"].ToString();
            string amount = row["Amount"].ToString();
            string status = row["PaymentStatus"].ToString();
            string date = Convert.ToDateTime(row["AppointmentDate"]).ToString("yyyy-MM-dd");

            // تجهيز الطابعة
            PrintDocument printDoc = new PrintDocument();
            printDoc.PrintPage += (senderPrint, ePrint) =>
            {
                Font titleFont = new Font("Arial", 18, FontStyle.Bold);
                Font subTitleFont = new Font("Arial", 14, FontStyle.Bold);
                Font bodyFont = new Font("Arial", 12, FontStyle.Regular);
                float y = 40;
                float leftMargin = 50;

                // عنوان الفاتورة
                ePrint.Graphics.DrawString("====================================", bodyFont, Brushes.Black, leftMargin, y);
                y += 25;
                ePrint.Graphics.DrawString("     فاتورة العيادة الطبية     ", titleFont, Brushes.Black, leftMargin, y);
                y += 40;
                ePrint.Graphics.DrawString("====================================", bodyFont, Brushes.Black, leftMargin, y);
                y += 30;

                // بيانات الفاتورة
                ePrint.Graphics.DrawString($"تاريخ الموعد    : {date}", bodyFont, Brushes.Black, leftMargin, y);
                y += 30;
                ePrint.Graphics.DrawString($"المريض          : {patient}", bodyFont, Brushes.Black, leftMargin, y);
                y += 30;
                ePrint.Graphics.DrawString($"الطبيب          : {doctor}", bodyFont, Brushes.Black, leftMargin, y);
                y += 30;
                ePrint.Graphics.DrawString($"المبلغ المستحق  : {amount} ل.س", bodyFont, Brushes.Black, leftMargin, y);
                y += 30;
                ePrint.Graphics.DrawString($"الحالة          : {status}", bodyFont, Brushes.Black, leftMargin, y);
                y += 40;

                // تذييل
                ePrint.Graphics.DrawString("====================================", bodyFont, Brushes.Black, leftMargin, y);
                y += 25;
                ePrint.Graphics.DrawString($"تمت الطباعة في  : {DateTime.Now}", bodyFont, Brushes.Black, leftMargin, y);
                y += 25;
                ePrint.Graphics.DrawString("شكراً لزيارتكم", bodyFont, Brushes.Black, leftMargin, y);
            };

            // عرض معاينة الطباعة
            PrintPreviewDialog preview = new PrintPreviewDialog();
            preview.Document = printDoc;
            preview.WindowState = FormWindowState.Maximized;
            preview.ShowDialog();
        }

        // زر البحث
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();
            if (string.IsNullOrEmpty(keyword))
                LoadAllBills();
            else
            {
                DataTable dt = billBL.SearchBills(keyword);
                dgvBills.DataSource = dt;
                FormatGridView();
                if (dt.Rows.Count == 0)
                    MessageBox.Show("لا توجد نتائج.", "بحث", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnUpdatePayment.Enabled = false;
                btnPrint.Enabled = false;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadAllBills();
            txtSearch.Clear();
        }
    }
}