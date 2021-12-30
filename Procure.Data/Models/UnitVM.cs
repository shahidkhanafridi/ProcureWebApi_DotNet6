using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Procure.Data.Models
{
    public class UnitVM : BaseVM
    {
        public int Id { get; set; }
        public string BranchCode { get; set; }
        public string UnitCode { get; set; }
        public string UnitName { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public string StatusLabel { get; set; }
    }
}
