using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractions
{
    class Player : IPlayable, IRecordable
    {
        public void Play()
        {
            Console.WriteLine("IPlayable -> Play");
        }
        void IPlayable.Pause()
        {
            Console.WriteLine("IPlayable -> Pause");
        }
        void IPlayable.Stop()
        {
            Console.WriteLine("IPlayable -> Stop");
        }
        public void Record()
        {
            Console.WriteLine("IRecordable -> Record");
        }
        void IRecordable.Pause()
        {
            Console.WriteLine("IRecordable -> Pause");
        }
        void IRecordable.Stop()
        {
            Console.WriteLine("IRecordable -> Stop");
        }
    }
}
