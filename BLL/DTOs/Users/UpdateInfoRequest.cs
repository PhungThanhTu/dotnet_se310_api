﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs.Users
{
    public class UpdateInfoRequest
    {
        public string? Username { get; set; }
        public string? Email { get; set; }
        public string? Fullname { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string? Avatar { get; set; }
    }
}
