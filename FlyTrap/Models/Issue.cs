using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FlyTrap.Models
{
    public class Issue
    {
#nullable enable
        [Key]
        public int Id { get; set; }

        public int ProjectId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string? StackTrace { get; set; }

        public string? Location { get; set; }

        public int? Priority { get; set; }
#nullable disable

        public string AuthorId { get; set; }

        public Project Project { get; set; }
    }
}
