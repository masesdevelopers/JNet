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

namespace Javax.Sql.Rowset
{
    #region WebRowSet declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/WebRowSet.html"/>
    /// </summary>
    public partial class WebRowSet : Javax.Sql.Rowset.CachedRowSet
    {
        const string _bridgeClassName = "javax.sql.rowset.WebRowSet";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("WebRowSet class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public WebRowSet() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("WebRowSet class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public WebRowSet(params object[] args) : base(args) { }

        private static readonly IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new InvalidOperationException($"Class {_bridgeClassName} was not found.");

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

    #region IWebRowSet
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IWebRowSet : Javax.Sql.Rowset.ICachedRowSet
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/WebRowSet.html#readXml(java.io.InputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.InputStream"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        /// <exception cref="Java.Io.IOException"/>
        void ReadXml(Java.Io.InputStream arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/WebRowSet.html#readXml(java.io.Reader)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.Reader"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        void ReadXml(Java.Io.Reader arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/WebRowSet.html#writeXml(java.io.OutputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.OutputStream"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        /// <exception cref="Java.Io.IOException"/>
        void WriteXml(Java.Io.OutputStream arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/WebRowSet.html#writeXml(java.io.Writer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.Writer"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        void WriteXml(Java.Io.Writer arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/WebRowSet.html#writeXml(java.sql.ResultSet,java.io.OutputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Sql.ResultSet"/></param>
        /// <param name="arg1"><see cref="Java.Io.OutputStream"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        /// <exception cref="Java.Io.IOException"/>
        void WriteXml(Java.Sql.ResultSet arg0, Java.Io.OutputStream arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/WebRowSet.html#writeXml(java.sql.ResultSet,java.io.Writer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Sql.ResultSet"/></param>
        /// <param name="arg1"><see cref="Java.Io.Writer"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        void WriteXml(Java.Sql.ResultSet arg0, Java.Io.Writer arg1);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region WebRowSet implementation
    public partial class WebRowSet : Javax.Sql.Rowset.IWebRowSet
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/WebRowSet.html#PUBLIC_XML_SCHEMA"/>
        /// </summary>
        public static Java.Lang.String PUBLIC_XML_SCHEMA { get { if (!_PUBLIC_XML_SCHEMAReady) { _PUBLIC_XML_SCHEMAContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "PUBLIC_XML_SCHEMA"); _PUBLIC_XML_SCHEMAReady = true; } return _PUBLIC_XML_SCHEMAContent; } }
        private static Java.Lang.String _PUBLIC_XML_SCHEMAContent = default;
        private static bool _PUBLIC_XML_SCHEMAReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/WebRowSet.html#SCHEMA_SYSTEM_ID"/>
        /// </summary>
        public static Java.Lang.String SCHEMA_SYSTEM_ID { get { if (!_SCHEMA_SYSTEM_IDReady) { _SCHEMA_SYSTEM_IDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "SCHEMA_SYSTEM_ID"); _SCHEMA_SYSTEM_IDReady = true; } return _SCHEMA_SYSTEM_IDContent; } }
        private static Java.Lang.String _SCHEMA_SYSTEM_IDContent = default;
        private static bool _SCHEMA_SYSTEM_IDReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/WebRowSet.html#readXml(java.io.InputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.InputStream"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        /// <exception cref="Java.Io.IOException"/>
        public void ReadXml(Java.Io.InputStream arg0)
        {
            IExecuteWithSignature("readXml", "(Ljava/io/InputStream;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/WebRowSet.html#readXml(java.io.Reader)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.Reader"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void ReadXml(Java.Io.Reader arg0)
        {
            IExecuteWithSignature("readXml", "(Ljava/io/Reader;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/WebRowSet.html#writeXml(java.io.OutputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.OutputStream"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        /// <exception cref="Java.Io.IOException"/>
        public void WriteXml(Java.Io.OutputStream arg0)
        {
            IExecuteWithSignature("writeXml", "(Ljava/io/OutputStream;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/WebRowSet.html#writeXml(java.io.Writer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.Writer"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void WriteXml(Java.Io.Writer arg0)
        {
            IExecuteWithSignature("writeXml", "(Ljava/io/Writer;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/WebRowSet.html#writeXml(java.sql.ResultSet,java.io.OutputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Sql.ResultSet"/></param>
        /// <param name="arg1"><see cref="Java.Io.OutputStream"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        /// <exception cref="Java.Io.IOException"/>
        public void WriteXml(Java.Sql.ResultSet arg0, Java.Io.OutputStream arg1)
        {
            IExecute("writeXml", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/WebRowSet.html#writeXml(java.sql.ResultSet,java.io.Writer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Sql.ResultSet"/></param>
        /// <param name="arg1"><see cref="Java.Io.Writer"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void WriteXml(Java.Sql.ResultSet arg0, Java.Io.Writer arg1)
        {
            IExecute("writeXml", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}