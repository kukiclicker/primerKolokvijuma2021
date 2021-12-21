using BusinessLayer;
using DataLayer.Models;
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
        private readonly StudentBusiness studentBusiness = new StudentBusiness();

        public Form1()
        {
            InitializeComponent();
            RefreshList();
        }
        public void RefreshList()
        {
            listBox1.Items.Clear();
            List<Student> studenti = new List<Student>();
            studenti = studentBusiness.GetAllItems();

            foreach(var s in studenti)
            {
                listBox1.Items.Add(string.Format(s.Id+"."+s.StudentName+"-"+s.IndexNumber+"-"+s.PointsESPB+"-"+s.StudyYear));
            }
        }


       
    }
}
