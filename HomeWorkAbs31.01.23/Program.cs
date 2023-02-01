using System;

namespace HomeWorkAbs31._01._23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region MyRegion
            //Console.WriteLine("UserName Dail edin :");
            //string userName = Console.ReadLine();
            //string password;
            //do
            //{
            //    Console.WriteLine("Passwordu daxil edin :");
            //    password = Console.ReadLine();
            //} while (!CheckPassWord(password));
            //User user = new User();
            //user.UserName = userName;
            //user.Password = password;
            #endregion

            #region Task 3
            Console.WriteLine("Adinizi daxil edin : ");
            string name = Console.ReadLine();

            string groupNo;
            do
            {
                Console.WriteLine("GroupNo daxil edin : ");
                groupNo = Console.ReadLine();
            } while (CheckGroupNo(groupNo) == false);

            Student student = new Student()
            {
                Name = name,
                GroupNo = groupNo


            };
            Student student1 = new Student()
            {
                Name = name,
                GroupNo = groupNo

            };

            Console.WriteLine(student.No);
            Console.WriteLine(student1.No);

            #endregion

            #region Task 2
            Bus bus = new Bus(5)
            {
                Fare = 0.30,
                CurrentCountSeat = 30

            };
            bus.CountPerson(25);
            Console.WriteLine(bus.Fare);
            Console.WriteLine(bus.CurrentCountSeat);

            bus.Pay(0.20);
            bus.ArrivalTime();

            Taxi taxi = new Taxi(10)
            {
                CurrentCountSeat = 5,
                
                
            };
            
           
            Console.WriteLine(taxi.CurrentCountSeat);
            
            Console.WriteLine(taxi.Fare);
            taxi.Pay(13);
            taxi.ArrivalTime();

            


            #endregion


        }
        static bool CheckPassWord(string str)
        {

            if (string.IsNullOrWhiteSpace(str) || str.Length < 8 || str.Length > 25)
            {
                return false;
            }
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsDigit(str[i]))
                {
                    return true;
                }


            }
            return false;
        }

        static bool CheckGroupNo(string str)
        {
            if (string.IsNullOrWhiteSpace(str) || str.Length != 4)
            {
                return false;
            }
            if (!char.IsUpper(str[0]))
            {
                return false;
            }
            for (int i = 1; i < str.Length; i++)
            {
                if (!char.IsDigit(str[i]))
                {
                    return false;
                }
            }
            return true;
        }

    }
}
