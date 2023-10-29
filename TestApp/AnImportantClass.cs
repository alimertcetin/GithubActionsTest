namespace TestApp
{
    /// <summary>
    /// Class that does some important stuff
    /// </summary>
    public class AnImportantClass : SomeTestClass, IDisposable, IEquatable<AnImportantClass>
    {
        public int val1;
        public int valProp1 { get; }
        public int valProp2 { get; set; }

        public string sVal => "Value";

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public bool Equals(AnImportantClass? other)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}