using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SnakeLib.States.InterfaceState;

namespace SnakeLib.States
{
    public class RightState : IState<char, bool>
    {
        public IState<char, bool> NextStateFunction(char input)
        {
            switch (input)
            {
                case 'w':
                    return new Upstate();
                case 's': return new DownState();
                default:
                    return this;
                
            }
        }

        public bool OutputFunction(SnakeStateMachine snake)
        {
            snake.Move.X++;
            return true;
        }
    }
}
