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

namespace Java.Awt.DesktopNs
{
    #region ScreenSleepListener declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/desktop/ScreenSleepListener.html"/>
    /// </summary>
    public partial class ScreenSleepListener : MASES.JCOBridge.C2JBridge.JVMBridgeListener
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public ScreenSleepListener() { InitializeHandlers(); }

        const string _bridgeClassName = "org.mases.jnet.generated.java.awt.desktop.ScreenSleepListener";
        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
        
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;

    
        // TODO: complete the class

    }
    #endregion

    #region ScreenSleepListenerDirect declaration
    /// <summary>
    /// Direct override of <see cref="ScreenSleepListener"/> or its generic type if there is one
    /// </summary>
    public partial class ScreenSleepListenerDirect : ScreenSleepListener
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_AutoInit.htm"/>
        /// </summary>
        public override bool AutoInit => false;

        /// <inheritdoc />
        protected override void InitializeHandlers() { }

        const string _bridgeClassName = "java.awt.desktop.ScreenSleepListener";
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

    #region IScreenSleepListener
    /// <summary>
    /// .NET interface for org.mases.jnet.generated.java.awt.desktop.ScreenSleepListener implementing <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/desktop/ScreenSleepListener.html"/>
    /// </summary>
    public partial interface IScreenSleepListener
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/desktop/ScreenSleepListener.html#screenAboutToSleep(java.awt.desktop.ScreenSleepEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.DesktopNs.ScreenSleepEvent"/></param>
        void ScreenAboutToSleep(Java.Awt.DesktopNs.ScreenSleepEvent arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/desktop/ScreenSleepListener.html#screenAwoke(java.awt.desktop.ScreenSleepEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.DesktopNs.ScreenSleepEvent"/></param>
        void ScreenAwoke(Java.Awt.DesktopNs.ScreenSleepEvent arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ScreenSleepListener implementation
    public partial class ScreenSleepListener : Java.Awt.DesktopNs.IScreenSleepListener
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
        /// Handlers initializer for <see cref="ScreenSleepListener"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("screenAboutToSleep", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(ScreenAboutToSleepEventHandler));
            AddEventHandler("screenAwoke", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(ScreenAwokeEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/desktop/ScreenSleepListener.html#screenAboutToSleep(java.awt.desktop.ScreenSleepEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnScreenAboutToSleep"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Java.Awt.DesktopNs.ScreenSleepEvent> OnScreenAboutToSleep { get; set; } = null;

        bool hasOverrideScreenAboutToSleep = true;
        void ScreenAboutToSleepEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideScreenAboutToSleep = true;
            var methodToExecute = (OnScreenAboutToSleep != null) ? OnScreenAboutToSleep : ScreenAboutToSleep;
            methodToExecute.Invoke(data.EventData.GetAt<Java.Awt.DesktopNs.ScreenSleepEvent>(0));
            data.EventData.TypedEventData.HasOverride = hasOverrideScreenAboutToSleep;
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/desktop/ScreenSleepListener.html#screenAboutToSleep(java.awt.desktop.ScreenSleepEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.DesktopNs.ScreenSleepEvent"/></param>
        public virtual void ScreenAboutToSleep(Java.Awt.DesktopNs.ScreenSleepEvent arg0)
        {
            hasOverrideScreenAboutToSleep = false;
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/desktop/ScreenSleepListener.html#screenAwoke(java.awt.desktop.ScreenSleepEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnScreenAwoke"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Java.Awt.DesktopNs.ScreenSleepEvent> OnScreenAwoke { get; set; } = null;

        bool hasOverrideScreenAwoke = true;
        void ScreenAwokeEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideScreenAwoke = true;
            var methodToExecute = (OnScreenAwoke != null) ? OnScreenAwoke : ScreenAwoke;
            methodToExecute.Invoke(data.EventData.GetAt<Java.Awt.DesktopNs.ScreenSleepEvent>(0));
            data.EventData.TypedEventData.HasOverride = hasOverrideScreenAwoke;
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/desktop/ScreenSleepListener.html#screenAwoke(java.awt.desktop.ScreenSleepEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.DesktopNs.ScreenSleepEvent"/></param>
        public virtual void ScreenAwoke(Java.Awt.DesktopNs.ScreenSleepEvent arg0)
        {
            hasOverrideScreenAwoke = false;
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ScreenSleepListenerDirect implementation
    public partial class ScreenSleepListenerDirect : Java.Awt.DesktopNs.IScreenSleepListener
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/desktop/ScreenSleepListener.html#screenAboutToSleep(java.awt.desktop.ScreenSleepEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.DesktopNs.ScreenSleepEvent"/></param>
        public override void ScreenAboutToSleep(Java.Awt.DesktopNs.ScreenSleepEvent arg0)
        {
            IExecuteWithSignature("screenAboutToSleep", "(Ljava/awt/desktop/ScreenSleepEvent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/desktop/ScreenSleepListener.html#screenAwoke(java.awt.desktop.ScreenSleepEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.DesktopNs.ScreenSleepEvent"/></param>
        public override void ScreenAwoke(Java.Awt.DesktopNs.ScreenSleepEvent arg0)
        {
            IExecuteWithSignature("screenAwoke", "(Ljava/awt/desktop/ScreenSleepEvent;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}