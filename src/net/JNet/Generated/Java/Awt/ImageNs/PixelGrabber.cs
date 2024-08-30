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

namespace Java.Awt.ImageNs
{
    #region PixelGrabber declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/PixelGrabber.html"/>
    /// </summary>
    public partial class PixelGrabber : Java.Awt.ImageNs.ImageConsumer
    {
        const string _bridgeClassName = "java.awt.image.PixelGrabber";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public PixelGrabber() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public PixelGrabber(params object[] args) : base(args) { }

        private static readonly IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new InvalidOperationException($"Class {_bridgeClassName} was not found.");

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

    #region PixelGrabber implementation
    public partial class PixelGrabber
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/PixelGrabber.html#%3Cinit%3E(java.awt.Image,int,int,int,int,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Image"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="bool"/></param>
        public PixelGrabber(Java.Awt.Image arg0, int arg1, int arg2, int arg3, int arg4, bool arg5)
            : base(arg0, arg1, arg2, arg3, arg4, arg5)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/PixelGrabber.html#%3Cinit%3E(java.awt.Image,int,int,int,int,int[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Image"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <param name="arg6"><see cref="int"/></param>
        /// <param name="arg7"><see cref="int"/></param>
        public PixelGrabber(Java.Awt.Image arg0, int arg1, int arg2, int arg3, int arg4, int[] arg5, int arg6, int arg7)
            : base(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/PixelGrabber.html#%3Cinit%3E(java.awt.image.ImageProducer,int,int,int,int,int[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.ImageProducer"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <param name="arg6"><see cref="int"/></param>
        /// <param name="arg7"><see cref="int"/></param>
        public PixelGrabber(Java.Awt.ImageNs.ImageProducer arg0, int arg1, int arg2, int arg3, int arg4, int[] arg5, int arg6, int arg7)
            : base(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7)
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/PixelGrabber.html#getColorModel()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/PixelGrabber.html#setColorModel(java.awt.image.ColorModel)"/>
        /// </summary>
        public Java.Awt.ImageNs.ColorModel ColorModel
        {
            get { return IExecuteWithSignature<Java.Awt.ImageNs.ColorModel>("getColorModel", "()Ljava/awt/image/ColorModel;"); } set { IExecuteWithSignature("setColorModel", "(Ljava/awt/image/ColorModel;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/PixelGrabber.html#getHeight()"/> 
        /// </summary>
        public int Height
        {
            get { return IExecuteWithSignature<int>("getHeight", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/PixelGrabber.html#getPixels()"/> 
        /// </summary>
        public object Pixels
        {
            get { return IExecuteWithSignature("getPixels", "()Ljava/lang/Object;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/PixelGrabber.html#getWidth()"/> 
        /// </summary>
        public int Width
        {
            get { return IExecuteWithSignature<int>("getWidth", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/PixelGrabber.html#grabPixels()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Lang.InterruptedException"/>
        public bool GrabPixels()
        {
            return IExecuteWithSignature<bool>("grabPixels", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/PixelGrabber.html#grabPixels(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Lang.InterruptedException"/>
        public bool GrabPixels(long arg0)
        {
            return IExecuteWithSignature<bool>("grabPixels", "(J)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/PixelGrabber.html#getStatus()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int GetStatus()
        {
            return IExecuteWithSignature<int>("getStatus", "()I");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/PixelGrabber.html#status()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int Status()
        {
            return IExecuteWithSignature<int>("status", "()I");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/PixelGrabber.html#abortGrabbing()"/>
        /// </summary>
        public void AbortGrabbing()
        {
            IExecuteWithSignature("abortGrabbing", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/PixelGrabber.html#imageComplete(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void ImageComplete(int arg0)
        {
            IExecuteWithSignature("imageComplete", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/PixelGrabber.html#startGrabbing()"/>
        /// </summary>
        public void StartGrabbing()
        {
            IExecuteWithSignature("startGrabbing", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/PixelGrabber.html#setDimensions(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void SetDimensions(int arg0, int arg1)
        {
            IExecute("setDimensions", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/PixelGrabber.html#setHints(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetHints(int arg0)
        {
            IExecuteWithSignature("setHints", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/PixelGrabber.html#setPixels(int,int,int,int,java.awt.image.ColorModel,byte[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="Java.Awt.ImageNs.ColorModel"/></param>
        /// <param name="arg5"><see cref="byte"/></param>
        /// <param name="arg6"><see cref="int"/></param>
        /// <param name="arg7"><see cref="int"/></param>
        public void SetPixels(int arg0, int arg1, int arg2, int arg3, Java.Awt.ImageNs.ColorModel arg4, byte[] arg5, int arg6, int arg7)
        {
            IExecute("setPixels", arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/PixelGrabber.html#setPixels(int,int,int,int,java.awt.image.ColorModel,int[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="Java.Awt.ImageNs.ColorModel"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <param name="arg6"><see cref="int"/></param>
        /// <param name="arg7"><see cref="int"/></param>
        public void SetPixels(int arg0, int arg1, int arg2, int arg3, Java.Awt.ImageNs.ColorModel arg4, int[] arg5, int arg6, int arg7)
        {
            IExecute("setPixels", arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/PixelGrabber.html#setProperties(java.util.Hashtable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Hashtable"/></param>
        public void SetProperties(Java.Util.Hashtable<object, object> arg0)
        {
            IExecuteWithSignature("setProperties", "(Ljava/util/Hashtable;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}