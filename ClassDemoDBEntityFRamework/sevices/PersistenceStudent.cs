using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClassDemoDBEntityFRamework.model;
using ClassDemoDBEntityFRamework.services;

namespace ClassDemoDBEntityFRamework.sevices
{
    public class PersistenceStudent:IPersistenceStudent
    {
        private DBContext db = new DBContext();
        public List<Student> GetAll()
        {
            return db.Students.ToList();

        }

        public void Create(Student student)
        {
            db.Students.Add(student);
            db.SaveChanges(); // husk

        }
    }
}
