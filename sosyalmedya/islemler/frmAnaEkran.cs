using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sosyalmedya.NttModels;

namespace sosyalmedya
{
    
    public partial class frmAnaEkran : Form
    {
        List<tbl_kullanici> kullist;
        List<tbl_takip> takiplist;
        List<tbl_kullanicigönderi> postlist;
        List<tbl_gyorum> yorumlist;
        public frmAnaEkran()
        {
            InitializeComponent();
            listele("");
            kendilist("");
            postlistele("");
        }
        DbFestegramEntities1 db = new DbFestegramEntities1();
        string listsecenek = "oner";
        void listele(string values)
        {
            dataGridView1.Rows.Clear();
            int sa = 0;
            if (values.Equals(""))
                kullist= db.tbl_kullanici.ToList();
            else
                kullist = db.tbl_kullanici.Where(x => x.kullanici_ad.Contains(values)).ToList();
            //-----------------------------------------------------------------------------------
            if (values.Equals(""))
                takiplist = db.tbl_takip.ToList();
            else
                takiplist = db.tbl_takip.Where(x => x.takipeden.Contains(values)).ToList();


            if (listsecenek.Equals("oner"))
            {
                foreach (var item in kullist)
                {
                    if (item.sil_id == 1 && label2.Text != item.kullanici_ad)
                    {
                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[sa].Cells[1].Value = item.kullanici_ad;
                        dataGridView1.Rows[sa].Cells[2].Value = item.takipci;
                        dataGridView1.Rows[sa].Cells[3].Value = item.takip;
                        sa++;
                    }


                }
            }
            else if (listsecenek.Equals("takip"))
            {
                foreach (var item in takiplist)
                {
                    if (label2.Text == item.takipeden)
                    {
                        foreach (var ite in kullist)
                        {
                            if (item.takipedilen.Equals(ite.kullanici_ad))
                            {
                                dataGridView1.Rows.Add();
                                dataGridView1.Rows[asw].Cells[1].Value = ite.kullanici_ad;
                                dataGridView1.Rows[asw].Cells[2].Value = ite.takipci;
                                dataGridView1.Rows[asw].Cells[3].Value = ite.takip;

                            }
                        }
                    }
                }
            }
            else if (listsecenek.Equals("takipci"))
            {
                foreach (var item in takiplist)
                {
                    if (label2.Text == item.takipedilen)
                    {
                        foreach (var ite in kullist)
                        {
                            if (item.takipeden.Equals(ite.kullanici_ad))
                            {
                                dataGridView1.Rows.Add();
                                dataGridView1.Rows[asw].Cells[1].Value = ite.kullanici_ad;
                                dataGridView1.Rows[asw].Cells[2].Value = ite.takipci;
                                dataGridView1.Rows[asw].Cells[3].Value = ite.takip;

                            }
                        }
                    }
                }
            }
          
        }
        private void takipbırak(string values)
        {
            int isistem = dataGridView1.CurrentRow.Index;
            string isim = dataGridView1.Rows[isistem].Cells[1].Value.ToString();

            if (values.Equals(""))
                kullist = db.tbl_kullanici.ToList();
            else
                kullist = db.tbl_kullanici.Where(x => x.kullanici_ad.Contains(values)).ToList();
            //-----------------------------------------------------------------------------------
            if (values.Equals(""))
                takiplist = db.tbl_takip.ToList();
            else
                takiplist = db.tbl_takip.Where(x => x.takipeden.Contains(values)).ToList();
            
            
            foreach (var item in takiplist)
            {
                if (label2.Text.Equals(item.takipeden) && isim.Equals(item.takipedilen))
                {
                    foreach (var ite in kullist)
                    {
                        if (item.takipedilen==ite.kullanici_ad)
                        {
                            ite.takipci--;
                            db.SaveChanges();
                            item.sil_id = 0;
                        }
                        if (item.takipeden==ite.kullanici_ad)
                        {
                            ite.takip--;
                        }
                    }
                  
                }
            }
        }
        private void lblgexit_Click(object sender, EventArgs e)
        {
            pnlgeribildirim.Visible = false;
            pnlgonderi.Visible = false;
        }

        private void btnbildir_Click(object sender, EventArgs e)
        {
            pnlgeribildirim.Visible = true;
        }

        private int geribildirim(tbl_geribildirim gb)
        {
            db.tbl_geribildirim.Add(gb);
            db.SaveChanges();
            int id = db.tbl_geribildirim.ToList().Last().id;
            return id;
        }
        private void btnggonder_Click(object sender, EventArgs e)
        {
            tbl_geribildirim geribil = new tbl_geribildirim();
            geribil.gonderen = label2.Text;
            geribil.kullanici_id = 1;
            geribil.tip = cboxkonu.Text;
            geribil.bildirim = rtxtgbm.Text;
            int geribildirim_id = geribildirim(geribil);
            db.SaveChanges();
            pnlyorumyap.Visible = false;
            yorumlistele("");

        }
        private int takipetir(tbl_takip takip)
        {
            db.tbl_takip.Add(takip);
            db.SaveChanges();
            int id = db.tbl_takip.ToList().Last().id;
            return id;
        }

