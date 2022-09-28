using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace JsonVisTestausta
{
    // Määritellään tiedot, jotka halutaan asettaa

    // Luokka jolla määritellään oppilaiden nimet
    public class Student
    {
        public string name
        {
            get;
            set;
        }
    }

    // Luokka jolla määritellään yliopistot
    public class Universities
    {
        // koulun tyyppi, university
        public string university
        {
            get;
            set;
        }

        // listaus oppilaista
        public IList<Student> students
        {
            get;
            set;
        }
    }

    // luokka joka pitää sisällään tiedot yliopistoista sekä oppilaista
    public class ClassUniversities
    {
        public Universities universities
        {
            get;
            set;
        }
    }
}
