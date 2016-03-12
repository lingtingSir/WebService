using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class ProblemResourceKind
    {
        private int pRKID;
        private int parentID;
        private string name;
        private string pRKDesc;
        private int pRKLevel;
        private string path;
        private int sort;
        private int paperNum;
        private int leafNode;
        private string x;
        private string y;
        public int PRKID
        {
            get
            {
                return this.pRKID;
            }
            set
            {
                this.pRKID = value;
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
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        public string PRKDesc
        {
            get
            {
                return this.pRKDesc;
            }
            set
            {
                this.pRKDesc = value;
            }
        }
        public int PRKLevel
        {
            get
            {
                return this.pRKLevel;
            }
            set
            {
                this.pRKLevel = value;
            }
        }
        public string Path
        {
            get
            {
                return this.path;
            }
            set
            {
                this.path = value;
            }
        }
        public int Sort
        {
            get
            {
                return this.sort;
            }
            set
            {
                this.sort = value;
            }
        }
        public int PaperNum
        {
            get
            {
                return this.paperNum;
            }
            set
            {
                this.paperNum = value;
            }
        }
        public int LeafNode
        {
            get
            {
                return this.leafNode;
            }
            set
            {
                this.leafNode = value;
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
    }
}
