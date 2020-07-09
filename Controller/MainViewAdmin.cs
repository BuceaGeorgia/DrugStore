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
    public partial class MainViewAdmin : Form
    {
        private ClientController ctr;
        private readonly IList<User> users;
        public MainViewAdmin(ClientController cl)
        {
            this.ctr = cl;

            InitializeComponent();
            users = new BindingList<User>((List<User>)ctr.getalluser());
            dataGridView1.DataSource = users;
            dataGridView1.Columns["Password"].Visible = false;
            dataGridView1.Columns["UserID"].Visible = false;

            comboBox1.DataSource = Enum.GetValues(typeof(Status));
        }
        private void updateListBox(DataGridView dg, IList<User> newData)
        {
            dg.DataSource = null;
            dg.DataSource = newData;
            dataGridView1.Columns["Password"].Visible = false;
            dataGridView1.Columns["UserID"].Visible = false;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MainViewAdmin_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
 
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string v=comboBox1.SelectedValue.ToString();
                Status MyStatus = (Status)Enum.Parse(typeof(Status), v, true);
                ctr.add_user(username.Text, password.Text, MyStatus,section.Text);
                List<User> res= ctr.getalluser();
                updateListBox(dataGridView1, res);
                MessageBox.Show(this, " Succes: ", "User was added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            catch(Exception ex)
            {
                MessageBox.Show(this, " Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void MainViewAdmin_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            Console.WriteLine("ChatWindow closing " + e.CloseReason);
            if (e.CloseReason == CloseReason.UserClosing)
            {
                ctr.logout();
                //ctr.updateEvent -= userUpdate;
                Application.Exit();
            }
        }
    }
}
