using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Project.Models
{
    public class ProjectInfo
    {
        public ProjectInfo()
        {
        }
        public int ProjectID { get; set; }
        [Required]
        public string ProjectName { get; set; }
        public string ProjectCode { get; set; }

    }
}
