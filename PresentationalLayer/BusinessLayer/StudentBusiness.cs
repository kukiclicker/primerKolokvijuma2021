using DataLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class StudentBusiness
    {
        private readonly StudentRepository studentRepository = new StudentRepository();

        public List<Student> GetAllItems()
        {
            return studentRepository.GetAllStudents().Where(s => s.PointsESPB > (s.StudyYear * 38) && (s.IsBudget == true)|| s.PointsESPB > s.StudyYear*48).ToList();
        }
        public int InsertStudent(Student s)
        {
            return studentRepository.InsertStudent(s);
        }

    }
}
