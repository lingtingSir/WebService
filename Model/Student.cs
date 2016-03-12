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
