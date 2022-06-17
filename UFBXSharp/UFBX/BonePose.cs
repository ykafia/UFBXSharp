namespace UFBX.Interop
{
    public unsafe partial struct BonePose
    {
        [NativeTypeName("ufbx_node *")]
        public Node* bone_node;

        public ufbx_matrix bone_to_world;
    }
}
