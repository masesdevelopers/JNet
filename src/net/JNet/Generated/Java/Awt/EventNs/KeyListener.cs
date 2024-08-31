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
    #region KeyListener declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/KeyListener.html"/>
    /// </summary>
    public partial class KeyListener : Java.Util.EventListener
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public KeyListener() { InitializeHandlers(); }

        const string _bridgeClassName = "org.mases.jnet.generated.java.awt.event.KeyListener";
        private static readonly IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new InvalidOperationException($"Class {_bridgeClassName} was not found.");
        
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;

    
        // TODO: complete the class

    }
    #endregion

    #region KeyListenerDirect declaration
    /// <summary>
    /// Direct override of <see cref="KeyListener"/> or its generic type if there is one
    /// </summary>
    public partial class KeyListenerDirect : KeyListener
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_AutoInit.htm"/>
        /// </summary>
        public override bool AutoInit => false;

        /// <inheritdoc />
        protected override void InitializeHandlers() { }

        const string _bridgeClassName = "java.awt.event.KeyListener";
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

    #region IKeyListener
    /// <summary>
    /// .NET interface for org.mases.jnet.generated.java.awt.event.KeyListener implementing <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/KeyListener.html"/>
    /// </summary>
    public partial interface IKeyListener
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/KeyListener.html#keyPressed(java.awt.event.KeyEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.KeyEvent"/></param>
        void KeyPressed(Java.Awt.EventNs.KeyEvent arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/KeyListener.html#keyReleased(java.awt.event.KeyEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.KeyEvent"/></param>
        void KeyReleased(Java.Awt.EventNs.KeyEvent arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/KeyListener.html#keyTyped(java.awt.event.KeyEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.KeyEvent"/></param>
        void KeyTyped(Java.Awt.EventNs.KeyEvent arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region KeyListener implementation
    public partial class KeyListener : Java.Awt.EventNs.IKeyListener
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
        /// Handlers initializer for <see cref="KeyListener"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("keyPressed", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.KeyEvent>>>(KeyPressedEventHandler));
            AddEventHandler("keyReleased", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.KeyEvent>>>(KeyReleasedEventHandler));
            AddEventHandler("keyTyped", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.KeyEvent>>>(KeyTypedEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/KeyListener.html#keyPressed(java.awt.event.KeyEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnKeyPressed"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Java.Awt.EventNs.KeyEvent> OnKeyPressed { get; set; } = null;

        void KeyPressedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.KeyEvent>> data)
        {
            var methodToExecute = (OnKeyPressed != null) ? OnKeyPressed : KeyPressed;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/KeyListener.html#keyPressed(java.awt.event.KeyEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.KeyEvent"/></param>
        public virtual void KeyPressed(Java.Awt.EventNs.KeyEvent arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/KeyListener.html#keyReleased(java.awt.event.KeyEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnKeyReleased"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Java.Awt.EventNs.KeyEvent> OnKeyReleased { get; set; } = null;

        void KeyReleasedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.KeyEvent>> data)
        {
            var methodToExecute = (OnKeyReleased != null) ? OnKeyReleased : KeyReleased;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/KeyListener.html#keyReleased(java.awt.event.KeyEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.KeyEvent"/></param>
        public virtual void KeyReleased(Java.Awt.EventNs.KeyEvent arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/KeyListener.html#keyTyped(java.awt.event.KeyEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnKeyTyped"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Java.Awt.EventNs.KeyEvent> OnKeyTyped { get; set; } = null;

        void KeyTypedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.KeyEvent>> data)
        {
            var methodToExecute = (OnKeyTyped != null) ? OnKeyTyped : KeyTyped;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/KeyListener.html#keyTyped(java.awt.event.KeyEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.KeyEvent"/></param>
        public virtual void KeyTyped(Java.Awt.EventNs.KeyEvent arg0)
        {
            
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region KeyListenerDirect implementation
    public partial class KeyListenerDirect : Java.Awt.EventNs.IKeyListener
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/KeyListener.html#keyPressed(java.awt.event.KeyEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.KeyEvent"/></param>
        public override void KeyPressed(Java.Awt.EventNs.KeyEvent arg0)
        {
            IExecuteWithSignature("keyPressed", "(Ljava/awt/event/KeyEvent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/KeyListener.html#keyReleased(java.awt.event.KeyEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.KeyEvent"/></param>
        public override void KeyReleased(Java.Awt.EventNs.KeyEvent arg0)
        {
            IExecuteWithSignature("keyReleased", "(Ljava/awt/event/KeyEvent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/KeyListener.html#keyTyped(java.awt.event.KeyEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.KeyEvent"/></param>
        public override void KeyTyped(Java.Awt.EventNs.KeyEvent arg0)
        {
            IExecuteWithSignature("keyTyped", "(Ljava/awt/event/KeyEvent;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}