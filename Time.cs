using System.ComponentModel;

namespace ClassTime
{
    class Time
    {
        int second;
        int minute;
        int hour;

        public int Second
        {
            get => second;
            set { second = ((value <= 59 && value >= 0) ? value : 0); }
        }

        public int Minute
        {
            get => minute;
            set { minute = ((value <= 59 && value >= 0) ? value : 0); }
        }

        public int Hour
        {
            get => hour;
            set { hour = ((value <= 23 && value >= 0) ? value : 0); }
        }


        public Time() { } // Стандартный конструктор
        public Time(int h) : this(h, 0, 0) { } // Конструктор с одним параметром устанавливает часы.
        public Time(int h, int m) : this(h, m, 0) { } // Конструктор с двумя параметрами устанавливает часы и минуты.
        public Time(int h, int m, int s) // Конструктор с тремя параметрами устанавливает часы, минуты и секунды.
        {
            Hour = h;
            Minute = m;
            Second = s;
        }


        public float ToHour() => hour + (minute / 60.0f) + (second / 3600.0f); // перевод времени в часы

        public float ToMinute() => (hour * 60) + minute + (second / 60.0f); // перевод в минуты

        public float ToSecond() => (hour * 3600.0f) + (minute * 60) + second; // перевод в секунды

        public override string ToString() => $"[{hour}:{minute}:{second}]"; // Метод возращающий значеник класса Time в форме строки 


        public static Time operator +(Time t1, Time t2) // Сложение двух времен
        {
            Time Res = new Time();
            Res.hour = (t1.hour + t2.hour);
            Res.minute = (t1.minute + t2.minute);
            Res.second = (t1.second + t2.second);

            if (Res.second > 59)
            {
                Res.second -= 60;
                Res.minute++;
            }
            if (Res.minute > 59)
            {
                Res.minute -= 60;
                Res.hour++;
            }
            if (Res.hour > 23)
            {
                Res.hour -= 24;
            }
            return Res;
        }

        public static Time operator -(Time t1, Time t2) // Вычетание двух времен
        {
            Time Res = new Time();
            Res.hour = (t1.hour - t2.hour);
            Res.minute = (t1.minute - t2.minute);
            Res.second = (t1.second - t2.second);
           

            if (Res.second < 0)
            {
                Res.second += 60;
                Res.minute--;
            }
            if (Res.minute < 0)
            {
                Res.minute += 60;
                Res.hour--;
            }
            if (Res.hour < 0)
            {
                Res.hour += 24;
            }

            return Res;
        }


        public void Add_Hour(uint h) // Добавление часов
        {
            long Add_Hour = hour + h;

            while (Add_Hour > 23)
                Add_Hour -= 24;

            hour = (sbyte)Add_Hour;
        }

        public void Add_Minute(uint m) // Добавление минут
        {
            long Add_Minute = minute + m;
            uint h = 0;

            while (Add_Minute > 59)
            {
                Add_Minute -= 60;
                h++;
            }
            minute = (sbyte)Add_Minute;
            Add_Hour(h);
        }

        public void Add_Second(uint s) // Добавление секунд
        {
            long Add_Second = second + s;
            uint m = 0;
            while (Add_Second > 59)
            {
                Add_Second -= 60;
                m++;
            }

            second = (sbyte)Add_Second;
            Add_Minute(m);
        }


        public void Sub_Hour(uint h) // Уменьшение часов
        {
            long Sub_Hour = hour - h;
            while (Sub_Hour < 0)
                Sub_Hour += 24;

            hour = (sbyte)Sub_Hour;
        }

        public void Sub_Minute(uint m) // Уменьшение минут
        {
            long Sub_Minute = minute - m;
            uint h = 0;

            while (Sub_Minute < 0)
            {
                Sub_Minute += 60;
                h++;
            }
            minute = (sbyte)Sub_Minute;
            Sub_Hour(h);
        }

        public void Sub_Second(uint s) // Уменьшение сукунд
        {
            long Sub_Second = second - s;
            uint m = 0;

            while (Sub_Second < 0)
            {
                Sub_Second += 60;
                m++;
            }
            second = (sbyte)Sub_Second;
            Sub_Minute(m);
        }
    }
}
