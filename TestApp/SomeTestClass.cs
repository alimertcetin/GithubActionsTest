namespace TestApp
{
    public class SomeTestClass
    {
        public const string TEST_STRİNG = "Has some test value";

        /// <summary>
        /// Factory method to create <see cref="SomeTestClass"/>
        /// </summary>
        /// <returns>An usable <see cref="SomeTestClass"/></returns>
        public static SomeTestClass Create()
        {
            return new SomeTestClass();
        }

        /// <summary>
        /// Method that does some important things
        /// </summary>
        public static void SomeTestMethod()
        {

        }

        /// <summary>
        /// Calculate sum
        /// </summary>
        /// <param name="arr">Array that contains values</param>
        /// <returns>The sum</returns>
        public int MethodWithParams(params int[] arr)
        {
            int v = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                v += arr[i];
            }
            return v;
        }
    }
}