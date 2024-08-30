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
    #region AdjustmentEvent declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/AdjustmentEvent.html"/>
    /// </summary>
    public partial class AdjustmentEvent : Java.Awt.AWTEvent
    {
        const string _bridgeClassName = "java.awt.event.AdjustmentEvent";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public AdjustmentEvent() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public AdjustmentEvent(params object[] args) : base(args) { }

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

    #region AdjustmentEvent implementation
    public partial class AdjustmentEvent
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/AdjustmentEvent.html#%3Cinit%3E(java.awt.Adjustable,int,int,int,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Adjustable"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="bool"/></param>
        public AdjustmentEvent(Java.Awt.Adjustable arg0, int arg1, int arg2, int arg3, bool arg4)
            : base(arg0, arg1, arg2, arg3, arg4)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/AdjustmentEvent.html#%3Cinit%3E(java.awt.Adjustable,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Adjustable"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public AdjustmentEvent(Java.Awt.Adjustable arg0, int arg1, int arg2, int arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/AdjustmentEvent.html#ADJUSTMENT_FIRST"/>
        /// </summary>
        public static int ADJUSTMENT_FIRST { get { if (!_ADJUSTMENT_FIRSTReady) { _ADJUSTMENT_FIRSTContent = SGetField<int>(LocalBridgeClazz, "ADJUSTMENT_FIRST"); _ADJUSTMENT_FIRSTReady = true; } return _ADJUSTMENT_FIRSTContent; } }
        private static int _ADJUSTMENT_FIRSTContent = default;
        private static bool _ADJUSTMENT_FIRSTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/AdjustmentEvent.html#ADJUSTMENT_LAST"/>
        /// </summary>
        public static int ADJUSTMENT_LAST { get { if (!_ADJUSTMENT_LASTReady) { _ADJUSTMENT_LASTContent = SGetField<int>(LocalBridgeClazz, "ADJUSTMENT_LAST"); _ADJUSTMENT_LASTReady = true; } return _ADJUSTMENT_LASTContent; } }
        private static int _ADJUSTMENT_LASTContent = default;
        private static bool _ADJUSTMENT_LASTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/AdjustmentEvent.html#ADJUSTMENT_VALUE_CHANGED"/>
        /// </summary>
        public static int ADJUSTMENT_VALUE_CHANGED { get { if (!_ADJUSTMENT_VALUE_CHANGEDReady) { _ADJUSTMENT_VALUE_CHANGEDContent = SGetField<int>(LocalBridgeClazz, "ADJUSTMENT_VALUE_CHANGED"); _ADJUSTMENT_VALUE_CHANGEDReady = true; } return _ADJUSTMENT_VALUE_CHANGEDContent; } }
        private static int _ADJUSTMENT_VALUE_CHANGEDContent = default;
        private static bool _ADJUSTMENT_VALUE_CHANGEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/AdjustmentEvent.html#BLOCK_DECREMENT"/>
        /// </summary>
        public static int BLOCK_DECREMENT { get { if (!_BLOCK_DECREMENTReady) { _BLOCK_DECREMENTContent = SGetField<int>(LocalBridgeClazz, "BLOCK_DECREMENT"); _BLOCK_DECREMENTReady = true; } return _BLOCK_DECREMENTContent; } }
        private static int _BLOCK_DECREMENTContent = default;
        private static bool _BLOCK_DECREMENTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/AdjustmentEvent.html#BLOCK_INCREMENT"/>
        /// </summary>
        public static int BLOCK_INCREMENT { get { if (!_BLOCK_INCREMENTReady) { _BLOCK_INCREMENTContent = SGetField<int>(LocalBridgeClazz, "BLOCK_INCREMENT"); _BLOCK_INCREMENTReady = true; } return _BLOCK_INCREMENTContent; } }
        private static int _BLOCK_INCREMENTContent = default;
        private static bool _BLOCK_INCREMENTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/AdjustmentEvent.html#TRACK"/>
        /// </summary>
        public static int TRACK { get { if (!_TRACKReady) { _TRACKContent = SGetField<int>(LocalBridgeClazz, "TRACK"); _TRACKReady = true; } return _TRACKContent; } }
        private static int _TRACKContent = default;
        private static bool _TRACKReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/AdjustmentEvent.html#UNIT_DECREMENT"/>
        /// </summary>
        public static int UNIT_DECREMENT { get { if (!_UNIT_DECREMENTReady) { _UNIT_DECREMENTContent = SGetField<int>(LocalBridgeClazz, "UNIT_DECREMENT"); _UNIT_DECREMENTReady = true; } return _UNIT_DECREMENTContent; } }
        private static int _UNIT_DECREMENTContent = default;
        private static bool _UNIT_DECREMENTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/AdjustmentEvent.html#UNIT_INCREMENT"/>
        /// </summary>
        public static int UNIT_INCREMENT { get { if (!_UNIT_INCREMENTReady) { _UNIT_INCREMENTContent = SGetField<int>(LocalBridgeClazz, "UNIT_INCREMENT"); _UNIT_INCREMENTReady = true; } return _UNIT_INCREMENTContent; } }
        private static int _UNIT_INCREMENTContent = default;
        private static bool _UNIT_INCREMENTReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/AdjustmentEvent.html#getAdjustable()"/> 
        /// </summary>
        public Java.Awt.Adjustable Adjustable
        {
            get { return IExecuteWithSignature<Java.Awt.Adjustable>("getAdjustable", "()Ljava/awt/Adjustable;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/AdjustmentEvent.html#getAdjustmentType()"/> 
        /// </summary>
        public int AdjustmentType
        {
            get { return IExecuteWithSignature<int>("getAdjustmentType", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/AdjustmentEvent.html#getValue()"/> 
        /// </summary>
        public int Value
        {
            get { return IExecuteWithSignature<int>("getValue", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/AdjustmentEvent.html#getValueIsAdjusting()"/> 
        /// </summary>
        public bool ValueIsAdjusting
        {
            get { return IExecuteWithSignature<bool>("getValueIsAdjusting", "()Z"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}