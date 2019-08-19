// This file was generated by a tool; you should avoid making direct changes.
// Consider using 'partial classes' to extend these types
// Input: roi_boundary_filter_config.proto

#pragma warning disable 0612, 1591, 3021
namespace apollo.perception.lidar
{

    [global::ProtoBuf.ProtoContract()]
    public partial class ROIBoundaryFilterConfig : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public ROIBoundaryFilterConfig()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue(1)]
        public double distance_to_boundary_threshold
        {
            get { return __pbn__distance_to_boundary_threshold ?? 1; }
            set { __pbn__distance_to_boundary_threshold = value; }
        }
        public bool ShouldSerializedistance_to_boundary_threshold()
        {
            return __pbn__distance_to_boundary_threshold != null;
        }
        public void Resetdistance_to_boundary_threshold()
        {
            __pbn__distance_to_boundary_threshold = null;
        }
        private double? __pbn__distance_to_boundary_threshold;

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue(0.5f)]
        public float confidence_threshold
        {
            get { return __pbn__confidence_threshold ?? 0.5f; }
            set { __pbn__confidence_threshold = value; }
        }
        public bool ShouldSerializeconfidence_threshold()
        {
            return __pbn__confidence_threshold != null;
        }
        public void Resetconfidence_threshold()
        {
            __pbn__confidence_threshold = null;
        }
        private float? __pbn__confidence_threshold;

        [global::ProtoBuf.ProtoMember(3)]
        [global::System.ComponentModel.DefaultValue(0.6f)]
        public float cross_roi_threshold
        {
            get { return __pbn__cross_roi_threshold ?? 0.6f; }
            set { __pbn__cross_roi_threshold = value; }
        }
        public bool ShouldSerializecross_roi_threshold()
        {
            return __pbn__cross_roi_threshold != null;
        }
        public void Resetcross_roi_threshold()
        {
            __pbn__cross_roi_threshold = null;
        }
        private float? __pbn__cross_roi_threshold;

        [global::ProtoBuf.ProtoMember(4)]
        [global::System.ComponentModel.DefaultValue(1)]
        public double inside_threshold
        {
            get { return __pbn__inside_threshold ?? 1; }
            set { __pbn__inside_threshold = value; }
        }
        public bool ShouldSerializeinside_threshold()
        {
            return __pbn__inside_threshold != null;
        }
        public void Resetinside_threshold()
        {
            __pbn__inside_threshold = null;
        }
        private double? __pbn__inside_threshold;

    }

}

#pragma warning restore 0612, 1591, 3021
