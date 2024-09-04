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
    #region RenderableImageProducer declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/RenderableImageProducer.html"/>
    /// </summary>
    public partial class RenderableImageProducer : MASES.JCOBridge.C2JBridge.JVMBridgeBase<RenderableImageProducer>
    {
        const string _bridgeClassName = "java.awt.image.renderable.RenderableImageProducer";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public RenderableImageProducer() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public RenderableImageProducer(params object[] args) : base(args) { }

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

    #region RenderableImageProducer implementation
    public partial class RenderableImageProducer
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/RenderableImageProducer.html#%3Cinit%3E(java.awt.image.renderable.RenderableImage,java.awt.image.renderable.RenderContext)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.Renderable.RenderableImage"/></param>
        /// <param name="arg1"><see cref="Java.Awt.ImageNs.Renderable.RenderContext"/></param>
        public RenderableImageProducer(Java.Awt.ImageNs.Renderable.RenderableImage arg0, Java.Awt.ImageNs.Renderable.RenderContext arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Awt.ImageNs.Renderable.RenderableImageProducer"/> to <see cref="Java.Awt.ImageNs.ImageProducer"/>
        /// </summary>
        public static implicit operator Java.Awt.ImageNs.ImageProducer(Java.Awt.ImageNs.Renderable.RenderableImageProducer t) => t.Cast<Java.Awt.ImageNs.ImageProducer>();
        /// <summary>
        /// Converter from <see cref="Java.Awt.ImageNs.Renderable.RenderableImageProducer"/> to <see cref="Java.Lang.Runnable"/>
        /// </summary>
        public static implicit operator Java.Lang.Runnable(Java.Awt.ImageNs.Renderable.RenderableImageProducer t) => t.Cast<Java.Lang.Runnable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/RenderableImageProducer.html#isConsumer(java.awt.image.ImageConsumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.ImageConsumer"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsConsumer(Java.Awt.ImageNs.ImageConsumer arg0)
        {
            return IExecuteWithSignature<bool>("isConsumer", "(Ljava/awt/image/ImageConsumer;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/RenderableImageProducer.html#addConsumer(java.awt.image.ImageConsumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.ImageConsumer"/></param>
        public void AddConsumer(Java.Awt.ImageNs.ImageConsumer arg0)
        {
            IExecuteWithSignature("addConsumer", "(Ljava/awt/image/ImageConsumer;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/RenderableImageProducer.html#removeConsumer(java.awt.image.ImageConsumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.ImageConsumer"/></param>
        public void RemoveConsumer(Java.Awt.ImageNs.ImageConsumer arg0)
        {
            IExecuteWithSignature("removeConsumer", "(Ljava/awt/image/ImageConsumer;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/RenderableImageProducer.html#setRenderContext(java.awt.image.renderable.RenderContext)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.Renderable.RenderContext"/></param>
        public void SetRenderContext(Java.Awt.ImageNs.Renderable.RenderContext arg0)
        {
            IExecuteWithSignature("setRenderContext", "(Ljava/awt/image/renderable/RenderContext;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/RenderableImageProducer.html#startProduction(java.awt.image.ImageConsumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.ImageConsumer"/></param>
        public void StartProduction(Java.Awt.ImageNs.ImageConsumer arg0)
        {
            IExecuteWithSignature("startProduction", "(Ljava/awt/image/ImageConsumer;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/RenderableImageProducer.html#requestTopDownLeftRightResend(java.awt.image.ImageConsumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.ImageConsumer"/></param>
        public void RequestTopDownLeftRightResend(Java.Awt.ImageNs.ImageConsumer arg0)
        {
            IExecuteWithSignature("requestTopDownLeftRightResend", "(Ljava/awt/image/ImageConsumer;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/renderable/RenderableImageProducer.html#run()"/>
        /// </summary>
        public void Run()
        {
            IExecuteWithSignature("run", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}