        private void takipet(string values)
        {
            tbl_takip tak = new tbl_takip();
            if (values.Equals(""))
                kullist = db.tbl_kullanici.ToList();
            else
                kullist = db.tbl_kullanici.Where(x => x.kullanici_ad.Contains(values)).ToList();

            int isistem = dataGridView1.CurrentRow.Index;
            string isim = dataGridView1.Rows[isistem].Cells[1].Value.ToString();
            foreach (var item in kullist)
            {
                if (item.kullanici_ad.Equals(isim))
                {
                    item.takipci++;
                }
            }
            foreach (var item in kullist)
            {
                if (label2.Text.Equals(item.kullanici_ad))
                {
                    item.takip++;
                }
            }
            tak.takipeden = label2.Text;
            tak.takipedilen = isim;
            int takip_id = takipetir(tak);
            db.SaveChanges();
            listele("");
        }
        private void lblexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btntakip_Click(object sender, EventArgs e)
        {
            takipet("");
            kendilist("");
            listele("");

        }
        int asw = 0;
        private void kendilist(string values)
        {
            if (values.Equals(""))
                kullist = db.tbl_kullanici.ToList();
            else
                kullist = db.tbl_kullanici.Where(x => x.kullanici_ad.Contains(values)).ToList();
            foreach (var item in kullist)
            {
                if (label2.Text==item.kullanici_ad)
                {
                    lblgonderisayısı.Text = item.gonderisayi.ToString();
                    lbltakip.Text = item.takip.ToString();
                    lbltakipci.Text = item.takipci.ToString();
                }
            }
        }
      
      private void tkpkontrol(string values) 
        {
            int isistem = dataGridView1.CurrentRow.Index;
            string isim = dataGridView1.Rows[isistem].Cells[1].Value.ToString();

            if (values.Equals(""))
                kullist = db.tbl_kullanici.ToList();
            else
                kullist = db.tbl_kullanici.Where(x => x.kullanici_ad.Contains(values)).ToList();
            //-----------------------------------------------------------------------------------
            if (values.Equals(""))
                takiplist = db.tbl_takip.ToList();
            else
                takiplist = db.tbl_takip.Where(x => x.takipeden.Contains(values)).ToList();

            foreach (var item in takiplist)
            {
                if (label2.Text.Equals(item.takipeden) && isim.Equals(item.takipedilen))
                {
                    btntakip.Visible = false;
                    btntakipbırak.Visible = true;

                }
                else
                {
                    btntakip.Visible = true;
                    btntakipbırak.Visible = false;
                }
            }
        }
        private void btnsonerilen_Click(object sender, EventArgs e)
        {
            listsecenek = "oner";
            listele("");
        }

        private void btnstakipci_Click(object sender, EventArgs e)
        {
            listsecenek = "takipci";
            listele("");
        }

        private void btnstakip_Click(object sender, EventArgs e)
        {
            listsecenek = "takip";
            listele("");
        }
     
        int mow, mowY, mowX;

        private void pnlcubuk_MouseUp(object sender, MouseEventArgs e)
        {
            mow = 0;
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            tkpkontrol("");
        }

        private void btntakipbırak_Click(object sender, EventArgs e)
        {
            takipbırak("");
        }

        private void pnlcubuk_MouseDown(object sender, MouseEventArgs e)
        {
            mow = 1;
            mowX = e.X;
            mowY = e.Y;
        }

        private void pnlcubuk_MouseMove(object sender, MouseEventArgs e)
        {
            if (mow == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mowX, MousePosition.Y - mowY);
            }
        }
        private void postlistele(string values)
        {
            dataGridViewgonderi.Rows.Clear();
            if (values.Equals(""))
                kullist = db.tbl_kullanici.ToList();
            else
                kullist = db.tbl_kullanici.Where(x => x.kullanici_ad.Contains(values)).ToList();
            //-----------------------------------------------------------------------------------
            if (values.Equals(""))
                takiplist = db.tbl_takip.ToList();
            else
                takiplist = db.tbl_takip.Where(x => x.takipeden.Contains(values)).ToList();
            //------------------------------------------------------------------------------------
            if (values.Equals(""))
                yorumlist = db.tbl_gyorum.ToList();
            else
                yorumlist = db.tbl_gyorum.Where(x => x.kullanici_ad.Contains(values)).ToList();
            //------------------------------------------------------------------------------------
            if (values.Equals(""))
                postlist = db.tbl_kullanicigönderi.ToList();
            else
                postlist = db.tbl_kullanicigönderi.Where(x => x.kullanici_ad.Contains(values)).ToList();
            int wa = 0;

            foreach (var item in postlist)
            {
                    dataGridViewgonderi.Rows.Add();
                    dataGridViewgonderi.Rows[wa].Cells[0].Value = item.kullanici_ad;
                    dataGridViewgonderi.Rows[wa].Cells[1].Value = item.post;
            }


            //int sayac = 0;
            //foreach (var item in postlist)
            //{
            //    dataGridViewgonderi.Rows.Add();
            //    sayac++;
            //    if (sayac==1)
            //    {
            //        dataGridViewgonderi.Rows[wa].Cells[0].Value = item.kullanici_ad;
            //    }
            //    else if (sayac==2)
            //    {
            //        dataGridViewgonderi.Rows[wa].Cells[0].Value = item.post;
            //    }
            //    else if (sayac==3)
            //    {
            //        dataGridViewgonderi.Rows[wa].Cells[0].Value = item.aciklama;
            //        sayac = 0;
            //    }
            //}

        }

