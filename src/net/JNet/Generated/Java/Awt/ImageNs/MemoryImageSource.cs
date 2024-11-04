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
*  This file is generated by MASES.JNetReflector (ver. 2.5.10.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Awt.ImageNs
{
    #region MemoryImageSource declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/MemoryImageSource.html"/>
    /// </summary>
    public partial class MemoryImageSource : Java.Awt.ImageNs.ImageProducer
    {
        const string _bridgeClassName = "java.awt.image.MemoryImageSource";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public MemoryImageSource() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public MemoryImageSource(params object[] args) : base(args) { }

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

    #region MemoryImageSource implementation
    public partial class MemoryImageSource
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/MemoryImageSource.html#%3Cinit%3E(int,int,int[],int,int,java.util.Hashtable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="Java.Util.Hashtable"/></param>
        public MemoryImageSource(int arg0, int arg1, int[] arg2, int arg3, int arg4, Java.Util.Hashtable<object, object> arg5)
            : base(arg0, arg1, arg2, arg3, arg4, arg5)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/MemoryImageSource.html#%3Cinit%3E(int,int,int[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        public MemoryImageSource(int arg0, int arg1, int[] arg2, int arg3, int arg4)
            : base(arg0, arg1, arg2, arg3, arg4)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/MemoryImageSource.html#%3Cinit%3E(int,int,java.awt.image.ColorModel,byte[],int,int,java.util.Hashtable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Java.Awt.ImageNs.ColorModel"/></param>
        /// <param name="arg3"><see cref="byte"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <param name="arg6"><see cref="Java.Util.Hashtable"/></param>
        public MemoryImageSource(int arg0, int arg1, Java.Awt.ImageNs.ColorModel arg2, byte[] arg3, int arg4, int arg5, Java.Util.Hashtable<object, object> arg6)
            : base(arg0, arg1, arg2, arg3, arg4, arg5, arg6)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/MemoryImageSource.html#%3Cinit%3E(int,int,java.awt.image.ColorModel,byte[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Java.Awt.ImageNs.ColorModel"/></param>
        /// <param name="arg3"><see cref="byte"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        public MemoryImageSource(int arg0, int arg1, Java.Awt.ImageNs.ColorModel arg2, byte[] arg3, int arg4, int arg5)
            : base(arg0, arg1, arg2, arg3, arg4, arg5)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/MemoryImageSource.html#%3Cinit%3E(int,int,java.awt.image.ColorModel,int[],int,int,java.util.Hashtable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Java.Awt.ImageNs.ColorModel"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <param name="arg6"><see cref="Java.Util.Hashtable"/></param>
        public MemoryImageSource(int arg0, int arg1, Java.Awt.ImageNs.ColorModel arg2, int[] arg3, int arg4, int arg5, Java.Util.Hashtable<object, object> arg6)
            : base(arg0, arg1, arg2, arg3, arg4, arg5, arg6)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/MemoryImageSource.html#%3Cinit%3E(int,int,java.awt.image.ColorModel,int[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Java.Awt.ImageNs.ColorModel"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        public MemoryImageSource(int arg0, int arg1, Java.Awt.ImageNs.ColorModel arg2, int[] arg3, int arg4, int arg5)
            : base(arg0, arg1, arg2, arg3, arg4, arg5)
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/MemoryImageSource.html#isConsumer(java.awt.image.ImageConsumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.ImageConsumer"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsConsumer(Java.Awt.ImageNs.ImageConsumer arg0)
        {
            return IExecuteWithSignature<bool>("isConsumer", "(Ljava/awt/image/ImageConsumer;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/MemoryImageSource.html#addConsumer(java.awt.image.ImageConsumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.ImageConsumer"/></param>
        public void AddConsumer(Java.Awt.ImageNs.ImageConsumer arg0)
        {
            IExecuteWithSignature("addConsumer", "(Ljava/awt/image/ImageConsumer;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/MemoryImageSource.html#newPixels(byte[],java.awt.image.ColorModel,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="Java.Awt.ImageNs.ColorModel"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public void NewPixels(byte[] arg0, Java.Awt.ImageNs.ColorModel arg1, int arg2, int arg3)
        {
            IExecuteWithSignature("newPixels", "([BLjava/awt/image/ColorModel;II)V", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/MemoryImageSource.html#newPixels(int,int,int,int,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="bool"/></param>
        public void NewPixels(int arg0, int arg1, int arg2, int arg3, bool arg4)
        {
            IExecuteWithSignature("newPixels", "(IIIIZ)V", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/MemoryImageSource.html#newPixels(int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public void NewPixels(int arg0, int arg1, int arg2, int arg3)
        {
            IExecuteWithSignature("newPixels", "(IIII)V", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/MemoryImageSource.html#newPixels(int[],java.awt.image.ColorModel,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Awt.ImageNs.ColorModel"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public void NewPixels(int[] arg0, Java.Awt.ImageNs.ColorModel arg1, int arg2, int arg3)
        {
            IExecuteWithSignature("newPixels", "([ILjava/awt/image/ColorModel;II)V", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/MemoryImageSource.html#removeConsumer(java.awt.image.ImageConsumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.ImageConsumer"/></param>
        public void RemoveConsumer(Java.Awt.ImageNs.ImageConsumer arg0)
        {
            IExecuteWithSignature("removeConsumer", "(Ljava/awt/image/ImageConsumer;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/MemoryImageSource.html#setAnimated(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetAnimated(bool arg0)
        {
            IExecuteWithSignature("setAnimated", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/MemoryImageSource.html#setFullBufferUpdates(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetFullBufferUpdates(bool arg0)
        {
            IExecuteWithSignature("setFullBufferUpdates", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/MemoryImageSource.html#newPixels()"/>
        /// </summary>
        public void NewPixels()
        {
            IExecuteWithSignature("newPixels", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/MemoryImageSource.html#requestTopDownLeftRightResend(java.awt.image.ImageConsumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.ImageConsumer"/></param>
        public void RequestTopDownLeftRightResend(Java.Awt.ImageNs.ImageConsumer arg0)
        {
            IExecuteWithSignature("requestTopDownLeftRightResend", "(Ljava/awt/image/ImageConsumer;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/MemoryImageSource.html#startProduction(java.awt.image.ImageConsumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.ImageConsumer"/></param>
        public void StartProduction(Java.Awt.ImageNs.ImageConsumer arg0)
        {
            IExecuteWithSignature("startProduction", "(Ljava/awt/image/ImageConsumer;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}