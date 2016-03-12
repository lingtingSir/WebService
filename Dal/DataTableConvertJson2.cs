using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;

/// <summary>
/// GetClassTypeJosn 的摘要说明
/// </summary>
public class DataTableConvertJson2
{

   
    /// <summary>  
    /// dataTable转换成Json格式  
    /// </summary>  
    /// <param name="dt"></param>  
    /// <returns></returns>  
    public static string DataTable2Json(DataTable dt, DataTable dt2)
    {
        StringBuilder jsonBuilder = new StringBuilder();
        jsonBuilder.Append("[");
        for (int i = 0; i < dt.Rows.Count; i++)
        {
           
            jsonBuilder.Append("{");
            for (int j = 0; j < dt.Columns.Count; j++)
            {
                jsonBuilder.Append("\"");
                jsonBuilder.Append(dt.Columns[j].ColumnName);
                jsonBuilder.Append("\":\"");
                jsonBuilder.Append(dt.Rows[i][j].ToString());
                jsonBuilder.Append("\",");


            }
            jsonBuilder.Append("\"");
            jsonBuilder.Append(dt2.TableName);
            jsonBuilder.Append("\":");
            jsonBuilder.Append("{");
            for (int l = 0; l < dt2.Columns.Count; l++)
            {
                jsonBuilder.Append("\"");
                jsonBuilder.Append(dt2.Columns[l].ColumnName);
                jsonBuilder.Append("\":\"");
                jsonBuilder.Append(dt2.Rows[i][l].ToString());
                jsonBuilder.Append("\",");
            }
            jsonBuilder.Remove(jsonBuilder.Length - 1, 1);
            jsonBuilder.Append("}");
            jsonBuilder.Append("},");
         
        }
        jsonBuilder.Remove(jsonBuilder.Length - 1, 1);
        jsonBuilder.Append("]");
        return jsonBuilder.ToString();
    }



    /// <summary>
    /// Msdn
    /// </summary>
    /// <param name="jsonName"></param>
    /// <param name="dt"></param>
    /// <returns></returns>
    public static string DataTableToJson(string jsonName, DataTable dt)
    {
        StringBuilder Json = new StringBuilder();
        Json.Append("{\"" + jsonName + "\":[");
        if (dt.Rows.Count > 0)
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Json.Append("{");
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    Json.Append("\"" + dt.Columns[j].ColumnName.ToString() + "\":\"" + dt.Rows[i][j].ToString() + "\"");
                    if (j < dt.Columns.Count - 1)
                    {
                        Json.Append(",");
                    }
                }
                Json.Append("}");
                if (i < dt.Rows.Count - 1)
                {
                    Json.Append(",");
                }
            }
        }
        Json.Append("]}");
        return Json.ToString();
    }

}