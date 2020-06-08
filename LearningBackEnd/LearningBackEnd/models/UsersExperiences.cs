using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearningBackEnd.models
{
    public class UsersExperiences
    {
        public long UserID { get; set; }
        public long ExperienceID { get; set; }
        public virtual User User { get; set; }
        public virtual Exception Exception { get; set; }
    }
}
