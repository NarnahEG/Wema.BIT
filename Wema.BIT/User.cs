namespace Wema.BIT
{
    public class User
    {
        public class Users
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }
        }

        public class Payment
        {
            public int Id { get; set; }
            public string UserID { get; set; }
            public decimal Amount { get; set; }

        }
        public static void Main(string[] args)
        {

            List<Users> users = new List<Users>()
    {
        new Users() { Id = 1, FirstName = "Aluh", LastName = "Johnson", Email = "johnson@gmail.com" },

        new Users() { Id = 2, FirstName = "Tolu", LastName = "Obasun", Email = "toluobasun@gmail.com" },

        new Users() { Id = 3, FirstName = "Tomi", LastName = "Olaoye", Email = "tomiolaoye@gmail.com" },

        new Users() { Id = 4, FirstName = "Joseph", LastName = "Udoka", Email = "josephudoka@gmail.com" },

        new Users() { Id = 5, FirstName = "Esther", LastName = "Gbadamosi", Email = "esthergbadamosi@gmail.com" },
    };

            List<Payment> payments = new List<Payment>()
    {
        new Payment() { Id = 1, UserID = "1", Amount = 2000 },

        new Payment() { Id = 2, UserID = "2", Amount = 2000 },

        new Payment() { Id = 3, UserID = "3", Amount = 2000 },
    };

            for (int i = 0; i < users.Count; i++)
            {
                Console.WriteLine("Full Name: " + users[i].FirstName + ' ' + users[i].LastName);
            }
            for (int i = 0; i < payments.Count; i++)
            {
                Console.WriteLine("ID: " + payments[i].UserID + ' ' + "Amount: " + payments[i].Amount);
            }
        }  

    }
}