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
*  This file is generated by MASES.JNetReflector (ver. 2.5.6.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Swing.Plaf.Synth
{
    #region SynthGraphicsUtils
    public partial class SynthGraphicsUtils
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/synth/SynthGraphicsUtils.html#getIconHeight(javax.swing.Icon,javax.swing.plaf.synth.SynthContext)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Icon"/></param>
        /// <param name="arg1"><see cref="Javax.Swing.Plaf.Synth.SynthContext"/></param>
        /// <returns><see cref="int"/></returns>
        public static int GetIconHeight(Javax.Swing.Icon arg0, Javax.Swing.Plaf.Synth.SynthContext arg1)
        {
            return SExecute<int>(LocalBridgeClazz, "getIconHeight", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/synth/SynthGraphicsUtils.html#getIconWidth(javax.swing.Icon,javax.swing.plaf.synth.SynthContext)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Icon"/></param>
        /// <param name="arg1"><see cref="Javax.Swing.Plaf.Synth.SynthContext"/></param>
        /// <returns><see cref="int"/></returns>
        public static int GetIconWidth(Javax.Swing.Icon arg0, Javax.Swing.Plaf.Synth.SynthContext arg1)
        {
            return SExecute<int>(LocalBridgeClazz, "getIconWidth", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/synth/SynthGraphicsUtils.html#paintIcon(javax.swing.Icon,javax.swing.plaf.synth.SynthContext,java.awt.Graphics,int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Icon"/></param>
        /// <param name="arg1"><see cref="Javax.Swing.Plaf.Synth.SynthContext"/></param>
        /// <param name="arg2"><see cref="Java.Awt.Graphics"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <param name="arg6"><see cref="int"/></param>
        public static void PaintIcon(Javax.Swing.Icon arg0, Javax.Swing.Plaf.Synth.SynthContext arg1, Java.Awt.Graphics arg2, int arg3, int arg4, int arg5, int arg6)
        {
            SExecute(LocalBridgeClazz, "paintIcon", arg0, arg1, arg2, arg3, arg4, arg5, arg6);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/synth/SynthGraphicsUtils.html#computeStringWidth(javax.swing.plaf.synth.SynthContext,java.awt.Font,java.awt.FontMetrics,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Plaf.Synth.SynthContext"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Font"/></param>
        /// <param name="arg2"><see cref="Java.Awt.FontMetrics"/></param>
        /// <param name="arg3"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="int"/></returns>
        public int ComputeStringWidth(Javax.Swing.Plaf.Synth.SynthContext arg0, Java.Awt.Font arg1, Java.Awt.FontMetrics arg2, Java.Lang.String arg3)
        {
            return IExecute<int>("computeStringWidth", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/synth/SynthGraphicsUtils.html#getMaximumCharHeight(javax.swing.plaf.synth.SynthContext)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Plaf.Synth.SynthContext"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetMaximumCharHeight(Javax.Swing.Plaf.Synth.SynthContext arg0)
        {
            return IExecuteWithSignature<int>("getMaximumCharHeight", "(Ljavax/swing/plaf/synth/SynthContext;)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/synth/SynthGraphicsUtils.html#getMaximumSize(javax.swing.plaf.synth.SynthContext,java.awt.Font,java.lang.String,javax.swing.Icon,int,int,int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Plaf.Synth.SynthContext"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Font"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="Javax.Swing.Icon"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <param name="arg6"><see cref="int"/></param>
        /// <param name="arg7"><see cref="int"/></param>
        /// <param name="arg8"><see cref="int"/></param>
        /// <param name="arg9"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.Dimension"/></returns>
        public Java.Awt.Dimension GetMaximumSize(Javax.Swing.Plaf.Synth.SynthContext arg0, Java.Awt.Font arg1, Java.Lang.String arg2, Javax.Swing.Icon arg3, int arg4, int arg5, int arg6, int arg7, int arg8, int arg9)
        {
            return IExecute<Java.Awt.Dimension>("getMaximumSize", arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/synth/SynthGraphicsUtils.html#getMinimumSize(javax.swing.plaf.synth.SynthContext,java.awt.Font,java.lang.String,javax.swing.Icon,int,int,int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Plaf.Synth.SynthContext"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Font"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="Javax.Swing.Icon"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <param name="arg6"><see cref="int"/></param>
        /// <param name="arg7"><see cref="int"/></param>
        /// <param name="arg8"><see cref="int"/></param>
        /// <param name="arg9"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.Dimension"/></returns>
        public Java.Awt.Dimension GetMinimumSize(Javax.Swing.Plaf.Synth.SynthContext arg0, Java.Awt.Font arg1, Java.Lang.String arg2, Javax.Swing.Icon arg3, int arg4, int arg5, int arg6, int arg7, int arg8, int arg9)
        {
            return IExecute<Java.Awt.Dimension>("getMinimumSize", arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/synth/SynthGraphicsUtils.html#getPreferredSize(javax.swing.plaf.synth.SynthContext,java.awt.Font,java.lang.String,javax.swing.Icon,int,int,int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Plaf.Synth.SynthContext"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Font"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="Javax.Swing.Icon"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <param name="arg6"><see cref="int"/></param>
        /// <param name="arg7"><see cref="int"/></param>
        /// <param name="arg8"><see cref="int"/></param>
        /// <param name="arg9"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.Dimension"/></returns>
        public Java.Awt.Dimension GetPreferredSize(Javax.Swing.Plaf.Synth.SynthContext arg0, Java.Awt.Font arg1, Java.Lang.String arg2, Javax.Swing.Icon arg3, int arg4, int arg5, int arg6, int arg7, int arg8, int arg9)
        {
            return IExecute<Java.Awt.Dimension>("getPreferredSize", arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/synth/SynthGraphicsUtils.html#layoutText(javax.swing.plaf.synth.SynthContext,java.awt.FontMetrics,java.lang.String,javax.swing.Icon,int,int,int,int,java.awt.Rectangle,java.awt.Rectangle,java.awt.Rectangle,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Plaf.Synth.SynthContext"/></param>
        /// <param name="arg1"><see cref="Java.Awt.FontMetrics"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="Javax.Swing.Icon"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <param name="arg6"><see cref="int"/></param>
        /// <param name="arg7"><see cref="int"/></param>
        /// <param name="arg8"><see cref="Java.Awt.Rectangle"/></param>
        /// <param name="arg9"><see cref="Java.Awt.Rectangle"/></param>
        /// <param name="arg10"><see cref="Java.Awt.Rectangle"/></param>
        /// <param name="arg11"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String LayoutText(Javax.Swing.Plaf.Synth.SynthContext arg0, Java.Awt.FontMetrics arg1, Java.Lang.String arg2, Javax.Swing.Icon arg3, int arg4, int arg5, int arg6, int arg7, Java.Awt.Rectangle arg8, Java.Awt.Rectangle arg9, Java.Awt.Rectangle arg10, int arg11)
        {
            return IExecute<Java.Lang.String>("layoutText", arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/synth/SynthGraphicsUtils.html#drawLine(javax.swing.plaf.synth.SynthContext,java.lang.Object,java.awt.Graphics,int,int,int,int,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Plaf.Synth.SynthContext"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="Java.Awt.Graphics"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <param name="arg6"><see cref="int"/></param>
        /// <param name="arg7"><see cref="object"/></param>
        public void DrawLine(Javax.Swing.Plaf.Synth.SynthContext arg0, object arg1, Java.Awt.Graphics arg2, int arg3, int arg4, int arg5, int arg6, object arg7)
        {
            IExecute("drawLine", arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/synth/SynthGraphicsUtils.html#drawLine(javax.swing.plaf.synth.SynthContext,java.lang.Object,java.awt.Graphics,int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Plaf.Synth.SynthContext"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="Java.Awt.Graphics"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <param name="arg6"><see cref="int"/></param>
        public void DrawLine(Javax.Swing.Plaf.Synth.SynthContext arg0, object arg1, Java.Awt.Graphics arg2, int arg3, int arg4, int arg5, int arg6)
        {
            IExecute("drawLine", arg0, arg1, arg2, arg3, arg4, arg5, arg6);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/synth/SynthGraphicsUtils.html#paintText(javax.swing.plaf.synth.SynthContext,java.awt.Graphics,java.lang.String,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Plaf.Synth.SynthContext"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Graphics"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        public void PaintText(Javax.Swing.Plaf.Synth.SynthContext arg0, Java.Awt.Graphics arg1, Java.Lang.String arg2, int arg3, int arg4, int arg5)
        {
            IExecute("paintText", arg0, arg1, arg2, arg3, arg4, arg5);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/synth/SynthGraphicsUtils.html#paintText(javax.swing.plaf.synth.SynthContext,java.awt.Graphics,java.lang.String,java.awt.Rectangle,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Plaf.Synth.SynthContext"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Graphics"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="Java.Awt.Rectangle"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        public void PaintText(Javax.Swing.Plaf.Synth.SynthContext arg0, Java.Awt.Graphics arg1, Java.Lang.String arg2, Java.Awt.Rectangle arg3, int arg4)
        {
            IExecute("paintText", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/synth/SynthGraphicsUtils.html#paintText(javax.swing.plaf.synth.SynthContext,java.awt.Graphics,java.lang.String,javax.swing.Icon,int,int,int,int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Plaf.Synth.SynthContext"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Graphics"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="Javax.Swing.Icon"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <param name="arg6"><see cref="int"/></param>
        /// <param name="arg7"><see cref="int"/></param>
        /// <param name="arg8"><see cref="int"/></param>
        /// <param name="arg9"><see cref="int"/></param>
        /// <param name="arg10"><see cref="int"/></param>
        public void PaintText(Javax.Swing.Plaf.Synth.SynthContext arg0, Java.Awt.Graphics arg1, Java.Lang.String arg2, Javax.Swing.Icon arg3, int arg4, int arg5, int arg6, int arg7, int arg8, int arg9, int arg10)
        {
            IExecute("paintText", arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}