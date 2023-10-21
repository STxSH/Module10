namespace Module10
{
    internal class Program
    {

        //task 10.4.4
        static void Main(string[] args)
        {

            User user = new User();
            Account account = new Account();
            IUpdater<Account> updater = new UserService();

            UserService userService = new UserService();
            userService.Update(user);


            Console.ReadKey();
        }
    }
    public class User
    {

    }

    public class Account : User
    {

    }

    public interface IUpdater<in T>
    {
        void Update(T entity);
    }


    public class UserService : IUpdater <User>
    {
        public void Update(User entity) { }
    }
}