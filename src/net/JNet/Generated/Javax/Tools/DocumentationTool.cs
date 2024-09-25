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

namespace Javax.Tools
{
    #region DocumentationTool declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/DocumentationTool.html"/>
    /// </summary>
    public partial class DocumentationTool : MASES.JCOBridge.C2JBridge.JVMBridgeBase<DocumentationTool>
    {
        const string _bridgeClassName = "javax.tools.DocumentationTool";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("DocumentationTool class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public DocumentationTool() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("DocumentationTool class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public DocumentationTool(params object[] args) : base(args) { }

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
        #region DocumentationTask declaration
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/DocumentationTool.DocumentationTask.html"/>
        /// </summary>
        public partial class DocumentationTask : Java.Util.Concurrent.Callable<Java.Lang.Boolean>
        {
            const string _bridgeClassName = "javax.tools.DocumentationTool$DocumentationTask";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            [global::System.Obsolete("DocumentationTask class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
            public DocumentationTask() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            [global::System.Obsolete("DocumentationTask class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
            public DocumentationTask(params object[] args) : base(args) { }

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
            public override bool IsBridgeStatic => true;

            // TODO: complete the class

        }
        #endregion

        #region Location declaration
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/DocumentationTool.Location.html"/>
        /// </summary>
        public partial class Location : Java.Lang.Enum<Javax.Tools.DocumentationTool.Location>
        {
            const string _bridgeClassName = "javax.tools.DocumentationTool$Location";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public Location() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public Location(params object[] args) : base(args) { }

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

    #region IDocumentationTool
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IDocumentationTool
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region DocumentationTool implementation
    public partial class DocumentationTool : Javax.Tools.IDocumentationTool
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Tools.DocumentationTool"/> to <see cref="Javax.Tools.Tool"/>
        /// </summary>
        public static implicit operator Javax.Tools.Tool(Javax.Tools.DocumentationTool t) => t.Cast<Javax.Tools.Tool>();
        /// <summary>
        /// Converter from <see cref="Javax.Tools.DocumentationTool"/> to <see cref="Javax.Tools.OptionChecker"/>
        /// </summary>
        public static implicit operator Javax.Tools.OptionChecker(Javax.Tools.DocumentationTool t) => t.Cast<Javax.Tools.OptionChecker>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes
        #region DocumentationTask implementation
        public partial class DocumentationTask
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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/DocumentationTool.DocumentationTask.html#addModules(java.lang.Iterable)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.Iterable"/></param>
            public void AddModules(Java.Lang.Iterable<Java.Lang.String> arg0)
            {
                IExecuteWithSignature("addModules", "(Ljava/lang/Iterable;)V", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/DocumentationTool.DocumentationTask.html#setLocale(java.util.Locale)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
            public void SetLocale(Java.Util.Locale arg0)
            {
                IExecuteWithSignature("setLocale", "(Ljava/util/Locale;)V", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/DocumentationTool.DocumentationTask.html#call()"/>
            /// </summary>
            /// <returns><see cref="object"/></returns>
            /// <exception cref="Java.Lang.Exception"/>
            public object Call()
            {
                return IExecuteWithSignature("call", "()Ljava/lang/Object;");
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region Location implementation
        public partial class Location
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/DocumentationTool.Location.html#DOCLET_PATH"/>
            /// </summary>
            public static Javax.Tools.DocumentationTool.Location DOCLET_PATH { get { if (!_DOCLET_PATHReady) { _DOCLET_PATHContent = SGetField<Javax.Tools.DocumentationTool.Location>(LocalBridgeClazz, "DOCLET_PATH"); _DOCLET_PATHReady = true; } return _DOCLET_PATHContent; } }
            private static Javax.Tools.DocumentationTool.Location _DOCLET_PATHContent = default;
            private static bool _DOCLET_PATHReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/DocumentationTool.Location.html#DOCUMENTATION_OUTPUT"/>
            /// </summary>
            public static Javax.Tools.DocumentationTool.Location DOCUMENTATION_OUTPUT { get { if (!_DOCUMENTATION_OUTPUTReady) { _DOCUMENTATION_OUTPUTContent = SGetField<Javax.Tools.DocumentationTool.Location>(LocalBridgeClazz, "DOCUMENTATION_OUTPUT"); _DOCUMENTATION_OUTPUTReady = true; } return _DOCUMENTATION_OUTPUTContent; } }
            private static Javax.Tools.DocumentationTool.Location _DOCUMENTATION_OUTPUTContent = default;
            private static bool _DOCUMENTATION_OUTPUTReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/DocumentationTool.Location.html#TAGLET_PATH"/>
            /// </summary>
            public static Javax.Tools.DocumentationTool.Location TAGLET_PATH { get { if (!_TAGLET_PATHReady) { _TAGLET_PATHContent = SGetField<Javax.Tools.DocumentationTool.Location>(LocalBridgeClazz, "TAGLET_PATH"); _TAGLET_PATHReady = true; } return _TAGLET_PATHContent; } }
            private static Javax.Tools.DocumentationTool.Location _TAGLET_PATHContent = default;
            private static bool _TAGLET_PATHReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/DocumentationTool.Location.html#valueOf(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Javax.Tools.DocumentationTool.Location"/></returns>
            public static Javax.Tools.DocumentationTool.Location ValueOf(Java.Lang.String arg0)
            {
                return SExecute<Javax.Tools.DocumentationTool.Location>(LocalBridgeClazz, "valueOf", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/DocumentationTool.Location.html#values()"/>
            /// </summary>
            /// <returns><see cref="Javax.Tools.DocumentationTool.Location"/></returns>
            public static Javax.Tools.DocumentationTool.Location[] Values()
            {
                return SExecuteArray<Javax.Tools.DocumentationTool.Location>(LocalBridgeClazz, "values");
            }

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/DocumentationTool.Location.html#getName()"/> 
            /// </summary>
            public Java.Lang.String Name
            {
                get { return IExecute<Java.Lang.String>("getName"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/DocumentationTool.Location.html#isOutputLocation()"/>
            /// </summary>
            /// <returns><see cref="bool"/></returns>
            public bool IsOutputLocation()
            {
                return IExecute<bool>("isOutputLocation");
            }

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