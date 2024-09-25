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

namespace Javax.Swing
{
    #region CellEditor declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/CellEditor.html"/>
    /// </summary>
    public partial class CellEditor : MASES.JCOBridge.C2JBridge.JVMBridgeBase<CellEditor>
    {
        const string _bridgeClassName = "javax.swing.CellEditor";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("CellEditor class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public CellEditor() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("CellEditor class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public CellEditor(params object[] args) : base(args) { }

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

    #region ICellEditor
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface ICellEditor
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/CellEditor.html#getCellEditorValue()"/> 
        /// </summary>
        object CellEditorValue { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/CellEditor.html#isCellEditable(java.util.EventObject)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.EventObject"/></param>
        /// <returns><see cref="bool"/></returns>
        bool IsCellEditable(Java.Util.EventObject arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/CellEditor.html#shouldSelectCell(java.util.EventObject)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.EventObject"/></param>
        /// <returns><see cref="bool"/></returns>
        bool ShouldSelectCell(Java.Util.EventObject arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/CellEditor.html#stopCellEditing()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        bool StopCellEditing();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/CellEditor.html#addCellEditorListener(javax.swing.event.CellEditorListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.CellEditorListener"/></param>
        void AddCellEditorListener(Javax.Swing.Event.CellEditorListener arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/CellEditor.html#cancelCellEditing()"/>
        /// </summary>
        void CancelCellEditing();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/CellEditor.html#removeCellEditorListener(javax.swing.event.CellEditorListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.CellEditorListener"/></param>
        void RemoveCellEditorListener(Javax.Swing.Event.CellEditorListener arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region CellEditor implementation
    public partial class CellEditor : Javax.Swing.ICellEditor
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/CellEditor.html#getCellEditorValue()"/> 
        /// </summary>
        public object CellEditorValue
        {
            get { return IExecute("getCellEditorValue"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/CellEditor.html#isCellEditable(java.util.EventObject)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.EventObject"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsCellEditable(Java.Util.EventObject arg0)
        {
            return IExecute<bool>("isCellEditable", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/CellEditor.html#shouldSelectCell(java.util.EventObject)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.EventObject"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool ShouldSelectCell(Java.Util.EventObject arg0)
        {
            return IExecute<bool>("shouldSelectCell", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/CellEditor.html#stopCellEditing()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool StopCellEditing()
        {
            return IExecute<bool>("stopCellEditing");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/CellEditor.html#addCellEditorListener(javax.swing.event.CellEditorListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.CellEditorListener"/></param>
        public void AddCellEditorListener(Javax.Swing.Event.CellEditorListener arg0)
        {
            IExecute("addCellEditorListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/CellEditor.html#cancelCellEditing()"/>
        /// </summary>
        public void CancelCellEditing()
        {
            IExecute("cancelCellEditing");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/CellEditor.html#removeCellEditorListener(javax.swing.event.CellEditorListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.CellEditorListener"/></param>
        public void RemoveCellEditorListener(Javax.Swing.Event.CellEditorListener arg0)
        {
            IExecute("removeCellEditorListener", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}