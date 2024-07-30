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
*  This file is generated by MASES.JNetReflector (ver. 2.5.7.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Awt.EventNs
{
    #region WindowEvent
    public partial class WindowEvent
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowEvent.html#%3Cinit%3E(java.awt.Window,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Window"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public WindowEvent(Java.Awt.Window arg0, int arg1, int arg2, int arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowEvent.html#%3Cinit%3E(java.awt.Window,int,java.awt.Window,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Window"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Java.Awt.Window"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        public WindowEvent(Java.Awt.Window arg0, int arg1, Java.Awt.Window arg2, int arg3, int arg4)
            : base(arg0, arg1, arg2, arg3, arg4)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowEvent.html#%3Cinit%3E(java.awt.Window,int,java.awt.Window)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Window"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Java.Awt.Window"/></param>
        public WindowEvent(Java.Awt.Window arg0, int arg1, Java.Awt.Window arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowEvent.html#%3Cinit%3E(java.awt.Window,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Window"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public WindowEvent(Java.Awt.Window arg0, int arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowEvent.html#WINDOW_ACTIVATED"/>
        /// </summary>
        public static int WINDOW_ACTIVATED { get { if (!_WINDOW_ACTIVATEDReady) { _WINDOW_ACTIVATEDContent = SGetField<int>(LocalBridgeClazz, "WINDOW_ACTIVATED"); _WINDOW_ACTIVATEDReady = true; } return _WINDOW_ACTIVATEDContent; } }
        private static int _WINDOW_ACTIVATEDContent = default;
        private static bool _WINDOW_ACTIVATEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowEvent.html#WINDOW_CLOSED"/>
        /// </summary>
        public static int WINDOW_CLOSED { get { if (!_WINDOW_CLOSEDReady) { _WINDOW_CLOSEDContent = SGetField<int>(LocalBridgeClazz, "WINDOW_CLOSED"); _WINDOW_CLOSEDReady = true; } return _WINDOW_CLOSEDContent; } }
        private static int _WINDOW_CLOSEDContent = default;
        private static bool _WINDOW_CLOSEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowEvent.html#WINDOW_CLOSING"/>
        /// </summary>
        public static int WINDOW_CLOSING { get { if (!_WINDOW_CLOSINGReady) { _WINDOW_CLOSINGContent = SGetField<int>(LocalBridgeClazz, "WINDOW_CLOSING"); _WINDOW_CLOSINGReady = true; } return _WINDOW_CLOSINGContent; } }
        private static int _WINDOW_CLOSINGContent = default;
        private static bool _WINDOW_CLOSINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowEvent.html#WINDOW_DEACTIVATED"/>
        /// </summary>
        public static int WINDOW_DEACTIVATED { get { if (!_WINDOW_DEACTIVATEDReady) { _WINDOW_DEACTIVATEDContent = SGetField<int>(LocalBridgeClazz, "WINDOW_DEACTIVATED"); _WINDOW_DEACTIVATEDReady = true; } return _WINDOW_DEACTIVATEDContent; } }
        private static int _WINDOW_DEACTIVATEDContent = default;
        private static bool _WINDOW_DEACTIVATEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowEvent.html#WINDOW_DEICONIFIED"/>
        /// </summary>
        public static int WINDOW_DEICONIFIED { get { if (!_WINDOW_DEICONIFIEDReady) { _WINDOW_DEICONIFIEDContent = SGetField<int>(LocalBridgeClazz, "WINDOW_DEICONIFIED"); _WINDOW_DEICONIFIEDReady = true; } return _WINDOW_DEICONIFIEDContent; } }
        private static int _WINDOW_DEICONIFIEDContent = default;
        private static bool _WINDOW_DEICONIFIEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowEvent.html#WINDOW_FIRST"/>
        /// </summary>
        public static int WINDOW_FIRST { get { if (!_WINDOW_FIRSTReady) { _WINDOW_FIRSTContent = SGetField<int>(LocalBridgeClazz, "WINDOW_FIRST"); _WINDOW_FIRSTReady = true; } return _WINDOW_FIRSTContent; } }
        private static int _WINDOW_FIRSTContent = default;
        private static bool _WINDOW_FIRSTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowEvent.html#WINDOW_GAINED_FOCUS"/>
        /// </summary>
        public static int WINDOW_GAINED_FOCUS { get { if (!_WINDOW_GAINED_FOCUSReady) { _WINDOW_GAINED_FOCUSContent = SGetField<int>(LocalBridgeClazz, "WINDOW_GAINED_FOCUS"); _WINDOW_GAINED_FOCUSReady = true; } return _WINDOW_GAINED_FOCUSContent; } }
        private static int _WINDOW_GAINED_FOCUSContent = default;
        private static bool _WINDOW_GAINED_FOCUSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowEvent.html#WINDOW_ICONIFIED"/>
        /// </summary>
        public static int WINDOW_ICONIFIED { get { if (!_WINDOW_ICONIFIEDReady) { _WINDOW_ICONIFIEDContent = SGetField<int>(LocalBridgeClazz, "WINDOW_ICONIFIED"); _WINDOW_ICONIFIEDReady = true; } return _WINDOW_ICONIFIEDContent; } }
        private static int _WINDOW_ICONIFIEDContent = default;
        private static bool _WINDOW_ICONIFIEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowEvent.html#WINDOW_LAST"/>
        /// </summary>
        public static int WINDOW_LAST { get { if (!_WINDOW_LASTReady) { _WINDOW_LASTContent = SGetField<int>(LocalBridgeClazz, "WINDOW_LAST"); _WINDOW_LASTReady = true; } return _WINDOW_LASTContent; } }
        private static int _WINDOW_LASTContent = default;
        private static bool _WINDOW_LASTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowEvent.html#WINDOW_LOST_FOCUS"/>
        /// </summary>
        public static int WINDOW_LOST_FOCUS { get { if (!_WINDOW_LOST_FOCUSReady) { _WINDOW_LOST_FOCUSContent = SGetField<int>(LocalBridgeClazz, "WINDOW_LOST_FOCUS"); _WINDOW_LOST_FOCUSReady = true; } return _WINDOW_LOST_FOCUSContent; } }
        private static int _WINDOW_LOST_FOCUSContent = default;
        private static bool _WINDOW_LOST_FOCUSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowEvent.html#WINDOW_OPENED"/>
        /// </summary>
        public static int WINDOW_OPENED { get { if (!_WINDOW_OPENEDReady) { _WINDOW_OPENEDContent = SGetField<int>(LocalBridgeClazz, "WINDOW_OPENED"); _WINDOW_OPENEDReady = true; } return _WINDOW_OPENEDContent; } }
        private static int _WINDOW_OPENEDContent = default;
        private static bool _WINDOW_OPENEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowEvent.html#WINDOW_STATE_CHANGED"/>
        /// </summary>
        public static int WINDOW_STATE_CHANGED { get { if (!_WINDOW_STATE_CHANGEDReady) { _WINDOW_STATE_CHANGEDContent = SGetField<int>(LocalBridgeClazz, "WINDOW_STATE_CHANGED"); _WINDOW_STATE_CHANGEDReady = true; } return _WINDOW_STATE_CHANGEDContent; } }
        private static int _WINDOW_STATE_CHANGEDContent = default;
        private static bool _WINDOW_STATE_CHANGEDReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowEvent.html#getNewState()"/> 
        /// </summary>
        public int NewState
        {
            get { return IExecuteWithSignature<int>("getNewState", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowEvent.html#getOldState()"/> 
        /// </summary>
        public int OldState
        {
            get { return IExecuteWithSignature<int>("getOldState", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowEvent.html#getOppositeWindow()"/> 
        /// </summary>
        public Java.Awt.Window OppositeWindow
        {
            get { return IExecuteWithSignature<Java.Awt.Window>("getOppositeWindow", "()Ljava/awt/Window;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowEvent.html#getWindow()"/> 
        /// </summary>
        public Java.Awt.Window Window
        {
            get { return IExecuteWithSignature<Java.Awt.Window>("getWindow", "()Ljava/awt/Window;"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}