namespace UC7
{
    internal class ProgramBase
    {

        public static int GetworkingHour(int rand)
        {
            int empHrs = 0;
            switch (rand)
            {
                case parttime: empHrs = 4; break;
                case fulltime: empHrs = 8; break;
                default: empHrs = 0; break;
            }
        }
    }
}