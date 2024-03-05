using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SnakeLib.States.InterfaceState;

namespace SnakeLib.States
{
    public class DownState : IState<char, bool>
    {
        public IState<char, bool> NextStateFunction(char input)
        {
            switch (input)
            {
                case'a':
                    return new LeftState();
                case 'd': return new RightState();
                default:
                    return this;
            }
        }

        public bool OutputFunction(SnakeStateMachine snake)
        {
            snake.Move.Y++;
            return true;
        }
    }
}
