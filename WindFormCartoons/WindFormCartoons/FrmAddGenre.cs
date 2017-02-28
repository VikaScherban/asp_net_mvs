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
    public partial class FrmAddGenre : Form
    {
        public int id_cart;
        string name_cart;
        private ClassCartoons.DBCartoonsEntities ctx;

        public FrmAddGenre()
        {
            InitializeComponent();
            ctx = new ClassCartoons.DBCartoonsEntities();
            ctx.DIC_GENRE.Load();
            this.dICGENREBindingSource.DataSource = ctx.DIC_GENRE.Local.ToBindingList();
        }



        public FrmAddGenre(int cart_id, string cart_name)
        {
            InitializeComponent();
            ctx = new ClassCartoons.DBCartoonsEntities();
            ctx.DIC_GENRE.Load();
            this.dICGENREBindingSource.DataSource = ctx.DIC_GENRE.Local.ToBindingList();
            Text = String.Concat(Text, " ", cart_name);
            id_cart = cart_id;
            name_cart = cart_name;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int gr_id = (int)(dICGENREBindingSource.Current as DataRowView)["GR_ID"];
                GENRE_CARTOONS new_row = new GENRE_CARTOONS();
                new_row.GC_CR = id_cart;
                new_row.GC_GR = gr_id;
                ctx.SaveChanges();
                this.Close();
            }
            catch
            {
                MessageBox.Show("Помилка додавання інформації про жанр мультфільму", "Додавання інформації про жанр мультфільму");
            }
        }
    }
}
