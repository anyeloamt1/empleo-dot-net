﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpleoDotNet.Core.Domain
{
    public class UserProfile : EntityBase
    {
        //public string UserId { get; set; }
        //public string Name { get; set; }
        //public string Email { get; set; }
        //public bool IsProfileCompleted { get; set; }

        //public UserProfileType UserProfileType { get; set; }
        //public List<Company> Companies { get; set; }

        public string UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public List<Company> Companies { get; set; }
    }
}
