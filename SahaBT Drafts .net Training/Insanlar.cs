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
  public  class Insanlar
    {
        public int id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public string Country { get; set; }

        public List<Insanlar> insanListe = new List<Insanlar>();

        public string jsonConvert()
        {
            using (StreamReader r = new StreamReader("../../Hayri.json"))//!!!!json uzantılı dosyanın konumu buraya yazılacak
            {
                string json = r.ReadToEnd();

                return json;

            }          
        }

        public List<Insanlar> personelListele(char listelenecek)
        {
            string json = jsonConvert();
            List<Insanlar> personel;
            if (listelenecek=='T')
            {
                personel = JsonConvert.DeserializeObject<List<Insanlar>>(json).GroupBy(x => new { x.FirstName, x.LastName, x.Email }).Select(x => x.First()).ToList();

            }
            else if (listelenecek == 'K')
            {
                personel = JsonConvert.DeserializeObject<List<Insanlar>>(json).Where(x => x.Gender == "Female").GroupBy(x => new { x.FirstName, x.LastName, x.Email }).Select(x => x.First()).ToList();

            }
            else
            {
                personel = JsonConvert.DeserializeObject<List<Insanlar>>(json).Where(x => x.Gender == "Male").GroupBy(x => new { x.FirstName, x.LastName, x.Email }).Select(x => x.First()).ToList();

            }

            foreach (var item in personel)
            {
                Insanlar insan = new Insanlar();
                insan.id = item.id;
                insan.FirstName = item.FirstName;
                insan.LastName = item.LastName;
                insan.Gender = item.Gender;
                insan.Email = item.Email;
                insan.Country = item.Country;
                insanListe.Add(insan);

            }
            return personel;
        }

        public List<Insanlar> ulkeyeGoreListele(char listelenecek, string ulke)
        {
            string json = jsonConvert();
            List<Insanlar> personel;
            if (listelenecek == 'T')
            {
                personel = JsonConvert.DeserializeObject<List<Insanlar>>(json).GroupBy(x => new { x.FirstName, x.LastName, x.Email }).Select(x => x.First()).Where(x => x.Country == ulke).ToList();

            }
            else if (listelenecek == 'K')
            {
                personel = JsonConvert.DeserializeObject<List<Insanlar>>(json).Where(x => x.Gender == "Female" && x.Country == ulke).GroupBy(x => new { x.FirstName, x.LastName, x.Email }).Select(x => x.First()).ToList();

            }
            else
            {
                personel = JsonConvert.DeserializeObject<List<Insanlar>>(json).Where(x => x.Gender == "Male" && x.Country == ulke).GroupBy(x => new { x.FirstName, x.LastName, x.Email }).Select(x => x.First()).ToList();
            }

            foreach (var item in personel)
            {
                Insanlar insan = new Insanlar();
                insan.id = item.id;
                insan.FirstName = item.FirstName;
                insan.LastName = item.LastName;
                insan.Gender = item.Gender;
                insan.Email = item.Email;
                insan.Country = item.Country;
                insanListe.Add(insan);

            }
            return personel;
        }
    }
}

