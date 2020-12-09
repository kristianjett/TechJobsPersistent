using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TechJobsPersistent.Models;

namespace TechJobsPersistent.ViewModels
{
    public class AddJobViewModel
    {
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }
        public int EmployerId { get; set; }
        public List<SelectListItem> EmployerList { get; set; }

        public AddJobViewModel() { }

        public AddJobViewModel(List<Employer> possibleEmployers) : this()
        {
            EmployerList = new List<SelectListItem>();

            foreach (Employer employer in possibleEmployers)
            {
                EmployerList.Add(new SelectListItem
                {
                    Value = employer.Id.ToString(),
                    Text = employer.Name
                });
            }
        }
    }
}
