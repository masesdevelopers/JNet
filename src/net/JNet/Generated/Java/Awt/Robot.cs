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
*  This file is generated by MASES.JNetReflector (ver. 2.5.9.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Awt
{
    #region Robot declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Robot.html"/>
    /// </summary>
    public partial class Robot : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Robot>
    {
        const string _bridgeClassName = "java.awt.Robot";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public Robot() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public Robot(params object[] args) : base(args) { }

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

    #region Robot implementation
    public partial class Robot
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Robot.html#%3Cinit%3E(java.awt.GraphicsDevice)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.GraphicsDevice"/></param>
        /// <exception cref="Java.Awt.AWTException"/>
        public Robot(Java.Awt.GraphicsDevice arg0)
            : base(arg0)
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Robot.html#getAutoDelay()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Robot.html#setAutoDelay(int)"/>
        /// </summary>
        public int AutoDelay
        {
            get { return IExecuteWithSignature<int>("getAutoDelay", "()I"); } set { IExecuteWithSignature("setAutoDelay", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Robot.html#isAutoWaitForIdle()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsAutoWaitForIdle()
        {
            return IExecuteWithSignature<bool>("isAutoWaitForIdle", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Robot.html#getPixelColor(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.Color"/></returns>
        public Java.Awt.Color GetPixelColor(int arg0, int arg1)
        {
            return IExecuteWithSignature<Java.Awt.Color>("getPixelColor", "(II)Ljava/awt/Color;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Robot.html#createScreenCapture(java.awt.Rectangle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Rectangle"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.BufferedImage"/></returns>
        public Java.Awt.ImageNs.BufferedImage CreateScreenCapture(Java.Awt.Rectangle arg0)
        {
            return IExecuteWithSignature<Java.Awt.ImageNs.BufferedImage>("createScreenCapture", "(Ljava/awt/Rectangle;)Ljava/awt/image/BufferedImage;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Robot.html#createMultiResolutionScreenCapture(java.awt.Rectangle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Rectangle"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.MultiResolutionImage"/></returns>
        public Java.Awt.ImageNs.MultiResolutionImage CreateMultiResolutionScreenCapture(Java.Awt.Rectangle arg0)
        {
            return IExecuteWithSignature<Java.Awt.ImageNs.MultiResolutionImage>("createMultiResolutionScreenCapture", "(Ljava/awt/Rectangle;)Ljava/awt/image/MultiResolutionImage;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Robot.html#delay(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void Delay(int arg0)
        {
            IExecuteWithSignature("delay", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Robot.html#keyPress(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void KeyPress(int arg0)
        {
            IExecuteWithSignature("keyPress", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Robot.html#keyRelease(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void KeyRelease(int arg0)
        {
            IExecuteWithSignature("keyRelease", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Robot.html#mouseMove(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void MouseMove(int arg0, int arg1)
        {
            IExecuteWithSignature("mouseMove", "(II)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Robot.html#mousePress(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void MousePress(int arg0)
        {
            IExecuteWithSignature("mousePress", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Robot.html#mouseRelease(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void MouseRelease(int arg0)
        {
            IExecuteWithSignature("mouseRelease", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Robot.html#mouseWheel(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void MouseWheel(int arg0)
        {
            IExecuteWithSignature("mouseWheel", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Robot.html#setAutoWaitForIdle(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetAutoWaitForIdle(bool arg0)
        {
            IExecuteWithSignature("setAutoWaitForIdle", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Robot.html#waitForIdle()"/>
        /// </summary>
        public void WaitForIdle()
        {
            IExecuteWithSignature("waitForIdle", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}