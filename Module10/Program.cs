namespace Module10
{
    internal class Program
    {

        //task 10.2.2
        static void Main(string[] args)
        {
            Writer writer = new Writer();

            ((IWriter)writer).Write();


        }
    }
    public interface IWriter
    {
        void Write();
    }

    public class Writer : IWriter
    {
        void IWriter.Write ()
        {

        }
    }


}