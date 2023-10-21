namespace Module10
{
    internal class Program
    {

        //task 10.2.4
        static void Main(string[] args)
        {
            Worker worker = new Worker();

            ((IWorker) worker).Build();

            Console.ReadKey();
        }
    }
    public interface IWorker
    {
        public void Build();
    }

    public class Worker :IWorker
    {
        void IWorker.Build()
        {

        }
    }

}