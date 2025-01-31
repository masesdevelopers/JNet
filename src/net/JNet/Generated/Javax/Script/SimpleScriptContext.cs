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
*  This file is generated by MASES.JNetReflector (ver. 2.5.11.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Script
{
    #region SimpleScriptContext declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/SimpleScriptContext.html"/>
    /// </summary>
    public partial class SimpleScriptContext : Javax.Script.ScriptContext
    {
        const string _bridgeClassName = "javax.script.SimpleScriptContext";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public SimpleScriptContext() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public SimpleScriptContext(params object[] args) : base(args) { }

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

    #region SimpleScriptContext implementation
    public partial class SimpleScriptContext
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/SimpleScriptContext.html#getErrorWriter()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/SimpleScriptContext.html#setErrorWriter(java.io.Writer)"/>
        /// </summary>
        public Java.Io.Writer ErrorWriter
        {
            get { return IExecuteWithSignature<Java.Io.Writer>("getErrorWriter", "()Ljava/io/Writer;"); } set { IExecuteWithSignature("setErrorWriter", "(Ljava/io/Writer;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/SimpleScriptContext.html#getReader()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/SimpleScriptContext.html#setReader(java.io.Reader)"/>
        /// </summary>
        public Java.Io.Reader Reader
        {
            get { return IExecuteWithSignature<Java.Io.Reader>("getReader", "()Ljava/io/Reader;"); } set { IExecuteWithSignature("setReader", "(Ljava/io/Reader;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/SimpleScriptContext.html#getScopes()"/> 
        /// </summary>
        public Java.Util.List<Java.Lang.Integer> Scopes
        {
            get { return IExecuteWithSignature<Java.Util.List<Java.Lang.Integer>>("getScopes", "()Ljava/util/List;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/SimpleScriptContext.html#getWriter()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/SimpleScriptContext.html#setWriter(java.io.Writer)"/>
        /// </summary>
        public Java.Io.Writer Writer
        {
            get { return IExecuteWithSignature<Java.Io.Writer>("getWriter", "()Ljava/io/Writer;"); } set { IExecuteWithSignature("setWriter", "(Ljava/io/Writer;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/SimpleScriptContext.html#getAttributesScope(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetAttributesScope(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<int>("getAttributesScope", "(Ljava/lang/String;)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/SimpleScriptContext.html#getAttribute(java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="object"/></returns>
        public object GetAttribute(Java.Lang.String arg0, int arg1)
        {
            return IExecuteWithSignature("getAttribute", "(Ljava/lang/String;I)Ljava/lang/Object;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/SimpleScriptContext.html#getAttribute(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="object"/></returns>
        public object GetAttribute(Java.Lang.String arg0)
        {
            return IExecuteWithSignature("getAttribute", "(Ljava/lang/String;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/SimpleScriptContext.html#removeAttribute(java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="object"/></returns>
        public object RemoveAttribute(Java.Lang.String arg0, int arg1)
        {
            return IExecuteWithSignature("removeAttribute", "(Ljava/lang/String;I)Ljava/lang/Object;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/SimpleScriptContext.html#getBindings(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Javax.Script.Bindings"/></returns>
        public Javax.Script.Bindings GetBindings(int arg0)
        {
            return IExecuteWithSignature<Javax.Script.Bindings>("getBindings", "(I)Ljavax/script/Bindings;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/SimpleScriptContext.html#setAttribute(java.lang.String,java.lang.Object,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public void SetAttribute(Java.Lang.String arg0, object arg1, int arg2)
        {
            IExecuteWithSignature("setAttribute", "(Ljava/lang/String;Ljava/lang/Object;I)V", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.scripting/javax/script/SimpleScriptContext.html#setBindings(javax.script.Bindings,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Script.Bindings"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void SetBindings(Javax.Script.Bindings arg0, int arg1)
        {
            IExecuteWithSignature("setBindings", "(Ljavax/script/Bindings;I)V", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}