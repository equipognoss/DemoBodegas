using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GnossLRTRoutesExample.Model
{
    public class Entity : IEquatable<Entity>
    {
        public Entity(string subject)
        {
            Subject = subject;
            Properties = new Dictionary<string, Property>();
        }

        public string Subject { get; set; }

        public Dictionary<string, Property> Properties { get; }

        public bool Equals(Entity other)
        {
            return Subject.Equals(other.Subject);
        }
    }

    public class Property
    {
        public Property(string predicate)
        {
            Predicate = predicate;
            Objects = new List<ObjectWithLanguage>();
        }

        public string Predicate { get; set; }

        public List<ObjectWithLanguage> Objects { get; }
    }

    public class ObjectWithLanguage
    {
        public string Value { get; set; }
        public string Language { get; set; }
    }
}
