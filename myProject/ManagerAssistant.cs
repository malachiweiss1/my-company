namespace myProject
{
    class ManagerAssistant : Manager
    {
        public override double getSalary()
        {
            return workingHours() * 10.5;
        }
        public ManagerAssistant(string f, string l, string p,BankAccount b, string pn, string a) : base(f, l, p, b, pn, a)
        {
        }
    }
}
