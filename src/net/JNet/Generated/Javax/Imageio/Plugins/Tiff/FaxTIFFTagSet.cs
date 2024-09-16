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
*  This file is generated by MASES.JNetReflector (ver. 2.5.8.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Imageio.Plugins.Tiff
{
    #region FaxTIFFTagSet declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/FaxTIFFTagSet.html"/>
    /// </summary>
    public partial class FaxTIFFTagSet : Javax.Imageio.Plugins.Tiff.TIFFTagSet
    {
        const string _bridgeClassName = "javax.imageio.plugins.tiff.FaxTIFFTagSet";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public FaxTIFFTagSet() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public FaxTIFFTagSet(params object[] args) : base(args) { }

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

    #region FaxTIFFTagSet implementation
    public partial class FaxTIFFTagSet
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/FaxTIFFTagSet.html#CLEAN_FAX_DATA_ERRORS_CORRECTED"/>
        /// </summary>
        public static int CLEAN_FAX_DATA_ERRORS_CORRECTED { get { if (!_CLEAN_FAX_DATA_ERRORS_CORRECTEDReady) { _CLEAN_FAX_DATA_ERRORS_CORRECTEDContent = SGetField<int>(LocalBridgeClazz, "CLEAN_FAX_DATA_ERRORS_CORRECTED"); _CLEAN_FAX_DATA_ERRORS_CORRECTEDReady = true; } return _CLEAN_FAX_DATA_ERRORS_CORRECTEDContent; } }
        private static int _CLEAN_FAX_DATA_ERRORS_CORRECTEDContent = default;
        private static bool _CLEAN_FAX_DATA_ERRORS_CORRECTEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/FaxTIFFTagSet.html#CLEAN_FAX_DATA_ERRORS_UNCORRECTED"/>
        /// </summary>
        public static int CLEAN_FAX_DATA_ERRORS_UNCORRECTED { get { if (!_CLEAN_FAX_DATA_ERRORS_UNCORRECTEDReady) { _CLEAN_FAX_DATA_ERRORS_UNCORRECTEDContent = SGetField<int>(LocalBridgeClazz, "CLEAN_FAX_DATA_ERRORS_UNCORRECTED"); _CLEAN_FAX_DATA_ERRORS_UNCORRECTEDReady = true; } return _CLEAN_FAX_DATA_ERRORS_UNCORRECTEDContent; } }
        private static int _CLEAN_FAX_DATA_ERRORS_UNCORRECTEDContent = default;
        private static bool _CLEAN_FAX_DATA_ERRORS_UNCORRECTEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/FaxTIFFTagSet.html#CLEAN_FAX_DATA_NO_ERRORS"/>
        /// </summary>
        public static int CLEAN_FAX_DATA_NO_ERRORS { get { if (!_CLEAN_FAX_DATA_NO_ERRORSReady) { _CLEAN_FAX_DATA_NO_ERRORSContent = SGetField<int>(LocalBridgeClazz, "CLEAN_FAX_DATA_NO_ERRORS"); _CLEAN_FAX_DATA_NO_ERRORSReady = true; } return _CLEAN_FAX_DATA_NO_ERRORSContent; } }
        private static int _CLEAN_FAX_DATA_NO_ERRORSContent = default;
        private static bool _CLEAN_FAX_DATA_NO_ERRORSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/FaxTIFFTagSet.html#TAG_BAD_FAX_LINES"/>
        /// </summary>
        public static int TAG_BAD_FAX_LINES { get { if (!_TAG_BAD_FAX_LINESReady) { _TAG_BAD_FAX_LINESContent = SGetField<int>(LocalBridgeClazz, "TAG_BAD_FAX_LINES"); _TAG_BAD_FAX_LINESReady = true; } return _TAG_BAD_FAX_LINESContent; } }
        private static int _TAG_BAD_FAX_LINESContent = default;
        private static bool _TAG_BAD_FAX_LINESReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/FaxTIFFTagSet.html#TAG_CLEAN_FAX_DATA"/>
        /// </summary>
        public static int TAG_CLEAN_FAX_DATA { get { if (!_TAG_CLEAN_FAX_DATAReady) { _TAG_CLEAN_FAX_DATAContent = SGetField<int>(LocalBridgeClazz, "TAG_CLEAN_FAX_DATA"); _TAG_CLEAN_FAX_DATAReady = true; } return _TAG_CLEAN_FAX_DATAContent; } }
        private static int _TAG_CLEAN_FAX_DATAContent = default;
        private static bool _TAG_CLEAN_FAX_DATAReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/FaxTIFFTagSet.html#TAG_CONSECUTIVE_BAD_LINES"/>
        /// </summary>
        public static int TAG_CONSECUTIVE_BAD_LINES { get { if (!_TAG_CONSECUTIVE_BAD_LINESReady) { _TAG_CONSECUTIVE_BAD_LINESContent = SGetField<int>(LocalBridgeClazz, "TAG_CONSECUTIVE_BAD_LINES"); _TAG_CONSECUTIVE_BAD_LINESReady = true; } return _TAG_CONSECUTIVE_BAD_LINESContent; } }
        private static int _TAG_CONSECUTIVE_BAD_LINESContent = default;
        private static bool _TAG_CONSECUTIVE_BAD_LINESReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/FaxTIFFTagSet.html#getInstance()"/> 
        /// </summary>
        public static Javax.Imageio.Plugins.Tiff.FaxTIFFTagSet Instance
        {
            get { return SExecuteWithSignature<Javax.Imageio.Plugins.Tiff.FaxTIFFTagSet>(LocalBridgeClazz, "getInstance", "()Ljavax/imageio/plugins/tiff/FaxTIFFTagSet;"); }
        }

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}