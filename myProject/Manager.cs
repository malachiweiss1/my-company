namespace myProject
{
    class Manager : Employee
    {
        private static int id = 1;//myId of the bigBoss is 1
        private int myId;
        private double bossSalary;
        public double BossSalary
        {
            set { bossSalary = value; }
        }
        private List<Employee> employees;
        public List<Employee> Employees
        {
            get { return employees; }
        }
        public void addEmployee(Employee e)
        {
            employees.Add(e);
        }
        public int getSumOfEmployees()
        {
            return employees.Count;
        }
        public void sendTaskToEmployee(Employee e, Task t)
        {
            e.addTask(t);
        }
        public void printReports()
        {
            //print reports only if exists
            int count = 0;
            foreach (Employee e in employees)
                foreach(Report report in e.Reports)
                    count++;
            if (count != 0) //reports sum is more than zero
            {
                Console.WriteLine(getName() + " reports:");
                foreach (Employee em in employees)
                    if (em.Reports.Count > 0)
                    {
                        Console.WriteLine('\t' + em.getName() + ":");
                        foreach (Report r in em.Reports)
                            Console.WriteLine('\t'  + r.ToString());
                    }
            }
        }
        public bool isEmployeeExist(Employee e)
        {
            //check if specific employee belongs to this manager
            foreach (Employee em in employees)
                if (em == e)
                    return true;
            return false;
        }
        public override double getSalary()
        {
            if (myId == 1)
                return bossSalary;
            return workingHours() * 23; //20*workingHours + 15%
        }
        public Manager(string f, string l, string p, BankAccount b, string pn, string a) : base(f, l, p, b, pn, a)
        {
            employees = new List<Employee>();
            myId = id++;
        }
    }
}
