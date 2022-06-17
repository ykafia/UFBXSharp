namespace UFBX.Interop
{
    public partial struct Application
    {
        [NativeTypeName("ufbx_string")]
        public String vendor;

        [NativeTypeName("ufbx_string")]
        public String name;

        [NativeTypeName("ufbx_string")]
        public String version;
    }
}
