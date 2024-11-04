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
*  This file is generated by MASES.JNetReflector (ver. 2.5.10.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Imageio
{
    #region ImageWriteParam declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriteParam.html"/>
    /// </summary>
    public partial class ImageWriteParam : Javax.Imageio.IIOParam
    {
        const string _bridgeClassName = "javax.imageio.ImageWriteParam";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public ImageWriteParam() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public ImageWriteParam(params object[] args) : base(args) { }

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

    #region ImageWriteParam implementation
    public partial class ImageWriteParam
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriteParam.html#%3Cinit%3E(java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
        public ImageWriteParam(Java.Util.Locale arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriteParam.html#MODE_COPY_FROM_METADATA"/>
        /// </summary>
        public static int MODE_COPY_FROM_METADATA { get { if (!_MODE_COPY_FROM_METADATAReady) { _MODE_COPY_FROM_METADATAContent = SGetField<int>(LocalBridgeClazz, "MODE_COPY_FROM_METADATA"); _MODE_COPY_FROM_METADATAReady = true; } return _MODE_COPY_FROM_METADATAContent; } }
        private static int _MODE_COPY_FROM_METADATAContent = default;
        private static bool _MODE_COPY_FROM_METADATAReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriteParam.html#MODE_DEFAULT"/>
        /// </summary>
        public static int MODE_DEFAULT { get { if (!_MODE_DEFAULTReady) { _MODE_DEFAULTContent = SGetField<int>(LocalBridgeClazz, "MODE_DEFAULT"); _MODE_DEFAULTReady = true; } return _MODE_DEFAULTContent; } }
        private static int _MODE_DEFAULTContent = default;
        private static bool _MODE_DEFAULTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriteParam.html#MODE_DISABLED"/>
        /// </summary>
        public static int MODE_DISABLED { get { if (!_MODE_DISABLEDReady) { _MODE_DISABLEDContent = SGetField<int>(LocalBridgeClazz, "MODE_DISABLED"); _MODE_DISABLEDReady = true; } return _MODE_DISABLEDContent; } }
        private static int _MODE_DISABLEDContent = default;
        private static bool _MODE_DISABLEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriteParam.html#MODE_EXPLICIT"/>
        /// </summary>
        public static int MODE_EXPLICIT { get { if (!_MODE_EXPLICITReady) { _MODE_EXPLICITContent = SGetField<int>(LocalBridgeClazz, "MODE_EXPLICIT"); _MODE_EXPLICITReady = true; } return _MODE_EXPLICITContent; } }
        private static int _MODE_EXPLICITContent = default;
        private static bool _MODE_EXPLICITReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriteParam.html#getCompressionMode()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriteParam.html#setCompressionMode(int)"/>
        /// </summary>
        public int CompressionMode
        {
            get { return IExecuteWithSignature<int>("getCompressionMode", "()I"); } set { IExecuteWithSignature("setCompressionMode", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriteParam.html#getCompressionQuality()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriteParam.html#setCompressionQuality(float)"/>
        /// </summary>
        public float CompressionQuality
        {
            get { return IExecuteWithSignature<float>("getCompressionQuality", "()F"); } set { IExecuteWithSignature("setCompressionQuality", "(F)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriteParam.html#getCompressionQualityDescriptions()"/> 
        /// </summary>
        public Java.Lang.String[] CompressionQualityDescriptions
        {
            get { return IExecuteWithSignatureArray<Java.Lang.String>("getCompressionQualityDescriptions", "()[Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriteParam.html#getCompressionQualityValues()"/> 
        /// </summary>
        public float[] CompressionQualityValues
        {
            get { return IExecuteWithSignatureArray<float>("getCompressionQualityValues", "()[F"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriteParam.html#getCompressionType()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriteParam.html#setCompressionType(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String CompressionType
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getCompressionType", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setCompressionType", "(Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriteParam.html#getCompressionTypes()"/> 
        /// </summary>
        public Java.Lang.String[] CompressionTypes
        {
            get { return IExecuteWithSignatureArray<Java.Lang.String>("getCompressionTypes", "()[Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriteParam.html#getLocale()"/> 
        /// </summary>
        public Java.Util.Locale Locale
        {
            get { return IExecuteWithSignature<Java.Util.Locale>("getLocale", "()Ljava/util/Locale;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriteParam.html#getLocalizedCompressionTypeName()"/> 
        /// </summary>
        public Java.Lang.String LocalizedCompressionTypeName
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getLocalizedCompressionTypeName", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriteParam.html#getPreferredTileSizes()"/> 
        /// </summary>
        public Java.Awt.Dimension[] PreferredTileSizes
        {
            get { return IExecuteWithSignatureArray<Java.Awt.Dimension>("getPreferredTileSizes", "()[Ljava/awt/Dimension;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriteParam.html#getProgressiveMode()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriteParam.html#setProgressiveMode(int)"/>
        /// </summary>
        public int ProgressiveMode
        {
            get { return IExecuteWithSignature<int>("getProgressiveMode", "()I"); } set { IExecuteWithSignature("setProgressiveMode", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriteParam.html#getTileGridXOffset()"/> 
        /// </summary>
        public int TileGridXOffset
        {
            get { return IExecuteWithSignature<int>("getTileGridXOffset", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriteParam.html#getTileGridYOffset()"/> 
        /// </summary>
        public int TileGridYOffset
        {
            get { return IExecuteWithSignature<int>("getTileGridYOffset", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriteParam.html#getTileHeight()"/> 
        /// </summary>
        public int TileHeight
        {
            get { return IExecuteWithSignature<int>("getTileHeight", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriteParam.html#getTileWidth()"/> 
        /// </summary>
        public int TileWidth
        {
            get { return IExecuteWithSignature<int>("getTileWidth", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriteParam.html#getTilingMode()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriteParam.html#setTilingMode(int)"/>
        /// </summary>
        public int TilingMode
        {
            get { return IExecuteWithSignature<int>("getTilingMode", "()I"); } set { IExecuteWithSignature("setTilingMode", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriteParam.html#canOffsetTiles()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool CanOffsetTiles()
        {
            return IExecuteWithSignature<bool>("canOffsetTiles", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriteParam.html#canWriteCompressed()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool CanWriteCompressed()
        {
            return IExecuteWithSignature<bool>("canWriteCompressed", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriteParam.html#canWriteProgressive()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool CanWriteProgressive()
        {
            return IExecuteWithSignature<bool>("canWriteProgressive", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriteParam.html#canWriteTiles()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool CanWriteTiles()
        {
            return IExecuteWithSignature<bool>("canWriteTiles", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriteParam.html#isCompressionLossless()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsCompressionLossless()
        {
            return IExecuteWithSignature<bool>("isCompressionLossless", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriteParam.html#getBitRate(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <returns><see cref="float"/></returns>
        public float GetBitRate(float arg0)
        {
            return IExecuteWithSignature<float>("getBitRate", "(F)F", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriteParam.html#setTiling(int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public void SetTiling(int arg0, int arg1, int arg2, int arg3)
        {
            IExecuteWithSignature("setTiling", "(IIII)V", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriteParam.html#unsetCompression()"/>
        /// </summary>
        public void UnsetCompression()
        {
            IExecuteWithSignature("unsetCompression", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriteParam.html#unsetTiling()"/>
        /// </summary>
        public void UnsetTiling()
        {
            IExecuteWithSignature("unsetTiling", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}