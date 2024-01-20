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
*  This file is generated by MASES.JNetReflector (ver. 2.2.1.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Swing.Event
{
    #region TableModelEvent
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
        public static int ALL_COLUMNS { get { return SGetField<int>(LocalBridgeClazz, "ALL_COLUMNS"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/TableModelEvent.html#DELETE"/>
        /// </summary>
        public static int DELETE { get { return SGetField<int>(LocalBridgeClazz, "DELETE"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/TableModelEvent.html#HEADER_ROW"/>
        /// </summary>
        public static int HEADER_ROW { get { return SGetField<int>(LocalBridgeClazz, "HEADER_ROW"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/TableModelEvent.html#INSERT"/>
        /// </summary>
        public static int INSERT { get { return SGetField<int>(LocalBridgeClazz, "INSERT"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/TableModelEvent.html#UPDATE"/>
        /// </summary>
        public static int UPDATE { get { return SGetField<int>(LocalBridgeClazz, "UPDATE"); } }

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/TableModelEvent.html#getColumn()"/> 
        /// </summary>
        public int Column
        {
            get { return IExecute<int>("getColumn"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/TableModelEvent.html#getFirstRow()"/> 
        /// </summary>
        public int FirstRow
        {
            get { return IExecute<int>("getFirstRow"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/TableModelEvent.html#getLastRow()"/> 
        /// </summary>
        public int LastRow
        {
            get { return IExecute<int>("getLastRow"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/TableModelEvent.html#getType()"/> 
        /// </summary>
        public int Type
        {
            get { return IExecute<int>("getType"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}