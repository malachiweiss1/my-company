namespace MyProject
{
    class MyClass
    {
        public static List<myProject.Report> getReportList()
        {
            //make a reports list
            List<myProject.Report> reportList = new List<myProject.Report>();
            reportList.Add(new myProject.Report("I finished my project", new DateTime(2022, 12, 1), new TimeSpan(8, 0, 0), new TimeSpan(20, 0, 0)));
            reportList.Add(new myProject.Report("I have finished my app", new DateTime(2022, 12, 4), new TimeSpan(10, 0, 0), new TimeSpan(16,30, 0)));
            reportList.Add(new myProject.Report("I did my all tasks", new DateTime(2022, 12, 2), new TimeSpan(9, 0, 0), new TimeSpan(10, 0, 0)));
            reportList.Add(new myProject.Report("I did everything", new DateTime(2022, 12, 10), new TimeSpan(14, 0, 0), new TimeSpan(20, 0, 0)));
            reportList.Add(new myProject.Report("I almost finish my project", new DateTime(2022,12,9), new TimeSpan(11,0,0), new TimeSpan(15,30,0)));
            reportList.Add(new myProject.Report("I started my task", new DateTime(2022, 12, 7), new TimeSpan(8, 0, 0), new TimeSpan(10, 0, 0)));
            return reportList;
        }
        public static List<myProject.Task> getTaskList()
        {
            //make a tasks list
            List<myProject.Task> taskList = new List<myProject.Task>();
            taskList.Add(new myProject.Task("make great app", new DateTime(2022, 12, 1,19,30,0), new DateTime(2022, 12, 10, 21, 30, 0)));
            taskList.Add(new myProject.Task("finish all your jobs", new DateTime(2022, 12, 2, 9, 30, 0), new DateTime(2022, 12, 13, 22, 30, 0)));
            taskList.Add(new myProject.Task("make a big project", new DateTime(2022, 12, 3, 19, 0, 0), new DateTime(2022, 12, 11, 23, 30, 0)));
            taskList.Add(new myProject.Task("start working", new DateTime(2022, 12, 4, 10, 0, 0), new DateTime(2022, 12, 9, 16, 0, 0)));
            taskList.Add(new myProject.Task("call to Steve Jobs", new DateTime(2022, 12, 5, 14, 30, 0), new DateTime(2022, 12, 20, 16, 0, 0)));
            taskList.Add(new myProject.Task("make a phone call to your parents", new DateTime(2022, 12, 6, 11, 45, 0), new DateTime(2022, 12, 15, 15, 15, 0)));
            return taskList;
        }
        public static List<myProject.Employee> getEmployeeList()
        {
            //make a employees list
            List<myProject.Employee> employeeList = new List<myProject.Employee>();
            employeeList.Add(new myProject.Employee("Dani","Levi","Senior Developer", new myProject.BankAccount("Discount",104259,"Netanya"),"0507254332", "Netanya"));
            employeeList.Add(new myProject.Employee("Sharel", "Cohen", "Junior Developer", new myProject.BankAccount("Leumi", 432234, "Pardesiya"), "0507683332", "Rehovot"));
            employeeList.Add(new myProject.Employee("Avi", "Israel", "Devops", new myProject.BankAccount("Hapoalim", 648112, "Tel aviv"), "0507254121", "Tel aviv"));
            employeeList.Add(new myProject.Employee("Sean", "Kingston", "Data analyst", new myProject.BankAccount("Discount", 998676, "Yokneam"), "0543454332", "Yokneam"));
            employeeList.Add(new myProject.Employee("Izik", "Berger", "Product Manager", new myProject.BankAccount("Leumi", 123114, "Haifa"), "0524454324", "Rehovot"));
            employeeList.Add(new myProject.Employee("Chen", "Tomson", "Data Engineering", new myProject.BankAccount("Hapoalim", 141551,"Jerusalem"),"0507254332", "Jerisalem"));
            return employeeList;
        }
        public static List<myProject.Manager> getManagerList()
        {
            //make a manager list
            List<myProject.Manager> managerList = new List<myProject.Manager>();
            managerList.Add(new myProject.Manager("Malachi", "Weiss", "Big Boss", new myProject.BankAccount("Discount", 123998, "Netanya"), "0507212722", "Beer sheva"));
            managerList.Add(new myProject.Manager("Shani", "Levi", "VP R&D", new myProject.BankAccount("Leumi", 445119, "Tel aviv"), "0549436321", "Kfar saba"));
            managerList.Add(new myProject.Manager("Dana", "Nyuton", "CTO", new myProject.BankAccount("Hapoalim", 131443, "Hod hasharon"), "0523381642", "Raanana"));
            return managerList;
        }
        public static List<myProject.Secretary> GetSecretaryList()
        {
            //make a secretaries list
            List<myProject.Secretary> secretariesList = new List<myProject.Secretary>();
            secretariesList.Add(new myProject.Secretary("Daniel", "Orbach", "Secretary", new myProject.BankAccount("Discount", 104259, "Eilat"), "0506430902", "Jerusalem"));
            return secretariesList;
        }
        public static List<myProject.ManagerAssistant> GetManagerAssistants()
        {
            //make a manager assistants list
            List<myProject.ManagerAssistant> managerAssistants = new List<myProject.ManagerAssistant>();
            managerAssistants.Add(new myProject.ManagerAssistant("Ilay", "levinshtein", "my assistant", new myProject.BankAccount("leumi", 776554, "tel aviv"), "0507654432", "haifa"));
            return managerAssistants;
        }
        static void Main(string[] args)
        {
            Random rand = new Random();
            double bossSalary = rand.Next(10000, 12000); //salary of the big boss of the company
            List<myProject.Report> reports = getReportList();
            List<myProject.Task> taskList = getTaskList();
            List<myProject.Employee> employeeList = getEmployeeList();
            List<myProject.Manager> managerList = getManagerList();
            List<myProject.Secretary> secretaryList = GetSecretaryList();
            List<myProject.ManagerAssistant> managerAssistants = GetManagerAssistants();
            myProject.Company company = new myProject.Company(managerList[0], bossSalary);
            
            company.addEmployeeToManager(managerList[1], managerList[0]);
            company.addEmployeeToManager(secretaryList[0], managerList[0]);
            company.addEmployeeToManager(managerAssistants[0], managerList[0]);
            company.addEmployeeToManager(managerList[2], managerList[1]);
            company.addEmployeeToManager(employeeList[0], managerList[1]);
            company.addEmployeeToManager(employeeList[1], managerList[1]);
            company.addEmployeeToManager(employeeList[2], managerList[1]);
            company.addEmployeeToManager(employeeList[3], managerList[2]);
            company.addEmployeeToManager(employeeList[4], managerList[2]);
            company.addEmployeeToManager(employeeList[5], managerList[2]);
            int x, y,z;
            //Distributing reports randomly
            for (int i = 0; i < 10; i++)
            {
                x = rand.Next(0, 6);
                y = rand.Next(1,3);
                z = rand.Next(0,2);
                company.sendReport(employeeList[x], reports[x]);
                company.sendReport(managerList[y], reports[x]);
                if(z == 0)
                    company.sendReport(secretaryList[0], reports[5-x]);
                else
                    company.sendReport(managerAssistants[0], reports[5 - x]);
            }
            company.printAllReports();
            company.sendTaskFromManagerToEmployee(managerList[1],employeeList[2],taskList[0]);
            company.sendTaskFromManagerToEmployee(managerAssistants[0], secretaryList[0], taskList[1]);

            company.printAllTasks();
            company.editAddressToEmployee(secretaryList[0], managerList[0], "New-York");
            company.editPhoneNumberToEmployee(secretaryList[0], managerList[1], "0523381648");
            company.calculateAllSalaries();
            
        }
    }
}