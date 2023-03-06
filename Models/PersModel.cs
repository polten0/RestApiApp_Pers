﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestApiApp_Pers.Models
{
    public class PersModel
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Image { get; set; }
        public PersLocationModel Location { get; set; }
        public string Species { get; set; }
    }
}
