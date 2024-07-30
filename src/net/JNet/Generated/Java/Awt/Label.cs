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
    #region Label
    public partial class Label
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Label.html#%3Cinit%3E(java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <exception cref="Java.Awt.HeadlessException"/>
        public Label(Java.Lang.String arg0, int arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Label.html#%3Cinit%3E(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Java.Awt.HeadlessException"/>
        public Label(Java.Lang.String arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Awt.Label"/> to <see cref="Javax.Accessibility.Accessible"/>
        /// </summary>
        public static implicit operator Javax.Accessibility.Accessible(Java.Awt.Label t) => t.Cast<Javax.Accessibility.Accessible>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Label.html#CENTER"/>
        /// </summary>
        public static int CENTER { get { if (!_CENTERReady) { _CENTERContent = SGetField<int>(LocalBridgeClazz, "CENTER"); _CENTERReady = true; } return _CENTERContent; } }
        private static int _CENTERContent = default;
        private static bool _CENTERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Label.html#LEFT"/>
        /// </summary>
        public static int LEFT { get { if (!_LEFTReady) { _LEFTContent = SGetField<int>(LocalBridgeClazz, "LEFT"); _LEFTReady = true; } return _LEFTContent; } }
        private static int _LEFTContent = default;
        private static bool _LEFTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Label.html#RIGHT"/>
        /// </summary>
        public static int RIGHT { get { if (!_RIGHTReady) { _RIGHTContent = SGetField<int>(LocalBridgeClazz, "RIGHT"); _RIGHTReady = true; } return _RIGHTContent; } }
        private static int _RIGHTContent = default;
        private static bool _RIGHTReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Label.html#getAlignment()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Label.html#setAlignment(int)"/>
        /// </summary>
        public int Alignment
        {
            get { return IExecuteWithSignature<int>("getAlignment", "()I"); } set { IExecuteWithSignature("setAlignment", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Label.html#getText()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Label.html#setText(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String Text
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getText", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setText", "(Ljava/lang/String;)V", value); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}