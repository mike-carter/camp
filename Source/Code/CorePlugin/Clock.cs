using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Duality;

namespace CampGame
{
    public class Clock : Component, ICmpInitializable, ICmpUpdatable
    {
        public static readonly DateTime NewGameStartTime = new DateTime(2016, 6, 19, 6, 0, 0);

        DateTime inGameTime = NewGameStartTime;
        float timeCounter;
        
        public string Date
        {
            get { return inGameTime.ToString("D"); }
        }
        
        public float FramesPerMinute { get; set; } = 60f;

        public int Year
        {
            get { return inGameTime.Year; }
        }

        void ICmpInitializable.OnInit(InitContext context)
        {
            
        }

        void ICmpInitializable.OnShutdown(ShutdownContext context)
        {
            
        }

        void ICmpUpdatable.OnUpdate()
        {
            timeCounter += Time.TimeMult;

        }
    }
}
