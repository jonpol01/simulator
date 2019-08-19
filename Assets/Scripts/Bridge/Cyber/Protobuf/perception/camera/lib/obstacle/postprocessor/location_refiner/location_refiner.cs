// This file was generated by a tool; you should avoid making direct changes.
// Consider using 'partial classes' to extend these types
// Input: location_refiner.proto

#pragma warning disable 0612, 1591, 3021
namespace apollo.perception.camera.location_refiner
{

    [global::ProtoBuf.ProtoContract()]
    public partial class LocationRefinerParam : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public LocationRefinerParam()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue(30f)]
        public float min_dist_to_camera
        {
            get { return __pbn__min_dist_to_camera ?? 30f; }
            set { __pbn__min_dist_to_camera = value; }
        }
        public bool ShouldSerializemin_dist_to_camera()
        {
            return __pbn__min_dist_to_camera != null;
        }
        public void Resetmin_dist_to_camera()
        {
            __pbn__min_dist_to_camera = null;
        }
        private float? __pbn__min_dist_to_camera;

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue(0.5f)]
        public float roi_h2bottom_scale
        {
            get { return __pbn__roi_h2bottom_scale ?? 0.5f; }
            set { __pbn__roi_h2bottom_scale = value; }
        }
        public bool ShouldSerializeroi_h2bottom_scale()
        {
            return __pbn__roi_h2bottom_scale != null;
        }
        public void Resetroi_h2bottom_scale()
        {
            __pbn__roi_h2bottom_scale = null;
        }
        private float? __pbn__roi_h2bottom_scale;

    }

}

#pragma warning restore 0612, 1591, 3021
