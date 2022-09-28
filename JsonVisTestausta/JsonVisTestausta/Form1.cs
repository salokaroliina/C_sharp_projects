using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace JsonVisTestausta
{
    public partial class Form1 : Form
    {
        Universities universities = new Universities();
        languages languages = new languages();

        public Form1()
        {
            InitializeComponent();
        }

        private void TiedotBtn_Click(object sender, EventArgs e)
        {
           ClassUniversities university1 = new ClassUniversities();
           
            university1.universities = new Universities();

            university1.universities.university = "South Carolina State University";

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
                name = "Adam Wilhite"
            };
            Student student4 = new Student
            {
                name = "Enis Kurtay YILMAZ"
            };

            listStudent.Add(student1);
            listStudent.Add(student2);
            listStudent.Add(student3);
            listStudent.Add(student4);

            university1.universities.students = listStudent;

            string json = JsonConvert.SerializeObject(student1.name + " - " + student2.name);

            TiedotLB.Text = json;
        
        }

        private void TranslateBtn_Click(object sender, EventArgs e)
        {
            ClassTranslations kaannos1 = new ClassTranslations();

            kaannos1.translations = new translations();

            List<languages>ListTranslation = new List<languages>();
            languages sana1 = new languages
            {
                finnish = "Jääkaappi"
            };
            languages sana2 = new languages
            {
                english = "Fridge"
            };

            ListTranslation.Add(sana1);
            ListTranslation.Add(sana2);

            kaannos1.translations.translateWords = ListTranslation;

            string json = JsonConvert.SerializeObject(sana1.finnish + " - " + sana2.english);

            TranslationsLB.Text = json;
        }
    }
}
