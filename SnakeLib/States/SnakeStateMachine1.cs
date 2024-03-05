using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SnakeLib.States.InterfaceState;

namespace SnakeLib.States
{
    public class SnakeStateMachine 
    {
        public Move Move { get; set; }

        public IState<char, bool> State { get; set; }

        /// <summary>
        /// This is the constructor for the SnakeStateMachine class which initializes the state and the position of the snake from the beginning of the game
        /// By default the snake is in the up state and the position is (x,y)
        /// </summary>
        public SnakeStateMachine()
        {
            State = new Upstate() ;
            Move = new Move(){X = 10, Y = 14};


        }
        /// <summary>
        /// This method updates the state of the snake and the position of the snake
        /// </summary>
        /// <param name="input">new road value for the snake</param>
        public void Update(char input)
        {
            State = State.NextStateFunction(input);
            State.OutputFunction(this);

        }
    }
}
