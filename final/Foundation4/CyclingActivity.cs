class CyclingActivity : Activity
    {
        private double _speed;
        private int _duration;
        public CyclingActivity(string date, int actDuration, double cycSpeed)
            : base(date, actDuration)
        {
            _speed = cycSpeed;
            _duration = actDuration;
        }

        public override double GetDistance()
        {
            return _speed * _duration / 60;
        }

        public override double GetSpeed()
        {
            return _speed;
        }

        public override double GetPace()
        {
            return 60 / _speed;
        }
    } 