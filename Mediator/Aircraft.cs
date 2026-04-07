using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class Aircraft
    {
        public string Name;
        private ICommandCentre _mediator;
        public Aircraft(string name, ICommandCentre mediator)
        {
            Name = name;
            _mediator = mediator;
            _mediator.RegisterAircraft(this);
        }

        public void Land()
        {
            Console.WriteLine($"Aircraft {Name} is landing.");
            _mediator.LandAircraft(this);
        }

        public void TakeOff()
        {
            Console.WriteLine($"Aircraft {Name} is taking off.");
            _mediator.TakeOffAircraft(this);
        }
    }
}
