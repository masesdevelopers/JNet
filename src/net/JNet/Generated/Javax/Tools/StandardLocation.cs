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

namespace Javax.Tools
{
    #region StandardLocation declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/StandardLocation.html"/>
    /// </summary>
    public partial class StandardLocation : Java.Lang.Enum<Javax.Tools.StandardLocation>
    {
        const string _bridgeClassName = "javax.tools.StandardLocation";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public StandardLocation() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public StandardLocation(params object[] args) : base(args) { }

        private static readonly IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new InvalidOperationException($"Class {_bridgeClassName} was not found.");

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

    #region StandardLocation implementation
    public partial class StandardLocation
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/StandardLocation.html#ANNOTATION_PROCESSOR_MODULE_PATH"/>
        /// </summary>
        public static Javax.Tools.StandardLocation ANNOTATION_PROCESSOR_MODULE_PATH { get { if (!_ANNOTATION_PROCESSOR_MODULE_PATHReady) { _ANNOTATION_PROCESSOR_MODULE_PATHContent = SGetField<Javax.Tools.StandardLocation>(LocalBridgeClazz, "ANNOTATION_PROCESSOR_MODULE_PATH"); _ANNOTATION_PROCESSOR_MODULE_PATHReady = true; } return _ANNOTATION_PROCESSOR_MODULE_PATHContent; } }
        private static Javax.Tools.StandardLocation _ANNOTATION_PROCESSOR_MODULE_PATHContent = default;
        private static bool _ANNOTATION_PROCESSOR_MODULE_PATHReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/StandardLocation.html#ANNOTATION_PROCESSOR_PATH"/>
        /// </summary>
        public static Javax.Tools.StandardLocation ANNOTATION_PROCESSOR_PATH { get { if (!_ANNOTATION_PROCESSOR_PATHReady) { _ANNOTATION_PROCESSOR_PATHContent = SGetField<Javax.Tools.StandardLocation>(LocalBridgeClazz, "ANNOTATION_PROCESSOR_PATH"); _ANNOTATION_PROCESSOR_PATHReady = true; } return _ANNOTATION_PROCESSOR_PATHContent; } }
        private static Javax.Tools.StandardLocation _ANNOTATION_PROCESSOR_PATHContent = default;
        private static bool _ANNOTATION_PROCESSOR_PATHReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/StandardLocation.html#CLASS_OUTPUT"/>
        /// </summary>
        public static Javax.Tools.StandardLocation CLASS_OUTPUT { get { if (!_CLASS_OUTPUTReady) { _CLASS_OUTPUTContent = SGetField<Javax.Tools.StandardLocation>(LocalBridgeClazz, "CLASS_OUTPUT"); _CLASS_OUTPUTReady = true; } return _CLASS_OUTPUTContent; } }
        private static Javax.Tools.StandardLocation _CLASS_OUTPUTContent = default;
        private static bool _CLASS_OUTPUTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/StandardLocation.html#CLASS_PATH"/>
        /// </summary>
        public static Javax.Tools.StandardLocation CLASS_PATH { get { if (!_CLASS_PATHReady) { _CLASS_PATHContent = SGetField<Javax.Tools.StandardLocation>(LocalBridgeClazz, "CLASS_PATH"); _CLASS_PATHReady = true; } return _CLASS_PATHContent; } }
        private static Javax.Tools.StandardLocation _CLASS_PATHContent = default;
        private static bool _CLASS_PATHReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/StandardLocation.html#MODULE_PATH"/>
        /// </summary>
        public static Javax.Tools.StandardLocation MODULE_PATH { get { if (!_MODULE_PATHReady) { _MODULE_PATHContent = SGetField<Javax.Tools.StandardLocation>(LocalBridgeClazz, "MODULE_PATH"); _MODULE_PATHReady = true; } return _MODULE_PATHContent; } }
        private static Javax.Tools.StandardLocation _MODULE_PATHContent = default;
        private static bool _MODULE_PATHReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/StandardLocation.html#MODULE_SOURCE_PATH"/>
        /// </summary>
        public static Javax.Tools.StandardLocation MODULE_SOURCE_PATH { get { if (!_MODULE_SOURCE_PATHReady) { _MODULE_SOURCE_PATHContent = SGetField<Javax.Tools.StandardLocation>(LocalBridgeClazz, "MODULE_SOURCE_PATH"); _MODULE_SOURCE_PATHReady = true; } return _MODULE_SOURCE_PATHContent; } }
        private static Javax.Tools.StandardLocation _MODULE_SOURCE_PATHContent = default;
        private static bool _MODULE_SOURCE_PATHReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/StandardLocation.html#NATIVE_HEADER_OUTPUT"/>
        /// </summary>
        public static Javax.Tools.StandardLocation NATIVE_HEADER_OUTPUT { get { if (!_NATIVE_HEADER_OUTPUTReady) { _NATIVE_HEADER_OUTPUTContent = SGetField<Javax.Tools.StandardLocation>(LocalBridgeClazz, "NATIVE_HEADER_OUTPUT"); _NATIVE_HEADER_OUTPUTReady = true; } return _NATIVE_HEADER_OUTPUTContent; } }
        private static Javax.Tools.StandardLocation _NATIVE_HEADER_OUTPUTContent = default;
        private static bool _NATIVE_HEADER_OUTPUTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/StandardLocation.html#PATCH_MODULE_PATH"/>
        /// </summary>
        public static Javax.Tools.StandardLocation PATCH_MODULE_PATH { get { if (!_PATCH_MODULE_PATHReady) { _PATCH_MODULE_PATHContent = SGetField<Javax.Tools.StandardLocation>(LocalBridgeClazz, "PATCH_MODULE_PATH"); _PATCH_MODULE_PATHReady = true; } return _PATCH_MODULE_PATHContent; } }
        private static Javax.Tools.StandardLocation _PATCH_MODULE_PATHContent = default;
        private static bool _PATCH_MODULE_PATHReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/StandardLocation.html#PLATFORM_CLASS_PATH"/>
        /// </summary>
        public static Javax.Tools.StandardLocation PLATFORM_CLASS_PATH { get { if (!_PLATFORM_CLASS_PATHReady) { _PLATFORM_CLASS_PATHContent = SGetField<Javax.Tools.StandardLocation>(LocalBridgeClazz, "PLATFORM_CLASS_PATH"); _PLATFORM_CLASS_PATHReady = true; } return _PLATFORM_CLASS_PATHContent; } }
        private static Javax.Tools.StandardLocation _PLATFORM_CLASS_PATHContent = default;
        private static bool _PLATFORM_CLASS_PATHReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/StandardLocation.html#SOURCE_OUTPUT"/>
        /// </summary>
        public static Javax.Tools.StandardLocation SOURCE_OUTPUT { get { if (!_SOURCE_OUTPUTReady) { _SOURCE_OUTPUTContent = SGetField<Javax.Tools.StandardLocation>(LocalBridgeClazz, "SOURCE_OUTPUT"); _SOURCE_OUTPUTReady = true; } return _SOURCE_OUTPUTContent; } }
        private static Javax.Tools.StandardLocation _SOURCE_OUTPUTContent = default;
        private static bool _SOURCE_OUTPUTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/StandardLocation.html#SOURCE_PATH"/>
        /// </summary>
        public static Javax.Tools.StandardLocation SOURCE_PATH { get { if (!_SOURCE_PATHReady) { _SOURCE_PATHContent = SGetField<Javax.Tools.StandardLocation>(LocalBridgeClazz, "SOURCE_PATH"); _SOURCE_PATHReady = true; } return _SOURCE_PATHContent; } }
        private static Javax.Tools.StandardLocation _SOURCE_PATHContent = default;
        private static bool _SOURCE_PATHReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/StandardLocation.html#SYSTEM_MODULES"/>
        /// </summary>
        public static Javax.Tools.StandardLocation SYSTEM_MODULES { get { if (!_SYSTEM_MODULESReady) { _SYSTEM_MODULESContent = SGetField<Javax.Tools.StandardLocation>(LocalBridgeClazz, "SYSTEM_MODULES"); _SYSTEM_MODULESReady = true; } return _SYSTEM_MODULESContent; } }
        private static Javax.Tools.StandardLocation _SYSTEM_MODULESContent = default;
        private static bool _SYSTEM_MODULESReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/StandardLocation.html#UPGRADE_MODULE_PATH"/>
        /// </summary>
        public static Javax.Tools.StandardLocation UPGRADE_MODULE_PATH { get { if (!_UPGRADE_MODULE_PATHReady) { _UPGRADE_MODULE_PATHContent = SGetField<Javax.Tools.StandardLocation>(LocalBridgeClazz, "UPGRADE_MODULE_PATH"); _UPGRADE_MODULE_PATHReady = true; } return _UPGRADE_MODULE_PATHContent; } }
        private static Javax.Tools.StandardLocation _UPGRADE_MODULE_PATHContent = default;
        private static bool _UPGRADE_MODULE_PATHReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/StandardLocation.html#locationFor(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Tools.JavaFileManager.Location"/></returns>
        public static Javax.Tools.JavaFileManager.Location LocationFor(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Javax.Tools.JavaFileManager.Location>(LocalBridgeClazz, "locationFor", "(Ljava/lang/String;)Ljavax/tools/JavaFileManager$Location;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/StandardLocation.html#valueOf(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Tools.StandardLocation"/></returns>
        public static Javax.Tools.StandardLocation ValueOf(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Javax.Tools.StandardLocation>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Ljavax/tools/StandardLocation;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/StandardLocation.html#values()"/>
        /// </summary>
        /// <returns><see cref="Javax.Tools.StandardLocation"/></returns>
        public static Javax.Tools.StandardLocation[] Values()
        {
            return SExecuteWithSignatureArray<Javax.Tools.StandardLocation>(LocalBridgeClazz, "values", "()[Ljavax/tools/StandardLocation;");
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/StandardLocation.html#getName()"/> 
        /// </summary>
        public Java.Lang.String Name
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getName", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/StandardLocation.html#isModuleOrientedLocation()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsModuleOrientedLocation()
        {
            return IExecuteWithSignature<bool>("isModuleOrientedLocation", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/StandardLocation.html#isOutputLocation()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsOutputLocation()
        {
            return IExecuteWithSignature<bool>("isOutputLocation", "()Z");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}