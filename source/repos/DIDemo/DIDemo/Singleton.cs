namespace DIDemo
{
    public interface ISingleton
    {
        void Process();
    }
    public class Singleton:ISingleton
    {
        public Singleton()
        {
            Console.WriteLine("Singleton class constructor called");
        }
        public void Process()
        {
            throw new NotImplementedException();
        }
    }
}
