namespace Runner
{
    public class SumOfMultiple
    {
        public int GetSumOfMultiple(int number)
        {
            int i = number / 3;
            int j = number / 5;
            int z = number / 15;

            int total3 = 3 * (i * (i + 1)) / 2;
            int total5 = 5 * (j * (j + 1)) / 2;
            int total15 = 15 * (z * (z + 1)) / 2;//multipe 3 and 5 

            return total3 + total5 - total15;

        }

    }
}
