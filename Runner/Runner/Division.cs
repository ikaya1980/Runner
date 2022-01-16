namespace Runner
{
    public class Division
    {
        public int IsXDivisibleByY(int x, int y)
        {
            int mod = x % y;

            int a = 0;

            //We will check all bits are 0. 

            //Int has 32 bit. 
            for (int i = 0; i < 32; i++)
            {
                //mod & 1 returns the last bit. a won't be 1 unless last bit equals 1.
                a = a | (mod & 1);
                mod = mod >> 1;//right shift, moves the bits against the right side by 1 step
            }

            return a ^ 1; //Exclusive OR :  1^ 1 = 0, 0 ^ 1 = 1 So if all bits are 0 return 1. 
        }
    }
}
