

using SnakeLib.States;

SnakeStateMachine snake = new SnakeStateMachine();

while (true)
{
    Console.Clear();
    Console.Write("Up");
    //This initializes the snake at the center of the screen
    Console.SetCursorPosition(snake.Move.X, snake.Move.Y);
    Console.Write("~~~");
    Console.SetCursorPosition(0, 0);
    ConsoleKeyInfo key = Console.ReadKey();
    snake.Update(key.KeyChar);
}