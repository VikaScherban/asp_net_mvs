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
    public partial class FrmCartoons : Form
    {
        private ClassCartoons.DBCartoonsEntities ctx;

        public FrmCartoons()
        {
            InitializeComponent();
            ctx = new ClassCartoons.DBCartoonsEntities();

            ctx.DIC_GENRE.Load();
            this.dICGENREBindingSource.DataSource = ctx.DIC_GENRE.Local.ToBindingList();

            ctx.DIC_DIRACTORS.Load();
            this.dICDIRACTORSBindingSource.DataSource = ctx.DIC_DIRACTORS.Local.ToBindingList();

            ctx.DIC_COMPANY.Load();
            this.dICCOMPANYBindingSource.DataSource = ctx.DIC_COMPANY.Local.ToBindingList();

            ctx.DIC_COUNRTY.Load();
            this.dICCOUNRTYBindingSource.DataSource = ctx.DIC_COUNRTY.Local.ToBindingList();

            ctx.CARTOONS.Load();
            this.cARTOONSBindingSource.DataSource = ctx.CARTOONS.Local.ToBindingList();

            ctx.DIC_CARTOON_STATUSES.Load();
            this.dICCARTOONSTATUSESBindingSource.DataSource = ctx.DIC_CARTOON_STATUSES.Local.ToBindingList();

        }

    

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            ctx.Dispose();
        }

        private void button_save_cartoon_Click(object sender, EventArgs e)
        {
            ctx.SaveChanges();
        }

        private void button_save_genre_Click(object sender, EventArgs e)
        {
            ctx.SaveChanges();
        }

        private void button_save_diretors_Click(object sender, EventArgs e)
        {
            ctx.SaveChanges();
        }

        private void button_save_company_Click(object sender, EventArgs e)
        {
            ctx.SaveChanges();
        }

        private void button_save_country_Click(object sender, EventArgs e)
        {
            ctx.SaveChanges();
        }

        private void button_save_statuses_Click(object sender, EventArgs e)
        {
            ctx.SaveChanges();
        }


        private void button_delete_genre_Click(object sender, EventArgs e)
        {
             try
            {
                DIC_GENRE genr = (DIC_GENRE) dGVGenre.CurrentRow.DataBoundItem;
                var b = (from c in ctx.CARTOONS where c.GENRE_CARTOONS.Any(f => f.GC_GR == genr.GR_ID) select c).Any(); 
                if (b)
                    MessageBox.Show("Видаляти не можна! До жанрів прив'язані мультфільми!", "Помилка видалення жанра");
                else
                {
                    dICGENREBindingSource.RemoveCurrent();
                    ctx.SaveChanges();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Помилка видалення інформації про жанр", "Видалення інформації про жанр");
                throw;
            }
        }

        private void button_delete_diractors_Click(object sender, EventArgs e)
        {
             try
            {
                DIC_DIRACTORS dir = (DIC_DIRACTORS) dGVDiractors.CurrentRow.DataBoundItem;
                var   b = (from  c  in  ctx.DIRACTORS_CARTOONS  where  (c.DK_DR == dir.DR_ID)select c).Any();
                if (b)
                    MessageBox.Show("Видаляти не можна! До режисерів прив'язані мультфільми!", "Помилка видалення режисера");
                else
                {
                    dICDIRACTORSBindingSource.RemoveCurrent();
                    ctx.SaveChanges();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Помилка видалення інформації про режисера", "Видалення інформації про режисера");
                throw;
            }
        }

        private void button_delete_company_Click(object sender, EventArgs e)
        {
             try
            {
                DIC_COMPANY com = (DIC_COMPANY) dGVCompany.CurrentRow.DataBoundItem;
               var   b = (from  c  in  ctx.COMPANY_CARTOONS  where  (c.CC_CP == com.CP_ID) select c).Any();
                if (b)
                    MessageBox.Show("Видаляти не можна! До компанії прив'язані мультфільми!", "Помилка видалення компанії");
                else
                {
                    dICCOMPANYBindingSource.RemoveCurrent();
                    ctx.SaveChanges();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Помилка видалення інформації про компанію", "Видалення інформації про компанію");
                throw;
            }
        }

        private void button_delete_country_Click(object sender, EventArgs e)
        {
            try
            {
                DIC_COUNRTY coun = (DIC_COUNRTY)dGVCountry.CurrentRow.DataBoundItem;
                var b = (from c in ctx.DIC_COMPANY where (c.CP_CT == coun.CT_ID) select c).Any();
                if (b)
                    MessageBox.Show("Видаляти не можна! До країни прив'язані компанії!", "Помилка видалення країни");
                else
                {
                    dICCOUNRTYBindingSource.RemoveCurrent();
                    ctx.SaveChanges();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Помилка видалення інформації про країну", "Видалення інформації про країну");
                throw;
            }
        }

        private void button_delete_statuses_Click(object sender, EventArgs e)
        {
            try
            {
                DIC_CARTOON_STATUSES st = (DIC_CARTOON_STATUSES)dGVStatuses.CurrentRow.DataBoundItem;
                var b = (from c in ctx.CARTOONS where (c.CR_CS ==  st.CS_ID)select c).Any();
                if (b)
                    MessageBox.Show("Видаляти не можна! До компанії прив'язані мультфільми!", "Помилка видалення компанії");
                else
                {
                    dICCARTOONSTATUSESBindingSource.RemoveCurrent();
                    ctx.SaveChanges();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Помилка видалення інформації про компанію", "Видалення інформації про компанію");
                throw;
            }
        }

        private void button_delete_cartoon_Click(object sender, EventArgs e)
        {
            cARTOONSBindingSource.RemoveCurrent();
            ctx.SaveChanges();
        }

        private void dGVGenre_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var chE = ctx.ChangeTracker.Entries<DIC_GENRE>().Where(a => a.State != EntityState.Unchanged).ToList();
            if (chE.Count != 0)
            {
                MessageBox.Show("Необхідно зберегти зміни!", "Перегляд книг за категорією");
            }
            else
            {
                try
                {
                    DIC_GENRE dgen = (DIC_GENRE)dGVGenre.CurrentRow.DataBoundItem;
                    FormSearch cartoonDialog = new FormSearch(dgen.GR_ID, dgen.GR_NAME);
                    cartoonDialog.ShowDialog(this);
                    cartoonDialog.Dispose();
                }
                catch
                {
                    MessageBox.Show("Помилка переходу до списку мультфільмів", "Перехід до списку мультфільмів");
                }
            }
        }

        private void button_add_genre_Click(object sender, EventArgs e)
        {
            int id = (int)dGVCartoons.CurrentRow.Cells["cRIDDataGridViewTextBoxColumn"].Value;
            string name = (string)dGVCartoons.CurrentRow.Cells["cRNAMEDataGridViewTextBoxColumn"].Value;
            FrmAddGenre genDialog = new FrmAddGenre(id, name);

            genDialog.ShowDialog(this);
            genDialog.Dispose();
        }

        private void button_add_diractor_Click(object sender, EventArgs e)
        {
            int id = (int)dGVCartoons.CurrentRow.Cells["cRIDDataGridViewTextBoxColumn"].Value;
            string name = (string)dGVCartoons.CurrentRow.Cells["cRNAMEDataGridViewTextBoxColumn"].Value;
            FrmAddDiractor dirDialog = new FrmAddDiractor(id, name);

            dirDialog.ShowDialog(this);
            dirDialog.Dispose();
        }

        private void button_add_company_Click(object sender, EventArgs e)
        {
            int id = (int)dGVCartoons.CurrentRow.Cells["cRIDDataGridViewTextBoxColumn"].Value;
            string name = (string)dGVCartoons.CurrentRow.Cells["cRNAMEDataGridViewTextBoxColumn"].Value;
            FrmAddCompany dirDialog = new FrmAddCompany(id, name);

            dirDialog.ShowDialog(this);
            dirDialog.Dispose();
        }

        private void button_del_genre_Click(object sender, EventArgs e)
        {
            dICGENREBindingSource1.RemoveCurrent();
            ctx.SaveChanges();
        }

        private void button_del_diractor_Click(object sender, EventArgs e)
        {
            dICDIRACTORSBindingSource1.RemoveCurrent();
            ctx.SaveChanges();
        }

        private void button_del_company_Click(object sender, EventArgs e)
        {
            dICCOMPANYBindingSource1.RemoveCurrent();
            ctx.SaveChanges();
        }

        private void dGVCartoons_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = (int)dGVCartoons.CurrentRow.Cells["cRIDDataGridViewTextBoxColumn"].Value;
                

                /*dtdiC_GENRETableAdapter1.FillByCR_IDInGenreCartoons(dsCartoons.DTDIC_GENRE, id);
                dtdiC_DIRACORSTableAdapter1.FillByCR_IDInDiractorsCartoons(dsCartoons.DTDIC_DIRACORS, id);*/
            }
            catch
            {
                MessageBox.Show("Помилка відображення списку жанрів та режисерів з таким іd мультфільму", "Відображення жанрів та режисерів мультфільму");
            }
        }
    }
}
