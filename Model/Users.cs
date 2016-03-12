using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class Users
    {
        private String userID;
        private String userPwd;
        private String userName;
        private String userImage;
        private String userDes;
        private DateTime registerDate;
        private DateTime overDate;
        private int userIntegral;
        public string UserID
        {
            get
            {
                return this.userID;
            }
            set
            {
                this.userID = value;
            }
        }
        public string UserPwd
        {
            get
            {
                return this.userPwd;
            }
            set
            {
                this.userPwd = value;
            }
        }
        public string UserName
        {
            get
            {
                return this.userName;
            }
            set
            {
                this.userName = value;
            }
        }
        public string UserImage
        {
            get
            {
                return this.userImage;
            }
            set
            {
                this.userImage = value;
            }
        }
        public string UserDes
        {
            get
            {
                return this.userDes;
            }
            set
            {
                this.userDes = value;
            }
        }
        public DateTime RegisterDate
        {
            get
            {
                return this.registerDate;
            }
            set
            {
                this.registerDate = value;
            }
        }
        public DateTime OverDate
        {
            get { return overDate; }
            set { overDate = value; }
        }
        public int UserIntegral
        {
            get
            {
                return this.userIntegral;
            }
            set
            {
                this.userIntegral = value;
            }
        }
       
    }
}
