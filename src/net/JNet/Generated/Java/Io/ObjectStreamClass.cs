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

namespace Java.Io
{
    #region ObjectStreamClass declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectStreamClass.html"/>
    /// </summary>
    public partial class ObjectStreamClass : Java.Io.Serializable
    {
        const string _bridgeClassName = "java.io.ObjectStreamClass";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public ObjectStreamClass() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public ObjectStreamClass(params object[] args) : base(args) { }

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

    #region ObjectStreamClass implementation
    public partial class ObjectStreamClass
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectStreamClass.html#NO_FIELDS"/>
        /// </summary>
        public static Java.Io.ObjectStreamField[] NO_FIELDS { get { if (!_NO_FIELDSReady) { _NO_FIELDSContent = SGetFieldArray<Java.Io.ObjectStreamField>(LocalBridgeClazz, "NO_FIELDS"); _NO_FIELDSReady = true; } return _NO_FIELDSContent; } }
        private static Java.Io.ObjectStreamField[] _NO_FIELDSContent = default;
        private static bool _NO_FIELDSReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectStreamClass.html#lookup(java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <returns><see cref="Java.Io.ObjectStreamClass"/></returns>
        public static Java.Io.ObjectStreamClass Lookup(Java.Lang.Class arg0)
        {
            return SExecuteWithSignature<Java.Io.ObjectStreamClass>(LocalBridgeClazz, "lookup", "(Ljava/lang/Class;)Ljava/io/ObjectStreamClass;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectStreamClass.html#lookupAny(java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <returns><see cref="Java.Io.ObjectStreamClass"/></returns>
        public static Java.Io.ObjectStreamClass LookupAny(Java.Lang.Class arg0)
        {
            return SExecuteWithSignature<Java.Io.ObjectStreamClass>(LocalBridgeClazz, "lookupAny", "(Ljava/lang/Class;)Ljava/io/ObjectStreamClass;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectStreamClass.html#getFields()"/> 
        /// </summary>
        public Java.Io.ObjectStreamField[] Fields
        {
            get { return IExecuteWithSignatureArray<Java.Io.ObjectStreamField>("getFields", "()[Ljava/io/ObjectStreamField;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectStreamClass.html#getName()"/> 
        /// </summary>
        public Java.Lang.String Name
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getName", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectStreamClass.html#getSerialVersionUID()"/> 
        /// </summary>
        public long SerialVersionUID
        {
            get { return IExecuteWithSignature<long>("getSerialVersionUID", "()J"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectStreamClass.html#getField(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Io.ObjectStreamField"/></returns>
        public Java.Io.ObjectStreamField GetField(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Io.ObjectStreamField>("getField", "(Ljava/lang/String;)Ljava/io/ObjectStreamField;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectStreamClass.html#forClass()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.Class"/></returns>
        public Java.Lang.Class ForClass()
        {
            return IExecuteWithSignature<Java.Lang.Class>("forClass", "()Ljava/lang/Class;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}