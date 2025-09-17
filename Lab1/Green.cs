namespace Lab1
{
    public class Green
    {
        public bool Task1(double d)
        {
            bool answer = false;

            // code here
            double f = Math.Abs(d);
            if (f >= 1) answer = true;
            // end

            return answer;
        }
        public bool Task2(double d, double f)
        {
            bool answer = false;

            // code here
            if ((d+f)/2 > 0) answer = true;
            // end

            return answer;
        }
        public bool Task3(int a, int b)
        {
            bool answer = false;

            // code here
            if (a+b > (Math.Abs(a) +  Math.Abs(b)) / 2) answer = true;
            // end

            return answer;
        }
        public int Task4(int a, int b, int c)
        {
            int answer = 0;

            // code here
            answer = Math.Max(a, Math.Max(b, c));
            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            if (Math.Abs(x) > 1)
                answer = 0;
            else
                answer = x * x - 1;
            // end

            return answer;
        }
        public bool Task6(double x, double y)
        {
            bool answer = false;

            // code here
            if ((y <= x+1) && (y >= 0) && (y <= -x + 1)) answer = true;
            // end

            return answer;
        }

        public bool Task7(int n)
        {
            bool answer = true;

            // code here
            if (n < 0) answer = false; else if (n % 2 == 0) answer = false;
            // end

            return answer;
        }
        public bool Task8(int X, int Y)
        {
            bool answer = false;

            // code here
            int sl = 4 * 60;

            int up = 14 * 60;

            up -= X * 60;
            up = Math.Clamp(up, 7 * 60, 14 * 60);

            sl -= ((X / 2) + 1) * Y;
            int sltime = up - sl;
            System.Console.WriteLine(sltime);

            if (((sltime >= 7 * 60) && (sltime <= 9 * 60) && up == 7 * 60)) answer = true;
            // end

            return answer;
        }
    }

}

