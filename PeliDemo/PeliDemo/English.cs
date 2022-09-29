using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PeliDemo
{
    public class English
    {
        public void Eng(string word)
        {
            var library = new Dictionary<string, Delegate>();
            library["PicturePB"] = new Func<string, string>(Func1);

            var res = library[word].DynamicInvoke(word);
        }


        private string Func1(string arg)
        {
            MessageBox.Show("It's Friday night. Moomin, Moominpapa and Hemulen have gone to party at town"); 
            return null; 
        }

    }
}
