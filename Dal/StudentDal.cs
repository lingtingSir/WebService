using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IModel;
using Model;
using System.Data;
using System.Security.Cryptography;
using System.Data.SqlClient;
namespace Dal
{
    public class StudentDal
    {

        //使用泛型 条件查询学生
        public Object StudentLogin(String StudentID, String Password)
        {
            String comstr = " select students.* from Students where studentid='" + StudentID + "'";
            String comstr2 = " select users.* from users where userid='201010414101'";
            Password = this.MD5(Password);
            IStudent sslist = new IStudent();

            List<Student> slist = new List<Student>();

            DataTable dt = new DataTable();
            DataBase db = new DataBase();
            dt = db.GetDataTable(comstr);
           
            slist = DatableToList.ConvertToList<Student>(dt);
            //测试嵌套users类
            DataTable dt2 = new DataTable();
            dt2 = db.GetDataTable(comstr2);


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




        //使用泛型 条件查询学生
        public Student2 StudentLogin2(String StudentID, String Password)
        {
            String comstr = " select students.* from Students where studentid='" + StudentID + "'";
            
            Password = this.MD5(Password);

            Student2 students = new Student2();

            DataTable dt = new DataTable();
            DataBase db = new DataBase();
            dt = db.GetDataTable(comstr);
            if (Validate_Login(StudentID, Password))
            {
                //STATE_FAIL 0  ,STATE_SUCCESS 1,  STATE_OFFLINE 2
                students.stateCode = 1;
                students.content = DataTableConvertJson.DataTable2Json2(dt);
            }
            else
            {

                students.stateCode = 0;
                students.message = "账号或密码有误";
            }

            return students;
        }

        //使用泛型 条件查询学生
        public Student2 StudentLogin3(String StudentID, String Password)
        {
            String comstr = " select students.* from Students where studentid='" + StudentID + "'";

            Password = this.MD5(Password);

            Student2 students = new Student2();

            DataTable dt = new DataTable();
            DataBase db = new DataBase();
            dt = db.GetDataTable(comstr);
            if (Validate_Login(StudentID, Password))
            {
                //STATE_FAIL 0  ,STATE_SUCCESS 1,  STATE_OFFLINE 2
                students.stateCode = 1;
                students.content = DataTableTypeToJson.DataTableConvertjson(dt);
            }
            else
            {

                students.stateCode = 0;
                students.message = "账号或密码有误";
            }

            return students;
        }

        //使用泛型 条件查询学生
        public Student2 StudentLogin4(String StudentID, String Password)
        {
            String comstr = " select students.* from Students where studentid='" + StudentID + "'";

            Password = this.MD5(Password);

            Student2 students = new Student2();

            DataTable dt = new DataTable();
            DataTable dt2 = new DataTable();
            DataBase db = new DataBase();
            dt = db.GetDataTable(comstr);
            dt2 = db.GetDataTable(comstr);

            dt2.TableName = "Student";
            String result = DataTableConvertJson2.DataTable2Json(dt, dt2);
            


            
            if (Validate_Login(StudentID, Password))
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

        public string MD5(string pwd)
        {
            MD5 mD = System.Security.Cryptography.MD5.Create();
            byte[] bytes = Encoding.Unicode.GetBytes(pwd);
            byte[] value = mD.ComputeHash(bytes);
            return BitConverter.ToString(value);
        }

        public bool Validate_Login(String StudentID, String Password)
        {
            DataBase db = new DataBase();
            string comstr = "select count(*) from Students where  StudentID='" + StudentID + "' and StudentPwd='" + Password + "'";
         
            int flag = Convert.ToInt32(db.ExecuteValue(comstr));
            return flag > 0;
        }



    }
}
