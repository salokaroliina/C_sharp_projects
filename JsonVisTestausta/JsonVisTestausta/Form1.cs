using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace JsonVisTestausta
{
    public class Student
    {
        public string name
        {
            get;
            set;
        }
    }

    public class Universities
    {
        public string university
        {
            get;
            set;
        }

        public IList<Student> students
        {
            get;
            set;
        }
    }
    public class ClassUniversities
    {
        public Universities universities
        {
            get;
            set;
        }
    }

    public partial class Form1 : Form
    {
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

            string json = JsonConvert.SerializeObject(university1);

            TiedotLB.Text = json;
        
        }
    }
}
