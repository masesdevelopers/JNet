/*
*  Copyright 2023 MASES s.r.l.
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
*  This file is generated by MASES.JNetReflector (ver. 2.0.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Imageio.Event
{
    #region IIIOReadUpdateListener
    /// <summary>
    /// .NET interface for org.mases.jnet.generated.javax.imageio.event.IIOReadUpdateListener implementing <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/event/IIOReadUpdateListener.html"/>
    /// </summary>
    public partial interface IIIOReadUpdateListener
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/event/IIOReadUpdateListener.html#imageUpdate(javax.imageio.ImageReader,java.awt.image.BufferedImage,int,int,int,int,int,int,int[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.ImageReader"/></param>
        /// <param name="arg1"><see cref="Java.Awt.ImageNs.BufferedImage"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <param name="arg6"><see cref="int"/></param>
        /// <param name="arg7"><see cref="int"/></param>
        /// <param name="arg8"><see cref="int"/></param>
        void ImageUpdate(Javax.Imageio.ImageReader arg0, Java.Awt.ImageNs.BufferedImage arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, int[] arg8);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/event/IIOReadUpdateListener.html#passComplete(javax.imageio.ImageReader,java.awt.image.BufferedImage)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.ImageReader"/></param>
        /// <param name="arg1"><see cref="Java.Awt.ImageNs.BufferedImage"/></param>
        void PassComplete(Javax.Imageio.ImageReader arg0, Java.Awt.ImageNs.BufferedImage arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/event/IIOReadUpdateListener.html#passStarted(javax.imageio.ImageReader,java.awt.image.BufferedImage,int,int,int,int,int,int,int,int[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.ImageReader"/></param>
        /// <param name="arg1"><see cref="Java.Awt.ImageNs.BufferedImage"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <param name="arg6"><see cref="int"/></param>
        /// <param name="arg7"><see cref="int"/></param>
        /// <param name="arg8"><see cref="int"/></param>
        /// <param name="arg9"><see cref="int"/></param>
        void PassStarted(Javax.Imageio.ImageReader arg0, Java.Awt.ImageNs.BufferedImage arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, int arg8, int[] arg9);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/event/IIOReadUpdateListener.html#thumbnailPassComplete(javax.imageio.ImageReader,java.awt.image.BufferedImage)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.ImageReader"/></param>
        /// <param name="arg1"><see cref="Java.Awt.ImageNs.BufferedImage"/></param>
        void ThumbnailPassComplete(Javax.Imageio.ImageReader arg0, Java.Awt.ImageNs.BufferedImage arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/event/IIOReadUpdateListener.html#thumbnailPassStarted(javax.imageio.ImageReader,java.awt.image.BufferedImage,int,int,int,int,int,int,int,int[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.ImageReader"/></param>
        /// <param name="arg1"><see cref="Java.Awt.ImageNs.BufferedImage"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <param name="arg6"><see cref="int"/></param>
        /// <param name="arg7"><see cref="int"/></param>
        /// <param name="arg8"><see cref="int"/></param>
        /// <param name="arg9"><see cref="int"/></param>
        void ThumbnailPassStarted(Javax.Imageio.ImageReader arg0, Java.Awt.ImageNs.BufferedImage arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, int arg8, int[] arg9);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/event/IIOReadUpdateListener.html#thumbnailUpdate(javax.imageio.ImageReader,java.awt.image.BufferedImage,int,int,int,int,int,int,int[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.ImageReader"/></param>
        /// <param name="arg1"><see cref="Java.Awt.ImageNs.BufferedImage"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <param name="arg6"><see cref="int"/></param>
        /// <param name="arg7"><see cref="int"/></param>
        /// <param name="arg8"><see cref="int"/></param>
        void ThumbnailUpdate(Javax.Imageio.ImageReader arg0, Java.Awt.ImageNs.BufferedImage arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, int[] arg8);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region IIOReadUpdateListener
    public partial class IIOReadUpdateListener : Javax.Imageio.Event.IIIOReadUpdateListener
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
        /// Handlers initializer for <see cref="IIOReadUpdateListener"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("imageUpdate", new System.EventHandler<CLRListenerEventArgs<CLREventData<Javax.Imageio.ImageReader>>>(ImageUpdateEventHandler)); OnImageUpdate = ImageUpdate;
            AddEventHandler("passComplete", new System.EventHandler<CLRListenerEventArgs<CLREventData<Javax.Imageio.ImageReader>>>(PassCompleteEventHandler)); OnPassComplete = PassComplete;
            AddEventHandler("passStarted", new System.EventHandler<CLRListenerEventArgs<CLREventData<Javax.Imageio.ImageReader>>>(PassStartedEventHandler)); OnPassStarted = PassStarted;
            AddEventHandler("thumbnailPassComplete", new System.EventHandler<CLRListenerEventArgs<CLREventData<Javax.Imageio.ImageReader>>>(ThumbnailPassCompleteEventHandler)); OnThumbnailPassComplete = ThumbnailPassComplete;
            AddEventHandler("thumbnailPassStarted", new System.EventHandler<CLRListenerEventArgs<CLREventData<Javax.Imageio.ImageReader>>>(ThumbnailPassStartedEventHandler)); OnThumbnailPassStarted = ThumbnailPassStarted;
            AddEventHandler("thumbnailUpdate", new System.EventHandler<CLRListenerEventArgs<CLREventData<Javax.Imageio.ImageReader>>>(ThumbnailUpdateEventHandler)); OnThumbnailUpdate = ThumbnailUpdate;

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/event/IIOReadUpdateListener.html#imageUpdate(javax.imageio.ImageReader,java.awt.image.BufferedImage,int,int,int,int,int,int,int[])"/>
        /// </summary>
        public System.Action<Javax.Imageio.ImageReader, Java.Awt.ImageNs.BufferedImage, int, int, int, int, int, int, int[]> OnImageUpdate { get; set; }

        void ImageUpdateEventHandler(object sender, CLRListenerEventArgs<CLREventData<Javax.Imageio.ImageReader>> data)
        {
            if (OnImageUpdate != null) OnImageUpdate.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<Java.Awt.ImageNs.BufferedImage>(0), data.EventData.GetAt<int>(1), data.EventData.GetAt<int>(2), data.EventData.GetAt<int>(3), data.EventData.GetAt<int>(4), data.EventData.GetAt<int>(5), data.EventData.GetAt<int>(6), data.EventData.GetAt<int[]>(7));
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/event/IIOReadUpdateListener.html#imageUpdate(javax.imageio.ImageReader,java.awt.image.BufferedImage,int,int,int,int,int,int,int[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.ImageReader"/></param>
        /// <param name="arg1"><see cref="Java.Awt.ImageNs.BufferedImage"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <param name="arg6"><see cref="int"/></param>
        /// <param name="arg7"><see cref="int"/></param>
        /// <param name="arg8"><see cref="int"/></param>
        public virtual void ImageUpdate(Javax.Imageio.ImageReader arg0, Java.Awt.ImageNs.BufferedImage arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, int[] arg8)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/event/IIOReadUpdateListener.html#passComplete(javax.imageio.ImageReader,java.awt.image.BufferedImage)"/>
        /// </summary>
        public System.Action<Javax.Imageio.ImageReader, Java.Awt.ImageNs.BufferedImage> OnPassComplete { get; set; }

        void PassCompleteEventHandler(object sender, CLRListenerEventArgs<CLREventData<Javax.Imageio.ImageReader>> data)
        {
            if (OnPassComplete != null) OnPassComplete.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<Java.Awt.ImageNs.BufferedImage>(0));
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/event/IIOReadUpdateListener.html#passComplete(javax.imageio.ImageReader,java.awt.image.BufferedImage)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.ImageReader"/></param>
        /// <param name="arg1"><see cref="Java.Awt.ImageNs.BufferedImage"/></param>
        public virtual void PassComplete(Javax.Imageio.ImageReader arg0, Java.Awt.ImageNs.BufferedImage arg1)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/event/IIOReadUpdateListener.html#passStarted(javax.imageio.ImageReader,java.awt.image.BufferedImage,int,int,int,int,int,int,int,int[])"/>
        /// </summary>
        public System.Action<Javax.Imageio.ImageReader, Java.Awt.ImageNs.BufferedImage, int, int, int, int, int, int, int, int[]> OnPassStarted { get; set; }

        void PassStartedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Javax.Imageio.ImageReader>> data)
        {
            if (OnPassStarted != null) OnPassStarted.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<Java.Awt.ImageNs.BufferedImage>(0), data.EventData.GetAt<int>(1), data.EventData.GetAt<int>(2), data.EventData.GetAt<int>(3), data.EventData.GetAt<int>(4), data.EventData.GetAt<int>(5), data.EventData.GetAt<int>(6), data.EventData.GetAt<int>(7), data.EventData.GetAt<int[]>(8));
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/event/IIOReadUpdateListener.html#passStarted(javax.imageio.ImageReader,java.awt.image.BufferedImage,int,int,int,int,int,int,int,int[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.ImageReader"/></param>
        /// <param name="arg1"><see cref="Java.Awt.ImageNs.BufferedImage"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <param name="arg6"><see cref="int"/></param>
        /// <param name="arg7"><see cref="int"/></param>
        /// <param name="arg8"><see cref="int"/></param>
        /// <param name="arg9"><see cref="int"/></param>
        public virtual void PassStarted(Javax.Imageio.ImageReader arg0, Java.Awt.ImageNs.BufferedImage arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, int arg8, int[] arg9)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/event/IIOReadUpdateListener.html#thumbnailPassComplete(javax.imageio.ImageReader,java.awt.image.BufferedImage)"/>
        /// </summary>
        public System.Action<Javax.Imageio.ImageReader, Java.Awt.ImageNs.BufferedImage> OnThumbnailPassComplete { get; set; }

        void ThumbnailPassCompleteEventHandler(object sender, CLRListenerEventArgs<CLREventData<Javax.Imageio.ImageReader>> data)
        {
            if (OnThumbnailPassComplete != null) OnThumbnailPassComplete.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<Java.Awt.ImageNs.BufferedImage>(0));
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/event/IIOReadUpdateListener.html#thumbnailPassComplete(javax.imageio.ImageReader,java.awt.image.BufferedImage)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.ImageReader"/></param>
        /// <param name="arg1"><see cref="Java.Awt.ImageNs.BufferedImage"/></param>
        public virtual void ThumbnailPassComplete(Javax.Imageio.ImageReader arg0, Java.Awt.ImageNs.BufferedImage arg1)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/event/IIOReadUpdateListener.html#thumbnailPassStarted(javax.imageio.ImageReader,java.awt.image.BufferedImage,int,int,int,int,int,int,int,int[])"/>
        /// </summary>
        public System.Action<Javax.Imageio.ImageReader, Java.Awt.ImageNs.BufferedImage, int, int, int, int, int, int, int, int[]> OnThumbnailPassStarted { get; set; }

        void ThumbnailPassStartedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Javax.Imageio.ImageReader>> data)
        {
            if (OnThumbnailPassStarted != null) OnThumbnailPassStarted.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<Java.Awt.ImageNs.BufferedImage>(0), data.EventData.GetAt<int>(1), data.EventData.GetAt<int>(2), data.EventData.GetAt<int>(3), data.EventData.GetAt<int>(4), data.EventData.GetAt<int>(5), data.EventData.GetAt<int>(6), data.EventData.GetAt<int>(7), data.EventData.GetAt<int[]>(8));
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/event/IIOReadUpdateListener.html#thumbnailPassStarted(javax.imageio.ImageReader,java.awt.image.BufferedImage,int,int,int,int,int,int,int,int[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.ImageReader"/></param>
        /// <param name="arg1"><see cref="Java.Awt.ImageNs.BufferedImage"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <param name="arg6"><see cref="int"/></param>
        /// <param name="arg7"><see cref="int"/></param>
        /// <param name="arg8"><see cref="int"/></param>
        /// <param name="arg9"><see cref="int"/></param>
        public virtual void ThumbnailPassStarted(Javax.Imageio.ImageReader arg0, Java.Awt.ImageNs.BufferedImage arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, int arg8, int[] arg9)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/event/IIOReadUpdateListener.html#thumbnailUpdate(javax.imageio.ImageReader,java.awt.image.BufferedImage,int,int,int,int,int,int,int[])"/>
        /// </summary>
        public System.Action<Javax.Imageio.ImageReader, Java.Awt.ImageNs.BufferedImage, int, int, int, int, int, int, int[]> OnThumbnailUpdate { get; set; }

        void ThumbnailUpdateEventHandler(object sender, CLRListenerEventArgs<CLREventData<Javax.Imageio.ImageReader>> data)
        {
            if (OnThumbnailUpdate != null) OnThumbnailUpdate.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<Java.Awt.ImageNs.BufferedImage>(0), data.EventData.GetAt<int>(1), data.EventData.GetAt<int>(2), data.EventData.GetAt<int>(3), data.EventData.GetAt<int>(4), data.EventData.GetAt<int>(5), data.EventData.GetAt<int>(6), data.EventData.GetAt<int[]>(7));
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/event/IIOReadUpdateListener.html#thumbnailUpdate(javax.imageio.ImageReader,java.awt.image.BufferedImage,int,int,int,int,int,int,int[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.ImageReader"/></param>
        /// <param name="arg1"><see cref="Java.Awt.ImageNs.BufferedImage"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <param name="arg6"><see cref="int"/></param>
        /// <param name="arg7"><see cref="int"/></param>
        /// <param name="arg8"><see cref="int"/></param>
        public virtual void ThumbnailUpdate(Javax.Imageio.ImageReader arg0, Java.Awt.ImageNs.BufferedImage arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, int[] arg8)
        {
            
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}