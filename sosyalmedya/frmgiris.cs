using sosyalmedya.NttModels;
using sosyalmedya.islemler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace sosyalmedya
{
    public partial class frmgiris : Form
    {
        DbFestegramEntities1 db;
        public frmgiris()
        {
            InitializeComponent();
            db =new DbFestegramEntities1();
        }
        List<tbl_kullanici> kullist;
        private void tpgirisyap_Click(object sender, EventArgs e)
        {
            
        }

        private int kullanıcıekle(tbl_kullanici kull)
        {
            db.tbl_kullanici.Add(kull);
            db.SaveChanges();
            int id = db.tbl_kullanici.ToList().Last().id;
            return id;
        }
  

        private void btnkayitol_Click(object sender, EventArgs e)
        {
            kayitol();
        }
        void kayitol()
        {
            
            tbl_kullanici kull = new tbl_kullanici();
            kull.eposta = txtkayiteposta.Text;
            kull.kullanici_ad = txtkayitkuladi.Text;
            kull.sifre = txtkayitsifre.Text;
            kull.id = kull.id;
            kull.sil_id = 1;
            kull.biografi = "";
            kull.profilfoto = "";
            kull.takip = 0;
            kull.takipci = 0;
            kull.gonderisayi = 0;
            int kullanıcıekle_id = kullanıcıekle(kull);
            db.SaveChanges();
            MessageBox.Show("Kayıt İşlemi Başarıyla Gerçekleşti");
            txtkayiteposta.Text = "";
            txtkayitkuladi.Text = "";
            txtkayitsifre.Text = "";
        }
        private void lblexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btngiris_Click(object sender, EventArgs e)
        {
            girisYap("");
        }
        int KalanHak=3;
        public void girisYap(string values)
        {
            String getUserName = txtgiriskuladi.Text;
            String getPassword = txtgirissifre.Text;

            if (txtgirissifre.Text.Equals("") || txtgiriskuladi.Text.Equals(""))
                MessageBox.Show("Kullanıcıadı Ya da Şifre Boş Geçilemez");
            {
                if (values.Equals(""))
                    kullist = db.tbl_kullanici.ToList();

                else
                    kullist = db.tbl_kullanici.Where(x => x.kullanici_ad.Contains(values)).ToList();
                foreach (var item in kullist)
                {
                  
                    if (getUserName.Equals(item.kullanici_ad)&&getPassword.Equals(item.sifre))
                    {
                        if (item.sil_id==3)
                        {
                            frmadminpanel admin = new frmadminpanel();
                            Hide();
                            admin.Show();
                        }
                        else if (item.sil_id==2)
                        {
                            frmadminpanel admin = new frmadminpanel();
                            Hide();
                            admin.Show();

                        }
                        else if (item.sil_id==1)
                        {
                            frmAnaEkran frm = new frmAnaEkran();
                              frm.label2.Text=getUserName;
                              Hide();
                              frm.Show();
                        }
                        else if(item.sil_id==0)
                        {
                            MessageBox.Show("Hesabınız Kapatılmıştır");
                        }
                      
                      
                    }
                   
                }
               


            }
           
        }
        public string actor;
        private void actar(string kuladi)
        {
             actor = kuladi;
        }
        int mow, mowY, mowX;
        private void panel11_MouseMove(object sender, MouseEventArgs e)
        {
            if (mow == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mowX, MousePosition.Y - mowY);
            }
        }

        private void panel11_MouseUp(object sender, MouseEventArgs e)
        {
            mow = 0;
        }

        private void panel11_MouseDown(object sender, MouseEventArgs e)
        {
            mow = 1;
            mowX = e.X;
            mowY = e.Y;
        }


        //Random rnd = new Random();
        //void MailGönder()
        //{
        //    MailMessage eposta = new MailMessage();
        //    SmtpClient smtp = new SmtpClient();
        //    smtp.EnableSsl = true;
        //    smtp.Credentials = new System.Net.NetworkCredential("isor5743@gmail.com", "a158764");
        //    smtp.Host = "smtp.gmail.com";

        //    smtp.Port = 587;

        //    eposta.From = new MailAddress("isor5743@gmail.com");
        //    eposta.To.Add(txtkayiteposta.Text.ToString());
        //    eposta.Subject = "Güvenlik Kodu";
        //    eposta.Body = kod.ToString();
        //    smtp.Send(eposta);
        //    MessageBox.Show("Epostanıza bakınız");
        //}
        //int kod = 0;
    }
}
