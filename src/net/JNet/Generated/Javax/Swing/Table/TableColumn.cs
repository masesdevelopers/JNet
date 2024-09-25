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

namespace Javax.Swing.Table
{
    #region TableColumn declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/TableColumn.html"/>
    /// </summary>
    public partial class TableColumn : Java.Io.Serializable
    {
        const string _bridgeClassName = "javax.swing.table.TableColumn";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public TableColumn() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public TableColumn(params object[] args) : base(args) { }

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

    #region TableColumn implementation
    public partial class TableColumn
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/TableColumn.html#%3Cinit%3E(int,int,javax.swing.table.TableCellRenderer,javax.swing.table.TableCellEditor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Javax.Swing.Table.TableCellRenderer"/></param>
        /// <param name="arg3"><see cref="Javax.Swing.Table.TableCellEditor"/></param>
        public TableColumn(int arg0, int arg1, Javax.Swing.Table.TableCellRenderer arg2, Javax.Swing.Table.TableCellEditor arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/TableColumn.html#%3Cinit%3E(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public TableColumn(int arg0, int arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/TableColumn.html#%3Cinit%3E(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public TableColumn(int arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/TableColumn.html#CELL_RENDERER_PROPERTY"/>
        /// </summary>
        public static Java.Lang.String CELL_RENDERER_PROPERTY { get { if (!_CELL_RENDERER_PROPERTYReady) { _CELL_RENDERER_PROPERTYContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "CELL_RENDERER_PROPERTY"); _CELL_RENDERER_PROPERTYReady = true; } return _CELL_RENDERER_PROPERTYContent; } }
        private static Java.Lang.String _CELL_RENDERER_PROPERTYContent = default;
        private static bool _CELL_RENDERER_PROPERTYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/TableColumn.html#COLUMN_WIDTH_PROPERTY"/>
        /// </summary>
        public static Java.Lang.String COLUMN_WIDTH_PROPERTY { get { if (!_COLUMN_WIDTH_PROPERTYReady) { _COLUMN_WIDTH_PROPERTYContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "COLUMN_WIDTH_PROPERTY"); _COLUMN_WIDTH_PROPERTYReady = true; } return _COLUMN_WIDTH_PROPERTYContent; } }
        private static Java.Lang.String _COLUMN_WIDTH_PROPERTYContent = default;
        private static bool _COLUMN_WIDTH_PROPERTYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/TableColumn.html#HEADER_RENDERER_PROPERTY"/>
        /// </summary>
        public static Java.Lang.String HEADER_RENDERER_PROPERTY { get { if (!_HEADER_RENDERER_PROPERTYReady) { _HEADER_RENDERER_PROPERTYContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "HEADER_RENDERER_PROPERTY"); _HEADER_RENDERER_PROPERTYReady = true; } return _HEADER_RENDERER_PROPERTYContent; } }
        private static Java.Lang.String _HEADER_RENDERER_PROPERTYContent = default;
        private static bool _HEADER_RENDERER_PROPERTYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/TableColumn.html#HEADER_VALUE_PROPERTY"/>
        /// </summary>
        public static Java.Lang.String HEADER_VALUE_PROPERTY { get { if (!_HEADER_VALUE_PROPERTYReady) { _HEADER_VALUE_PROPERTYContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "HEADER_VALUE_PROPERTY"); _HEADER_VALUE_PROPERTYReady = true; } return _HEADER_VALUE_PROPERTYContent; } }
        private static Java.Lang.String _HEADER_VALUE_PROPERTYContent = default;
        private static bool _HEADER_VALUE_PROPERTYReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/TableColumn.html#getCellEditor()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/TableColumn.html#setCellEditor(javax.swing.table.TableCellEditor)"/>
        /// </summary>
        public Javax.Swing.Table.TableCellEditor CellEditor
        {
            get { return IExecute<Javax.Swing.Table.TableCellEditor>("getCellEditor"); } set { IExecute("setCellEditor", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/TableColumn.html#getCellRenderer()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/TableColumn.html#setCellRenderer(javax.swing.table.TableCellRenderer)"/>
        /// </summary>
        public Javax.Swing.Table.TableCellRenderer CellRenderer
        {
            get { return IExecute<Javax.Swing.Table.TableCellRenderer>("getCellRenderer"); } set { IExecute("setCellRenderer", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/TableColumn.html#getHeaderRenderer()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/TableColumn.html#setHeaderRenderer(javax.swing.table.TableCellRenderer)"/>
        /// </summary>
        public Javax.Swing.Table.TableCellRenderer HeaderRenderer
        {
            get { return IExecute<Javax.Swing.Table.TableCellRenderer>("getHeaderRenderer"); } set { IExecute("setHeaderRenderer", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/TableColumn.html#getHeaderValue()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/TableColumn.html#setHeaderValue(java.lang.Object)"/>
        /// </summary>
        public object HeaderValue
        {
            get { return IExecute("getHeaderValue"); } set { IExecute("setHeaderValue", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/TableColumn.html#getIdentifier()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/TableColumn.html#setIdentifier(java.lang.Object)"/>
        /// </summary>
        public object Identifier
        {
            get { return IExecute("getIdentifier"); } set { IExecute("setIdentifier", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/TableColumn.html#getMaxWidth()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/TableColumn.html#setMaxWidth(int)"/>
        /// </summary>
        public int MaxWidth
        {
            get { return IExecute<int>("getMaxWidth"); } set { IExecute("setMaxWidth", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/TableColumn.html#getMinWidth()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/TableColumn.html#setMinWidth(int)"/>
        /// </summary>
        public int MinWidth
        {
            get { return IExecute<int>("getMinWidth"); } set { IExecute("setMinWidth", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/TableColumn.html#getModelIndex()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/TableColumn.html#setModelIndex(int)"/>
        /// </summary>
        public int ModelIndex
        {
            get { return IExecute<int>("getModelIndex"); } set { IExecute("setModelIndex", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/TableColumn.html#getPreferredWidth()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/TableColumn.html#setPreferredWidth(int)"/>
        /// </summary>
        public int PreferredWidth
        {
            get { return IExecute<int>("getPreferredWidth"); } set { IExecute("setPreferredWidth", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/TableColumn.html#getPropertyChangeListeners()"/> 
        /// </summary>
        public Java.Beans.PropertyChangeListener[] PropertyChangeListeners
        {
            get { return IExecuteArray<Java.Beans.PropertyChangeListener>("getPropertyChangeListeners"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/TableColumn.html#getResizable()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/TableColumn.html#setResizable(boolean)"/>
        /// </summary>
        public bool Resizable
        {
            get { return IExecute<bool>("getResizable"); } set { IExecute("setResizable", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/TableColumn.html#getWidth()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/TableColumn.html#setWidth(int)"/>
        /// </summary>
        public int Width
        {
            get { return IExecute<int>("getWidth"); } set { IExecute("setWidth", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/TableColumn.html#addPropertyChangeListener(java.beans.PropertyChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Beans.PropertyChangeListener"/></param>
        public void AddPropertyChangeListener(Java.Beans.PropertyChangeListener arg0)
        {
            IExecute("addPropertyChangeListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/TableColumn.html#removePropertyChangeListener(java.beans.PropertyChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Beans.PropertyChangeListener"/></param>
        public void RemovePropertyChangeListener(Java.Beans.PropertyChangeListener arg0)
        {
            IExecute("removePropertyChangeListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/TableColumn.html#sizeWidthToFit()"/>
        /// </summary>
        public void SizeWidthToFit()
        {
            IExecute("sizeWidthToFit");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}