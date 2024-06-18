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
    #region FontMetrics
    public partial class FontMetrics
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/FontMetrics.html#getAscent()"/> 
        /// </summary>
        public int Ascent
        {
            get { return IExecuteWithSignature<int>("getAscent", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/FontMetrics.html#getDescent()"/> 
        /// </summary>
        public int Descent
        {
            get { return IExecuteWithSignature<int>("getDescent", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/FontMetrics.html#getFont()"/> 
        /// </summary>
        public Java.Awt.Font Font
        {
            get { return IExecuteWithSignature<Java.Awt.Font>("getFont", "()Ljava/awt/Font;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/FontMetrics.html#getFontRenderContext()"/> 
        /// </summary>
        public Java.Awt.FontNs.FontRenderContext FontRenderContext
        {
            get { return IExecuteWithSignature<Java.Awt.FontNs.FontRenderContext>("getFontRenderContext", "()Ljava/awt/font/FontRenderContext;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/FontMetrics.html#getHeight()"/> 
        /// </summary>
        public int Height
        {
            get { return IExecuteWithSignature<int>("getHeight", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/FontMetrics.html#getLeading()"/> 
        /// </summary>
        public int Leading
        {
            get { return IExecuteWithSignature<int>("getLeading", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/FontMetrics.html#getMaxAdvance()"/> 
        /// </summary>
        public int MaxAdvance
        {
            get { return IExecuteWithSignature<int>("getMaxAdvance", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/FontMetrics.html#getMaxAscent()"/> 
        /// </summary>
        public int MaxAscent
        {
            get { return IExecuteWithSignature<int>("getMaxAscent", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/FontMetrics.html#getMaxDescent()"/> 
        /// </summary>
        public int MaxDescent
        {
            get { return IExecuteWithSignature<int>("getMaxDescent", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/FontMetrics.html#getWidths()"/> 
        /// </summary>
        public int[] Widths
        {
            get { return IExecuteWithSignatureArray<int>("getWidths", "()[I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/FontMetrics.html#hasUniformLineMetrics()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasUniformLineMetrics()
        {
            return IExecuteWithSignature<bool>("hasUniformLineMetrics", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/FontMetrics.html#bytesWidth(byte[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int BytesWidth(byte[] arg0, int arg1, int arg2)
        {
            return IExecute<int>("bytesWidth", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/FontMetrics.html#charsWidth(char[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="char"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int CharsWidth(char[] arg0, int arg1, int arg2)
        {
            return IExecute<int>("charsWidth", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/FontMetrics.html#charWidth(char)"/>
        /// </summary>
        /// <param name="arg0"><see cref="char"/></param>
        /// <returns><see cref="int"/></returns>
        public int CharWidth(char arg0)
        {
            return IExecuteWithSignature<int>("charWidth", "(C)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/FontMetrics.html#charWidth(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int CharWidth(int arg0)
        {
            return IExecuteWithSignature<int>("charWidth", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/FontMetrics.html#stringWidth(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="int"/></returns>
        public int StringWidth(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<int>("stringWidth", "(Ljava/lang/String;)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/FontMetrics.html#getLineMetrics(char[],int,int,java.awt.Graphics)"/>
        /// </summary>
        /// <param name="arg0"><see cref="char"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="Java.Awt.Graphics"/></param>
        /// <returns><see cref="Java.Awt.FontNs.LineMetrics"/></returns>
        public Java.Awt.FontNs.LineMetrics GetLineMetrics(char[] arg0, int arg1, int arg2, Java.Awt.Graphics arg3)
        {
            return IExecute<Java.Awt.FontNs.LineMetrics>("getLineMetrics", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/FontMetrics.html#getLineMetrics(java.lang.String,int,int,java.awt.Graphics)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="Java.Awt.Graphics"/></param>
        /// <returns><see cref="Java.Awt.FontNs.LineMetrics"/></returns>
        public Java.Awt.FontNs.LineMetrics GetLineMetrics(Java.Lang.String arg0, int arg1, int arg2, Java.Awt.Graphics arg3)
        {
            return IExecute<Java.Awt.FontNs.LineMetrics>("getLineMetrics", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/FontMetrics.html#getLineMetrics(java.lang.String,java.awt.Graphics)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Graphics"/></param>
        /// <returns><see cref="Java.Awt.FontNs.LineMetrics"/></returns>
        public Java.Awt.FontNs.LineMetrics GetLineMetrics(Java.Lang.String arg0, Java.Awt.Graphics arg1)
        {
            return IExecute<Java.Awt.FontNs.LineMetrics>("getLineMetrics", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/FontMetrics.html#getLineMetrics(java.text.CharacterIterator,int,int,java.awt.Graphics)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Text.CharacterIterator"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="Java.Awt.Graphics"/></param>
        /// <returns><see cref="Java.Awt.FontNs.LineMetrics"/></returns>
        public Java.Awt.FontNs.LineMetrics GetLineMetrics(Java.Text.CharacterIterator arg0, int arg1, int arg2, Java.Awt.Graphics arg3)
        {
            return IExecute<Java.Awt.FontNs.LineMetrics>("getLineMetrics", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/FontMetrics.html#getMaxCharBounds(java.awt.Graphics)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Graphics"/></param>
        /// <returns><see cref="Java.Awt.Geom.Rectangle2D"/></returns>
        public Java.Awt.Geom.Rectangle2D GetMaxCharBounds(Java.Awt.Graphics arg0)
        {
            return IExecuteWithSignature<Java.Awt.Geom.Rectangle2D>("getMaxCharBounds", "(Ljava/awt/Graphics;)Ljava/awt/geom/Rectangle2D;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/FontMetrics.html#getStringBounds(char[],int,int,java.awt.Graphics)"/>
        /// </summary>
        /// <param name="arg0"><see cref="char"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="Java.Awt.Graphics"/></param>
        /// <returns><see cref="Java.Awt.Geom.Rectangle2D"/></returns>
        public Java.Awt.Geom.Rectangle2D GetStringBounds(char[] arg0, int arg1, int arg2, Java.Awt.Graphics arg3)
        {
            return IExecute<Java.Awt.Geom.Rectangle2D>("getStringBounds", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/FontMetrics.html#getStringBounds(java.lang.String,int,int,java.awt.Graphics)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="Java.Awt.Graphics"/></param>
        /// <returns><see cref="Java.Awt.Geom.Rectangle2D"/></returns>
        public Java.Awt.Geom.Rectangle2D GetStringBounds(Java.Lang.String arg0, int arg1, int arg2, Java.Awt.Graphics arg3)
        {
            return IExecute<Java.Awt.Geom.Rectangle2D>("getStringBounds", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/FontMetrics.html#getStringBounds(java.lang.String,java.awt.Graphics)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Graphics"/></param>
        /// <returns><see cref="Java.Awt.Geom.Rectangle2D"/></returns>
        public Java.Awt.Geom.Rectangle2D GetStringBounds(Java.Lang.String arg0, Java.Awt.Graphics arg1)
        {
            return IExecute<Java.Awt.Geom.Rectangle2D>("getStringBounds", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/FontMetrics.html#getStringBounds(java.text.CharacterIterator,int,int,java.awt.Graphics)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Text.CharacterIterator"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="Java.Awt.Graphics"/></param>
        /// <returns><see cref="Java.Awt.Geom.Rectangle2D"/></returns>
        public Java.Awt.Geom.Rectangle2D GetStringBounds(Java.Text.CharacterIterator arg0, int arg1, int arg2, Java.Awt.Graphics arg3)
        {
            return IExecute<Java.Awt.Geom.Rectangle2D>("getStringBounds", arg0, arg1, arg2, arg3);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}