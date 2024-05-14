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

namespace Java.Nio.File.Attribute
{
    #region UserPrincipalLookupService
    public partial class UserPrincipalLookupService
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/attribute/UserPrincipalLookupService.html#lookupPrincipalByGroupName(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Nio.File.Attribute.GroupPrincipal"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Nio.File.Attribute.GroupPrincipal LookupPrincipalByGroupName(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Nio.File.Attribute.GroupPrincipal>("lookupPrincipalByGroupName", "(Ljava/lang/String;)Ljava/nio/file/attribute/GroupPrincipal;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/attribute/UserPrincipalLookupService.html#lookupPrincipalByName(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Nio.File.Attribute.UserPrincipal"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Nio.File.Attribute.UserPrincipal LookupPrincipalByName(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Nio.File.Attribute.UserPrincipal>("lookupPrincipalByName", "(Ljava/lang/String;)Ljava/nio/file/attribute/UserPrincipal;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}