using BusinesLayer;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class Form1 : Form
    {
        public readonly StudentBusiness studentBusiness;
        public Form1()
        {
            this.studentBusiness = new StudentBusiness();
            InitializeComponent();
        }

        private void RefreshData()
        {
            List<Student> students = studentBusiness.GetStudents();
            listBox.Items.Clear();

            foreach(Student s in students)
            {
                listBox.Items.Add(s.Id + " - " + s.Name + " - " + s.IndexNumber + " - " + s.AverageMark);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void button_Click(object sender, EventArgs e)
        {
            Student s = new Student();
            s.Name = textBoxName.Text;
            s.IndexNumber = textBoxIndex.Text;
            s.AverageMark = Convert.ToDecimal(textBoxAverage.Text);

            if (this.studentBusiness.Insert(s))
            {
                RefreshData();
                textBoxName.Clear();
                textBoxIndex.Clear();
                textBoxAverage.Clear();
            }
            else
                MessageBox.Show("Eror");
        }
    }
}
