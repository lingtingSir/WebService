using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;

/// <summary>
/// GetClassTypeJosn 的摘要说明
/// </summary>
public class DataTableConvertJson
{

    #region dataTable转换成Json格式
    /// <summary>  
    /// dataTable转换成Json格式  
    /// </summary>  
    /// <param name="dt"></param>  
    /// <returns></returns>  
    public static string DataTable2Json2(DataTable dt)
    {
        StringBuilder jsonBuilder = new StringBuilder();
        jsonBuilder.Append("[");
        jsonBuilder.Append(dt.TableName);
        jsonBuilder.Append("{");
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            jsonBuilder.Append("[");
            jsonBuilder.Append(dt.TableName);
            jsonBuilder.Append("{");
            for (int j = 0; j < dt.Columns.Count; j++)
            {
                jsonBuilder.Append("\"");
                jsonBuilder.Append(dt.Columns[j].ColumnName);
                jsonBuilder.Append("\":\"");
                jsonBuilder.Append(dt.Rows[i][j].ToString());
                 jsonBuilder.Append("\",");
            }
            jsonBuilder.Remove(jsonBuilder.Length - 1, 1);
            jsonBuilder.Append("},");
        }
        jsonBuilder.Remove(jsonBuilder.Length - 1, 1);
        jsonBuilder.Append("]");
        return jsonBuilder.ToString();
    }

    #endregion dataTable转换成Json格式
    #region DataSet转换成Json格式
    /// <summary>  
    /// DataSet转换成Json格式  
    /// </summary>  
    /// <param name="ds">DataSet</param> 
    /// <returns></returns>  
    public static string Dataset2Json(DataSet ds)
    {
        StringBuilder json = new StringBuilder();

        foreach (DataTable dt in ds.Tables)
        {
            json.Append("{\"");
            json.Append(dt.TableName);
            json.Append("\":");
            json.Append(DataTable2Json2(dt));
            json.Append("}");
        } return json.ToString();
    }

    #endregion

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
