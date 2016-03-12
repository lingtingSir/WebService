using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Dal;
using System.Web.Script.Services;
using System.Web.Script.Serialization;

[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。
// [System.Web.Script.Services.ScriptService]

public class Service : System.Web.Services.WebService
{
    private StudentDal studentDal = new Dal.StudentDal();
    public Service () {

        //如果使用设计的组件，请取消注释以下行
        //InitializeComponent(); 
    }

    [WebMethod]
    public string HelloWorld() {
        return "Hello World";
    }
    [WebMethod(Description = "学生登录查询")]
    [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
    public void StudentLogin(String StudentID, String Password)
    {
        /*
         进行序列化或反序列化时出错。字符串的长度超过了为 maxJsonLength 属性设置的值
         解决办法：
         * JavaScriptSerializer jsSerializer = new JavaScriptSerializer();
            jsSerializer.MaxJsonLength = Int32.MaxValue;
         */
        Context.Response.Clear();
        Context.Response.ContentType = "text/html";
        JavaScriptSerializer jsSerializer = new JavaScriptSerializer();
        jsSerializer.MaxJsonLength = Int32.MaxValue;
        Context.Response.Write(jsSerializer.Serialize(studentDal.StudentLogin(StudentID, Password)));
        //   return dal.Select();

    }
    [WebMethod(Description = "测试新Json")]
    [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
    public void StudentLogin2(String StudentID, String Password)
    {
        /*
         进行序列化或反序列化时出错。字符串的长度超过了为 maxJsonLength 属性设置的值
         解决办法：
         * JavaScriptSerializer jsSerializer = new JavaScriptSerializer();
            jsSerializer.MaxJsonLength = Int32.MaxValue;
         */
        Context.Response.Clear();
        Context.Response.ContentType = "text/html";
        Context.Response.Charset = "utf-8";
        JavaScriptSerializer jsSerializer = new JavaScriptSerializer();
        jsSerializer.MaxJsonLength = Int32.MaxValue;
        String result = jsSerializer.Serialize(studentDal.StudentLogin2(StudentID, Password));
        result = DataTableToJson.String2Json(result);
        Context.Response.Write(result);
        //   return dal.Select();

    }
    [WebMethod(Description = "测试新Json2")]
    [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
    public void StudentLogin3(String StudentID, String Password)
    {
        /*
         进行序列化或反序列化时出错。字符串的长度超过了为 maxJsonLength 属性设置的值
         解决办法：
         * JavaScriptSerializer jsSerializer = new JavaScriptSerializer();
            jsSerializer.MaxJsonLength = Int32.MaxValue;
         */
        Context.Response.Clear();
        Context.Response.ContentType = "text/html";
        Context.Response.Charset = "utf-8";
        JavaScriptSerializer jsSerializer = new JavaScriptSerializer();
        jsSerializer.MaxJsonLength = Int32.MaxValue;
        String result = jsSerializer.Serialize(studentDal.StudentLogin3(StudentID, Password));
        result = DataTableToJson.String2Json(result);
        Context.Response.Write(result);
        //   return dal.Select();

    }
    [WebMethod(Description = "测试新Json3")]
    [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
    public void StudentLogin4(String StudentID, String Password)
    {
        /*
         进行序列化或反序列化时出错。字符串的长度超过了为 maxJsonLength 属性设置的值
         解决办法：
         * JavaScriptSerializer jsSerializer = new JavaScriptSerializer();
            jsSerializer.MaxJsonLength = Int32.MaxValue;
         */
        Context.Response.Clear();
        Context.Response.ContentType = "text/html";
        Context.Response.Charset = "utf-8";
        JavaScriptSerializer jsSerializer = new JavaScriptSerializer();
        jsSerializer.MaxJsonLength = Int32.MaxValue;
        String result = jsSerializer.Serialize(studentDal.StudentLogin4(StudentID, Password));
        result = DataTableToJson.String2Json(result);
        Context.Response.Write(result);
        //   return dal.Select();

    }

    [WebMethod(Description = "测试新Json3")]
    [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
    public void StudentLogin5()
    {
        /*
         进行序列化或反序列化时出错。字符串的长度超过了为 maxJsonLength 属性设置的值
         解决办法：
         * JavaScriptSerializer jsSerializer = new JavaScriptSerializer();
            jsSerializer.MaxJsonLength = Int32.MaxValue;
         */
        Context.Response.Clear();
        Context.Response.ContentType = "text/html";
        Context.Response.Charset = "utf-8";
        JavaScriptSerializer jsSerializer = new JavaScriptSerializer();
        jsSerializer.MaxJsonLength = Int32.MaxValue;
        String result = jsSerializer.Serialize(studentDal.StudentLogin5());
        result = DataTableToJson.String2Json(result);
        Context.Response.Write(result);
        //   return dal.Select();

    }

}