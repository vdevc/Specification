﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Ardalis.Specification.EF.IntegrationTests.Data
{
    public class Country
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public List<Company> Companies { get; set; } = new List<Company>();
    }
}
