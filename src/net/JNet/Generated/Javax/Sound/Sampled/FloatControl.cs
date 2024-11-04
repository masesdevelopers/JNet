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
*  This file is generated by MASES.JNetReflector (ver. 2.5.10.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Sound.Sampled
{
    #region FloatControl declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/FloatControl.html"/>
    /// </summary>
    public partial class FloatControl : Javax.Sound.Sampled.Control
    {
        const string _bridgeClassName = "javax.sound.sampled.FloatControl";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("FloatControl class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public FloatControl() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("FloatControl class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public FloatControl(params object[] args) : base(args) { }

        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

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
        #region Type declaration
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/FloatControl.Type.html"/>
        /// </summary>
        public partial class Type : Javax.Sound.Sampled.Control.Type
        {
            const string _bridgeClassName = "javax.sound.sampled.FloatControl$Type";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public Type() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public Type(params object[] args) : base(args) { }

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
            public override bool IsBridgeStatic => true;

            // TODO: complete the class

        }
        #endregion

    
    }
    #endregion

    #region FloatControl implementation
    public partial class FloatControl
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/FloatControl.html#getMaximum()"/> 
        /// </summary>
        public float Maximum
        {
            get { return IExecuteWithSignature<float>("getMaximum", "()F"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/FloatControl.html#getMaxLabel()"/> 
        /// </summary>
        public Java.Lang.String MaxLabel
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getMaxLabel", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/FloatControl.html#getMidLabel()"/> 
        /// </summary>
        public Java.Lang.String MidLabel
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getMidLabel", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/FloatControl.html#getMinimum()"/> 
        /// </summary>
        public float Minimum
        {
            get { return IExecuteWithSignature<float>("getMinimum", "()F"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/FloatControl.html#getMinLabel()"/> 
        /// </summary>
        public Java.Lang.String MinLabel
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getMinLabel", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/FloatControl.html#getPrecision()"/> 
        /// </summary>
        public float Precision
        {
            get { return IExecuteWithSignature<float>("getPrecision", "()F"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/FloatControl.html#getUnits()"/> 
        /// </summary>
        public Java.Lang.String Units
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getUnits", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/FloatControl.html#getUpdatePeriod()"/> 
        /// </summary>
        public int UpdatePeriod
        {
            get { return IExecuteWithSignature<int>("getUpdatePeriod", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/FloatControl.html#getValue()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/FloatControl.html#setValue(float)"/>
        /// </summary>
        public float Value
        {
            get { return IExecuteWithSignature<float>("getValue", "()F"); } set { IExecuteWithSignature("setValue", "(F)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/FloatControl.html#shift(float,float,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public void Shift(float arg0, float arg1, int arg2)
        {
            IExecuteWithSignature("shift", "(FFI)V", arg0, arg1, arg2);
        }

        #endregion

        #region Nested classes
        #region Type implementation
        public partial class Type
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/FloatControl.Type.html#AUX_RETURN"/>
            /// </summary>
            public static Javax.Sound.Sampled.FloatControl.Type AUX_RETURN { get { if (!_AUX_RETURNReady) { _AUX_RETURNContent = SGetField<Javax.Sound.Sampled.FloatControl.Type>(LocalBridgeClazz, "AUX_RETURN"); _AUX_RETURNReady = true; } return _AUX_RETURNContent; } }
            private static Javax.Sound.Sampled.FloatControl.Type _AUX_RETURNContent = default;
            private static bool _AUX_RETURNReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/FloatControl.Type.html#AUX_SEND"/>
            /// </summary>
            public static Javax.Sound.Sampled.FloatControl.Type AUX_SEND { get { if (!_AUX_SENDReady) { _AUX_SENDContent = SGetField<Javax.Sound.Sampled.FloatControl.Type>(LocalBridgeClazz, "AUX_SEND"); _AUX_SENDReady = true; } return _AUX_SENDContent; } }
            private static Javax.Sound.Sampled.FloatControl.Type _AUX_SENDContent = default;
            private static bool _AUX_SENDReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/FloatControl.Type.html#BALANCE"/>
            /// </summary>
            public static Javax.Sound.Sampled.FloatControl.Type BALANCE { get { if (!_BALANCEReady) { _BALANCEContent = SGetField<Javax.Sound.Sampled.FloatControl.Type>(LocalBridgeClazz, "BALANCE"); _BALANCEReady = true; } return _BALANCEContent; } }
            private static Javax.Sound.Sampled.FloatControl.Type _BALANCEContent = default;
            private static bool _BALANCEReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/FloatControl.Type.html#MASTER_GAIN"/>
            /// </summary>
            public static Javax.Sound.Sampled.FloatControl.Type MASTER_GAIN { get { if (!_MASTER_GAINReady) { _MASTER_GAINContent = SGetField<Javax.Sound.Sampled.FloatControl.Type>(LocalBridgeClazz, "MASTER_GAIN"); _MASTER_GAINReady = true; } return _MASTER_GAINContent; } }
            private static Javax.Sound.Sampled.FloatControl.Type _MASTER_GAINContent = default;
            private static bool _MASTER_GAINReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/FloatControl.Type.html#PAN"/>
            /// </summary>
            public static Javax.Sound.Sampled.FloatControl.Type PAN { get { if (!_PANReady) { _PANContent = SGetField<Javax.Sound.Sampled.FloatControl.Type>(LocalBridgeClazz, "PAN"); _PANReady = true; } return _PANContent; } }
            private static Javax.Sound.Sampled.FloatControl.Type _PANContent = default;
            private static bool _PANReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/FloatControl.Type.html#REVERB_RETURN"/>
            /// </summary>
            public static Javax.Sound.Sampled.FloatControl.Type REVERB_RETURN { get { if (!_REVERB_RETURNReady) { _REVERB_RETURNContent = SGetField<Javax.Sound.Sampled.FloatControl.Type>(LocalBridgeClazz, "REVERB_RETURN"); _REVERB_RETURNReady = true; } return _REVERB_RETURNContent; } }
            private static Javax.Sound.Sampled.FloatControl.Type _REVERB_RETURNContent = default;
            private static bool _REVERB_RETURNReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/FloatControl.Type.html#REVERB_SEND"/>
            /// </summary>
            public static Javax.Sound.Sampled.FloatControl.Type REVERB_SEND { get { if (!_REVERB_SENDReady) { _REVERB_SENDContent = SGetField<Javax.Sound.Sampled.FloatControl.Type>(LocalBridgeClazz, "REVERB_SEND"); _REVERB_SENDReady = true; } return _REVERB_SENDContent; } }
            private static Javax.Sound.Sampled.FloatControl.Type _REVERB_SENDContent = default;
            private static bool _REVERB_SENDReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/FloatControl.Type.html#SAMPLE_RATE"/>
            /// </summary>
            public static Javax.Sound.Sampled.FloatControl.Type SAMPLE_RATE { get { if (!_SAMPLE_RATEReady) { _SAMPLE_RATEContent = SGetField<Javax.Sound.Sampled.FloatControl.Type>(LocalBridgeClazz, "SAMPLE_RATE"); _SAMPLE_RATEReady = true; } return _SAMPLE_RATEContent; } }
            private static Javax.Sound.Sampled.FloatControl.Type _SAMPLE_RATEContent = default;
            private static bool _SAMPLE_RATEReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/FloatControl.Type.html#VOLUME"/>
            /// </summary>
            public static Javax.Sound.Sampled.FloatControl.Type VOLUME { get { if (!_VOLUMEReady) { _VOLUMEContent = SGetField<Javax.Sound.Sampled.FloatControl.Type>(LocalBridgeClazz, "VOLUME"); _VOLUMEReady = true; } return _VOLUMEContent; } }
            private static Javax.Sound.Sampled.FloatControl.Type _VOLUMEContent = default;
            private static bool _VOLUMEReady = false; // this is used because in case of generics 

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

    
        #endregion

        // TODO: complete the class
    }
    #endregion
}