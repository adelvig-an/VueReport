﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbLayer
{
    public class DbInitializer
    {
        public static void Initializer (ApplicationDbContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}
