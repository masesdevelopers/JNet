/*
*  Copyright 2023 MASES s.r.l.
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
*  This file is generated by MASES.JNetReflector (ver. 1.5.4.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Awt.ImageNs.Renderable
{
    #region RenderableImageOp
    public partial class RenderableImageOp
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/RenderableImageOp.html#%3Cinit%3E(java.awt.image.renderable.ContextualRenderedImageFactory,java.awt.image.renderable.ParameterBlock)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.Renderable.ContextualRenderedImageFactory"/></param>
        /// <param name="arg1"><see cref="Java.Awt.ImageNs.Renderable.ParameterBlock"/></param>
        public RenderableImageOp(Java.Awt.ImageNs.Renderable.ContextualRenderedImageFactory arg0, Java.Awt.ImageNs.Renderable.ParameterBlock arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Awt.ImageNs.Renderable.RenderableImageOp"/> to <see cref="Java.Awt.ImageNs.Renderable.RenderableImage"/>
        /// </summary>
        public static implicit operator Java.Awt.ImageNs.Renderable.RenderableImage(Java.Awt.ImageNs.Renderable.RenderableImageOp t) => t.Cast<Java.Awt.ImageNs.Renderable.RenderableImage>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/RenderableImageOp.html#createDefaultRendering()"/> 
        /// </summary>
        public Java.Awt.ImageNs.RenderedImage CreateDefaultRendering
        {
            get { return IExecute<Java.Awt.ImageNs.RenderedImage>("createDefaultRendering"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/RenderableImageOp.html#getHeight()"/> 
        /// </summary>
        public float Height
        {
            get { return IExecute<float>("getHeight"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/RenderableImageOp.html#isDynamic()"/> 
        /// </summary>
        public bool IsDynamic
        {
            get { return IExecute<bool>("isDynamic"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/RenderableImageOp.html#getMinX()"/> 
        /// </summary>
        public float MinX
        {
            get { return IExecute<float>("getMinX"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/RenderableImageOp.html#getMinY()"/> 
        /// </summary>
        public float MinY
        {
            get { return IExecute<float>("getMinY"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/RenderableImageOp.html#getParameterBlock()"/> 
        /// </summary>
        public Java.Awt.ImageNs.Renderable.ParameterBlock ParameterBlock
        {
            get { return IExecute<Java.Awt.ImageNs.Renderable.ParameterBlock>("getParameterBlock"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/RenderableImageOp.html#getPropertyNames()"/> 
        /// </summary>
        public string[] PropertyNames
        {
            get { return IExecuteArray<string>("getPropertyNames"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/RenderableImageOp.html#getSources()"/> 
        /// </summary>
        public Java.Util.Vector<Java.Awt.ImageNs.Renderable.RenderableImage> Sources
        {
            get { return IExecute<Java.Util.Vector<Java.Awt.ImageNs.Renderable.RenderableImage>>("getSources"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/RenderableImageOp.html#getWidth()"/> 
        /// </summary>
        public float Width
        {
            get { return IExecute<float>("getWidth"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/RenderableImageOp.html#setParameterBlock(java.awt.image.renderable.ParameterBlock)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.Renderable.ParameterBlock"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.Renderable.ParameterBlock"/></returns>
        public Java.Awt.ImageNs.Renderable.ParameterBlock SetParameterBlock(Java.Awt.ImageNs.Renderable.ParameterBlock arg0)
        {
            return IExecute<Java.Awt.ImageNs.Renderable.ParameterBlock>("setParameterBlock", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/RenderableImageOp.html#createRendering(java.awt.image.renderable.RenderContext)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.Renderable.RenderContext"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.RenderedImage"/></returns>
        public Java.Awt.ImageNs.RenderedImage CreateRendering(Java.Awt.ImageNs.Renderable.RenderContext arg0)
        {
            return IExecute<Java.Awt.ImageNs.RenderedImage>("createRendering", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/RenderableImageOp.html#createScaledRendering(int,int,java.awt.RenderingHints)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Java.Awt.RenderingHints"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.RenderedImage"/></returns>
        public Java.Awt.ImageNs.RenderedImage CreateScaledRendering(int arg0, int arg1, Java.Awt.RenderingHints arg2)
        {
            return IExecute<Java.Awt.ImageNs.RenderedImage>("createScaledRendering", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/RenderableImageOp.html#getProperty(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="object"/></returns>
        public object GetProperty(string arg0)
        {
            return IExecute("getProperty", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}