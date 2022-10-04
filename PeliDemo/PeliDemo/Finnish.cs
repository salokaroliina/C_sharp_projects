using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PeliDemo
{
    public class Finnish
    {
       
        // metodi, joka pitää sisällään sanasto-kirjaston
        public void Fin(string word)
        {
            // luodaan uusi dictionary
            var library = new Dictionary<string, Delegate>();
            
            // uusi metodi määräytyy kuvan nimen perusteella
            library["PicturePB"] = new Func<string, string>(Func1);

            // kuvaa klikatessa kirjasto vastaa
            var res = library[word].DynamicInvoke(word);
        }

        // jokainen kuva saa oman metodin, johon on kirjattu teksti joka halutaan tuoda esiin klikatessa
        private string Func1(string arg)
        { 
            MessageBox.Show("On perjantai ilta. Muumipeikko, Muumipappa ja Hemuli ovat lähteneet viihteelle");

            return null; 
        }

        // Testasin luoda toisen dictionaryn, jota voi vaihtoehtoisesti käyttää
        // Tarkoitus on demota laajemman sanaston käyttöä ja sen jaottelua tarpeen mukaan,
        // jotta kaikki teksti ei olisi yhdessä isossa voidissa
        public void FinKaksi(string word)
        {
            var library = new Dictionary<string , Delegate>();

            library["PicturePB"] = new Func<string, string>(Func2);

            var res = library[word].DynamicInvoke(word);
        }

        private string Func2(string arg)
        {
            MessageBox.Show("Perjantai-ilta Muumilaaksossa");

            return null;
        }


     


    }

}
