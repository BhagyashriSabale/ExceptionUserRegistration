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
                string lastName = GetValidLastName();
                string email = GetValidEMail();
                Console.WriteLine("Registration successful!");
                Console.WriteLine("First Name: " + firstName);
                Console.WriteLine("Last Name: " + lastName);
                Console.WriteLine("Email: " + email);
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
        static string GetValidLastName()
        {
            Console.Write("Enter Last Name: ");
            string lastName = Console.ReadLine();

            if (string.IsNullOrEmpty(lastName))
            {
                throw new UserRegisterException("Last Name cannot be empty.");
            }
            else if (lastName.Length < 3)
            {
                throw new UserRegisterException("Last Name should have a minimum of 3 characters.");
            }
            else if (!char.IsUpper(lastName[0]))
            {
                throw new UserRegisterException("Last Name should start with a capital letter.");
            }

            return lastName;
        }
        static string GetValidEMail()
        {
            Console.Write("Enter Email: ");
            string email = Console.ReadLine();
            if (string.IsNullOrEmpty(email))
            {
                throw new UserRegisterException("Email cannot be empty.");
            }
            else if (!email.Contains("@") || !email.Contains("."))
            {
                throw new UserRegisterException("Invalid Email format.");
            }
            string[] parts = email.Split('@');
            if (parts.Length != 2)
            {
                throw new UserRegisterException("Invalid Email format.");
            }

            string[] domainParts = parts[1].Split('.');
            if (domainParts.Length < 2 || domainParts.Length > 4)
            {
                throw new UserRegisterException("Invalid Email format.");
            }
            foreach (string part in parts)
            {
                if (string.IsNullOrEmpty(part))
                {
                    throw new UserRegisterException("Invalid Email format.");
                }
            }

            return email;
        }
    }
}