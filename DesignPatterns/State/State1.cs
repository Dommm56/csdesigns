using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.State
{
    class State1 : State
    {
        public override void Handle(Context context)
        {
            if (!this.isConnected)
            {
                context.State = new State2();
            }
        }
    }
}
