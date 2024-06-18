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

namespace Java.Awt
{
    #region TextArea
    public partial class TextArea
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/TextArea.html#%3Cinit%3E(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <exception cref="Java.Awt.HeadlessException"/>
        public TextArea(int arg0, int arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/TextArea.html#%3Cinit%3E(java.lang.String,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <exception cref="Java.Awt.HeadlessException"/>
        public TextArea(Java.Lang.String arg0, int arg1, int arg2, int arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/TextArea.html#%3Cinit%3E(java.lang.String,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <exception cref="Java.Awt.HeadlessException"/>
        public TextArea(Java.Lang.String arg0, int arg1, int arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/TextArea.html#%3Cinit%3E(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Java.Awt.HeadlessException"/>
        public TextArea(Java.Lang.String arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/TextArea.html#SCROLLBARS_BOTH"/>
        /// </summary>
        public static int SCROLLBARS_BOTH { get { if (!_SCROLLBARS_BOTHReady) { _SCROLLBARS_BOTHContent = SGetField<int>(LocalBridgeClazz, "SCROLLBARS_BOTH"); _SCROLLBARS_BOTHReady = true; } return _SCROLLBARS_BOTHContent; } }
        private static int _SCROLLBARS_BOTHContent = default;
        private static bool _SCROLLBARS_BOTHReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/TextArea.html#SCROLLBARS_HORIZONTAL_ONLY"/>
        /// </summary>
        public static int SCROLLBARS_HORIZONTAL_ONLY { get { if (!_SCROLLBARS_HORIZONTAL_ONLYReady) { _SCROLLBARS_HORIZONTAL_ONLYContent = SGetField<int>(LocalBridgeClazz, "SCROLLBARS_HORIZONTAL_ONLY"); _SCROLLBARS_HORIZONTAL_ONLYReady = true; } return _SCROLLBARS_HORIZONTAL_ONLYContent; } }
        private static int _SCROLLBARS_HORIZONTAL_ONLYContent = default;
        private static bool _SCROLLBARS_HORIZONTAL_ONLYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/TextArea.html#SCROLLBARS_NONE"/>
        /// </summary>
        public static int SCROLLBARS_NONE { get { if (!_SCROLLBARS_NONEReady) { _SCROLLBARS_NONEContent = SGetField<int>(LocalBridgeClazz, "SCROLLBARS_NONE"); _SCROLLBARS_NONEReady = true; } return _SCROLLBARS_NONEContent; } }
        private static int _SCROLLBARS_NONEContent = default;
        private static bool _SCROLLBARS_NONEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/TextArea.html#SCROLLBARS_VERTICAL_ONLY"/>
        /// </summary>
        public static int SCROLLBARS_VERTICAL_ONLY { get { if (!_SCROLLBARS_VERTICAL_ONLYReady) { _SCROLLBARS_VERTICAL_ONLYContent = SGetField<int>(LocalBridgeClazz, "SCROLLBARS_VERTICAL_ONLY"); _SCROLLBARS_VERTICAL_ONLYReady = true; } return _SCROLLBARS_VERTICAL_ONLYContent; } }
        private static int _SCROLLBARS_VERTICAL_ONLYContent = default;
        private static bool _SCROLLBARS_VERTICAL_ONLYReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/TextArea.html#getColumns()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/TextArea.html#setColumns(int)"/>
        /// </summary>
        public int Columns
        {
            get { return IExecuteWithSignature<int>("getColumns", "()I"); } set { IExecuteWithSignature("setColumns", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/TextArea.html#getRows()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/TextArea.html#setRows(int)"/>
        /// </summary>
        public int Rows
        {
            get { return IExecuteWithSignature<int>("getRows", "()I"); } set { IExecuteWithSignature("setRows", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/TextArea.html#getScrollbarVisibility()"/> 
        /// </summary>
        public int ScrollbarVisibility
        {
            get { return IExecuteWithSignature<int>("getScrollbarVisibility", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/TextArea.html#getMinimumSize(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.Dimension"/></returns>
        public Java.Awt.Dimension GetMinimumSize(int arg0, int arg1)
        {
            return IExecute<Java.Awt.Dimension>("getMinimumSize", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/TextArea.html#getPreferredSize(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.Dimension"/></returns>
        public Java.Awt.Dimension GetPreferredSize(int arg0, int arg1)
        {
            return IExecute<Java.Awt.Dimension>("getPreferredSize", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/TextArea.html#append(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void Append(Java.Lang.String arg0)
        {
            IExecuteWithSignature("append", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/TextArea.html#insert(java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void Insert(Java.Lang.String arg0, int arg1)
        {
            IExecute("insert", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/TextArea.html#replaceRange(java.lang.String,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public void ReplaceRange(Java.Lang.String arg0, int arg1, int arg2)
        {
            IExecute("replaceRange", arg0, arg1, arg2);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}