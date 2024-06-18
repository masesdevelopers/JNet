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

namespace Javax.Management.Relation
{
    #region RoleInfo
    public partial class RoleInfo
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RoleInfo.html#%3Cinit%3E(java.lang.String,java.lang.String,boolean,boolean,int,int,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        /// <param name="arg3"><see cref="bool"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <param name="arg6"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        /// <exception cref="Javax.Management.Relation.InvalidRoleInfoException"/>
        /// <exception cref="Java.Lang.ClassNotFoundException"/>
        /// <exception cref="Javax.Management.NotCompliantMBeanException"/>
        public RoleInfo(Java.Lang.String arg0, Java.Lang.String arg1, bool arg2, bool arg3, int arg4, int arg5, Java.Lang.String arg6)
            : base(arg0, arg1, arg2, arg3, arg4, arg5, arg6)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RoleInfo.html#%3Cinit%3E(java.lang.String,java.lang.String,boolean,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        /// <param name="arg3"><see cref="bool"/></param>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        /// <exception cref="Java.Lang.ClassNotFoundException"/>
        /// <exception cref="Javax.Management.NotCompliantMBeanException"/>
        public RoleInfo(Java.Lang.String arg0, Java.Lang.String arg1, bool arg2, bool arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RoleInfo.html#%3Cinit%3E(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        /// <exception cref="Java.Lang.ClassNotFoundException"/>
        /// <exception cref="Javax.Management.NotCompliantMBeanException"/>
        public RoleInfo(Java.Lang.String arg0, Java.Lang.String arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RoleInfo.html#%3Cinit%3E(javax.management.relation.RoleInfo)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.Relation.RoleInfo"/></param>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        public RoleInfo(Javax.Management.Relation.RoleInfo arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RoleInfo.html#ROLE_CARDINALITY_INFINITY"/>
        /// </summary>
        public static int ROLE_CARDINALITY_INFINITY { get { if (!_ROLE_CARDINALITY_INFINITYReady) { _ROLE_CARDINALITY_INFINITYContent = SGetField<int>(LocalBridgeClazz, "ROLE_CARDINALITY_INFINITY"); _ROLE_CARDINALITY_INFINITYReady = true; } return _ROLE_CARDINALITY_INFINITYContent; } }
        private static int _ROLE_CARDINALITY_INFINITYContent = default;
        private static bool _ROLE_CARDINALITY_INFINITYReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RoleInfo.html#getDescription()"/> 
        /// </summary>
        public Java.Lang.String Description
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getDescription", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RoleInfo.html#getMaxDegree()"/> 
        /// </summary>
        public int MaxDegree
        {
            get { return IExecuteWithSignature<int>("getMaxDegree", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RoleInfo.html#getMinDegree()"/> 
        /// </summary>
        public int MinDegree
        {
            get { return IExecuteWithSignature<int>("getMinDegree", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RoleInfo.html#getName()"/> 
        /// </summary>
        public Java.Lang.String Name
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getName", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RoleInfo.html#getRefMBeanClassName()"/> 
        /// </summary>
        public Java.Lang.String RefMBeanClassName
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getRefMBeanClassName", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RoleInfo.html#checkMaxDegree(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool CheckMaxDegree(int arg0)
        {
            return IExecuteWithSignature<bool>("checkMaxDegree", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RoleInfo.html#checkMinDegree(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool CheckMinDegree(int arg0)
        {
            return IExecuteWithSignature<bool>("checkMinDegree", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RoleInfo.html#isReadable()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsReadable()
        {
            return IExecuteWithSignature<bool>("isReadable", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RoleInfo.html#isWritable()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsWritable()
        {
            return IExecuteWithSignature<bool>("isWritable", "()Z");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}