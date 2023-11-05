﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAOs
{
    public class SqlOperation
    {
        public string ProcedureName { get; set; }

        public List<SqlParameter> Parameters { get; set; }

        public SqlOperation()
        {
            Parameters = new List<SqlParameter>();
        }

        public void AddVarcharParam(string paraName, string paramValue)
        {
            Parameters.Add(new SqlParameter(paraName, paramValue));
        }
        public void AddIntParam(string paramName, int paramValue)
        {
            Parameters.Add(new SqlParameter(paramName, paramValue));
        }
        public void AddDateTimeParam(string paramName, DateTime paramValue)
        {
            Parameters.Add(new SqlParameter(paramName, paramValue));
        }
        public void AddFloatParam(string paramName, float paramValue)
        {
            Parameters.Add(new SqlParameter(paramName, paramValue));
        }

        
    }
}
