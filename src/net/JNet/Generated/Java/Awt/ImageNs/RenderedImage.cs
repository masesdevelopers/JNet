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
    #region RenderedImage declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/RenderedImage.html"/>
    /// </summary>
    public partial class RenderedImage : MASES.JCOBridge.C2JBridge.JVMBridgeBase<RenderedImage>
    {
        const string _bridgeClassName = "java.awt.image.RenderedImage";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("RenderedImage class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public RenderedImage() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("RenderedImage class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public RenderedImage(params object[] args) : base(args) { }

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
        public override bool IsBridgeInterface => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region IRenderedImage
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IRenderedImage
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/RenderedImage.html#getColorModel()"/> 
        /// </summary>
        Java.Awt.ImageNs.ColorModel ColorModel { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/RenderedImage.html#getData()"/> 
        /// </summary>
        Java.Awt.ImageNs.Raster Data { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/RenderedImage.html#getHeight()"/> 
        /// </summary>
        int Height { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/RenderedImage.html#getMinTileX()"/> 
        /// </summary>
        int MinTileX { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/RenderedImage.html#getMinTileY()"/> 
        /// </summary>
        int MinTileY { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/RenderedImage.html#getMinX()"/> 
        /// </summary>
        int MinX { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/RenderedImage.html#getMinY()"/> 
        /// </summary>
        int MinY { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/RenderedImage.html#getNumXTiles()"/> 
        /// </summary>
        int NumXTiles { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/RenderedImage.html#getNumYTiles()"/> 
        /// </summary>
        int NumYTiles { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/RenderedImage.html#getPropertyNames()"/> 
        /// </summary>
        Java.Lang.String[] PropertyNames { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/RenderedImage.html#getSampleModel()"/> 
        /// </summary>
        Java.Awt.ImageNs.SampleModel SampleModel { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/RenderedImage.html#getSources()"/> 
        /// </summary>
        Java.Util.Vector<Java.Awt.ImageNs.RenderedImage> Sources { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/RenderedImage.html#getTileGridXOffset()"/> 
        /// </summary>
        int TileGridXOffset { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/RenderedImage.html#getTileGridYOffset()"/> 
        /// </summary>
        int TileGridYOffset { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/RenderedImage.html#getTileHeight()"/> 
        /// </summary>
        int TileHeight { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/RenderedImage.html#getTileWidth()"/> 
        /// </summary>
        int TileWidth { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/RenderedImage.html#getWidth()"/> 
        /// </summary>
        int Width { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/RenderedImage.html#getData(java.awt.Rectangle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Rectangle"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.Raster"/></returns>
        Java.Awt.ImageNs.Raster GetData(Java.Awt.Rectangle arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/RenderedImage.html#getTile(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.Raster"/></returns>
        Java.Awt.ImageNs.Raster GetTile(int arg0, int arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/RenderedImage.html#copyData(java.awt.image.WritableRaster)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.WritableRaster"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.WritableRaster"/></returns>
        Java.Awt.ImageNs.WritableRaster CopyData(Java.Awt.ImageNs.WritableRaster arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/RenderedImage.html#getProperty(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="object"/></returns>
        object GetProperty(Java.Lang.String arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region RenderedImage implementation
    public partial class RenderedImage : Java.Awt.ImageNs.IRenderedImage
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/RenderedImage.html#getColorModel()"/> 
        /// </summary>
        public Java.Awt.ImageNs.ColorModel ColorModel
        {
            get { return IExecuteWithSignature<Java.Awt.ImageNs.ColorModel>("getColorModel", "()Ljava/awt/image/ColorModel;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/RenderedImage.html#getData()"/> 
        /// </summary>
        public Java.Awt.ImageNs.Raster Data
        {
            get { return IExecuteWithSignature<Java.Awt.ImageNs.Raster>("getData", "()Ljava/awt/image/Raster;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/RenderedImage.html#getHeight()"/> 
        /// </summary>
        public int Height
        {
            get { return IExecuteWithSignature<int>("getHeight", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/RenderedImage.html#getMinTileX()"/> 
        /// </summary>
        public int MinTileX
        {
            get { return IExecuteWithSignature<int>("getMinTileX", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/RenderedImage.html#getMinTileY()"/> 
        /// </summary>
        public int MinTileY
        {
            get { return IExecuteWithSignature<int>("getMinTileY", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/RenderedImage.html#getMinX()"/> 
        /// </summary>
        public int MinX
        {
            get { return IExecuteWithSignature<int>("getMinX", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/RenderedImage.html#getMinY()"/> 
        /// </summary>
        public int MinY
        {
            get { return IExecuteWithSignature<int>("getMinY", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/RenderedImage.html#getNumXTiles()"/> 
        /// </summary>
        public int NumXTiles
        {
            get { return IExecuteWithSignature<int>("getNumXTiles", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/RenderedImage.html#getNumYTiles()"/> 
        /// </summary>
        public int NumYTiles
        {
            get { return IExecuteWithSignature<int>("getNumYTiles", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/RenderedImage.html#getPropertyNames()"/> 
        /// </summary>
        public Java.Lang.String[] PropertyNames
        {
            get { return IExecuteWithSignatureArray<Java.Lang.String>("getPropertyNames", "()[Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/RenderedImage.html#getSampleModel()"/> 
        /// </summary>
        public Java.Awt.ImageNs.SampleModel SampleModel
        {
            get { return IExecuteWithSignature<Java.Awt.ImageNs.SampleModel>("getSampleModel", "()Ljava/awt/image/SampleModel;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/RenderedImage.html#getSources()"/> 
        /// </summary>
        public Java.Util.Vector<Java.Awt.ImageNs.RenderedImage> Sources
        {
            get { return IExecuteWithSignature<Java.Util.Vector<Java.Awt.ImageNs.RenderedImage>>("getSources", "()Ljava/util/Vector;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/RenderedImage.html#getTileGridXOffset()"/> 
        /// </summary>
        public int TileGridXOffset
        {
            get { return IExecuteWithSignature<int>("getTileGridXOffset", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/RenderedImage.html#getTileGridYOffset()"/> 
        /// </summary>
        public int TileGridYOffset
        {
            get { return IExecuteWithSignature<int>("getTileGridYOffset", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/RenderedImage.html#getTileHeight()"/> 
        /// </summary>
        public int TileHeight
        {
            get { return IExecuteWithSignature<int>("getTileHeight", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/RenderedImage.html#getTileWidth()"/> 
        /// </summary>
        public int TileWidth
        {
            get { return IExecuteWithSignature<int>("getTileWidth", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/RenderedImage.html#getWidth()"/> 
        /// </summary>
        public int Width
        {
            get { return IExecuteWithSignature<int>("getWidth", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/RenderedImage.html#getData(java.awt.Rectangle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Rectangle"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.Raster"/></returns>
        public Java.Awt.ImageNs.Raster GetData(Java.Awt.Rectangle arg0)
        {
            return IExecuteWithSignature<Java.Awt.ImageNs.Raster>("getData", "(Ljava/awt/Rectangle;)Ljava/awt/image/Raster;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/RenderedImage.html#getTile(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.Raster"/></returns>
        public Java.Awt.ImageNs.Raster GetTile(int arg0, int arg1)
        {
            return IExecuteWithSignature<Java.Awt.ImageNs.Raster>("getTile", "(II)Ljava/awt/image/Raster;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/RenderedImage.html#copyData(java.awt.image.WritableRaster)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.WritableRaster"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.WritableRaster"/></returns>
        public Java.Awt.ImageNs.WritableRaster CopyData(Java.Awt.ImageNs.WritableRaster arg0)
        {
            return IExecuteWithSignature<Java.Awt.ImageNs.WritableRaster>("copyData", "(Ljava/awt/image/WritableRaster;)Ljava/awt/image/WritableRaster;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/RenderedImage.html#getProperty(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="object"/></returns>
        public object GetProperty(Java.Lang.String arg0)
        {
            return IExecuteWithSignature("getProperty", "(Ljava/lang/String;)Ljava/lang/Object;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}