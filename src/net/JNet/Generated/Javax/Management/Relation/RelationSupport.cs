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
*  This file is generated by MASES.JNetReflector (ver. 2.5.7.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Management.Relation
{
    #region RelationSupport
    public partial class RelationSupport
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationSupport.html#%3Cinit%3E(java.lang.String,javax.management.ObjectName,java.lang.String,javax.management.relation.RoleList)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Javax.Management.ObjectName"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="Javax.Management.Relation.RoleList"/></param>
        /// <exception cref="Javax.Management.Relation.InvalidRoleValueException"/>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        public RelationSupport(Java.Lang.String arg0, Javax.Management.ObjectName arg1, Java.Lang.String arg2, Javax.Management.Relation.RoleList arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationSupport.html#%3Cinit%3E(java.lang.String,javax.management.ObjectName,javax.management.MBeanServer,java.lang.String,javax.management.relation.RoleList)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Javax.Management.ObjectName"/></param>
        /// <param name="arg2"><see cref="Javax.Management.MBeanServer"/></param>
        /// <param name="arg3"><see cref="Java.Lang.String"/></param>
        /// <param name="arg4"><see cref="Javax.Management.Relation.RoleList"/></param>
        /// <exception cref="Javax.Management.Relation.InvalidRoleValueException"/>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        public RelationSupport(Java.Lang.String arg0, Javax.Management.ObjectName arg1, Javax.Management.MBeanServer arg2, Java.Lang.String arg3, Javax.Management.Relation.RoleList arg4)
            : base(arg0, arg1, arg2, arg3, arg4)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Management.Relation.RelationSupport"/> to <see cref="Javax.Management.Relation.RelationSupportMBean"/>
        /// </summary>
        public static implicit operator Javax.Management.Relation.RelationSupportMBean(Javax.Management.Relation.RelationSupport t) => t.Cast<Javax.Management.Relation.RelationSupportMBean>();
        /// <summary>
        /// Converter from <see cref="Javax.Management.Relation.RelationSupport"/> to <see cref="Javax.Management.MBeanRegistration"/>
        /// </summary>
        public static implicit operator Javax.Management.MBeanRegistration(Javax.Management.Relation.RelationSupport t) => t.Cast<Javax.Management.MBeanRegistration>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationSupport.html#getAllRoles()"/> 
        /// </summary>
        public Javax.Management.Relation.RoleResult AllRoles
        {
            get { return IExecuteWithSignature<Javax.Management.Relation.RoleResult>("getAllRoles", "()Ljavax/management/relation/RoleResult;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationSupport.html#getReferencedMBeans()"/> 
        /// </summary>
        public Java.Util.Map<Javax.Management.ObjectName, Java.Util.List<Java.Lang.String>> ReferencedMBeans
        {
            get { return IExecuteWithSignature<Java.Util.Map<Javax.Management.ObjectName, Java.Util.List<Java.Lang.String>>>("getReferencedMBeans", "()Ljava/util/Map;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationSupport.html#getRelationId()"/> 
        /// </summary>
        public Java.Lang.String RelationId
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getRelationId", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationSupport.html#getRelationServiceName()"/> 
        /// </summary>
        public Javax.Management.ObjectName RelationServiceName
        {
            get { return IExecuteWithSignature<Javax.Management.ObjectName>("getRelationServiceName", "()Ljavax/management/ObjectName;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationSupport.html#getRelationTypeName()"/> 
        /// </summary>
        public Java.Lang.String RelationTypeName
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getRelationTypeName", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationSupport.html#isInRelationService()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.Boolean"/></returns>
        public Java.Lang.Boolean IsInRelationService()
        {
            return IExecuteWithSignature<Java.Lang.Boolean>("isInRelationService", "()Ljava/lang/Boolean;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationSupport.html#getRoleCardinality(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.Integer"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        /// <exception cref="Javax.Management.Relation.RoleNotFoundException"/>
        public Java.Lang.Integer GetRoleCardinality(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Lang.Integer>("getRoleCardinality", "(Ljava/lang/String;)Ljava/lang/Integer;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationSupport.html#getRole(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Util.List"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        /// <exception cref="Javax.Management.Relation.RoleNotFoundException"/>
        /// <exception cref="Javax.Management.Relation.RelationServiceNotRegisteredException"/>
        public Java.Util.List<Javax.Management.ObjectName> GetRole(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Util.List<Javax.Management.ObjectName>>("getRole", "(Ljava/lang/String;)Ljava/util/List;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationSupport.html#preRegister(javax.management.MBeanServer,javax.management.ObjectName)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.MBeanServer"/></param>
        /// <param name="arg1"><see cref="Javax.Management.ObjectName"/></param>
        /// <returns><see cref="Javax.Management.ObjectName"/></returns>
        /// <exception cref="Java.Lang.Exception"/>
        public Javax.Management.ObjectName PreRegister(Javax.Management.MBeanServer arg0, Javax.Management.ObjectName arg1)
        {
            return IExecute<Javax.Management.ObjectName>("preRegister", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationSupport.html#retrieveAllRoles()"/>
        /// </summary>
        /// <returns><see cref="Javax.Management.Relation.RoleList"/></returns>
        public Javax.Management.Relation.RoleList RetrieveAllRoles()
        {
            return IExecuteWithSignature<Javax.Management.Relation.RoleList>("retrieveAllRoles", "()Ljavax/management/relation/RoleList;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationSupport.html#getRoles(java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Management.Relation.RoleResult"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        /// <exception cref="Javax.Management.Relation.RelationServiceNotRegisteredException"/>
        public Javax.Management.Relation.RoleResult GetRoles(Java.Lang.String[] arg0)
        {
            return IExecuteWithSignature<Javax.Management.Relation.RoleResult>("getRoles", "([Ljava/lang/String;)Ljavax/management/relation/RoleResult;", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationSupport.html#setRoles(javax.management.relation.RoleList)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.Relation.RoleList"/></param>
        /// <returns><see cref="Javax.Management.Relation.RoleResult"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        /// <exception cref="Javax.Management.Relation.RelationServiceNotRegisteredException"/>
        /// <exception cref="Javax.Management.Relation.RelationTypeNotFoundException"/>
        /// <exception cref="Javax.Management.Relation.RelationNotFoundException"/>
        public Javax.Management.Relation.RoleResult SetRoles(Javax.Management.Relation.RoleList arg0)
        {
            return IExecuteWithSignature<Javax.Management.Relation.RoleResult>("setRoles", "(Ljavax/management/relation/RoleList;)Ljavax/management/relation/RoleResult;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationSupport.html#handleMBeanUnregistration(javax.management.ObjectName,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.ObjectName"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        /// <exception cref="Javax.Management.Relation.RoleNotFoundException"/>
        /// <exception cref="Javax.Management.Relation.InvalidRoleValueException"/>
        /// <exception cref="Javax.Management.Relation.RelationServiceNotRegisteredException"/>
        /// <exception cref="Javax.Management.Relation.RelationTypeNotFoundException"/>
        /// <exception cref="Javax.Management.Relation.RelationNotFoundException"/>
        public void HandleMBeanUnregistration(Javax.Management.ObjectName arg0, Java.Lang.String arg1)
        {
            IExecute("handleMBeanUnregistration", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationSupport.html#postDeregister()"/>
        /// </summary>
        public void PostDeregister()
        {
            IExecuteWithSignature("postDeregister", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationSupport.html#postRegister(java.lang.Boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Boolean"/></param>
        public void PostRegister(Java.Lang.Boolean arg0)
        {
            IExecuteWithSignature("postRegister", "(Ljava/lang/Boolean;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationSupport.html#preDeregister()"/>
        /// </summary>
        /// <exception cref="Java.Lang.Exception"/>
        public void PreDeregister()
        {
            IExecuteWithSignature("preDeregister", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationSupport.html#setRelationServiceManagementFlag(java.lang.Boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Boolean"/></param>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        public void SetRelationServiceManagementFlag(Java.Lang.Boolean arg0)
        {
            IExecuteWithSignature("setRelationServiceManagementFlag", "(Ljava/lang/Boolean;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationSupport.html#setRole(javax.management.relation.Role)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.Relation.Role"/></param>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        /// <exception cref="Javax.Management.Relation.RoleNotFoundException"/>
        /// <exception cref="Javax.Management.Relation.RelationTypeNotFoundException"/>
        /// <exception cref="Javax.Management.Relation.InvalidRoleValueException"/>
        /// <exception cref="Javax.Management.Relation.RelationServiceNotRegisteredException"/>
        /// <exception cref="Javax.Management.Relation.RelationNotFoundException"/>
        public void SetRole(Javax.Management.Relation.Role arg0)
        {
            IExecuteWithSignature("setRole", "(Ljavax/management/relation/Role;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}