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
*  This file is generated by MASES.JNetReflector (ver. 2.5.8.0)
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

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/RenderableImageOp.html#getHeight()"/> 
        /// </summary>
        public float Height
        {
            get { return IExecuteWithSignature<float>("getHeight", "()F"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/RenderableImageOp.html#getMinX()"/> 
        /// </summary>
        public float MinX
        {
            get { return IExecuteWithSignature<float>("getMinX", "()F"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/RenderableImageOp.html#getMinY()"/> 
        /// </summary>
        public float MinY
        {
            get { return IExecuteWithSignature<float>("getMinY", "()F"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/RenderableImageOp.html#getParameterBlock()"/> 
        /// </summary>
        public Java.Awt.ImageNs.Renderable.ParameterBlock ParameterBlock
        {
            get { return IExecuteWithSignature<Java.Awt.ImageNs.Renderable.ParameterBlock>("getParameterBlock", "()Ljava/awt/image/renderable/ParameterBlock;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/RenderableImageOp.html#getPropertyNames()"/> 
        /// </summary>
        public Java.Lang.String[] PropertyNames
        {
            get { return IExecuteWithSignatureArray<Java.Lang.String>("getPropertyNames", "()[Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/RenderableImageOp.html#getSources()"/> 
        /// </summary>
        public Java.Util.Vector<Java.Awt.ImageNs.Renderable.RenderableImage> Sources
        {
            get { return IExecuteWithSignature<Java.Util.Vector<Java.Awt.ImageNs.Renderable.RenderableImage>>("getSources", "()Ljava/util/Vector;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/RenderableImageOp.html#getWidth()"/> 
        /// </summary>
        public float Width
        {
            get { return IExecuteWithSignature<float>("getWidth", "()F"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/RenderableImageOp.html#isDynamic()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsDynamic()
        {
            return IExecuteWithSignature<bool>("isDynamic", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/RenderableImageOp.html#setParameterBlock(java.awt.image.renderable.ParameterBlock)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.Renderable.ParameterBlock"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.Renderable.ParameterBlock"/></returns>
        public Java.Awt.ImageNs.Renderable.ParameterBlock SetParameterBlock(Java.Awt.ImageNs.Renderable.ParameterBlock arg0)
        {
            return IExecuteWithSignature<Java.Awt.ImageNs.Renderable.ParameterBlock>("setParameterBlock", "(Ljava/awt/image/renderable/ParameterBlock;)Ljava/awt/image/renderable/ParameterBlock;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/RenderableImageOp.html#createDefaultRendering()"/>
        /// </summary>
        /// <returns><see cref="Java.Awt.ImageNs.RenderedImage"/></returns>
        public Java.Awt.ImageNs.RenderedImage CreateDefaultRendering()
        {
            return IExecuteWithSignature<Java.Awt.ImageNs.RenderedImage>("createDefaultRendering", "()Ljava/awt/image/RenderedImage;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/RenderableImageOp.html#createRendering(java.awt.image.renderable.RenderContext)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.Renderable.RenderContext"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.RenderedImage"/></returns>
        public Java.Awt.ImageNs.RenderedImage CreateRendering(Java.Awt.ImageNs.Renderable.RenderContext arg0)
        {
            return IExecuteWithSignature<Java.Awt.ImageNs.RenderedImage>("createRendering", "(Ljava/awt/image/renderable/RenderContext;)Ljava/awt/image/RenderedImage;", arg0);
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