using System;

namespace UFBX.Interop
{
    public unsafe partial struct ufbx_line_segment_list
    {
        [NativeTypeName("ufbx_line_segment *")]
        public LineSegment* data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }
}
