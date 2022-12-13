namespace myProject
{
    class Company
    {
        private Manager root;
        private bool isManager(Employee node)
        {
            //return if specific employee is manager
            return node.GetType() == typeof(Manager);
        }
        private bool isManagerAssistant(Employee node)
        {
            //return if specific employee is manager assistant
            return node.GetType() == typeof(ManagerAssistant);
        }
        public void printAllEmployees()
        {
            Console.WriteLine("The all company :");
            printAllEmployees(root , 1);
        }
        public void printAllEmployees(Employee node, int n)
        {
            //printing the list of employees recursively
            if (root != null)
            {
                Console.WriteLine(node.getName() + " (" + node.Position + ")");
                if(isManager(node))
                {
                    Manager temp = (Manager)node;
                    foreach (Employee e in temp.Employees)
                    {
                        for (int i = 0; i < n; i++)
                            Console.Write('\t');
                        printAllEmployees(e,n+1);
                    }
                }
            }
        }
        public bool isEmployeeInCompany(Employee e)
        {
            return isEmployeeInCompany(e, root);
        }
        private bool isEmployeeInCompany(Employee e, Employee node)
        {
            //searching for the employee within the company recursively
            bool flag;
            if (isManager(node))
            {
                Manager temp = (Manager)node;
                foreach(Employee e2 in temp.Employees)
                {
                    flag = isEmployeeInCompany(e, e2);
                    if(flag)
                        return true;
                }
            }
            return e == node;
        }
        public void addEmployeeToManager(Employee e, Manager m)
        {
            if(isEmployeeInCompany(m, root))
                m.addEmployee(e);
        }
        public void printAllReports()
        {
            Console.WriteLine("Reports List :");
            printAllReports(root);
        }
        private void printAllReports(Employee node)
        {
            //print all reports recursively
            if (isManager(node))
            {
                Manager temp = (Manager)node;
                temp.printReports();
                foreach (Employee e in temp.Employees)
                    printAllReports(e);
            }
        }
        public void printAllTasks()
        {
            Console.WriteLine("Tasks List :");
            printAllTasks(root);
        }
        private void printAllTasks(Employee e)
        {
            //print all tasks recursively
            if (isManager(e))
            {
                Manager temp = (Manager)e;
                foreach (Employee t in temp.Employees)
                    printAllTasks(t);
            }
            e.printTasks();
        }
        public void sendTaskFromManagerToEmployee(Manager m, Employee e, Task t)
        {
            //check if m is e's manager or m is managerAssistant of e's manager
            if ((getManager(e) == m || (isManagerAssistant(m) && getManager(e) == getManager(m))) && isEmployeeInCompany(m,root) && isEmployeeInCompany(e,root))
                m.sendTaskToEmployee(e, t);
        }
        public Manager getManager(Employee e)
        {
            if(isEmployeeInCompany(e,root))
                return getManager(e, root);
            return null;
        }
        private Manager getManager(Employee e, Employee node)
        {
            //find e's manager recursively
            if (isManager(node))
            {
                Manager m = (Manager)node;
                foreach (Employee e2 in m.Employees)
                    if (e == e2)
                        return m;
                foreach (Employee e2 in m.Employees)
                {
                    Manager temp = getManager(e, e2);
                    if (temp != null)
                        return temp;
                }
            }
            return null;
        }
        public void sendReport(Employee e, Report r)
        {
            if(isEmployeeInCompany(e,root))
                e.sendReport(r);
        }
        public void editAddressToEmployee(Secretary s, Employee e, string address)
        {
            if (isEmployeeInCompany(e, root) && (isEmployeeInCompany(s, root)))
                s.editAddressToEmployee(e, address);
        }
        public void editPhoneNumberToEmployee(Secretary s, Employee e, string phoneNumber)
        {
            if (isEmployeeInCompany(e, root) && (isEmployeeInCompany(s, root)))
                s.editPhoneNumberToEmployee(e, phoneNumber);
        }
        public void calculateAllSalaries()
        {
            Console.WriteLine("All salaries :");
            calculateAllSalaries(root);
        }
        private void calculateAllSalaries(Employee e)
        {
            //print all salaries recursively
            const int width = 20;
            if(isManager(e))
            {
                Manager m = (Manager)e;
                foreach(Employee e2 in m.Employees)
                    calculateAllSalaries(e2);
            }
            int x = width - e.getName().Length;
            int y = width - e.Position.Length;
            Console.Write(e.getName());
            for (int i = 0; i < x; i++)
                Console.Write(" ");
            Console.Write(e.Position);
            for (int i = 0; i < y; i++)
                Console.Write(" ");
            Console.WriteLine(e.getSalary());
        }
        public void finishTask(Employee e, int index)
        {
            if (isEmployeeInCompany(e, root) && index < e.tasksCount())
                e.finishTask(index);
        }
        public Company(Manager firstManager, double bossSalary)
        {
            root = firstManager;
            root.BossSalary = bossSalary;
        }
    }
}
