using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
    public class Topics
    {
        public enum From
        {
            IN,
            OUT
        }

        public enum Status
        {
            YES,
            NO
        }

        string _topic;
        public string Topic
        {
            get { return _topic; }
            set { _topic = value; }
        }

        From _topicFrom;
        public From TopicFrom
        {
            get { return _topicFrom; }
            set { _topicFrom = value; }
        }
        Status _isCovered;
        public Status IsCovered
        {
            get { return _isCovered; }
            set { _isCovered = value; }
        }
        public Topics(string topicName, From topicFrom, Status coverdORnot)
        {
            this._topic = topicName;
            this._topicFrom = topicFrom;
            this._isCovered = coverdORnot;
        }
        public Topics()
        {

        }
    }
}
