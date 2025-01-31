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

namespace Javax.Imageio
{
    #region ImageIO declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageIO.html"/>
    /// </summary>
    public partial class ImageIO : MASES.JCOBridge.C2JBridge.JVMBridgeBase<ImageIO>
    {
        const string _bridgeClassName = "javax.imageio.ImageIO";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public ImageIO() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public ImageIO(params object[] args) : base(args) { }

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

    #region ImageIO implementation
    public partial class ImageIO
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageIO.html#getCacheDirectory()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageIO.html#setCacheDirectory(java.io.File)"/>
        /// </summary>
        public static Java.Io.File CacheDirectory
        {
            get { return SExecuteWithSignature<Java.Io.File>(LocalBridgeClazz, "getCacheDirectory", "()Ljava/io/File;"); } set { SExecuteWithSignature(LocalBridgeClazz, "setCacheDirectory", "(Ljava/io/File;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageIO.html#getReaderFileSuffixes()"/> 
        /// </summary>
        public static Java.Lang.String[] ReaderFileSuffixes
        {
            get { return SExecuteWithSignatureArray<Java.Lang.String>(LocalBridgeClazz, "getReaderFileSuffixes", "()[Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageIO.html#getReaderFormatNames()"/> 
        /// </summary>
        public static Java.Lang.String[] ReaderFormatNames
        {
            get { return SExecuteWithSignatureArray<Java.Lang.String>(LocalBridgeClazz, "getReaderFormatNames", "()[Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageIO.html#getReaderMIMETypes()"/> 
        /// </summary>
        public static Java.Lang.String[] ReaderMIMETypes
        {
            get { return SExecuteWithSignatureArray<Java.Lang.String>(LocalBridgeClazz, "getReaderMIMETypes", "()[Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageIO.html#getUseCache()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageIO.html#setUseCache(boolean)"/>
        /// </summary>
        public static bool UseCache
        {
            get { return SExecuteWithSignature<bool>(LocalBridgeClazz, "getUseCache", "()Z"); } set { SExecuteWithSignature(LocalBridgeClazz, "setUseCache", "(Z)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageIO.html#getWriterFileSuffixes()"/> 
        /// </summary>
        public static Java.Lang.String[] WriterFileSuffixes
        {
            get { return SExecuteWithSignatureArray<Java.Lang.String>(LocalBridgeClazz, "getWriterFileSuffixes", "()[Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageIO.html#getWriterFormatNames()"/> 
        /// </summary>
        public static Java.Lang.String[] WriterFormatNames
        {
            get { return SExecuteWithSignatureArray<Java.Lang.String>(LocalBridgeClazz, "getWriterFormatNames", "()[Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageIO.html#getWriterMIMETypes()"/> 
        /// </summary>
        public static Java.Lang.String[] WriterMIMETypes
        {
            get { return SExecuteWithSignatureArray<Java.Lang.String>(LocalBridgeClazz, "getWriterMIMETypes", "()[Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageIO.html#write(java.awt.image.RenderedImage,java.lang.String,java.io.File)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.RenderedImage"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Io.File"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public static bool Write(Java.Awt.ImageNs.RenderedImage arg0, Java.Lang.String arg1, Java.Io.File arg2)
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "write", "(Ljava/awt/image/RenderedImage;Ljava/lang/String;Ljava/io/File;)Z", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageIO.html#write(java.awt.image.RenderedImage,java.lang.String,java.io.OutputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.RenderedImage"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Io.OutputStream"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public static bool Write(Java.Awt.ImageNs.RenderedImage arg0, Java.Lang.String arg1, Java.Io.OutputStream arg2)
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "write", "(Ljava/awt/image/RenderedImage;Ljava/lang/String;Ljava/io/OutputStream;)Z", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageIO.html#write(java.awt.image.RenderedImage,java.lang.String,javax.imageio.stream.ImageOutputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.RenderedImage"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Javax.Imageio.Stream.ImageOutputStream"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public static bool Write(Java.Awt.ImageNs.RenderedImage arg0, Java.Lang.String arg1, Javax.Imageio.Stream.ImageOutputStream arg2)
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "write", "(Ljava/awt/image/RenderedImage;Ljava/lang/String;Ljavax/imageio/stream/ImageOutputStream;)Z", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageIO.html#read(java.io.File)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.File"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.BufferedImage"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public static Java.Awt.ImageNs.BufferedImage Read(Java.Io.File arg0)
        {
            return SExecuteWithSignature<Java.Awt.ImageNs.BufferedImage>(LocalBridgeClazz, "read", "(Ljava/io/File;)Ljava/awt/image/BufferedImage;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageIO.html#read(java.io.InputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.InputStream"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.BufferedImage"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public static Java.Awt.ImageNs.BufferedImage Read(Java.Io.InputStream arg0)
        {
            return SExecuteWithSignature<Java.Awt.ImageNs.BufferedImage>(LocalBridgeClazz, "read", "(Ljava/io/InputStream;)Ljava/awt/image/BufferedImage;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageIO.html#read(java.net.URL)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.URL"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.BufferedImage"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public static Java.Awt.ImageNs.BufferedImage Read(Java.Net.URL arg0)
        {
            return SExecuteWithSignature<Java.Awt.ImageNs.BufferedImage>(LocalBridgeClazz, "read", "(Ljava/net/URL;)Ljava/awt/image/BufferedImage;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageIO.html#read(javax.imageio.stream.ImageInputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.Stream.ImageInputStream"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.BufferedImage"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public static Java.Awt.ImageNs.BufferedImage Read(Javax.Imageio.Stream.ImageInputStream arg0)
        {
            return SExecuteWithSignature<Java.Awt.ImageNs.BufferedImage>(LocalBridgeClazz, "read", "(Ljavax/imageio/stream/ImageInputStream;)Ljava/awt/image/BufferedImage;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageIO.html#getImageReaders(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="Java.Util.Iterator"/></returns>
        public static Java.Util.Iterator<Javax.Imageio.ImageReader> GetImageReaders(object arg0)
        {
            return SExecuteWithSignature<Java.Util.Iterator<Javax.Imageio.ImageReader>>(LocalBridgeClazz, "getImageReaders", "(Ljava/lang/Object;)Ljava/util/Iterator;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageIO.html#getImageReadersByFormatName(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Util.Iterator"/></returns>
        public static Java.Util.Iterator<Javax.Imageio.ImageReader> GetImageReadersByFormatName(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Util.Iterator<Javax.Imageio.ImageReader>>(LocalBridgeClazz, "getImageReadersByFormatName", "(Ljava/lang/String;)Ljava/util/Iterator;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageIO.html#getImageReadersByMIMEType(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Util.Iterator"/></returns>
        public static Java.Util.Iterator<Javax.Imageio.ImageReader> GetImageReadersByMIMEType(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Util.Iterator<Javax.Imageio.ImageReader>>(LocalBridgeClazz, "getImageReadersByMIMEType", "(Ljava/lang/String;)Ljava/util/Iterator;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageIO.html#getImageReadersBySuffix(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Util.Iterator"/></returns>
        public static Java.Util.Iterator<Javax.Imageio.ImageReader> GetImageReadersBySuffix(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Util.Iterator<Javax.Imageio.ImageReader>>(LocalBridgeClazz, "getImageReadersBySuffix", "(Ljava/lang/String;)Ljava/util/Iterator;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageIO.html#getImageTranscoders(javax.imageio.ImageReader,javax.imageio.ImageWriter)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.ImageReader"/></param>
        /// <param name="arg1"><see cref="Javax.Imageio.ImageWriter"/></param>
        /// <returns><see cref="Java.Util.Iterator"/></returns>
        public static Java.Util.Iterator<Javax.Imageio.ImageTranscoder> GetImageTranscoders(Javax.Imageio.ImageReader arg0, Javax.Imageio.ImageWriter arg1)
        {
            return SExecuteWithSignature<Java.Util.Iterator<Javax.Imageio.ImageTranscoder>>(LocalBridgeClazz, "getImageTranscoders", "(Ljavax/imageio/ImageReader;Ljavax/imageio/ImageWriter;)Ljava/util/Iterator;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageIO.html#getImageWriters(javax.imageio.ImageTypeSpecifier,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.ImageTypeSpecifier"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Util.Iterator"/></returns>
        public static Java.Util.Iterator<Javax.Imageio.ImageWriter> GetImageWriters(Javax.Imageio.ImageTypeSpecifier arg0, Java.Lang.String arg1)
        {
            return SExecuteWithSignature<Java.Util.Iterator<Javax.Imageio.ImageWriter>>(LocalBridgeClazz, "getImageWriters", "(Ljavax/imageio/ImageTypeSpecifier;Ljava/lang/String;)Ljava/util/Iterator;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageIO.html#getImageWritersByFormatName(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Util.Iterator"/></returns>
        public static Java.Util.Iterator<Javax.Imageio.ImageWriter> GetImageWritersByFormatName(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Util.Iterator<Javax.Imageio.ImageWriter>>(LocalBridgeClazz, "getImageWritersByFormatName", "(Ljava/lang/String;)Ljava/util/Iterator;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageIO.html#getImageWritersByMIMEType(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Util.Iterator"/></returns>
        public static Java.Util.Iterator<Javax.Imageio.ImageWriter> GetImageWritersByMIMEType(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Util.Iterator<Javax.Imageio.ImageWriter>>(LocalBridgeClazz, "getImageWritersByMIMEType", "(Ljava/lang/String;)Ljava/util/Iterator;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageIO.html#getImageWritersBySuffix(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Util.Iterator"/></returns>
        public static Java.Util.Iterator<Javax.Imageio.ImageWriter> GetImageWritersBySuffix(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Util.Iterator<Javax.Imageio.ImageWriter>>(LocalBridgeClazz, "getImageWritersBySuffix", "(Ljava/lang/String;)Ljava/util/Iterator;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageIO.html#getImageReader(javax.imageio.ImageWriter)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.ImageWriter"/></param>
        /// <returns><see cref="Javax.Imageio.ImageReader"/></returns>
        public static Javax.Imageio.ImageReader GetImageReader(Javax.Imageio.ImageWriter arg0)
        {
            return SExecuteWithSignature<Javax.Imageio.ImageReader>(LocalBridgeClazz, "getImageReader", "(Ljavax/imageio/ImageWriter;)Ljavax/imageio/ImageReader;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageIO.html#getImageWriter(javax.imageio.ImageReader)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.ImageReader"/></param>
        /// <returns><see cref="Javax.Imageio.ImageWriter"/></returns>
        public static Javax.Imageio.ImageWriter GetImageWriter(Javax.Imageio.ImageReader arg0)
        {
            return SExecuteWithSignature<Javax.Imageio.ImageWriter>(LocalBridgeClazz, "getImageWriter", "(Ljavax/imageio/ImageReader;)Ljavax/imageio/ImageWriter;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageIO.html#createImageInputStream(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="Javax.Imageio.Stream.ImageInputStream"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public static Javax.Imageio.Stream.ImageInputStream CreateImageInputStream(object arg0)
        {
            return SExecuteWithSignature<Javax.Imageio.Stream.ImageInputStream>(LocalBridgeClazz, "createImageInputStream", "(Ljava/lang/Object;)Ljavax/imageio/stream/ImageInputStream;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageIO.html#createImageOutputStream(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="Javax.Imageio.Stream.ImageOutputStream"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public static Javax.Imageio.Stream.ImageOutputStream CreateImageOutputStream(object arg0)
        {
            return SExecuteWithSignature<Javax.Imageio.Stream.ImageOutputStream>(LocalBridgeClazz, "createImageOutputStream", "(Ljava/lang/Object;)Ljavax/imageio/stream/ImageOutputStream;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageIO.html#scanForPlugins()"/>
        /// </summary>
        public static void ScanForPlugins()
        {
            SExecuteWithSignature(LocalBridgeClazz, "scanForPlugins", "()V");
        }

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}