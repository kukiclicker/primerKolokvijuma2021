using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class StudentRepository
    {
        public string connectionString = "Data Source=(localdb)\\ProjectsV13;Initial Catalog=StudentDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public List<Student> GetAllStudents()
        {
            List<Student> res = new List<Student>();

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "SELECT * FROM Students";
                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    Student s = new Student();
                    s.Id = sqlDataReader.GetInt32(0);
                    s.StudentName = sqlDataReader.GetString(1);
                    s.IndexNumber = sqlDataReader.GetString(2);
                    s.PointsESPB = sqlDataReader.GetInt32(3);
                    s.StudyYear = sqlDataReader.GetInt32(4);
                    s.AverageMark = sqlDataReader.GetDecimal(5);
                    s.IsBudget = sqlDataReader.GetBoolean(6);

                    res.Add(s);
                }

            }

            return res;
        }
        public int InsertStudent(Student s)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = string.Format(format: "INSERT INTO Students VALUES('{0}','{1}',{2},{3},{4},{5})", s.StudentName, s.IndexNumber, s.PointsESPB,s.StudyYear,s.AverageMark,s.IsBudget);
                sqlConnection.Open();
                return sqlCommand.ExecuteNonQuery();
            }
        }
    }
}
