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

namespace Javax.Imageio.Event
{
    #region IIOReadWarningListener declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/event/IIOReadWarningListener.html"/>
    /// </summary>
    public partial class IIOReadWarningListener : Java.Util.EventListener
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public IIOReadWarningListener() { InitializeHandlers(); }

        const string _bridgeClassName = "org.mases.jnet.generated.javax.imageio.event.IIOReadWarningListener";
        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
        
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;

    
        // TODO: complete the class

    }
    #endregion

    #region IIOReadWarningListenerDirect declaration
    /// <summary>
    /// Direct override of <see cref="IIOReadWarningListener"/> or its generic type if there is one
    /// </summary>
    public partial class IIOReadWarningListenerDirect : IIOReadWarningListener
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_AutoInit.htm"/>
        /// </summary>
        public override bool AutoInit => false;

        /// <inheritdoc />
        protected override void InitializeHandlers() { }

        const string _bridgeClassName = "javax.imageio.event.IIOReadWarningListener";
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

    #region IIIOReadWarningListener
    /// <summary>
    /// .NET interface for org.mases.jnet.generated.javax.imageio.event.IIOReadWarningListener implementing <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/event/IIOReadWarningListener.html"/>
    /// </summary>
    public partial interface IIIOReadWarningListener
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/event/IIOReadWarningListener.html#warningOccurred(javax.imageio.ImageReader,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.ImageReader"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        void WarningOccurred(Javax.Imageio.ImageReader arg0, Java.Lang.String arg1);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region IIOReadWarningListener implementation
    public partial class IIOReadWarningListener : Javax.Imageio.Event.IIIOReadWarningListener
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
        /// Handlers initializer for <see cref="IIOReadWarningListener"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("warningOccurred", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(WarningOccurredEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/event/IIOReadWarningListener.html#warningOccurred(javax.imageio.ImageReader,java.lang.String)"/>
        /// </summary>
        /// <remarks>If <see cref="OnWarningOccurred"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Javax.Imageio.ImageReader, Java.Lang.String> OnWarningOccurred { get; set; } = null;

        bool hasOverrideWarningOccurred = true;
        void WarningOccurredEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            var methodToExecute = (OnWarningOccurred != null) ? OnWarningOccurred : WarningOccurred;
            methodToExecute.Invoke(data.EventData.GetAt<Javax.Imageio.ImageReader>(0), data.EventData.GetAt<Java.Lang.String>(1));
            data.TypedEventData.HasOverride = hasOverrideWarningOccurred;
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/event/IIOReadWarningListener.html#warningOccurred(javax.imageio.ImageReader,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.ImageReader"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        public virtual void WarningOccurred(Javax.Imageio.ImageReader arg0, Java.Lang.String arg1)
        {
            hasOverrideWarningOccurred = false;
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region IIOReadWarningListenerDirect implementation
    public partial class IIOReadWarningListenerDirect : Javax.Imageio.Event.IIIOReadWarningListener
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/event/IIOReadWarningListener.html#warningOccurred(javax.imageio.ImageReader,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.ImageReader"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        public override void WarningOccurred(Javax.Imageio.ImageReader arg0, Java.Lang.String arg1)
        {
            IExecute("warningOccurred", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}