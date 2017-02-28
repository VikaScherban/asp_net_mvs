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
    public partial class FrmAddDiractor : Form
    {
        public int id_cart;
        string name_cart;
        private ClassCartoons.DBCartoonsEntities ctx;

        public FrmAddDiractor()
        {
            InitializeComponent();
            ctx = new ClassCartoons.DBCartoonsEntities();
            ctx.DIC_DIRACTORS.Load();
            this.dICDIRACTORSBindingSource.DataSource = ctx.DIC_DIRACTORS.Local.ToBindingList();
        }

        public FrmAddDiractor(int cart_id, string cart_name)
        {
            InitializeComponent();
            ctx = new ClassCartoons.DBCartoonsEntities();
            ctx.DIC_DIRACTORS.Load();
            this.dICDIRACTORSBindingSource.DataSource = ctx.DIC_DIRACTORS.Local.ToBindingList();
            Text = String.Concat(Text, " ", cart_name);
            id_cart = cart_id;
            name_cart = cart_name;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int dir_id = (int)(dICDIRACTORSBindingSource.Current as DataRowView)["DR_ID"];

                /*dtadD_DIRACTORS1TableAdapter1.InsertQuery(id_cart, dir_id);*/
                this.Close();
            }
            catch
            {
                MessageBox.Show("Помилка додавання інформації про режисера мультфільму", "Додавання інформації про режисера мультфільму");
            }
        }
    }
}
