using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClassDemoDBEntityFRamework.model;
using ClassDemoDBEntityFRamework.services;

namespace ClassDemoDBEntityFRamework.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private IPersistenceStudent _persistence;
        private List<Student> _students;

        public List<Student> Students => _students;

        [BindProperty]
        public Student Student { get; set; }


        public IndexModel(ILogger<IndexModel> logger, IPersistenceStudent persistence)
        {
            _logger = logger;
            _persistence = persistence;
        }

        public void OnGet()
        {
            _students = _persistence.GetAll();
        }

        public IActionResult OnPost()
        {
            _persistence.Create(Student);
            return RedirectToPage("Index");
        }

    }

    
}
