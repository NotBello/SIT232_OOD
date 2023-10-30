using System;

namespace Time
{

    class MyTime
    {
        private int hour;
        private int minute;
        private int second;


        public int GetHour()
        { return hour; }

        public int GetMinute()
        {
            return minute;
        }

        public int GetSecond()
        {
            return second;
        }


        public MyTime(int hour, int minute, int second)
        {
            this.hour = hour;
            this.minute = minute;
            this.second = second;
        }

        public MyTime()
        {
            hour = 0;
            minute = 0;
            second = 0;

        }

        public void SetHour(int hour)
        {
            if (IsValidHour(hour))
                this.hour = hour;
            else
                throw new ArgumentOutOfRangeException("hour", "Hour must be between 0 and 23");
        }

        public void SetMinute(int minute)
        {
            if (IsValidMinuteOrSecond(minute))
                this.minute = minute;
            else
                throw new ArgumentOutOfRangeException("minute", "Minute must be between 0 and 59");

        }

        public void SetSecond(int second)
        {
            if (IsValidMinuteOrSecond(second))
                this.second = second;
            else
                throw new ArgumentOutOfRangeException("second", "Second must be between 0 and 59");
        }

        public void SetTime(int hour, int minute, int second)
        {
            if (IsValidHour(hour))
                this.hour = hour;
            else
                throw new ArgumentOutOfRangeException("hour", "Hour must be between 0 and 23");

            if (IsValidMinuteOrSecond(minute))
                this.minute = minute;
            else
                throw new ArgumentOutOfRangeException("minute", "Minute must be between 0 and 59");

            if (IsValidMinuteOrSecond(second))
                this.second = second;
            else
                throw new ArgumentOutOfRangeException("second", "Second must be between 0 and 59");
        }

        private bool IsValidHour(int hour)
        {
            return hour >= 0 && hour <= 23;
        }

        private bool IsValidMinuteOrSecond(int value)
        {
            return value >= 0 && value <= 59;

        }

        public string ToString()
        {
            string formattedHour = FormatValue(hour);
            string formattedMinute = FormatValue(minute);
            string formattedSecond = FormatValue(second);

            return formattedHour + ":" + formattedMinute + ":" + formattedSecond;
        }

        private string FormatValue(int value)
        {
            if (value < 10)
            {
                return "0" + value;
            }
            else
            {
                return value.ToString();
            }
        }


        public MyTime PreviousSecond()
        {
            second--;

            if (second < 0)
            {
                second = 59;
                minute--;

                if (minute < 0)
                {
                    minute = 59;
                    hour--;

                    if (hour < 0)
                    {
                        hour = 23;
                    }
                }
            }

            return this;
        } 

        public MyTime NextSecond()
        {
            second++;

            if (second >= 60)
            {
                second = 0;
                minute++;

                if (minute >= 60)
                {
                    minute = 0;
                    hour++;

                    if (hour >= 24)
                    {
                        hour = 0;
                    }
                }
            }

            return this;
        }

        public MyTime PreviousMinute()
        {
            minute--;

            if (minute < 0)
            {
                minute = 59;
                hour--;

                if (hour < 0)
                {
                    hour = 23;
                }
            }

            return this;
        }

        public MyTime NextMinute()
        {
            minute++;

            if (minute >= 60)
            {
                minute = 0;
                hour++;

                if (hour >= 24)
                {
                    hour = 0;
                }
            }

            return this;
        }

        public MyTime PreviousHour()
        {
            hour--;

            if (hour < 0)
            {
                hour = 23;
            }

            return this;
        }
        public MyTime NextHour()
        {
            hour++;

            if (hour >= 24)
            {
                hour = 0;
            }

            return this;
        }

    }

    class TestMyTime
    {
        static void Main(string[] args)
        {
            TestConstructor();
            TestGet();
            TestSet();
            TTManipulation();
            TestToStr();

            Console.WriteLine("Succesfuly completed all required tests.");
        }

        static void TestConstructor()
        {
            Console.WriteLine("Testing Constructor");

            MyTime time1 = new MyTime(12, 30, 45);
            Console.WriteLine(time1.ToString());

            MyTime time2 = new MyTime();
            Console.WriteLine(time2.ToString());
        }

        static void TestGet()
        {
            Console.WriteLine("Testing Getters");

            MyTime time = new MyTime(14, 25, 0);
            Console.WriteLine("Hr: " + time.GetHour());
            Console.WriteLine("Min: " + time.GetMinute());
            Console.WriteLine("Sec: " + time.GetSecond());
        }

        static void TestSet()
        {
            Console.WriteLine("Testing Setters");

            MyTime time = new MyTime();

            time.SetHour(8);
            time.SetMinute(45);
            time.SetSecond(30);

            Console.WriteLine(time.ToString());
        }

        static void TTManipulation()
        {
            Console.WriteLine("Manipulation time test: ");

            MyTime time = new MyTime(15, 45, 30);

            time.NextSecond();
            Console.WriteLine("Next Sec: " + time.ToString());

            time.PreviousMinute();
            Console.WriteLine("Previous Min: " + time.ToString());

            time.NextHour();
            Console.WriteLine("Next Hr: " + time.ToString());
        }

        static void TestToStr()
        {
            Console.WriteLine("ToString test");

            MyTime time = new MyTime(9, 5, 15);
            Console.WriteLine(time.ToString());
        }
    }

}