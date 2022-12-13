
namespace myProject
{
    class Employee 
    {
        private List<Task> tasks;
        public List<Task> Tasks
        {
            set { tasks = value; }
        }
        private List<Report> reports;
        public List<Report> Reports
        {
            get { return reports; }
        }
        private string firstName;
        private string lastName;
        private string position;
        public string Position
        {
            get { return position; }
        }
        private BankAccount bankAccount;
        private string phoneNumber;
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }
        private string address;
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public int tasksCount()
        {
            return tasks.Count;
        }
        public void finishTask(int index)
        {
            tasks[index].IsDone = true;
        }
        public string getName()
        {
            return firstName + " " + lastName;
        }
        public override string ToString()
        {
            return getName() + ", " + position + ", (" + bankAccount.ToString() + "), " + phoneNumber + ", " + address;
        }
        public int finishedTasks()
        {
            int numOfFinishedTasks = 0;
            foreach (Task task in tasks)
                if (task.IsDone)
                    numOfFinishedTasks++;
            return numOfFinishedTasks;
        }
        public double workingHours()
        {
            double hours = 0;
            foreach (Report report in reports)
                hours += report.WorkingHours[1].TotalHours - report.WorkingHours[0].TotalHours;
            return hours;
        }
        public virtual double getSalary()
        {
            int numOfFinishedTasks = 0;
            foreach(Task task in tasks)
                if(task.IsDone)
                    numOfFinishedTasks++;
            return workingHours() * 10 + finishedTasks()* 5;// 10*workingHours + 5* finishedTasks
        }
        public void addTask(Task t)
        {
            tasks.Add(t);
        }
        public void sendReport(Report r)
        {
            reports.Add(r);
        }
        public void printTasks()
        {
            if (tasks.Count > 0)
            {
                Console.WriteLine(getName() + ":");
                foreach (Task t in tasks)
                    Console.WriteLine(t.ToString());
            }
        }
        public Employee(string f, string l, string p, myProject.BankAccount b, string pn, string a)
        {
            firstName = f;
            lastName = l;
            position = p;
            bankAccount = b;
            phoneNumber = pn;
            address = a;
            tasks = new List<Task>();
            reports = new List<Report>();
        }
    }
}