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

namespace Javax.Imageio.Plugins.Tiff
{
    #region TIFFTag declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/TIFFTag.html"/>
    /// </summary>
    public partial class TIFFTag : MASES.JCOBridge.C2JBridge.JVMBridgeBase<TIFFTag>
    {
        const string _bridgeClassName = "javax.imageio.plugins.tiff.TIFFTag";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public TIFFTag() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public TIFFTag(params object[] args) : base(args) { }

        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
        /// </summary>
        public override bool IsBridgeCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
        /// </summary>
        public override bool IsBridgeInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region TIFFTag implementation
    public partial class TIFFTag
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/TIFFTag.html#%3Cinit%3E(java.lang.String,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public TIFFTag(Java.Lang.String arg0, int arg1, int arg2, int arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/TIFFTag.html#%3Cinit%3E(java.lang.String,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public TIFFTag(Java.Lang.String arg0, int arg1, int arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/TIFFTag.html#%3Cinit%3E(java.lang.String,int,javax.imageio.plugins.tiff.TIFFTagSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Javax.Imageio.Plugins.Tiff.TIFFTagSet"/></param>
        public TIFFTag(Java.Lang.String arg0, int arg1, Javax.Imageio.Plugins.Tiff.TIFFTagSet arg2)
            : base(arg0, arg1, arg2)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/TIFFTag.html#MAX_DATATYPE"/>
        /// </summary>
        public static int MAX_DATATYPE { get { if (!_MAX_DATATYPEReady) { _MAX_DATATYPEContent = SGetField<int>(LocalBridgeClazz, "MAX_DATATYPE"); _MAX_DATATYPEReady = true; } return _MAX_DATATYPEContent; } }
        private static int _MAX_DATATYPEContent = default;
        private static bool _MAX_DATATYPEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/TIFFTag.html#MIN_DATATYPE"/>
        /// </summary>
        public static int MIN_DATATYPE { get { if (!_MIN_DATATYPEReady) { _MIN_DATATYPEContent = SGetField<int>(LocalBridgeClazz, "MIN_DATATYPE"); _MIN_DATATYPEReady = true; } return _MIN_DATATYPEContent; } }
        private static int _MIN_DATATYPEContent = default;
        private static bool _MIN_DATATYPEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/TIFFTag.html#TIFF_ASCII"/>
        /// </summary>
        public static int TIFF_ASCII { get { if (!_TIFF_ASCIIReady) { _TIFF_ASCIIContent = SGetField<int>(LocalBridgeClazz, "TIFF_ASCII"); _TIFF_ASCIIReady = true; } return _TIFF_ASCIIContent; } }
        private static int _TIFF_ASCIIContent = default;
        private static bool _TIFF_ASCIIReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/TIFFTag.html#TIFF_BYTE"/>
        /// </summary>
        public static int TIFF_BYTE { get { if (!_TIFF_BYTEReady) { _TIFF_BYTEContent = SGetField<int>(LocalBridgeClazz, "TIFF_BYTE"); _TIFF_BYTEReady = true; } return _TIFF_BYTEContent; } }
        private static int _TIFF_BYTEContent = default;
        private static bool _TIFF_BYTEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/TIFFTag.html#TIFF_DOUBLE"/>
        /// </summary>
        public static int TIFF_DOUBLE { get { if (!_TIFF_DOUBLEReady) { _TIFF_DOUBLEContent = SGetField<int>(LocalBridgeClazz, "TIFF_DOUBLE"); _TIFF_DOUBLEReady = true; } return _TIFF_DOUBLEContent; } }
        private static int _TIFF_DOUBLEContent = default;
        private static bool _TIFF_DOUBLEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/TIFFTag.html#TIFF_FLOAT"/>
        /// </summary>
        public static int TIFF_FLOAT { get { if (!_TIFF_FLOATReady) { _TIFF_FLOATContent = SGetField<int>(LocalBridgeClazz, "TIFF_FLOAT"); _TIFF_FLOATReady = true; } return _TIFF_FLOATContent; } }
        private static int _TIFF_FLOATContent = default;
        private static bool _TIFF_FLOATReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/TIFFTag.html#TIFF_IFD_POINTER"/>
        /// </summary>
        public static int TIFF_IFD_POINTER { get { if (!_TIFF_IFD_POINTERReady) { _TIFF_IFD_POINTERContent = SGetField<int>(LocalBridgeClazz, "TIFF_IFD_POINTER"); _TIFF_IFD_POINTERReady = true; } return _TIFF_IFD_POINTERContent; } }
        private static int _TIFF_IFD_POINTERContent = default;
        private static bool _TIFF_IFD_POINTERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/TIFFTag.html#TIFF_LONG"/>
        /// </summary>
        public static int TIFF_LONG { get { if (!_TIFF_LONGReady) { _TIFF_LONGContent = SGetField<int>(LocalBridgeClazz, "TIFF_LONG"); _TIFF_LONGReady = true; } return _TIFF_LONGContent; } }
        private static int _TIFF_LONGContent = default;
        private static bool _TIFF_LONGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/TIFFTag.html#TIFF_RATIONAL"/>
        /// </summary>
        public static int TIFF_RATIONAL { get { if (!_TIFF_RATIONALReady) { _TIFF_RATIONALContent = SGetField<int>(LocalBridgeClazz, "TIFF_RATIONAL"); _TIFF_RATIONALReady = true; } return _TIFF_RATIONALContent; } }
        private static int _TIFF_RATIONALContent = default;
        private static bool _TIFF_RATIONALReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/TIFFTag.html#TIFF_SBYTE"/>
        /// </summary>
        public static int TIFF_SBYTE { get { if (!_TIFF_SBYTEReady) { _TIFF_SBYTEContent = SGetField<int>(LocalBridgeClazz, "TIFF_SBYTE"); _TIFF_SBYTEReady = true; } return _TIFF_SBYTEContent; } }
        private static int _TIFF_SBYTEContent = default;
        private static bool _TIFF_SBYTEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/TIFFTag.html#TIFF_SHORT"/>
        /// </summary>
        public static int TIFF_SHORT { get { if (!_TIFF_SHORTReady) { _TIFF_SHORTContent = SGetField<int>(LocalBridgeClazz, "TIFF_SHORT"); _TIFF_SHORTReady = true; } return _TIFF_SHORTContent; } }
        private static int _TIFF_SHORTContent = default;
        private static bool _TIFF_SHORTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/TIFFTag.html#TIFF_SLONG"/>
        /// </summary>
        public static int TIFF_SLONG { get { if (!_TIFF_SLONGReady) { _TIFF_SLONGContent = SGetField<int>(LocalBridgeClazz, "TIFF_SLONG"); _TIFF_SLONGReady = true; } return _TIFF_SLONGContent; } }
        private static int _TIFF_SLONGContent = default;
        private static bool _TIFF_SLONGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/TIFFTag.html#TIFF_SRATIONAL"/>
        /// </summary>
        public static int TIFF_SRATIONAL { get { if (!_TIFF_SRATIONALReady) { _TIFF_SRATIONALContent = SGetField<int>(LocalBridgeClazz, "TIFF_SRATIONAL"); _TIFF_SRATIONALReady = true; } return _TIFF_SRATIONALContent; } }
        private static int _TIFF_SRATIONALContent = default;
        private static bool _TIFF_SRATIONALReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/TIFFTag.html#TIFF_SSHORT"/>
        /// </summary>
        public static int TIFF_SSHORT { get { if (!_TIFF_SSHORTReady) { _TIFF_SSHORTContent = SGetField<int>(LocalBridgeClazz, "TIFF_SSHORT"); _TIFF_SSHORTReady = true; } return _TIFF_SSHORTContent; } }
        private static int _TIFF_SSHORTContent = default;
        private static bool _TIFF_SSHORTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/TIFFTag.html#TIFF_UNDEFINED"/>
        /// </summary>
        public static int TIFF_UNDEFINED { get { if (!_TIFF_UNDEFINEDReady) { _TIFF_UNDEFINEDContent = SGetField<int>(LocalBridgeClazz, "TIFF_UNDEFINED"); _TIFF_UNDEFINEDReady = true; } return _TIFF_UNDEFINEDContent; } }
        private static int _TIFF_UNDEFINEDContent = default;
        private static bool _TIFF_UNDEFINEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/TIFFTag.html#UNKNOWN_TAG_NAME"/>
        /// </summary>
        public static Java.Lang.String UNKNOWN_TAG_NAME { get { if (!_UNKNOWN_TAG_NAMEReady) { _UNKNOWN_TAG_NAMEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "UNKNOWN_TAG_NAME"); _UNKNOWN_TAG_NAMEReady = true; } return _UNKNOWN_TAG_NAMEContent; } }
        private static Java.Lang.String _UNKNOWN_TAG_NAMEContent = default;
        private static bool _UNKNOWN_TAG_NAMEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/TIFFTag.html#getSizeOfType(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public static int GetSizeOfType(int arg0)
        {
            return SExecute<int>(LocalBridgeClazz, "getSizeOfType", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/TIFFTag.html#getCount()"/> 
        /// </summary>
        public int Count
        {
            get { return IExecute<int>("getCount"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/TIFFTag.html#getDataTypes()"/> 
        /// </summary>
        public int DataTypes
        {
            get { return IExecute<int>("getDataTypes"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/TIFFTag.html#getName()"/> 
        /// </summary>
        public Java.Lang.String Name
        {
            get { return IExecute<Java.Lang.String>("getName"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/TIFFTag.html#getNamedValues()"/> 
        /// </summary>
        public int[] NamedValues
        {
            get { return IExecuteArray<int>("getNamedValues"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/TIFFTag.html#getNumber()"/> 
        /// </summary>
        public int Number
        {
            get { return IExecute<int>("getNumber"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/TIFFTag.html#getTagSet()"/> 
        /// </summary>
        public Javax.Imageio.Plugins.Tiff.TIFFTagSet TagSet
        {
            get { return IExecute<Javax.Imageio.Plugins.Tiff.TIFFTagSet>("getTagSet"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/TIFFTag.html#hasValueNames()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasValueNames()
        {
            return IExecute<bool>("hasValueNames");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/TIFFTag.html#isDataTypeOK(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsDataTypeOK(int arg0)
        {
            return IExecute<bool>("isDataTypeOK", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/TIFFTag.html#isIFDPointer()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsIFDPointer()
        {
            return IExecute<bool>("isIFDPointer");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/TIFFTag.html#getValueName(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetValueName(int arg0)
        {
            return IExecute<Java.Lang.String>("getValueName", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}