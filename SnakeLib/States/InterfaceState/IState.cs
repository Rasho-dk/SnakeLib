using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLib.States.InterfaceState
{
    public interface IState<Tin, Tout>
    {
        /// <summary>
        /// Input function that returns the next state of the state machine
        /// </summary>
        /// <param name="input">Explain where the snake should goes</param>
        /// <returns></returns>
        public IState<char, bool> NextStateFunction(char input);

        /// <summary>
        /// Output function that returns the next state of the state machine
        /// </summary>
        /// <param name="snake"></param>
        /// <returns></returns>
        public bool OutputFunction(SnakeStateMachine snake);


    }

   
}
