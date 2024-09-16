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

namespace Java.Awt.Dnd
{
    #region DnDConstants declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DnDConstants.html"/>
    /// </summary>
    public partial class DnDConstants : MASES.JCOBridge.C2JBridge.JVMBridgeBase<DnDConstants>
    {
        const string _bridgeClassName = "java.awt.dnd.DnDConstants";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public DnDConstants() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public DnDConstants(params object[] args) : base(args) { }

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

    #region DnDConstants implementation
    public partial class DnDConstants
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DnDConstants.html#ACTION_COPY"/>
        /// </summary>
        public static int ACTION_COPY { get { if (!_ACTION_COPYReady) { _ACTION_COPYContent = SGetField<int>(LocalBridgeClazz, "ACTION_COPY"); _ACTION_COPYReady = true; } return _ACTION_COPYContent; } }
        private static int _ACTION_COPYContent = default;
        private static bool _ACTION_COPYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DnDConstants.html#ACTION_COPY_OR_MOVE"/>
        /// </summary>
        public static int ACTION_COPY_OR_MOVE { get { if (!_ACTION_COPY_OR_MOVEReady) { _ACTION_COPY_OR_MOVEContent = SGetField<int>(LocalBridgeClazz, "ACTION_COPY_OR_MOVE"); _ACTION_COPY_OR_MOVEReady = true; } return _ACTION_COPY_OR_MOVEContent; } }
        private static int _ACTION_COPY_OR_MOVEContent = default;
        private static bool _ACTION_COPY_OR_MOVEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DnDConstants.html#ACTION_LINK"/>
        /// </summary>
        public static int ACTION_LINK { get { if (!_ACTION_LINKReady) { _ACTION_LINKContent = SGetField<int>(LocalBridgeClazz, "ACTION_LINK"); _ACTION_LINKReady = true; } return _ACTION_LINKContent; } }
        private static int _ACTION_LINKContent = default;
        private static bool _ACTION_LINKReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DnDConstants.html#ACTION_MOVE"/>
        /// </summary>
        public static int ACTION_MOVE { get { if (!_ACTION_MOVEReady) { _ACTION_MOVEContent = SGetField<int>(LocalBridgeClazz, "ACTION_MOVE"); _ACTION_MOVEReady = true; } return _ACTION_MOVEContent; } }
        private static int _ACTION_MOVEContent = default;
        private static bool _ACTION_MOVEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DnDConstants.html#ACTION_NONE"/>
        /// </summary>
        public static int ACTION_NONE { get { if (!_ACTION_NONEReady) { _ACTION_NONEContent = SGetField<int>(LocalBridgeClazz, "ACTION_NONE"); _ACTION_NONEReady = true; } return _ACTION_NONEContent; } }
        private static int _ACTION_NONEContent = default;
        private static bool _ACTION_NONEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DnDConstants.html#ACTION_REFERENCE"/>
        /// </summary>
        public static int ACTION_REFERENCE { get { if (!_ACTION_REFERENCEReady) { _ACTION_REFERENCEContent = SGetField<int>(LocalBridgeClazz, "ACTION_REFERENCE"); _ACTION_REFERENCEReady = true; } return _ACTION_REFERENCEContent; } }
        private static int _ACTION_REFERENCEContent = default;
        private static bool _ACTION_REFERENCEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}