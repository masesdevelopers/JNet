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

namespace Javax.Sound.Midi
{
    #region ControllerEventListener declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/ControllerEventListener.html"/>
    /// </summary>
    public partial class ControllerEventListener : Java.Util.EventListener
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public ControllerEventListener() { InitializeHandlers(); }

        const string _bridgeClassName = "org.mases.jnet.generated.javax.sound.midi.ControllerEventListener";
        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
        
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;

    
        // TODO: complete the class

    }
    #endregion

    #region ControllerEventListenerDirect declaration
    /// <summary>
    /// Direct override of <see cref="ControllerEventListener"/> or its generic type if there is one
    /// </summary>
    public partial class ControllerEventListenerDirect : ControllerEventListener
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_AutoInit.htm"/>
        /// </summary>
        public override bool AutoInit => false;

        /// <inheritdoc />
        protected override void InitializeHandlers() { }

        const string _bridgeClassName = "javax.sound.midi.ControllerEventListener";
        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
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
    }
    #endregion

    #region IControllerEventListener
    /// <summary>
    /// .NET interface for org.mases.jnet.generated.javax.sound.midi.ControllerEventListener implementing <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/ControllerEventListener.html"/>
    /// </summary>
    public partial interface IControllerEventListener
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/ControllerEventListener.html#controlChange(javax.sound.midi.ShortMessage)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Midi.ShortMessage"/></param>
        void ControlChange(Javax.Sound.Midi.ShortMessage arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ControllerEventListener implementation
    public partial class ControllerEventListener : Javax.Sound.Midi.IControllerEventListener
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
        /// Handlers initializer for <see cref="ControllerEventListener"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("controlChange", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(ControlChangeEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/ControllerEventListener.html#controlChange(javax.sound.midi.ShortMessage)"/>
        /// </summary>
        /// <remarks>If <see cref="OnControlChange"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Javax.Sound.Midi.ShortMessage> OnControlChange { get; set; } = null;

        bool hasOverrideControlChange = true;
        void ControlChangeEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            var methodToExecute = (OnControlChange != null) ? OnControlChange : ControlChange;
            methodToExecute.Invoke(data.EventData.GetAt<Javax.Sound.Midi.ShortMessage>(0));
            data.EventData.TypedEventData.HasOverride = hasOverrideControlChange;
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/ControllerEventListener.html#controlChange(javax.sound.midi.ShortMessage)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Midi.ShortMessage"/></param>
        public virtual void ControlChange(Javax.Sound.Midi.ShortMessage arg0)
        {
            hasOverrideControlChange = false;
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ControllerEventListenerDirect implementation
    public partial class ControllerEventListenerDirect : Javax.Sound.Midi.IControllerEventListener
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/midi/ControllerEventListener.html#controlChange(javax.sound.midi.ShortMessage)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Midi.ShortMessage"/></param>
        public override void ControlChange(Javax.Sound.Midi.ShortMessage arg0)
        {
            IExecuteWithSignature("controlChange", "(Ljavax/sound/midi/ShortMessage;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}