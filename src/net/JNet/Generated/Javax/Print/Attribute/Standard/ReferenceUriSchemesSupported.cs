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

namespace Javax.Print.Attribute.Standard
{
    #region ReferenceUriSchemesSupported declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/ReferenceUriSchemesSupported.html"/>
    /// </summary>
    public partial class ReferenceUriSchemesSupported : Javax.Print.Attribute.EnumSyntax
    {
        const string _bridgeClassName = "javax.print.attribute.standard.ReferenceUriSchemesSupported";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public ReferenceUriSchemesSupported() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public ReferenceUriSchemesSupported(params object[] args) : base(args) { }

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

    #region ReferenceUriSchemesSupported implementation
    public partial class ReferenceUriSchemesSupported
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Print.Attribute.Standard.ReferenceUriSchemesSupported"/> to <see cref="Javax.Print.Attribute.Attribute"/>
        /// </summary>
        public static implicit operator Javax.Print.Attribute.Attribute(Javax.Print.Attribute.Standard.ReferenceUriSchemesSupported t) => t.Cast<Javax.Print.Attribute.Attribute>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/ReferenceUriSchemesSupported.html#FILE"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.ReferenceUriSchemesSupported FILE { get { if (!_FILEReady) { _FILEContent = SGetField<Javax.Print.Attribute.Standard.ReferenceUriSchemesSupported>(LocalBridgeClazz, "FILE"); _FILEReady = true; } return _FILEContent; } }
        private static Javax.Print.Attribute.Standard.ReferenceUriSchemesSupported _FILEContent = default;
        private static bool _FILEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/ReferenceUriSchemesSupported.html#FTP"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.ReferenceUriSchemesSupported FTP { get { if (!_FTPReady) { _FTPContent = SGetField<Javax.Print.Attribute.Standard.ReferenceUriSchemesSupported>(LocalBridgeClazz, "FTP"); _FTPReady = true; } return _FTPContent; } }
        private static Javax.Print.Attribute.Standard.ReferenceUriSchemesSupported _FTPContent = default;
        private static bool _FTPReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/ReferenceUriSchemesSupported.html#GOPHER"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.ReferenceUriSchemesSupported GOPHER { get { if (!_GOPHERReady) { _GOPHERContent = SGetField<Javax.Print.Attribute.Standard.ReferenceUriSchemesSupported>(LocalBridgeClazz, "GOPHER"); _GOPHERReady = true; } return _GOPHERContent; } }
        private static Javax.Print.Attribute.Standard.ReferenceUriSchemesSupported _GOPHERContent = default;
        private static bool _GOPHERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/ReferenceUriSchemesSupported.html#HTTP"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.ReferenceUriSchemesSupported HTTP { get { if (!_HTTPReady) { _HTTPContent = SGetField<Javax.Print.Attribute.Standard.ReferenceUriSchemesSupported>(LocalBridgeClazz, "HTTP"); _HTTPReady = true; } return _HTTPContent; } }
        private static Javax.Print.Attribute.Standard.ReferenceUriSchemesSupported _HTTPContent = default;
        private static bool _HTTPReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/ReferenceUriSchemesSupported.html#HTTPS"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.ReferenceUriSchemesSupported HTTPS { get { if (!_HTTPSReady) { _HTTPSContent = SGetField<Javax.Print.Attribute.Standard.ReferenceUriSchemesSupported>(LocalBridgeClazz, "HTTPS"); _HTTPSReady = true; } return _HTTPSContent; } }
        private static Javax.Print.Attribute.Standard.ReferenceUriSchemesSupported _HTTPSContent = default;
        private static bool _HTTPSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/ReferenceUriSchemesSupported.html#NEWS"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.ReferenceUriSchemesSupported NEWS { get { if (!_NEWSReady) { _NEWSContent = SGetField<Javax.Print.Attribute.Standard.ReferenceUriSchemesSupported>(LocalBridgeClazz, "NEWS"); _NEWSReady = true; } return _NEWSContent; } }
        private static Javax.Print.Attribute.Standard.ReferenceUriSchemesSupported _NEWSContent = default;
        private static bool _NEWSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/ReferenceUriSchemesSupported.html#NNTP"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.ReferenceUriSchemesSupported NNTP { get { if (!_NNTPReady) { _NNTPContent = SGetField<Javax.Print.Attribute.Standard.ReferenceUriSchemesSupported>(LocalBridgeClazz, "NNTP"); _NNTPReady = true; } return _NNTPContent; } }
        private static Javax.Print.Attribute.Standard.ReferenceUriSchemesSupported _NNTPContent = default;
        private static bool _NNTPReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/ReferenceUriSchemesSupported.html#WAIS"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.ReferenceUriSchemesSupported WAIS { get { if (!_WAISReady) { _WAISContent = SGetField<Javax.Print.Attribute.Standard.ReferenceUriSchemesSupported>(LocalBridgeClazz, "WAIS"); _WAISReady = true; } return _WAISContent; } }
        private static Javax.Print.Attribute.Standard.ReferenceUriSchemesSupported _WAISContent = default;
        private static bool _WAISReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/ReferenceUriSchemesSupported.html#getCategory()"/> 
        /// </summary>
        public Java.Lang.Class Category
        {
            get { return IExecuteWithSignature<Java.Lang.Class>("getCategory", "()Ljava/lang/Class;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/ReferenceUriSchemesSupported.html#getName()"/> 
        /// </summary>
        public Java.Lang.String Name
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getName", "()Ljava/lang/String;"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}