using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using ClassCartoons;

namespace WindFormCartoons
{
    public partial class FrmAddCompany : Form
    {

        public int id_cart;
        string name_cart;
        private ClassCartoons.DBCartoonsEntities ctx;

        public FrmAddCompany()
        {
            InitializeComponent();
            ctx = new ClassCartoons.DBCartoonsEntities();
            ctx.DIC_COMPANY.Load();
            this.dICCOMPANYBindingSource.DataSource = ctx.DIC_COMPANY.Local.ToBindingList();
        }



        public FrmAddCompany(int cart_id, string cart_name)
        {
            InitializeComponent();
            ctx = new ClassCartoons.DBCartoonsEntities();
            ctx.DIC_COMPANY.Load();
            this.dICCOMPANYBindingSource.DataSource = ctx.DIC_COMPANY.Local.ToBindingList();
            Text = String.Concat(Text, " ", cart_name);
            id_cart = cart_id;
            name_cart = cart_name;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int gr_id = (int)(dICCOMPANYBindingSource.Current as DataRowView)["CP_ID"];
                /*dT_ADD_GENRETableAdapter1.InsertQuery(id_cart, gr_id);*/
                this.Close();
            }
            catch
            {
                MessageBox.Show("Помилка додавання інформації про жанр мультфільму", "Додавання інформації про жанр мультфільму");
            }
        }
    }
}