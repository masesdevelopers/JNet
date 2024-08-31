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

namespace Javax.Imageio
{
    #region IIOImage declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/IIOImage.html"/>
    /// </summary>
    public partial class IIOImage : MASES.JCOBridge.C2JBridge.JVMBridgeBase<IIOImage>
    {
        const string _bridgeClassName = "javax.imageio.IIOImage";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public IIOImage() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public IIOImage(params object[] args) : base(args) { }

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
        public override bool IsBridgeStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region IIOImage implementation
    public partial class IIOImage
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/IIOImage.html#%3Cinit%3E(java.awt.image.Raster,java.util.List,javax.imageio.metadata.IIOMetadata)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.Raster"/></param>
        /// <param name="arg1"><see cref="Java.Util.List"/></param>
        /// <param name="arg2"><see cref="Javax.Imageio.Metadata.IIOMetadata"/></param>
        public IIOImage(Java.Awt.ImageNs.Raster arg0, Java.Util.List arg1, Javax.Imageio.Metadata.IIOMetadata arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/IIOImage.html#%3Cinit%3E(java.awt.image.RenderedImage,java.util.List,javax.imageio.metadata.IIOMetadata)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.RenderedImage"/></param>
        /// <param name="arg1"><see cref="Java.Util.List"/></param>
        /// <param name="arg2"><see cref="Javax.Imageio.Metadata.IIOMetadata"/></param>
        public IIOImage(Java.Awt.ImageNs.RenderedImage arg0, Java.Util.List arg1, Javax.Imageio.Metadata.IIOMetadata arg2)
            : base(arg0, arg1, arg2)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/IIOImage.html#getMetadata()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/IIOImage.html#setMetadata(javax.imageio.metadata.IIOMetadata)"/>
        /// </summary>
        public Javax.Imageio.Metadata.IIOMetadata Metadata
        {
            get { return IExecuteWithSignature<Javax.Imageio.Metadata.IIOMetadata>("getMetadata", "()Ljavax/imageio/metadata/IIOMetadata;"); } set { IExecuteWithSignature("setMetadata", "(Ljavax/imageio/metadata/IIOMetadata;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/IIOImage.html#getNumThumbnails()"/> 
        /// </summary>
        public int NumThumbnails
        {
            get { return IExecuteWithSignature<int>("getNumThumbnails", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/IIOImage.html#getRaster()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/IIOImage.html#setRaster(java.awt.image.Raster)"/>
        /// </summary>
        public Java.Awt.ImageNs.Raster Raster
        {
            get { return IExecuteWithSignature<Java.Awt.ImageNs.Raster>("getRaster", "()Ljava/awt/image/Raster;"); } set { IExecuteWithSignature("setRaster", "(Ljava/awt/image/Raster;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/IIOImage.html#getRenderedImage()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/IIOImage.html#setRenderedImage(java.awt.image.RenderedImage)"/>
        /// </summary>
        public Java.Awt.ImageNs.RenderedImage RenderedImage
        {
            get { return IExecuteWithSignature<Java.Awt.ImageNs.RenderedImage>("getRenderedImage", "()Ljava/awt/image/RenderedImage;"); } set { IExecuteWithSignature("setRenderedImage", "(Ljava/awt/image/RenderedImage;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/IIOImage.html#getThumbnails()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/IIOImage.html#setThumbnails(java.util.List)"/>
        /// </summary>
        public Java.Util.List Thumbnails
        {
            get { return IExecuteWithSignature<Java.Util.List>("getThumbnails", "()Ljava/util/List;"); } set { IExecuteWithSignature("setThumbnails", "(Ljava/util/List;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/IIOImage.html#hasRaster()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasRaster()
        {
            return IExecuteWithSignature<bool>("hasRaster", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/IIOImage.html#getThumbnail(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.BufferedImage"/></returns>
        public Java.Awt.ImageNs.BufferedImage GetThumbnail(int arg0)
        {
            return IExecuteWithSignature<Java.Awt.ImageNs.BufferedImage>("getThumbnail", "(I)Ljava/awt/image/BufferedImage;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}