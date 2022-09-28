using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PeliDemoTestaus
{
    public class KatsottavaKaksi
    {
        public void Meme(string meem)
        {
            var kirjasto = new Dictionary<string, Delegate>();
            kirjasto["KekPB"] = new Func<string, string>(Func1);
            kirjasto["SiiliPB"] = new Func<string, string>(Func2);
            kirjasto["VaderPB"] = new Func<string, string>(Func3);
            kirjasto["LegolasPB"] = new Func<string, string>(Func4);

            var res = kirjasto[meem].DynamicInvoke(meem);
        }

        private string Func1(string arg)
        {
            MessageBox.Show("Gordon Keksay");
            
            return null;
        }

        private string Func2(string arg)
        {
            MessageBox.Show("Siili haukottelee");
            return null;
        }

        private string Func3(string arg)
        {
            MessageBox.Show("NOOOOOOOOOOO!!!!");
            return null;
        }

        private string Func4(string arg)
        {
            MessageBox.Show("Maybe he's born with it, maybe it's Maybelline");
            return null;
        }
    }
}
