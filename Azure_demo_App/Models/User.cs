﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Azure_demo_App.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
    }
}