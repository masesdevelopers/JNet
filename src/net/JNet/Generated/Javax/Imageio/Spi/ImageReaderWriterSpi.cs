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
*  This file is generated by MASES.JNetReflector (ver. 2.2.5.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Imageio.Spi
{
    #region ImageReaderWriterSpi
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
            get { return IExecuteArray<Java.Lang.String>("getExtraImageMetadataFormatNames"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/spi/ImageReaderWriterSpi.html#getExtraStreamMetadataFormatNames()"/> 
        /// </summary>
        public Java.Lang.String[] ExtraStreamMetadataFormatNames
        {
            get { return IExecuteArray<Java.Lang.String>("getExtraStreamMetadataFormatNames"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/spi/ImageReaderWriterSpi.html#getFileSuffixes()"/> 
        /// </summary>
        public Java.Lang.String[] FileSuffixes
        {
            get { return IExecuteArray<Java.Lang.String>("getFileSuffixes"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/spi/ImageReaderWriterSpi.html#getFormatNames()"/> 
        /// </summary>
        public Java.Lang.String[] FormatNames
        {
            get { return IExecuteArray<Java.Lang.String>("getFormatNames"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/spi/ImageReaderWriterSpi.html#getMIMETypes()"/> 
        /// </summary>
        public Java.Lang.String[] MIMETypes
        {
            get { return IExecuteArray<Java.Lang.String>("getMIMETypes"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/spi/ImageReaderWriterSpi.html#getNativeImageMetadataFormatName()"/> 
        /// </summary>
        public Java.Lang.String NativeImageMetadataFormatName
        {
            get { return IExecute<Java.Lang.String>("getNativeImageMetadataFormatName"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/spi/ImageReaderWriterSpi.html#getNativeStreamMetadataFormatName()"/> 
        /// </summary>
        public Java.Lang.String NativeStreamMetadataFormatName
        {
            get { return IExecute<Java.Lang.String>("getNativeStreamMetadataFormatName"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/spi/ImageReaderWriterSpi.html#getPluginClassName()"/> 
        /// </summary>
        public Java.Lang.String PluginClassName
        {
            get { return IExecute<Java.Lang.String>("getPluginClassName"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/spi/ImageReaderWriterSpi.html#isStandardImageMetadataFormatSupported()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsStandardImageMetadataFormatSupported()
        {
            return IExecute<bool>("isStandardImageMetadataFormatSupported");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/spi/ImageReaderWriterSpi.html#isStandardStreamMetadataFormatSupported()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsStandardStreamMetadataFormatSupported()
        {
            return IExecute<bool>("isStandardStreamMetadataFormatSupported");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/spi/ImageReaderWriterSpi.html#getImageMetadataFormat(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Imageio.Metadata.IIOMetadataFormat"/></returns>
        public Javax.Imageio.Metadata.IIOMetadataFormat GetImageMetadataFormat(Java.Lang.String arg0)
        {
            return IExecute<Javax.Imageio.Metadata.IIOMetadataFormat>("getImageMetadataFormat", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/spi/ImageReaderWriterSpi.html#getStreamMetadataFormat(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Imageio.Metadata.IIOMetadataFormat"/></returns>
        public Javax.Imageio.Metadata.IIOMetadataFormat GetStreamMetadataFormat(Java.Lang.String arg0)
        {
            return IExecute<Javax.Imageio.Metadata.IIOMetadataFormat>("getStreamMetadataFormat", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}