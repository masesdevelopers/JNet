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

namespace Java.Awt.EventNs
{
    #region HierarchyEvent declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/HierarchyEvent.html"/>
    /// </summary>
    public partial class HierarchyEvent : Java.Awt.AWTEvent
    {
        const string _bridgeClassName = "java.awt.event.HierarchyEvent";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public HierarchyEvent() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public HierarchyEvent(params object[] args) : base(args) { }

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

    #region HierarchyEvent implementation
    public partial class HierarchyEvent
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/HierarchyEvent.html#%3Cinit%3E(java.awt.Component,int,java.awt.Component,java.awt.Container,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Java.Awt.Component"/></param>
        /// <param name="arg3"><see cref="Java.Awt.Container"/></param>
        /// <param name="arg4"><see cref="long"/></param>
        public HierarchyEvent(Java.Awt.Component arg0, int arg1, Java.Awt.Component arg2, Java.Awt.Container arg3, long arg4)
            : base(arg0, arg1, arg2, arg3, arg4)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/HierarchyEvent.html#%3Cinit%3E(java.awt.Component,int,java.awt.Component,java.awt.Container)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Java.Awt.Component"/></param>
        /// <param name="arg3"><see cref="Java.Awt.Container"/></param>
        public HierarchyEvent(Java.Awt.Component arg0, int arg1, Java.Awt.Component arg2, Java.Awt.Container arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/HierarchyEvent.html#ANCESTOR_MOVED"/>
        /// </summary>
        public static int ANCESTOR_MOVED { get { if (!_ANCESTOR_MOVEDReady) { _ANCESTOR_MOVEDContent = SGetField<int>(LocalBridgeClazz, "ANCESTOR_MOVED"); _ANCESTOR_MOVEDReady = true; } return _ANCESTOR_MOVEDContent; } }
        private static int _ANCESTOR_MOVEDContent = default;
        private static bool _ANCESTOR_MOVEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/HierarchyEvent.html#ANCESTOR_RESIZED"/>
        /// </summary>
        public static int ANCESTOR_RESIZED { get { if (!_ANCESTOR_RESIZEDReady) { _ANCESTOR_RESIZEDContent = SGetField<int>(LocalBridgeClazz, "ANCESTOR_RESIZED"); _ANCESTOR_RESIZEDReady = true; } return _ANCESTOR_RESIZEDContent; } }
        private static int _ANCESTOR_RESIZEDContent = default;
        private static bool _ANCESTOR_RESIZEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/HierarchyEvent.html#DISPLAYABILITY_CHANGED"/>
        /// </summary>
        public static int DISPLAYABILITY_CHANGED { get { if (!_DISPLAYABILITY_CHANGEDReady) { _DISPLAYABILITY_CHANGEDContent = SGetField<int>(LocalBridgeClazz, "DISPLAYABILITY_CHANGED"); _DISPLAYABILITY_CHANGEDReady = true; } return _DISPLAYABILITY_CHANGEDContent; } }
        private static int _DISPLAYABILITY_CHANGEDContent = default;
        private static bool _DISPLAYABILITY_CHANGEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/HierarchyEvent.html#HIERARCHY_CHANGED"/>
        /// </summary>
        public static int HIERARCHY_CHANGED { get { if (!_HIERARCHY_CHANGEDReady) { _HIERARCHY_CHANGEDContent = SGetField<int>(LocalBridgeClazz, "HIERARCHY_CHANGED"); _HIERARCHY_CHANGEDReady = true; } return _HIERARCHY_CHANGEDContent; } }
        private static int _HIERARCHY_CHANGEDContent = default;
        private static bool _HIERARCHY_CHANGEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/HierarchyEvent.html#HIERARCHY_FIRST"/>
        /// </summary>
        public static int HIERARCHY_FIRST { get { if (!_HIERARCHY_FIRSTReady) { _HIERARCHY_FIRSTContent = SGetField<int>(LocalBridgeClazz, "HIERARCHY_FIRST"); _HIERARCHY_FIRSTReady = true; } return _HIERARCHY_FIRSTContent; } }
        private static int _HIERARCHY_FIRSTContent = default;
        private static bool _HIERARCHY_FIRSTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/HierarchyEvent.html#HIERARCHY_LAST"/>
        /// </summary>
        public static int HIERARCHY_LAST { get { if (!_HIERARCHY_LASTReady) { _HIERARCHY_LASTContent = SGetField<int>(LocalBridgeClazz, "HIERARCHY_LAST"); _HIERARCHY_LASTReady = true; } return _HIERARCHY_LASTContent; } }
        private static int _HIERARCHY_LASTContent = default;
        private static bool _HIERARCHY_LASTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/HierarchyEvent.html#PARENT_CHANGED"/>
        /// </summary>
        public static int PARENT_CHANGED { get { if (!_PARENT_CHANGEDReady) { _PARENT_CHANGEDContent = SGetField<int>(LocalBridgeClazz, "PARENT_CHANGED"); _PARENT_CHANGEDReady = true; } return _PARENT_CHANGEDContent; } }
        private static int _PARENT_CHANGEDContent = default;
        private static bool _PARENT_CHANGEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/HierarchyEvent.html#SHOWING_CHANGED"/>
        /// </summary>
        public static int SHOWING_CHANGED { get { if (!_SHOWING_CHANGEDReady) { _SHOWING_CHANGEDContent = SGetField<int>(LocalBridgeClazz, "SHOWING_CHANGED"); _SHOWING_CHANGEDReady = true; } return _SHOWING_CHANGEDContent; } }
        private static int _SHOWING_CHANGEDContent = default;
        private static bool _SHOWING_CHANGEDReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/HierarchyEvent.html#getChanged()"/> 
        /// </summary>
        public Java.Awt.Component Changed
        {
            get { return IExecuteWithSignature<Java.Awt.Component>("getChanged", "()Ljava/awt/Component;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/HierarchyEvent.html#getChangedParent()"/> 
        /// </summary>
        public Java.Awt.Container ChangedParent
        {
            get { return IExecuteWithSignature<Java.Awt.Container>("getChangedParent", "()Ljava/awt/Container;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/HierarchyEvent.html#getChangeFlags()"/> 
        /// </summary>
        public long ChangeFlags
        {
            get { return IExecuteWithSignature<long>("getChangeFlags", "()J"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/HierarchyEvent.html#getComponent()"/> 
        /// </summary>
        public Java.Awt.Component Component
        {
            get { return IExecuteWithSignature<Java.Awt.Component>("getComponent", "()Ljava/awt/Component;"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}