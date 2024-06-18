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

namespace Java.Nio.File.Attribute
{
    #region IDosFileAttributes
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IDosFileAttributes : Java.Nio.File.Attribute.IBasicFileAttributes
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/attribute/DosFileAttributes.html#isArchive()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        bool IsArchive();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/attribute/DosFileAttributes.html#isHidden()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        bool IsHidden();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/attribute/DosFileAttributes.html#isReadOnly()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        bool IsReadOnly();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/attribute/DosFileAttributes.html#isSystem()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        bool IsSystem();

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region DosFileAttributes
    public partial class DosFileAttributes : Java.Nio.File.Attribute.IDosFileAttributes
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/attribute/DosFileAttributes.html#isArchive()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsArchive()
        {
            return IExecuteWithSignature<bool>("isArchive", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/attribute/DosFileAttributes.html#isHidden()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsHidden()
        {
            return IExecuteWithSignature<bool>("isHidden", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/attribute/DosFileAttributes.html#isReadOnly()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsReadOnly()
        {
            return IExecuteWithSignature<bool>("isReadOnly", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/attribute/DosFileAttributes.html#isSystem()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsSystem()
        {
            return IExecuteWithSignature<bool>("isSystem", "()Z");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}