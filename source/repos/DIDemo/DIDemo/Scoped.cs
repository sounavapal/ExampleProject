namespace DIDemo
{
    public interface IScoped
    {
        void Process();
    }
    public class Scoped : IScoped
    {
        public Scoped()
        {
            Console.WriteLine("Scoped class constructor called");
        }
        public void Process()
        {
            throw new NotImplementedException();
        }
    }
}
