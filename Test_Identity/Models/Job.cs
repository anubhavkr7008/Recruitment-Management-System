﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Test_Identity.Models
{
    public class Job
    {
        public int Id { get; set; }
        public string JobName { get; set; }
        public int Experience { get; set; }
        public string JobDescription { get; set; }
        public string SelectedSkillID { get; set; }

        [NotMapped]
        public IEnumerable<SkillModels> SkillCollection { get; set; }

        [NotMapped]
        public string[] SelectedIDArray { get; set; }
    }
}