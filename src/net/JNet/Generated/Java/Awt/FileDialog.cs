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
*  This file is generated by MASES.JNetReflector (ver. 2.5.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Awt
{
    #region FileDialog
    public partial class FileDialog
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/FileDialog.html#%3Cinit%3E(java.awt.Dialog,java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Dialog"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public FileDialog(Java.Awt.Dialog arg0, Java.Lang.String arg1, int arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/FileDialog.html#%3Cinit%3E(java.awt.Dialog,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Dialog"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        public FileDialog(Java.Awt.Dialog arg0, Java.Lang.String arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/FileDialog.html#%3Cinit%3E(java.awt.Dialog)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Dialog"/></param>
        public FileDialog(Java.Awt.Dialog arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/FileDialog.html#%3Cinit%3E(java.awt.Frame,java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Frame"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public FileDialog(Java.Awt.Frame arg0, Java.Lang.String arg1, int arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/FileDialog.html#%3Cinit%3E(java.awt.Frame,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Frame"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        public FileDialog(Java.Awt.Frame arg0, Java.Lang.String arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/FileDialog.html#%3Cinit%3E(java.awt.Frame)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Frame"/></param>
        public FileDialog(Java.Awt.Frame arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/FileDialog.html#LOAD"/>
        /// </summary>
        public static int LOAD { get { if (!_LOADReady) { _LOADContent = SGetField<int>(LocalBridgeClazz, "LOAD"); _LOADReady = true; } return _LOADContent; } }
        private static int _LOADContent = default;
        private static bool _LOADReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/FileDialog.html#SAVE"/>
        /// </summary>
        public static int SAVE { get { if (!_SAVEReady) { _SAVEContent = SGetField<int>(LocalBridgeClazz, "SAVE"); _SAVEReady = true; } return _SAVEContent; } }
        private static int _SAVEContent = default;
        private static bool _SAVEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/FileDialog.html#getDirectory()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/FileDialog.html#setDirectory(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String Directory
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getDirectory", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setDirectory", "(Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/FileDialog.html#getFile()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/FileDialog.html#setFile(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String File
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getFile", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setFile", "(Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/FileDialog.html#getFilenameFilter()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/FileDialog.html#setFilenameFilter(java.io.FilenameFilter)"/>
        /// </summary>
        public Java.Io.FilenameFilter FilenameFilter
        {
            get { return IExecuteWithSignature<Java.Io.FilenameFilter>("getFilenameFilter", "()Ljava/io/FilenameFilter;"); } set { IExecuteWithSignature("setFilenameFilter", "(Ljava/io/FilenameFilter;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/FileDialog.html#getFiles()"/> 
        /// </summary>
        public Java.Io.File[] Files
        {
            get { return IExecuteWithSignatureArray<Java.Io.File>("getFiles", "()[Ljava/io/File;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/FileDialog.html#getMode()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/FileDialog.html#setMode(int)"/>
        /// </summary>
        public int Mode
        {
            get { return IExecuteWithSignature<int>("getMode", "()I"); } set { IExecuteWithSignature("setMode", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/FileDialog.html#isMultipleMode()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsMultipleMode()
        {
            return IExecuteWithSignature<bool>("isMultipleMode", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/FileDialog.html#setMultipleMode(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetMultipleMode(bool arg0)
        {
            IExecuteWithSignature("setMultipleMode", "(Z)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}