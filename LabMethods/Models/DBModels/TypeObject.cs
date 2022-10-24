using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabMethods.Models.DBModels
{
    internal class TypeObject
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        //public virtual ICollection<LabMethod> TypeObjects { get; set; } = Array.Empty<LabMethod>();
    }
}
