﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_Credentials.Domain.Models;

public class User
{
    public Object? UserId { get; set; }
    public string? Email { get; set; }
    public string? Password { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    
    public int? IsTwoAuthen { get; set; }

    public string? PhoneNumber { get; set; }
}
