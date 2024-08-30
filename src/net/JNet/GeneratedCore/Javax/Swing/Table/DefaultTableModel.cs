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

namespace Javax.Swing.Table
{
    #region DefaultTableModel definition
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/DefaultTableModel.html"/>
    /// </summary>
    public partial class DefaultTableModel : Javax.Swing.Table.AbstractTableModel
    {
        const string _bridgeClassName = "javax.swing.table.DefaultTableModel";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public DefaultTableModel() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public DefaultTableModel(params object[] args) : base(args) { }

        private static readonly IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new InvalidOperationException($"Class {_bridgeClassName} was not found.");

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

    #region DefaultTableModel
    public partial class DefaultTableModel
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/DefaultTableModel.html#%3Cinit%3E(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public DefaultTableModel(int arg0, int arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/DefaultTableModel.html#%3Cinit%3E(java.util.Vector,java.util.Vector)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Vector"/></param>
        /// <param name="arg1"><see cref="Java.Util.Vector"/></param>
        public DefaultTableModel(Java.Util.Vector arg0, Java.Util.Vector<object> arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/DefaultTableModel.html#%3Cinit%3E(java.util.Vector,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Vector"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public DefaultTableModel(Java.Util.Vector<object> arg0, int arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/DefaultTableModel.html#getDataVector()"/> 
        /// </summary>
        public Java.Util.Vector<Java.Util.Vector> DataVector
        {
            get { return IExecuteWithSignature<Java.Util.Vector<Java.Util.Vector>>("getDataVector", "()Ljava/util/Vector;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/DefaultTableModel.html#addColumn(java.lang.Object,java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        public void AddColumn(object arg0, object[] arg1)
        {
            IExecute("addColumn", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/DefaultTableModel.html#addColumn(java.lang.Object,java.util.Vector)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="Java.Util.Vector"/></param>
        public void AddColumn(object arg0, Java.Util.Vector<object> arg1)
        {
            IExecute("addColumn", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/DefaultTableModel.html#addColumn(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        public void AddColumn(object arg0)
        {
            IExecuteWithSignature("addColumn", "(Ljava/lang/Object;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/DefaultTableModel.html#addRow(java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        public void AddRow(object[] arg0)
        {
            IExecuteWithSignature("addRow", "([Ljava/lang/Object;)V", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/DefaultTableModel.html#addRow(java.util.Vector)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Vector"/></param>
        public void AddRow(Java.Util.Vector<object> arg0)
        {
            IExecuteWithSignature("addRow", "(Ljava/util/Vector;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/DefaultTableModel.html#insertRow(int,java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        public void InsertRow(int arg0, object[] arg1)
        {
            IExecute("insertRow", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/DefaultTableModel.html#insertRow(int,java.util.Vector)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Util.Vector"/></param>
        public void InsertRow(int arg0, Java.Util.Vector<object> arg1)
        {
            IExecute("insertRow", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/DefaultTableModel.html#moveRow(int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public void MoveRow(int arg0, int arg1, int arg2)
        {
            IExecute("moveRow", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/DefaultTableModel.html#newDataAvailable(javax.swing.event.TableModelEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.TableModelEvent"/></param>
        public void NewDataAvailable(Javax.Swing.Event.TableModelEvent arg0)
        {
            IExecuteWithSignature("newDataAvailable", "(Ljavax/swing/event/TableModelEvent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/DefaultTableModel.html#newRowsAdded(javax.swing.event.TableModelEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.TableModelEvent"/></param>
        public void NewRowsAdded(Javax.Swing.Event.TableModelEvent arg0)
        {
            IExecuteWithSignature("newRowsAdded", "(Ljavax/swing/event/TableModelEvent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/DefaultTableModel.html#removeRow(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void RemoveRow(int arg0)
        {
            IExecuteWithSignature("removeRow", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/DefaultTableModel.html#rowsRemoved(javax.swing.event.TableModelEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.TableModelEvent"/></param>
        public void RowsRemoved(Javax.Swing.Event.TableModelEvent arg0)
        {
            IExecuteWithSignature("rowsRemoved", "(Ljavax/swing/event/TableModelEvent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/DefaultTableModel.html#setColumnCount(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetColumnCount(int arg0)
        {
            IExecuteWithSignature("setColumnCount", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/DefaultTableModel.html#setColumnIdentifiers(java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        public void SetColumnIdentifiers(object[] arg0)
        {
            IExecuteWithSignature("setColumnIdentifiers", "([Ljava/lang/Object;)V", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/DefaultTableModel.html#setColumnIdentifiers(java.util.Vector)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Vector"/></param>
        public void SetColumnIdentifiers(Java.Util.Vector<object> arg0)
        {
            IExecuteWithSignature("setColumnIdentifiers", "(Ljava/util/Vector;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/DefaultTableModel.html#setDataVector(java.lang.Object[][],java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        public void SetDataVector(object[][] arg0, object[] arg1)
        {
            IExecute("setDataVector", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/DefaultTableModel.html#setDataVector(java.util.Vector,java.util.Vector)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Vector"/></param>
        /// <param name="arg1"><see cref="Java.Util.Vector"/></param>
        /// <typeparam name="Arg0ExtendsJava_Util_Vector"><see cref="Java.Util.Vector"/></typeparam>
        public void SetDataVector<Arg0ExtendsJava_Util_Vector>(Java.Util.Vector<Arg0ExtendsJava_Util_Vector> arg0, Java.Util.Vector<object> arg1) where Arg0ExtendsJava_Util_Vector : Java.Util.Vector
        {
            IExecute("setDataVector", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/DefaultTableModel.html#setNumRows(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetNumRows(int arg0)
        {
            IExecuteWithSignature("setNumRows", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/DefaultTableModel.html#setRowCount(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetRowCount(int arg0)
        {
            IExecuteWithSignature("setRowCount", "(I)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}