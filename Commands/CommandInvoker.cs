namespace SnakeConsole
{
    public class CommandInvoker
    {
        public void Invoke(ICommand command)
        {
            if (command != null)
            {
                command.Handle();
            }
        }
    }
}