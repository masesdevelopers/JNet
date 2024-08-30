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

namespace Java.Net
{
    #region HttpURLConnection definition
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/HttpURLConnection.html"/>
    /// </summary>
    public partial class HttpURLConnection : Java.Net.URLConnection
    {
        const string _bridgeClassName = "java.net.HttpURLConnection";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("HttpURLConnection class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public HttpURLConnection() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("HttpURLConnection class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public HttpURLConnection(params object[] args) : base(args) { }

        private static readonly IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new InvalidOperationException($"Class {_bridgeClassName} was not found.");

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
        public override bool IsBridgeInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region HttpURLConnection
    public partial class HttpURLConnection
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/HttpURLConnection.html#HTTP_ACCEPTED"/>
        /// </summary>
        public static int HTTP_ACCEPTED { get { if (!_HTTP_ACCEPTEDReady) { _HTTP_ACCEPTEDContent = SGetField<int>(LocalBridgeClazz, "HTTP_ACCEPTED"); _HTTP_ACCEPTEDReady = true; } return _HTTP_ACCEPTEDContent; } }
        private static int _HTTP_ACCEPTEDContent = default;
        private static bool _HTTP_ACCEPTEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/HttpURLConnection.html#HTTP_BAD_GATEWAY"/>
        /// </summary>
        public static int HTTP_BAD_GATEWAY { get { if (!_HTTP_BAD_GATEWAYReady) { _HTTP_BAD_GATEWAYContent = SGetField<int>(LocalBridgeClazz, "HTTP_BAD_GATEWAY"); _HTTP_BAD_GATEWAYReady = true; } return _HTTP_BAD_GATEWAYContent; } }
        private static int _HTTP_BAD_GATEWAYContent = default;
        private static bool _HTTP_BAD_GATEWAYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/HttpURLConnection.html#HTTP_BAD_METHOD"/>
        /// </summary>
        public static int HTTP_BAD_METHOD { get { if (!_HTTP_BAD_METHODReady) { _HTTP_BAD_METHODContent = SGetField<int>(LocalBridgeClazz, "HTTP_BAD_METHOD"); _HTTP_BAD_METHODReady = true; } return _HTTP_BAD_METHODContent; } }
        private static int _HTTP_BAD_METHODContent = default;
        private static bool _HTTP_BAD_METHODReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/HttpURLConnection.html#HTTP_BAD_REQUEST"/>
        /// </summary>
        public static int HTTP_BAD_REQUEST { get { if (!_HTTP_BAD_REQUESTReady) { _HTTP_BAD_REQUESTContent = SGetField<int>(LocalBridgeClazz, "HTTP_BAD_REQUEST"); _HTTP_BAD_REQUESTReady = true; } return _HTTP_BAD_REQUESTContent; } }
        private static int _HTTP_BAD_REQUESTContent = default;
        private static bool _HTTP_BAD_REQUESTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/HttpURLConnection.html#HTTP_CLIENT_TIMEOUT"/>
        /// </summary>
        public static int HTTP_CLIENT_TIMEOUT { get { if (!_HTTP_CLIENT_TIMEOUTReady) { _HTTP_CLIENT_TIMEOUTContent = SGetField<int>(LocalBridgeClazz, "HTTP_CLIENT_TIMEOUT"); _HTTP_CLIENT_TIMEOUTReady = true; } return _HTTP_CLIENT_TIMEOUTContent; } }
        private static int _HTTP_CLIENT_TIMEOUTContent = default;
        private static bool _HTTP_CLIENT_TIMEOUTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/HttpURLConnection.html#HTTP_CONFLICT"/>
        /// </summary>
        public static int HTTP_CONFLICT { get { if (!_HTTP_CONFLICTReady) { _HTTP_CONFLICTContent = SGetField<int>(LocalBridgeClazz, "HTTP_CONFLICT"); _HTTP_CONFLICTReady = true; } return _HTTP_CONFLICTContent; } }
        private static int _HTTP_CONFLICTContent = default;
        private static bool _HTTP_CONFLICTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/HttpURLConnection.html#HTTP_CREATED"/>
        /// </summary>
        public static int HTTP_CREATED { get { if (!_HTTP_CREATEDReady) { _HTTP_CREATEDContent = SGetField<int>(LocalBridgeClazz, "HTTP_CREATED"); _HTTP_CREATEDReady = true; } return _HTTP_CREATEDContent; } }
        private static int _HTTP_CREATEDContent = default;
        private static bool _HTTP_CREATEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/HttpURLConnection.html#HTTP_ENTITY_TOO_LARGE"/>
        /// </summary>
        public static int HTTP_ENTITY_TOO_LARGE { get { if (!_HTTP_ENTITY_TOO_LARGEReady) { _HTTP_ENTITY_TOO_LARGEContent = SGetField<int>(LocalBridgeClazz, "HTTP_ENTITY_TOO_LARGE"); _HTTP_ENTITY_TOO_LARGEReady = true; } return _HTTP_ENTITY_TOO_LARGEContent; } }
        private static int _HTTP_ENTITY_TOO_LARGEContent = default;
        private static bool _HTTP_ENTITY_TOO_LARGEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/HttpURLConnection.html#HTTP_FORBIDDEN"/>
        /// </summary>
        public static int HTTP_FORBIDDEN { get { if (!_HTTP_FORBIDDENReady) { _HTTP_FORBIDDENContent = SGetField<int>(LocalBridgeClazz, "HTTP_FORBIDDEN"); _HTTP_FORBIDDENReady = true; } return _HTTP_FORBIDDENContent; } }
        private static int _HTTP_FORBIDDENContent = default;
        private static bool _HTTP_FORBIDDENReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/HttpURLConnection.html#HTTP_GATEWAY_TIMEOUT"/>
        /// </summary>
        public static int HTTP_GATEWAY_TIMEOUT { get { if (!_HTTP_GATEWAY_TIMEOUTReady) { _HTTP_GATEWAY_TIMEOUTContent = SGetField<int>(LocalBridgeClazz, "HTTP_GATEWAY_TIMEOUT"); _HTTP_GATEWAY_TIMEOUTReady = true; } return _HTTP_GATEWAY_TIMEOUTContent; } }
        private static int _HTTP_GATEWAY_TIMEOUTContent = default;
        private static bool _HTTP_GATEWAY_TIMEOUTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/HttpURLConnection.html#HTTP_GONE"/>
        /// </summary>
        public static int HTTP_GONE { get { if (!_HTTP_GONEReady) { _HTTP_GONEContent = SGetField<int>(LocalBridgeClazz, "HTTP_GONE"); _HTTP_GONEReady = true; } return _HTTP_GONEContent; } }
        private static int _HTTP_GONEContent = default;
        private static bool _HTTP_GONEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/HttpURLConnection.html#HTTP_INTERNAL_ERROR"/>
        /// </summary>
        public static int HTTP_INTERNAL_ERROR { get { if (!_HTTP_INTERNAL_ERRORReady) { _HTTP_INTERNAL_ERRORContent = SGetField<int>(LocalBridgeClazz, "HTTP_INTERNAL_ERROR"); _HTTP_INTERNAL_ERRORReady = true; } return _HTTP_INTERNAL_ERRORContent; } }
        private static int _HTTP_INTERNAL_ERRORContent = default;
        private static bool _HTTP_INTERNAL_ERRORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/HttpURLConnection.html#HTTP_LENGTH_REQUIRED"/>
        /// </summary>
        public static int HTTP_LENGTH_REQUIRED { get { if (!_HTTP_LENGTH_REQUIREDReady) { _HTTP_LENGTH_REQUIREDContent = SGetField<int>(LocalBridgeClazz, "HTTP_LENGTH_REQUIRED"); _HTTP_LENGTH_REQUIREDReady = true; } return _HTTP_LENGTH_REQUIREDContent; } }
        private static int _HTTP_LENGTH_REQUIREDContent = default;
        private static bool _HTTP_LENGTH_REQUIREDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/HttpURLConnection.html#HTTP_MOVED_PERM"/>
        /// </summary>
        public static int HTTP_MOVED_PERM { get { if (!_HTTP_MOVED_PERMReady) { _HTTP_MOVED_PERMContent = SGetField<int>(LocalBridgeClazz, "HTTP_MOVED_PERM"); _HTTP_MOVED_PERMReady = true; } return _HTTP_MOVED_PERMContent; } }
        private static int _HTTP_MOVED_PERMContent = default;
        private static bool _HTTP_MOVED_PERMReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/HttpURLConnection.html#HTTP_MOVED_TEMP"/>
        /// </summary>
        public static int HTTP_MOVED_TEMP { get { if (!_HTTP_MOVED_TEMPReady) { _HTTP_MOVED_TEMPContent = SGetField<int>(LocalBridgeClazz, "HTTP_MOVED_TEMP"); _HTTP_MOVED_TEMPReady = true; } return _HTTP_MOVED_TEMPContent; } }
        private static int _HTTP_MOVED_TEMPContent = default;
        private static bool _HTTP_MOVED_TEMPReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/HttpURLConnection.html#HTTP_MULT_CHOICE"/>
        /// </summary>
        public static int HTTP_MULT_CHOICE { get { if (!_HTTP_MULT_CHOICEReady) { _HTTP_MULT_CHOICEContent = SGetField<int>(LocalBridgeClazz, "HTTP_MULT_CHOICE"); _HTTP_MULT_CHOICEReady = true; } return _HTTP_MULT_CHOICEContent; } }
        private static int _HTTP_MULT_CHOICEContent = default;
        private static bool _HTTP_MULT_CHOICEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/HttpURLConnection.html#HTTP_NO_CONTENT"/>
        /// </summary>
        public static int HTTP_NO_CONTENT { get { if (!_HTTP_NO_CONTENTReady) { _HTTP_NO_CONTENTContent = SGetField<int>(LocalBridgeClazz, "HTTP_NO_CONTENT"); _HTTP_NO_CONTENTReady = true; } return _HTTP_NO_CONTENTContent; } }
        private static int _HTTP_NO_CONTENTContent = default;
        private static bool _HTTP_NO_CONTENTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/HttpURLConnection.html#HTTP_NOT_ACCEPTABLE"/>
        /// </summary>
        public static int HTTP_NOT_ACCEPTABLE { get { if (!_HTTP_NOT_ACCEPTABLEReady) { _HTTP_NOT_ACCEPTABLEContent = SGetField<int>(LocalBridgeClazz, "HTTP_NOT_ACCEPTABLE"); _HTTP_NOT_ACCEPTABLEReady = true; } return _HTTP_NOT_ACCEPTABLEContent; } }
        private static int _HTTP_NOT_ACCEPTABLEContent = default;
        private static bool _HTTP_NOT_ACCEPTABLEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/HttpURLConnection.html#HTTP_NOT_AUTHORITATIVE"/>
        /// </summary>
        public static int HTTP_NOT_AUTHORITATIVE { get { if (!_HTTP_NOT_AUTHORITATIVEReady) { _HTTP_NOT_AUTHORITATIVEContent = SGetField<int>(LocalBridgeClazz, "HTTP_NOT_AUTHORITATIVE"); _HTTP_NOT_AUTHORITATIVEReady = true; } return _HTTP_NOT_AUTHORITATIVEContent; } }
        private static int _HTTP_NOT_AUTHORITATIVEContent = default;
        private static bool _HTTP_NOT_AUTHORITATIVEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/HttpURLConnection.html#HTTP_NOT_FOUND"/>
        /// </summary>
        public static int HTTP_NOT_FOUND { get { if (!_HTTP_NOT_FOUNDReady) { _HTTP_NOT_FOUNDContent = SGetField<int>(LocalBridgeClazz, "HTTP_NOT_FOUND"); _HTTP_NOT_FOUNDReady = true; } return _HTTP_NOT_FOUNDContent; } }
        private static int _HTTP_NOT_FOUNDContent = default;
        private static bool _HTTP_NOT_FOUNDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/HttpURLConnection.html#HTTP_NOT_IMPLEMENTED"/>
        /// </summary>
        public static int HTTP_NOT_IMPLEMENTED { get { if (!_HTTP_NOT_IMPLEMENTEDReady) { _HTTP_NOT_IMPLEMENTEDContent = SGetField<int>(LocalBridgeClazz, "HTTP_NOT_IMPLEMENTED"); _HTTP_NOT_IMPLEMENTEDReady = true; } return _HTTP_NOT_IMPLEMENTEDContent; } }
        private static int _HTTP_NOT_IMPLEMENTEDContent = default;
        private static bool _HTTP_NOT_IMPLEMENTEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/HttpURLConnection.html#HTTP_NOT_MODIFIED"/>
        /// </summary>
        public static int HTTP_NOT_MODIFIED { get { if (!_HTTP_NOT_MODIFIEDReady) { _HTTP_NOT_MODIFIEDContent = SGetField<int>(LocalBridgeClazz, "HTTP_NOT_MODIFIED"); _HTTP_NOT_MODIFIEDReady = true; } return _HTTP_NOT_MODIFIEDContent; } }
        private static int _HTTP_NOT_MODIFIEDContent = default;
        private static bool _HTTP_NOT_MODIFIEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/HttpURLConnection.html#HTTP_OK"/>
        /// </summary>
        public static int HTTP_OK { get { if (!_HTTP_OKReady) { _HTTP_OKContent = SGetField<int>(LocalBridgeClazz, "HTTP_OK"); _HTTP_OKReady = true; } return _HTTP_OKContent; } }
        private static int _HTTP_OKContent = default;
        private static bool _HTTP_OKReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/HttpURLConnection.html#HTTP_PARTIAL"/>
        /// </summary>
        public static int HTTP_PARTIAL { get { if (!_HTTP_PARTIALReady) { _HTTP_PARTIALContent = SGetField<int>(LocalBridgeClazz, "HTTP_PARTIAL"); _HTTP_PARTIALReady = true; } return _HTTP_PARTIALContent; } }
        private static int _HTTP_PARTIALContent = default;
        private static bool _HTTP_PARTIALReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/HttpURLConnection.html#HTTP_PAYMENT_REQUIRED"/>
        /// </summary>
        public static int HTTP_PAYMENT_REQUIRED { get { if (!_HTTP_PAYMENT_REQUIREDReady) { _HTTP_PAYMENT_REQUIREDContent = SGetField<int>(LocalBridgeClazz, "HTTP_PAYMENT_REQUIRED"); _HTTP_PAYMENT_REQUIREDReady = true; } return _HTTP_PAYMENT_REQUIREDContent; } }
        private static int _HTTP_PAYMENT_REQUIREDContent = default;
        private static bool _HTTP_PAYMENT_REQUIREDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/HttpURLConnection.html#HTTP_PRECON_FAILED"/>
        /// </summary>
        public static int HTTP_PRECON_FAILED { get { if (!_HTTP_PRECON_FAILEDReady) { _HTTP_PRECON_FAILEDContent = SGetField<int>(LocalBridgeClazz, "HTTP_PRECON_FAILED"); _HTTP_PRECON_FAILEDReady = true; } return _HTTP_PRECON_FAILEDContent; } }
        private static int _HTTP_PRECON_FAILEDContent = default;
        private static bool _HTTP_PRECON_FAILEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/HttpURLConnection.html#HTTP_PROXY_AUTH"/>
        /// </summary>
        public static int HTTP_PROXY_AUTH { get { if (!_HTTP_PROXY_AUTHReady) { _HTTP_PROXY_AUTHContent = SGetField<int>(LocalBridgeClazz, "HTTP_PROXY_AUTH"); _HTTP_PROXY_AUTHReady = true; } return _HTTP_PROXY_AUTHContent; } }
        private static int _HTTP_PROXY_AUTHContent = default;
        private static bool _HTTP_PROXY_AUTHReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/HttpURLConnection.html#HTTP_REQ_TOO_LONG"/>
        /// </summary>
        public static int HTTP_REQ_TOO_LONG { get { if (!_HTTP_REQ_TOO_LONGReady) { _HTTP_REQ_TOO_LONGContent = SGetField<int>(LocalBridgeClazz, "HTTP_REQ_TOO_LONG"); _HTTP_REQ_TOO_LONGReady = true; } return _HTTP_REQ_TOO_LONGContent; } }
        private static int _HTTP_REQ_TOO_LONGContent = default;
        private static bool _HTTP_REQ_TOO_LONGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/HttpURLConnection.html#HTTP_RESET"/>
        /// </summary>
        public static int HTTP_RESET { get { if (!_HTTP_RESETReady) { _HTTP_RESETContent = SGetField<int>(LocalBridgeClazz, "HTTP_RESET"); _HTTP_RESETReady = true; } return _HTTP_RESETContent; } }
        private static int _HTTP_RESETContent = default;
        private static bool _HTTP_RESETReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/HttpURLConnection.html#HTTP_SEE_OTHER"/>
        /// </summary>
        public static int HTTP_SEE_OTHER { get { if (!_HTTP_SEE_OTHERReady) { _HTTP_SEE_OTHERContent = SGetField<int>(LocalBridgeClazz, "HTTP_SEE_OTHER"); _HTTP_SEE_OTHERReady = true; } return _HTTP_SEE_OTHERContent; } }
        private static int _HTTP_SEE_OTHERContent = default;
        private static bool _HTTP_SEE_OTHERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/HttpURLConnection.html#HTTP_UNAUTHORIZED"/>
        /// </summary>
        public static int HTTP_UNAUTHORIZED { get { if (!_HTTP_UNAUTHORIZEDReady) { _HTTP_UNAUTHORIZEDContent = SGetField<int>(LocalBridgeClazz, "HTTP_UNAUTHORIZED"); _HTTP_UNAUTHORIZEDReady = true; } return _HTTP_UNAUTHORIZEDContent; } }
        private static int _HTTP_UNAUTHORIZEDContent = default;
        private static bool _HTTP_UNAUTHORIZEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/HttpURLConnection.html#HTTP_UNAVAILABLE"/>
        /// </summary>
        public static int HTTP_UNAVAILABLE { get { if (!_HTTP_UNAVAILABLEReady) { _HTTP_UNAVAILABLEContent = SGetField<int>(LocalBridgeClazz, "HTTP_UNAVAILABLE"); _HTTP_UNAVAILABLEReady = true; } return _HTTP_UNAVAILABLEContent; } }
        private static int _HTTP_UNAVAILABLEContent = default;
        private static bool _HTTP_UNAVAILABLEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/HttpURLConnection.html#HTTP_UNSUPPORTED_TYPE"/>
        /// </summary>
        public static int HTTP_UNSUPPORTED_TYPE { get { if (!_HTTP_UNSUPPORTED_TYPEReady) { _HTTP_UNSUPPORTED_TYPEContent = SGetField<int>(LocalBridgeClazz, "HTTP_UNSUPPORTED_TYPE"); _HTTP_UNSUPPORTED_TYPEReady = true; } return _HTTP_UNSUPPORTED_TYPEContent; } }
        private static int _HTTP_UNSUPPORTED_TYPEContent = default;
        private static bool _HTTP_UNSUPPORTED_TYPEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/HttpURLConnection.html#HTTP_USE_PROXY"/>
        /// </summary>
        public static int HTTP_USE_PROXY { get { if (!_HTTP_USE_PROXYReady) { _HTTP_USE_PROXYContent = SGetField<int>(LocalBridgeClazz, "HTTP_USE_PROXY"); _HTTP_USE_PROXYReady = true; } return _HTTP_USE_PROXYContent; } }
        private static int _HTTP_USE_PROXYContent = default;
        private static bool _HTTP_USE_PROXYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/HttpURLConnection.html#HTTP_VERSION"/>
        /// </summary>
        public static int HTTP_VERSION { get { if (!_HTTP_VERSIONReady) { _HTTP_VERSIONContent = SGetField<int>(LocalBridgeClazz, "HTTP_VERSION"); _HTTP_VERSIONReady = true; } return _HTTP_VERSIONContent; } }
        private static int _HTTP_VERSIONContent = default;
        private static bool _HTTP_VERSIONReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/HttpURLConnection.html#getFollowRedirects()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/HttpURLConnection.html#setFollowRedirects(boolean)"/>
        /// </summary>
        public static bool FollowRedirects
        {
            get { return SExecuteWithSignature<bool>(LocalBridgeClazz, "getFollowRedirects", "()Z"); } set { SExecuteWithSignature(LocalBridgeClazz, "setFollowRedirects", "(Z)V", value); }
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/HttpURLConnection.html#getErrorStream()"/> 
        /// </summary>
        public Java.Io.InputStream ErrorStream
        {
            get { return IExecuteWithSignature<Java.Io.InputStream>("getErrorStream", "()Ljava/io/InputStream;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/HttpURLConnection.html#getInstanceFollowRedirects()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/HttpURLConnection.html#setInstanceFollowRedirects(boolean)"/>
        /// </summary>
        public bool InstanceFollowRedirects
        {
            get { return IExecuteWithSignature<bool>("getInstanceFollowRedirects", "()Z"); } set { IExecuteWithSignature("setInstanceFollowRedirects", "(Z)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/HttpURLConnection.html#getRequestMethod()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/HttpURLConnection.html#setRequestMethod(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String RequestMethod
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getRequestMethod", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setRequestMethod", "(Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/HttpURLConnection.html#getResponseCode()"/> 
        /// </summary>
        public int ResponseCode
        {
            get { return IExecuteWithSignature<int>("getResponseCode", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/HttpURLConnection.html#getResponseMessage()"/> 
        /// </summary>
        public Java.Lang.String ResponseMessage
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getResponseMessage", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/HttpURLConnection.html#usingProxy()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool UsingProxy()
        {
            return IExecuteWithSignature<bool>("usingProxy", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/HttpURLConnection.html#disconnect()"/>
        /// </summary>
        public void Disconnect()
        {
            IExecuteWithSignature("disconnect", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/HttpURLConnection.html#setAuthenticator(java.net.Authenticator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.Authenticator"/></param>
        public void SetAuthenticator(Java.Net.Authenticator arg0)
        {
            IExecuteWithSignature("setAuthenticator", "(Ljava/net/Authenticator;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/HttpURLConnection.html#setChunkedStreamingMode(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetChunkedStreamingMode(int arg0)
        {
            IExecuteWithSignature("setChunkedStreamingMode", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/HttpURLConnection.html#setFixedLengthStreamingMode(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetFixedLengthStreamingMode(int arg0)
        {
            IExecuteWithSignature("setFixedLengthStreamingMode", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/HttpURLConnection.html#setFixedLengthStreamingMode(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        public void SetFixedLengthStreamingMode(long arg0)
        {
            IExecuteWithSignature("setFixedLengthStreamingMode", "(J)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}