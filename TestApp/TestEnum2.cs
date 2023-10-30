namespace TestApp
{
    /// <summary>
    /// A Test Enum defined in its own file.
    /// </summary>
    [Flags]
    public enum TestEnum2
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