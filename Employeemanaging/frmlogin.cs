using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Employeemanaging_DataAccess.Context;
using Employeemanaging_Model.Entities;


namespace Employeemanaging
{
    
    public partial class frmlogin : Form
    {
        public bool isEdit = false;
        public frmlogin()
        {
            InitializeComponent();
        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }

        private void frmlogin_Load(object sender, EventArgs e)
        {
            if(isEdit == true)
            {
                using (ApplicationDbContext db = new ApplicationDbContext())
                {
                    var login = db.Login.First(x => x.id == 1);
                    txtPassword.Text = login.Password.ToString();
                    txtUserName.Text = login.Username;
                    btnLogin.Text = "تغییر رمز";
                }
            }
          
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "" && txtUserName.Text == "")
            {
                MessageBox.Show("رمز عبور و نام کاربری را وارد کنید  ", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                using (ApplicationDbContext db = new ApplicationDbContext())
                {
                    if (isEdit == false)
                    {
                        //var login = db.Login.First();
                        if (db.Login.Where(x => x.Username == txtUserName.Text && x.Password == txtPassword.Text).Any())
                        {
                            DialogResult = DialogResult.OK;
                        }
                        else
                        {
                            MessageBox.Show("رمز عبور یا نام کاربری اشتباه است ", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        var login = db.Login.First();
                        login.Username = txtUserName.Text;
                        login.Password = txtPassword.Text;
                        db.Login.Update(login);
                        db.SaveChanges();
                        Application.Restart();

                    }

                }
            }
           
        }

        private void btnLogin_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void btnLogin_MouseMove(object sender, MouseEventArgs e)
        {
          
        }
    }
}
