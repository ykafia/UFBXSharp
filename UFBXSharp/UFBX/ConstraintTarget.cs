namespace UFBX.Interop
{
    public unsafe partial struct ConstraintTarget
    {
        [NativeTypeName("ufbx_node *")]
        public Node* node;

        [NativeTypeName("ufbx_real")]
        public Real weight;

        public ufbx_transform transform;
    }
}
