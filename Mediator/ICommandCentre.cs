using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public interface ICommandCentre
    {
        void RegisterAircraft(Aircraft aircraft);
        void RegisterRunway(Runway runway);
        void LandAircraft(Aircraft aircraft);
        void TakeOffAircraft(Aircraft aircraft);
    }
}
