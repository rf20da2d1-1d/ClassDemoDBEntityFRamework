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

        void Create(Student student);
    }
}
