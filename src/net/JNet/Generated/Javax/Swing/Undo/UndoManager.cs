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
*  This file is generated by MASES.JNetReflector (ver. 2.5.3.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Swing.Undo
{
    #region UndoManager
    public partial class UndoManager
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Swing.Undo.UndoManager"/> to <see cref="Javax.Swing.Event.UndoableEditListener"/>
        /// </summary>
        public static implicit operator Javax.Swing.Event.UndoableEditListener(Javax.Swing.Undo.UndoManager t) => t.Cast<Javax.Swing.Event.UndoableEditListener>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/undo/UndoManager.html#getLimit()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/undo/UndoManager.html#setLimit(int)"/>
        /// </summary>
        public int Limit
        {
            get { return IExecuteWithSignature<int>("getLimit", "()I"); } set { IExecuteWithSignature("setLimit", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/undo/UndoManager.html#getUndoOrRedoPresentationName()"/> 
        /// </summary>
        public Java.Lang.String UndoOrRedoPresentationName
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getUndoOrRedoPresentationName", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/undo/UndoManager.html#canUndoOrRedo()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool CanUndoOrRedo()
        {
            return IExecuteWithSignature<bool>("canUndoOrRedo", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/undo/UndoManager.html#discardAllEdits()"/>
        /// </summary>
        public void DiscardAllEdits()
        {
            IExecuteWithSignature("discardAllEdits", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/undo/UndoManager.html#undoableEditHappened(javax.swing.event.UndoableEditEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.UndoableEditEvent"/></param>
        public void UndoableEditHappened(Javax.Swing.Event.UndoableEditEvent arg0)
        {
            IExecuteWithSignature("undoableEditHappened", "(Ljavax/swing/event/UndoableEditEvent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/undo/UndoManager.html#undoOrRedo()"/>
        /// </summary>
        /// <exception cref="Javax.Swing.Undo.CannotRedoException"/>
        /// <exception cref="Javax.Swing.Undo.CannotUndoException"/>
        public void UndoOrRedo()
        {
            IExecuteWithSignature("undoOrRedo", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}