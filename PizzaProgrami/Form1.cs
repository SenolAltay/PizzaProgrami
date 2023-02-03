using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace PizzaProgrami
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string CheckBoxMetinleriniAl()
        {
            string sonMetin = "";
            var liste = this.Controls;
            foreach (var item in liste.OfType<CheckBox>())
            {
                if (item.Checked)
                {
                    sonMetin += item.Text + ",";
                }
                else
                {
                    sonMetin = sonMetin.Replace(item.Text + ",", "");
                }
            }
            return sonMetin;
        }

        public void DataGridViewEkle(DataGridView dataGridView)
        {
            List<Pizza> pizzalar = new List<Pizza>();
            PizzaDBEntities veritabani = new PizzaDBEntities();
            pizzalar = veritabani.Pizzas.ToList();
            dataGridView1.DataSource = pizzalar;            
        }



        public List<Pizza> PizzalariEkle()
        {
            List<Pizza> pizza = new List<Pizza>();
            Pizza pizza1 = new Pizza();
            pizza1.adı = "Pizza1";
            pizza1.hamurTipi = "Orta";
            pizza1.domatesSosluMu = true;
            pizza1.Malzemeler = "Zeytin,Sucuk";
            pizza1.fiyati = 100;
            pizza1.boyutu = "Küçük";
            pizza.Add(pizza1);

            Pizza pizza2 = new Pizza();
            pizza2.adı = "Pizza2";
            pizza2.hamurTipi = "Orta";
            pizza2.domatesSosluMu = true;
            pizza2.Malzemeler = "Domates,Zeytin";
            pizza2.fiyati = 120;
            pizza2.boyutu = "Orta";
            pizza.Add(pizza2);

            return pizza;
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            
            Pizza pizza = new Pizza();
            pizza.adı = txtAd.Text;
            pizza.hamurTipi = cmbhamurTipi.SelectedItem.ToString();
            pizza.boyutu = cmbBoyut.SelectedItem.ToString();
            pizza.fiyati = Convert.ToDecimal(txtFiyat.Text);
            if (rdbEvet.Checked) //radiobutton seçiliyse
            {
                pizza.domatesSosluMu = true;
            }
            if (rdbHayır.Checked)
            {
                pizza.domatesSosluMu = false;
            }
            string secililer=CheckBoxMetinleriniAl();
            pizza.Malzemeler = secililer;

            //ödev
            //malzeme listesini checkboxlarda seçili olanlar 27.01.2023 cuma günü yapılam projeden alıp buraya uyarlanacak.

            PizzaDBEntities db = new PizzaDBEntities();
            db.Pizzas.Add(pizza);
            db.SaveChanges();

            DataGridViewEkle(dataGridView1);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PizzaDBEntities veritabani = new PizzaDBEntities();
            List<Pizza> veritabanindakiler = veritabani.Pizzas.ToList();
            if (veritabanindakiler.Count == 0)
            {
                List<Pizza> pizzalar = PizzalariEkle();
                foreach (var item in pizzalar)
                {
                    veritabani.Pizzas.Add(item);
                    veritabani.SaveChanges();//ram deki farklılıkları veri tabanında değişiklik yapar
                }
            }

            
        }

        private void Temizle()
        {
            txtAd.Clear();
            txtFiyat.Clear();
            chkDomates.Checked = false;
            chkSucuk.Checked = false;
            chkZeytin.Checked = false;
            chkMısır.Checked = false;
            chkMantar.Checked = false;
            rdbEvet.Checked = false;
            rdbHayır.Checked = false;
            cmbBoyut.Text = "Seçiniz";
            cmbhamurTipi.Text = "Seçiniz";
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void rdmSucukMalzeme_CheckedChanged(object sender, EventArgs e)
        {
            if (rdmSucukMalzeme.Checked)
            {
                PizzaDBEntities veritabani = new PizzaDBEntities();
                List<Pizza> sucuklular=veritabani.Pizzas.Where(kayit => kayit.Malzemeler.Contains("sucuk") || kayit.Malzemeler.Contains("sucuk")).ToList();

                //List<Pizza> sucuklular = veritabani.Pizzas.Where(kayit => kayit.Malzemeler.Contains("sucuk") || kayit.Malzemeler.Contains("Sucuk")).ToList();

                dataGridView1.DataSource = sucuklular;
            }
        }

        private void btnFiyatKaydet_Click(object sender, EventArgs e)
        {
            string fiyat = txtFiyataGore.Text;
            decimal fiyatson=0;
            PizzaDBEntities veritabani = new PizzaDBEntities();
            decimal fiyatd = Convert.ToDecimal(fiyat);
            if (!fiyat.Contains(","))
            {
                if (fiyat.Contains("."))
                {
                    fiyatson = Convert.ToDecimal(fiyat.Replace(".", ","));
                }
                else
                {
                    string son = fiyat.ToString() + ",0";
                    fiyatson = Convert.ToDecimal(son);
                }
            }
            else
            {
                fiyatson = Convert.ToDecimal(fiyat);
            }
            List<Pizza> pizzalar=veritabani.Pizzas.Where(satir => satir.fiyati == fiyatson).ToList();
            dataGridView1.DataSource = pizzalar;
        }
    }
}
