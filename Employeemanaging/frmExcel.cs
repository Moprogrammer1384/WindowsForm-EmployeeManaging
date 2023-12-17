using Employeemanaging_DataAccess.Context;
using Employeemanaging_Model.Entities;
using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Employeemanaging
{
    public partial class frmExcel : Form
    {
        public frmExcel()
        {
            InitializeComponent();
        }

        private void frmExcel_Load(object sender, EventArgs e)
        {
            dgvImport.AutoGenerateColumns = false;
        }
        DataTableCollection tableCollection;
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Excel 97-2003 Workbook|*.xls|Excel Eorkbook|*.xlsx" })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtFileName.Text = openFileDialog.FileName;
                    using (var stream = File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                    {
                        using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                        {
                            DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
                            });
                            tableCollection = result.Tables;
                            cmbSheet.Items.Clear();
                            foreach (DataTable table in tableCollection)
                            {
                                cmbSheet.Items.Add(table.TableName);//adding sheets to combobox
                            }
                        }
                    }
                }
            }
        }

        private void cmbSheet_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = tableCollection[cmbSheet.SelectedItem.ToString()];
            //dgvImport.DataSource = dt;

            if (dt != null)
            {
                List<EmployeesTB> employees = new List<EmployeesTB>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    EmployeesTB employee = new EmployeesTB();
                    employee.PersonalCode = dt.Rows[i]["پرسنلی"].ToString();
                    employee.SecondSchoolCode = dt.Rows[i]["کد مدرسه دوم"].ToString();
                    employee.FirstSchoolCode = dt.Rows[i]["کد مدرسه اول"].ToString();
                    employee.Position = dt.Rows[i]["رسته"].ToString();
                    employee.Status = dt.Rows[i]["وضعیت ابلاغ"].ToString();
                    employee.FirstSchool = dt.Rows[i]["مدرسه اول"].ToString();
                    employee.SecondSchool = dt.Rows[i]["مدرسه دوم"].ToString();
                    employee.Grade = dt.Rows[i]["مقطع"].ToString();
                    employee.LastName = dt.Rows[i]["نام خانوادگی"].ToString();
                    employee.FirstName = dt.Rows[i]["نام"].ToString();
                    employee.SchoolGender = dt.Rows[i]["جنسیت مدرسه"].ToString();
                    employee.Shift = dt.Rows[i][" نوبت 2"].ToString();
                    employee.FatherName = dt.Rows[i]["نام پدر"].ToString();
                    employee.Gender = dt.Rows[i]["جنسیت"].ToString();
                    employee.PhoneNumber = dt.Rows[i]["شماره موبایل "].ToString();
                    employee.MainPhone = dt.Rows[i]["تلفن ثابت"].ToString();
                    employee.NationaleCode = dt.Rows[i]["کدملی"].ToString();
                    employee.AccountNumber = dt.Rows[i]["شماره حساب"].ToString();
                    employee.Description = dt.Rows[i]["توضیحات"].ToString();
                    employees.Add(employee);

                }
                dgvImport.DataSource = employees;
                dgvImport.Columns["PersonalCode2"].DataPropertyName = "PersonalCode";
                dgvImport.Columns["SecondSchoolCode2"].DataPropertyName = "SecondSchoolCode";
                dgvImport.Columns["FirstSchoolCode2"].DataPropertyName = "FirstSchoolCode";
                dgvImport.Columns["Position2"].DataPropertyName = "Position";
                dgvImport.Columns["Status2"].DataPropertyName = "Status";
                dgvImport.Columns["FirstSchool2"].DataPropertyName = "FirstSchool";
                dgvImport.Columns["SecondSchool2"].DataPropertyName = "SecondSchool";
                dgvImport.Columns["Grade"].DataPropertyName = "Grade";
                dgvImport.Columns["LastName"].DataPropertyName = "LastName";
                dgvImport.Columns["FirstName"].DataPropertyName = "FirstName";
                dgvImport.Columns["SchoolGender"].DataPropertyName = "SchoolGender";
                dgvImport.Columns["Shift"].DataPropertyName = "Shift";
                dgvImport.Columns["FatherName"].DataPropertyName = "FatherName";
                dgvImport.Columns["Gender"].DataPropertyName = "Gender";
                dgvImport.Columns["PhoneNumber"].DataPropertyName = "PhoneNumber";
                dgvImport.Columns["MainPhone"].DataPropertyName = "MainPhone";
                dgvImport.Columns["NationaleCode"].DataPropertyName = "NationaleCode";
                dgvImport.Columns["AccountNumber"].DataPropertyName = "AccountNumber";
                dgvImport.Columns["Description"].DataPropertyName = "Description";
            }

        }

        private void btnImport_Click(object sender, EventArgs e)
        {

            try
            {
                List<EmployeesTB> employees = dgvImport.DataSource as List<EmployeesTB>;
                if (employees != null)
                {
                    using (ApplicationDbContext db = new ApplicationDbContext())
                    {
                        foreach (var employee in employees)
                        {

                            if (db.EmployeesTB.Where(x => x.PersonalCode == employee.PersonalCode).Any() == false)
                            {
                                db.EmployeesTB.Add(employee);
                                db.SaveChanges();
                            }
                            else
                            {
                                var id = employee.PersonalCode;
                                var emp = db.EmployeesTB.FirstOrDefault(x => x.PersonalCode == id);
                                if (employee.SecondSchoolCode != emp.SecondSchoolCode)
                                {
                                    emp.SecondSchoolCode = employee.SecondSchoolCode;
                                }

                                if (employee.FirstSchoolCode != emp.FirstSchoolCode)
                                {
                                    emp.FirstSchoolCode = employee.FirstSchoolCode;
                                }

                                if (employee.Position != emp.Position)
                                {
                                    emp.Position = employee.Position;
                                }

                                if (employee.Status != emp.Status)
                                {
                                    emp.Status = employee.Status;
                                }

                                if (employee.FirstSchool != emp.FirstSchool)
                                {
                                    emp.FirstSchool = employee.FirstSchool;
                                }

                                if (employee.SecondSchool != emp.SecondSchool)
                                {
                                    emp.SecondSchool = employee.SecondSchool;
                                }

                                if (employee.Grade != emp.Grade)
                                {
                                    emp.Grade = employee.Grade;
                                }

                                if (employee.LastName != emp.LastName)
                                {
                                    emp.LastName = employee.LastName;
                                }

                                if (employee.FirstName != emp.FirstName)
                                {
                                    emp.FirstName = employee.FirstName;
                                }

                                if (employee.SchoolGender != emp.SchoolGender)
                                {
                                    emp.SchoolGender = employee.SchoolGender;
                                }

                                if (employee.Shift != emp.Shift)
                                {
                                    emp.Shift = employee.Shift;
                                }

                                if (employee.FatherName != emp.FatherName)
                                {
                                    emp.FatherName = employee.FatherName;
                                }

                                if (employee.Gender != emp.Gender)
                                {
                                    emp.Gender = employee.Gender;
                                }

                                if (employee.PhoneNumber != emp.PhoneNumber)
                                {
                                    emp.PhoneNumber = employee.PhoneNumber;
                                }

                                if (employee.MainPhone != emp.MainPhone)
                                {
                                    emp.MainPhone = employee.MainPhone;
                                }

                                if (employee.NationaleCode != emp.NationaleCode)
                                {
                                    emp.NationaleCode = employee.NationaleCode;
                                }

                                if (employee.AccountNumber != emp.AccountNumber)
                                {
                                    emp.AccountNumber = employee.AccountNumber;
                                }

                                if (employee.Description != emp.Description)
                                {
                                    emp.Description = employee.Description;
                                }

                                db.EmployeesTB.Update(emp);
                                db.SaveChanges();

                            }
                        }


                    }

                }
                MessageBox.Show("عملیات با موفقیت انجام شد ", "پیام", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch 
            {
                MessageBox.Show("عملیات با شکست انجام شد !!!! ", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
           

           
        }
    }
}

