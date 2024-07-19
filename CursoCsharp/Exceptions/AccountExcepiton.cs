namespace CursoCsharp.Exceptions
{
    internal class AccountExcepiton : ApplicationException
    {
        public AccountExcepiton(string message) 
            : base (message)
        {
        }
    }
}
