// This file was generated by a tool; you should avoid making direct changes.
// Consider using 'partial classes' to extend these types
// Input: map_speed_bump.proto

#pragma warning disable 0612, 1591, 3021
namespace apollo.hdmap
{

    [global::ProtoBuf.ProtoContract()]
    public partial class SpeedBump : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public SpeedBump()
        {
            overlap_id = new global::System.Collections.Generic.List<Id>();
            position = new global::System.Collections.Generic.List<Curve>();
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        public Id id { get; set; }

        [global::ProtoBuf.ProtoMember(2)]
        public global::System.Collections.Generic.List<Id> overlap_id { get; private set; }

        [global::ProtoBuf.ProtoMember(3)]
        public global::System.Collections.Generic.List<Curve> position { get; private set; }

    }

}

#pragma warning restore 0612, 1591, 3021
