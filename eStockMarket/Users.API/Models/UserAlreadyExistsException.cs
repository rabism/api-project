﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Users.API.Models
{
    public class UserAlreadyExistsException : ApplicationException
    {
        public UserAlreadyExistsException(string message) : base(message) { }
    }
}
