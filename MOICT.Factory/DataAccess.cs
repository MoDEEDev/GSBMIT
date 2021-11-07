﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Reflection;

namespace MOICT.Factory
{
    public class DataAccess
    {
        private static readonly string path = ConfigurationManager.AppSettings["MOICT.DAL"];

        public static T CreateInstance<T>(string classPath)
        {
            string className = string.Format("{0}.{1}", path, classPath);
            return (T)Assembly.Load(path).CreateInstance(className);
        }

    }
}
