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

namespace Javax.Security.Auth.Callback
{
    #region ConfirmationCallback
    public partial class ConfirmationCallback
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/callback/ConfirmationCallback.html#%3Cinit%3E(int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public ConfirmationCallback(int arg0, int arg1, int arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/callback/ConfirmationCallback.html#%3Cinit%3E(int,java.lang.String[],int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public ConfirmationCallback(int arg0, string[] arg1, int arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/callback/ConfirmationCallback.html#%3Cinit%3E(java.lang.String,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public ConfirmationCallback(string arg0, int arg1, int arg2, int arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/callback/ConfirmationCallback.html#%3Cinit%3E(java.lang.String,int,java.lang.String[],int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="string"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public ConfirmationCallback(string arg0, int arg1, string[] arg2, int arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        
        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Security.Auth.Callback.ConfirmationCallback"/> to <see cref="Javax.Security.Auth.Callback.Callback"/>
        /// </summary>
        public static implicit operator Javax.Security.Auth.Callback.Callback(Javax.Security.Auth.Callback.ConfirmationCallback t) => t.Cast<Javax.Security.Auth.Callback.Callback>();
        /// <summary>
        /// Converter from <see cref="Javax.Security.Auth.Callback.ConfirmationCallback"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Javax.Security.Auth.Callback.ConfirmationCallback t) => t.Cast<Java.Io.Serializable>();
        
        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/callback/ConfirmationCallback.html#CANCEL"/>
        /// </summary>
        public static int CANCEL { get { return LocalClazz.GetField<int>("CANCEL"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/callback/ConfirmationCallback.html#ERROR"/>
        /// </summary>
        public static int ERROR { get { return LocalClazz.GetField<int>("ERROR"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/callback/ConfirmationCallback.html#INFORMATION"/>
        /// </summary>
        public static int INFORMATION { get { return LocalClazz.GetField<int>("INFORMATION"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/callback/ConfirmationCallback.html#NO"/>
        /// </summary>
        public static int NO { get { return LocalClazz.GetField<int>("NO"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/callback/ConfirmationCallback.html#OK"/>
        /// </summary>
        public static int OK { get { return LocalClazz.GetField<int>("OK"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/callback/ConfirmationCallback.html#OK_CANCEL_OPTION"/>
        /// </summary>
        public static int OK_CANCEL_OPTION { get { return LocalClazz.GetField<int>("OK_CANCEL_OPTION"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/callback/ConfirmationCallback.html#UNSPECIFIED_OPTION"/>
        /// </summary>
        public static int UNSPECIFIED_OPTION { get { return LocalClazz.GetField<int>("UNSPECIFIED_OPTION"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/callback/ConfirmationCallback.html#WARNING"/>
        /// </summary>
        public static int WARNING { get { return LocalClazz.GetField<int>("WARNING"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/callback/ConfirmationCallback.html#YES"/>
        /// </summary>
        public static int YES { get { return LocalClazz.GetField<int>("YES"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/callback/ConfirmationCallback.html#YES_NO_CANCEL_OPTION"/>
        /// </summary>
        public static int YES_NO_CANCEL_OPTION { get { return LocalClazz.GetField<int>("YES_NO_CANCEL_OPTION"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/callback/ConfirmationCallback.html#YES_NO_OPTION"/>
        /// </summary>
        public static int YES_NO_OPTION { get { return LocalClazz.GetField<int>("YES_NO_OPTION"); } }
        
        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/callback/ConfirmationCallback.html#getDefaultOption()"/> 
        /// </summary>
        public int DefaultOption
        {
            get { return IExecute<int>("getDefaultOption"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/callback/ConfirmationCallback.html#getMessageType()"/> 
        /// </summary>
        public int MessageType
        {
            get { return IExecute<int>("getMessageType"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/callback/ConfirmationCallback.html#getOptions()"/> 
        /// </summary>
        public string[] Options
        {
            get { return IExecuteArray<string>("getOptions"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/callback/ConfirmationCallback.html#getOptionType()"/> 
        /// </summary>
        public int OptionType
        {
            get { return IExecute<int>("getOptionType"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/callback/ConfirmationCallback.html#getPrompt()"/> 
        /// </summary>
        public string Prompt
        {
            get { return IExecute<string>("getPrompt"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/callback/ConfirmationCallback.html#getSelectedIndex()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/security/auth/callback/ConfirmationCallback.html#setSelectedIndex(int)"/>
        /// </summary>
        public int SelectedIndex
        {
            get { return IExecute<int>("getSelectedIndex"); } set { IExecute("setSelectedIndex", value); }
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}