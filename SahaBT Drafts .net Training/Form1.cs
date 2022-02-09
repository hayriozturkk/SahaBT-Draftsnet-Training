using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Json
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            Insanlar insanlar = new Insanlar();
            dataGridViewTumu.DataSource = insanlar.personelListele('T');
            dataGridViewErkek.DataSource = insanlar.personelListele('E');
            dataGridViewKadin.DataSource = insanlar.personelListele('K');
        }

        public void button1_Click(object sender, EventArgs e)
        {
            Insanlar insanlar = new Insanlar();
            string ulke = textBox2.Text;
            dataGridViewTumu.DataSource = insanlar.ulkeyeGoreListele('T', ulke);
            dataGridViewErkek.DataSource = insanlar.ulkeyeGoreListele('E', ulke);
            dataGridViewKadin.DataSource = insanlar.ulkeyeGoreListele('K', ulke);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
            Insanlar insanlar = new Insanlar();
            dataGridViewTumu.DataSource = insanlar.personelListele('T');
            dataGridViewErkek.DataSource = insanlar.personelListele('E');
            dataGridViewKadin.DataSource = insanlar.personelListele('K');
        }
    }
}
