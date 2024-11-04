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
*  This file is generated by MASES.JNetReflector (ver. 2.5.10.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Management.Relation
{
    #region RelationNotification declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationNotification.html"/>
    /// </summary>
    public partial class RelationNotification : Javax.Management.Notification
    {
        const string _bridgeClassName = "javax.management.relation.RelationNotification";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public RelationNotification() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public RelationNotification(params object[] args) : base(args) { }

        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
        /// </summary>
        public override bool IsBridgeCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
        /// </summary>
        public override bool IsBridgeInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region RelationNotification implementation
    public partial class RelationNotification
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationNotification.html#%3Cinit%3E(java.lang.String,java.lang.Object,long,long,java.lang.String,java.lang.String,java.lang.String,javax.management.ObjectName,java.lang.String,java.util.List,java.util.List)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <param name="arg3"><see cref="long"/></param>
        /// <param name="arg4"><see cref="Java.Lang.String"/></param>
        /// <param name="arg5"><see cref="Java.Lang.String"/></param>
        /// <param name="arg6"><see cref="Java.Lang.String"/></param>
        /// <param name="arg7"><see cref="Javax.Management.ObjectName"/></param>
        /// <param name="arg8"><see cref="Java.Lang.String"/></param>
        /// <param name="arg9"><see cref="Java.Util.List"/></param>
        /// <param name="arg10"><see cref="Java.Util.List"/></param>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        public RelationNotification(Java.Lang.String arg0, object arg1, long arg2, long arg3, Java.Lang.String arg4, Java.Lang.String arg5, Java.Lang.String arg6, Javax.Management.ObjectName arg7, Java.Lang.String arg8, Java.Util.List<Javax.Management.ObjectName> arg9, Java.Util.List<Javax.Management.ObjectName> arg10)
            : base(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationNotification.html#%3Cinit%3E(java.lang.String,java.lang.Object,long,long,java.lang.String,java.lang.String,java.lang.String,javax.management.ObjectName,java.util.List)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <param name="arg3"><see cref="long"/></param>
        /// <param name="arg4"><see cref="Java.Lang.String"/></param>
        /// <param name="arg5"><see cref="Java.Lang.String"/></param>
        /// <param name="arg6"><see cref="Java.Lang.String"/></param>
        /// <param name="arg7"><see cref="Javax.Management.ObjectName"/></param>
        /// <param name="arg8"><see cref="Java.Util.List"/></param>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        public RelationNotification(Java.Lang.String arg0, object arg1, long arg2, long arg3, Java.Lang.String arg4, Java.Lang.String arg5, Java.Lang.String arg6, Javax.Management.ObjectName arg7, Java.Util.List<Javax.Management.ObjectName> arg8)
            : base(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationNotification.html#RELATION_BASIC_CREATION"/>
        /// </summary>
        public static Java.Lang.String RELATION_BASIC_CREATION { get { if (!_RELATION_BASIC_CREATIONReady) { _RELATION_BASIC_CREATIONContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "RELATION_BASIC_CREATION"); _RELATION_BASIC_CREATIONReady = true; } return _RELATION_BASIC_CREATIONContent; } }
        private static Java.Lang.String _RELATION_BASIC_CREATIONContent = default;
        private static bool _RELATION_BASIC_CREATIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationNotification.html#RELATION_BASIC_REMOVAL"/>
        /// </summary>
        public static Java.Lang.String RELATION_BASIC_REMOVAL { get { if (!_RELATION_BASIC_REMOVALReady) { _RELATION_BASIC_REMOVALContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "RELATION_BASIC_REMOVAL"); _RELATION_BASIC_REMOVALReady = true; } return _RELATION_BASIC_REMOVALContent; } }
        private static Java.Lang.String _RELATION_BASIC_REMOVALContent = default;
        private static bool _RELATION_BASIC_REMOVALReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationNotification.html#RELATION_BASIC_UPDATE"/>
        /// </summary>
        public static Java.Lang.String RELATION_BASIC_UPDATE { get { if (!_RELATION_BASIC_UPDATEReady) { _RELATION_BASIC_UPDATEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "RELATION_BASIC_UPDATE"); _RELATION_BASIC_UPDATEReady = true; } return _RELATION_BASIC_UPDATEContent; } }
        private static Java.Lang.String _RELATION_BASIC_UPDATEContent = default;
        private static bool _RELATION_BASIC_UPDATEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationNotification.html#RELATION_MBEAN_CREATION"/>
        /// </summary>
        public static Java.Lang.String RELATION_MBEAN_CREATION { get { if (!_RELATION_MBEAN_CREATIONReady) { _RELATION_MBEAN_CREATIONContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "RELATION_MBEAN_CREATION"); _RELATION_MBEAN_CREATIONReady = true; } return _RELATION_MBEAN_CREATIONContent; } }
        private static Java.Lang.String _RELATION_MBEAN_CREATIONContent = default;
        private static bool _RELATION_MBEAN_CREATIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationNotification.html#RELATION_MBEAN_REMOVAL"/>
        /// </summary>
        public static Java.Lang.String RELATION_MBEAN_REMOVAL { get { if (!_RELATION_MBEAN_REMOVALReady) { _RELATION_MBEAN_REMOVALContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "RELATION_MBEAN_REMOVAL"); _RELATION_MBEAN_REMOVALReady = true; } return _RELATION_MBEAN_REMOVALContent; } }
        private static Java.Lang.String _RELATION_MBEAN_REMOVALContent = default;
        private static bool _RELATION_MBEAN_REMOVALReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationNotification.html#RELATION_MBEAN_UPDATE"/>
        /// </summary>
        public static Java.Lang.String RELATION_MBEAN_UPDATE { get { if (!_RELATION_MBEAN_UPDATEReady) { _RELATION_MBEAN_UPDATEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "RELATION_MBEAN_UPDATE"); _RELATION_MBEAN_UPDATEReady = true; } return _RELATION_MBEAN_UPDATEContent; } }
        private static Java.Lang.String _RELATION_MBEAN_UPDATEContent = default;
        private static bool _RELATION_MBEAN_UPDATEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationNotification.html#getMBeansToUnregister()"/> 
        /// </summary>
        public Java.Util.List<Javax.Management.ObjectName> MBeansToUnregister
        {
            get { return IExecuteWithSignature<Java.Util.List<Javax.Management.ObjectName>>("getMBeansToUnregister", "()Ljava/util/List;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationNotification.html#getNewRoleValue()"/> 
        /// </summary>
        public Java.Util.List<Javax.Management.ObjectName> NewRoleValue
        {
            get { return IExecuteWithSignature<Java.Util.List<Javax.Management.ObjectName>>("getNewRoleValue", "()Ljava/util/List;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationNotification.html#getObjectName()"/> 
        /// </summary>
        public Javax.Management.ObjectName ObjectName
        {
            get { return IExecuteWithSignature<Javax.Management.ObjectName>("getObjectName", "()Ljavax/management/ObjectName;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationNotification.html#getOldRoleValue()"/> 
        /// </summary>
        public Java.Util.List<Javax.Management.ObjectName> OldRoleValue
        {
            get { return IExecuteWithSignature<Java.Util.List<Javax.Management.ObjectName>>("getOldRoleValue", "()Ljava/util/List;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationNotification.html#getRelationId()"/> 
        /// </summary>
        public Java.Lang.String RelationId
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getRelationId", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationNotification.html#getRelationTypeName()"/> 
        /// </summary>
        public Java.Lang.String RelationTypeName
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getRelationTypeName", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationNotification.html#getRoleName()"/> 
        /// </summary>
        public Java.Lang.String RoleName
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getRoleName", "()Ljava/lang/String;"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}