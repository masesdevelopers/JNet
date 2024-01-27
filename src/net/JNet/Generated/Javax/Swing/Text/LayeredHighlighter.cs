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
*  This file is generated by MASES.JNetReflector (ver. 2.2.4.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Swing.Text
{
    #region LayeredHighlighter
    public partial class LayeredHighlighter
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/LayeredHighlighter.html#paintLayeredHighlights(java.awt.Graphics,int,int,java.awt.Shape,javax.swing.text.JTextComponent,javax.swing.text.View)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Graphics"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="Java.Awt.Shape"/></param>
        /// <param name="arg4"><see cref="Javax.Swing.Text.JTextComponent"/></param>
        /// <param name="arg5"><see cref="Javax.Swing.Text.View"/></param>
        public void PaintLayeredHighlights(Java.Awt.Graphics arg0, int arg1, int arg2, Java.Awt.Shape arg3, Javax.Swing.Text.JTextComponent arg4, Javax.Swing.Text.View arg5)
        {
            IExecute("paintLayeredHighlights", arg0, arg1, arg2, arg3, arg4, arg5);
        }

        #endregion

        #region Nested classes
        #region LayerPainter
        public partial class LayerPainter
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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/LayeredHighlighter.LayerPainter.html#paintLayer(java.awt.Graphics,int,int,java.awt.Shape,javax.swing.text.JTextComponent,javax.swing.text.View)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Awt.Graphics"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <param name="arg2"><see cref="int"/></param>
            /// <param name="arg3"><see cref="Java.Awt.Shape"/></param>
            /// <param name="arg4"><see cref="Javax.Swing.Text.JTextComponent"/></param>
            /// <param name="arg5"><see cref="Javax.Swing.Text.View"/></param>
            /// <returns><see cref="Java.Awt.Shape"/></returns>
            public Java.Awt.Shape PaintLayer(Java.Awt.Graphics arg0, int arg1, int arg2, Java.Awt.Shape arg3, Javax.Swing.Text.JTextComponent arg4, Javax.Swing.Text.View arg5)
            {
                return IExecute<Java.Awt.Shape>("paintLayer", arg0, arg1, arg2, arg3, arg4, arg5);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

    
        #endregion

        // TODO: complete the class
    }
    #endregion
}