//part 1
System.Console.Write("What is your full name? ");
string fullName = Console.ReadLine();
fullName = fullName.Trim();
int spacePosition = fullName.IndexOf(" ");
string firstName = fullName.Substring(0, spacePosition);
string lastName = fullName.Substring(spacePosition + 1);

//output
System.Console.WriteLine("Name on badge: " + fullName.ToUpper());
System.Console.WriteLine("Username: " + firstName.Substring(0,1) + lastName.ToLower());
System.Console.WriteLine("Initials: " + firstName.Substring(0,1).ToUpper() + "." + lastName.Substring(4,1).ToUpper() + ".");
System.Console.WriteLine("Letters in last name: " + lastName.Length);

//part 2
Random rng = new Random();
int studentID = rng.Next(100000, 1000000);
int lockerNum = rng.Next(1, 501);

//output
System.Console.WriteLine("Student ID: " + studentID);
System.Console.WriteLine("Locker: " + lockerNum);