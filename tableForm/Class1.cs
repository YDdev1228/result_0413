﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tableForm
{
    internal class Class1
    {
        public string dbConnect() 
        {
            string con = @"server=192.168.0.53;userid=root;password=1111;database=test_db";
            return con;
        }
    }
}
