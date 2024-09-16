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
    #region JavaFileObject declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/JavaFileObject.html"/>
    /// </summary>
    public partial class JavaFileObject : Javax.Tools.FileObject
    {
        const string _bridgeClassName = "javax.tools.JavaFileObject";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("JavaFileObject class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public JavaFileObject() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("JavaFileObject class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public JavaFileObject(params object[] args) : base(args) { }

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
        #region Kind declaration
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/JavaFileObject.Kind.html"/>
        /// </summary>
        public partial class Kind : Java.Lang.Enum<Javax.Tools.JavaFileObject.Kind>
        {
            const string _bridgeClassName = "javax.tools.JavaFileObject$Kind";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public Kind() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public Kind(params object[] args) : base(args) { }

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
            public override bool IsBridgeStatic => true;

            // TODO: complete the class

        }
        #endregion

    
    }
    #endregion

    #region IJavaFileObject
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IJavaFileObject : Javax.Tools.IFileObject
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/JavaFileObject.html#getAccessLevel()"/> 
        /// </summary>
        Javax.Lang.Model.Element.Modifier AccessLevel { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/JavaFileObject.html#getKind()"/> 
        /// </summary>
        Javax.Tools.JavaFileObject.Kind GetKind { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/JavaFileObject.html#getNestingKind()"/> 
        /// </summary>
        Javax.Lang.Model.Element.NestingKind NestingKind { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/JavaFileObject.html#isNameCompatible(java.lang.String,javax.tools.JavaFileObject.Kind)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Javax.Tools.JavaFileObject.Kind"/></param>
        /// <returns><see cref="bool"/></returns>
        bool IsNameCompatible(Java.Lang.String arg0, Javax.Tools.JavaFileObject.Kind arg1);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region JavaFileObject implementation
    public partial class JavaFileObject : Javax.Tools.IJavaFileObject
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/JavaFileObject.html#getAccessLevel()"/> 
        /// </summary>
        public Javax.Lang.Model.Element.Modifier AccessLevel
        {
            get { return IExecuteWithSignature<Javax.Lang.Model.Element.Modifier>("getAccessLevel", "()Ljavax/lang/model/element/Modifier;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/JavaFileObject.html#getKind()"/> 
        /// </summary>
        public Javax.Tools.JavaFileObject.Kind GetKind
        {
            get { return IExecuteWithSignature<Javax.Tools.JavaFileObject.Kind>("getKind", "()Ljavax/tools/JavaFileObject$Kind;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/JavaFileObject.html#getNestingKind()"/> 
        /// </summary>
        public Javax.Lang.Model.Element.NestingKind NestingKind
        {
            get { return IExecuteWithSignature<Javax.Lang.Model.Element.NestingKind>("getNestingKind", "()Ljavax/lang/model/element/NestingKind;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/JavaFileObject.html#isNameCompatible(java.lang.String,javax.tools.JavaFileObject.Kind)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Javax.Tools.JavaFileObject.Kind"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsNameCompatible(Java.Lang.String arg0, Javax.Tools.JavaFileObject.Kind arg1)
        {
            return IExecute<bool>("isNameCompatible", arg0, arg1);
        }

        #endregion

        #region Nested classes
        #region Kind implementation
        public partial class Kind
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/JavaFileObject.Kind.html#extension"/>
            /// </summary>
            public Java.Lang.String extension { get { if (!_extensionReady) { _extensionContent = IGetField<Java.Lang.String>("extension"); _extensionReady = true; } return _extensionContent; } }
            private Java.Lang.String _extensionContent = default;
            private bool _extensionReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/JavaFileObject.Kind.html#CLASS"/>
            /// </summary>
            public static Javax.Tools.JavaFileObject.Kind CLASS { get { if (!_CLASSReady) { _CLASSContent = SGetField<Javax.Tools.JavaFileObject.Kind>(LocalBridgeClazz, "CLASS"); _CLASSReady = true; } return _CLASSContent; } }
            private static Javax.Tools.JavaFileObject.Kind _CLASSContent = default;
            private static bool _CLASSReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/JavaFileObject.Kind.html#HTML"/>
            /// </summary>
            public static Javax.Tools.JavaFileObject.Kind HTML { get { if (!_HTMLReady) { _HTMLContent = SGetField<Javax.Tools.JavaFileObject.Kind>(LocalBridgeClazz, "HTML"); _HTMLReady = true; } return _HTMLContent; } }
            private static Javax.Tools.JavaFileObject.Kind _HTMLContent = default;
            private static bool _HTMLReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/JavaFileObject.Kind.html#OTHER"/>
            /// </summary>
            public static Javax.Tools.JavaFileObject.Kind OTHER { get { if (!_OTHERReady) { _OTHERContent = SGetField<Javax.Tools.JavaFileObject.Kind>(LocalBridgeClazz, "OTHER"); _OTHERReady = true; } return _OTHERContent; } }
            private static Javax.Tools.JavaFileObject.Kind _OTHERContent = default;
            private static bool _OTHERReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/JavaFileObject.Kind.html#SOURCE"/>
            /// </summary>
            public static Javax.Tools.JavaFileObject.Kind SOURCE { get { if (!_SOURCEReady) { _SOURCEContent = SGetField<Javax.Tools.JavaFileObject.Kind>(LocalBridgeClazz, "SOURCE"); _SOURCEReady = true; } return _SOURCEContent; } }
            private static Javax.Tools.JavaFileObject.Kind _SOURCEContent = default;
            private static bool _SOURCEReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/JavaFileObject.Kind.html#valueOf(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Javax.Tools.JavaFileObject.Kind"/></returns>
            public static Javax.Tools.JavaFileObject.Kind ValueOf(Java.Lang.String arg0)
            {
                return SExecuteWithSignature<Javax.Tools.JavaFileObject.Kind>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Ljavax/tools/JavaFileObject$Kind;", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/JavaFileObject.Kind.html#values()"/>
            /// </summary>
            /// <returns><see cref="Javax.Tools.JavaFileObject.Kind"/></returns>
            public static Javax.Tools.JavaFileObject.Kind[] Values()
            {
                return SExecuteWithSignatureArray<Javax.Tools.JavaFileObject.Kind>(LocalBridgeClazz, "values", "()[Ljavax/tools/JavaFileObject$Kind;");
            }

            #endregion

            #region Instance methods

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

    
        #endregion

        // TODO: complete the class
    }
    #endregion
}