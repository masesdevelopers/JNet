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
*  This file is generated by MASES.JNetReflector (ver. 1.5.5.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Io
{
    #region ByteArrayOutputStream
    public partial class ByteArrayOutputStream
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ByteArrayOutputStream.html#%3Cinit%3E(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public ByteArrayOutputStream(int arg0)
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ByteArrayOutputStream.html#size()"/> 
        /// </summary>
        public int Size
        {
            get { return IExecute<int>("size"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ByteArrayOutputStream.html#toByteArray()"/> 
        /// </summary>
        public byte[] ToByteArray
        {
            get { return IExecuteArray<byte>("toByteArray"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ByteArrayOutputStream.html#toString(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="string"/></returns>
        /// <exception cref="Java.Io.UnsupportedEncodingException"/>
        public string ToString(string arg0)
        {
            return IExecute<string>("toString", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ByteArrayOutputStream.html#toString(java.nio.charset.Charset)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.Charset.Charset"/></param>
        /// <returns><see cref="string"/></returns>
        public string ToString(Java.Nio.Charset.Charset arg0)
        {
            return IExecute<string>("toString", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ByteArrayOutputStream.html#reset()"/>
        /// </summary>
        public void Reset()
        {
            IExecute("reset");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ByteArrayOutputStream.html#writeTo(java.io.OutputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.OutputStream"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void WriteTo(Java.Io.OutputStream arg0)
        {
            IExecute("writeTo", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ByteArrayOutputStream.html#writeBytes(byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        public void WriteBytes(byte[] arg0)
        {
            IExecute("writeBytes", new object[] { arg0 });
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}