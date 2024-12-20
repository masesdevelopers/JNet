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

namespace Javax.Swing.Text
{
    #region Document declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Document.html"/>
    /// </summary>
    public partial class Document : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Document>
    {
        const string _bridgeClassName = "javax.swing.text.Document";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("Document class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public Document() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("Document class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public Document(params object[] args) : base(args) { }

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

    }
    #endregion

    #region IDocument
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IDocument
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Document.html#getDefaultRootElement()"/> 
        /// </summary>
        Javax.Swing.Text.Element DefaultRootElement { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Document.html#getEndPosition()"/> 
        /// </summary>
        Javax.Swing.Text.Position EndPosition { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Document.html#getLength()"/> 
        /// </summary>
        int Length { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Document.html#getRootElements()"/> 
        /// </summary>
        Javax.Swing.Text.Element[] RootElements { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Document.html#getStartPosition()"/> 
        /// </summary>
        Javax.Swing.Text.Position StartPosition { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Document.html#getProperty(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        object GetProperty(object arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Document.html#getText(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        /// <exception cref="Javax.Swing.Text.BadLocationException"/>
        Java.Lang.String GetText(int arg0, int arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Document.html#createPosition(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Javax.Swing.Text.Position"/></returns>
        /// <exception cref="Javax.Swing.Text.BadLocationException"/>
        Javax.Swing.Text.Position CreatePosition(int arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Document.html#addDocumentListener(javax.swing.event.DocumentListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.DocumentListener"/></param>
        void AddDocumentListener(Javax.Swing.Event.DocumentListener arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Document.html#addUndoableEditListener(javax.swing.event.UndoableEditListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.UndoableEditListener"/></param>
        void AddUndoableEditListener(Javax.Swing.Event.UndoableEditListener arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Document.html#getText(int,int,javax.swing.text.Segment)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Javax.Swing.Text.Segment"/></param>
        /// <exception cref="Javax.Swing.Text.BadLocationException"/>
        void GetText(int arg0, int arg1, Javax.Swing.Text.Segment arg2);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Document.html#insertString(int,java.lang.String,javax.swing.text.AttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Javax.Swing.Text.AttributeSet"/></param>
        /// <exception cref="Javax.Swing.Text.BadLocationException"/>
        void InsertString(int arg0, Java.Lang.String arg1, Javax.Swing.Text.AttributeSet arg2);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Document.html#putProperty(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        void PutProperty(object arg0, object arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Document.html#remove(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <exception cref="Javax.Swing.Text.BadLocationException"/>
        void Remove(int arg0, int arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Document.html#removeDocumentListener(javax.swing.event.DocumentListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.DocumentListener"/></param>
        void RemoveDocumentListener(Javax.Swing.Event.DocumentListener arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Document.html#removeUndoableEditListener(javax.swing.event.UndoableEditListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.UndoableEditListener"/></param>
        void RemoveUndoableEditListener(Javax.Swing.Event.UndoableEditListener arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Document.html#render(java.lang.Runnable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Runnable"/></param>
        void Render(Java.Lang.Runnable arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region Document implementation
    public partial class Document : Javax.Swing.Text.IDocument
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Document.html#StreamDescriptionProperty"/>
        /// </summary>
        public static Java.Lang.String StreamDescriptionProperty { get { if (!_StreamDescriptionPropertyReady) { _StreamDescriptionPropertyContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "StreamDescriptionProperty"); _StreamDescriptionPropertyReady = true; } return _StreamDescriptionPropertyContent; } }
        private static Java.Lang.String _StreamDescriptionPropertyContent = default;
        private static bool _StreamDescriptionPropertyReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Document.html#TitleProperty"/>
        /// </summary>
        public static Java.Lang.String TitleProperty { get { if (!_TitlePropertyReady) { _TitlePropertyContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "TitleProperty"); _TitlePropertyReady = true; } return _TitlePropertyContent; } }
        private static Java.Lang.String _TitlePropertyContent = default;
        private static bool _TitlePropertyReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Document.html#getDefaultRootElement()"/> 
        /// </summary>
        public Javax.Swing.Text.Element DefaultRootElement
        {
            get { return IExecuteWithSignature<Javax.Swing.Text.Element>("getDefaultRootElement", "()Ljavax/swing/text/Element;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Document.html#getEndPosition()"/> 
        /// </summary>
        public Javax.Swing.Text.Position EndPosition
        {
            get { return IExecuteWithSignature<Javax.Swing.Text.Position>("getEndPosition", "()Ljavax/swing/text/Position;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Document.html#getLength()"/> 
        /// </summary>
        public int Length
        {
            get { return IExecuteWithSignature<int>("getLength", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Document.html#getRootElements()"/> 
        /// </summary>
        public Javax.Swing.Text.Element[] RootElements
        {
            get { return IExecuteWithSignatureArray<Javax.Swing.Text.Element>("getRootElements", "()[Ljavax/swing/text/Element;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Document.html#getStartPosition()"/> 
        /// </summary>
        public Javax.Swing.Text.Position StartPosition
        {
            get { return IExecuteWithSignature<Javax.Swing.Text.Position>("getStartPosition", "()Ljavax/swing/text/Position;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Document.html#getProperty(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object GetProperty(object arg0)
        {
            return IExecuteWithSignature("getProperty", "(Ljava/lang/Object;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Document.html#getText(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        /// <exception cref="Javax.Swing.Text.BadLocationException"/>
        public Java.Lang.String GetText(int arg0, int arg1)
        {
            return IExecuteWithSignature<Java.Lang.String>("getText", "(II)Ljava/lang/String;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Document.html#createPosition(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Javax.Swing.Text.Position"/></returns>
        /// <exception cref="Javax.Swing.Text.BadLocationException"/>
        public Javax.Swing.Text.Position CreatePosition(int arg0)
        {
            return IExecuteWithSignature<Javax.Swing.Text.Position>("createPosition", "(I)Ljavax/swing/text/Position;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Document.html#addDocumentListener(javax.swing.event.DocumentListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.DocumentListener"/></param>
        public void AddDocumentListener(Javax.Swing.Event.DocumentListener arg0)
        {
            IExecuteWithSignature("addDocumentListener", "(Ljavax/swing/event/DocumentListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Document.html#addUndoableEditListener(javax.swing.event.UndoableEditListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.UndoableEditListener"/></param>
        public void AddUndoableEditListener(Javax.Swing.Event.UndoableEditListener arg0)
        {
            IExecuteWithSignature("addUndoableEditListener", "(Ljavax/swing/event/UndoableEditListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Document.html#getText(int,int,javax.swing.text.Segment)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Javax.Swing.Text.Segment"/></param>
        /// <exception cref="Javax.Swing.Text.BadLocationException"/>
        public void GetText(int arg0, int arg1, Javax.Swing.Text.Segment arg2)
        {
            IExecuteWithSignature("getText", "(IILjavax/swing/text/Segment;)V", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Document.html#insertString(int,java.lang.String,javax.swing.text.AttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Javax.Swing.Text.AttributeSet"/></param>
        /// <exception cref="Javax.Swing.Text.BadLocationException"/>
        public void InsertString(int arg0, Java.Lang.String arg1, Javax.Swing.Text.AttributeSet arg2)
        {
            IExecuteWithSignature("insertString", "(ILjava/lang/String;Ljavax/swing/text/AttributeSet;)V", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Document.html#putProperty(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        public void PutProperty(object arg0, object arg1)
        {
            IExecuteWithSignature("putProperty", "(Ljava/lang/Object;Ljava/lang/Object;)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Document.html#remove(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <exception cref="Javax.Swing.Text.BadLocationException"/>
        public void Remove(int arg0, int arg1)
        {
            IExecuteWithSignature("remove", "(II)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Document.html#removeDocumentListener(javax.swing.event.DocumentListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.DocumentListener"/></param>
        public void RemoveDocumentListener(Javax.Swing.Event.DocumentListener arg0)
        {
            IExecuteWithSignature("removeDocumentListener", "(Ljavax/swing/event/DocumentListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Document.html#removeUndoableEditListener(javax.swing.event.UndoableEditListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.UndoableEditListener"/></param>
        public void RemoveUndoableEditListener(Javax.Swing.Event.UndoableEditListener arg0)
        {
            IExecuteWithSignature("removeUndoableEditListener", "(Ljavax/swing/event/UndoableEditListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/Document.html#render(java.lang.Runnable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Runnable"/></param>
        public void Render(Java.Lang.Runnable arg0)
        {
            IExecuteWithSignature("render", "(Ljava/lang/Runnable;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}