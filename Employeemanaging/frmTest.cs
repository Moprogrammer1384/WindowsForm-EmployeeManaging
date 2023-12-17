using ClosedXML.Excel;
using Employeemanaging_DataAccess.Context;
using Employeemanaging_Model.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employeemanaging
{
    public partial class frmTest : Form
    {
        bool check = true;
        int id;
        public frmTest()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmTest_Load(object sender, EventArgs e)
        {
            this.Hide();
            frmlogin frmLogin = new frmlogin();

            if (frmLogin.ShowDialog() == DialogResult.OK)
            {
                //Responsive ResponsiveObj;
                //ResponsiveObj = new Responsive(Screen.PrimaryScreen.Bounds);
                //ResponsiveObj.SetMultiplicationFactor();
                //Width = ResponsiveObj.GetMetrics(Width, "Width");           // Form width and height set up.
                //Height = ResponsiveObj.GetMetrics(Height, "Height");
                //Left = Screen.GetBounds(this).Width / 2 - Width / 2;        // Form centering.
                //Top = Screen.GetBounds(this).Height / 2 - Height / 2 - 30;  // 30 is a calibration factor.

                //foreach (Control Ctl in this.Controls)
                //{
                //    Ctl.Font = new Font(FontFamily.GenericSansSerif,
                //               ResponsiveObj.GetMetrics((int)Ctl.Font.Size), FontStyle.Regular);
                //    Ctl.Width = ResponsiveObj.GetMetrics(Ctl.Width, "Width");
                //    Ctl.Height = ResponsiveObj.GetMetrics(Ctl.Height, "Height");
                //    Ctl.Top = ResponsiveObj.GetMetrics(Ctl.Top, "Top");
                //    Ctl.Left = ResponsiveObj.GetMetrics(Ctl.Left, "Left");
                //}

                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
                BtnClear.Enabled = true;
                using (ApplicationDbContext db = new ApplicationDbContext())
                {
                    dgvEmployee.AutoGenerateColumns = false;
                    dgvEmployee.DataSource = db.EmployeesTB.ToList();
                    dgvEmployee.Columns["Id"].DataPropertyName = "Id";
                    dgvEmployee.Columns["PersonalCode"].DataPropertyName = "PersonalCode";
                    dgvEmployee.Columns["SecondSchoolCode"].DataPropertyName = "SecondSchoolCode";
                    dgvEmployee.Columns["FirstSchoolCode"].DataPropertyName = "FirstSchoolCode";
                    dgvEmployee.Columns["Position"].DataPropertyName = "Position";
                    dgvEmployee.Columns["Status"].DataPropertyName = "Status";
                    dgvEmployee.Columns["FirstSchool"].DataPropertyName = "FirstSchool";
                    dgvEmployee.Columns["SecondSchool"].DataPropertyName = "SecondSchool";
                    dgvEmployee.Columns["Grade"].DataPropertyName = "Grade";
                    dgvEmployee.Columns["LastName"].DataPropertyName = "LastName";
                    dgvEmployee.Columns["FirstName"].DataPropertyName = "FirstName";
                    dgvEmployee.Columns["SchoolGender"].DataPropertyName = "SchoolGender";
                    dgvEmployee.Columns["Shift"].DataPropertyName = "Shift";
                    dgvEmployee.Columns["FatherName"].DataPropertyName = "FatherName";
                    dgvEmployee.Columns["Gender"].DataPropertyName = "Gender";
                    dgvEmployee.Columns["PhoneNumber"].DataPropertyName = "PhoneNumber";
                    dgvEmployee.Columns["MainPhone"].DataPropertyName = "MainPhone";
                    dgvEmployee.Columns["NationaleCode"].DataPropertyName = "NationaleCode";
                    dgvEmployee.Columns["AccountNumber"].DataPropertyName = "AccountNumber";
                    dgvEmployee.Columns["Description"].DataPropertyName = "Description";










                }

            }
            else
            {
                Application.Exit();
            }
        }
        public void Clear(bool isUsual)
        {
            txtPersonalCode2.Text = "";
            txtSecondSchoolCode.Text = "";
            txtFirstSchoolCode2.Text = "";
            txtPosition.Text = "";
            txtStatus2.Text = "";
            txtFirstSchool.Text = "";
            txtSecondSchool2.Text = "";
            txtGrade.Text = "";
            txtLastName2.Text = "";
            txtName.Text = "";
            txtSchoolGender2.Text = "";
            txtShift.Text = "";
            txtFatherName2.Text = "";
            txtGender.Text = "";
            txtPhoneNumber.Text = "";
            txtMainPhone.Text = "";
            txtNationalCode.Text = "";
            txtAccountNumber.Text = "";
            txtDescription.Text = "";

            if (isUsual == true)
            {

                cmbSearch.SelectedItem = null;

                cmbSearch.Text = "فیلد مورد نظر رو انتخاب کنید ";
            }


        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                check = false;
                Clear(check);

                switch (cmbSearch.SelectedItem)
                {
                    case "کد پرسنلی ":
                        using (ApplicationDbContext db = new ApplicationDbContext())
                        {

                            dgvEmployee.DataSource = db.EmployeesTB.Where(a =>
                            a.PersonalCode.Contains(txtSearch.Text)).ToList();
                        }
                        break;
                    case "کد مدرسه ی دوم ":
                        using (ApplicationDbContext db = new ApplicationDbContext())
                        {
                            dgvEmployee.DataSource = db.EmployeesTB.Where(a =>
                            a.SecondSchoolCode.Contains(txtSearch.Text)).ToList();
                        }
                        break;
                    case "کد مدرسه ی اول ":
                        using (ApplicationDbContext db = new ApplicationDbContext())
                        {
                            dgvEmployee.DataSource = db.EmployeesTB.Where(a =>
                            a.FirstSchoolCode.Contains(txtSearch.Text)).ToList();
                        }
                        break;
                    case "رسته":
                        using (ApplicationDbContext db = new ApplicationDbContext())
                        {
                            dgvEmployee.DataSource = db.EmployeesTB.Where(a =>
                            a.Position.Contains(txtSearch.Text)).ToList();
                        }
                        break;
                    case "وضعیت ابلاغ":
                        using (ApplicationDbContext db = new ApplicationDbContext())
                        {
                            dgvEmployee.DataSource = db.EmployeesTB.Where(a =>
                            a.Status.Contains(txtSearch.Text)).ToList();
                        }
                        break;
                    case "مدرسه ی اول ":
                        using (ApplicationDbContext db = new ApplicationDbContext())
                        {
                            dgvEmployee.DataSource = db.EmployeesTB.Where(a =>
                            a.FirstSchool.Contains(txtSearch.Text)).ToList();
                        }
                        break;
                    case "مدرسه ی دوم":
                        using (ApplicationDbContext db = new ApplicationDbContext())
                        {
                            dgvEmployee.DataSource = db.EmployeesTB.Where(a =>
                            a.SecondSchool.Contains(txtSearch.Text)).ToList();
                        }
                        break;
                    case "مقطع":
                        using (ApplicationDbContext db = new ApplicationDbContext())
                        {
                            dgvEmployee.DataSource = db.EmployeesTB.Where(a =>
                            a.Grade.Contains(txtSearch.Text)).ToList();
                        }
                        break;
                    case "نام خانوادگی ":
                        using (ApplicationDbContext db = new ApplicationDbContext())
                        {
                            dgvEmployee.DataSource = db.EmployeesTB.Where(a =>
                            a.LastName.Contains(txtSearch.Text)).ToList();
                        }
                        break;
                    case "نام":
                        using (ApplicationDbContext db = new ApplicationDbContext())
                        {
                            dgvEmployee.DataSource = db.EmployeesTB.Where(a =>
                            a.FirstName.Contains(txtSearch.Text)).ToList();
                        }
                        break;
                    case "جنسیت مدرسه":
                        using (ApplicationDbContext db = new ApplicationDbContext())
                        {
                            dgvEmployee.DataSource = db.EmployeesTB.Where(a =>
                            a.SchoolGender.Contains(txtSearch.Text)).ToList();
                        }
                        break;
                    case "نوبت":
                        using (ApplicationDbContext db = new ApplicationDbContext())
                        {
                            dgvEmployee.DataSource = db.EmployeesTB.Where(a =>
                            a.Shift.Contains(txtSearch.Text)).ToList();
                        }
                        break;
                    case "نام پدر":
                        using (ApplicationDbContext db = new ApplicationDbContext())
                        {
                            dgvEmployee.DataSource = db.EmployeesTB.Where(a =>
                            a.FatherName.Contains(txtSearch.Text)).ToList();
                        }
                        break;
                    case "جنسیت":
                        using (ApplicationDbContext db = new ApplicationDbContext())
                        {
                            dgvEmployee.DataSource = db.EmployeesTB.Where(a =>
                            a.Gender.Contains(txtSearch.Text)).ToList();
                        }
                        break;
                    case "شماره ی موبایل":
                        using (ApplicationDbContext db = new ApplicationDbContext())
                        {
                            dgvEmployee.DataSource = db.EmployeesTB.Where(a =>
                            a.PhoneNumber.Contains(txtSearch.Text)).ToList();
                        }
                        break;
                    case "تلفن ثابت":
                        using (ApplicationDbContext db = new ApplicationDbContext())
                        {
                            dgvEmployee.DataSource = db.EmployeesTB.Where(a =>
                            a.MainPhone.Contains(txtSearch.Text)).ToList();
                        }
                        break;
                    case "کدملی":
                        using (ApplicationDbContext db = new ApplicationDbContext())
                        {
                            dgvEmployee.DataSource = db.EmployeesTB.Where(a =>
                            a.NationaleCode.Contains(txtSearch.Text)).ToList();
                        }
                        break;
                    case "شماره ی حساب":
                        using (ApplicationDbContext db = new ApplicationDbContext())
                        {
                            dgvEmployee.DataSource = db.EmployeesTB.Where(a =>
                            a.AccountNumber.Contains(txtSearch.Text)).ToList();
                        }
                        break;
                    case "توضیحات":
                        using (ApplicationDbContext db = new ApplicationDbContext())
                        {
                            dgvEmployee.DataSource = db.EmployeesTB.Where(a =>
                            a.Description.Contains(txtSearch.Text)).ToList();
                        }
                        break;
                    case "هیچکدام":
                        using (ApplicationDbContext db = new ApplicationDbContext())
                        {
                            dgvEmployee.DataSource = db.EmployeesTB.Where(a =>
                           a.PersonalCode.Contains(txtSearch.Text) ||
                           a.SecondSchoolCode.Contains(txtSearch.Text) ||
                           a.FirstSchoolCode.Contains(txtSearch.Text) ||
                           a.Position.Contains(txtSearch.Text) ||
                           a.Status.Contains(txtSearch.Text) ||
                           a.FirstSchool.Contains(txtSearch.Text) ||
                           a.Grade.Contains(txtSearch.Text) ||
                           a.LastName.Contains(txtSearch.Text) ||
                           a.FirstName.Contains(txtSearch.Text) ||
                           a.SchoolGender.Contains(txtSearch.Text) ||
                           a.Shift.Contains(txtSearch.Text) ||
                           a.FatherName.Contains(txtSearch.Text) ||
                           a.Gender.Contains(txtSearch.Text) ||
                           a.PhoneNumber.Contains(txtSearch.Text) ||
                           a.MainPhone.Contains(txtSearch.Text) ||
                           a.NationaleCode.Contains(txtSearch.Text) ||
                           a.AccountNumber.Contains(txtSearch.Text) ||
                           a.Description.Contains(txtSearch.Text)


                           ).ToList();

                        }
                        break;
                    default:
                        using (ApplicationDbContext db = new ApplicationDbContext())
                        {
                            dgvEmployee.DataSource = db.EmployeesTB.Where(a =>
                           a.PersonalCode.Contains(txtSearch.Text) ||
                           a.SecondSchoolCode.Contains(txtSearch.Text) ||
                           a.FirstSchoolCode.Contains(txtSearch.Text) ||
                           a.Position.Contains(txtSearch.Text) ||
                           a.Status.Contains(txtSearch.Text) ||
                           a.FirstSchool.Contains(txtSearch.Text) ||
                           a.Grade.Contains(txtSearch.Text) ||
                           a.LastName.Contains(txtSearch.Text) ||
                           a.FirstName.Contains(txtSearch.Text) ||
                           a.SchoolGender.Contains(txtSearch.Text) ||
                           a.Shift.Contains(txtSearch.Text) ||
                           a.FatherName.Contains(txtSearch.Text) ||
                           a.Gender.Contains(txtSearch.Text) ||
                           a.PhoneNumber.Contains(txtSearch.Text) ||
                           a.MainPhone.Contains(txtSearch.Text) ||
                           a.NationaleCode.Contains(txtSearch.Text) ||
                           a.AccountNumber.Contains(txtSearch.Text) ||
                           a.Description.Contains(txtSearch.Text)


                           ).ToList();
                        }

                        break;


                }


            }
            catch
            {

                MessageBox.Show("موردی یافت نشد !!!!", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Clear(check);
            btnSave.Enabled = false;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            BtnClear.Enabled = true;
            try
            {
                using (ApplicationDbContext db = new ApplicationDbContext())
                {
                    id = (int)dgvEmployee.Rows[e.RowIndex].Cells["Id"].Value;


                    var employee = db.EmployeesTB.FirstOrDefault(x => x.Id == id);

                    if (employee.PersonalCode != null)
                    {
                        txtPersonalCode2.Text = employee.PersonalCode;
                    }

                    if (employee.SecondSchoolCode != null)
                    {
                        txtSecondSchoolCode.Text = employee.SecondSchoolCode;
                    }

                    if (employee.FirstSchoolCode != null)
                    {
                        txtFirstSchoolCode2.Text = employee.FirstSchoolCode;
                    }

                    if (employee.Position != null)
                    {
                        txtPosition.Text = employee.Position.ToString();
                    }

                    if (employee.Status != null)
                    {
                        txtStatus2.Text = employee.Status.ToString();
                    }

                    if (employee.FirstSchool != null)
                    {
                        txtFirstSchool.Text = employee.FirstSchool.ToString();
                    }

                    if (employee.SecondSchool != null)
                    {
                        txtSecondSchool2.Text = employee.SecondSchool.ToString();
                    }

                    if (employee.Grade != null)
                    {
                        txtGrade.Text = employee.Grade.ToString();
                    }

                    if (employee.LastName != null)
                    {
                        txtLastName2.Text = employee.LastName.ToString();
                    }

                    if (employee.FirstName != null)
                    {
                        txtName.Text = employee.FirstName.ToString();
                    }

                    if (employee.SchoolGender != null)
                    {
                        txtSchoolGender2.Text = employee.SchoolGender.ToString();
                    }

                    if (employee.Shift != null)
                    {
                        txtShift.Text = employee.Shift.ToString();
                    }

                    if (employee.FatherName != null)
                    {
                        txtFatherName2.Text = employee.FatherName.ToString();
                    }

                    if (employee.Gender != null)
                    {
                        txtGender.Text = employee.Gender.ToString();
                    }

                    if (employee.PhoneNumber != null)
                    {
                        txtPhoneNumber.Text = employee.PhoneNumber;
                    }

                    if (employee.MainPhone != null)
                    {
                        txtMainPhone.Text = employee.MainPhone;
                    }

                    if (employee.NationaleCode != null)
                    {
                        txtNationalCode.Text = employee.NationaleCode;
                    }

                    if (employee.AccountNumber != null)
                    {
                        txtAccountNumber.Text = employee.AccountNumber;
                    }

                    if (employee.Description != null)
                    {
                        txtDescription.Text = employee.Description.ToString();
                    }
                }
            }
            catch
            {

                MessageBox.Show("اشتباهی رخ داده  ", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void TxtCheck(EmployeesTB employee)
        {



            employee.PersonalCode = txtPersonalCode2.Text;
            employee.SecondSchoolCode = txtSecondSchoolCode.Text.ToString();
            employee.FirstSchoolCode = txtFirstSchoolCode2.Text;
            employee.PhoneNumber = txtPhoneNumber.Text;
            employee.MainPhone = txtMainPhone.Text;
            employee.AccountNumber = txtAccountNumber.Text;
            employee.NationaleCode = txtNationalCode.Text;
            employee.Position = txtPosition.Text;
            employee.Status = txtStatus2.Text;
            employee.FirstSchool = txtFirstSchool.Text;
            employee.SecondSchool = txtSecondSchool2.Text;
            employee.Grade = txtGrade.Text;
            employee.LastName = txtLastName2.Text;
            employee.FirstName = txtName.Text;
            employee.Shift = txtShift.Text;
            employee.FatherName = txtFatherName2.Text;
            employee.Gender = txtGender.Text;
            employee.Description = txtDescription.Text;
            employee.SchoolGender = txtSchoolGender2.Text;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (ApplicationDbContext db = new ApplicationDbContext())
                {
                    EmployeesTB employee = new EmployeesTB();
                    TxtCheck(employee);



                    string personalcode = txtPersonalCode2.Text;
                    if (db.EmployeesTB.Where(x => x.PersonalCode == personalcode).Any())
                    {
                        MessageBox.Show("کد پرسنلی تکراری است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        employee.PersonalCode = txtPersonalCode2.Text;

                        db.EmployeesTB.Add(employee);
                        db.SaveChanges();
                        MessageBox.Show("رکورد با موفقیت اضافه شد ", "پیام", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Refresh();
                        check = true;
                        Clear(check);



                    }




                }
            }
            catch
            {

                MessageBox.Show("رکورد متاسفانه ثبت نشد ", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Refresh()
        {
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                dgvEmployee.DataSource = db.EmployeesTB.ToList();

            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {

                using (ApplicationDbContext db = new ApplicationDbContext())
                {






                    EmployeesTB employee = db.EmployeesTB.FirstOrDefault(x => x.Id == id);
                    TxtCheck(employee);



                    db.EmployeesTB.Update(employee);
                    db.SaveChanges();
                    MessageBox.Show("رکورد با موفقیت ویرایش  شد ", "پیام", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Refresh();
                    check = true;
                    Clear(check);
                    btnUpdate.Enabled = false;
                    btnDelete.Enabled = false;
                    btnSave.Enabled = true;




                }

            }
            catch
            {
                MessageBox.Show("مشکلی در ویرایش رکورد پیش اومد !!!", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var result = MessageBox.Show("آیا از حذف اطمینان دارید ",
                     "پیام", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {

                    using (ApplicationDbContext db = new ApplicationDbContext())
                    {
                        var employee = db.EmployeesTB.FirstOrDefault(x => x.Id == id);
                        db.EmployeesTB.Remove(employee);
                        db.SaveChanges();
                        Refresh();
                        check = true;

                        Clear(check);

                        MessageBox.Show(" رکورد با موفقیت حذف شد  ",
                            "پیام", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnUpdate.Enabled = false;
                        btnDelete.Enabled = false;
                        btnSave.Enabled = true;

                    }
                }

            }
            catch
            {

                MessageBox.Show("عملیات حذف با شکست مواجه شد  ", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            check = true;

            Clear(check);
            txtSearch.Text = "";
            Refresh();
            btnSave.Enabled = true;
        }

        private void btnEditPassword_Click(object sender, EventArgs e)
        {
            frmlogin frmlogin = new frmlogin();
            frmlogin.isEdit = true;
            frmlogin.Show();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook |*.xlsx" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (XLWorkbook workbook = new XLWorkbook())
                        {

                            DataTable data = new DataTable();
                            data.Columns.Add("کد پرسنلی");
                            data.Columns.Add("کد مدرسه ی دوم");
                            data.Columns.Add("کد مدرسه ی اول");
                            data.Columns.Add("رسته");
                            data.Columns.Add("وضعیت ابلاغ");
                            data.Columns.Add("مدرسه ی اول");
                            data.Columns.Add("مدرسه ی دوم");
                            data.Columns.Add("مقطع");
                            data.Columns.Add("نام خانوادگی ");
                            data.Columns.Add("نام");
                            data.Columns.Add("جنسیت مدرسه");
                            data.Columns.Add("نوبت");
                            data.Columns.Add("نام پدر");
                            data.Columns.Add("جنسیت");
                            data.Columns.Add("شماره ی موبایل");
                            data.Columns.Add("تلفن ثابت");
                            data.Columns.Add("کد ملی");
                            data.Columns.Add("شماره ی حساب");
                            data.Columns.Add("توضیحات");

                            DataRow dt = null;
                            foreach (DataGridViewRow dr in dgvEmployee.Rows)
                            {
                                dt = data.NewRow();
                                dt["کد پرسنلی"] = dr.Cells["PersonalCode"].Value;
                                dt["کد مدرسه ی دوم"] = dr.Cells["SecondSchoolCode"].Value;
                                dt["کد مدرسه ی اول"] = dr.Cells["FirstSchoolCode"].Value;
                                dt["رسته"] = dr.Cells["Position"].Value;
                                dt["وضعیت ابلاغ"] = dr.Cells["Status"].Value;
                                dt["مدرسه ی اول"] = dr.Cells["FirstSchool"].Value;
                                dt["مدرسه ی دوم"] = dr.Cells["SecondSchool"].Value;
                                dt["مقطع"] = dr.Cells["Grade"].Value;
                                dt["نام خانوادگی "] = dr.Cells["LastName"].Value;
                                dt["نام"] = dr.Cells["FirstName"].Value;
                                dt["جنسیت مدرسه"] = dr.Cells["SchoolGender"].Value;
                                dt["نوبت"] = dr.Cells["Shift"].Value;
                                dt["نام پدر"] = dr.Cells["FatherName"].Value;
                                dt["جنسیت"] = dr.Cells["Gender"].Value;
                                dt["شماره ی موبایل"] = dr.Cells["PhoneNumber"].Value;
                                dt["تلفن ثابت"] = dr.Cells["MainPhone"].Value;
                                dt["کد ملی"] = dr.Cells["NationaleCode"].Value;
                                dt["شماره ی حساب"] = dr.Cells["AccountNumber"].Value;
                                dt["توضیحات"] = dr.Cells["Description"].Value;
                                data.Rows.Add(dt);
                            }

                            workbook.Worksheets.Add(data, "Employees");
                            workbook.SaveAs(sfd.FileName);




                        }
                        MessageBox.Show("خروجی گرفتن با موفقیت انجام شد ", "پیام", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message, "پیام", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            frmExcel frm = new frmExcel();
            frm.Show();
        }
    }
}
