﻿  using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ERPSchoolManagement.Models.Custom
{
    public class CustomExamType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
    }
}