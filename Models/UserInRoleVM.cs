﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template.BL.Models
{
    public class UserInRoleVM
    {
        public string UserId { get; set; }

        public string UserName { get; set; }

        public string Email { get; set; }

        public bool IsSelected { get; set; }
    }
}
