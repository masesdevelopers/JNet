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
*  This file is generated by MASES.JNetReflector (ver. 2.5.11.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Imageio.Event
{
    #region IIOWriteProgressListener declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/event/IIOWriteProgressListener.html"/>
    /// </summary>
    public partial class IIOWriteProgressListener : Java.Util.EventListener
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public IIOWriteProgressListener() { InitializeHandlers(); }

        const string _bridgeClassName = "org.mases.jnet.generated.javax.imageio.event.IIOWriteProgressListener";
        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
        
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;

    
        // TODO: complete the class

    }
    #endregion

    #region IIOWriteProgressListenerDirect declaration
    /// <summary>
    /// Direct override of <see cref="IIOWriteProgressListener"/> or its generic type if there is one
    /// </summary>
    public partial class IIOWriteProgressListenerDirect : IIOWriteProgressListener
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_AutoInit.htm"/>
        /// </summary>
        public override bool AutoInit => false;

        /// <inheritdoc />
        protected override void InitializeHandlers() { }

        const string _bridgeClassName = "javax.imageio.event.IIOWriteProgressListener";
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

    #region IIIOWriteProgressListener
    /// <summary>
    /// .NET interface for org.mases.jnet.generated.javax.imageio.event.IIOWriteProgressListener implementing <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/event/IIOWriteProgressListener.html"/>
    /// </summary>
    public partial interface IIIOWriteProgressListener
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/event/IIOWriteProgressListener.html#imageComplete(javax.imageio.ImageWriter)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.ImageWriter"/></param>
        void ImageComplete(Javax.Imageio.ImageWriter arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/event/IIOWriteProgressListener.html#imageProgress(javax.imageio.ImageWriter,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.ImageWriter"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        void ImageProgress(Javax.Imageio.ImageWriter arg0, float arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/event/IIOWriteProgressListener.html#imageStarted(javax.imageio.ImageWriter,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.ImageWriter"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        void ImageStarted(Javax.Imageio.ImageWriter arg0, int arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/event/IIOWriteProgressListener.html#thumbnailComplete(javax.imageio.ImageWriter)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.ImageWriter"/></param>
        void ThumbnailComplete(Javax.Imageio.ImageWriter arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/event/IIOWriteProgressListener.html#thumbnailProgress(javax.imageio.ImageWriter,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.ImageWriter"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        void ThumbnailProgress(Javax.Imageio.ImageWriter arg0, float arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/event/IIOWriteProgressListener.html#thumbnailStarted(javax.imageio.ImageWriter,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.ImageWriter"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        void ThumbnailStarted(Javax.Imageio.ImageWriter arg0, int arg1, int arg2);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/event/IIOWriteProgressListener.html#writeAborted(javax.imageio.ImageWriter)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.ImageWriter"/></param>
        void WriteAborted(Javax.Imageio.ImageWriter arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region IIOWriteProgressListener implementation
    public partial class IIOWriteProgressListener : Javax.Imageio.Event.IIIOWriteProgressListener
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
        /// Handlers initializer for <see cref="IIOWriteProgressListener"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("imageComplete", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(ImageCompleteEventHandler));
            AddEventHandler("imageProgress", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(ImageProgressEventHandler));
            AddEventHandler("imageStarted", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(ImageStartedEventHandler));
            AddEventHandler("thumbnailComplete", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(ThumbnailCompleteEventHandler));
            AddEventHandler("thumbnailProgress", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(ThumbnailProgressEventHandler));
            AddEventHandler("thumbnailStarted", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(ThumbnailStartedEventHandler));
            AddEventHandler("writeAborted", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>>>(WriteAbortedEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/event/IIOWriteProgressListener.html#imageComplete(javax.imageio.ImageWriter)"/>
        /// </summary>
        /// <remarks>If <see cref="OnImageComplete"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Javax.Imageio.ImageWriter> OnImageComplete { get; set; } = null;

        bool hasOverrideImageComplete = true;
        void ImageCompleteEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideImageComplete = true;
            var methodToExecute = (OnImageComplete != null) ? OnImageComplete : ImageComplete;
            methodToExecute.Invoke(data.EventData.GetAt<Javax.Imageio.ImageWriter>(0));
            data.EventData.TypedEventData.HasOverride = hasOverrideImageComplete;
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/event/IIOWriteProgressListener.html#imageComplete(javax.imageio.ImageWriter)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.ImageWriter"/></param>
        public virtual void ImageComplete(Javax.Imageio.ImageWriter arg0)
        {
            hasOverrideImageComplete = false;
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/event/IIOWriteProgressListener.html#imageProgress(javax.imageio.ImageWriter,float)"/>
        /// </summary>
        /// <remarks>If <see cref="OnImageProgress"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Javax.Imageio.ImageWriter, float> OnImageProgress { get; set; } = null;

        bool hasOverrideImageProgress = true;
        void ImageProgressEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideImageProgress = true;
            var methodToExecute = (OnImageProgress != null) ? OnImageProgress : ImageProgress;
            methodToExecute.Invoke(data.EventData.GetAt<Javax.Imageio.ImageWriter>(0), data.EventData.GetAt<float>(1));
            data.EventData.TypedEventData.HasOverride = hasOverrideImageProgress;
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/event/IIOWriteProgressListener.html#imageProgress(javax.imageio.ImageWriter,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.ImageWriter"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        public virtual void ImageProgress(Javax.Imageio.ImageWriter arg0, float arg1)
        {
            hasOverrideImageProgress = false;
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/event/IIOWriteProgressListener.html#imageStarted(javax.imageio.ImageWriter,int)"/>
        /// </summary>
        /// <remarks>If <see cref="OnImageStarted"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Javax.Imageio.ImageWriter, int> OnImageStarted { get; set; } = null;

        bool hasOverrideImageStarted = true;
        void ImageStartedEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideImageStarted = true;
            var methodToExecute = (OnImageStarted != null) ? OnImageStarted : ImageStarted;
            methodToExecute.Invoke(data.EventData.GetAt<Javax.Imageio.ImageWriter>(0), data.EventData.GetAt<int>(1));
            data.EventData.TypedEventData.HasOverride = hasOverrideImageStarted;
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/event/IIOWriteProgressListener.html#imageStarted(javax.imageio.ImageWriter,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.ImageWriter"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public virtual void ImageStarted(Javax.Imageio.ImageWriter arg0, int arg1)
        {
            hasOverrideImageStarted = false;
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/event/IIOWriteProgressListener.html#thumbnailComplete(javax.imageio.ImageWriter)"/>
        /// </summary>
        /// <remarks>If <see cref="OnThumbnailComplete"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Javax.Imageio.ImageWriter> OnThumbnailComplete { get; set; } = null;

        bool hasOverrideThumbnailComplete = true;
        void ThumbnailCompleteEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideThumbnailComplete = true;
            var methodToExecute = (OnThumbnailComplete != null) ? OnThumbnailComplete : ThumbnailComplete;
            methodToExecute.Invoke(data.EventData.GetAt<Javax.Imageio.ImageWriter>(0));
            data.EventData.TypedEventData.HasOverride = hasOverrideThumbnailComplete;
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/event/IIOWriteProgressListener.html#thumbnailComplete(javax.imageio.ImageWriter)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.ImageWriter"/></param>
        public virtual void ThumbnailComplete(Javax.Imageio.ImageWriter arg0)
        {
            hasOverrideThumbnailComplete = false;
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/event/IIOWriteProgressListener.html#thumbnailProgress(javax.imageio.ImageWriter,float)"/>
        /// </summary>
        /// <remarks>If <see cref="OnThumbnailProgress"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Javax.Imageio.ImageWriter, float> OnThumbnailProgress { get; set; } = null;

        bool hasOverrideThumbnailProgress = true;
        void ThumbnailProgressEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideThumbnailProgress = true;
            var methodToExecute = (OnThumbnailProgress != null) ? OnThumbnailProgress : ThumbnailProgress;
            methodToExecute.Invoke(data.EventData.GetAt<Javax.Imageio.ImageWriter>(0), data.EventData.GetAt<float>(1));
            data.EventData.TypedEventData.HasOverride = hasOverrideThumbnailProgress;
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/event/IIOWriteProgressListener.html#thumbnailProgress(javax.imageio.ImageWriter,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.ImageWriter"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        public virtual void ThumbnailProgress(Javax.Imageio.ImageWriter arg0, float arg1)
        {
            hasOverrideThumbnailProgress = false;
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/event/IIOWriteProgressListener.html#thumbnailStarted(javax.imageio.ImageWriter,int,int)"/>
        /// </summary>
        /// <remarks>If <see cref="OnThumbnailStarted"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Javax.Imageio.ImageWriter, int, int> OnThumbnailStarted { get; set; } = null;

        bool hasOverrideThumbnailStarted = true;
        void ThumbnailStartedEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideThumbnailStarted = true;
            var methodToExecute = (OnThumbnailStarted != null) ? OnThumbnailStarted : ThumbnailStarted;
            methodToExecute.Invoke(data.EventData.GetAt<Javax.Imageio.ImageWriter>(0), data.EventData.GetAt<int>(1), data.EventData.GetAt<int>(2));
            data.EventData.TypedEventData.HasOverride = hasOverrideThumbnailStarted;
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/event/IIOWriteProgressListener.html#thumbnailStarted(javax.imageio.ImageWriter,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.ImageWriter"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public virtual void ThumbnailStarted(Javax.Imageio.ImageWriter arg0, int arg1, int arg2)
        {
            hasOverrideThumbnailStarted = false;
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/event/IIOWriteProgressListener.html#writeAborted(javax.imageio.ImageWriter)"/>
        /// </summary>
        /// <remarks>If <see cref="OnWriteAborted"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Javax.Imageio.ImageWriter> OnWriteAborted { get; set; } = null;

        bool hasOverrideWriteAborted = true;
        void WriteAbortedEventHandler(object sender, CLRListenerEventArgs<CLREventData<MASES.JNet.Specific.JNetEventResult>> data)
        {
            hasOverrideWriteAborted = true;
            var methodToExecute = (OnWriteAborted != null) ? OnWriteAborted : WriteAborted;
            methodToExecute.Invoke(data.EventData.GetAt<Javax.Imageio.ImageWriter>(0));
            data.EventData.TypedEventData.HasOverride = hasOverrideWriteAborted;
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/event/IIOWriteProgressListener.html#writeAborted(javax.imageio.ImageWriter)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.ImageWriter"/></param>
        public virtual void WriteAborted(Javax.Imageio.ImageWriter arg0)
        {
            hasOverrideWriteAborted = false;
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region IIOWriteProgressListenerDirect implementation
    public partial class IIOWriteProgressListenerDirect : Javax.Imageio.Event.IIIOWriteProgressListener
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/event/IIOWriteProgressListener.html#imageComplete(javax.imageio.ImageWriter)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.ImageWriter"/></param>
        public override void ImageComplete(Javax.Imageio.ImageWriter arg0)
        {
            IExecuteWithSignature("imageComplete", "(Ljavax/imageio/ImageWriter;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/event/IIOWriteProgressListener.html#imageProgress(javax.imageio.ImageWriter,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.ImageWriter"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        public override void ImageProgress(Javax.Imageio.ImageWriter arg0, float arg1)
        {
            IExecuteWithSignature("imageProgress", "(Ljavax/imageio/ImageWriter;F)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/event/IIOWriteProgressListener.html#imageStarted(javax.imageio.ImageWriter,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.ImageWriter"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public override void ImageStarted(Javax.Imageio.ImageWriter arg0, int arg1)
        {
            IExecuteWithSignature("imageStarted", "(Ljavax/imageio/ImageWriter;I)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/event/IIOWriteProgressListener.html#thumbnailComplete(javax.imageio.ImageWriter)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.ImageWriter"/></param>
        public override void ThumbnailComplete(Javax.Imageio.ImageWriter arg0)
        {
            IExecuteWithSignature("thumbnailComplete", "(Ljavax/imageio/ImageWriter;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/event/IIOWriteProgressListener.html#thumbnailProgress(javax.imageio.ImageWriter,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.ImageWriter"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        public override void ThumbnailProgress(Javax.Imageio.ImageWriter arg0, float arg1)
        {
            IExecuteWithSignature("thumbnailProgress", "(Ljavax/imageio/ImageWriter;F)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/event/IIOWriteProgressListener.html#thumbnailStarted(javax.imageio.ImageWriter,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.ImageWriter"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public override void ThumbnailStarted(Javax.Imageio.ImageWriter arg0, int arg1, int arg2)
        {
            IExecuteWithSignature("thumbnailStarted", "(Ljavax/imageio/ImageWriter;II)V", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/event/IIOWriteProgressListener.html#writeAborted(javax.imageio.ImageWriter)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.ImageWriter"/></param>
        public override void WriteAborted(Javax.Imageio.ImageWriter arg0)
        {
            IExecuteWithSignature("writeAborted", "(Ljavax/imageio/ImageWriter;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}