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
    #region InputEvent declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/InputEvent.html"/>
    /// </summary>
    public partial class InputEvent : Java.Awt.EventNs.ComponentEvent
    {
        const string _bridgeClassName = "java.awt.event.InputEvent";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("InputEvent class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public InputEvent() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("InputEvent class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public InputEvent(params object[] args) : base(args) { }

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

    #region InputEvent implementation
    public partial class InputEvent
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/InputEvent.html#ALT_DOWN_MASK"/>
        /// </summary>
        public static int ALT_DOWN_MASK { get { if (!_ALT_DOWN_MASKReady) { _ALT_DOWN_MASKContent = SGetField<int>(LocalBridgeClazz, "ALT_DOWN_MASK"); _ALT_DOWN_MASKReady = true; } return _ALT_DOWN_MASKContent; } }
        private static int _ALT_DOWN_MASKContent = default;
        private static bool _ALT_DOWN_MASKReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/InputEvent.html#ALT_GRAPH_DOWN_MASK"/>
        /// </summary>
        public static int ALT_GRAPH_DOWN_MASK { get { if (!_ALT_GRAPH_DOWN_MASKReady) { _ALT_GRAPH_DOWN_MASKContent = SGetField<int>(LocalBridgeClazz, "ALT_GRAPH_DOWN_MASK"); _ALT_GRAPH_DOWN_MASKReady = true; } return _ALT_GRAPH_DOWN_MASKContent; } }
        private static int _ALT_GRAPH_DOWN_MASKContent = default;
        private static bool _ALT_GRAPH_DOWN_MASKReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/InputEvent.html#BUTTON1_DOWN_MASK"/>
        /// </summary>
        public static int BUTTON1_DOWN_MASK { get { if (!_BUTTON1_DOWN_MASKReady) { _BUTTON1_DOWN_MASKContent = SGetField<int>(LocalBridgeClazz, "BUTTON1_DOWN_MASK"); _BUTTON1_DOWN_MASKReady = true; } return _BUTTON1_DOWN_MASKContent; } }
        private static int _BUTTON1_DOWN_MASKContent = default;
        private static bool _BUTTON1_DOWN_MASKReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/InputEvent.html#BUTTON2_DOWN_MASK"/>
        /// </summary>
        public static int BUTTON2_DOWN_MASK { get { if (!_BUTTON2_DOWN_MASKReady) { _BUTTON2_DOWN_MASKContent = SGetField<int>(LocalBridgeClazz, "BUTTON2_DOWN_MASK"); _BUTTON2_DOWN_MASKReady = true; } return _BUTTON2_DOWN_MASKContent; } }
        private static int _BUTTON2_DOWN_MASKContent = default;
        private static bool _BUTTON2_DOWN_MASKReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/InputEvent.html#BUTTON3_DOWN_MASK"/>
        /// </summary>
        public static int BUTTON3_DOWN_MASK { get { if (!_BUTTON3_DOWN_MASKReady) { _BUTTON3_DOWN_MASKContent = SGetField<int>(LocalBridgeClazz, "BUTTON3_DOWN_MASK"); _BUTTON3_DOWN_MASKReady = true; } return _BUTTON3_DOWN_MASKContent; } }
        private static int _BUTTON3_DOWN_MASKContent = default;
        private static bool _BUTTON3_DOWN_MASKReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/InputEvent.html#CTRL_DOWN_MASK"/>
        /// </summary>
        public static int CTRL_DOWN_MASK { get { if (!_CTRL_DOWN_MASKReady) { _CTRL_DOWN_MASKContent = SGetField<int>(LocalBridgeClazz, "CTRL_DOWN_MASK"); _CTRL_DOWN_MASKReady = true; } return _CTRL_DOWN_MASKContent; } }
        private static int _CTRL_DOWN_MASKContent = default;
        private static bool _CTRL_DOWN_MASKReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/InputEvent.html#META_DOWN_MASK"/>
        /// </summary>
        public static int META_DOWN_MASK { get { if (!_META_DOWN_MASKReady) { _META_DOWN_MASKContent = SGetField<int>(LocalBridgeClazz, "META_DOWN_MASK"); _META_DOWN_MASKReady = true; } return _META_DOWN_MASKContent; } }
        private static int _META_DOWN_MASKContent = default;
        private static bool _META_DOWN_MASKReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/InputEvent.html#SHIFT_DOWN_MASK"/>
        /// </summary>
        public static int SHIFT_DOWN_MASK { get { if (!_SHIFT_DOWN_MASKReady) { _SHIFT_DOWN_MASKContent = SGetField<int>(LocalBridgeClazz, "SHIFT_DOWN_MASK"); _SHIFT_DOWN_MASKReady = true; } return _SHIFT_DOWN_MASKContent; } }
        private static int _SHIFT_DOWN_MASKContent = default;
        private static bool _SHIFT_DOWN_MASKReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/InputEvent.html#getMaskForButton(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public static int GetMaskForButton(int arg0)
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "getMaskForButton", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/InputEvent.html#getModifiersExText(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String GetModifiersExText(int arg0)
        {
            return SExecuteWithSignature<Java.Lang.String>(LocalBridgeClazz, "getModifiersExText", "(I)Ljava/lang/String;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/InputEvent.html#getModifiersEx()"/> 
        /// </summary>
        public int ModifiersEx
        {
            get { return IExecuteWithSignature<int>("getModifiersEx", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/InputEvent.html#getWhen()"/> 
        /// </summary>
        public long When
        {
            get { return IExecuteWithSignature<long>("getWhen", "()J"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/InputEvent.html#isAltDown()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsAltDown()
        {
            return IExecuteWithSignature<bool>("isAltDown", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/InputEvent.html#isAltGraphDown()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsAltGraphDown()
        {
            return IExecuteWithSignature<bool>("isAltGraphDown", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/InputEvent.html#isConsumed()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsConsumed()
        {
            return IExecuteWithSignature<bool>("isConsumed", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/InputEvent.html#isControlDown()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsControlDown()
        {
            return IExecuteWithSignature<bool>("isControlDown", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/InputEvent.html#isMetaDown()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsMetaDown()
        {
            return IExecuteWithSignature<bool>("isMetaDown", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/InputEvent.html#isShiftDown()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsShiftDown()
        {
            return IExecuteWithSignature<bool>("isShiftDown", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/InputEvent.html#consume()"/>
        /// </summary>
        public void Consume()
        {
            IExecuteWithSignature("consume", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}