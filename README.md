# WebService
C# WEB服务编写的WebService服务器端文件
http://dota2ms.com/Service.asmx  类似效果

#Known problems
*   DataBase数据库操作类
*   DatableToList DataTable转List集合
*   DataTableConvertJson2 DataTable转化Json,不使用系统序列化换json，手动转换json
*   目前更新比较慢，目标是content至少达到 3 4层嵌套，希望能保持关注 
*   希望顺便点一下右上角的⭐️Star ，朋友的鼓励和支持是我继续分享的动力 
*   

#Features 
    
#第一种格式  content一层
    {
    "content": [
        {
            "StudentID": "201310414101",
            "ClassID": 33,
            "StudentPwd": "92-DF-1C-BA-F2-4F-52-8F-A1-17-DF-8D-AD-9D-2D-DC",
            "StudentName": "林名君",
            "StudentImage": "",
            "StudentDes": "",
            "X": null,
            "Y": null,
            "Z": null
        }
    ],
    "message": null,
    "stateCode": 1
}
#Model
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    
    namespace Model
    {
       public  class Student
        {
     
            private string studentID;
            private int classID;
            private string studentPwd;
            private string studentName;
            private string studentImage;
            private string studentDes;
            private string x;
            private string y;
            private string z;
            public string StudentID
            {
                get
                {
                    return this.studentID;
                }
                set
                {
                    this.studentID = value;
                }
            }
            public int ClassID
            {
                get
                {
                    return this.classID;
                }
                set
                {
                    this.classID = value;
                }
            }
            public string StudentPwd
            {
                get
                {
                    return this.studentPwd;
                }
                set
                {
                    this.studentPwd = value;
                }
            }
            public string StudentName
            {
                get
                {
                    return this.studentName;
                }
                set
                {
                    this.studentName = value;
                }
            }
            public string StudentImage
            {
                get
                {
                    return this.studentImage;
                }
                set
                {
                    this.studentImage = value;
                }
            }
            public string StudentDes
            {
                get
                {
                    return this.studentDes;
                }
                set
                {
                    this.studentDes = value;
                }
            }
            public string X
            {
                get
                {
                    return this.x;
                }
                set
                {
                    this.x = value;
                }
            }
            public string Y
            {
                get
                {
                    return this.y;
                }
                set
                {
                    this.y = value;
                }
            }
            public string Z
            {
                get
                {
                    return this.z;
                }
                set
                {
                    this.z = value;
                }
            }
        }
    }
#IModel
    using Model;
    namespace IModel
    {
        public class IStudent
        {
            public List<Student> content;
    
            public String message;
    
            public Int32 stateCode;
        }
    }

#StudentDal
    //使用泛型 条件查询学生
        public IStudent StudentLogin3(String StudentID, String Password)
        {
            String comstr = " select students.* from Students where studentid='" + StudentID + "'";
            Password = this.MD5(Password);
            IStudent sslist = new IStudent();

            List<Student> slist = new List<Student>();

            DataTable dt = new DataTable();
            DataBase db = new DataBase();
            dt = db.GetDataTable(comstr);
            slist = DatableToList.ConvertToList<Student>(dt);

            if (Validate_Login(StudentID, Password))
            {
                //STATE_FAIL 0  ,STATE_SUCCESS 1,  STATE_OFFLINE 2
                sslist.stateCode = 1;
                sslist.content = slist;
            }
            else
            {

                sslist.stateCode = 0;
                sslist.message = "账号或密码有误";
            }

            return sslist;
        }


    
#Service.cs
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
        Context.Response.ContentType = "text/json";
        Context.Response.Write(new JavaScriptSerializer().Serialize(studentDal.StudentLogin3(StudentID, Password)));



      
        //   return dal.Select();

    }

#第二种格式，content两层
    {
    "content": [
        {
            "StudentID": "1",
            "ClassID": "42",
            "StudentPwd": "AF-C9-11-D4-F9-8B-2F-F1-1E-42-F1-9E-93-FC-D1-E4",
            "StudentName": "asdasdas",
            "StudentImage": "",
            "StudentDes": "",
            "X": "",
            "Y": "",
            "Z": "",
            "Student": {
                "StudentID": "1",
                "ClassID": "42",
                "StudentPwd": "AF-C9-11-D4-F9-8B-2F-F1-1E-42-F1-9E-93-FC-D1-E4",
                "StudentName": "asdasdas",
                "StudentImage": "",
                "StudentDes": "",
                "X": "",
                "Y": "",
                "Z": ""
            }
        },
        {
            "StudentID": "1111111",
            "ClassID": "42",
            "StudentPwd": "7E-03-79-C9-17-36-74-04-56-0A-17-68-6E-56-2E-E8",
            "StudentName": "lou",
            "StudentImage": "",
            "StudentDes": "",
            "X": "",
            "Y": "",
            "Z": "",
            "Student": {
                "StudentID": "1111111",
                "ClassID": "42",
                "StudentPwd": "7E-03-79-C9-17-36-74-04-56-0A-17-68-6E-56-2E-E8",
                "StudentName": "lou",
                "StudentImage": "",
                "StudentDes": "",
                "X": "",
                "Y": "",
                "Z": ""
            }
        },
        {
            "StudentID": "12321321",
            "ClassID": "42",
            "StudentPwd": "321321",
            "StudentName": "321321321",
            "StudentImage": "",
            "StudentDes": "",
            "X": "",
            "Y": "",
            "Z": "",
            "Student": {
                "StudentID": "12321321",
                "ClassID": "42",
                "StudentPwd": "321321",
                "StudentName": "321321321",
                "StudentImage": "",
                "StudentDes": "",
                "X": "",
                "Y": "",
                "Z": ""
            }
        }
    ],
    "message": null,
    "stateCode": 1
}
    
#IModel
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Model;
    namespace IModel
    {
        public class IStudent2
        {
    
            public Student content;
    
            public String message;
    
            public Int32 stateCode;
        }
    }
#Dal
     //使用泛型 条件查询学生
        public Student2 StudentLogin5()
        {
            String comstr = " select top 10 students.* from Students";

           

            Student2 students = new Student2();

            DataTable dt = new DataTable();
            DataTable dt2 = new DataTable();
            DataBase db = new DataBase();
            dt = db.GetDataTable(comstr);
            dt2 = db.GetDataTable(comstr);

            dt2.TableName = "Student";
            String result = DataTableConvertJson2.DataTable2Json(dt, dt2);




            if (true)
            {
                //STATE_FAIL 0  ,STATE_SUCCESS 1,  STATE_OFFLINE 2
                students.stateCode = 1;
                students.content = result;
            }
            else
            {

                students.stateCode = 0;
                students.message = "账号或密码有误";
            }

            return students;
        }

#Service.cs
    [WebMethod(Description = "")]
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
        Context.Response.ContentType = "text/json";
        Context.Response.Charset = "utf-8";
        JavaScriptSerializer jsSerializer = new JavaScriptSerializer();
        jsSerializer.MaxJsonLength = Int32.MaxValue;
        String result = jsSerializer.Serialize(studentDal.StudentLogin5());
        result = DataTableToJson.String2Json(result);
        result = result.Replace("\"[{", "[{");
        result = result.Replace("}]\"", "}]");

        Context.Response.Write(result);
        //   return dal.Select();

    }
