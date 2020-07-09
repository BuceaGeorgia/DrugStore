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
    public partial class MainViewStaff : Form
    {
        private ClientController cl;
        private readonly IList<Order> orders;
        public MainViewStaff(ClientController cl)
        {
            this.cl = cl;
           
            InitializeComponent();
            orders = new BindingList<Order>((List<Order>)cl.getMedicalStaff(cl.user.SectieID));
            dataGridView1.DataSource = orders;

            cl.updateEvent += userUpdate;
            drugs.View = View.Details;
            drugs.Columns.Add("ID");
            drugs.Columns.Add("Name");
            drugs.Columns.Add("Description");
            Citems.View = View.Details;
            Citems.Columns.Add("Drug");
            Citems.Columns.Add("Quantity");
        }

        public delegate void UpdateListBoxCallback(DataGridView list, IList<Order> data);
        public void userUpdate(object sender, UserEventArgs e)
        {
            if (e.UserEventType == UserEvent.TAKE_ORDER)
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
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //search and find drugs with given name
            drugs.Items.Clear();
            foreach(var el in this.cl.filter(drugname.Text))
            {
                string[] row = { el.Name,el.Description};
                var listViewItem = new ListViewItem(el.DrugID.ToString());
                listViewItem.SubItems.Add(el.Name);
                listViewItem.SubItems.Add(el.Description);
                drugs.Items.Add(listViewItem);

            }
 
        }

        private void add_Click(object sender, EventArgs e)
        {
            //add a new item to the temporary list in controller
            
            try
            {
                
                cl.additem(iddrugtext.Text, quantitytext.Text);
                //adds the item to listview
                Citems.Items.Clear();
                foreach (var el in this.cl.currOrder)
                {
                    string[] row = {el.DrugID.ToString(),el.Quantity.ToString() };
                    var listViewItem = new ListViewItem(el.DrugID.ToString());
                    listViewItem.SubItems.Add(el.Quantity.ToString());
                   
                    Citems.Items.Add(listViewItem);

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(this, " Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void Citems_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void placeorde_Click(object sender, EventArgs e)
        {
            try
            {
                cl.place_order();
                MessageBox.Show(this, " Placed order ", "New order was placed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                List<Order> res = cl.getMedicalStaff(cl.user.SectieID);
                updateListBox(dataGridView1, res);
            }catch(Exception ex)
            {
                MessageBox.Show(this, " Error ", "New order was not placed", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void drugs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MainViewStaff_FormClosing(object sender, FormClosingEventArgs e)
        {
            Console.WriteLine("ChatWindow closing " + e.CloseReason);
            if (e.CloseReason == CloseReason.UserClosing)
            {
                cl.logout();
                //ctr.updateEvent -= userUpdate;
                Application.Exit();
            }
        }
    }
}
