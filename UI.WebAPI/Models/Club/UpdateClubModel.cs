﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UI.WebAPI
{
    public class UpdateClubModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
    }
}
