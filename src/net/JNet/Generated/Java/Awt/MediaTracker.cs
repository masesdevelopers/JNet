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

namespace Java.Awt
{
    #region MediaTracker declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/MediaTracker.html"/>
    /// </summary>
    public partial class MediaTracker : Java.Io.Serializable
    {
        const string _bridgeClassName = "java.awt.MediaTracker";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public MediaTracker() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public MediaTracker(params object[] args) : base(args) { }

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

    #region MediaTracker implementation
    public partial class MediaTracker
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/MediaTracker.html#%3Cinit%3E(java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        public MediaTracker(Java.Awt.Component arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/MediaTracker.html#ABORTED"/>
        /// </summary>
        public static int ABORTED { get { if (!_ABORTEDReady) { _ABORTEDContent = SGetField<int>(LocalBridgeClazz, "ABORTED"); _ABORTEDReady = true; } return _ABORTEDContent; } }
        private static int _ABORTEDContent = default;
        private static bool _ABORTEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/MediaTracker.html#COMPLETE"/>
        /// </summary>
        public static int COMPLETE { get { if (!_COMPLETEReady) { _COMPLETEContent = SGetField<int>(LocalBridgeClazz, "COMPLETE"); _COMPLETEReady = true; } return _COMPLETEContent; } }
        private static int _COMPLETEContent = default;
        private static bool _COMPLETEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/MediaTracker.html#ERRORED"/>
        /// </summary>
        public static int ERRORED { get { if (!_ERROREDReady) { _ERROREDContent = SGetField<int>(LocalBridgeClazz, "ERRORED"); _ERROREDReady = true; } return _ERROREDContent; } }
        private static int _ERROREDContent = default;
        private static bool _ERROREDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/MediaTracker.html#LOADING"/>
        /// </summary>
        public static int LOADING { get { if (!_LOADINGReady) { _LOADINGContent = SGetField<int>(LocalBridgeClazz, "LOADING"); _LOADINGReady = true; } return _LOADINGContent; } }
        private static int _LOADINGContent = default;
        private static bool _LOADINGReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/MediaTracker.html#getErrorsAny()"/> 
        /// </summary>
        public object[] ErrorsAny
        {
            get { return IExecuteWithSignatureArray<object>("getErrorsAny", "()[Ljava/lang/Object;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/MediaTracker.html#checkAll()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool CheckAll()
        {
            return IExecuteWithSignature<bool>("checkAll", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/MediaTracker.html#checkAll(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool CheckAll(bool arg0)
        {
            return IExecuteWithSignature<bool>("checkAll", "(Z)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/MediaTracker.html#checkID(int,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool CheckID(int arg0, bool arg1)
        {
            return IExecute<bool>("checkID", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/MediaTracker.html#checkID(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool CheckID(int arg0)
        {
            return IExecuteWithSignature<bool>("checkID", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/MediaTracker.html#statusAll(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <returns><see cref="int"/></returns>
        public int StatusAll(bool arg0)
        {
            return IExecuteWithSignature<int>("statusAll", "(Z)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/MediaTracker.html#statusID(int,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <returns><see cref="int"/></returns>
        public int StatusID(int arg0, bool arg1)
        {
            return IExecute<int>("statusID", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/MediaTracker.html#isErrorAny()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsErrorAny()
        {
            return IExecuteWithSignature<bool>("isErrorAny", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/MediaTracker.html#isErrorID(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsErrorID(int arg0)
        {
            return IExecuteWithSignature<bool>("isErrorID", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/MediaTracker.html#waitForAll(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Lang.InterruptedException"/>
        public bool WaitForAll(long arg0)
        {
            return IExecuteWithSignature<bool>("waitForAll", "(J)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/MediaTracker.html#waitForID(int,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Lang.InterruptedException"/>
        public bool WaitForID(int arg0, long arg1)
        {
            return IExecute<bool>("waitForID", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/MediaTracker.html#getErrorsID(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="object"/></returns>
        public object[] GetErrorsID(int arg0)
        {
            return IExecuteWithSignatureArray<object>("getErrorsID", "(I)[Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/MediaTracker.html#addImage(java.awt.Image,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Image"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public void AddImage(Java.Awt.Image arg0, int arg1, int arg2, int arg3)
        {
            IExecute("addImage", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/MediaTracker.html#removeImage(java.awt.Image,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Image"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public void RemoveImage(Java.Awt.Image arg0, int arg1, int arg2, int arg3)
        {
            IExecute("removeImage", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/MediaTracker.html#removeImage(java.awt.Image,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Image"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void RemoveImage(Java.Awt.Image arg0, int arg1)
        {
            IExecute("removeImage", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/MediaTracker.html#removeImage(java.awt.Image)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Image"/></param>
        public void RemoveImage(Java.Awt.Image arg0)
        {
            IExecuteWithSignature("removeImage", "(Ljava/awt/Image;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/MediaTracker.html#addImage(java.awt.Image,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Image"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void AddImage(Java.Awt.Image arg0, int arg1)
        {
            IExecute("addImage", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/MediaTracker.html#waitForAll()"/>
        /// </summary>
        /// <exception cref="Java.Lang.InterruptedException"/>
        public void WaitForAll()
        {
            IExecuteWithSignature("waitForAll", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/MediaTracker.html#waitForID(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <exception cref="Java.Lang.InterruptedException"/>
        public void WaitForID(int arg0)
        {
            IExecuteWithSignature("waitForID", "(I)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}