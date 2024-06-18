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
*  This file is generated by MASES.JNetReflector (ver. 2.5.3.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Awt.EventNs
{
    #region ActionEvent
    public partial class ActionEvent
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/ActionEvent.html#%3Cinit%3E(java.lang.Object,int,java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public ActionEvent(object arg0, int arg1, Java.Lang.String arg2, int arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/ActionEvent.html#%3Cinit%3E(java.lang.Object,int,java.lang.String,long,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="long"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        public ActionEvent(object arg0, int arg1, Java.Lang.String arg2, long arg3, int arg4)
            : base(arg0, arg1, arg2, arg3, arg4)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/ActionEvent.html#%3Cinit%3E(java.lang.Object,int,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        public ActionEvent(object arg0, int arg1, Java.Lang.String arg2)
            : base(arg0, arg1, arg2)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/ActionEvent.html#ACTION_FIRST"/>
        /// </summary>
        public static int ACTION_FIRST { get { if (!_ACTION_FIRSTReady) { _ACTION_FIRSTContent = SGetField<int>(LocalBridgeClazz, "ACTION_FIRST"); _ACTION_FIRSTReady = true; } return _ACTION_FIRSTContent; } }
        private static int _ACTION_FIRSTContent = default;
        private static bool _ACTION_FIRSTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/ActionEvent.html#ACTION_LAST"/>
        /// </summary>
        public static int ACTION_LAST { get { if (!_ACTION_LASTReady) { _ACTION_LASTContent = SGetField<int>(LocalBridgeClazz, "ACTION_LAST"); _ACTION_LASTReady = true; } return _ACTION_LASTContent; } }
        private static int _ACTION_LASTContent = default;
        private static bool _ACTION_LASTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/ActionEvent.html#ACTION_PERFORMED"/>
        /// </summary>
        public static int ACTION_PERFORMED { get { if (!_ACTION_PERFORMEDReady) { _ACTION_PERFORMEDContent = SGetField<int>(LocalBridgeClazz, "ACTION_PERFORMED"); _ACTION_PERFORMEDReady = true; } return _ACTION_PERFORMEDContent; } }
        private static int _ACTION_PERFORMEDContent = default;
        private static bool _ACTION_PERFORMEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/ActionEvent.html#ALT_MASK"/>
        /// </summary>
        public static int ALT_MASK { get { if (!_ALT_MASKReady) { _ALT_MASKContent = SGetField<int>(LocalBridgeClazz, "ALT_MASK"); _ALT_MASKReady = true; } return _ALT_MASKContent; } }
        private static int _ALT_MASKContent = default;
        private static bool _ALT_MASKReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/ActionEvent.html#CTRL_MASK"/>
        /// </summary>
        public static int CTRL_MASK { get { if (!_CTRL_MASKReady) { _CTRL_MASKContent = SGetField<int>(LocalBridgeClazz, "CTRL_MASK"); _CTRL_MASKReady = true; } return _CTRL_MASKContent; } }
        private static int _CTRL_MASKContent = default;
        private static bool _CTRL_MASKReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/ActionEvent.html#META_MASK"/>
        /// </summary>
        public static int META_MASK { get { if (!_META_MASKReady) { _META_MASKContent = SGetField<int>(LocalBridgeClazz, "META_MASK"); _META_MASKReady = true; } return _META_MASKContent; } }
        private static int _META_MASKContent = default;
        private static bool _META_MASKReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/ActionEvent.html#SHIFT_MASK"/>
        /// </summary>
        public static int SHIFT_MASK { get { if (!_SHIFT_MASKReady) { _SHIFT_MASKContent = SGetField<int>(LocalBridgeClazz, "SHIFT_MASK"); _SHIFT_MASKReady = true; } return _SHIFT_MASKContent; } }
        private static int _SHIFT_MASKContent = default;
        private static bool _SHIFT_MASKReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/ActionEvent.html#getActionCommand()"/> 
        /// </summary>
        public Java.Lang.String ActionCommand
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getActionCommand", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/ActionEvent.html#getModifiers()"/> 
        /// </summary>
        public int Modifiers
        {
            get { return IExecuteWithSignature<int>("getModifiers", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/ActionEvent.html#getWhen()"/> 
        /// </summary>
        public long When
        {
            get { return IExecuteWithSignature<long>("getWhen", "()J"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}