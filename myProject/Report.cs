namespace myProject
{
    class Report
    {
        private string text;
        private DateTime date;
        private List<TimeSpan> workingHours;
        public List<TimeSpan> WorkingHours
        {
            get { return workingHours; }
        }
        public override string ToString()
        {
            return "\t" + text + ".\n \t \t date : " + date.ToShortDateString() + ". \n \t \t working hours : " + workingHours[0].ToString() + " - " + workingHours[1].ToString() + ".";
        }
        public Report(string t, DateTime d, TimeSpan t1, TimeSpan t2)
        {
            text = t;
            date = d;
            workingHours = new List<TimeSpan>();
            workingHours.Add(t1);
            workingHours.Add(t2);
        }
    }
}