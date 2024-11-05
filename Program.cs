namespace SuperParentClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var user = new User { Name = "test ", Id = 10 };
            var user2 = user; ;

            Console.WriteLine(user.Equals(user2));


            object o = true;
            object x = "";
            object u = user;

            string t = (string)x;

        }
    }

    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return $"id = {Id} ,name ={Name}";
        }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }
    }

    public class User2 : User
    {

    }
}
