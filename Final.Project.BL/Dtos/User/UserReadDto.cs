﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final.Project.BL;

public class UserReadDto
{
    public string? Id { get; set; }
    public string Fname { get; set; } = string.Empty;
    public string Lname { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public int phone { get; set; }
    public string City { get; set; } = string.Empty;
    public string Street { get; set; } = string.Empty;
}