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

namespace Javax.Swing.Tree
{
    #region DefaultTreeSelectionModel declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeSelectionModel.html"/>
    /// </summary>
    public partial class DefaultTreeSelectionModel : MASES.JCOBridge.C2JBridge.JVMBridgeBase<DefaultTreeSelectionModel>
    {
        const string _bridgeClassName = "javax.swing.tree.DefaultTreeSelectionModel";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public DefaultTreeSelectionModel() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public DefaultTreeSelectionModel(params object[] args) : base(args) { }

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

    #region DefaultTreeSelectionModel implementation
    public partial class DefaultTreeSelectionModel
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Swing.Tree.DefaultTreeSelectionModel"/> to <see cref="Java.Lang.Cloneable"/>
        /// </summary>
        public static implicit operator Java.Lang.Cloneable(Javax.Swing.Tree.DefaultTreeSelectionModel t) => t.Cast<Java.Lang.Cloneable>();
        /// <summary>
        /// Converter from <see cref="Javax.Swing.Tree.DefaultTreeSelectionModel"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Javax.Swing.Tree.DefaultTreeSelectionModel t) => t.Cast<Java.Io.Serializable>();
        /// <summary>
        /// Converter from <see cref="Javax.Swing.Tree.DefaultTreeSelectionModel"/> to <see cref="Javax.Swing.Tree.TreeSelectionModel"/>
        /// </summary>
        public static implicit operator Javax.Swing.Tree.TreeSelectionModel(Javax.Swing.Tree.DefaultTreeSelectionModel t) => t.Cast<Javax.Swing.Tree.TreeSelectionModel>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeSelectionModel.html#SELECTION_MODE_PROPERTY"/>
        /// </summary>
        public static Java.Lang.String SELECTION_MODE_PROPERTY { get { if (!_SELECTION_MODE_PROPERTYReady) { _SELECTION_MODE_PROPERTYContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "SELECTION_MODE_PROPERTY"); _SELECTION_MODE_PROPERTYReady = true; } return _SELECTION_MODE_PROPERTYContent; } }
        private static Java.Lang.String _SELECTION_MODE_PROPERTYContent = default;
        private static bool _SELECTION_MODE_PROPERTYReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeSelectionModel.html#getLeadSelectionPath()"/> 
        /// </summary>
        public Javax.Swing.Tree.TreePath LeadSelectionPath
        {
            get { return IExecuteWithSignature<Javax.Swing.Tree.TreePath>("getLeadSelectionPath", "()Ljavax/swing/tree/TreePath;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeSelectionModel.html#getLeadSelectionRow()"/> 
        /// </summary>
        public int LeadSelectionRow
        {
            get { return IExecuteWithSignature<int>("getLeadSelectionRow", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeSelectionModel.html#getMaxSelectionRow()"/> 
        /// </summary>
        public int MaxSelectionRow
        {
            get { return IExecuteWithSignature<int>("getMaxSelectionRow", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeSelectionModel.html#getMinSelectionRow()"/> 
        /// </summary>
        public int MinSelectionRow
        {
            get { return IExecuteWithSignature<int>("getMinSelectionRow", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeSelectionModel.html#getPropertyChangeListeners()"/> 
        /// </summary>
        public Java.Beans.PropertyChangeListener[] PropertyChangeListeners
        {
            get { return IExecuteWithSignatureArray<Java.Beans.PropertyChangeListener>("getPropertyChangeListeners", "()[Ljava/beans/PropertyChangeListener;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeSelectionModel.html#getRowMapper()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeSelectionModel.html#setRowMapper(javax.swing.tree.RowMapper)"/>
        /// </summary>
        public Javax.Swing.Tree.RowMapper RowMapper
        {
            get { return IExecuteWithSignature<Javax.Swing.Tree.RowMapper>("getRowMapper", "()Ljavax/swing/tree/RowMapper;"); } set { IExecuteWithSignature("setRowMapper", "(Ljavax/swing/tree/RowMapper;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeSelectionModel.html#getSelectionCount()"/> 
        /// </summary>
        public int SelectionCount
        {
            get { return IExecuteWithSignature<int>("getSelectionCount", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeSelectionModel.html#getSelectionMode()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeSelectionModel.html#setSelectionMode(int)"/>
        /// </summary>
        public int SelectionMode
        {
            get { return IExecuteWithSignature<int>("getSelectionMode", "()I"); } set { IExecuteWithSignature("setSelectionMode", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeSelectionModel.html#getSelectionPath()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeSelectionModel.html#setSelectionPath(javax.swing.tree.TreePath)"/>
        /// </summary>
        public Javax.Swing.Tree.TreePath SelectionPath
        {
            get { return IExecuteWithSignature<Javax.Swing.Tree.TreePath>("getSelectionPath", "()Ljavax/swing/tree/TreePath;"); } set { IExecuteWithSignature("setSelectionPath", "(Ljavax/swing/tree/TreePath;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeSelectionModel.html#getSelectionPaths()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeSelectionModel.html#setSelectionPaths(javax.swing.tree.TreePath[])"/>
        /// </summary>
        public Javax.Swing.Tree.TreePath[] SelectionPaths
        {
            get { return IExecuteWithSignatureArray<Javax.Swing.Tree.TreePath>("getSelectionPaths", "()[Ljavax/swing/tree/TreePath;"); } set { IExecuteWithSignature("setSelectionPaths", "([Ljavax/swing/tree/TreePath;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeSelectionModel.html#getSelectionRows()"/> 
        /// </summary>
        public int[] SelectionRows
        {
            get { return IExecuteWithSignatureArray<int>("getSelectionRows", "()[I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeSelectionModel.html#getTreeSelectionListeners()"/> 
        /// </summary>
        public Javax.Swing.Event.TreeSelectionListener[] TreeSelectionListeners
        {
            get { return IExecuteWithSignatureArray<Javax.Swing.Event.TreeSelectionListener>("getTreeSelectionListeners", "()[Ljavax/swing/event/TreeSelectionListener;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeSelectionModel.html#getListeners(java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <typeparam name="T"><see cref="Java.Util.IEventListener"/></typeparam>
        /// <returns><typeparamref name="T"/></returns>
        public T[] GetListeners<T>(Java.Lang.Class arg0) where T : Java.Util.IEventListener, new()
        {
            return IExecuteArray<T>("getListeners", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeSelectionModel.html#isPathSelected(javax.swing.tree.TreePath)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Tree.TreePath"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsPathSelected(Javax.Swing.Tree.TreePath arg0)
        {
            return IExecuteWithSignature<bool>("isPathSelected", "(Ljavax/swing/tree/TreePath;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeSelectionModel.html#isRowSelected(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsRowSelected(int arg0)
        {
            return IExecuteWithSignature<bool>("isRowSelected", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeSelectionModel.html#isSelectionEmpty()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsSelectionEmpty()
        {
            return IExecuteWithSignature<bool>("isSelectionEmpty", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeSelectionModel.html#addPropertyChangeListener(java.beans.PropertyChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Beans.PropertyChangeListener"/></param>
        public void AddPropertyChangeListener(Java.Beans.PropertyChangeListener arg0)
        {
            IExecuteWithSignature("addPropertyChangeListener", "(Ljava/beans/PropertyChangeListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeSelectionModel.html#removePropertyChangeListener(java.beans.PropertyChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Beans.PropertyChangeListener"/></param>
        public void RemovePropertyChangeListener(Java.Beans.PropertyChangeListener arg0)
        {
            IExecuteWithSignature("removePropertyChangeListener", "(Ljava/beans/PropertyChangeListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeSelectionModel.html#addSelectionPath(javax.swing.tree.TreePath)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Tree.TreePath"/></param>
        public void AddSelectionPath(Javax.Swing.Tree.TreePath arg0)
        {
            IExecuteWithSignature("addSelectionPath", "(Ljavax/swing/tree/TreePath;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeSelectionModel.html#addSelectionPaths(javax.swing.tree.TreePath[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Tree.TreePath"/></param>
        public void AddSelectionPaths(Javax.Swing.Tree.TreePath[] arg0)
        {
            IExecuteWithSignature("addSelectionPaths", "([Ljavax/swing/tree/TreePath;)V", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeSelectionModel.html#addTreeSelectionListener(javax.swing.event.TreeSelectionListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.TreeSelectionListener"/></param>
        public void AddTreeSelectionListener(Javax.Swing.Event.TreeSelectionListener arg0)
        {
            IExecuteWithSignature("addTreeSelectionListener", "(Ljavax/swing/event/TreeSelectionListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeSelectionModel.html#clearSelection()"/>
        /// </summary>
        public void ClearSelection()
        {
            IExecuteWithSignature("clearSelection", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeSelectionModel.html#removeSelectionPath(javax.swing.tree.TreePath)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Tree.TreePath"/></param>
        public void RemoveSelectionPath(Javax.Swing.Tree.TreePath arg0)
        {
            IExecuteWithSignature("removeSelectionPath", "(Ljavax/swing/tree/TreePath;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeSelectionModel.html#removeSelectionPaths(javax.swing.tree.TreePath[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Tree.TreePath"/></param>
        public void RemoveSelectionPaths(Javax.Swing.Tree.TreePath[] arg0)
        {
            IExecuteWithSignature("removeSelectionPaths", "([Ljavax/swing/tree/TreePath;)V", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeSelectionModel.html#removeTreeSelectionListener(javax.swing.event.TreeSelectionListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.TreeSelectionListener"/></param>
        public void RemoveTreeSelectionListener(Javax.Swing.Event.TreeSelectionListener arg0)
        {
            IExecuteWithSignature("removeTreeSelectionListener", "(Ljavax/swing/event/TreeSelectionListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeSelectionModel.html#resetRowSelection()"/>
        /// </summary>
        public void ResetRowSelection()
        {
            IExecuteWithSignature("resetRowSelection", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}