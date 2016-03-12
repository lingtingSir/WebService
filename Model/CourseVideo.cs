using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public  class CourseVideo
    {
        private int videoID;

        public int VideoID
        {
            get { return videoID; }
            set { videoID = value; }
        }
        private int courseID;

        public int CourseID
        {
            get { return courseID; }
            set { courseID = value; }
        }
        private String videoName;

        public String VideoName
        {
            get { return videoName; }
            set { videoName = value; }
        }
        private String videoPath;

        public String VideoPath
        {
            get { return videoPath; }
            set { videoPath = value; }
        }
        private String videoImage;

        public String VideoImage
        {
            get { return videoImage; }
            set { videoImage = value; }
        }
        private int videoLength;
        public int VideoLength
        {
            get { return videoLength; }
            set { videoLength = value; }
        }
        
    }
}
