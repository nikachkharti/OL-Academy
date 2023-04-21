namespace OLBootcampConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region დავალება 1

            //1) დაწერეთ შემდეგი პროგრამა:
            //კონსოლიდან შეიყვანეთ იუზერის სახელი და პაროლი. თუ დაემთხვა თქვენს მიერ შექმნილ
            //იუზერს და პაროლს, კონსოლზე დაიბეჭდოს წარმატება. 5 ცდის შემდეგ კი დააბრუნოს
            //შეცდომის შეტყობინება.
            //int attempts = 5;
            //while (attempts > 0)
            //{
            //    Console.Write("Please enter the username: ");
            //    string enteredUsername = Console.ReadLine();
            //    Console.WriteLine("-----------------------------------");

            //    Console.Write("Please enter the password: ");
            //    string enteredPassword = Console.ReadLine();
            //    Console.WriteLine("-----------------------------------");

            //    if (UserInfoIsValid(enteredUsername, enteredPassword))
            //    {
            //        Console.WriteLine("SUCCESS");
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("INCORRECT INFORMATION");
            //    }
            //    Console.WriteLine("-----------------------------------");
            //    attempts--;
            //}

            #endregion
        }


        /// <summary>
        /// პირველი დავალება მომხმარებლის პაროლის და სახელის შემოწმება
        /// </summary>
        /// <param name="username">შემოყვანილი სახელი</param>
        /// <param name="password">შემოყვანილი პაროლი</param>
        /// <returns>bool მნიშვნელობას</returns>
        static bool UserInfoIsValid(string username, string password)
        {
            string myUsername = "myUser";
            string myPassword = "myPassword";

            return username == myUsername && password == myPassword;
        }
    }
}