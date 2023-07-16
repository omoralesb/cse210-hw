abstract class Activity
    {
        private string _date;
        private int _duration;

        public Activity(string curDate, int actDuration)
        {
            _date = curDate;
            _duration = actDuration;
        }

        public abstract double GetDistance();
        public abstract double GetSpeed();
        public abstract double GetPace();

        public string GetSummary()
        {
            return $"{_date:d} {GetType().Name} ({_duration} min) - Distance: {GetDistance():F1} km, Speed: {GetSpeed():F1} km/h, Pace: {GetPace():F1} min/km";
        }
    } 