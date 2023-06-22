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

namespace Java.Nio
{
    #region MappedByteBuffer
    public partial class MappedByteBuffer
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/MappedByteBuffer.html#isLoaded()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsLoaded()
        {
            return IExecute<bool>("isLoaded");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/MappedByteBuffer.html#force()"/>
        /// </summary>

        /// <returns><see cref="Java.Nio.MappedByteBuffer"/></returns>
        public Java.Nio.MappedByteBuffer Force()
        {
            return IExecute<Java.Nio.MappedByteBuffer>("force");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/MappedByteBuffer.html#load()"/>
        /// </summary>

        /// <returns><see cref="Java.Nio.MappedByteBuffer"/></returns>
        public Java.Nio.MappedByteBuffer Load()
        {
            return IExecute<Java.Nio.MappedByteBuffer>("load");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}