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
*  This file is generated by MASES.JNetReflector (ver. 2.5.10.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Swing.Text
{
    #region EditorKit declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/EditorKit.html"/>
    /// </summary>
    public partial class EditorKit : MASES.JCOBridge.C2JBridge.JVMBridgeBase<EditorKit>
    {
        const string _bridgeClassName = "javax.swing.text.EditorKit";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("EditorKit class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public EditorKit() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("EditorKit class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public EditorKit(params object[] args) : base(args) { }

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
        public override bool IsBridgeInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region EditorKit implementation
    public partial class EditorKit
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Swing.Text.EditorKit"/> to <see cref="Java.Lang.Cloneable"/>
        /// </summary>
        public static implicit operator Java.Lang.Cloneable(Javax.Swing.Text.EditorKit t) => t.Cast<Java.Lang.Cloneable>();
        /// <summary>
        /// Converter from <see cref="Javax.Swing.Text.EditorKit"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Javax.Swing.Text.EditorKit t) => t.Cast<Java.Io.Serializable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/EditorKit.html#getActions()"/> 
        /// </summary>
        public Javax.Swing.Action[] Actions
        {
            get { return IExecuteWithSignatureArray<Javax.Swing.Action>("getActions", "()[Ljavax/swing/Action;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/EditorKit.html#getContentType()"/> 
        /// </summary>
        public Java.Lang.String ContentType
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getContentType", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/EditorKit.html#getViewFactory()"/> 
        /// </summary>
        public Javax.Swing.Text.ViewFactory ViewFactory
        {
            get { return IExecuteWithSignature<Javax.Swing.Text.ViewFactory>("getViewFactory", "()Ljavax/swing/text/ViewFactory;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/EditorKit.html#createCaret()"/>
        /// </summary>
        /// <returns><see cref="Javax.Swing.Text.Caret"/></returns>
        public Javax.Swing.Text.Caret CreateCaret()
        {
            return IExecuteWithSignature<Javax.Swing.Text.Caret>("createCaret", "()Ljavax/swing/text/Caret;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/EditorKit.html#createDefaultDocument()"/>
        /// </summary>
        /// <returns><see cref="Javax.Swing.Text.Document"/></returns>
        public Javax.Swing.Text.Document CreateDefaultDocument()
        {
            return IExecuteWithSignature<Javax.Swing.Text.Document>("createDefaultDocument", "()Ljavax/swing/text/Document;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/EditorKit.html#read(java.io.InputStream,javax.swing.text.Document,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.InputStream"/></param>
        /// <param name="arg1"><see cref="Javax.Swing.Text.Document"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <exception cref="Java.Io.IOException"/>
        /// <exception cref="Javax.Swing.Text.BadLocationException"/>
        public void Read(Java.Io.InputStream arg0, Javax.Swing.Text.Document arg1, int arg2)
        {
            IExecuteWithSignature("read", "(Ljava/io/InputStream;Ljavax/swing/text/Document;I)V", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/EditorKit.html#read(java.io.Reader,javax.swing.text.Document,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.Reader"/></param>
        /// <param name="arg1"><see cref="Javax.Swing.Text.Document"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <exception cref="Java.Io.IOException"/>
        /// <exception cref="Javax.Swing.Text.BadLocationException"/>
        public void Read(Java.Io.Reader arg0, Javax.Swing.Text.Document arg1, int arg2)
        {
            IExecuteWithSignature("read", "(Ljava/io/Reader;Ljavax/swing/text/Document;I)V", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/EditorKit.html#write(java.io.OutputStream,javax.swing.text.Document,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.OutputStream"/></param>
        /// <param name="arg1"><see cref="Javax.Swing.Text.Document"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <exception cref="Java.Io.IOException"/>
        /// <exception cref="Javax.Swing.Text.BadLocationException"/>
        public void Write(Java.Io.OutputStream arg0, Javax.Swing.Text.Document arg1, int arg2, int arg3)
        {
            IExecuteWithSignature("write", "(Ljava/io/OutputStream;Ljavax/swing/text/Document;II)V", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/EditorKit.html#write(java.io.Writer,javax.swing.text.Document,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.Writer"/></param>
        /// <param name="arg1"><see cref="Javax.Swing.Text.Document"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <exception cref="Java.Io.IOException"/>
        /// <exception cref="Javax.Swing.Text.BadLocationException"/>
        public void Write(Java.Io.Writer arg0, Javax.Swing.Text.Document arg1, int arg2, int arg3)
        {
            IExecuteWithSignature("write", "(Ljava/io/Writer;Ljavax/swing/text/Document;II)V", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/EditorKit.html#deinstall(javax.swing.JEditorPane)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JEditorPane"/></param>
        public void Deinstall(Javax.Swing.JEditorPane arg0)
        {
            IExecuteWithSignature("deinstall", "(Ljavax/swing/JEditorPane;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/EditorKit.html#install(javax.swing.JEditorPane)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JEditorPane"/></param>
        public void Install(Javax.Swing.JEditorPane arg0)
        {
            IExecuteWithSignature("install", "(Ljavax/swing/JEditorPane;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}