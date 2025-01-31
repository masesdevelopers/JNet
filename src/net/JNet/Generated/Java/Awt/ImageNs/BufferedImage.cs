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

namespace Java.Awt.ImageNs
{
    #region BufferedImage declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferedImage.html"/>
    /// </summary>
    public partial class BufferedImage : Java.Awt.Image
    {
        const string _bridgeClassName = "java.awt.image.BufferedImage";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public BufferedImage() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public BufferedImage(params object[] args) : base(args) { }

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

    #region BufferedImage implementation
    public partial class BufferedImage
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferedImage.html#%3Cinit%3E(int,int,int,java.awt.image.IndexColorModel)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="Java.Awt.ImageNs.IndexColorModel"/></param>
        public BufferedImage(int arg0, int arg1, int arg2, Java.Awt.ImageNs.IndexColorModel arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferedImage.html#%3Cinit%3E(int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public BufferedImage(int arg0, int arg1, int arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferedImage.html#%3Cinit%3E(java.awt.image.ColorModel,java.awt.image.WritableRaster,boolean,java.util.Hashtable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.ColorModel"/></param>
        /// <param name="arg1"><see cref="Java.Awt.ImageNs.WritableRaster"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        /// <param name="arg3"><see cref="Java.Util.Hashtable"/></param>
        public BufferedImage(Java.Awt.ImageNs.ColorModel arg0, Java.Awt.ImageNs.WritableRaster arg1, bool arg2, Java.Util.Hashtable<object, object> arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Awt.ImageNs.BufferedImage"/> to <see cref="Java.Awt.ImageNs.WritableRenderedImage"/>
        /// </summary>
        public static implicit operator Java.Awt.ImageNs.WritableRenderedImage(Java.Awt.ImageNs.BufferedImage t) => t.Cast<Java.Awt.ImageNs.WritableRenderedImage>();
        /// <summary>
        /// Converter from <see cref="Java.Awt.ImageNs.BufferedImage"/> to <see cref="Java.Awt.Transparency"/>
        /// </summary>
        public static implicit operator Java.Awt.Transparency(Java.Awt.ImageNs.BufferedImage t) => t.Cast<Java.Awt.Transparency>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferedImage.html#TYPE_3BYTE_BGR"/>
        /// </summary>
        public static int TYPE_3BYTE_BGR { get { if (!_TYPE_3BYTE_BGRReady) { _TYPE_3BYTE_BGRContent = SGetField<int>(LocalBridgeClazz, "TYPE_3BYTE_BGR"); _TYPE_3BYTE_BGRReady = true; } return _TYPE_3BYTE_BGRContent; } }
        private static int _TYPE_3BYTE_BGRContent = default;
        private static bool _TYPE_3BYTE_BGRReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferedImage.html#TYPE_4BYTE_ABGR"/>
        /// </summary>
        public static int TYPE_4BYTE_ABGR { get { if (!_TYPE_4BYTE_ABGRReady) { _TYPE_4BYTE_ABGRContent = SGetField<int>(LocalBridgeClazz, "TYPE_4BYTE_ABGR"); _TYPE_4BYTE_ABGRReady = true; } return _TYPE_4BYTE_ABGRContent; } }
        private static int _TYPE_4BYTE_ABGRContent = default;
        private static bool _TYPE_4BYTE_ABGRReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferedImage.html#TYPE_4BYTE_ABGR_PRE"/>
        /// </summary>
        public static int TYPE_4BYTE_ABGR_PRE { get { if (!_TYPE_4BYTE_ABGR_PREReady) { _TYPE_4BYTE_ABGR_PREContent = SGetField<int>(LocalBridgeClazz, "TYPE_4BYTE_ABGR_PRE"); _TYPE_4BYTE_ABGR_PREReady = true; } return _TYPE_4BYTE_ABGR_PREContent; } }
        private static int _TYPE_4BYTE_ABGR_PREContent = default;
        private static bool _TYPE_4BYTE_ABGR_PREReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferedImage.html#TYPE_BYTE_BINARY"/>
        /// </summary>
        public static int TYPE_BYTE_BINARY { get { if (!_TYPE_BYTE_BINARYReady) { _TYPE_BYTE_BINARYContent = SGetField<int>(LocalBridgeClazz, "TYPE_BYTE_BINARY"); _TYPE_BYTE_BINARYReady = true; } return _TYPE_BYTE_BINARYContent; } }
        private static int _TYPE_BYTE_BINARYContent = default;
        private static bool _TYPE_BYTE_BINARYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferedImage.html#TYPE_BYTE_GRAY"/>
        /// </summary>
        public static int TYPE_BYTE_GRAY { get { if (!_TYPE_BYTE_GRAYReady) { _TYPE_BYTE_GRAYContent = SGetField<int>(LocalBridgeClazz, "TYPE_BYTE_GRAY"); _TYPE_BYTE_GRAYReady = true; } return _TYPE_BYTE_GRAYContent; } }
        private static int _TYPE_BYTE_GRAYContent = default;
        private static bool _TYPE_BYTE_GRAYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferedImage.html#TYPE_BYTE_INDEXED"/>
        /// </summary>
        public static int TYPE_BYTE_INDEXED { get { if (!_TYPE_BYTE_INDEXEDReady) { _TYPE_BYTE_INDEXEDContent = SGetField<int>(LocalBridgeClazz, "TYPE_BYTE_INDEXED"); _TYPE_BYTE_INDEXEDReady = true; } return _TYPE_BYTE_INDEXEDContent; } }
        private static int _TYPE_BYTE_INDEXEDContent = default;
        private static bool _TYPE_BYTE_INDEXEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferedImage.html#TYPE_CUSTOM"/>
        /// </summary>
        public static int TYPE_CUSTOM { get { if (!_TYPE_CUSTOMReady) { _TYPE_CUSTOMContent = SGetField<int>(LocalBridgeClazz, "TYPE_CUSTOM"); _TYPE_CUSTOMReady = true; } return _TYPE_CUSTOMContent; } }
        private static int _TYPE_CUSTOMContent = default;
        private static bool _TYPE_CUSTOMReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferedImage.html#TYPE_INT_ARGB"/>
        /// </summary>
        public static int TYPE_INT_ARGB { get { if (!_TYPE_INT_ARGBReady) { _TYPE_INT_ARGBContent = SGetField<int>(LocalBridgeClazz, "TYPE_INT_ARGB"); _TYPE_INT_ARGBReady = true; } return _TYPE_INT_ARGBContent; } }
        private static int _TYPE_INT_ARGBContent = default;
        private static bool _TYPE_INT_ARGBReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferedImage.html#TYPE_INT_ARGB_PRE"/>
        /// </summary>
        public static int TYPE_INT_ARGB_PRE { get { if (!_TYPE_INT_ARGB_PREReady) { _TYPE_INT_ARGB_PREContent = SGetField<int>(LocalBridgeClazz, "TYPE_INT_ARGB_PRE"); _TYPE_INT_ARGB_PREReady = true; } return _TYPE_INT_ARGB_PREContent; } }
        private static int _TYPE_INT_ARGB_PREContent = default;
        private static bool _TYPE_INT_ARGB_PREReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferedImage.html#TYPE_INT_BGR"/>
        /// </summary>
        public static int TYPE_INT_BGR { get { if (!_TYPE_INT_BGRReady) { _TYPE_INT_BGRContent = SGetField<int>(LocalBridgeClazz, "TYPE_INT_BGR"); _TYPE_INT_BGRReady = true; } return _TYPE_INT_BGRContent; } }
        private static int _TYPE_INT_BGRContent = default;
        private static bool _TYPE_INT_BGRReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferedImage.html#TYPE_INT_RGB"/>
        /// </summary>
        public static int TYPE_INT_RGB { get { if (!_TYPE_INT_RGBReady) { _TYPE_INT_RGBContent = SGetField<int>(LocalBridgeClazz, "TYPE_INT_RGB"); _TYPE_INT_RGBReady = true; } return _TYPE_INT_RGBContent; } }
        private static int _TYPE_INT_RGBContent = default;
        private static bool _TYPE_INT_RGBReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferedImage.html#TYPE_USHORT_555_RGB"/>
        /// </summary>
        public static int TYPE_USHORT_555_RGB { get { if (!_TYPE_USHORT_555_RGBReady) { _TYPE_USHORT_555_RGBContent = SGetField<int>(LocalBridgeClazz, "TYPE_USHORT_555_RGB"); _TYPE_USHORT_555_RGBReady = true; } return _TYPE_USHORT_555_RGBContent; } }
        private static int _TYPE_USHORT_555_RGBContent = default;
        private static bool _TYPE_USHORT_555_RGBReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferedImage.html#TYPE_USHORT_565_RGB"/>
        /// </summary>
        public static int TYPE_USHORT_565_RGB { get { if (!_TYPE_USHORT_565_RGBReady) { _TYPE_USHORT_565_RGBContent = SGetField<int>(LocalBridgeClazz, "TYPE_USHORT_565_RGB"); _TYPE_USHORT_565_RGBReady = true; } return _TYPE_USHORT_565_RGBContent; } }
        private static int _TYPE_USHORT_565_RGBContent = default;
        private static bool _TYPE_USHORT_565_RGBReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferedImage.html#TYPE_USHORT_GRAY"/>
        /// </summary>
        public static int TYPE_USHORT_GRAY { get { if (!_TYPE_USHORT_GRAYReady) { _TYPE_USHORT_GRAYContent = SGetField<int>(LocalBridgeClazz, "TYPE_USHORT_GRAY"); _TYPE_USHORT_GRAYReady = true; } return _TYPE_USHORT_GRAYContent; } }
        private static int _TYPE_USHORT_GRAYContent = default;
        private static bool _TYPE_USHORT_GRAYReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferedImage.html#getAlphaRaster()"/> 
        /// </summary>
        public Java.Awt.ImageNs.WritableRaster AlphaRaster
        {
            get { return IExecuteWithSignature<Java.Awt.ImageNs.WritableRaster>("getAlphaRaster", "()Ljava/awt/image/WritableRaster;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferedImage.html#getColorModel()"/> 
        /// </summary>
        public Java.Awt.ImageNs.ColorModel ColorModel
        {
            get { return IExecuteWithSignature<Java.Awt.ImageNs.ColorModel>("getColorModel", "()Ljava/awt/image/ColorModel;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferedImage.html#getData()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferedImage.html#setData(java.awt.image.Raster)"/>
        /// </summary>
        public Java.Awt.ImageNs.Raster Data
        {
            get { return IExecuteWithSignature<Java.Awt.ImageNs.Raster>("getData", "()Ljava/awt/image/Raster;"); } set { IExecuteWithSignature("setData", "(Ljava/awt/image/Raster;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferedImage.html#getHeight()"/> 
        /// </summary>
        public int Height
        {
            get { return IExecuteWithSignature<int>("getHeight", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferedImage.html#getMinTileX()"/> 
        /// </summary>
        public int MinTileX
        {
            get { return IExecuteWithSignature<int>("getMinTileX", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferedImage.html#getMinTileY()"/> 
        /// </summary>
        public int MinTileY
        {
            get { return IExecuteWithSignature<int>("getMinTileY", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferedImage.html#getMinX()"/> 
        /// </summary>
        public int MinX
        {
            get { return IExecuteWithSignature<int>("getMinX", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferedImage.html#getMinY()"/> 
        /// </summary>
        public int MinY
        {
            get { return IExecuteWithSignature<int>("getMinY", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferedImage.html#getNumXTiles()"/> 
        /// </summary>
        public int NumXTiles
        {
            get { return IExecuteWithSignature<int>("getNumXTiles", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferedImage.html#getNumYTiles()"/> 
        /// </summary>
        public int NumYTiles
        {
            get { return IExecuteWithSignature<int>("getNumYTiles", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferedImage.html#getPropertyNames()"/> 
        /// </summary>
        public Java.Lang.String[] PropertyNames
        {
            get { return IExecuteWithSignatureArray<Java.Lang.String>("getPropertyNames", "()[Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferedImage.html#getRaster()"/> 
        /// </summary>
        public Java.Awt.ImageNs.WritableRaster Raster
        {
            get { return IExecuteWithSignature<Java.Awt.ImageNs.WritableRaster>("getRaster", "()Ljava/awt/image/WritableRaster;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferedImage.html#getSampleModel()"/> 
        /// </summary>
        public Java.Awt.ImageNs.SampleModel SampleModel
        {
            get { return IExecuteWithSignature<Java.Awt.ImageNs.SampleModel>("getSampleModel", "()Ljava/awt/image/SampleModel;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferedImage.html#getSources()"/> 
        /// </summary>
        public Java.Util.Vector<Java.Awt.ImageNs.RenderedImage> Sources
        {
            get { return IExecuteWithSignature<Java.Util.Vector<Java.Awt.ImageNs.RenderedImage>>("getSources", "()Ljava/util/Vector;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferedImage.html#getTileGridXOffset()"/> 
        /// </summary>
        public int TileGridXOffset
        {
            get { return IExecuteWithSignature<int>("getTileGridXOffset", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferedImage.html#getTileGridYOffset()"/> 
        /// </summary>
        public int TileGridYOffset
        {
            get { return IExecuteWithSignature<int>("getTileGridYOffset", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferedImage.html#getTileHeight()"/> 
        /// </summary>
        public int TileHeight
        {
            get { return IExecuteWithSignature<int>("getTileHeight", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferedImage.html#getTileWidth()"/> 
        /// </summary>
        public int TileWidth
        {
            get { return IExecuteWithSignature<int>("getTileWidth", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferedImage.html#getTransparency()"/> 
        /// </summary>
        public int Transparency
        {
            get { return IExecuteWithSignature<int>("getTransparency", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferedImage.html#getType()"/> 
        /// </summary>
        public int Type
        {
            get { return IExecuteWithSignature<int>("getType", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferedImage.html#getWidth()"/> 
        /// </summary>
        public int Width
        {
            get { return IExecuteWithSignature<int>("getWidth", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferedImage.html#getWritableTileIndices()"/> 
        /// </summary>
        public Java.Awt.Point[] WritableTileIndices
        {
            get { return IExecuteWithSignatureArray<Java.Awt.Point>("getWritableTileIndices", "()[Ljava/awt/Point;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferedImage.html#hasTileWriters()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasTileWriters()
        {
            return IExecuteWithSignature<bool>("hasTileWriters", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferedImage.html#isAlphaPremultiplied()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsAlphaPremultiplied()
        {
            return IExecuteWithSignature<bool>("isAlphaPremultiplied", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferedImage.html#isTileWritable(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsTileWritable(int arg0, int arg1)
        {
            return IExecuteWithSignature<bool>("isTileWritable", "(II)Z", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferedImage.html#getRGB(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetRGB(int arg0, int arg1)
        {
            return IExecuteWithSignature<int>("getRGB", "(II)I", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferedImage.html#getRGB(int,int,int,int,int[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <param name="arg6"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int[] GetRGB(int arg0, int arg1, int arg2, int arg3, int[] arg4, int arg5, int arg6)
        {
            return IExecuteWithSignatureArray<int>("getRGB", "(IIII[III)[I", arg0, arg1, arg2, arg3, arg4, arg5, arg6);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferedImage.html#createGraphics()"/>
        /// </summary>
        /// <returns><see cref="Java.Awt.Graphics2D"/></returns>
        public Java.Awt.Graphics2D CreateGraphics()
        {
            return IExecuteWithSignature<Java.Awt.Graphics2D>("createGraphics", "()Ljava/awt/Graphics2D;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferedImage.html#getSubimage(int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.BufferedImage"/></returns>
        public Java.Awt.ImageNs.BufferedImage GetSubimage(int arg0, int arg1, int arg2, int arg3)
        {
            return IExecuteWithSignature<Java.Awt.ImageNs.BufferedImage>("getSubimage", "(IIII)Ljava/awt/image/BufferedImage;", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferedImage.html#getData(java.awt.Rectangle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Rectangle"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.Raster"/></returns>
        public Java.Awt.ImageNs.Raster GetData(Java.Awt.Rectangle arg0)
        {
            return IExecuteWithSignature<Java.Awt.ImageNs.Raster>("getData", "(Ljava/awt/Rectangle;)Ljava/awt/image/Raster;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferedImage.html#getTile(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.Raster"/></returns>
        public Java.Awt.ImageNs.Raster GetTile(int arg0, int arg1)
        {
            return IExecuteWithSignature<Java.Awt.ImageNs.Raster>("getTile", "(II)Ljava/awt/image/Raster;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferedImage.html#copyData(java.awt.image.WritableRaster)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.WritableRaster"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.WritableRaster"/></returns>
        public Java.Awt.ImageNs.WritableRaster CopyData(Java.Awt.ImageNs.WritableRaster arg0)
        {
            return IExecuteWithSignature<Java.Awt.ImageNs.WritableRaster>("copyData", "(Ljava/awt/image/WritableRaster;)Ljava/awt/image/WritableRaster;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferedImage.html#getWritableTile(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.WritableRaster"/></returns>
        public Java.Awt.ImageNs.WritableRaster GetWritableTile(int arg0, int arg1)
        {
            return IExecuteWithSignature<Java.Awt.ImageNs.WritableRaster>("getWritableTile", "(II)Ljava/awt/image/WritableRaster;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferedImage.html#getProperty(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="object"/></returns>
        public object GetProperty(Java.Lang.String arg0)
        {
            return IExecuteWithSignature("getProperty", "(Ljava/lang/String;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferedImage.html#addTileObserver(java.awt.image.TileObserver)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.TileObserver"/></param>
        public void AddTileObserver(Java.Awt.ImageNs.TileObserver arg0)
        {
            IExecuteWithSignature("addTileObserver", "(Ljava/awt/image/TileObserver;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferedImage.html#coerceData(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void CoerceData(bool arg0)
        {
            IExecuteWithSignature("coerceData", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferedImage.html#releaseWritableTile(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void ReleaseWritableTile(int arg0, int arg1)
        {
            IExecuteWithSignature("releaseWritableTile", "(II)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferedImage.html#removeTileObserver(java.awt.image.TileObserver)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.TileObserver"/></param>
        public void RemoveTileObserver(Java.Awt.ImageNs.TileObserver arg0)
        {
            IExecuteWithSignature("removeTileObserver", "(Ljava/awt/image/TileObserver;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferedImage.html#setRGB(int,int,int,int,int[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <param name="arg6"><see cref="int"/></param>
        public void SetRGB(int arg0, int arg1, int arg2, int arg3, int[] arg4, int arg5, int arg6)
        {
            IExecuteWithSignature("setRGB", "(IIII[III)V", arg0, arg1, arg2, arg3, arg4, arg5, arg6);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferedImage.html#setRGB(int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public void SetRGB(int arg0, int arg1, int arg2)
        {
            IExecuteWithSignature("setRGB", "(III)V", arg0, arg1, arg2);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}