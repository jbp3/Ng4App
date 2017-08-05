using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ng4AppData
{
    public class Person
    {
        public Person()
        {
            this.Thoughts = new HashSet<Thought>();
        }

        public int PersonID { get; set; }
        public string PersonName { get; set; }

        public virtual ICollection<Thought> Thoughts { get; set; }
    }

    public class Thought
    {
        public int ThoughtID { get; set; }
        public string ThoughtLiteral { get; set; }
    }
}
