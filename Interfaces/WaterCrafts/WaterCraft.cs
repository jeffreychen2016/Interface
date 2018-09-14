using Interfaces._Interfaces;

namespace Interfaces.WaterCrafts
{
    public class WaterCraft
    {
        IWaterCraft _waterCraft = null;

        public WaterCraft(IWaterCraft waterCraft)
        {
            _waterCraft = waterCraft;
        }

        // do not care what the move type is
        public void Move()
        {
            _waterCraft.Move();
        }

        public void Start()
        {
            _waterCraft.Start();
        }

        public void Stop()
        {
            _waterCraft.Stop();
        }
    }
}


