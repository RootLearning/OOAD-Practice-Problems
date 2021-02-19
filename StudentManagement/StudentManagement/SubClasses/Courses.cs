using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
    public class Courses : Topics
    {
        public enum Course
        {
            FundamentalProgramming = 6000,

            CompetitiveItermediate = 8000,
            CompetitiveAdvanced = 20000,

            ProblemSolving = 15000,
            
            DataScience = 12000,
            DataStructure = 15000
        }
        List<Topics> _topicHistory = new List<Topics>();
        public List<Topics> TopicHisotry
        {
            get { return _topicHistory; }
        }

        public void LoadTopicAndStatus(Course selectedCourse)
        {
            if(selectedCourse.Equals(Course.CompetitiveAdvanced))
            {
                _topicHistory.Add(new Topics("Competitive Advanced Topic 1", From.OUT, Status.YES));
                _topicHistory.Add(new Topics("Competitive Advanced Topic 2", From.OUT, Status.YES));
                _topicHistory.Add(new Topics("Competitive Advanced Topic 3", From.IN, Status.YES));
                _topicHistory.Add(new Topics("Competitive Advanced Topic 4", From.IN, Status.YES));
                _topicHistory.Add(new Topics("Competitive Advanced Topic 5", From.IN, Status.NO));
                _topicHistory.Add(new Topics("Competitive Advanced Topic 6", From.IN, Status.YES));
                _topicHistory.Add(new Topics("Competitive Advanced Topic 7", From.IN, Status.YES));
                _topicHistory.Add(new Topics("Competitive Advanced Topic 8", From.IN, Status.NO));
            }
            else if(selectedCourse.Equals(Course.CompetitiveItermediate))
            {
                _topicHistory.Add(new Topics("Competitive Intermediate Topic 1", From.OUT, Status.YES));
                _topicHistory.Add(new Topics("Competitive Intermediate Topic 2", From.OUT, Status.YES));
                _topicHistory.Add(new Topics("Competitive Intermediate Topic 3", From.IN, Status.YES));
                _topicHistory.Add(new Topics("Competitive Intermediate Topic 4", From.IN, Status.YES));
                _topicHistory.Add(new Topics("Competitive Intermediate Topic 5", From.IN, Status.YES));
                _topicHistory.Add(new Topics("Competitive Intermediate Topic 6", From.IN, Status.YES));
                _topicHistory.Add(new Topics("Competitive Intermediate Topic 7", From.IN, Status.NO));
                _topicHistory.Add(new Topics("Competitive Intermediate Topic 8", From.IN, Status.NO));
            }
        }
    }
}
