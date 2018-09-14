using Interfaces._Interfaces;

namespace Interfaces.LandCrafts
{
    public class LandCraft
    {
        ILandCraft _landCraft = null;

        public LandCraft(ILandCraft landCraft)
        {
            _landCraft = landCraft;
        }

        // do not care what the move type is
        public void Move()
        {
            _landCraft.Move();
        }

        public void Start()
        {
            _landCraft.Start();
        }

        public void Stop()
        {
            _landCraft.Stop();
        }
    }
}


