namespace myProject
{
    class BankAccount
    {
        private string name;
        private int id;
        private string branch;
        public override string ToString()
        {
            return name + " " + id.ToString() + " " + branch.ToString();
        }
        public BankAccount(string n, int i, string b)
        {
            this.name = n;
            this.id = i;
            this.branch = b;
        }
    }
}

