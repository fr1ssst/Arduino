using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bunker.Creatures
{
    class Women : Player
    {
        Random random = null;
        public Women(string name, string job, string hobby, string nature,
            string orientation) : base(name)
        {
            Random random = new Random();

            this.sex = "Жінка";
            this.job = job;
            this.age = random.Next(14, 86);
            this.hobby = hobby;
            this.nature = nature;
            this.orientation = orientation;
        }
    }
}
