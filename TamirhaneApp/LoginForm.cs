using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TamirhaneApp
{
    public partial class LoginForm : Form
    {
        AlertForm alertForm = new AlertForm();
        HomeForm homeForm = new HomeForm();
        TamiraneDBEntities tamiraneDBEntities = new TamiraneDBEntities();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text != "" && txtUserName.Text != "")
            {
                //Burada girişi yapılan kullanıcı adı ve şifrenin veritabanında bulunup bulunmadığı kontrolü yapılır.
                List<girisekrani> isExistList = tamiraneDBEntities.girisekrani.Where(x => x.kullaniciadi == txtUserName.Text && x.sifre == txtPassword.Text).ToList();

                if (isExistList.Count != 0 )
                {

                    homeForm.Show();
                    this.Hide();
                }
                else
                {
                    alertForm.Show();
                    alertForm.lblAlertNew.Text = "Kullanıcı adı ya da şifre yanlıştır.";

                  
                }
            }
            else
            {
                alertForm.Show();
                alertForm.lblAlertNew.Text = "Kullanıcı adı ya da şifre alanı boş bırakıldı.";
            }
        }

            private void LoginForm_Load(object sender, EventArgs e)
            {

                      
        }

       
    }
    }
