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
*  This file is generated by MASES.JNetReflector (ver. 2.5.3.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Awt
{
    #region TexturePaint
    public partial class TexturePaint
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/TexturePaint.html#%3Cinit%3E(java.awt.image.BufferedImage,java.awt.geom.Rectangle2D)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.BufferedImage"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Geom.Rectangle2D"/></param>
        public TexturePaint(Java.Awt.ImageNs.BufferedImage arg0, Java.Awt.Geom.Rectangle2D arg1)
            : base(arg0, arg1)
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/TexturePaint.html#getAnchorRect()"/> 
        /// </summary>
        public Java.Awt.Geom.Rectangle2D AnchorRect
        {
            get { return IExecuteWithSignature<Java.Awt.Geom.Rectangle2D>("getAnchorRect", "()Ljava/awt/geom/Rectangle2D;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/TexturePaint.html#getImage()"/> 
        /// </summary>
        public Java.Awt.ImageNs.BufferedImage Image
        {
            get { return IExecuteWithSignature<Java.Awt.ImageNs.BufferedImage>("getImage", "()Ljava/awt/image/BufferedImage;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/TexturePaint.html#getTransparency()"/> 
        /// </summary>
        public int Transparency
        {
            get { return IExecuteWithSignature<int>("getTransparency", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/TexturePaint.html#createContext(java.awt.image.ColorModel,java.awt.Rectangle,java.awt.geom.Rectangle2D,java.awt.geom.AffineTransform,java.awt.RenderingHints)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.ColorModel"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Rectangle"/></param>
        /// <param name="arg2"><see cref="Java.Awt.Geom.Rectangle2D"/></param>
        /// <param name="arg3"><see cref="Java.Awt.Geom.AffineTransform"/></param>
        /// <param name="arg4"><see cref="Java.Awt.RenderingHints"/></param>
        /// <returns><see cref="Java.Awt.PaintContext"/></returns>
        public Java.Awt.PaintContext CreateContext(Java.Awt.ImageNs.ColorModel arg0, Java.Awt.Rectangle arg1, Java.Awt.Geom.Rectangle2D arg2, Java.Awt.Geom.AffineTransform arg3, Java.Awt.RenderingHints arg4)
        {
            return IExecute<Java.Awt.PaintContext>("createContext", arg0, arg1, arg2, arg3, arg4);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}