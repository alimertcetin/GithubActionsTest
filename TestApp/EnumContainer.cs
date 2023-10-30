namespace TestApp
{
    /// <summary>
    /// This static class contains enums
    /// </summary>
    public static class EnumContainer
    {
        /// <summary>
        /// A static int field inside <see cref="EnumContainer"/>
        /// </summary>
        public static int aStaticIntField = 5;

        /// <summary>
        /// A static int property inside <see cref="EnumContainer"/>
        /// </summary>
        public static int aStaticIntProp { get; set; } = 5;

        /// <summary>
        /// A static string contains the name of <see cref="SomeTestClass"/>
        /// </summary>
        public static string aStaticString = nameof(SomeTestClass);

        /// <summary>
        /// Returns the sum of <see cref="aStaticIntField"/> and <see cref="aStaticIntProp"/>
        /// </summary>
        /// <seealso cref="Multiply"/>
        public static int Add()
        {
            return aStaticIntField + aStaticIntProp;
        }

        /// <summary>
        /// Multiplies <see cref="aStaticIntField"/> and <see cref="aStaticIntProp"/>
        /// </summary>
        /// <returns>The result</returns>
        public static int Multiply()
        {
            return aStaticIntField * aStaticIntProp;
        }
    
        /// <summary>
        /// A Test Enum defined inside the <see cref="EnumContainer"/>.
        /// </summary>
        [Flags]
        public enum TestEnum
        {
            /// <summary>
            /// A test member
            /// </summary>
            Member = 0,
            /// <summary>
            /// Another test member that works well with <see cref="Member"/>
            /// </summary>
            Member1 = 1,
            /// <summary>
            /// A member that combines <see cref="Member"/> and <see cref="Member1"/>
            /// </summary>
            Member2 = Member | Member1,
            /// <summary>
            /// This member combines all enum members
            /// </summary>
            Member3 = Member | Member1 | Member2,
        }
    }
}