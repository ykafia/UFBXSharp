namespace UFBX.Interop
{
    public unsafe partial struct Edge
    {
        [NativeTypeName("uint32_t[2]")]
        public fixed uint indices[2];
    }
}
