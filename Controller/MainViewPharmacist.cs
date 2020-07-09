
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
   
    public partial class MainViewPharmacist : Form
    {
        private ClientController cl;
        private readonly IList<Order> users;

        public MainViewPharmacist(ClientController cl)
        {
            this.cl = cl;
            cl.updateEvent += userUpdate;
            InitializeComponent();
            users = new BindingList<Order>((List<Order>)cl.getOrdersPharmacist());
            dataGridView1.DataSource = users;
        }

        public delegate void UpdateListBoxCallback(DataGridView list, IList<Order> data);
        public void userUpdate(object sender, UserEventArgs e)
        {
            if (e.UserEventType == UserEvent.PLACED_ORDER)
            {
                Console.WriteLine("E in userUpdate");
                dataGridView1.BeginInvoke(new UpdateListBoxCallback(this.updateListBox), new Object[] { dataGridView1, (List<Order>)e.Data });
                //   friendList.BeginInvoke((Action) delegate { friendList.DataSource = friendsData; });
            }

        }
        private void updateListBox(DataGridView dg, IList<Order> newData)
        {
            dg.DataSource = null;
            dg.DataSource = newData;

        }
        private void MainViewPharmacist_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                int id = Int32.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                cl.takeOrder(id);
                List<Order> res = cl.getOrdersPharmacist();
                updateListBox(dataGridView1, res);
            }
            else
            {
                MessageBox.Show(this, " Error: ", "Choose an order", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {

        }

        private void MainViewPharmacist_FormClosing(object sender, FormClosingEventArgs e)
        {
            Console.WriteLine("ChatWindow closing " + e.CloseReason);
            if (e.CloseReason == CloseReason.UserClosing)
            {
                cl.logout();
                cl.updateEvent -= userUpdate;
                Application.Exit();
            }
        }
    }
}
