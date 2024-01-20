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
*  This file is generated by MASES.JNetReflector (ver. 2.2.1.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Awt.FontNs
{
    #region GlyphVector
    public partial class GlyphVector
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/GlyphVector.html#FLAG_COMPLEX_GLYPHS"/>
        /// </summary>
        public static int FLAG_COMPLEX_GLYPHS { get { return SGetField<int>(LocalBridgeClazz, "FLAG_COMPLEX_GLYPHS"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/GlyphVector.html#FLAG_HAS_POSITION_ADJUSTMENTS"/>
        /// </summary>
        public static int FLAG_HAS_POSITION_ADJUSTMENTS { get { return SGetField<int>(LocalBridgeClazz, "FLAG_HAS_POSITION_ADJUSTMENTS"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/GlyphVector.html#FLAG_HAS_TRANSFORMS"/>
        /// </summary>
        public static int FLAG_HAS_TRANSFORMS { get { return SGetField<int>(LocalBridgeClazz, "FLAG_HAS_TRANSFORMS"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/GlyphVector.html#FLAG_MASK"/>
        /// </summary>
        public static int FLAG_MASK { get { return SGetField<int>(LocalBridgeClazz, "FLAG_MASK"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/GlyphVector.html#FLAG_RUN_RTL"/>
        /// </summary>
        public static int FLAG_RUN_RTL { get { return SGetField<int>(LocalBridgeClazz, "FLAG_RUN_RTL"); } }

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/GlyphVector.html#getFont()"/> 
        /// </summary>
        public Java.Awt.Font Font
        {
            get { return IExecute<Java.Awt.Font>("getFont"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/GlyphVector.html#getFontRenderContext()"/> 
        /// </summary>
        public Java.Awt.FontNs.FontRenderContext FontRenderContext
        {
            get { return IExecute<Java.Awt.FontNs.FontRenderContext>("getFontRenderContext"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/GlyphVector.html#getLayoutFlags()"/> 
        /// </summary>
        public int LayoutFlags
        {
            get { return IExecute<int>("getLayoutFlags"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/GlyphVector.html#getLogicalBounds()"/> 
        /// </summary>
        public Java.Awt.Geom.Rectangle2D LogicalBounds
        {
            get { return IExecute<Java.Awt.Geom.Rectangle2D>("getLogicalBounds"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/GlyphVector.html#getNumGlyphs()"/> 
        /// </summary>
        public int NumGlyphs
        {
            get { return IExecute<int>("getNumGlyphs"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/GlyphVector.html#getOutline()"/> 
        /// </summary>
        public Java.Awt.Shape Outline
        {
            get { return IExecute<Java.Awt.Shape>("getOutline"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/GlyphVector.html#getVisualBounds()"/> 
        /// </summary>
        public Java.Awt.Geom.Rectangle2D VisualBounds
        {
            get { return IExecute<Java.Awt.Geom.Rectangle2D>("getVisualBounds"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/GlyphVector.html#getGlyphPositions(int,int,float[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        /// <returns><see cref="float"/></returns>
        public float[] GetGlyphPositions(int arg0, int arg1, float[] arg2)
        {
            return IExecuteArray<float>("getGlyphPositions", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/GlyphVector.html#getGlyphCode(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetGlyphCode(int arg0)
        {
            return IExecute<int>("getGlyphCode", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/GlyphVector.html#getGlyphCodes(int,int,int[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int[] GetGlyphCodes(int arg0, int arg1, int[] arg2)
        {
            return IExecuteArray<int>("getGlyphCodes", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/GlyphVector.html#getGlyphJustificationInfo(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.FontNs.GlyphJustificationInfo"/></returns>
        public Java.Awt.FontNs.GlyphJustificationInfo GetGlyphJustificationInfo(int arg0)
        {
            return IExecute<Java.Awt.FontNs.GlyphJustificationInfo>("getGlyphJustificationInfo", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/GlyphVector.html#getGlyphMetrics(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.FontNs.GlyphMetrics"/></returns>
        public Java.Awt.FontNs.GlyphMetrics GetGlyphMetrics(int arg0)
        {
            return IExecute<Java.Awt.FontNs.GlyphMetrics>("getGlyphMetrics", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/GlyphVector.html#getGlyphTransform(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.Geom.AffineTransform"/></returns>
        public Java.Awt.Geom.AffineTransform GetGlyphTransform(int arg0)
        {
            return IExecute<Java.Awt.Geom.AffineTransform>("getGlyphTransform", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/GlyphVector.html#getGlyphPosition(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.Geom.Point2D"/></returns>
        public Java.Awt.Geom.Point2D GetGlyphPosition(int arg0)
        {
            return IExecute<Java.Awt.Geom.Point2D>("getGlyphPosition", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/GlyphVector.html#getGlyphLogicalBounds(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.Shape"/></returns>
        public Java.Awt.Shape GetGlyphLogicalBounds(int arg0)
        {
            return IExecute<Java.Awt.Shape>("getGlyphLogicalBounds", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/GlyphVector.html#getGlyphOutline(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.Shape"/></returns>
        public Java.Awt.Shape GetGlyphOutline(int arg0)
        {
            return IExecute<Java.Awt.Shape>("getGlyphOutline", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/GlyphVector.html#getGlyphVisualBounds(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.Shape"/></returns>
        public Java.Awt.Shape GetGlyphVisualBounds(int arg0)
        {
            return IExecute<Java.Awt.Shape>("getGlyphVisualBounds", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/GlyphVector.html#getOutline(float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <returns><see cref="Java.Awt.Shape"/></returns>
        public Java.Awt.Shape GetOutline(float arg0, float arg1)
        {
            return IExecute<Java.Awt.Shape>("getOutline", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/GlyphVector.html#performDefaultLayout()"/>
        /// </summary>
        public void PerformDefaultLayout()
        {
            IExecute("performDefaultLayout");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/GlyphVector.html#setGlyphPosition(int,java.awt.geom.Point2D)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Geom.Point2D"/></param>
        public void SetGlyphPosition(int arg0, Java.Awt.Geom.Point2D arg1)
        {
            IExecute("setGlyphPosition", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/GlyphVector.html#setGlyphTransform(int,java.awt.geom.AffineTransform)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Geom.AffineTransform"/></param>
        public void SetGlyphTransform(int arg0, Java.Awt.Geom.AffineTransform arg1)
        {
            IExecute("setGlyphTransform", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/GlyphVector.html#getGlyphCharIndex(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetGlyphCharIndex(int arg0)
        {
            return IExecute<int>("getGlyphCharIndex", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/GlyphVector.html#getGlyphCharIndices(int,int,int[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int[] GetGlyphCharIndices(int arg0, int arg1, int[] arg2)
        {
            return IExecuteArray<int>("getGlyphCharIndices", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/GlyphVector.html#getGlyphPixelBounds(int,java.awt.font.FontRenderContext,float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Awt.FontNs.FontRenderContext"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        /// <param name="arg3"><see cref="float"/></param>
        /// <returns><see cref="Java.Awt.Rectangle"/></returns>
        public Java.Awt.Rectangle GetGlyphPixelBounds(int arg0, Java.Awt.FontNs.FontRenderContext arg1, float arg2, float arg3)
        {
            return IExecute<Java.Awt.Rectangle>("getGlyphPixelBounds", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/GlyphVector.html#getPixelBounds(java.awt.font.FontRenderContext,float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.FontNs.FontRenderContext"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        /// <returns><see cref="Java.Awt.Rectangle"/></returns>
        public Java.Awt.Rectangle GetPixelBounds(Java.Awt.FontNs.FontRenderContext arg0, float arg1, float arg2)
        {
            return IExecute<Java.Awt.Rectangle>("getPixelBounds", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/GlyphVector.html#getGlyphOutline(int,float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        /// <returns><see cref="Java.Awt.Shape"/></returns>
        public Java.Awt.Shape GetGlyphOutline(int arg0, float arg1, float arg2)
        {
            return IExecute<Java.Awt.Shape>("getGlyphOutline", arg0, arg1, arg2);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}