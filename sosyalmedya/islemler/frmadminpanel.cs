using sosyalmedya.NttModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sosyalmedya.islemler
{
    public partial class frmadminpanel : Form
    {
        List<tbl_kullanici> kullist;
        List<tbl_geribildirim> gerlist;
        public frmadminpanel()
        {
            InitializeComponent();
            listele("");
            glistele("");
            tmrsaat.Start();
        }
        DbFestegramEntities1 db = new DbFestegramEntities1();
        #region tutamac
        int mow, mowY, mowX;

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mow = 1;
            mowX = e.X;
            mowY = e.Y;
        }

        private void lblexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mow = 0;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mow == 1)
            { 
                this.SetDesktopLocation(MousePosition.X - mowX, MousePosition.Y - mowY);
            }
        }
        #endregion

 

        private void btnallkullist_Click(object sender, EventArgs e)
        {
            b =5;
            listele("");
        }

        private void btnkulliste_Click(object sender, EventArgs e)
        {
            btnkulliste.Enabled = false;
            btngeribildirm.Enabled =true;

            pnlkullaniciliste.Visible = true;
            pnlgerilist.Visible = false;

            gboxgeribildirim.Visible = false;
            gbkullist.Visible = true;

            listele("");
        }

        private void btnblackkullist_Click(object sender, EventArgs e)
        {
            b = 0;
            listele("");
        }

        private void btnwhitekullist_Click(object sender, EventArgs e)
        {
            b = 1;
            listele("");
        }

        private void btnadminkullist_Click(object sender, EventArgs e)
        {
            b = 2;
            listele("");
            
        }
        int w = 1;
        private void islemler(string values )
        {
          
                tbl_kullanici item = new tbl_kullanici();
                int isistem = dataGridViewkullist.CurrentRow.Index;
                string isim = dataGridViewkullist.Rows[isistem].Cells[1].Value.ToString();
                string sid = dataGridViewkullist.Rows[isistem].Cells[4].Value.ToString();
                if (values.Equals(""))
                    kullist = db.tbl_kullanici.ToList();
                else
                    kullist = db.tbl_kullanici.Where(x => x.kullanici_ad.Contains(values)).ToList();
              
                foreach (var ite in kullist)
                {
                if (isim==ite.kullanici_ad)
                {
                    switch (w)
                    {
                        case 0: ite.sil_id = 0; db.SaveChanges(); break;
                        case 1: ite.sil_id = 1; db.SaveChanges(); break;
                        case 2: ite.sil_id = 2; db.SaveChanges(); break;
                      
                    db.SaveChanges();
                }
                }
            if (sid == "2" || sid == "0")
            {
                btbybkaldır.Enabled = true;
                btnban.Enabled = false;
                btnyetki.Enabled = false;
            }
            else if (sid == "1")
            {
                btbybkaldır.Enabled = false;
                btnban.Enabled = true;
                btnyetki.Enabled = true;
            }
            db.SaveChanges();
              
         
           
         
        }
        private void btbybkaldır_Click(object sender, EventArgs e)
        {
            w = 1;
            islemler("");
            listele("");
        }

        private void dataGridViewkullist_Click(object sender, EventArgs e)
        {
            islemler("");
        }
 
        private void btnban_Click(object sender, EventArgs e)
        {
            w = 0;
            islemler("");
            listele("");
        }

        private void btnyetki_Click(object sender, EventArgs e)
        {
            w = 2;
            islemler("");
            listele("");
        }

        private void dataGridViewkullist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            islemler("");
        }

        int b = 5;
        private void geriokuma(string values)
        {
            tbl_geribildirim gb = new tbl_geribildirim();
            int isistem = dataGridViewgeribildirim.CurrentRow.Index;
            string tip = dataGridViewgeribildirim.Rows[isistem].Cells[3].Value.ToString();
            string mesaj = dataGridViewgeribildirim.Rows[isistem].Cells[4].Value.ToString();
            string gonderen = dataGridViewgeribildirim.Rows[isistem].Cells[2].Value.ToString();
            lbltip.Text = tip;
            txtmesaj.Text = mesaj;
            dataGridViewgeribildirim.Rows.Clear();
            if (values.Equals(""))
            {
                gerlist = db.tbl_geribildirim.ToList();
            }
            else
            {
                gerlist = db.tbl_geribildirim.Where(x => x.gonderen.Contains(values)).ToList();
            }
            foreach (var item in gerlist)
            {
                if (gonderen==item.gonderen&&mesaj==item.bildirim&&tip ==item.tip)
                {
                    item.kullanici_id = 0;
                    db.SaveChanges();
                }
            }
        }
        private void btnoku_Click(object sender, EventArgs e)
        {
            geriokuma("");
            glistele("");
        }
        int za = 2;
        private void btnhespsi_Click(object sender, EventArgs e)
        {
            za = 2;
            glistele("");
        }

        private void btnyeni_Click(object sender, EventArgs e)
        {
            za = 1;
            glistele("");
        }

        private void btneski_Click(object sender, EventArgs e)
        {
            za = 0;
            glistele("");
        }
        
        private void tmrsaat_Tick(object sender, EventArgs e)
        {
            string saat = DateTime.Now.ToLongTimeString();
            lblsaat.Text = saat;
        }

        private void btngeribildirm_Click(object sender, EventArgs e)
        {
            btnkulliste.Enabled = true;
            btngeribildirm.Enabled = false;

            pnlkullaniciliste.Visible = false;
            pnlgerilist.Visible = true;

            gboxgeribildirim.Visible = true;
            gbkullist.Visible = false;
          
            glistele("");
        }
        string tpe = "hepsi";
        private void btnthepsi_Click(object sender, EventArgs e)
        {
            tpe = "hepsi";
            glistele("");
        }

        private void btntsikayet_Click(object sender, EventArgs e)
        {
            tpe = "Şikayet";
            glistele("");
        }

        private void btnthata_Click(object sender, EventArgs e)
        {
            tpe = "Hata";
            glistele("");
        }

        private void btntoneri_Click(object sender, EventArgs e)
        {
            tpe = "Öneri";
            glistele("");
        }

        private void glistele(string values)
        {
            dataGridViewgeribildirim.Rows.Clear();
            int fa = 0;
            if (values.Equals(""))
            {
                gerlist = db.tbl_geribildirim.ToList();
            }
            else
            {
                gerlist = db.tbl_geribildirim.Where(x => x.gonderen.Contains(values)).ToList();
            }
            foreach (var item in gerlist)
            {
                if (tpe.Equals("hepsi"))
                {
                    if (za == 2)
                    {
                        dataGridViewgeribildirim.Rows.Add();
                        dataGridViewgeribildirim.Rows[fa].Cells[0].Value = item.id;
                        if (item.kullanici_id == 1)
                        {
                            dataGridViewgeribildirim.Rows[fa].Cells[1].Value = "X";
                        }
                        else
                        {
                            dataGridViewgeribildirim.Rows[fa].Cells[1].Value = "✓";
                        }
                        dataGridViewgeribildirim.Rows[fa].Cells[2].Value = item.gonderen;
                        dataGridViewgeribildirim.Rows[fa].Cells[3].Value = item.tip;
                        dataGridViewgeribildirim.Rows[fa].Cells[4].Value = item.bildirim;
                    }
                    else if (item.kullanici_id == za)
                    {
                        dataGridViewgeribildirim.Rows.Add();
                        dataGridViewgeribildirim.Rows[fa].Cells[0].Value = item.id;
                        if (item.kullanici_id == 1)
                        {
                            dataGridViewgeribildirim.Rows[fa].Cells[1].Value = "X";
                        }
                        else
                        {
                            dataGridViewgeribildirim.Rows[fa].Cells[1].Value = "✓";
                        }
                        dataGridViewgeribildirim.Rows[fa].Cells[2].Value = item.gonderen;
                        dataGridViewgeribildirim.Rows[fa].Cells[3].Value = item.tip;
                        dataGridViewgeribildirim.Rows[fa].Cells[4].Value = item.bildirim;
                    }

                }
                else if (item.tip==tpe)
                {
                    if (za == 2)
                    {
                        dataGridViewgeribildirim.Rows.Add();
                        dataGridViewgeribildirim.Rows[fa].Cells[0].Value = item.id;
                        if (item.kullanici_id == 1)
                        {
                            dataGridViewgeribildirim.Rows[fa].Cells[1].Value = "X";
                        }
                        else
                        {
                            dataGridViewgeribildirim.Rows[fa].Cells[1].Value = "✓";
                        }
                        dataGridViewgeribildirim.Rows[fa].Cells[2].Value = item.gonderen;
                        dataGridViewgeribildirim.Rows[fa].Cells[3].Value = item.tip;
                        dataGridViewgeribildirim.Rows[fa].Cells[4].Value = item.bildirim;
                    }
                    else if (item.kullanici_id == za)
                    {
                        dataGridViewgeribildirim.Rows.Add();
                        dataGridViewgeribildirim.Rows[fa].Cells[0].Value = item.id;
                        if (item.kullanici_id == 1)
                        {
                            dataGridViewgeribildirim.Rows[fa].Cells[1].Value = "X";
                        }
                        else
                        {
                            dataGridViewgeribildirim.Rows[fa].Cells[1].Value = "✓";
                        }
                        dataGridViewgeribildirim.Rows[fa].Cells[2].Value = item.gonderen;
                        dataGridViewgeribildirim.Rows[fa].Cells[3].Value = item.tip;
                        dataGridViewgeribildirim.Rows[fa].Cells[4].Value = item.bildirim;
                    }
                }
              
              
                fa++;
            }
        }
        int uyesayi=0;
        private void listele(string values)
        {

            dataGridViewkullist.Rows.Clear();
            int sa = 0;
            if (values.Equals(""))
                kullist = db.tbl_kullanici.ToList();
            else
                kullist = db.tbl_kullanici.Where(x => x.kullanici_ad.Contains(values)).ToList();

            foreach (var item in kullist)
            {
                if (b==5)
                {

                    dataGridViewkullist.Rows.Add();
                    dataGridViewkullist.Rows[sa].Cells[0].Value = item.id;
                    dataGridViewkullist.Rows[sa].Cells[1].Value = item.kullanici_ad;
                    dataGridViewkullist.Rows[sa].Cells[2].Value = item.sifre;
                    dataGridViewkullist.Rows[sa].Cells[3].Value = item.eposta;
                    dataGridViewkullist.Rows[sa].Cells[4].Value = item.sil_id;
                    sa++;
                }
                else if (item.sil_id==b)
                {
                    dataGridViewkullist.Rows.Add();
                    dataGridViewkullist.Rows[sa].Cells[0].Value = item.id;
                    dataGridViewkullist.Rows[sa].Cells[1].Value = item.kullanici_ad;
                    dataGridViewkullist.Rows[sa].Cells[2].Value = item.sifre;
                    dataGridViewkullist.Rows[sa].Cells[3].Value = item.eposta;
                    dataGridViewkullist.Rows[sa].Cells[4].Value = item.sil_id;
                    sa++;
                }
                uyesayi++;
            }
            lbluyesayı.Text = uyesayi.ToString() ;
        } 


    }
}
