using Controller.Controller;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controller
{
    public partial class LoginView : Form
    {
        private ClientController ctr;
        public LoginView(ClientController cl)
        {
            InitializeComponent();
            this.ctr = cl;
        }

        private void LoginView_Load(object sender, EventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        {
            try
            {
                this.ctr.login(textuser.Text, textpassword.Text);
                if (ctr.user.Status == Status.Admin)
                {
                    MainViewAdmin mwa = new MainViewAdmin(ctr);
                    mwa.Show();
                    this.Hide();
                }
                else
                {
                    if(this.ctr.user.Status ==Status.MedicalStaff)
                    {
                        MainViewStaff mws = new MainViewStaff(ctr);
                        mws.Show();
                        this.Hide();
                    }
                    else
                    {
                        MainViewPharmacist mwp = new MainViewPharmacist(ctr);
                        mwp.Show();
                        this.Hide();
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show(this, "Login Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void lab_Click(object sender, EventArgs e)
        {

        }
    }
}
