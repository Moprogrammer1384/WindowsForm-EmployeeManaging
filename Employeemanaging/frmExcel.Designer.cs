
namespace Employeemanaging
{
    partial class frmExcel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExcel));
            this.dgvImport = new System.Windows.Forms.DataGridView();
            this.PersonalCode2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SecondSchoolCode2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstSchoolCode2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Position2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstSchool2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SecondSchool2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SchoolGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Shift = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FatherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MainPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NationaleCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.cmbSheet = new System.Windows.Forms.ComboBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.PersonalCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SecondSchoolCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstSchoolCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstSchool = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SecondSchool = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImport)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvImport
            // 
            this.dgvImport.AllowUserToAddRows = false;
            this.dgvImport.AllowUserToDeleteRows = false;
            this.dgvImport.BackgroundColor = System.Drawing.Color.White;
            this.dgvImport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvImport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PersonalCode2,
            this.SecondSchoolCode2,
            this.FirstSchoolCode2,
            this.Position2,
            this.Status2,
            this.FirstSchool2,
            this.SecondSchool2,
            this.Grade,
            this.LastName,
            this.FirstName,
            this.SchoolGender,
            this.Shift,
            this.FatherName,
            this.Gender,
            this.PhoneNumber,
            this.MainPhone,
            this.NationaleCode,
            this.AccountNumber,
            this.Description});
            this.dgvImport.Location = new System.Drawing.Point(0, 0);
            this.dgvImport.Name = "dgvImport";
            this.dgvImport.ReadOnly = true;
            this.dgvImport.RowHeadersWidth = 51;
            this.dgvImport.RowTemplate.Height = 29;
            this.dgvImport.Size = new System.Drawing.Size(935, 338);
            this.dgvImport.TabIndex = 0;
            // 
            // PersonalCode2
            // 
            this.PersonalCode2.HeaderText = "کد پرسنلی ";
            this.PersonalCode2.MinimumWidth = 6;
            this.PersonalCode2.Name = "PersonalCode2";
            this.PersonalCode2.ReadOnly = true;
            this.PersonalCode2.Width = 125;
            // 
            // SecondSchoolCode2
            // 
            this.SecondSchoolCode2.HeaderText = "کد مدرسه ی دوم";
            this.SecondSchoolCode2.MinimumWidth = 6;
            this.SecondSchoolCode2.Name = "SecondSchoolCode2";
            this.SecondSchoolCode2.ReadOnly = true;
            this.SecondSchoolCode2.Width = 125;
            // 
            // FirstSchoolCode2
            // 
            this.FirstSchoolCode2.HeaderText = "کد مدرسه ی اول ";
            this.FirstSchoolCode2.MinimumWidth = 6;
            this.FirstSchoolCode2.Name = "FirstSchoolCode2";
            this.FirstSchoolCode2.ReadOnly = true;
            this.FirstSchoolCode2.Width = 125;
            // 
            // Position2
            // 
            this.Position2.HeaderText = "رسته";
            this.Position2.MinimumWidth = 6;
            this.Position2.Name = "Position2";
            this.Position2.ReadOnly = true;
            this.Position2.Width = 125;
            // 
            // Status2
            // 
            this.Status2.HeaderText = "وضعیت ابلاغ ";
            this.Status2.MinimumWidth = 6;
            this.Status2.Name = "Status2";
            this.Status2.ReadOnly = true;
            this.Status2.Width = 125;
            // 
            // FirstSchool2
            // 
            this.FirstSchool2.HeaderText = "مدرسه ی اول ";
            this.FirstSchool2.MinimumWidth = 6;
            this.FirstSchool2.Name = "FirstSchool2";
            this.FirstSchool2.ReadOnly = true;
            this.FirstSchool2.Width = 125;
            // 
            // SecondSchool2
            // 
            this.SecondSchool2.HeaderText = "مدرسه ی دوم";
            this.SecondSchool2.MinimumWidth = 6;
            this.SecondSchool2.Name = "SecondSchool2";
            this.SecondSchool2.ReadOnly = true;
            this.SecondSchool2.Width = 125;
            // 
            // Grade
            // 
            this.Grade.HeaderText = "مقطع";
            this.Grade.MinimumWidth = 6;
            this.Grade.Name = "Grade";
            this.Grade.ReadOnly = true;
            this.Grade.Width = 125;
            // 
            // LastName
            // 
            this.LastName.HeaderText = "نام خانوادگی ";
            this.LastName.MinimumWidth = 6;
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            this.LastName.Width = 125;
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "نام";
            this.FirstName.MinimumWidth = 6;
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            this.FirstName.Width = 125;
            // 
            // SchoolGender
            // 
            this.SchoolGender.HeaderText = "جنسیت مدرسه";
            this.SchoolGender.MinimumWidth = 6;
            this.SchoolGender.Name = "SchoolGender";
            this.SchoolGender.ReadOnly = true;
            this.SchoolGender.Width = 125;
            // 
            // Shift
            // 
            this.Shift.HeaderText = "نوبت";
            this.Shift.MinimumWidth = 6;
            this.Shift.Name = "Shift";
            this.Shift.ReadOnly = true;
            this.Shift.Width = 125;
            // 
            // FatherName
            // 
            this.FatherName.HeaderText = "نام پدر";
            this.FatherName.MinimumWidth = 6;
            this.FatherName.Name = "FatherName";
            this.FatherName.ReadOnly = true;
            this.FatherName.Width = 125;
            // 
            // Gender
            // 
            this.Gender.HeaderText = "جنسیت";
            this.Gender.MinimumWidth = 6;
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            this.Gender.Width = 125;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.HeaderText = "شماره ی موبایل";
            this.PhoneNumber.MinimumWidth = 6;
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.ReadOnly = true;
            this.PhoneNumber.Width = 125;
            // 
            // MainPhone
            // 
            this.MainPhone.HeaderText = "تلفن ثابت";
            this.MainPhone.MinimumWidth = 6;
            this.MainPhone.Name = "MainPhone";
            this.MainPhone.ReadOnly = true;
            this.MainPhone.Width = 125;
            // 
            // NationaleCode
            // 
            this.NationaleCode.HeaderText = "کد ملی";
            this.NationaleCode.MinimumWidth = 6;
            this.NationaleCode.Name = "NationaleCode";
            this.NationaleCode.ReadOnly = true;
            this.NationaleCode.Width = 125;
            // 
            // AccountNumber
            // 
            this.AccountNumber.HeaderText = "شماره ی حساب ";
            this.AccountNumber.MinimumWidth = 6;
            this.AccountNumber.Name = "AccountNumber";
            this.AccountNumber.ReadOnly = true;
            this.AccountNumber.Width = 125;
            // 
            // Description
            // 
            this.Description.HeaderText = "توضیحات";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(862, 382);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "جدول:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(862, 347);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "فایل:";
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(163, 344);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(693, 29);
            this.txtFileName.TabIndex = 3;
            // 
            // cmbSheet
            // 
            this.cmbSheet.FormattingEnabled = true;
            this.cmbSheet.Location = new System.Drawing.Point(163, 379);
            this.cmbSheet.Name = "cmbSheet";
            this.cmbSheet.Size = new System.Drawing.Size(693, 30);
            this.cmbSheet.TabIndex = 4;
            this.cmbSheet.SelectedIndexChanged += new System.EventHandler(this.cmbSheet_SelectedIndexChanged);
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnBrowse.Location = new System.Drawing.Point(95, 344);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(62, 29);
            this.btnBrowse.TabIndex = 5;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnImport
            // 
            this.btnImport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnImport.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnImport.Location = new System.Drawing.Point(12, 382);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(145, 29);
            this.btnImport.TabIndex = 6;
            this.btnImport.Text = "&وارد کردن";
            this.btnImport.UseVisualStyleBackColor = false;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // PersonalCode
            // 
            this.PersonalCode.HeaderText = "کد پرسنلی ";
            this.PersonalCode.MinimumWidth = 6;
            this.PersonalCode.Name = "PersonalCode";
            this.PersonalCode.Width = 125;
            // 
            // SecondSchoolCode
            // 
            this.SecondSchoolCode.HeaderText = "کد مدرسه ی دوم ";
            this.SecondSchoolCode.MinimumWidth = 6;
            this.SecondSchoolCode.Name = "SecondSchoolCode";
            this.SecondSchoolCode.Width = 125;
            // 
            // FirstSchoolCode
            // 
            this.FirstSchoolCode.HeaderText = "کد مدرسه ی اول ";
            this.FirstSchoolCode.MinimumWidth = 6;
            this.FirstSchoolCode.Name = "FirstSchoolCode";
            this.FirstSchoolCode.Width = 125;
            // 
            // Position
            // 
            this.Position.HeaderText = "رسته";
            this.Position.MinimumWidth = 6;
            this.Position.Name = "Position";
            this.Position.Width = 125;
            // 
            // Status
            // 
            this.Status.HeaderText = "وضعیت ابلاغ";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.Width = 125;
            // 
            // FirstSchool
            // 
            this.FirstSchool.HeaderText = "مدرسه ی اول ";
            this.FirstSchool.MinimumWidth = 6;
            this.FirstSchool.Name = "FirstSchool";
            this.FirstSchool.Width = 125;
            // 
            // SecondSchool
            // 
            this.SecondSchool.HeaderText = "مدرسه ی دوم ";
            this.SecondSchool.MinimumWidth = 6;
            this.SecondSchool.Name = "SecondSchool";
            this.SecondSchool.Width = 125;
            // 
            // frmExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(933, 418);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.cmbSheet);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvImport);
            this.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmExcel";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmExcel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvImport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvImport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.ComboBox cmbSheet;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonalCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn SecondSchoolCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstSchoolCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Position;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstSchool;
        private System.Windows.Forms.DataGridViewTextBoxColumn SecondSchool;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonalCode2;
        private System.Windows.Forms.DataGridViewTextBoxColumn SecondSchoolCode2;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstSchoolCode2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Position2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status2;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstSchool2;
        private System.Windows.Forms.DataGridViewTextBoxColumn SecondSchool2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grade;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SchoolGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Shift;
        private System.Windows.Forms.DataGridViewTextBoxColumn FatherName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn MainPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn NationaleCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
    }
}