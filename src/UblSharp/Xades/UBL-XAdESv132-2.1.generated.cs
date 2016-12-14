// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Manual changes to this file will be overwritten if the code is regenerated.
//
// </auto-generated>
//------------------------------------------------------------------------------
namespace UblSharp.Xades
{
    using XmlDigitalSignature;
    
    
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("ReferenceInfoType", Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
    public partial class ReferenceInfoType
    {
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("DigestMethod", Namespace = "http://www.w3.org/2000/09/xmldsig#", Order=0)]
        public DigestMethodType @__DigestMethod;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("DigestValue", Namespace = "http://www.w3.org/2000/09/xmldsig#", DataType="base64Binary", Order=1)]
        public byte[] @__DigestValue;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlAttributeAttribute("Id", DataType="ID")]
        public string @__Id;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlAttributeAttribute("URI", DataType="anyURI")]
        public string @__URI;
        
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public DigestMethodType DigestMethod
        {
            get
            {
                if (__DigestMethod == null) { __DigestMethod = new DigestMethodType(); }
                return __DigestMethod;
            }
            set
            {
                __DigestMethod = value;
            }
        }

        
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public byte[] DigestValue
        {
            get
            {
                return __DigestValue;
            }
            set
            {
                __DigestValue = value;
            }
        }

        
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public string Id
        {
            get
            {
                return __Id;
            }
            set
            {
                __Id = value;
            }
        }

        
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public string URI
        {
            get
            {
                return __URI;
            }
            set
            {
                __URI = value;
            }
        }

    }
    
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("IncludeType", Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
    public partial class IncludeType
    {
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlAttributeAttribute("URI", DataType="anyURI")]
        public string @__URI;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlAttributeAttribute("referencedData")]
        public bool @__referencedData;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool @__referencedDataSpecified;
        
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public string URI
        {
            get
            {
                return __URI;
            }
            set
            {
                __URI = value;
            }
        }

        
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public bool referencedData
        {
            get
            {
                return __referencedData;
            }
            set
            {
                __referencedData = value;
            }
        }

        
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public bool referencedDataSpecified
        {
            get
            {
                return __referencedDataSpecified;
            }
            set
            {
                __referencedDataSpecified = value;
            }
        }

    }
    
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OtherTimeStampType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(XAdESTimeStampType))]
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("GenericTimeStampType", Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
    public abstract partial class GenericTimeStampType
    {
        
        private System.Collections.Generic.List<System.Object> _items;
        
        [System.Xml.Serialization.XmlElementAttribute("Include", typeof(IncludeType), Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("ReferenceInfo", typeof(ReferenceInfoType))]
        public object[] @__Items
        {
            get
            {
                return _items?.ToArray();
            }
            set
            {
                _items = value == null ? null : new System.Collections.Generic.List<System.Object>(value);
            }
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("CanonicalizationMethod", Namespace = "http://www.w3.org/2000/09/xmldsig#", Order=1)]
        public CanonicalizationMethodType @__CanonicalizationMethod;
        
        private System.Collections.Generic.List<System.Object> _items1;
        
        [System.Xml.Serialization.XmlElementAttribute("EncapsulatedTimeStamp", typeof(EncapsulatedPKIDataType), Order=2)]
        [System.Xml.Serialization.XmlElementAttribute("XMLTimeStamp", typeof(AnyType))]
        public object[] @__Items1
        {
            get
            {
                return _items1?.ToArray();
            }
            set
            {
                _items1 = value == null ? null : new System.Collections.Generic.List<System.Object>(value);
            }
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlAttributeAttribute("Id", DataType="ID")]
        public string @__Id;
        
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Collections.Generic.List<System.Object> Items
        {
            get { return _items ?? (_items = new System.Collections.Generic.List<System.Object>()); }
            set { _items = value; }
        }

        
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Collections.Generic.List<System.Object> Items1
        {
            get { return _items1 ?? (_items1 = new System.Collections.Generic.List<System.Object>()); }
            set { _items1 = value; }
        }

        
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public CanonicalizationMethodType CanonicalizationMethod
        {
            get
            {
                if (__CanonicalizationMethod == null) { __CanonicalizationMethod = new CanonicalizationMethodType(); }
                return __CanonicalizationMethod;
            }
            set
            {
                __CanonicalizationMethod = value;
            }
        }

        
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public string Id
        {
            get
            {
                return __Id;
            }
            set
            {
                __Id = value;
            }
        }

    }
    
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("EncapsulatedPKIDataType", Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
    public partial class EncapsulatedPKIDataType
    {
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlAttributeAttribute("Id", DataType="ID")]
        public string @__Id;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlAttributeAttribute("Encoding", DataType="anyURI")]
        public string @__Encoding;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlTextAttribute(DataType="base64Binary")]
        public byte[] @__Value;
        
        public static implicit operator EncapsulatedPKIDataType(byte[] value)
        {
             return new EncapsulatedPKIDataType { Value = value };
        }

        public static implicit operator byte[](EncapsulatedPKIDataType value)
        {
             return value.Value;
        }

        
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public string Id
        {
            get
            {
                return __Id;
            }
            set
            {
                __Id = value;
            }
        }

        
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public string Encoding
        {
            get
            {
                return __Encoding;
            }
            set
            {
                __Encoding = value;
            }
        }

        
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public byte[] Value
        {
            get
            {
                return __Value;
            }
            set
            {
                __Value = value;
            }
        }

    }
    
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("AnyType", Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
    public partial class AnyType
    {
        
#if FEATURE_XMLDOCUMENT
        private System.Collections.Generic.List<System.Xml.XmlNode> _any;
#elif !FEATURE_XMLDOCUMENT && FEATURE_LINQ
        private System.Collections.Generic.List<System.Xml.Linq.XNode> _any;
#else
        private System.Collections.Generic.List<object> _any;
#endif
        
        [System.Xml.Serialization.XmlTextAttribute()]
        [System.Xml.Serialization.XmlAnyElementAttribute(Order=0)]
#if FEATURE_XMLDOCUMENT
        public System.Xml.XmlNode[] @__Any
#elif !FEATURE_XMLDOCUMENT && FEATURE_LINQ
        public System.Xml.Linq.XNode[] @__Any
#else
        public object[] @__Any
#endif
        {
            get
            {
                return _any?.ToArray();
            }
            set
            {
#if FEATURE_XMLDOCUMENT
                _any = value == null ? null : new System.Collections.Generic.List<System.Xml.XmlNode>(value);
#elif !FEATURE_XMLDOCUMENT && FEATURE_LINQ
                _any = value == null ? null : new System.Collections.Generic.List<System.Xml.Linq.XNode>(value);
#else
                _any = value == null ? null : new System.Collections.Generic.List<object>(value);
#endif
            }
        }
        
#if FEATURE_XMLDOCUMENT
        private System.Collections.Generic.List<System.Xml.XmlAttribute> _anyAttr;
#elif !FEATURE_XMLDOCUMENT && FEATURE_LINQ
        private System.Collections.Generic.List<System.Xml.Linq.XAttribute> _anyAttr;
#else
        private System.Collections.Generic.List<object> _anyAttr;
#endif
        
        [System.Xml.Serialization.XmlAnyAttributeAttribute()]
#if FEATURE_XMLDOCUMENT
        public System.Xml.XmlAttribute[] @__AnyAttr
#elif !FEATURE_XMLDOCUMENT && FEATURE_LINQ
        public System.Xml.Linq.XAttribute[] @__AnyAttr
#else
        public object[] @__AnyAttr
#endif
        {
            get
            {
                return _anyAttr?.ToArray();
            }
            set
            {
#if FEATURE_XMLDOCUMENT
                _anyAttr = value == null ? null : new System.Collections.Generic.List<System.Xml.XmlAttribute>(value);
#elif !FEATURE_XMLDOCUMENT && FEATURE_LINQ
                _anyAttr = value == null ? null : new System.Collections.Generic.List<System.Xml.Linq.XAttribute>(value);
#else
                _anyAttr = value == null ? null : new System.Collections.Generic.List<object>(value);
#endif
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute]
#if FEATURE_XMLDOCUMENT
        public System.Collections.Generic.List<System.Xml.XmlNode> Any
#elif !FEATURE_XMLDOCUMENT && FEATURE_LINQ
        public System.Collections.Generic.List<System.Xml.Linq.XNode> Any
#else
        public System.Collections.Generic.List<object> Any
#endif
        {
#if FEATURE_XMLDOCUMENT
            get { return _any ?? (_any = new System.Collections.Generic.List<System.Xml.XmlNode>()); }
#elif !FEATURE_XMLDOCUMENT && FEATURE_LINQ
            get { return _any ?? (_any = new System.Collections.Generic.List<System.Xml.Linq.XNode>()); }
#else
            get { return _any ?? (_any = new System.Collections.Generic.List<object>()); }
#endif
            set { _any = value; }
        }

        
        [System.Xml.Serialization.XmlIgnoreAttribute]
#if FEATURE_XMLDOCUMENT
        public System.Collections.Generic.List<System.Xml.XmlAttribute> AnyAttr
#elif !FEATURE_XMLDOCUMENT && FEATURE_LINQ
        public System.Collections.Generic.List<System.Xml.Linq.XAttribute> AnyAttr
#else
        public System.Collections.Generic.List<object> AnyAttr
#endif
        {
#if FEATURE_XMLDOCUMENT
            get { return _anyAttr ?? (_anyAttr = new System.Collections.Generic.List<System.Xml.XmlAttribute>()); }
#elif !FEATURE_XMLDOCUMENT && FEATURE_LINQ
            get { return _anyAttr ?? (_anyAttr = new System.Collections.Generic.List<System.Xml.Linq.XAttribute>()); }
#else
            get { return _anyAttr ?? (_anyAttr = new System.Collections.Generic.List<object>()); }
#endif
            set { _anyAttr = value; }
        }

    }
    
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("OtherTimeStampType", Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
    public partial class OtherTimeStampType : GenericTimeStampType
    {
    }
    
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("RevocationValuesType", Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
    public partial class RevocationValuesType
    {
        
        private System.Collections.Generic.List<EncapsulatedPKIDataType> _cRLValues;
        
        [System.Xml.Serialization.XmlArrayItemAttribute("EncapsulatedCRLValue", IsNullable=false)]
        public EncapsulatedPKIDataType[] @__CRLValues
        {
            get
            {
                return _cRLValues?.ToArray();
            }
            set
            {
                _cRLValues = value == null ? null : new System.Collections.Generic.List<EncapsulatedPKIDataType>(value);
            }
        }
        
        private System.Collections.Generic.List<EncapsulatedPKIDataType> _oCSPValues;
        
        [System.Xml.Serialization.XmlArrayItemAttribute("EncapsulatedOCSPValue", IsNullable=false)]
        public EncapsulatedPKIDataType[] @__OCSPValues
        {
            get
            {
                return _oCSPValues?.ToArray();
            }
            set
            {
                _oCSPValues = value == null ? null : new System.Collections.Generic.List<EncapsulatedPKIDataType>(value);
            }
        }
        
        private System.Collections.Generic.List<AnyType> _otherValues;
        
        [System.Xml.Serialization.XmlArrayItemAttribute("OtherValue", IsNullable=false)]
        public AnyType[] @__OtherValues
        {
            get
            {
                return _otherValues?.ToArray();
            }
            set
            {
                _otherValues = value == null ? null : new System.Collections.Generic.List<AnyType>(value);
            }
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlAttributeAttribute("Id", DataType="ID")]
        public string @__Id;
        
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Collections.Generic.List<EncapsulatedPKIDataType> CRLValues
        {
            get { return _cRLValues ?? (_cRLValues = new System.Collections.Generic.List<EncapsulatedPKIDataType>()); }
            set { _cRLValues = value; }
        }

        
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Collections.Generic.List<EncapsulatedPKIDataType> OCSPValues
        {
            get { return _oCSPValues ?? (_oCSPValues = new System.Collections.Generic.List<EncapsulatedPKIDataType>()); }
            set { _oCSPValues = value; }
        }

        
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Collections.Generic.List<AnyType> OtherValues
        {
            get { return _otherValues ?? (_otherValues = new System.Collections.Generic.List<AnyType>()); }
            set { _otherValues = value; }
        }

        
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public string Id
        {
            get
            {
                return __Id;
            }
            set
            {
                __Id = value;
            }
        }

    }
    
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("CertificateValuesType", Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
    public partial class CertificateValuesType
    {
        
        private System.Collections.Generic.List<System.Object> _items;
        
        [System.Xml.Serialization.XmlElementAttribute("EncapsulatedX509Certificate", typeof(EncapsulatedPKIDataType), Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("OtherCertificate", typeof(AnyType))]
        public object[] @__Items
        {
            get
            {
                return _items?.ToArray();
            }
            set
            {
                _items = value == null ? null : new System.Collections.Generic.List<System.Object>(value);
            }
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlAttributeAttribute("Id", DataType="ID")]
        public string @__Id;
        
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Collections.Generic.List<System.Object> Items
        {
            get { return _items ?? (_items = new System.Collections.Generic.List<System.Object>()); }
            set { _items = value; }
        }

        
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public string Id
        {
            get
            {
                return __Id;
            }
            set
            {
                __Id = value;
            }
        }

    }
    
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("ArchiveTimeStampV2", Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
    [System.Xml.Serialization.XmlRootAttribute("ArchiveTimeStampV2", Namespace = "http://uri.etsi.org/01903/v1.4.1#", IsNullable=false)]
    public partial class XAdESTimeStampType : GenericTimeStampType
    {
    }
}
