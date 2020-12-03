using BusinesLayer;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PresentationLayerWeb
{
    public partial class _Default : Page
    {
        private StudentBusiness studentBusiness;
        protected void Page_Load(object sender, EventArgs e)
        {
            this.studentBusiness = new StudentBusiness();

            List<Student> all = this.studentBusiness.GetStudents();
            ListBoxStudents.Items.Clear();

            foreach(Student s in all)
            {
                ListBoxStudents.Items.Add(s.Id + " - " + s.Name + " - " + s.IndexNumber + " - " + s.AverageMark);
            }

        }
    }
}