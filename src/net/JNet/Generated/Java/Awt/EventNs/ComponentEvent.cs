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

namespace Java.Awt.EventNs
{
    #region ComponentEvent declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/ComponentEvent.html"/>
    /// </summary>
    public partial class ComponentEvent : Java.Awt.AWTEvent
    {
        const string _bridgeClassName = "java.awt.event.ComponentEvent";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public ComponentEvent() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public ComponentEvent(params object[] args) : base(args) { }

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

    #region ComponentEvent implementation
    public partial class ComponentEvent
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/ComponentEvent.html#%3Cinit%3E(java.awt.Component,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public ComponentEvent(Java.Awt.Component arg0, int arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/ComponentEvent.html#COMPONENT_FIRST"/>
        /// </summary>
        public static int COMPONENT_FIRST { get { if (!_COMPONENT_FIRSTReady) { _COMPONENT_FIRSTContent = SGetField<int>(LocalBridgeClazz, "COMPONENT_FIRST"); _COMPONENT_FIRSTReady = true; } return _COMPONENT_FIRSTContent; } }
        private static int _COMPONENT_FIRSTContent = default;
        private static bool _COMPONENT_FIRSTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/ComponentEvent.html#COMPONENT_HIDDEN"/>
        /// </summary>
        public static int COMPONENT_HIDDEN { get { if (!_COMPONENT_HIDDENReady) { _COMPONENT_HIDDENContent = SGetField<int>(LocalBridgeClazz, "COMPONENT_HIDDEN"); _COMPONENT_HIDDENReady = true; } return _COMPONENT_HIDDENContent; } }
        private static int _COMPONENT_HIDDENContent = default;
        private static bool _COMPONENT_HIDDENReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/ComponentEvent.html#COMPONENT_LAST"/>
        /// </summary>
        public static int COMPONENT_LAST { get { if (!_COMPONENT_LASTReady) { _COMPONENT_LASTContent = SGetField<int>(LocalBridgeClazz, "COMPONENT_LAST"); _COMPONENT_LASTReady = true; } return _COMPONENT_LASTContent; } }
        private static int _COMPONENT_LASTContent = default;
        private static bool _COMPONENT_LASTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/ComponentEvent.html#COMPONENT_MOVED"/>
        /// </summary>
        public static int COMPONENT_MOVED { get { if (!_COMPONENT_MOVEDReady) { _COMPONENT_MOVEDContent = SGetField<int>(LocalBridgeClazz, "COMPONENT_MOVED"); _COMPONENT_MOVEDReady = true; } return _COMPONENT_MOVEDContent; } }
        private static int _COMPONENT_MOVEDContent = default;
        private static bool _COMPONENT_MOVEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/ComponentEvent.html#COMPONENT_RESIZED"/>
        /// </summary>
        public static int COMPONENT_RESIZED { get { if (!_COMPONENT_RESIZEDReady) { _COMPONENT_RESIZEDContent = SGetField<int>(LocalBridgeClazz, "COMPONENT_RESIZED"); _COMPONENT_RESIZEDReady = true; } return _COMPONENT_RESIZEDContent; } }
        private static int _COMPONENT_RESIZEDContent = default;
        private static bool _COMPONENT_RESIZEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/ComponentEvent.html#COMPONENT_SHOWN"/>
        /// </summary>
        public static int COMPONENT_SHOWN { get { if (!_COMPONENT_SHOWNReady) { _COMPONENT_SHOWNContent = SGetField<int>(LocalBridgeClazz, "COMPONENT_SHOWN"); _COMPONENT_SHOWNReady = true; } return _COMPONENT_SHOWNContent; } }
        private static int _COMPONENT_SHOWNContent = default;
        private static bool _COMPONENT_SHOWNReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/ComponentEvent.html#getComponent()"/> 
        /// </summary>
        public Java.Awt.Component Component
        {
            get { return IExecute<Java.Awt.Component>("getComponent"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}