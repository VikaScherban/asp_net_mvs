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
    public partial class FormSearch : Form
    {
        private int dgen_id;
        private readonly string dgen_name;
        private ClassCartoons.DBCartoonsEntities ctx_cartoon;

        public FormSearch()
        {
            InitializeComponent();
         }

        public FormSearch(int gen_id, string gen_name)
        {
            InitializeComponent();
            dgen_id = gen_id;
            dgen_name = gen_name;

            ctx_cartoon = new ClassCartoons.DBCartoonsEntities();
            Text = String.Concat(Text, " ", dgen_name);

            FindCartoon();
        }

      private void FindCartoon()
        {
            var chE = ctx_cartoon.ChangeTracker.Entries<FrmCartoons>().Where(a => a.State != EntityState.Unchanged).ToList();
            if (chE.Count != 0)
            {
                MessageBox.Show("Необхідно зберегти зміни!", "Перегляд книг за жанром");
            }
            else
            {
                ctx_cartoon.Dispose();
                ctx_cartoon = new ClassCartoons.DBCartoonsEntities();

                var query = (from c in ctx_cartoon.CARTOONS
                             where c.GENRE_CARTOONS.Any(cr => cr.GC_GR == dgen_id)
                             select c);                             
                if (!String.IsNullOrWhiteSpace(tBCartoonName.Text))
                {
                    query = query.Where(c => c.CR_NAME.Contains(tBCartoonName.Text));
                }

                if (!String.IsNullOrWhiteSpace(tBRating.Text))
                {
                    float f1 = float.Parse(tBRating.Text);
                    query = query.Where(c => (c.CR_RATING <= f1 + 1) && (c.CR_RATING >=f1-1));
                }
                   
               
                if (!String.IsNullOrWhiteSpace(tBYear.Text))
                {
                    int i1 = int.Parse(tBYear.Text);
                    query = query.Where(c => c.CR_YEAR == i1);
                }
                    

                if (!String.IsNullOrWhiteSpace(tBDuration.Text))
                {
                    int i1 = int.Parse(tBDuration.Text);
                    query = query.Where(c => c.CR_DURATION == i1);
                }
                cARTOONSBindingSource.DataSource = query.ToList(); ;
            }
        }
          private void button_search_Click(object sender, EventArgs e)
          {
              FindCartoon();
          }

          private void button_save_Click(object sender, EventArgs e)
          {
              ctx_cartoon.SaveChanges();
          }

    }
}
