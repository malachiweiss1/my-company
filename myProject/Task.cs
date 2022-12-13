namespace myProject
{
    class Task
    {
        private string text;
        public string Text
        {
            set { text = value; }
            get { return text; }
        }
        private DateTime assignDate;
        private DateTime dueDate;
        private bool isDone;
        public bool IsDone
        {
            get { return isDone; }
            set { isDone = value; }
        }
        public override string ToString()
        {
            return "\t" + text + ".\n \t assign date : " + assignDate.ToString() + ". \n \t due date    : " + dueDate.ToString() + ".";
        }
        public Task(string t, DateTime ad, DateTime dd)
        {
            text = t;
            assignDate = ad;
            dueDate = dd;
            isDone = false;
        }
    }
}