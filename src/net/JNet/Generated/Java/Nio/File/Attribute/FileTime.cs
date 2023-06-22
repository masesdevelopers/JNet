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
*  This file is generated by MASES.JNetReflector (ver. 2.0.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Nio.File.Attribute
{
    #region FileTime
    public partial class FileTime
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/attribute/FileTime.html#from(java.time.Instant)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Instant"/></param>
        /// <returns><see cref="Java.Nio.File.Attribute.FileTime"/></returns>
        public static Java.Nio.File.Attribute.FileTime From(Java.Time.Instant arg0)
        {
            return SExecute<Java.Nio.File.Attribute.FileTime>(LocalBridgeClazz, "from", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/attribute/FileTime.html#from(long,java.util.concurrent.TimeUnit)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="Java.Util.Concurrent.TimeUnit"/></param>
        /// <returns><see cref="Java.Nio.File.Attribute.FileTime"/></returns>
        public static Java.Nio.File.Attribute.FileTime From(long arg0, Java.Util.Concurrent.TimeUnit arg1)
        {
            return SExecute<Java.Nio.File.Attribute.FileTime>(LocalBridgeClazz, "from", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/attribute/FileTime.html#fromMillis(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Nio.File.Attribute.FileTime"/></returns>
        public static Java.Nio.File.Attribute.FileTime FromMillis(long arg0)
        {
            return SExecute<Java.Nio.File.Attribute.FileTime>(LocalBridgeClazz, "fromMillis", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/attribute/FileTime.html#compareTo(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="int"/></returns>
        public int CompareTo(object arg0)
        {
            return IExecute<int>("compareTo", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/attribute/FileTime.html#compareTo(java.nio.file.attribute.FileTime)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.File.Attribute.FileTime"/></param>
        /// <returns><see cref="int"/></returns>
        public int CompareTo(Java.Nio.File.Attribute.FileTime arg0)
        {
            return IExecute<int>("compareTo", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/attribute/FileTime.html#toInstant()"/>
        /// </summary>

        /// <returns><see cref="Java.Time.Instant"/></returns>
        public Java.Time.Instant ToInstant()
        {
            return IExecute<Java.Time.Instant>("toInstant");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/attribute/FileTime.html#to(java.util.concurrent.TimeUnit)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.TimeUnit"/></param>
        /// <returns><see cref="long"/></returns>
        public long To(Java.Util.Concurrent.TimeUnit arg0)
        {
            return IExecute<long>("to", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/attribute/FileTime.html#toMillis()"/>
        /// </summary>

        /// <returns><see cref="long"/></returns>
        public long ToMillis()
        {
            return IExecute<long>("toMillis");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}