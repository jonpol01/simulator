// This file was generated by a tool; you should avoid making direct changes.
// Consider using 'partial classes' to extend these types
// Input: ncut_config.proto

#pragma warning disable 0612, 1591, 3021
namespace apollo.perception.lidar
{

    [global::ProtoBuf.ProtoContract()]
    public partial class NCutConfig : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public NCutConfig()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue(@"./data/models/ncut/param.conf")]
        public string param_file
        {
            get { return __pbn__param_file ?? @"./data/models/ncut/param.conf"; }
            set { __pbn__param_file = value; }
        }
        public bool ShouldSerializeparam_file()
        {
            return __pbn__param_file != null;
        }
        public void Resetparam_file()
        {
            __pbn__param_file = null;
        }
        private string __pbn__param_file;

    }

}

#pragma warning restore 0612, 1591, 3021
