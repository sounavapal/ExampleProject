namespace DIDemo
{
    public interface ITransient
    {
        public void Process();
    }
    public class Transient:ITransient
    {
        public Transient()
        {
            Console.WriteLine("Transient class constructor called");
        }
        public void Process()
        {
            throw new NotImplementedException();
        }
    }
}
