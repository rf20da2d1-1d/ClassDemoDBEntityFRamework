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

        public Student GetOne(int id)
        {
            return db.Students.Find(id);
        }

        public void Create(Student student)
        {
            db.Students.Add(student);
            db.SaveChanges(); // husk

        }

        public void Delete(int id)
        {
            Student student = GetOne(id);
            db.Students.Remove(student);
            db.SaveChanges(); // husk
        }

        public void Update(int id, Student updatedStudent)
        {
            Student student = GetOne(id);
            student.ClassId = updatedStudent.ClassId;
            student.Name= updatedStudent.Name;
            student.EMail= updatedStudent.EMail;
            db.SaveChanges(); // husk
        }
    }
}
