using System;

namespace UFBX.Interop
{
    public unsafe partial struct CharacterList
    {
        [NativeTypeName("ufbx_character **")]
        public Character** data;

        [NativeTypeName("size_t")]
        public UIntPtr count;
    }
}
