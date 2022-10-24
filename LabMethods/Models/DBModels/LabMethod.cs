using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabMethods.Models.DBModels
{
    internal class LabMethod
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public string Description { get; set; } = null!;
        //public virtual TypeObject? TypeObject { get; set; }
    }
}
