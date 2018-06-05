namespace DEVTask7
{
    /// <summary>
    /// Interface provides method execute 
    /// </summary>
    /// <typeparam name="T">
    /// type of returned value
    /// </typeparam>
    public interface ICommand<T>
    {
        T Execute();
    }
}
