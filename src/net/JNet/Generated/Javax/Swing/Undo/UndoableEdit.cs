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

namespace Javax.Swing.Undo
{
    #region UndoableEdit declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/undo/UndoableEdit.html"/>
    /// </summary>
    public partial class UndoableEdit : MASES.JCOBridge.C2JBridge.JVMBridgeBase<UndoableEdit>
    {
        const string _bridgeClassName = "javax.swing.undo.UndoableEdit";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("UndoableEdit class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public UndoableEdit() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("UndoableEdit class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public UndoableEdit(params object[] args) : base(args) { }

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

    #region IUndoableEdit
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IUndoableEdit
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/undo/UndoableEdit.html#getPresentationName()"/> 
        /// </summary>
        Java.Lang.String PresentationName { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/undo/UndoableEdit.html#getRedoPresentationName()"/> 
        /// </summary>
        Java.Lang.String RedoPresentationName { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/undo/UndoableEdit.html#getUndoPresentationName()"/> 
        /// </summary>
        Java.Lang.String UndoPresentationName { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/undo/UndoableEdit.html#addEdit(javax.swing.undo.UndoableEdit)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Undo.UndoableEdit"/></param>
        /// <returns><see cref="bool"/></returns>
        bool AddEdit(Javax.Swing.Undo.UndoableEdit arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/undo/UndoableEdit.html#canRedo()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        bool CanRedo();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/undo/UndoableEdit.html#canUndo()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        bool CanUndo();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/undo/UndoableEdit.html#isSignificant()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        bool IsSignificant();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/undo/UndoableEdit.html#replaceEdit(javax.swing.undo.UndoableEdit)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Undo.UndoableEdit"/></param>
        /// <returns><see cref="bool"/></returns>
        bool ReplaceEdit(Javax.Swing.Undo.UndoableEdit arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/undo/UndoableEdit.html#die()"/>
        /// </summary>
        void Die();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/undo/UndoableEdit.html#redo()"/>
        /// </summary>
        /// <exception cref="Javax.Swing.Undo.CannotRedoException"/>
        void Redo();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/undo/UndoableEdit.html#undo()"/>
        /// </summary>
        /// <exception cref="Javax.Swing.Undo.CannotUndoException"/>
        void Undo();

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region UndoableEdit implementation
    public partial class UndoableEdit : Javax.Swing.Undo.IUndoableEdit
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/undo/UndoableEdit.html#getPresentationName()"/> 
        /// </summary>
        public Java.Lang.String PresentationName
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getPresentationName", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/undo/UndoableEdit.html#getRedoPresentationName()"/> 
        /// </summary>
        public Java.Lang.String RedoPresentationName
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getRedoPresentationName", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/undo/UndoableEdit.html#getUndoPresentationName()"/> 
        /// </summary>
        public Java.Lang.String UndoPresentationName
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getUndoPresentationName", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/undo/UndoableEdit.html#addEdit(javax.swing.undo.UndoableEdit)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Undo.UndoableEdit"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool AddEdit(Javax.Swing.Undo.UndoableEdit arg0)
        {
            return IExecuteWithSignature<bool>("addEdit", "(Ljavax/swing/undo/UndoableEdit;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/undo/UndoableEdit.html#canRedo()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool CanRedo()
        {
            return IExecuteWithSignature<bool>("canRedo", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/undo/UndoableEdit.html#canUndo()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool CanUndo()
        {
            return IExecuteWithSignature<bool>("canUndo", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/undo/UndoableEdit.html#isSignificant()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsSignificant()
        {
            return IExecuteWithSignature<bool>("isSignificant", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/undo/UndoableEdit.html#replaceEdit(javax.swing.undo.UndoableEdit)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Undo.UndoableEdit"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool ReplaceEdit(Javax.Swing.Undo.UndoableEdit arg0)
        {
            return IExecuteWithSignature<bool>("replaceEdit", "(Ljavax/swing/undo/UndoableEdit;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/undo/UndoableEdit.html#die()"/>
        /// </summary>
        public void Die()
        {
            IExecuteWithSignature("die", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/undo/UndoableEdit.html#redo()"/>
        /// </summary>
        /// <exception cref="Javax.Swing.Undo.CannotRedoException"/>
        public void Redo()
        {
            IExecuteWithSignature("redo", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/undo/UndoableEdit.html#undo()"/>
        /// </summary>
        /// <exception cref="Javax.Swing.Undo.CannotUndoException"/>
        public void Undo()
        {
            IExecuteWithSignature("undo", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}