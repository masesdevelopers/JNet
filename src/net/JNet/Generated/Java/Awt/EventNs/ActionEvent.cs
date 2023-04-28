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
        /// <param name="arg2"><see cref="string"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public ActionEvent(object arg0, int arg1, string arg2, int arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/ActionEvent.html#%3Cinit%3E(java.lang.Object,int,java.lang.String,long,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="string"/></param>
        /// <param name="arg3"><see cref="long"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        public ActionEvent(object arg0, int arg1, string arg2, long arg3, int arg4)
            : base(arg0, arg1, arg2, arg3, arg4)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/ActionEvent.html#%3Cinit%3E(java.lang.Object,int,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="string"/></param>
        public ActionEvent(object arg0, int arg1, string arg2)
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
        public static int ACTION_FIRST { get { return LocalClazz.GetField<int>("ACTION_FIRST"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/ActionEvent.html#ACTION_LAST"/>
        /// </summary>
        public static int ACTION_LAST { get { return LocalClazz.GetField<int>("ACTION_LAST"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/ActionEvent.html#ACTION_PERFORMED"/>
        /// </summary>
        public static int ACTION_PERFORMED { get { return LocalClazz.GetField<int>("ACTION_PERFORMED"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/ActionEvent.html#ALT_MASK"/>
        /// </summary>
        public static int ALT_MASK { get { return LocalClazz.GetField<int>("ALT_MASK"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/ActionEvent.html#CTRL_MASK"/>
        /// </summary>
        public static int CTRL_MASK { get { return LocalClazz.GetField<int>("CTRL_MASK"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/ActionEvent.html#META_MASK"/>
        /// </summary>
        public static int META_MASK { get { return LocalClazz.GetField<int>("META_MASK"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/ActionEvent.html#SHIFT_MASK"/>
        /// </summary>
        public static int SHIFT_MASK { get { return LocalClazz.GetField<int>("SHIFT_MASK"); } }

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/ActionEvent.html#getActionCommand()"/> 
        /// </summary>
        public string ActionCommand
        {
            get { return IExecute<string>("getActionCommand"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/ActionEvent.html#getModifiers()"/> 
        /// </summary>
        public int Modifiers
        {
            get { return IExecute<int>("getModifiers"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/ActionEvent.html#getWhen()"/> 
        /// </summary>
        public long When
        {
            get { return IExecute<long>("getWhen"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}