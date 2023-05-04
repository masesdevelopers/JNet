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

namespace Java.Nio.File.Attribute
{
    #region AclEntry
    public partial class AclEntry
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/attribute/AclEntry.html#newBuilder()"/>
        /// </summary>

        /// <returns><see cref="Java.Nio.File.Attribute.AclEntry.Builder"/></returns>
        public static Java.Nio.File.Attribute.AclEntry.Builder NewBuilder()
        {
            return SExecute<Java.Nio.File.Attribute.AclEntry.Builder>(LocalBridgeClazz, "newBuilder");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/attribute/AclEntry.html#newBuilder(java.nio.file.attribute.AclEntry)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.File.Attribute.AclEntry"/></param>
        /// <returns><see cref="Java.Nio.File.Attribute.AclEntry.Builder"/></returns>
        public static Java.Nio.File.Attribute.AclEntry.Builder NewBuilder(Java.Nio.File.Attribute.AclEntry arg0)
        {
            return SExecute<Java.Nio.File.Attribute.AclEntry.Builder>(LocalBridgeClazz, "newBuilder", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/attribute/AclEntry.html#flags()"/> 
        /// </summary>
        public Java.Util.Set<Java.Nio.File.Attribute.AclEntryFlag> Flags
        {
            get { return IExecute<Java.Util.Set<Java.Nio.File.Attribute.AclEntryFlag>>("flags"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/attribute/AclEntry.html#permissions()"/> 
        /// </summary>
        public Java.Util.Set<Java.Nio.File.Attribute.AclEntryPermission> Permissions
        {
            get { return IExecute<Java.Util.Set<Java.Nio.File.Attribute.AclEntryPermission>>("permissions"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/attribute/AclEntry.html#principal()"/> 
        /// </summary>
        public Java.Nio.File.Attribute.UserPrincipal Principal
        {
            get { return IExecute<Java.Nio.File.Attribute.UserPrincipal>("principal"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/attribute/AclEntry.html#type()"/> 
        /// </summary>
        public Java.Nio.File.Attribute.AclEntryType Type
        {
            get { return IExecute<Java.Nio.File.Attribute.AclEntryType>("type"); }
        }

        #endregion

        #region Nested classes
        #region Builder
        public partial class Builder
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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/attribute/AclEntry.Builder.html#build()"/> 
            /// </summary>
            public Java.Nio.File.Attribute.AclEntry Build
            {
                get { return IExecute<Java.Nio.File.Attribute.AclEntry>("build"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/attribute/AclEntry.Builder.html#setFlags(java.nio.file.attribute.AclEntryFlag[])"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Nio.File.Attribute.AclEntryFlag"/></param>
            /// <returns><see cref="Java.Nio.File.Attribute.AclEntry.Builder"/></returns>
            public Java.Nio.File.Attribute.AclEntry.Builder SetFlags(params Java.Nio.File.Attribute.AclEntryFlag[] arg0)
            {
                if (arg0.Length == 0) return IExecute<Java.Nio.File.Attribute.AclEntry.Builder>("setFlags"); else return IExecute<Java.Nio.File.Attribute.AclEntry.Builder>("setFlags", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/attribute/AclEntry.Builder.html#setFlags(java.util.Set)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.Set"/></param>
            /// <returns><see cref="Java.Nio.File.Attribute.AclEntry.Builder"/></returns>
            public Java.Nio.File.Attribute.AclEntry.Builder SetFlags(Java.Util.Set<Java.Nio.File.Attribute.AclEntryFlag> arg0)
            {
                return IExecute<Java.Nio.File.Attribute.AclEntry.Builder>("setFlags", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/attribute/AclEntry.Builder.html#setPermissions(java.nio.file.attribute.AclEntryPermission[])"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Nio.File.Attribute.AclEntryPermission"/></param>
            /// <returns><see cref="Java.Nio.File.Attribute.AclEntry.Builder"/></returns>
            public Java.Nio.File.Attribute.AclEntry.Builder SetPermissions(params Java.Nio.File.Attribute.AclEntryPermission[] arg0)
            {
                if (arg0.Length == 0) return IExecute<Java.Nio.File.Attribute.AclEntry.Builder>("setPermissions"); else return IExecute<Java.Nio.File.Attribute.AclEntry.Builder>("setPermissions", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/attribute/AclEntry.Builder.html#setPermissions(java.util.Set)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.Set"/></param>
            /// <returns><see cref="Java.Nio.File.Attribute.AclEntry.Builder"/></returns>
            public Java.Nio.File.Attribute.AclEntry.Builder SetPermissions(Java.Util.Set<Java.Nio.File.Attribute.AclEntryPermission> arg0)
            {
                return IExecute<Java.Nio.File.Attribute.AclEntry.Builder>("setPermissions", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/attribute/AclEntry.Builder.html#setPrincipal(java.nio.file.attribute.UserPrincipal)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Nio.File.Attribute.UserPrincipal"/></param>
            /// <returns><see cref="Java.Nio.File.Attribute.AclEntry.Builder"/></returns>
            public Java.Nio.File.Attribute.AclEntry.Builder SetPrincipal(Java.Nio.File.Attribute.UserPrincipal arg0)
            {
                return IExecute<Java.Nio.File.Attribute.AclEntry.Builder>("setPrincipal", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/attribute/AclEntry.Builder.html#setType(java.nio.file.attribute.AclEntryType)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Nio.File.Attribute.AclEntryType"/></param>
            /// <returns><see cref="Java.Nio.File.Attribute.AclEntry.Builder"/></returns>
            public Java.Nio.File.Attribute.AclEntry.Builder SetType(Java.Nio.File.Attribute.AclEntryType arg0)
            {
                return IExecute<Java.Nio.File.Attribute.AclEntry.Builder>("setType", arg0);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

    
        #endregion

        // TODO: complete the class
    }
    #endregion
}