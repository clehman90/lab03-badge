//part 1
using System.Runtime.Intrinsics.Arm;

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

//part 3
System.Console.Write("What is your dorm's x? ");
int dormX = Convert.ToInt32(Console.ReadLine());
System.Console.Write("What is your dorm's y? ");
int dormY = Convert.ToInt32(Console.ReadLine());
System.Console.Write("What is your classroom's x? ");
int classX = Convert.ToInt32(Console.ReadLine());
System.Console.Write("What is your classroom's y? ");
int classY = Convert.ToInt32(Console.ReadLine());
System.Console.Write("What is your walking speed in feet per second? ");
double walkingSpeed = Convert.ToDouble(Console.ReadLine());

//math
int diffX = classX - dormX;
double squareDiffX = Math.Pow(diffX, 2);
int diffY = classY - dormY;
double squareDiffY = Math.Pow(diffY, 2);
double addThem = squareDiffX + squareDiffY;
double distance = Math.Sqrt(addThem);
double distanceRounded = Math.Round(distance, 1);
double tripSeconds = distance / walkingSpeed;
double timeRounded = Math.Round(tripSeconds, 0);
double minutes = timeRounded / 60;
double minutesRounded = Math.Round(minutes, 0);
double seconds = timeRounded % 60;

//output
System.Console.WriteLine("Distance: " + distanceRounded + " feet");
System.Console.WriteLine("Walk Time: " + minutesRounded + " minutes " + seconds + " seconds");