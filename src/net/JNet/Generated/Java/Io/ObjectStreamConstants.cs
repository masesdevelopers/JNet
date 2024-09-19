/*
*  Copyright 2024 MASES s.r.l.
*
*  Licensed under the Apache License, Version 2.0 (the "License");
*  you may not use this file except in compliance with the License.
*  You may obtain a copy of the License at
*
*  http://www.apache.org/licenses/LICENSE-2.0
*
*  Unless required by applicable law or agreed to in writing, software
*  distributed under the License is distributed on an "AS IS" BASIS,
*  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
*  See the License for the specific language governing permissions and
*  limitations under the License.
*
*  Refer to LICENSE for more information.
*/

/*
*  This file is generated by MASES.JNetReflector (ver. 2.5.9.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Io
{
    #region ObjectStreamConstants declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectStreamConstants.html"/>
    /// </summary>
    public partial class ObjectStreamConstants : MASES.JCOBridge.C2JBridge.JVMBridgeBase<ObjectStreamConstants>
    {
        const string _bridgeClassName = "java.io.ObjectStreamConstants";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("ObjectStreamConstants class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public ObjectStreamConstants() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("ObjectStreamConstants class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public ObjectStreamConstants(params object[] args) : base(args) { }

        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
        /// </summary>
        public override bool IsBridgeCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
        /// </summary>
        public override bool IsBridgeInterface => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region IObjectStreamConstants
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IObjectStreamConstants
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ObjectStreamConstants implementation
    public partial class ObjectStreamConstants : Java.Io.IObjectStreamConstants
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectStreamConstants.html#SC_BLOCK_DATA"/>
        /// </summary>
        public static byte SC_BLOCK_DATA { get { if (!_SC_BLOCK_DATAReady) { _SC_BLOCK_DATAContent = SGetField<byte>(LocalBridgeClazz, "SC_BLOCK_DATA"); _SC_BLOCK_DATAReady = true; } return _SC_BLOCK_DATAContent; } }
        private static byte _SC_BLOCK_DATAContent = default;
        private static bool _SC_BLOCK_DATAReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectStreamConstants.html#SC_ENUM"/>
        /// </summary>
        public static byte SC_ENUM { get { if (!_SC_ENUMReady) { _SC_ENUMContent = SGetField<byte>(LocalBridgeClazz, "SC_ENUM"); _SC_ENUMReady = true; } return _SC_ENUMContent; } }
        private static byte _SC_ENUMContent = default;
        private static bool _SC_ENUMReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectStreamConstants.html#SC_EXTERNALIZABLE"/>
        /// </summary>
        public static byte SC_EXTERNALIZABLE { get { if (!_SC_EXTERNALIZABLEReady) { _SC_EXTERNALIZABLEContent = SGetField<byte>(LocalBridgeClazz, "SC_EXTERNALIZABLE"); _SC_EXTERNALIZABLEReady = true; } return _SC_EXTERNALIZABLEContent; } }
        private static byte _SC_EXTERNALIZABLEContent = default;
        private static bool _SC_EXTERNALIZABLEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectStreamConstants.html#SC_SERIALIZABLE"/>
        /// </summary>
        public static byte SC_SERIALIZABLE { get { if (!_SC_SERIALIZABLEReady) { _SC_SERIALIZABLEContent = SGetField<byte>(LocalBridgeClazz, "SC_SERIALIZABLE"); _SC_SERIALIZABLEReady = true; } return _SC_SERIALIZABLEContent; } }
        private static byte _SC_SERIALIZABLEContent = default;
        private static bool _SC_SERIALIZABLEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectStreamConstants.html#SC_WRITE_METHOD"/>
        /// </summary>
        public static byte SC_WRITE_METHOD { get { if (!_SC_WRITE_METHODReady) { _SC_WRITE_METHODContent = SGetField<byte>(LocalBridgeClazz, "SC_WRITE_METHOD"); _SC_WRITE_METHODReady = true; } return _SC_WRITE_METHODContent; } }
        private static byte _SC_WRITE_METHODContent = default;
        private static bool _SC_WRITE_METHODReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectStreamConstants.html#TC_ARRAY"/>
        /// </summary>
        public static byte TC_ARRAY { get { if (!_TC_ARRAYReady) { _TC_ARRAYContent = SGetField<byte>(LocalBridgeClazz, "TC_ARRAY"); _TC_ARRAYReady = true; } return _TC_ARRAYContent; } }
        private static byte _TC_ARRAYContent = default;
        private static bool _TC_ARRAYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectStreamConstants.html#TC_BASE"/>
        /// </summary>
        public static byte TC_BASE { get { if (!_TC_BASEReady) { _TC_BASEContent = SGetField<byte>(LocalBridgeClazz, "TC_BASE"); _TC_BASEReady = true; } return _TC_BASEContent; } }
        private static byte _TC_BASEContent = default;
        private static bool _TC_BASEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectStreamConstants.html#TC_BLOCKDATA"/>
        /// </summary>
        public static byte TC_BLOCKDATA { get { if (!_TC_BLOCKDATAReady) { _TC_BLOCKDATAContent = SGetField<byte>(LocalBridgeClazz, "TC_BLOCKDATA"); _TC_BLOCKDATAReady = true; } return _TC_BLOCKDATAContent; } }
        private static byte _TC_BLOCKDATAContent = default;
        private static bool _TC_BLOCKDATAReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectStreamConstants.html#TC_BLOCKDATALONG"/>
        /// </summary>
        public static byte TC_BLOCKDATALONG { get { if (!_TC_BLOCKDATALONGReady) { _TC_BLOCKDATALONGContent = SGetField<byte>(LocalBridgeClazz, "TC_BLOCKDATALONG"); _TC_BLOCKDATALONGReady = true; } return _TC_BLOCKDATALONGContent; } }
        private static byte _TC_BLOCKDATALONGContent = default;
        private static bool _TC_BLOCKDATALONGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectStreamConstants.html#TC_CLASS"/>
        /// </summary>
        public static byte TC_CLASS { get { if (!_TC_CLASSReady) { _TC_CLASSContent = SGetField<byte>(LocalBridgeClazz, "TC_CLASS"); _TC_CLASSReady = true; } return _TC_CLASSContent; } }
        private static byte _TC_CLASSContent = default;
        private static bool _TC_CLASSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectStreamConstants.html#TC_CLASSDESC"/>
        /// </summary>
        public static byte TC_CLASSDESC { get { if (!_TC_CLASSDESCReady) { _TC_CLASSDESCContent = SGetField<byte>(LocalBridgeClazz, "TC_CLASSDESC"); _TC_CLASSDESCReady = true; } return _TC_CLASSDESCContent; } }
        private static byte _TC_CLASSDESCContent = default;
        private static bool _TC_CLASSDESCReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectStreamConstants.html#TC_ENDBLOCKDATA"/>
        /// </summary>
        public static byte TC_ENDBLOCKDATA { get { if (!_TC_ENDBLOCKDATAReady) { _TC_ENDBLOCKDATAContent = SGetField<byte>(LocalBridgeClazz, "TC_ENDBLOCKDATA"); _TC_ENDBLOCKDATAReady = true; } return _TC_ENDBLOCKDATAContent; } }
        private static byte _TC_ENDBLOCKDATAContent = default;
        private static bool _TC_ENDBLOCKDATAReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectStreamConstants.html#TC_ENUM"/>
        /// </summary>
        public static byte TC_ENUM { get { if (!_TC_ENUMReady) { _TC_ENUMContent = SGetField<byte>(LocalBridgeClazz, "TC_ENUM"); _TC_ENUMReady = true; } return _TC_ENUMContent; } }
        private static byte _TC_ENUMContent = default;
        private static bool _TC_ENUMReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectStreamConstants.html#TC_EXCEPTION"/>
        /// </summary>
        public static byte TC_EXCEPTION { get { if (!_TC_EXCEPTIONReady) { _TC_EXCEPTIONContent = SGetField<byte>(LocalBridgeClazz, "TC_EXCEPTION"); _TC_EXCEPTIONReady = true; } return _TC_EXCEPTIONContent; } }
        private static byte _TC_EXCEPTIONContent = default;
        private static bool _TC_EXCEPTIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectStreamConstants.html#TC_LONGSTRING"/>
        /// </summary>
        public static byte TC_LONGSTRING { get { if (!_TC_LONGSTRINGReady) { _TC_LONGSTRINGContent = SGetField<byte>(LocalBridgeClazz, "TC_LONGSTRING"); _TC_LONGSTRINGReady = true; } return _TC_LONGSTRINGContent; } }
        private static byte _TC_LONGSTRINGContent = default;
        private static bool _TC_LONGSTRINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectStreamConstants.html#TC_MAX"/>
        /// </summary>
        public static byte TC_MAX { get { if (!_TC_MAXReady) { _TC_MAXContent = SGetField<byte>(LocalBridgeClazz, "TC_MAX"); _TC_MAXReady = true; } return _TC_MAXContent; } }
        private static byte _TC_MAXContent = default;
        private static bool _TC_MAXReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectStreamConstants.html#TC_NULL"/>
        /// </summary>
        public static byte TC_NULL { get { if (!_TC_NULLReady) { _TC_NULLContent = SGetField<byte>(LocalBridgeClazz, "TC_NULL"); _TC_NULLReady = true; } return _TC_NULLContent; } }
        private static byte _TC_NULLContent = default;
        private static bool _TC_NULLReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectStreamConstants.html#TC_OBJECT"/>
        /// </summary>
        public static byte TC_OBJECT { get { if (!_TC_OBJECTReady) { _TC_OBJECTContent = SGetField<byte>(LocalBridgeClazz, "TC_OBJECT"); _TC_OBJECTReady = true; } return _TC_OBJECTContent; } }
        private static byte _TC_OBJECTContent = default;
        private static bool _TC_OBJECTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectStreamConstants.html#TC_PROXYCLASSDESC"/>
        /// </summary>
        public static byte TC_PROXYCLASSDESC { get { if (!_TC_PROXYCLASSDESCReady) { _TC_PROXYCLASSDESCContent = SGetField<byte>(LocalBridgeClazz, "TC_PROXYCLASSDESC"); _TC_PROXYCLASSDESCReady = true; } return _TC_PROXYCLASSDESCContent; } }
        private static byte _TC_PROXYCLASSDESCContent = default;
        private static bool _TC_PROXYCLASSDESCReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectStreamConstants.html#TC_REFERENCE"/>
        /// </summary>
        public static byte TC_REFERENCE { get { if (!_TC_REFERENCEReady) { _TC_REFERENCEContent = SGetField<byte>(LocalBridgeClazz, "TC_REFERENCE"); _TC_REFERENCEReady = true; } return _TC_REFERENCEContent; } }
        private static byte _TC_REFERENCEContent = default;
        private static bool _TC_REFERENCEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectStreamConstants.html#TC_RESET"/>
        /// </summary>
        public static byte TC_RESET { get { if (!_TC_RESETReady) { _TC_RESETContent = SGetField<byte>(LocalBridgeClazz, "TC_RESET"); _TC_RESETReady = true; } return _TC_RESETContent; } }
        private static byte _TC_RESETContent = default;
        private static bool _TC_RESETReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectStreamConstants.html#TC_STRING"/>
        /// </summary>
        public static byte TC_STRING { get { if (!_TC_STRINGReady) { _TC_STRINGContent = SGetField<byte>(LocalBridgeClazz, "TC_STRING"); _TC_STRINGReady = true; } return _TC_STRINGContent; } }
        private static byte _TC_STRINGContent = default;
        private static bool _TC_STRINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectStreamConstants.html#baseWireHandle"/>
        /// </summary>
        public static int baseWireHandle { get { if (!_baseWireHandleReady) { _baseWireHandleContent = SGetField<int>(LocalBridgeClazz, "baseWireHandle"); _baseWireHandleReady = true; } return _baseWireHandleContent; } }
        private static int _baseWireHandleContent = default;
        private static bool _baseWireHandleReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectStreamConstants.html#PROTOCOL_VERSION_1"/>
        /// </summary>
        public static int PROTOCOL_VERSION_1 { get { if (!_PROTOCOL_VERSION_1Ready) { _PROTOCOL_VERSION_1Content = SGetField<int>(LocalBridgeClazz, "PROTOCOL_VERSION_1"); _PROTOCOL_VERSION_1Ready = true; } return _PROTOCOL_VERSION_1Content; } }
        private static int _PROTOCOL_VERSION_1Content = default;
        private static bool _PROTOCOL_VERSION_1Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectStreamConstants.html#PROTOCOL_VERSION_2"/>
        /// </summary>
        public static int PROTOCOL_VERSION_2 { get { if (!_PROTOCOL_VERSION_2Ready) { _PROTOCOL_VERSION_2Content = SGetField<int>(LocalBridgeClazz, "PROTOCOL_VERSION_2"); _PROTOCOL_VERSION_2Ready = true; } return _PROTOCOL_VERSION_2Content; } }
        private static int _PROTOCOL_VERSION_2Content = default;
        private static bool _PROTOCOL_VERSION_2Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectStreamConstants.html#SERIAL_FILTER_PERMISSION"/>
        /// </summary>
        public static Java.Io.SerializablePermission SERIAL_FILTER_PERMISSION { get { if (!_SERIAL_FILTER_PERMISSIONReady) { _SERIAL_FILTER_PERMISSIONContent = SGetField<Java.Io.SerializablePermission>(LocalBridgeClazz, "SERIAL_FILTER_PERMISSION"); _SERIAL_FILTER_PERMISSIONReady = true; } return _SERIAL_FILTER_PERMISSIONContent; } }
        private static Java.Io.SerializablePermission _SERIAL_FILTER_PERMISSIONContent = default;
        private static bool _SERIAL_FILTER_PERMISSIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectStreamConstants.html#SUBCLASS_IMPLEMENTATION_PERMISSION"/>
        /// </summary>
        public static Java.Io.SerializablePermission SUBCLASS_IMPLEMENTATION_PERMISSION { get { if (!_SUBCLASS_IMPLEMENTATION_PERMISSIONReady) { _SUBCLASS_IMPLEMENTATION_PERMISSIONContent = SGetField<Java.Io.SerializablePermission>(LocalBridgeClazz, "SUBCLASS_IMPLEMENTATION_PERMISSION"); _SUBCLASS_IMPLEMENTATION_PERMISSIONReady = true; } return _SUBCLASS_IMPLEMENTATION_PERMISSIONContent; } }
        private static Java.Io.SerializablePermission _SUBCLASS_IMPLEMENTATION_PERMISSIONContent = default;
        private static bool _SUBCLASS_IMPLEMENTATION_PERMISSIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectStreamConstants.html#SUBSTITUTION_PERMISSION"/>
        /// </summary>
        public static Java.Io.SerializablePermission SUBSTITUTION_PERMISSION { get { if (!_SUBSTITUTION_PERMISSIONReady) { _SUBSTITUTION_PERMISSIONContent = SGetField<Java.Io.SerializablePermission>(LocalBridgeClazz, "SUBSTITUTION_PERMISSION"); _SUBSTITUTION_PERMISSIONReady = true; } return _SUBSTITUTION_PERMISSIONContent; } }
        private static Java.Io.SerializablePermission _SUBSTITUTION_PERMISSIONContent = default;
        private static bool _SUBSTITUTION_PERMISSIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectStreamConstants.html#STREAM_MAGIC"/>
        /// </summary>
        public static short STREAM_MAGIC { get { if (!_STREAM_MAGICReady) { _STREAM_MAGICContent = SGetField<short>(LocalBridgeClazz, "STREAM_MAGIC"); _STREAM_MAGICReady = true; } return _STREAM_MAGICContent; } }
        private static short _STREAM_MAGICContent = default;
        private static bool _STREAM_MAGICReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectStreamConstants.html#STREAM_VERSION"/>
        /// </summary>
        public static short STREAM_VERSION { get { if (!_STREAM_VERSIONReady) { _STREAM_VERSIONContent = SGetField<short>(LocalBridgeClazz, "STREAM_VERSION"); _STREAM_VERSIONReady = true; } return _STREAM_VERSIONContent; } }
        private static short _STREAM_VERSIONContent = default;
        private static bool _STREAM_VERSIONReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}