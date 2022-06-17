namespace UFBX.Interop
{
    public partial struct TopoEdge
    {
        [NativeTypeName("int32_t")]
        public int index;

        [NativeTypeName("int32_t")]
        public int next;

        [NativeTypeName("int32_t")]
        public int prev;

        [NativeTypeName("int32_t")]
        public int twin;

        [NativeTypeName("int32_t")]
        public int face;

        [NativeTypeName("int32_t")]
        public int edge;

        [NativeTypeName("ufbx_topo_flags")]
        public TopoFlags flags;
    }
}
