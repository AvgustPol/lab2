using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntonVlasiukZadanieDomowe2
{
    class Base : Movable
    {
        public virtual void Move()
        {
            //Just virtual method. It will be overridden.
        }

        public virtual void Stop()
        {
            //Just virtual method. It will be overridden.
        }

        public virtual bool AmIMoving()
        {
            //Just virtual method. It will be overridden.
            return false;
        }
    }
}
