using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClassDemoDBEntityFRamework.model;

namespace ClassDemoDBEntityFRamework.services
{
    public interface IPersistenceStudent
    {
        List<Student> GetAll();

        Student GetOne(int id);

        void Create(Student student);

        void Delete(int id);

        void Update(int id, Student student);
    }
}
