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
    #region IIOWriteWarningListener declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/event/IIOWriteWarningListener.html"/>
    /// </summary>
    public partial class IIOWriteWarningListener : Java.Util.EventListener
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public IIOWriteWarningListener() { InitializeHandlers(); }

        const string _bridgeClassName = "org.mases.jnet.generated.javax.imageio.event.IIOWriteWarningListener";
        private static readonly IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new InvalidOperationException($"Class {_bridgeClassName} was not found.");
        
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;

    
        // TODO: complete the class

    }
    #endregion

    #region IIOWriteWarningListenerDirect declaration
    /// <summary>
    /// Direct override of <see cref="IIOWriteWarningListener"/> or its generic type if there is one
    /// </summary>
    public partial class IIOWriteWarningListenerDirect : IIOWriteWarningListener
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_AutoInit.htm"/>
        /// </summary>
        public override bool AutoInit => false;

        /// <inheritdoc />
        protected override void InitializeHandlers() { }

        const string _bridgeClassName = "javax.imageio.event.IIOWriteWarningListener";
        private static readonly IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new InvalidOperationException($"Class {_bridgeClassName} was not found.");

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

    #region IIIOWriteWarningListener
    /// <summary>
    /// .NET interface for org.mases.jnet.generated.javax.imageio.event.IIOWriteWarningListener implementing <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/event/IIOWriteWarningListener.html"/>
    /// </summary>
    public partial interface IIIOWriteWarningListener
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/event/IIOWriteWarningListener.html#warningOccurred(javax.imageio.ImageWriter,int,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.ImageWriter"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        void WarningOccurred(Javax.Imageio.ImageWriter arg0, int arg1, Java.Lang.String arg2);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region IIOWriteWarningListener implementation
    public partial class IIOWriteWarningListener : Javax.Imageio.Event.IIIOWriteWarningListener
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
        /// Handlers initializer for <see cref="IIOWriteWarningListener"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("warningOccurred", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Javax.Imageio.ImageWriter>>>(WarningOccurredEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/event/IIOWriteWarningListener.html#warningOccurred(javax.imageio.ImageWriter,int,java.lang.String)"/>
        /// </summary>
        /// <remarks>If <see cref="OnWarningOccurred"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Javax.Imageio.ImageWriter, int, Java.Lang.String> OnWarningOccurred { get; set; } = null;

        void WarningOccurredEventHandler(object sender, CLRListenerEventArgs<CLREventData<Javax.Imageio.ImageWriter>> data)
        {
            var methodToExecute = (OnWarningOccurred != null) ? OnWarningOccurred : WarningOccurred;
            methodToExecute.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<int>(0), data.EventData.GetAt<Java.Lang.String>(1));
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/event/IIOWriteWarningListener.html#warningOccurred(javax.imageio.ImageWriter,int,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.ImageWriter"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        public virtual void WarningOccurred(Javax.Imageio.ImageWriter arg0, int arg1, Java.Lang.String arg2)
        {
            
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region IIOWriteWarningListenerDirect implementation
    public partial class IIOWriteWarningListenerDirect : Javax.Imageio.Event.IIIOWriteWarningListener
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/event/IIOWriteWarningListener.html#warningOccurred(javax.imageio.ImageWriter,int,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.ImageWriter"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        public override void WarningOccurred(Javax.Imageio.ImageWriter arg0, int arg1, Java.Lang.String arg2)
        {
            IExecute("warningOccurred", arg0, arg1, arg2);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}