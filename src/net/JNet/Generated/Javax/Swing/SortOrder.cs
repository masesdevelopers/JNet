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

namespace Javax.Swing
{
    #region SortOrder declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SortOrder.html"/>
    /// </summary>
    public partial class SortOrder : Java.Lang.Enum<Javax.Swing.SortOrder>
    {
        const string _bridgeClassName = "javax.swing.SortOrder";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public SortOrder() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public SortOrder(params object[] args) : base(args) { }

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

    #region SortOrder implementation
    public partial class SortOrder
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SortOrder.html#ASCENDING"/>
        /// </summary>
        public static Javax.Swing.SortOrder ASCENDING { get { if (!_ASCENDINGReady) { _ASCENDINGContent = SGetField<Javax.Swing.SortOrder>(LocalBridgeClazz, "ASCENDING"); _ASCENDINGReady = true; } return _ASCENDINGContent; } }
        private static Javax.Swing.SortOrder _ASCENDINGContent = default;
        private static bool _ASCENDINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SortOrder.html#DESCENDING"/>
        /// </summary>
        public static Javax.Swing.SortOrder DESCENDING { get { if (!_DESCENDINGReady) { _DESCENDINGContent = SGetField<Javax.Swing.SortOrder>(LocalBridgeClazz, "DESCENDING"); _DESCENDINGReady = true; } return _DESCENDINGContent; } }
        private static Javax.Swing.SortOrder _DESCENDINGContent = default;
        private static bool _DESCENDINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SortOrder.html#UNSORTED"/>
        /// </summary>
        public static Javax.Swing.SortOrder UNSORTED { get { if (!_UNSORTEDReady) { _UNSORTEDContent = SGetField<Javax.Swing.SortOrder>(LocalBridgeClazz, "UNSORTED"); _UNSORTEDReady = true; } return _UNSORTEDContent; } }
        private static Javax.Swing.SortOrder _UNSORTEDContent = default;
        private static bool _UNSORTEDReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SortOrder.html#valueOf(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Swing.SortOrder"/></returns>
        public static Javax.Swing.SortOrder ValueOf(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Javax.Swing.SortOrder>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Ljavax/swing/SortOrder;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/SortOrder.html#values()"/>
        /// </summary>
        /// <returns><see cref="Javax.Swing.SortOrder"/></returns>
        public static Javax.Swing.SortOrder[] Values()
        {
            return SExecuteWithSignatureArray<Javax.Swing.SortOrder>(LocalBridgeClazz, "values", "()[Ljavax/swing/SortOrder;");
        }

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}