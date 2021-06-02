﻿using NorthwindBackend.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NorthwindBackend.Entities.Dtos
{
    public class UserForRegisterDto: IDto
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string FistName { get; set; }
        public string LastName { get; set; }
    }
}
