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

namespace Javax.Sql.Rowset.Serial
{
    #region SerialStruct declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/serial/SerialStruct.html"/>
    /// </summary>
    public partial class SerialStruct : MASES.JCOBridge.C2JBridge.JVMBridgeBase<SerialStruct>
    {
        const string _bridgeClassName = "javax.sql.rowset.serial.SerialStruct";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public SerialStruct() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public SerialStruct(params object[] args) : base(args) { }

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

    #region SerialStruct implementation
    public partial class SerialStruct
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/serial/SerialStruct.html#%3Cinit%3E(java.sql.SQLData,java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Sql.SQLData"/></param>
        /// <param name="arg1"><see cref="Java.Util.Map"/></param>
        /// <exception cref="Javax.Sql.Rowset.Serial.SerialException"/>
        public SerialStruct(Java.Sql.SQLData arg0, Java.Util.Map<Java.Lang.String, Java.Lang.Class> arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/serial/SerialStruct.html#%3Cinit%3E(java.sql.Struct,java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Sql.Struct"/></param>
        /// <param name="arg1"><see cref="Java.Util.Map"/></param>
        /// <exception cref="Javax.Sql.Rowset.Serial.SerialException"/>
        public SerialStruct(Java.Sql.Struct arg0, Java.Util.Map<Java.Lang.String, Java.Lang.Class> arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Sql.Rowset.Serial.SerialStruct"/> to <see cref="Java.Sql.Struct"/>
        /// </summary>
        public static implicit operator Java.Sql.Struct(Javax.Sql.Rowset.Serial.SerialStruct t) => t.Cast<Java.Sql.Struct>();
        /// <summary>
        /// Converter from <see cref="Javax.Sql.Rowset.Serial.SerialStruct"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Javax.Sql.Rowset.Serial.SerialStruct t) => t.Cast<Java.Io.Serializable>();
        /// <summary>
        /// Converter from <see cref="Javax.Sql.Rowset.Serial.SerialStruct"/> to <see cref="Java.Lang.Cloneable"/>
        /// </summary>
        public static implicit operator Java.Lang.Cloneable(Javax.Sql.Rowset.Serial.SerialStruct t) => t.Cast<Java.Lang.Cloneable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/serial/SerialStruct.html#getAttributes()"/> 
        /// </summary>
        public object[] Attributes
        {
            get { return IExecuteWithSignatureArray<object>("getAttributes", "()[Ljava/lang/Object;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/serial/SerialStruct.html#getSQLTypeName()"/> 
        /// </summary>
        public Java.Lang.String SQLTypeName
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getSQLTypeName", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/serial/SerialStruct.html#getAttributes(java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Javax.Sql.Rowset.Serial.SerialException"/>
        public object[] GetAttributes(Java.Util.Map<Java.Lang.String, Java.Lang.Class> arg0)
        {
            return IExecuteWithSignatureArray<object>("getAttributes", "(Ljava/util/Map;)[Ljava/lang/Object;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}