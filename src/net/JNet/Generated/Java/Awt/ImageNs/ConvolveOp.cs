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
*  This file is generated by MASES.JNetReflector (ver. 2.5.7.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Awt.ImageNs
{
    #region ConvolveOp
    public partial class ConvolveOp
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/ConvolveOp.html#%3Cinit%3E(java.awt.image.Kernel,int,java.awt.RenderingHints)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.Kernel"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Java.Awt.RenderingHints"/></param>
        public ConvolveOp(Java.Awt.ImageNs.Kernel arg0, int arg1, Java.Awt.RenderingHints arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/ConvolveOp.html#%3Cinit%3E(java.awt.image.Kernel)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.Kernel"/></param>
        public ConvolveOp(Java.Awt.ImageNs.Kernel arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Awt.ImageNs.ConvolveOp"/> to <see cref="Java.Awt.ImageNs.BufferedImageOp"/>
        /// </summary>
        public static implicit operator Java.Awt.ImageNs.BufferedImageOp(Java.Awt.ImageNs.ConvolveOp t) => t.Cast<Java.Awt.ImageNs.BufferedImageOp>();
        /// <summary>
        /// Converter from <see cref="Java.Awt.ImageNs.ConvolveOp"/> to <see cref="Java.Awt.ImageNs.RasterOp"/>
        /// </summary>
        public static implicit operator Java.Awt.ImageNs.RasterOp(Java.Awt.ImageNs.ConvolveOp t) => t.Cast<Java.Awt.ImageNs.RasterOp>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/ConvolveOp.html#EDGE_NO_OP"/>
        /// </summary>
        public static int EDGE_NO_OP { get { if (!_EDGE_NO_OPReady) { _EDGE_NO_OPContent = SGetField<int>(LocalBridgeClazz, "EDGE_NO_OP"); _EDGE_NO_OPReady = true; } return _EDGE_NO_OPContent; } }
        private static int _EDGE_NO_OPContent = default;
        private static bool _EDGE_NO_OPReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/ConvolveOp.html#EDGE_ZERO_FILL"/>
        /// </summary>
        public static int EDGE_ZERO_FILL { get { if (!_EDGE_ZERO_FILLReady) { _EDGE_ZERO_FILLContent = SGetField<int>(LocalBridgeClazz, "EDGE_ZERO_FILL"); _EDGE_ZERO_FILLReady = true; } return _EDGE_ZERO_FILLContent; } }
        private static int _EDGE_ZERO_FILLContent = default;
        private static bool _EDGE_ZERO_FILLReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/ConvolveOp.html#getEdgeCondition()"/> 
        /// </summary>
        public int EdgeCondition
        {
            get { return IExecuteWithSignature<int>("getEdgeCondition", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/ConvolveOp.html#getKernel()"/> 
        /// </summary>
        public Java.Awt.ImageNs.Kernel Kernel
        {
            get { return IExecuteWithSignature<Java.Awt.ImageNs.Kernel>("getKernel", "()Ljava/awt/image/Kernel;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/ConvolveOp.html#getRenderingHints()"/> 
        /// </summary>
        public Java.Awt.RenderingHints RenderingHints
        {
            get { return IExecuteWithSignature<Java.Awt.RenderingHints>("getRenderingHints", "()Ljava/awt/RenderingHints;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/ConvolveOp.html#getPoint2D(java.awt.geom.Point2D,java.awt.geom.Point2D)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Geom.Point2D"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Geom.Point2D"/></param>
        /// <returns><see cref="Java.Awt.Geom.Point2D"/></returns>
        public Java.Awt.Geom.Point2D GetPoint2D(Java.Awt.Geom.Point2D arg0, Java.Awt.Geom.Point2D arg1)
        {
            return IExecute<Java.Awt.Geom.Point2D>("getPoint2D", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/ConvolveOp.html#getBounds2D(java.awt.image.BufferedImage)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.BufferedImage"/></param>
        /// <returns><see cref="Java.Awt.Geom.Rectangle2D"/></returns>
        public Java.Awt.Geom.Rectangle2D GetBounds2D(Java.Awt.ImageNs.BufferedImage arg0)
        {
            return IExecuteWithSignature<Java.Awt.Geom.Rectangle2D>("getBounds2D", "(Ljava/awt/image/BufferedImage;)Ljava/awt/geom/Rectangle2D;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/ConvolveOp.html#getBounds2D(java.awt.image.Raster)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.Raster"/></param>
        /// <returns><see cref="Java.Awt.Geom.Rectangle2D"/></returns>
        public Java.Awt.Geom.Rectangle2D GetBounds2D(Java.Awt.ImageNs.Raster arg0)
        {
            return IExecuteWithSignature<Java.Awt.Geom.Rectangle2D>("getBounds2D", "(Ljava/awt/image/Raster;)Ljava/awt/geom/Rectangle2D;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/ConvolveOp.html#filter(java.awt.image.BufferedImage,java.awt.image.BufferedImage)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.BufferedImage"/></param>
        /// <param name="arg1"><see cref="Java.Awt.ImageNs.BufferedImage"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.BufferedImage"/></returns>
        public Java.Awt.ImageNs.BufferedImage Filter(Java.Awt.ImageNs.BufferedImage arg0, Java.Awt.ImageNs.BufferedImage arg1)
        {
            return IExecute<Java.Awt.ImageNs.BufferedImage>("filter", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/ConvolveOp.html#filter(java.awt.image.Raster,java.awt.image.WritableRaster)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.Raster"/></param>
        /// <param name="arg1"><see cref="Java.Awt.ImageNs.WritableRaster"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.WritableRaster"/></returns>
        public Java.Awt.ImageNs.WritableRaster Filter(Java.Awt.ImageNs.Raster arg0, Java.Awt.ImageNs.WritableRaster arg1)
        {
            return IExecute<Java.Awt.ImageNs.WritableRaster>("filter", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/ConvolveOp.html#createCompatibleDestImage(java.awt.image.BufferedImage,java.awt.image.ColorModel)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.BufferedImage"/></param>
        /// <param name="arg1"><see cref="Java.Awt.ImageNs.ColorModel"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.BufferedImage"/></returns>
        public Java.Awt.ImageNs.BufferedImage CreateCompatibleDestImage(Java.Awt.ImageNs.BufferedImage arg0, Java.Awt.ImageNs.ColorModel arg1)
        {
            return IExecute<Java.Awt.ImageNs.BufferedImage>("createCompatibleDestImage", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/ConvolveOp.html#createCompatibleDestRaster(java.awt.image.Raster)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.Raster"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.WritableRaster"/></returns>
        public Java.Awt.ImageNs.WritableRaster CreateCompatibleDestRaster(Java.Awt.ImageNs.Raster arg0)
        {
            return IExecuteWithSignature<Java.Awt.ImageNs.WritableRaster>("createCompatibleDestRaster", "(Ljava/awt/image/Raster;)Ljava/awt/image/WritableRaster;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}