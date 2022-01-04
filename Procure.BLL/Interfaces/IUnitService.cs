using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Procure.BLL.Interfaces
{
    public interface IUnitService
    {
        UnitVM? UpsertUnit(UnitVM model);
        UnitVM? GetUnit(UnitVM model);
        IEnumerable<UnitVM> GetUnits();
    }
}
