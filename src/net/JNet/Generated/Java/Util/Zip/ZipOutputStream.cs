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

namespace Java.Util.Zip
{
    #region ZipOutputStream
    public partial class ZipOutputStream
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/ZipOutputStream.html#%3Cinit%3E(java.io.OutputStream,java.nio.charset.Charset)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.OutputStream"/></param>
        /// <param name="arg1"><see cref="Java.Nio.Charset.Charset"/></param>
        public ZipOutputStream(Java.Io.OutputStream arg0, Java.Nio.Charset.Charset arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/ZipOutputStream.html#%3Cinit%3E(java.io.OutputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.OutputStream"/></param>
        public ZipOutputStream(Java.Io.OutputStream arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/ZipOutputStream.html#DEFLATED"/>
        /// </summary>
        public static int DEFLATED { get { if (!_DEFLATEDReady) { _DEFLATEDContent = SGetField<int>(LocalBridgeClazz, "DEFLATED"); _DEFLATEDReady = true; } return _DEFLATEDContent; } }
        private static int _DEFLATEDContent = default;
        private static bool _DEFLATEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/ZipOutputStream.html#STORED"/>
        /// </summary>
        public static int STORED { get { if (!_STOREDReady) { _STOREDContent = SGetField<int>(LocalBridgeClazz, "STORED"); _STOREDReady = true; } return _STOREDContent; } }
        private static int _STOREDContent = default;
        private static bool _STOREDReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/ZipOutputStream.html#closeEntry()"/>
        /// </summary>
        /// <exception cref="Java.Io.IOException"/>
        public void CloseEntry()
        {
            IExecuteWithSignature("closeEntry", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/ZipOutputStream.html#putNextEntry(java.util.zip.ZipEntry)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Zip.ZipEntry"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void PutNextEntry(Java.Util.Zip.ZipEntry arg0)
        {
            IExecuteWithSignature("putNextEntry", "(Ljava/util/zip/ZipEntry;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/ZipOutputStream.html#setComment(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void SetComment(Java.Lang.String arg0)
        {
            IExecuteWithSignature("setComment", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/ZipOutputStream.html#setLevel(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetLevel(int arg0)
        {
            IExecuteWithSignature("setLevel", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/ZipOutputStream.html#setMethod(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetMethod(int arg0)
        {
            IExecuteWithSignature("setMethod", "(I)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}