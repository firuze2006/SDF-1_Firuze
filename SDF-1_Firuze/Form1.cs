using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDF_1_Firuze
{
    public partial class Form1 : Form
    {
        EmployeeServiceBase service = new EmployeeService();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnIsciElaveAt_Click(object sender, EventArgs e)
        {

            string kod = txtKod.Text.Trim();
            string ad = txtAd.Text.Trim();
            string soyad = txtSoyad.Text.Trim();
            int yas;

            if (kod == "" || ad == "" || soyad == "" ||
                !int.TryParse(txtYas.Text, out yas) || yas <= 0)
            {
                MessageBox.Show("Melumatlari duzgun daxil edin!");
                return;
            }

            Employee yeniIsci = new Employee(kod, ad, soyad, yas);

            if (service.AddEmployee(yeniIsci))
            {
                MessageBox.Show("Isci ugurla elave edildi!");

                txtKod.Clear();
                txtAd.Clear();
                txtSoyad.Clear();
                txtYas.Clear();
            }
            else
            {
                MessageBox.Show("Bu kodla isci artiq movcuddur!");
            }

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnOdenisYaz_Click(object sender, EventArgs e)
        {

            string kod = txtOdenisKodu.Text.Trim();
            string ad = txtOdenisAdi.Text.Trim();
            double mebleg;

            if (kod == "" || ad == "" ||
                !double.TryParse(txtMebleg.Text, out mebleg) ||
                mebleg <= 0)
            {
                MessageBox.Show("Melumatlari duzgun daxil edin!");
                return;
            }

            if (service.AddPayment(kod, ad, mebleg))
            {
                MessageBox.Show("Odenis ugurla elave edildi!");

                txtOdenisKodu.Clear();
                txtOdenisAdi.Clear();
                txtMebleg.Clear();
            }
            else
            {
                MessageBox.Show("Isci tapilmadi ve ya melumatlar yanlisdir!");
            }


        }

        private void btnAxtar_Click(object sender, EventArgs e)
        {

            string kod = txtAxtarKod.Text.Trim();

            Employee isci = service.FindEmployee(kod);

            if (isci == null)
            {
                MessageBox.Show("Bu kodla isci tapilmadi!");
                return;
            }

            lstStatistika.Items.Clear();

            lstStatistika.Items.Add("Isci kodu: " + isci.Code);
            lstStatistika.Items.Add("Ad: " + isci.FirstName);
            lstStatistika.Items.Add("Soyad: " + isci.LastName);
            lstStatistika.Items.Add("Yas: " + isci.Age);
            lstStatistika.Items.Add("Odenisler:");

            double cem = 0;

            foreach (Payment odenis in isci.Payments)
            {
                lstStatistika.Items.Add(
                    odenis.Title + " - " + odenis.Amount + " AZN");

                cem += odenis.Amount;
            }

            lstStatistika.Items.Add("--------------------");
            lstStatistika.Items.Add("Umumi mebleg: " + cem + " AZN");

        }

        private void btnCixis_Click(object sender, EventArgs e)
        {

            DialogResult cavab = MessageBox.Show(
                "Proqramdan cixmaq isteyirsiniz?",
                "Cixis",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (cavab == DialogResult.Yes)
            {
                Application.Exit();
            }

        }
    }
}
