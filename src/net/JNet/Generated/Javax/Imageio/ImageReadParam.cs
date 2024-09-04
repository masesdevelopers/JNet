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

namespace Javax.Imageio
{
    #region ImageReadParam declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageReadParam.html"/>
    /// </summary>
    public partial class ImageReadParam : Javax.Imageio.IIOParam
    {
        const string _bridgeClassName = "javax.imageio.ImageReadParam";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public ImageReadParam() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public ImageReadParam(params object[] args) : base(args) { }

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

    #region ImageReadParam implementation
    public partial class ImageReadParam
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageReadParam.html#getDestination()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageReadParam.html#setDestination(java.awt.image.BufferedImage)"/>
        /// </summary>
        public Java.Awt.ImageNs.BufferedImage Destination
        {
            get { return IExecuteWithSignature<Java.Awt.ImageNs.BufferedImage>("getDestination", "()Ljava/awt/image/BufferedImage;"); } set { IExecuteWithSignature("setDestination", "(Ljava/awt/image/BufferedImage;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageReadParam.html#getDestinationBands()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageReadParam.html#setDestinationBands(int[])"/>
        /// </summary>
        public int[] DestinationBands
        {
            get { return IExecuteWithSignatureArray<int>("getDestinationBands", "()[I"); } set { IExecuteWithSignature("setDestinationBands", "([I)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageReadParam.html#getSourceMaxProgressivePass()"/> 
        /// </summary>
        public int SourceMaxProgressivePass
        {
            get { return IExecuteWithSignature<int>("getSourceMaxProgressivePass", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageReadParam.html#getSourceMinProgressivePass()"/> 
        /// </summary>
        public int SourceMinProgressivePass
        {
            get { return IExecuteWithSignature<int>("getSourceMinProgressivePass", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageReadParam.html#getSourceNumProgressivePasses()"/> 
        /// </summary>
        public int SourceNumProgressivePasses
        {
            get { return IExecuteWithSignature<int>("getSourceNumProgressivePasses", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageReadParam.html#getSourceRenderSize()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageReadParam.html#setSourceRenderSize(java.awt.Dimension)"/>
        /// </summary>
        public Java.Awt.Dimension SourceRenderSize
        {
            get { return IExecuteWithSignature<Java.Awt.Dimension>("getSourceRenderSize", "()Ljava/awt/Dimension;"); } set { IExecuteWithSignature("setSourceRenderSize", "(Ljava/awt/Dimension;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageReadParam.html#canSetSourceRenderSize()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool CanSetSourceRenderSize()
        {
            return IExecuteWithSignature<bool>("canSetSourceRenderSize", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageReadParam.html#setSourceProgressivePasses(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void SetSourceProgressivePasses(int arg0, int arg1)
        {
            IExecute("setSourceProgressivePasses", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}