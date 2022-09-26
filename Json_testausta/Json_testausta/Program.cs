using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Json_testausta
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

    // Itse ohjelma alkaa tästä
    class Program
    {
        static void Main(string[] args)
        {
            // ClassUniversities pitää sisällään tiedot yliopistoista
            ClassUniversities university1 = new ClassUniversities();

            // university1:lle annetaan tiedot yliopiston nimestä ja sen oppilaista
            university1.universities = new Universities();
            // annetaan yliopistolle nimi
            university1.universities.university = "South Carolina State University";

            // täytetään oppilaslista
            List<Student> listStudent = new List<Student>();
            Student student1 = new Student
            {
                name = "Stephen Cousins"
            };
            Student student2 = new Student
            {
                name = "Austin A. Newton"
            };
            Student student3 = new Student
            {
                name = "Adam Whilhite"
            };
            Student student4 = new Student
            {
                name = "Enis Kurtay YILMAZ"
            };

            listStudent.Add(student1);
            listStudent.Add(student2);
            listStudent.Add(student3);
            listStudent.Add(student4);  


            // annetaan oppilaslistan tiedot yliopistolle
            university1.universities.students = listStudent;
            // muunnetaan tiedot luettavaan muotoon
            string json = JsonConvert.SerializeObject(university1);

            Console.WriteLine(json);
            Console.ReadLine();

        }
    }
}
