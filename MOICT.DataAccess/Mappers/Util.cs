using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace MOICT.DataAccess.Mappers
{
    class Util
    {
        public static object GetValue(DataRow dr, string ColumnName)
        {
            try
            {
                if (dr.IsNull(ColumnName))
                {
                    return null;
                }
                else
                {
                    switch (dr[ColumnName].GetType().Name.ToLower())
                    {
                        case "char":
                            return (Nullable<char>)dr[ColumnName];
                        case "string":
                            return dr[ColumnName].ToString().Trim();
                        case "guid":
                            return dr[ColumnName].ToString();
                        default:
                            return null;
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.logError(ex);
                return null;
            }
        }

        public static Nullable<T> GetValue<T>(DataRow dr, string ColumnName) where T : struct
        {
            try
            {
                if (dr.IsNull(ColumnName))
                {
                    return null;
                }
                else
                {
                    switch (dr[ColumnName].GetType().Name.ToLower())
                    {
                        case "short":
                            return (T)Convert.ChangeType(dr[ColumnName], typeof(T));
                        case "int16":
                            return (T)Convert.ChangeType(dr[ColumnName], typeof(T));
                        case "int":
                            return (T)Convert.ChangeType(dr[ColumnName], typeof(T));
                        case "int32":
                            return (T)Convert.ChangeType(dr[ColumnName], typeof(T));
                        case "long":
                            return (T)Convert.ChangeType(dr[ColumnName], typeof(T));
                        case "int64":
                            return (T)Convert.ChangeType(dr[ColumnName], typeof(T));
                        case "byte":
                            return (T)Convert.ChangeType(dr[ColumnName], typeof(T));
                        case "float":
                            return (T)Convert.ChangeType(dr[ColumnName], typeof(T));
                        case "double":
                            return (T)Convert.ChangeType(dr[ColumnName], typeof(T));
                        case "decimal":
                            return (T)Convert.ChangeType(dr[ColumnName], typeof(T));
                        case "bool":
                            return (T)Convert.ChangeType(dr[ColumnName], typeof(T));
                        case "boolean":
                            return (T)Convert.ChangeType(dr[ColumnName], typeof(T));
                        case "datetime":
                            return (T)Convert.ChangeType(dr[ColumnName], typeof(T));
                        default:
                            return null;
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.logError(ex);
                return null;
            }
        }
    }
}
