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
    #region IRelation
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IRelation
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/Relation.html#getAllRoles()"/> 
        /// </summary>
        Javax.Management.Relation.RoleResult AllRoles { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/Relation.html#getReferencedMBeans()"/> 
        /// </summary>
        Java.Util.Map<Javax.Management.ObjectName, Java.Util.List<Java.Lang.String>> ReferencedMBeans { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/Relation.html#getRelationId()"/> 
        /// </summary>
        Java.Lang.String RelationId { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/Relation.html#getRelationServiceName()"/> 
        /// </summary>
        Javax.Management.ObjectName RelationServiceName { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/Relation.html#getRelationTypeName()"/> 
        /// </summary>
        Java.Lang.String RelationTypeName { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/Relation.html#getRoleCardinality(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.Integer"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        /// <exception cref="Javax.Management.Relation.RoleNotFoundException"/>
        Java.Lang.Integer GetRoleCardinality(Java.Lang.String arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/Relation.html#getRole(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Util.List"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        /// <exception cref="Javax.Management.Relation.RoleNotFoundException"/>
        /// <exception cref="Javax.Management.Relation.RelationServiceNotRegisteredException"/>
        Java.Util.List<Javax.Management.ObjectName> GetRole(Java.Lang.String arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/Relation.html#retrieveAllRoles()"/>
        /// </summary>

        /// <returns><see cref="Javax.Management.Relation.RoleList"/></returns>
        Javax.Management.Relation.RoleList RetrieveAllRoles();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/Relation.html#getRoles(java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Management.Relation.RoleResult"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        /// <exception cref="Javax.Management.Relation.RelationServiceNotRegisteredException"/>
        Javax.Management.Relation.RoleResult GetRoles(Java.Lang.String[] arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/Relation.html#setRoles(javax.management.relation.RoleList)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.Relation.RoleList"/></param>
        /// <returns><see cref="Javax.Management.Relation.RoleResult"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        /// <exception cref="Javax.Management.Relation.RelationServiceNotRegisteredException"/>
        /// <exception cref="Javax.Management.Relation.RelationTypeNotFoundException"/>
        /// <exception cref="Javax.Management.Relation.RelationNotFoundException"/>
        Javax.Management.Relation.RoleResult SetRoles(Javax.Management.Relation.RoleList arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/Relation.html#handleMBeanUnregistration(javax.management.ObjectName,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.ObjectName"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        /// <exception cref="Javax.Management.Relation.RoleNotFoundException"/>
        /// <exception cref="Javax.Management.Relation.InvalidRoleValueException"/>
        /// <exception cref="Javax.Management.Relation.RelationServiceNotRegisteredException"/>
        /// <exception cref="Javax.Management.Relation.RelationTypeNotFoundException"/>
        /// <exception cref="Javax.Management.Relation.RelationNotFoundException"/>
        void HandleMBeanUnregistration(Javax.Management.ObjectName arg0, Java.Lang.String arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/Relation.html#setRole(javax.management.relation.Role)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.Relation.Role"/></param>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        /// <exception cref="Javax.Management.Relation.RoleNotFoundException"/>
        /// <exception cref="Javax.Management.Relation.RelationTypeNotFoundException"/>
        /// <exception cref="Javax.Management.Relation.InvalidRoleValueException"/>
        /// <exception cref="Javax.Management.Relation.RelationServiceNotRegisteredException"/>
        /// <exception cref="Javax.Management.Relation.RelationNotFoundException"/>
        void SetRole(Javax.Management.Relation.Role arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region Relation
    public partial class Relation : Javax.Management.Relation.IRelation
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/Relation.html#getAllRoles()"/> 
        /// </summary>
        public Javax.Management.Relation.RoleResult AllRoles
        {
            get { return IExecuteWithSignature<Javax.Management.Relation.RoleResult>("getAllRoles", "()Ljavax/management/relation/RoleResult;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/Relation.html#getReferencedMBeans()"/> 
        /// </summary>
        public Java.Util.Map<Javax.Management.ObjectName, Java.Util.List<Java.Lang.String>> ReferencedMBeans
        {
            get { return IExecuteWithSignature<Java.Util.Map<Javax.Management.ObjectName, Java.Util.List<Java.Lang.String>>>("getReferencedMBeans", "()Ljava/util/Map;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/Relation.html#getRelationId()"/> 
        /// </summary>
        public Java.Lang.String RelationId
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getRelationId", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/Relation.html#getRelationServiceName()"/> 
        /// </summary>
        public Javax.Management.ObjectName RelationServiceName
        {
            get { return IExecuteWithSignature<Javax.Management.ObjectName>("getRelationServiceName", "()Ljavax/management/ObjectName;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/Relation.html#getRelationTypeName()"/> 
        /// </summary>
        public Java.Lang.String RelationTypeName
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getRelationTypeName", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/Relation.html#getRoleCardinality(java.lang.String)"/>
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/Relation.html#getRole(java.lang.String)"/>
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/Relation.html#retrieveAllRoles()"/>
        /// </summary>

        /// <returns><see cref="Javax.Management.Relation.RoleList"/></returns>
        public Javax.Management.Relation.RoleList RetrieveAllRoles()
        {
            return IExecuteWithSignature<Javax.Management.Relation.RoleList>("retrieveAllRoles", "()Ljavax/management/relation/RoleList;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/Relation.html#getRoles(java.lang.String[])"/>
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/Relation.html#setRoles(javax.management.relation.RoleList)"/>
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/Relation.html#handleMBeanUnregistration(javax.management.ObjectName,java.lang.String)"/>
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/Relation.html#setRole(javax.management.relation.Role)"/>
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