namespace UFBX.Interop
{
    public unsafe partial struct Error
    {
        [NativeTypeName("ufbx_error_type")]
        public ErrorType type;

        [NativeTypeName("const char *")]
        public sbyte* description;

        [NativeTypeName("uint32_t")]
        public uint stack_size;

        [NativeTypeName("ufbx_error_frame[8]")]
        public _stack_e__FixedBuffer stack;

        public partial struct _stack_e__FixedBuffer
        {
            public ErrorFrame e0;
            public ErrorFrame e1;
            public ErrorFrame e2;
            public ErrorFrame e3;
            public ErrorFrame e4;
            public ErrorFrame e5;
            public ErrorFrame e6;
            public ErrorFrame e7;

            public unsafe ref ErrorFrame this[int index]
            {
                get
                {
                    fixed (ErrorFrame* pThis = &e0)
                    {
                        return ref pThis[index];
                    }
                }
            }
        }
    }
}
