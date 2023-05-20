namespace ExceptionUserRegistration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome Exception Problem");
            try
            {
                
               
                string firstName = GetValidFirstName();
                Console.WriteLine("Registration successful!");
                Console.WriteLine("First Name: " + firstName);
            }
            catch (UserRegisterException ex)
            {
                Console.WriteLine("Registration failed: " + ex.Message);
            }
            
        }
        static string GetValidFirstName()
        {
            Console.Write("Enter First Name: ");
            string firstName = Console.ReadLine();

            if (string.IsNullOrEmpty(firstName))
            {
                throw new UserRegisterException("First Name cannot be empty.");
            }
            else if (firstName.Length < 3)
            {
                throw new UserRegisterException("First Name should have a minimum of 3 characters.");
            }
            else if (!char.IsUpper(firstName[0]))
            {
                throw new UserRegisterException("First Name should start with a capital letter.");
            }

            return firstName;
        }
    }
}