using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class CommandCentre : ICommandCentre
    {
        private List<Runway> _runways = new List<Runway>();
        private List<Aircraft> _aircrafts = new List<Aircraft>();

        private Dictionary<Aircraft, Runway> _aircraftLocations = new Dictionary<Aircraft, Runway>();


        public void LandAircraft(Aircraft aircraft)
        {
            var freeRunway = _runways.FirstOrDefault(r => !r.IsBusy);

            if(freeRunway != null)
            {
                Console.WriteLine($"Aircraft {aircraft.Name} is landing.");
                freeRunway.IsBusy = true;
                freeRunway.HighLightRed();
                _aircraftLocations[aircraft] = freeRunway;
            }
            else
            {
                Console.WriteLine($"No free runway for aircraft {aircraft.Name}. Please wait.");
            }
        }

        public void RegisterAircraft(Aircraft aircraft) => _aircrafts.Add(aircraft);
        public void RegisterRunway(Runway runway) => _runways.Add(runway);
        

        public void TakeOffAircraft(Aircraft aircraft)
        {
            if(_aircraftLocations.TryGetValue(aircraft, out var runway))
            {
                Console.WriteLine($"Aircraft {aircraft.Name} is taking off.");
                runway.IsBusy = false;
                runway.HighLightGreen();
                _aircraftLocations.Remove(aircraft);
            }
            else
            {
                Console.WriteLine($"Aircraft {aircraft.Name} is not on any runway.");
            }
        }
    }
}
