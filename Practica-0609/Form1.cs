using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_0609
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // el metodo Load() es el que se ejecuta al momento de iniciar
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGetName_Click(object sender, EventArgs e)
        {
            //llamado al metodo selectName
            selectName();
        }

        //metodo para obtener los nombres de la colección 
        private void selectName()
        {
            List<string> query = (
                from student in Student.GetStudents()
                select student.firtsName
                ).ToList();

            //recorrer lilsta y llenar lstNames
            foreach(var name in query)
            {
                //llenar lstNames
                lstNames.Items.Add(name);

            }

        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            // agregar columnas al DataGridView
            dgData.Columns.Add("idStudent", "ID");
            dgData.Columns.Add("idStudent", "FIRST NAME");
            dgData.Columns.Add("idStudent", "LAST NAME");
            dgData.Columns.Add("idStudent", "AGE");
            dgData.Columns.Add("idStudent", "NATIONALITY");
            foreach (var student in selectAllData())
            {
                dgData.Rows.Add(student.idStudent, student.firtsName, student.lastName,
                    student.age, student.nationality);
            }

        }
        private List<Student> selectAllData()
        {
            List<Student> query = (
                from student in Student.GetStudents()
                select new Student()
                {
                    idStudent = student.idStudent,
                    firtsName = student.firtsName,
                    lastName = student.lastName,
                    age = student.age,
                    nationality = student.nationality,
                }
                ).ToList();
            return query;
        }

    }
}
