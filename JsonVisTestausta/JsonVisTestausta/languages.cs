using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace JsonVisTestausta
{
    public class languages
    {
        public string finnish
        {
            get;
            set;
        }

        public string english
        {
            get;
            set;
        }

    }

    public class translations
    {
        public string translation
        {
            get;
            set;
        }

        public IList<languages>translateWords
        {
            get;
            set;
        }
    }

    public class ClassTranslations
    {
        public translations translations
        {
            get;
            set;
        }
    }


  
}

