using Introduction_to_Algorithms.Chapter_5;
using Xunit;

namespace Test
{
    public class Chapter5
    {
        [Theory]
        [InlineData(new[]{ 2.0, 1.0 }, 1.0, 3.0)]
        [InlineData(new[]{10, 6, 1.5, 3, 7.5, 15}, 3.0, 4375.0)]
        public void E5_2(double[] a, double x, double result)
        {
            var r = Example_5_2.PolynomialEvaluation(a, x);
            Assert.Equal(result, r);
        }

        [Theory]
        [InlineData(new[]{ 2, 0, 0, 4, 4, 3, 5 }, 7, new[]{0, 2, 4})]
        public void E5_4(int[] f, int n, int[] result)
        {
            var r = Example_5_4.Algorithm_Mapping(f, n);
            Assert.Equal(result, r);
        }


        [Theory]
        [InlineData("11111,01000,11001,11101,01010", 2)]
        [InlineData("11111,01100,00000,11001,01110", 0)]
        [InlineData("1011,1101,0011,0001", 4)]
        [InlineData("1001,1101,0011,1001", 0)]
        public void E5_5(string know, int result)
        {
            var ds1 = know.Split(',');
            char[][] cs = new char[ds1.Length][];
            for (int i = 0; i < ds1.Length; i++)
            {
                cs[i] = ds1[i].ToCharArray();
            }

            bool[,] bs = new bool[ds1.Length, ds1.Length];
            for (int i = 0; i < ds1.Length; i++)
            {
                for (int j = 0; j < ds1.Length; j++)
                {
                    bs[i, j] = cs[i][j] == '1';
                }
            }

            var r = Example_5_5.Algorithm_Celebrity(bs);
            Assert.Equal(result, r);
        }

        [Theory]
        [InlineData(new[]{ 2, -3, 1.5, -1, 3, -2, -3, 3 }, 3.5)]
        public void E5_8(double[] x, double result)
        {
            var r = Example_5_8.Maximum_Consecutive_Subsequence(x);
            Assert.Equal(result, r);
        }
    }
}
