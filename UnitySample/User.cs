using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitySample
{
    public class User:IEquatable<User>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }

        public override string ToString()
        {
            return Name+" "+Family;
        }

        public bool Equals(User other)
        {
            if (other==null)
            {
                return false;
            }
            return this.Id.Equals(other.Id);
        }



    }
}
