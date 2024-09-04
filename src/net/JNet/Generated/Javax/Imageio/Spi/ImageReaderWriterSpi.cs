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

namespace Javax.Imageio.Spi
{
    #region ImageReaderWriterSpi declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/spi/ImageReaderWriterSpi.html"/>
    /// </summary>
    public partial class ImageReaderWriterSpi : Javax.Imageio.Spi.IIOServiceProvider
    {
        const string _bridgeClassName = "javax.imageio.spi.ImageReaderWriterSpi";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("ImageReaderWriterSpi class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public ImageReaderWriterSpi() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("ImageReaderWriterSpi class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public ImageReaderWriterSpi(params object[] args) : base(args) { }

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

    #region ImageReaderWriterSpi implementation
    public partial class ImageReaderWriterSpi
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/spi/ImageReaderWriterSpi.html#%3Cinit%3E(java.lang.String,java.lang.String,java.lang.String[],java.lang.String[],java.lang.String[],java.lang.String,boolean,java.lang.String,java.lang.String,java.lang.String[],java.lang.String[],boolean,java.lang.String,java.lang.String,java.lang.String[],java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="Java.Lang.String"/></param>
        /// <param name="arg4"><see cref="Java.Lang.String"/></param>
        /// <param name="arg5"><see cref="Java.Lang.String"/></param>
        /// <param name="arg6"><see cref="bool"/></param>
        /// <param name="arg7"><see cref="Java.Lang.String"/></param>
        /// <param name="arg8"><see cref="Java.Lang.String"/></param>
        /// <param name="arg9"><see cref="Java.Lang.String"/></param>
        /// <param name="arg10"><see cref="Java.Lang.String"/></param>
        /// <param name="arg11"><see cref="bool"/></param>
        /// <param name="arg12"><see cref="Java.Lang.String"/></param>
        /// <param name="arg13"><see cref="Java.Lang.String"/></param>
        /// <param name="arg14"><see cref="Java.Lang.String"/></param>
        /// <param name="arg15"><see cref="Java.Lang.String"/></param>
        public ImageReaderWriterSpi(Java.Lang.String arg0, Java.Lang.String arg1, Java.Lang.String[] arg2, Java.Lang.String[] arg3, Java.Lang.String[] arg4, Java.Lang.String arg5, bool arg6, Java.Lang.String arg7, Java.Lang.String arg8, Java.Lang.String[] arg9, Java.Lang.String[] arg10, bool arg11, Java.Lang.String arg12, Java.Lang.String arg13, Java.Lang.String[] arg14, Java.Lang.String[] arg15)
            : base(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15)
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/spi/ImageReaderWriterSpi.html#getExtraImageMetadataFormatNames()"/> 
        /// </summary>
        public Java.Lang.String[] ExtraImageMetadataFormatNames
        {
            get { return IExecuteWithSignatureArray<Java.Lang.String>("getExtraImageMetadataFormatNames", "()[Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/spi/ImageReaderWriterSpi.html#getExtraStreamMetadataFormatNames()"/> 
        /// </summary>
        public Java.Lang.String[] ExtraStreamMetadataFormatNames
        {
            get { return IExecuteWithSignatureArray<Java.Lang.String>("getExtraStreamMetadataFormatNames", "()[Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/spi/ImageReaderWriterSpi.html#getFileSuffixes()"/> 
        /// </summary>
        public Java.Lang.String[] FileSuffixes
        {
            get { return IExecuteWithSignatureArray<Java.Lang.String>("getFileSuffixes", "()[Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/spi/ImageReaderWriterSpi.html#getFormatNames()"/> 
        /// </summary>
        public Java.Lang.String[] FormatNames
        {
            get { return IExecuteWithSignatureArray<Java.Lang.String>("getFormatNames", "()[Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/spi/ImageReaderWriterSpi.html#getMIMETypes()"/> 
        /// </summary>
        public Java.Lang.String[] MIMETypes
        {
            get { return IExecuteWithSignatureArray<Java.Lang.String>("getMIMETypes", "()[Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/spi/ImageReaderWriterSpi.html#getNativeImageMetadataFormatName()"/> 
        /// </summary>
        public Java.Lang.String NativeImageMetadataFormatName
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getNativeImageMetadataFormatName", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/spi/ImageReaderWriterSpi.html#getNativeStreamMetadataFormatName()"/> 
        /// </summary>
        public Java.Lang.String NativeStreamMetadataFormatName
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getNativeStreamMetadataFormatName", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/spi/ImageReaderWriterSpi.html#getPluginClassName()"/> 
        /// </summary>
        public Java.Lang.String PluginClassName
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getPluginClassName", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/spi/ImageReaderWriterSpi.html#isStandardImageMetadataFormatSupported()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsStandardImageMetadataFormatSupported()
        {
            return IExecuteWithSignature<bool>("isStandardImageMetadataFormatSupported", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/spi/ImageReaderWriterSpi.html#isStandardStreamMetadataFormatSupported()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsStandardStreamMetadataFormatSupported()
        {
            return IExecuteWithSignature<bool>("isStandardStreamMetadataFormatSupported", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/spi/ImageReaderWriterSpi.html#getImageMetadataFormat(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Imageio.Metadata.IIOMetadataFormat"/></returns>
        public Javax.Imageio.Metadata.IIOMetadataFormat GetImageMetadataFormat(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Javax.Imageio.Metadata.IIOMetadataFormat>("getImageMetadataFormat", "(Ljava/lang/String;)Ljavax/imageio/metadata/IIOMetadataFormat;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/spi/ImageReaderWriterSpi.html#getStreamMetadataFormat(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Imageio.Metadata.IIOMetadataFormat"/></returns>
        public Javax.Imageio.Metadata.IIOMetadataFormat GetStreamMetadataFormat(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Javax.Imageio.Metadata.IIOMetadataFormat>("getStreamMetadataFormat", "(Ljava/lang/String;)Ljavax/imageio/metadata/IIOMetadataFormat;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}