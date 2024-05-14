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

namespace Javax.Management.Relation
{
    #region RoleUnresolvedList
    public partial class RoleUnresolvedList
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RoleUnresolvedList.html#%3Cinit%3E(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public RoleUnresolvedList(int arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RoleUnresolvedList.html#%3Cinit%3E(java.util.List)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.List"/></param>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        public RoleUnresolvedList(Java.Util.List<Javax.Management.Relation.RoleUnresolved> arg0)
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RoleUnresolvedList.html#addAll(int,javax.management.relation.RoleUnresolvedList)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Javax.Management.Relation.RoleUnresolvedList"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        /// <exception cref="Java.Lang.IndexOutOfBoundsException"/>
        public bool AddAll(int arg0, Javax.Management.Relation.RoleUnresolvedList arg1)
        {
            return IExecute<bool>("addAll", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RoleUnresolvedList.html#addAll(javax.management.relation.RoleUnresolvedList)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.Relation.RoleUnresolvedList"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Lang.IndexOutOfBoundsException"/>
        public bool AddAll(Javax.Management.Relation.RoleUnresolvedList arg0)
        {
            return IExecuteWithSignature<bool>("addAll", "(Ljavax/management/relation/RoleUnresolvedList;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RoleUnresolvedList.html#asList()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Javax.Management.Relation.RoleUnresolved> AsList()
        {
            return IExecuteWithSignature<Java.Util.List<Javax.Management.Relation.RoleUnresolved>>("asList", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RoleUnresolvedList.html#add(int,javax.management.relation.RoleUnresolved)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Javax.Management.Relation.RoleUnresolved"/></param>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        /// <exception cref="Java.Lang.IndexOutOfBoundsException"/>
        public void Add(int arg0, Javax.Management.Relation.RoleUnresolved arg1)
        {
            IExecute("add", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RoleUnresolvedList.html#add(javax.management.relation.RoleUnresolved)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.Relation.RoleUnresolved"/></param>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        public void Add(Javax.Management.Relation.RoleUnresolved arg0)
        {
            IExecuteWithSignature("add", "(Ljavax/management/relation/RoleUnresolved;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RoleUnresolvedList.html#set(int,javax.management.relation.RoleUnresolved)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Javax.Management.Relation.RoleUnresolved"/></param>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        /// <exception cref="Java.Lang.IndexOutOfBoundsException"/>
        public void Set(int arg0, Javax.Management.Relation.RoleUnresolved arg1)
        {
            IExecute("set", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}