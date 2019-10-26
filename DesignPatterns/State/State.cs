using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.State
{
    abstract class State
    {
        protected bool isConnected = true;

        public virtual void SimulateConnectionLoss() => isConnected = false;

        public abstract void Handle(Context context);

    }
}
