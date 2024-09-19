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
*  This file is generated by MASES.JNetReflector (ver. 2.5.9.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Imageio
{
    #region ImageWriter declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriter.html"/>
    /// </summary>
    public partial class ImageWriter : Javax.Imageio.ImageTranscoder
    {
        const string _bridgeClassName = "javax.imageio.ImageWriter";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("ImageWriter class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public ImageWriter() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("ImageWriter class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public ImageWriter(params object[] args) : base(args) { }

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

    }
    #endregion

    #region ImageWriter implementation
    public partial class ImageWriter
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriter.html#getAvailableLocales()"/> 
        /// </summary>
        public Java.Util.Locale[] AvailableLocales
        {
            get { return IExecuteWithSignatureArray<Java.Util.Locale>("getAvailableLocales", "()[Ljava/util/Locale;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriter.html#getDefaultWriteParam()"/> 
        /// </summary>
        public Javax.Imageio.ImageWriteParam DefaultWriteParam
        {
            get { return IExecuteWithSignature<Javax.Imageio.ImageWriteParam>("getDefaultWriteParam", "()Ljavax/imageio/ImageWriteParam;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriter.html#getLocale()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriter.html#setLocale(java.util.Locale)"/>
        /// </summary>
        public Java.Util.Locale Locale
        {
            get { return IExecuteWithSignature<Java.Util.Locale>("getLocale", "()Ljava/util/Locale;"); } set { IExecuteWithSignature("setLocale", "(Ljava/util/Locale;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriter.html#getOriginatingProvider()"/> 
        /// </summary>
        public Javax.Imageio.Spi.ImageWriterSpi OriginatingProvider
        {
            get { return IExecuteWithSignature<Javax.Imageio.Spi.ImageWriterSpi>("getOriginatingProvider", "()Ljavax/imageio/spi/ImageWriterSpi;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriter.html#getOutput()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriter.html#setOutput(java.lang.Object)"/>
        /// </summary>
        public object Output
        {
            get { return IExecuteWithSignature("getOutput", "()Ljava/lang/Object;"); } set { IExecuteWithSignature("setOutput", "(Ljava/lang/Object;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriter.html#convertImageMetadata(javax.imageio.metadata.IIOMetadata,javax.imageio.ImageTypeSpecifier,javax.imageio.ImageWriteParam)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.Metadata.IIOMetadata"/></param>
        /// <param name="arg1"><see cref="Javax.Imageio.ImageTypeSpecifier"/></param>
        /// <param name="arg2"><see cref="Javax.Imageio.ImageWriteParam"/></param>
        /// <returns><see cref="Javax.Imageio.Metadata.IIOMetadata"/></returns>
        public Javax.Imageio.Metadata.IIOMetadata ConvertImageMetadata(Javax.Imageio.Metadata.IIOMetadata arg0, Javax.Imageio.ImageTypeSpecifier arg1, Javax.Imageio.ImageWriteParam arg2)
        {
            return IExecute<Javax.Imageio.Metadata.IIOMetadata>("convertImageMetadata", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriter.html#convertStreamMetadata(javax.imageio.metadata.IIOMetadata,javax.imageio.ImageWriteParam)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.Metadata.IIOMetadata"/></param>
        /// <param name="arg1"><see cref="Javax.Imageio.ImageWriteParam"/></param>
        /// <returns><see cref="Javax.Imageio.Metadata.IIOMetadata"/></returns>
        public Javax.Imageio.Metadata.IIOMetadata ConvertStreamMetadata(Javax.Imageio.Metadata.IIOMetadata arg0, Javax.Imageio.ImageWriteParam arg1)
        {
            return IExecute<Javax.Imageio.Metadata.IIOMetadata>("convertStreamMetadata", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriter.html#getDefaultImageMetadata(javax.imageio.ImageTypeSpecifier,javax.imageio.ImageWriteParam)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.ImageTypeSpecifier"/></param>
        /// <param name="arg1"><see cref="Javax.Imageio.ImageWriteParam"/></param>
        /// <returns><see cref="Javax.Imageio.Metadata.IIOMetadata"/></returns>
        public Javax.Imageio.Metadata.IIOMetadata GetDefaultImageMetadata(Javax.Imageio.ImageTypeSpecifier arg0, Javax.Imageio.ImageWriteParam arg1)
        {
            return IExecute<Javax.Imageio.Metadata.IIOMetadata>("getDefaultImageMetadata", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriter.html#getDefaultStreamMetadata(javax.imageio.ImageWriteParam)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.ImageWriteParam"/></param>
        /// <returns><see cref="Javax.Imageio.Metadata.IIOMetadata"/></returns>
        public Javax.Imageio.Metadata.IIOMetadata GetDefaultStreamMetadata(Javax.Imageio.ImageWriteParam arg0)
        {
            return IExecuteWithSignature<Javax.Imageio.Metadata.IIOMetadata>("getDefaultStreamMetadata", "(Ljavax/imageio/ImageWriteParam;)Ljavax/imageio/metadata/IIOMetadata;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriter.html#write(javax.imageio.metadata.IIOMetadata,javax.imageio.IIOImage,javax.imageio.ImageWriteParam)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.Metadata.IIOMetadata"/></param>
        /// <param name="arg1"><see cref="Javax.Imageio.IIOImage"/></param>
        /// <param name="arg2"><see cref="Javax.Imageio.ImageWriteParam"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void Write(Javax.Imageio.Metadata.IIOMetadata arg0, Javax.Imageio.IIOImage arg1, Javax.Imageio.ImageWriteParam arg2)
        {
            IExecute("write", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriter.html#canInsertEmpty(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public bool CanInsertEmpty(int arg0)
        {
            return IExecuteWithSignature<bool>("canInsertEmpty", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriter.html#canInsertImage(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public bool CanInsertImage(int arg0)
        {
            return IExecuteWithSignature<bool>("canInsertImage", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriter.html#canRemoveImage(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public bool CanRemoveImage(int arg0)
        {
            return IExecuteWithSignature<bool>("canRemoveImage", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriter.html#canReplaceImageMetadata(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public bool CanReplaceImageMetadata(int arg0)
        {
            return IExecuteWithSignature<bool>("canReplaceImageMetadata", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriter.html#canReplacePixels(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public bool CanReplacePixels(int arg0)
        {
            return IExecuteWithSignature<bool>("canReplacePixels", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriter.html#canReplaceStreamMetadata()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public bool CanReplaceStreamMetadata()
        {
            return IExecuteWithSignature<bool>("canReplaceStreamMetadata", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriter.html#canWriteEmpty()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public bool CanWriteEmpty()
        {
            return IExecuteWithSignature<bool>("canWriteEmpty", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriter.html#canWriteRasters()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool CanWriteRasters()
        {
            return IExecuteWithSignature<bool>("canWriteRasters", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriter.html#canWriteSequence()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool CanWriteSequence()
        {
            return IExecuteWithSignature<bool>("canWriteSequence", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriter.html#getNumThumbnailsSupported(javax.imageio.ImageTypeSpecifier,javax.imageio.ImageWriteParam,javax.imageio.metadata.IIOMetadata,javax.imageio.metadata.IIOMetadata)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.ImageTypeSpecifier"/></param>
        /// <param name="arg1"><see cref="Javax.Imageio.ImageWriteParam"/></param>
        /// <param name="arg2"><see cref="Javax.Imageio.Metadata.IIOMetadata"/></param>
        /// <param name="arg3"><see cref="Javax.Imageio.Metadata.IIOMetadata"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetNumThumbnailsSupported(Javax.Imageio.ImageTypeSpecifier arg0, Javax.Imageio.ImageWriteParam arg1, Javax.Imageio.Metadata.IIOMetadata arg2, Javax.Imageio.Metadata.IIOMetadata arg3)
        {
            return IExecute<int>("getNumThumbnailsSupported", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriter.html#getPreferredThumbnailSizes(javax.imageio.ImageTypeSpecifier,javax.imageio.ImageWriteParam,javax.imageio.metadata.IIOMetadata,javax.imageio.metadata.IIOMetadata)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.ImageTypeSpecifier"/></param>
        /// <param name="arg1"><see cref="Javax.Imageio.ImageWriteParam"/></param>
        /// <param name="arg2"><see cref="Javax.Imageio.Metadata.IIOMetadata"/></param>
        /// <param name="arg3"><see cref="Javax.Imageio.Metadata.IIOMetadata"/></param>
        /// <returns><see cref="Java.Awt.Dimension"/></returns>
        public Java.Awt.Dimension[] GetPreferredThumbnailSizes(Javax.Imageio.ImageTypeSpecifier arg0, Javax.Imageio.ImageWriteParam arg1, Javax.Imageio.Metadata.IIOMetadata arg2, Javax.Imageio.Metadata.IIOMetadata arg3)
        {
            return IExecuteArray<Java.Awt.Dimension>("getPreferredThumbnailSizes", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriter.html#abort()"/>
        /// </summary>
        public void Abort()
        {
            IExecuteWithSignature("abort", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriter.html#addIIOWriteProgressListener(javax.imageio.event.IIOWriteProgressListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.Event.IIOWriteProgressListener"/></param>
        public void AddIIOWriteProgressListener(Javax.Imageio.Event.IIOWriteProgressListener arg0)
        {
            IExecuteWithSignature("addIIOWriteProgressListener", "(Ljavax/imageio/event/IIOWriteProgressListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriter.html#addIIOWriteWarningListener(javax.imageio.event.IIOWriteWarningListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.Event.IIOWriteWarningListener"/></param>
        public void AddIIOWriteWarningListener(Javax.Imageio.Event.IIOWriteWarningListener arg0)
        {
            IExecuteWithSignature("addIIOWriteWarningListener", "(Ljavax/imageio/event/IIOWriteWarningListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriter.html#dispose()"/>
        /// </summary>
        public new void Dispose()
        {
            IExecuteWithSignature("dispose", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriter.html#endInsertEmpty()"/>
        /// </summary>
        /// <exception cref="Java.Io.IOException"/>
        public void EndInsertEmpty()
        {
            IExecuteWithSignature("endInsertEmpty", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriter.html#endReplacePixels()"/>
        /// </summary>
        /// <exception cref="Java.Io.IOException"/>
        public void EndReplacePixels()
        {
            IExecuteWithSignature("endReplacePixels", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriter.html#endWriteEmpty()"/>
        /// </summary>
        /// <exception cref="Java.Io.IOException"/>
        public void EndWriteEmpty()
        {
            IExecuteWithSignature("endWriteEmpty", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriter.html#endWriteSequence()"/>
        /// </summary>
        /// <exception cref="Java.Io.IOException"/>
        public void EndWriteSequence()
        {
            IExecuteWithSignature("endWriteSequence", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriter.html#prepareInsertEmpty(int,javax.imageio.ImageTypeSpecifier,int,int,javax.imageio.metadata.IIOMetadata,java.util.List,javax.imageio.ImageWriteParam)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Javax.Imageio.ImageTypeSpecifier"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="Javax.Imageio.Metadata.IIOMetadata"/></param>
        /// <param name="arg5"><see cref="Java.Util.List"/></param>
        /// <param name="arg6"><see cref="Javax.Imageio.ImageWriteParam"/></param>
        /// <typeparam name="Arg5ExtendsJava_Awt_ImageNs_BufferedImage"><see cref="Java.Awt.ImageNs.BufferedImage"/></typeparam>
        /// <exception cref="Java.Io.IOException"/>
        public void PrepareInsertEmpty<Arg5ExtendsJava_Awt_ImageNs_BufferedImage>(int arg0, Javax.Imageio.ImageTypeSpecifier arg1, int arg2, int arg3, Javax.Imageio.Metadata.IIOMetadata arg4, Java.Util.List<Arg5ExtendsJava_Awt_ImageNs_BufferedImage> arg5, Javax.Imageio.ImageWriteParam arg6) where Arg5ExtendsJava_Awt_ImageNs_BufferedImage : Java.Awt.ImageNs.BufferedImage
        {
            IExecute("prepareInsertEmpty", arg0, arg1, arg2, arg3, arg4, arg5, arg6);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriter.html#prepareReplacePixels(int,java.awt.Rectangle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Rectangle"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void PrepareReplacePixels(int arg0, Java.Awt.Rectangle arg1)
        {
            IExecute("prepareReplacePixels", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriter.html#prepareWriteEmpty(javax.imageio.metadata.IIOMetadata,javax.imageio.ImageTypeSpecifier,int,int,javax.imageio.metadata.IIOMetadata,java.util.List,javax.imageio.ImageWriteParam)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.Metadata.IIOMetadata"/></param>
        /// <param name="arg1"><see cref="Javax.Imageio.ImageTypeSpecifier"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="Javax.Imageio.Metadata.IIOMetadata"/></param>
        /// <param name="arg5"><see cref="Java.Util.List"/></param>
        /// <param name="arg6"><see cref="Javax.Imageio.ImageWriteParam"/></param>
        /// <typeparam name="Arg5ExtendsJava_Awt_ImageNs_BufferedImage"><see cref="Java.Awt.ImageNs.BufferedImage"/></typeparam>
        /// <exception cref="Java.Io.IOException"/>
        public void PrepareWriteEmpty<Arg5ExtendsJava_Awt_ImageNs_BufferedImage>(Javax.Imageio.Metadata.IIOMetadata arg0, Javax.Imageio.ImageTypeSpecifier arg1, int arg2, int arg3, Javax.Imageio.Metadata.IIOMetadata arg4, Java.Util.List<Arg5ExtendsJava_Awt_ImageNs_BufferedImage> arg5, Javax.Imageio.ImageWriteParam arg6) where Arg5ExtendsJava_Awt_ImageNs_BufferedImage : Java.Awt.ImageNs.BufferedImage
        {
            IExecute("prepareWriteEmpty", arg0, arg1, arg2, arg3, arg4, arg5, arg6);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriter.html#prepareWriteSequence(javax.imageio.metadata.IIOMetadata)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.Metadata.IIOMetadata"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void PrepareWriteSequence(Javax.Imageio.Metadata.IIOMetadata arg0)
        {
            IExecuteWithSignature("prepareWriteSequence", "(Ljavax/imageio/metadata/IIOMetadata;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriter.html#removeAllIIOWriteProgressListeners()"/>
        /// </summary>
        public void RemoveAllIIOWriteProgressListeners()
        {
            IExecuteWithSignature("removeAllIIOWriteProgressListeners", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriter.html#removeAllIIOWriteWarningListeners()"/>
        /// </summary>
        public void RemoveAllIIOWriteWarningListeners()
        {
            IExecuteWithSignature("removeAllIIOWriteWarningListeners", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriter.html#removeIIOWriteProgressListener(javax.imageio.event.IIOWriteProgressListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.Event.IIOWriteProgressListener"/></param>
        public void RemoveIIOWriteProgressListener(Javax.Imageio.Event.IIOWriteProgressListener arg0)
        {
            IExecuteWithSignature("removeIIOWriteProgressListener", "(Ljavax/imageio/event/IIOWriteProgressListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriter.html#removeIIOWriteWarningListener(javax.imageio.event.IIOWriteWarningListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.Event.IIOWriteWarningListener"/></param>
        public void RemoveIIOWriteWarningListener(Javax.Imageio.Event.IIOWriteWarningListener arg0)
        {
            IExecuteWithSignature("removeIIOWriteWarningListener", "(Ljavax/imageio/event/IIOWriteWarningListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriter.html#removeImage(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void RemoveImage(int arg0)
        {
            IExecuteWithSignature("removeImage", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriter.html#replaceImageMetadata(int,javax.imageio.metadata.IIOMetadata)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Javax.Imageio.Metadata.IIOMetadata"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void ReplaceImageMetadata(int arg0, Javax.Imageio.Metadata.IIOMetadata arg1)
        {
            IExecute("replaceImageMetadata", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriter.html#replacePixels(java.awt.image.Raster,javax.imageio.ImageWriteParam)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.Raster"/></param>
        /// <param name="arg1"><see cref="Javax.Imageio.ImageWriteParam"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void ReplacePixels(Java.Awt.ImageNs.Raster arg0, Javax.Imageio.ImageWriteParam arg1)
        {
            IExecute("replacePixels", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriter.html#replacePixels(java.awt.image.RenderedImage,javax.imageio.ImageWriteParam)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.RenderedImage"/></param>
        /// <param name="arg1"><see cref="Javax.Imageio.ImageWriteParam"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void ReplacePixels(Java.Awt.ImageNs.RenderedImage arg0, Javax.Imageio.ImageWriteParam arg1)
        {
            IExecute("replacePixels", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriter.html#replaceStreamMetadata(javax.imageio.metadata.IIOMetadata)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.Metadata.IIOMetadata"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void ReplaceStreamMetadata(Javax.Imageio.Metadata.IIOMetadata arg0)
        {
            IExecuteWithSignature("replaceStreamMetadata", "(Ljavax/imageio/metadata/IIOMetadata;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriter.html#reset()"/>
        /// </summary>
        public void Reset()
        {
            IExecuteWithSignature("reset", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriter.html#write(java.awt.image.RenderedImage)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.RenderedImage"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void Write(Java.Awt.ImageNs.RenderedImage arg0)
        {
            IExecuteWithSignature("write", "(Ljava/awt/image/RenderedImage;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriter.html#write(javax.imageio.IIOImage)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.IIOImage"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void Write(Javax.Imageio.IIOImage arg0)
        {
            IExecuteWithSignature("write", "(Ljavax/imageio/IIOImage;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriter.html#writeInsert(int,javax.imageio.IIOImage,javax.imageio.ImageWriteParam)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Javax.Imageio.IIOImage"/></param>
        /// <param name="arg2"><see cref="Javax.Imageio.ImageWriteParam"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void WriteInsert(int arg0, Javax.Imageio.IIOImage arg1, Javax.Imageio.ImageWriteParam arg2)
        {
            IExecute("writeInsert", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriter.html#writeToSequence(javax.imageio.IIOImage,javax.imageio.ImageWriteParam)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.IIOImage"/></param>
        /// <param name="arg1"><see cref="Javax.Imageio.ImageWriteParam"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void WriteToSequence(Javax.Imageio.IIOImage arg0, Javax.Imageio.ImageWriteParam arg1)
        {
            IExecute("writeToSequence", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}