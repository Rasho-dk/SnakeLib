

using SnakeLib.States;

SnakeStateMachine snake = new SnakeStateMachine();

while (true)
{
    Console.Clear();
    Console.Write("a");
    Console.SetCursorPosition(snake.Move.X, snake.Move.Y);
    Console.Write("b");
    Console.SetCursorPosition(0, 0);
    ConsoleKeyInfo key = Console.ReadKey();
    snake.Update(key.KeyChar);
}