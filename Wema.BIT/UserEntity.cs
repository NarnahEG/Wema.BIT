namespace Wema.BIT
{
    public class UserEntity
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
        new Users() { Id = 1, FirstName = "Kemi", LastName = "Johnson", Email = "johnson@gmail.com" },

        new Users() { Id = 2, FirstName = "Tolu", LastName = "Obasun", Email = "toluobasun@gmail.com" },

        new Users() { Id = 3, FirstName = "Tomi", LastName = "Olaoye", Email = "tomiolaoye@gmail.com" },

        new Users() { Id = 4, FirstName = "Joseph", LastName = "Udoka", Email = "josephudoka@gmail.com" },

        new Users() { Id = 5, FirstName = "Esther", LastName = "Gbadamosi", Email = "esthergbadamosi@gmail.com" },
    };

            List<Payment> payments = new List<Payment>()
    {
        new Payment() { Id = 1, UserID = "1", Amount = 2000 },

        new Payment() { Id = 2, UserID = "4", Amount = 3056 },

        new Payment() { Id = 3, UserID = "2", Amount = 4000 },

        new Payment() { Id = 4, UserID = "3", Amount = 3000 },

        new Payment() { Id = 5, UserID = "5", Amount = 3000 },

        new Payment() { Id = 6, UserID = "3", Amount = 2500 },

        new Payment() { Id = 7, UserID = "2", Amount = 1000 },

        new Payment() { Id = 8, UserID = "5", Amount = 2800 },

        new Payment() { Id = 9, UserID = "4", Amount = 2600 },

        new Payment() { Id = 10, UserID = "1", Amount = 2000 },

        new Payment() { Id = 11, UserID = "3", Amount = 1500 },

        new Payment() { Id = 12, UserID = "5", Amount = 2000 },

        new Payment() { Id = 13, UserID = "4", Amount = 7500 },

        new Payment() { Id = 14, UserID = "2", Amount = 6000 },

        new Payment() { Id = 15, UserID = "5", Amount = 2200 },

        new Payment() { Id = 19, UserID = "1", Amount = 2500 },
    };

            foreach (var user in users)
            {
                Console.WriteLine($"ID: {user.Id}, Email: {user.Email}, Name: {user.FirstName} {user.LastName}");

                // Filter payments for the current user
                var userPayments = payments.Where(payment => payment.UserID == user.Id.ToString()).Take(3);

                foreach (var payment in userPayments)
                {
                    Console.WriteLine($"ID: {payment.Id}, Amount: {payment.Amount}, UserID: {payment.UserID}");
                }
            }

        }  
    }
}

