using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class ProblemsLib
    {
        private int problemsLibID;

        public int ProblemsLibID
        {
            get { return problemsLibID; }
            set { problemsLibID = value; }
        }
        private int typeID;

        public int TypeID
        {
            get { return typeID; }
            set { typeID = value; }
        }
        private int courseID;

        public int CourseID
        {
            get { return courseID; }
            set { courseID = value; }
        }
        private int problemspaperID;

        public int ProblemspaperID
        {
            get { return problemspaperID; }
            set { problemspaperID = value; }
        }
        private String problemName;

        public String ProblemName
        {
            get { return problemName; }
            set { problemName = value; }
        }
        private String problemAnswer;

        public String ProblemAnswer
        {
            get { return problemAnswer; }
            set { problemAnswer = value; }
        }
        private String problemDes;

        public String ProblemDes
        {
            get { return problemDes; }
            set { problemDes = value; }
        }
        private Int64 questionNumber;

        public Int64 QuestionNumber
        {
            get { return questionNumber; }
            set { questionNumber = value; }
        }
        private String paperName;

        public String PaperName
        {
            get { return paperName; }
            set { paperName = value; }
        }
    }
}
