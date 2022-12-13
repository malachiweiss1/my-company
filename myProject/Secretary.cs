namespace myProject
{
    class Secretary : Employee
    {
        public override double getSalary()
        {
            return workingHours() * 13.02;
        }
        public void editAddressToEmployee(Employee e, string a)
        {
            Console.WriteLine(getName() + " changed " + e.getName() + " address , from " + e.Address + " to " + a);
            e.Address = a;
        }
        public void editPhoneNumberToEmployee(Employee e, string p)
        {
            Console.WriteLine(getName() + " changed " + e.getName() + " phone number , from " + e.PhoneNumber + " to " + p);
            e.PhoneNumber = p;
        }
        public Secretary(string f, string l, string p, BankAccount b, string pn, string a) : base(f, l, p, b, pn, a)
        {
        }
    }
}
