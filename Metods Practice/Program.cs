//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

#region Vip Calculator

//using Metods_Practice;

//Calculate();

//static void Calculate()
//{
//    Calculator calculator = new Calculator();

//    Console.WriteLine("Please add first number :");

//Number1: string number1 = Console.ReadLine();

//    int chechkedNum1;
//    bool isParseNum1 = int.TryParse(number1, out chechkedNum1);



//    if (!isParseNum1)
//    {
//        Console.ForegroundColor = ConsoleColor.Red;
//        Console.WriteLine("Please add correct format number 1");
//        Console.ResetColor();
//        goto Number1;
//    }


//    Console.WriteLine("Please add operation :");
//    string operation = Console.ReadLine();

//    Console.WriteLine("Please add second number :");


//Number2: string number2 = Console.ReadLine();
//    int chechkedNum2;
//    bool isParseNum2 = int.TryParse(number2, out chechkedNum2);

//    if (!isParseNum2)
//    {
//        Console.ForegroundColor = ConsoleColor.Red;
//        Console.WriteLine("Please add correct format number 2");
//        Console.ResetColor();
//        goto Number2;
//    }

//    if (chechkedNum2 == 0)
//    {
//        Console.ForegroundColor = ConsoleColor.Red;
//        Console.WriteLine("Please don't add 0");
//        Console.ResetColor();
//        goto Number2;
//    }


//    var result = calculator.Calculation(chechkedNum1, chechkedNum2, operation);

//    Console.ForegroundColor = ConsoleColor.Green;
//    Console.WriteLine(result);
//    Console.ResetColor();

//}

#endregion



#region Doctors
//using Metods_Practice;


//var startDate = new DateTime(1993, 05, 25);
//var endDate = new DateTime(2002, 12, 25);


//GetDoctorsByBirthday(startDate, endDate);

//static void GetDoctorsByBirthday(DateTime start, DateTime end)
//{
//    var doctors = GetDoctors();

//    foreach (var doctor in doctors)
//    {
//        if (doctor.Birthday > start && doctor.Birthday < end)
//        {
//            Console.WriteLine($"{doctor.Name}-{doctor.Surname}-{doctor.Adress}-{doctor.Birthday}");
//        }
//    }

//}



//static Doctor[] GetDoctors()
//{
//    Doctor doctor1 = new Doctor()
//    {
//        Name = "Mirze",
//        Surname = "Besirzade",
//        Adress = "BulBule",
//        Birthday = new DateTime(1996, 01, 15)

//    };

//    Doctor doctor2 = new Doctor()
//    {
//        Name = "Aqsin",
//        Surname = "Hummetov",
//        Adress = "Xirdalan",
//        Birthday = new DateTime(1995, 11, 06)

//    };



//    Doctor doctor3 = new Doctor()
//    {
//        Name = "Cahandar",
//        Surname = "Velibeyli",
//        Adress = "Nargilenin kruqu",
//        Birthday = new DateTime(1996, 08, 11)

//    };



//    Doctor doctor4 = new Doctor()
//    {
//        Name = "Ferid",
//        Surname = "Abdurrahmanov",
//        Adress = "Xalqlar",
//        Birthday = new DateTime(2007, 05, 15)

//    };






//    Doctor doctor5 = new Doctor()
//    {
//        Name = "Hamca",
//        Surname = "Masanov",
//        Adress = "BulBule",
//        Birthday = new DateTime(2003, 10, 30)

//    };



//    Doctor[] doctors = { doctor1, doctor2, doctor3, doctor4, doctor5 };

//    return doctors;

//}



#endregion




#region Orders


//using Metods_Practice;

//static Order[] GetOrders()
//{
//    var order1 = new Order(new DateTime(2022, 12, 18), 500);
//    var order2 = new Order(new DateTime(2022, 12, 19), 300);
//    var order3 = new Order(new DateTime(2022, 12, 20), 250);
//    var order4 = new Order(new DateTime(2022, 12, 18), 1500);
//    var order5 = new Order(new DateTime(2022, 12, 22), 1500);
//    var order6 = new Order(new DateTime(2022, 12, 28), 500);

//    return new Order[] { order1, order2, order3, order4, order5, order6 };
//}

//DateTime filteredDate = DateTime.Now.AddDays(1);

//double filteredPrice = 200;

//GetFilteredOrders(filteredDate, filteredPrice);


//static void GetFilteredOrders(DateTime date, double price)
//{


//    var orders = GetOrders();

//    foreach (var item in orders)
//    {
//        if (item.Price > price && item.Date <= date)
//        {
//            Console.WriteLine(item.Date + ":" + item.Price);
//        }
//    }
//}



#endregion