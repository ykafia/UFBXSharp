namespace UFBX.Interop
{
    internal class NativeTypeNameAttribute : Attribute
    {
        private readonly string _name;

        /// Initializes a new instance of the  clast.
        /// The name of the type that was used in the native signature.
        public NativeTypeNameAttribute(string name)
        {
            _name = name;
        }

        /// Gets the name of the type that was used in the native signature.
        public string Name => _name;
    }
}