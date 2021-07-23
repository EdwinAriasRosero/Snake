namespace Engine
{
    public class CommandInvoker
    {
        public void Invoke(ICommand command)
        {
            command?.Handle();
        }
    }
}