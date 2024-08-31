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
    #region SimpleJavaFileObject declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/SimpleJavaFileObject.html"/>
    /// </summary>
    public partial class SimpleJavaFileObject : Javax.Tools.JavaFileObject
    {
        const string _bridgeClassName = "javax.tools.SimpleJavaFileObject";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public SimpleJavaFileObject() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public SimpleJavaFileObject(params object[] args) : base(args) { }

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

    #region SimpleJavaFileObject implementation
    public partial class SimpleJavaFileObject
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/SimpleJavaFileObject.html#getAccessLevel()"/> 
        /// </summary>
        public Javax.Lang.Model.Element.Modifier AccessLevel
        {
            get { return IExecuteWithSignature<Javax.Lang.Model.Element.Modifier>("getAccessLevel", "()Ljavax/lang/model/element/Modifier;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/SimpleJavaFileObject.html#getKind()"/> 
        /// </summary>
        public Javax.Tools.JavaFileObject.Kind Kind
        {
            get { return IExecuteWithSignature<Javax.Tools.JavaFileObject.Kind>("getKind", "()Ljavax/tools/JavaFileObject$Kind;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/SimpleJavaFileObject.html#getLastModified()"/> 
        /// </summary>
        public long LastModified
        {
            get { return IExecuteWithSignature<long>("getLastModified", "()J"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/SimpleJavaFileObject.html#getName()"/> 
        /// </summary>
        public Java.Lang.String Name
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getName", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/SimpleJavaFileObject.html#getNestingKind()"/> 
        /// </summary>
        public Javax.Lang.Model.Element.NestingKind NestingKind
        {
            get { return IExecuteWithSignature<Javax.Lang.Model.Element.NestingKind>("getNestingKind", "()Ljavax/lang/model/element/NestingKind;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/SimpleJavaFileObject.html#delete()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool Delete()
        {
            return IExecuteWithSignature<bool>("delete", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/SimpleJavaFileObject.html#isNameCompatible(java.lang.String,javax.tools.JavaFileObject.Kind)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Javax.Tools.JavaFileObject.Kind"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsNameCompatible(Java.Lang.String arg0, Javax.Tools.JavaFileObject.Kind arg1)
        {
            return IExecute<bool>("isNameCompatible", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/SimpleJavaFileObject.html#openInputStream()"/>
        /// </summary>
        /// <returns><see cref="Java.Io.InputStream"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Io.InputStream OpenInputStream()
        {
            return IExecuteWithSignature<Java.Io.InputStream>("openInputStream", "()Ljava/io/InputStream;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/SimpleJavaFileObject.html#openOutputStream()"/>
        /// </summary>
        /// <returns><see cref="Java.Io.OutputStream"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Io.OutputStream OpenOutputStream()
        {
            return IExecuteWithSignature<Java.Io.OutputStream>("openOutputStream", "()Ljava/io/OutputStream;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/SimpleJavaFileObject.html#openReader(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <returns><see cref="Java.Io.Reader"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Io.Reader OpenReader(bool arg0)
        {
            return IExecuteWithSignature<Java.Io.Reader>("openReader", "(Z)Ljava/io/Reader;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/SimpleJavaFileObject.html#openWriter()"/>
        /// </summary>
        /// <returns><see cref="Java.Io.Writer"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Io.Writer OpenWriter()
        {
            return IExecuteWithSignature<Java.Io.Writer>("openWriter", "()Ljava/io/Writer;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/SimpleJavaFileObject.html#getCharContent(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <returns><see cref="Java.Lang.CharSequence"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Lang.CharSequence GetCharContent(bool arg0)
        {
            return IExecuteWithSignature<Java.Lang.CharSequence>("getCharContent", "(Z)Ljava/lang/CharSequence;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/SimpleJavaFileObject.html#toUri()"/>
        /// </summary>
        /// <returns><see cref="Java.Net.URI"/></returns>
        public Java.Net.URI ToUri()
        {
            return IExecuteWithSignature<Java.Net.URI>("toUri", "()Ljava/net/URI;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}