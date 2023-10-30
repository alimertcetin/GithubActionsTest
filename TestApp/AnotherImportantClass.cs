namespace TestApp
{
    /// <summary>
    /// Another class that does some important stuff
    /// </summary>
    public class AnotherImportantClass : IDisposable, IEquatable<AnotherImportantClass>
    {
        /// <summary>
        /// This is a field
        /// </summary>
        public int val1;
        /// <summary>
        /// This is a get only property
        /// </summary>
        public int valProp1 { get; }
        /// <summary>
        /// This is an auto property
        /// </summary>
        public int valProp2 { get; set; }

        /// <summary>
        /// Stores "Value"
        /// </summary>
        public string sVal => "Value";

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public bool Equals(AnotherImportantClass? other)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}