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

namespace Javax.Swing.Event
{
    #region TableModelEvent declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/TableModelEvent.html"/>
    /// </summary>
    public partial class TableModelEvent : Java.Util.EventObject
    {
        const string _bridgeClassName = "javax.swing.event.TableModelEvent";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public TableModelEvent() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public TableModelEvent(params object[] args) : base(args) { }

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

    #region TableModelEvent implementation
    public partial class TableModelEvent
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/TableModelEvent.html#%3Cinit%3E(javax.swing.table.TableModel,int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Table.TableModel"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        public TableModelEvent(Javax.Swing.Table.TableModel arg0, int arg1, int arg2, int arg3, int arg4)
            : base(arg0, arg1, arg2, arg3, arg4)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/TableModelEvent.html#%3Cinit%3E(javax.swing.table.TableModel,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Table.TableModel"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public TableModelEvent(Javax.Swing.Table.TableModel arg0, int arg1, int arg2, int arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/TableModelEvent.html#%3Cinit%3E(javax.swing.table.TableModel,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Table.TableModel"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public TableModelEvent(Javax.Swing.Table.TableModel arg0, int arg1, int arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/TableModelEvent.html#%3Cinit%3E(javax.swing.table.TableModel,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Table.TableModel"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public TableModelEvent(Javax.Swing.Table.TableModel arg0, int arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/TableModelEvent.html#%3Cinit%3E(javax.swing.table.TableModel)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Table.TableModel"/></param>
        public TableModelEvent(Javax.Swing.Table.TableModel arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/TableModelEvent.html#ALL_COLUMNS"/>
        /// </summary>
        public static int ALL_COLUMNS { get { if (!_ALL_COLUMNSReady) { _ALL_COLUMNSContent = SGetField<int>(LocalBridgeClazz, "ALL_COLUMNS"); _ALL_COLUMNSReady = true; } return _ALL_COLUMNSContent; } }
        private static int _ALL_COLUMNSContent = default;
        private static bool _ALL_COLUMNSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/TableModelEvent.html#DELETE"/>
        /// </summary>
        public static int DELETE { get { if (!_DELETEReady) { _DELETEContent = SGetField<int>(LocalBridgeClazz, "DELETE"); _DELETEReady = true; } return _DELETEContent; } }
        private static int _DELETEContent = default;
        private static bool _DELETEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/TableModelEvent.html#HEADER_ROW"/>
        /// </summary>
        public static int HEADER_ROW { get { if (!_HEADER_ROWReady) { _HEADER_ROWContent = SGetField<int>(LocalBridgeClazz, "HEADER_ROW"); _HEADER_ROWReady = true; } return _HEADER_ROWContent; } }
        private static int _HEADER_ROWContent = default;
        private static bool _HEADER_ROWReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/TableModelEvent.html#INSERT"/>
        /// </summary>
        public static int INSERT { get { if (!_INSERTReady) { _INSERTContent = SGetField<int>(LocalBridgeClazz, "INSERT"); _INSERTReady = true; } return _INSERTContent; } }
        private static int _INSERTContent = default;
        private static bool _INSERTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/TableModelEvent.html#UPDATE"/>
        /// </summary>
        public static int UPDATE { get { if (!_UPDATEReady) { _UPDATEContent = SGetField<int>(LocalBridgeClazz, "UPDATE"); _UPDATEReady = true; } return _UPDATEContent; } }
        private static int _UPDATEContent = default;
        private static bool _UPDATEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/TableModelEvent.html#getColumn()"/> 
        /// </summary>
        public int Column
        {
            get { return IExecuteWithSignature<int>("getColumn", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/TableModelEvent.html#getFirstRow()"/> 
        /// </summary>
        public int FirstRow
        {
            get { return IExecuteWithSignature<int>("getFirstRow", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/TableModelEvent.html#getLastRow()"/> 
        /// </summary>
        public int LastRow
        {
            get { return IExecuteWithSignature<int>("getLastRow", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/TableModelEvent.html#getType()"/> 
        /// </summary>
        public int Type
        {
            get { return IExecuteWithSignature<int>("getType", "()I"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}