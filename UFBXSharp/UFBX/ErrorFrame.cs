namespace UFBX.Interop
{
    public unsafe partial struct ErrorFrame
    {
        [NativeTypeName("uint32_t")]
        public uint source_line;

        [NativeTypeName("const char *")]
        public sbyte* function;

        [NativeTypeName("const char *")]
        public sbyte* description;
    }
}
