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

namespace Java.Awt
{
    #region AWTEvent declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/AWTEvent.html"/>
    /// </summary>
    public partial class AWTEvent : Java.Util.EventObject
    {
        const string _bridgeClassName = "java.awt.AWTEvent";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("AWTEvent class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public AWTEvent() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("AWTEvent class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public AWTEvent(params object[] args) : base(args) { }

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
        public override bool IsBridgeInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region AWTEvent implementation
    public partial class AWTEvent
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/AWTEvent.html#%3Cinit%3E(java.lang.Object,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public AWTEvent(object arg0, int arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/AWTEvent.html#RESERVED_ID_MAX"/>
        /// </summary>
        public static int RESERVED_ID_MAX { get { if (!_RESERVED_ID_MAXReady) { _RESERVED_ID_MAXContent = SGetField<int>(LocalBridgeClazz, "RESERVED_ID_MAX"); _RESERVED_ID_MAXReady = true; } return _RESERVED_ID_MAXContent; } }
        private static int _RESERVED_ID_MAXContent = default;
        private static bool _RESERVED_ID_MAXReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/AWTEvent.html#ACTION_EVENT_MASK"/>
        /// </summary>
        public static long ACTION_EVENT_MASK { get { if (!_ACTION_EVENT_MASKReady) { _ACTION_EVENT_MASKContent = SGetField<long>(LocalBridgeClazz, "ACTION_EVENT_MASK"); _ACTION_EVENT_MASKReady = true; } return _ACTION_EVENT_MASKContent; } }
        private static long _ACTION_EVENT_MASKContent = default;
        private static bool _ACTION_EVENT_MASKReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/AWTEvent.html#ADJUSTMENT_EVENT_MASK"/>
        /// </summary>
        public static long ADJUSTMENT_EVENT_MASK { get { if (!_ADJUSTMENT_EVENT_MASKReady) { _ADJUSTMENT_EVENT_MASKContent = SGetField<long>(LocalBridgeClazz, "ADJUSTMENT_EVENT_MASK"); _ADJUSTMENT_EVENT_MASKReady = true; } return _ADJUSTMENT_EVENT_MASKContent; } }
        private static long _ADJUSTMENT_EVENT_MASKContent = default;
        private static bool _ADJUSTMENT_EVENT_MASKReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/AWTEvent.html#COMPONENT_EVENT_MASK"/>
        /// </summary>
        public static long COMPONENT_EVENT_MASK { get { if (!_COMPONENT_EVENT_MASKReady) { _COMPONENT_EVENT_MASKContent = SGetField<long>(LocalBridgeClazz, "COMPONENT_EVENT_MASK"); _COMPONENT_EVENT_MASKReady = true; } return _COMPONENT_EVENT_MASKContent; } }
        private static long _COMPONENT_EVENT_MASKContent = default;
        private static bool _COMPONENT_EVENT_MASKReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/AWTEvent.html#CONTAINER_EVENT_MASK"/>
        /// </summary>
        public static long CONTAINER_EVENT_MASK { get { if (!_CONTAINER_EVENT_MASKReady) { _CONTAINER_EVENT_MASKContent = SGetField<long>(LocalBridgeClazz, "CONTAINER_EVENT_MASK"); _CONTAINER_EVENT_MASKReady = true; } return _CONTAINER_EVENT_MASKContent; } }
        private static long _CONTAINER_EVENT_MASKContent = default;
        private static bool _CONTAINER_EVENT_MASKReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/AWTEvent.html#FOCUS_EVENT_MASK"/>
        /// </summary>
        public static long FOCUS_EVENT_MASK { get { if (!_FOCUS_EVENT_MASKReady) { _FOCUS_EVENT_MASKContent = SGetField<long>(LocalBridgeClazz, "FOCUS_EVENT_MASK"); _FOCUS_EVENT_MASKReady = true; } return _FOCUS_EVENT_MASKContent; } }
        private static long _FOCUS_EVENT_MASKContent = default;
        private static bool _FOCUS_EVENT_MASKReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/AWTEvent.html#HIERARCHY_BOUNDS_EVENT_MASK"/>
        /// </summary>
        public static long HIERARCHY_BOUNDS_EVENT_MASK { get { if (!_HIERARCHY_BOUNDS_EVENT_MASKReady) { _HIERARCHY_BOUNDS_EVENT_MASKContent = SGetField<long>(LocalBridgeClazz, "HIERARCHY_BOUNDS_EVENT_MASK"); _HIERARCHY_BOUNDS_EVENT_MASKReady = true; } return _HIERARCHY_BOUNDS_EVENT_MASKContent; } }
        private static long _HIERARCHY_BOUNDS_EVENT_MASKContent = default;
        private static bool _HIERARCHY_BOUNDS_EVENT_MASKReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/AWTEvent.html#HIERARCHY_EVENT_MASK"/>
        /// </summary>
        public static long HIERARCHY_EVENT_MASK { get { if (!_HIERARCHY_EVENT_MASKReady) { _HIERARCHY_EVENT_MASKContent = SGetField<long>(LocalBridgeClazz, "HIERARCHY_EVENT_MASK"); _HIERARCHY_EVENT_MASKReady = true; } return _HIERARCHY_EVENT_MASKContent; } }
        private static long _HIERARCHY_EVENT_MASKContent = default;
        private static bool _HIERARCHY_EVENT_MASKReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/AWTEvent.html#INPUT_METHOD_EVENT_MASK"/>
        /// </summary>
        public static long INPUT_METHOD_EVENT_MASK { get { if (!_INPUT_METHOD_EVENT_MASKReady) { _INPUT_METHOD_EVENT_MASKContent = SGetField<long>(LocalBridgeClazz, "INPUT_METHOD_EVENT_MASK"); _INPUT_METHOD_EVENT_MASKReady = true; } return _INPUT_METHOD_EVENT_MASKContent; } }
        private static long _INPUT_METHOD_EVENT_MASKContent = default;
        private static bool _INPUT_METHOD_EVENT_MASKReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/AWTEvent.html#INVOCATION_EVENT_MASK"/>
        /// </summary>
        public static long INVOCATION_EVENT_MASK { get { if (!_INVOCATION_EVENT_MASKReady) { _INVOCATION_EVENT_MASKContent = SGetField<long>(LocalBridgeClazz, "INVOCATION_EVENT_MASK"); _INVOCATION_EVENT_MASKReady = true; } return _INVOCATION_EVENT_MASKContent; } }
        private static long _INVOCATION_EVENT_MASKContent = default;
        private static bool _INVOCATION_EVENT_MASKReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/AWTEvent.html#ITEM_EVENT_MASK"/>
        /// </summary>
        public static long ITEM_EVENT_MASK { get { if (!_ITEM_EVENT_MASKReady) { _ITEM_EVENT_MASKContent = SGetField<long>(LocalBridgeClazz, "ITEM_EVENT_MASK"); _ITEM_EVENT_MASKReady = true; } return _ITEM_EVENT_MASKContent; } }
        private static long _ITEM_EVENT_MASKContent = default;
        private static bool _ITEM_EVENT_MASKReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/AWTEvent.html#KEY_EVENT_MASK"/>
        /// </summary>
        public static long KEY_EVENT_MASK { get { if (!_KEY_EVENT_MASKReady) { _KEY_EVENT_MASKContent = SGetField<long>(LocalBridgeClazz, "KEY_EVENT_MASK"); _KEY_EVENT_MASKReady = true; } return _KEY_EVENT_MASKContent; } }
        private static long _KEY_EVENT_MASKContent = default;
        private static bool _KEY_EVENT_MASKReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/AWTEvent.html#MOUSE_EVENT_MASK"/>
        /// </summary>
        public static long MOUSE_EVENT_MASK { get { if (!_MOUSE_EVENT_MASKReady) { _MOUSE_EVENT_MASKContent = SGetField<long>(LocalBridgeClazz, "MOUSE_EVENT_MASK"); _MOUSE_EVENT_MASKReady = true; } return _MOUSE_EVENT_MASKContent; } }
        private static long _MOUSE_EVENT_MASKContent = default;
        private static bool _MOUSE_EVENT_MASKReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/AWTEvent.html#MOUSE_MOTION_EVENT_MASK"/>
        /// </summary>
        public static long MOUSE_MOTION_EVENT_MASK { get { if (!_MOUSE_MOTION_EVENT_MASKReady) { _MOUSE_MOTION_EVENT_MASKContent = SGetField<long>(LocalBridgeClazz, "MOUSE_MOTION_EVENT_MASK"); _MOUSE_MOTION_EVENT_MASKReady = true; } return _MOUSE_MOTION_EVENT_MASKContent; } }
        private static long _MOUSE_MOTION_EVENT_MASKContent = default;
        private static bool _MOUSE_MOTION_EVENT_MASKReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/AWTEvent.html#MOUSE_WHEEL_EVENT_MASK"/>
        /// </summary>
        public static long MOUSE_WHEEL_EVENT_MASK { get { if (!_MOUSE_WHEEL_EVENT_MASKReady) { _MOUSE_WHEEL_EVENT_MASKContent = SGetField<long>(LocalBridgeClazz, "MOUSE_WHEEL_EVENT_MASK"); _MOUSE_WHEEL_EVENT_MASKReady = true; } return _MOUSE_WHEEL_EVENT_MASKContent; } }
        private static long _MOUSE_WHEEL_EVENT_MASKContent = default;
        private static bool _MOUSE_WHEEL_EVENT_MASKReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/AWTEvent.html#PAINT_EVENT_MASK"/>
        /// </summary>
        public static long PAINT_EVENT_MASK { get { if (!_PAINT_EVENT_MASKReady) { _PAINT_EVENT_MASKContent = SGetField<long>(LocalBridgeClazz, "PAINT_EVENT_MASK"); _PAINT_EVENT_MASKReady = true; } return _PAINT_EVENT_MASKContent; } }
        private static long _PAINT_EVENT_MASKContent = default;
        private static bool _PAINT_EVENT_MASKReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/AWTEvent.html#TEXT_EVENT_MASK"/>
        /// </summary>
        public static long TEXT_EVENT_MASK { get { if (!_TEXT_EVENT_MASKReady) { _TEXT_EVENT_MASKContent = SGetField<long>(LocalBridgeClazz, "TEXT_EVENT_MASK"); _TEXT_EVENT_MASKReady = true; } return _TEXT_EVENT_MASKContent; } }
        private static long _TEXT_EVENT_MASKContent = default;
        private static bool _TEXT_EVENT_MASKReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/AWTEvent.html#WINDOW_EVENT_MASK"/>
        /// </summary>
        public static long WINDOW_EVENT_MASK { get { if (!_WINDOW_EVENT_MASKReady) { _WINDOW_EVENT_MASKContent = SGetField<long>(LocalBridgeClazz, "WINDOW_EVENT_MASK"); _WINDOW_EVENT_MASKReady = true; } return _WINDOW_EVENT_MASKContent; } }
        private static long _WINDOW_EVENT_MASKContent = default;
        private static bool _WINDOW_EVENT_MASKReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/AWTEvent.html#WINDOW_FOCUS_EVENT_MASK"/>
        /// </summary>
        public static long WINDOW_FOCUS_EVENT_MASK { get { if (!_WINDOW_FOCUS_EVENT_MASKReady) { _WINDOW_FOCUS_EVENT_MASKContent = SGetField<long>(LocalBridgeClazz, "WINDOW_FOCUS_EVENT_MASK"); _WINDOW_FOCUS_EVENT_MASKReady = true; } return _WINDOW_FOCUS_EVENT_MASKContent; } }
        private static long _WINDOW_FOCUS_EVENT_MASKContent = default;
        private static bool _WINDOW_FOCUS_EVENT_MASKReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/AWTEvent.html#WINDOW_STATE_EVENT_MASK"/>
        /// </summary>
        public static long WINDOW_STATE_EVENT_MASK { get { if (!_WINDOW_STATE_EVENT_MASKReady) { _WINDOW_STATE_EVENT_MASKContent = SGetField<long>(LocalBridgeClazz, "WINDOW_STATE_EVENT_MASK"); _WINDOW_STATE_EVENT_MASKReady = true; } return _WINDOW_STATE_EVENT_MASKContent; } }
        private static long _WINDOW_STATE_EVENT_MASKContent = default;
        private static bool _WINDOW_STATE_EVENT_MASKReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/AWTEvent.html#getID()"/> 
        /// </summary>
        public int ID
        {
            get { return IExecuteWithSignature<int>("getID", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/AWTEvent.html#paramString()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String ParamString()
        {
            return IExecuteWithSignature<Java.Lang.String>("paramString", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/AWTEvent.html#setSource(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        public void SetSource(object arg0)
        {
            IExecuteWithSignature("setSource", "(Ljava/lang/Object;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}