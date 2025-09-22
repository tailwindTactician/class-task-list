var employees = new List<Employee>()
        {
            new Employee()
            {
                Id = 1,
                FirstName = "Alijon",
                LastName = "Zabirov",
                Age = 24,
                PhoneNumber = "881667007",
                Salary = 4000
            },
            new Employee()
            {
                Id = 2,
                FirstName = "Nurullo",
                LastName = "Sulaymonov",
                Age = 30,
                PhoneNumber = "908765432",
                Salary = 8000
            },
            new Employee()
            {
                Id = 3,
                FirstName = "Shodmon",
                LastName = "Inoyatzoda",
                Age = 26,
                PhoneNumber = "987009988",
                Salary = 7800
            }
        };

        // Section 3
        var newEmployees = new List<Employee>()
        {
            new Employee()
            {
                Id = 4,
                FirstName = "Javohir",
                LastName = "Saidov",
                Age = 28,
                PhoneNumber = "900112233",
                Salary = 6500
            },
            new Employee()
            {
                Id = 5,
                FirstName = "Bekzod",
                LastName = "Karimov",
                Age = 32,
                PhoneNumber = "933221144",
                Salary = 7200
            }
        };
        employees.AddRange(newEmployees);

        // Section 4
        employees = employees.OrderBy(e => e.Salary).ToList();

        // Section 5
        employees.RemoveAll(e => e.Age < 25);

        // Section 6
        var highSalaryEmployees = employees.FindAll(e => e.Salary > 5000);

        // Section 7
        var empWithId3 = employees.FirstOrDefault(e => e.Id == 3);
        if (empWithId3 != null)
        {
            employees.Remove(empWithId3);
        }

        // Section 8
        bool existsJura = employees.Exists(e => e.FirstName == "Jura");
        if (!existsJura)
        {
            employees.Insert(1, new Employee()
            {
                Id = 6,
                FirstName = "Jura",
                LastName = "Jurayev",
                Age = 29,
                PhoneNumber = "944556677",
                Salary = 5000
            });
        }

        // Section 9
        var moreEmployees = new List<Employee>()
        {
            new Employee()
            {
                Id = 7,
                FirstName = "Rustam",
                LastName = "Qodirov",
                Age = 35,
                PhoneNumber = "911223344",
                Salary = 9000
            },
            new Employee()
            {
                Id = 8,
                FirstName = "Amir",
                LastName = "Rahmonov",
                Age = 27,
                PhoneNumber = "977665544",
                Salary = 6000
            },
            new Employee()
            {
                Id = 9,
                FirstName = "Dilshod",
                LastName = "Nazarov",
                Age = 31,
                PhoneNumber = "988332211",
                Salary = 8500
            }
        };
        employees.InsertRange(2, moreEmployees);

        // Section 10
        employees = employees.OrderByDescending(e => e.Salary).ToList();

        foreach (var emp in employees)
        {
            Console.WriteLine($"ID: {emp.Id}, {emp.FirstName} {emp.LastName}, Age: {emp.Age}, Salary: {emp.Salary}");
        }
    