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

namespace Java.Nio.File
{
    #region StandardOpenOption declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/StandardOpenOption.html"/>
    /// </summary>
    public partial class StandardOpenOption : Java.Lang.Enum<Java.Nio.File.StandardOpenOption>
    {
        const string _bridgeClassName = "java.nio.file.StandardOpenOption";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public StandardOpenOption() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public StandardOpenOption(params object[] args) : base(args) { }

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

    #region StandardOpenOption implementation
    public partial class StandardOpenOption
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Nio.File.StandardOpenOption"/> to <see cref="Java.Nio.File.OpenOption"/>
        /// </summary>
        public static implicit operator Java.Nio.File.OpenOption(Java.Nio.File.StandardOpenOption t) => t.Cast<Java.Nio.File.OpenOption>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/StandardOpenOption.html#APPEND"/>
        /// </summary>
        public static Java.Nio.File.StandardOpenOption APPEND { get { if (!_APPENDReady) { _APPENDContent = SGetField<Java.Nio.File.StandardOpenOption>(LocalBridgeClazz, "APPEND"); _APPENDReady = true; } return _APPENDContent; } }
        private static Java.Nio.File.StandardOpenOption _APPENDContent = default;
        private static bool _APPENDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/StandardOpenOption.html#CREATE"/>
        /// </summary>
        public static Java.Nio.File.StandardOpenOption CREATE { get { if (!_CREATEReady) { _CREATEContent = SGetField<Java.Nio.File.StandardOpenOption>(LocalBridgeClazz, "CREATE"); _CREATEReady = true; } return _CREATEContent; } }
        private static Java.Nio.File.StandardOpenOption _CREATEContent = default;
        private static bool _CREATEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/StandardOpenOption.html#CREATE_NEW"/>
        /// </summary>
        public static Java.Nio.File.StandardOpenOption CREATE_NEW { get { if (!_CREATE_NEWReady) { _CREATE_NEWContent = SGetField<Java.Nio.File.StandardOpenOption>(LocalBridgeClazz, "CREATE_NEW"); _CREATE_NEWReady = true; } return _CREATE_NEWContent; } }
        private static Java.Nio.File.StandardOpenOption _CREATE_NEWContent = default;
        private static bool _CREATE_NEWReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/StandardOpenOption.html#DELETE_ON_CLOSE"/>
        /// </summary>
        public static Java.Nio.File.StandardOpenOption DELETE_ON_CLOSE { get { if (!_DELETE_ON_CLOSEReady) { _DELETE_ON_CLOSEContent = SGetField<Java.Nio.File.StandardOpenOption>(LocalBridgeClazz, "DELETE_ON_CLOSE"); _DELETE_ON_CLOSEReady = true; } return _DELETE_ON_CLOSEContent; } }
        private static Java.Nio.File.StandardOpenOption _DELETE_ON_CLOSEContent = default;
        private static bool _DELETE_ON_CLOSEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/StandardOpenOption.html#DSYNC"/>
        /// </summary>
        public static Java.Nio.File.StandardOpenOption DSYNC { get { if (!_DSYNCReady) { _DSYNCContent = SGetField<Java.Nio.File.StandardOpenOption>(LocalBridgeClazz, "DSYNC"); _DSYNCReady = true; } return _DSYNCContent; } }
        private static Java.Nio.File.StandardOpenOption _DSYNCContent = default;
        private static bool _DSYNCReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/StandardOpenOption.html#READ"/>
        /// </summary>
        public static Java.Nio.File.StandardOpenOption READ { get { if (!_READReady) { _READContent = SGetField<Java.Nio.File.StandardOpenOption>(LocalBridgeClazz, "READ"); _READReady = true; } return _READContent; } }
        private static Java.Nio.File.StandardOpenOption _READContent = default;
        private static bool _READReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/StandardOpenOption.html#SPARSE"/>
        /// </summary>
        public static Java.Nio.File.StandardOpenOption SPARSE { get { if (!_SPARSEReady) { _SPARSEContent = SGetField<Java.Nio.File.StandardOpenOption>(LocalBridgeClazz, "SPARSE"); _SPARSEReady = true; } return _SPARSEContent; } }
        private static Java.Nio.File.StandardOpenOption _SPARSEContent = default;
        private static bool _SPARSEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/StandardOpenOption.html#SYNC"/>
        /// </summary>
        public static Java.Nio.File.StandardOpenOption SYNC { get { if (!_SYNCReady) { _SYNCContent = SGetField<Java.Nio.File.StandardOpenOption>(LocalBridgeClazz, "SYNC"); _SYNCReady = true; } return _SYNCContent; } }
        private static Java.Nio.File.StandardOpenOption _SYNCContent = default;
        private static bool _SYNCReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/StandardOpenOption.html#TRUNCATE_EXISTING"/>
        /// </summary>
        public static Java.Nio.File.StandardOpenOption TRUNCATE_EXISTING { get { if (!_TRUNCATE_EXISTINGReady) { _TRUNCATE_EXISTINGContent = SGetField<Java.Nio.File.StandardOpenOption>(LocalBridgeClazz, "TRUNCATE_EXISTING"); _TRUNCATE_EXISTINGReady = true; } return _TRUNCATE_EXISTINGContent; } }
        private static Java.Nio.File.StandardOpenOption _TRUNCATE_EXISTINGContent = default;
        private static bool _TRUNCATE_EXISTINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/StandardOpenOption.html#WRITE"/>
        /// </summary>
        public static Java.Nio.File.StandardOpenOption WRITE { get { if (!_WRITEReady) { _WRITEContent = SGetField<Java.Nio.File.StandardOpenOption>(LocalBridgeClazz, "WRITE"); _WRITEReady = true; } return _WRITEContent; } }
        private static Java.Nio.File.StandardOpenOption _WRITEContent = default;
        private static bool _WRITEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/StandardOpenOption.html#valueOf(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Nio.File.StandardOpenOption"/></returns>
        public static Java.Nio.File.StandardOpenOption ValueOf(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Nio.File.StandardOpenOption>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Ljava/nio/file/StandardOpenOption;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/StandardOpenOption.html#values()"/>
        /// </summary>
        /// <returns><see cref="Java.Nio.File.StandardOpenOption"/></returns>
        public static Java.Nio.File.StandardOpenOption[] Values()
        {
            return SExecuteWithSignatureArray<Java.Nio.File.StandardOpenOption>(LocalBridgeClazz, "values", "()[Ljava/nio/file/StandardOpenOption;");
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