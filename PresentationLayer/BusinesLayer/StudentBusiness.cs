using DataAccessLayer;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinesLayer
{
    public class StudentBusiness
    {
        public readonly StudentRepository studentRepository;

        public StudentBusiness()
        {
            this.studentRepository = new StudentRepository();
        }

        public List<Student> GetStudents()
        {
            return this.studentRepository.GetAllStudents();
        }

        public bool Insert(Student s)
        {
            if (this.studentRepository.Insert(s) > 0)
            {
                return true;
            }
            return false;
        }
    }
}
