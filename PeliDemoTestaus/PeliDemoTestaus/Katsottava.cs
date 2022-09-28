using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 

namespace PeliDemoTestaus
{
    public class Katsottava
    {
        public void Meme(string meem) // luodaan dictionary sanastolle
        {
            var kirjasto = new Dictionary<string, Delegate>(); 
            kirjasto["KekPB"] = new Func<string, string>(Func1); // jokaiselle kuvalle luodaan oma metodi kuvan nimen perusteella
            kirjasto["SiiliPB"] = new Func<string, string>(Func2);
            kirjasto["VaderPB"] = new Func<string, string>(Func3);
            kirjasto["LegolasPB"] = new Func<string, string>(Func4);

            var res = kirjasto[meem].DynamicInvoke(meem); // kutsuu tiettyä metodia kuvan nimen perusteella,
                                                          // kun mitä tahansa kuvaa klikkaa
        }

        private string Func1(string arg) // jokainen kuva saa vastaavan metodin
        {
            MessageBox.Show("Kek"); // tällä hetkellä käytössä on messagebox, testataan muita tapoja
            return null;
        }

        private string Func2(string arg)
        {
            MessageBox.Show("Siili");
            return null;
        }

        private string Func3(string arg)
        {
            MessageBox.Show("I am your father");
            return null;
        }

        private string Func4(string arg)
        {
            MessageBox.Show("They're taking the Hobbits to Isengard");
            return null;
        }
    }
}
