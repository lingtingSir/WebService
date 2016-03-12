using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class ProblemPaper
    {
        private int ppID;

        public int PpID
        {
            get { return ppID; }
            set { ppID = value; }
        }
        private int prkID;

        public int PrkID
        {
            get { return prkID; }
            set { prkID = value; }
        }
        private int ptID;

        public int PtID
        {
            get { return ptID; }
            set { ptID = value; }
        }
        private String name;

        public String Name
        {
            get { return name; }
            set { name = value; }
        }
        private DateTime updateTime;

        public DateTime UpdateTime
        {
            get { return updateTime; }
            set { updateTime = value; }
        }
        private String ppDesc;

        public String PpDesc
        {
            get { return ppDesc; }
            set { ppDesc = value; }
        }
        private int problemNum;

        public int ProblemNum
        {
            get { return problemNum; }
            set { problemNum = value; }
        }
        private String categoryURL;

        public String CategoryURL
        {
            get { return categoryURL; }
            set { categoryURL = value; }
        }

        private String header;

        public String Header
        {
            get { return header; }
            set { header = value; }
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

       
    }
}