        private void btngpaylas_Click(object sender, EventArgs e)
        {
            gonderipaylas("");
            postlistele("");
            pnlgonderi.Visible = false;
        }
        private void btngonderipaylas_Click(object sender, EventArgs e)
        {
            pnlgonderi.Visible = true;
            postlistele("");
        }
        private void dataGridViewgonderi_Click(object sender, EventArgs e)
        {
            yorumlistele("");
        }
        int awq = 0;
        private void yorumlistele(string values)
        {
            dataGridViewyorum.Rows.Clear();
            int isistem = dataGridViewgonderi.CurrentRow.Index;
            string isim = dataGridViewgonderi.Rows[isistem].Cells[0].Value.ToString();
            string posmesaj = dataGridViewgonderi.Rows[isistem].Cells[1].Value.ToString();
            if (values.Equals(""))
                yorumlist = db.tbl_gyorum.ToList();
            else
                yorumlist = db.tbl_gyorum.Where(x => x.kullanici_ad.Contains(values)).ToList();
            //------------------------------------------------------------------------------------
            if (values.Equals(""))
                postlist = db.tbl_kullanicigönderi.ToList();
            else
                postlist = db.tbl_kullanicigönderi.Where(x => x.kullanici_ad.Contains(values)).ToList();
            foreach (var item in postlist)
            {
                if (isim.Equals(item.kullanici_ad)&&posmesaj.Equals(item.post))
                {
                    foreach (var ite in yorumlist)
                    {
                        if (item.kullanici_ad.Equals(ite.kullanici_ad)&&item.post.Equals(ite.post))
                        {
                            dataGridViewyorum.Rows.Add();
                            dataGridViewyorum.Rows[awq].Cells[0].Value = ite.gonderen;
                            dataGridViewyorum.Rows[awq].Cells[1].Value = ite.yorum;
                            awq++;
                        }
                    }
                }
            }
        }

        private void btngonderipaylas_Click_1(object sender, EventArgs e)
        {
            pnlgonderi.Visible = true;
        }

        private void btnyorumyap_Click(object sender, EventArgs e)
        {
            pnlyorumyap.Visible = true;
        }

        private void dataGridViewgonderi_Click_1(object sender, EventArgs e)
        {
            yorumlistele("");
        }

        private int gpaylasid(tbl_kullanicigönderi post)
        {
            db.tbl_kullanicigönderi.Add(post);
            db.SaveChanges();
            int id = db.tbl_kullanicigönderi.ToList().Last().id;
            return id;
        }
        private void gonderipaylas(string values)
        {
            tbl_kullanicigönderi kpost = new tbl_kullanicigönderi();
            if (values.Equals(""))
                kullist = db.tbl_kullanici.ToList();
            else
                kullist = db.tbl_kullanici.Where(x => x.kullanici_ad.Contains(values)).ToList();
            foreach (var item in kullist)
            {
                if (label2.Text==item.kullanici_ad)
                {
                    item.gonderisayi++;
                }
            }
            kpost.kullanici_ad = label2.Text;
            kpost.post = rtxtpost.Text;
            kpost.sil_id = 1;
            kpost.aciklama = "";
            int paylas_id = gpaylasid(kpost);
            db.SaveChanges();
        }

        private void btnyorpaylas_Click(object sender, EventArgs e)
        {
            yorumyap("");
        }

        private int yorumyapid(tbl_gyorum yor)
        {
            db.tbl_gyorum.Add(yor);
            db.SaveChanges();
            int id = db.tbl_gyorum.ToList().Last().id;
            return id;
        }
        private void yorumyap(string values)
        {
            tbl_gyorum yorum = new tbl_gyorum();
            int isistem = dataGridViewgonderi.CurrentRow.Index;
            string isim = dataGridViewgonderi.Rows[isistem].Cells[0].Value.ToString();
            string posmesaj = dataGridViewgonderi.Rows[isistem].Cells[1].Value.ToString();
            yorum.kullanici_ad = isim;
            yorum.post = posmesaj;
            yorum.gonderen = label2.Text;
            yorum.yorum = ryorumyap.Text;
            int yorum_id = yorumyapid(yorum);
            db.SaveChanges();

        }
    }
}