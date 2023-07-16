class RunningActivity : Activity
    {
        private double _distance;
        private int _duration;

        public RunningActivity(string date, int actDuration, double runDistance)
            : base(date, actDuration)
        {
            _distance = runDistance;
            _duration = actDuration;
        }

        public override double GetDistance()
        {
            return _distance;
        }

        public override double GetSpeed()
        {
            return _distance / _duration * 60;
        }

        public override double GetPace()
        {
            return _duration / _distance;
        }
    } 