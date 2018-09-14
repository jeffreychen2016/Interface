using Interfaces._Interfaces;

namespace Interfaces.AirCrafts
{
    public class AirCraft
    {
        IAirCraft _airCraft = null;

        public AirCraft(IAirCraft airCraft)
        {
            _airCraft = airCraft;
        }

        // do not care what the move type is
        public void Move()
        {
            _airCraft.Move();
        }

        public void Start()
        {
            _airCraft.Start();
        }

        public void Stop()
        {
            _airCraft.Stop();
        }
    }
}


