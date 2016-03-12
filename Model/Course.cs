using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class Course
    {
        private int courseID;
        private int parentID;
        private string courseName;
        private string courseDes;
        private string x;
        private string y;
        private string z;
        private int courseSort;
        private int courseKind;
        private string coursePPT;
        private string courseVideo;
        private String categoryURL;
        public int CourseID
        {
            get
            {
                return this.courseID;
            }
            set
            {
                this.courseID = value;
            }
        }
        public int ParentID
        {
            get
            {
                return this.parentID;
            }
            set
            {
                this.parentID = value;
            }
        }
        public string CourseName
        {
            get
            {
                return this.courseName;
            }
            set
            {
                this.courseName = value;
            }
        }
        public string CourseDes
        {
            get
            {
                return this.courseDes;
            }
            set
            {
                this.courseDes = value;
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
        public int CourseSort
        {
            get
            {
                return this.courseSort;
            }
            set
            {
                this.courseSort = value;
            }
        }
        public int CourseKind
        {
            get
            {
                return this.courseKind;
            }
            set
            {
                this.courseKind = value;
            }
        }
        public string CoursePPT
        {
            get
            {
                return this.coursePPT;
            }
            set
            {
                this.coursePPT = value;
            }
        }
        public string CourseVideo
        {
            get
            {
                return this.courseVideo;
            }
            set
            {
                this.courseVideo = value;
            }
        }
       

        public String CategoryURL
        {
            get { return categoryURL; }
            set { categoryURL = value; }
        }
    }
}
