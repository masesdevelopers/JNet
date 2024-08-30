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
*  This file is generated by MASES.JNetReflector (ver. 2.5.8.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Management.Openmbean
{
    #region OpenMBeanParameterInfo definition
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/OpenMBeanParameterInfo.html"/>
    /// </summary>
    public partial class OpenMBeanParameterInfo : MASES.JCOBridge.C2JBridge.JVMBridgeBase<OpenMBeanParameterInfo>
    {
        const string _bridgeClassName = "javax.management.openmbean.OpenMBeanParameterInfo";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("OpenMBeanParameterInfo class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public OpenMBeanParameterInfo() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("OpenMBeanParameterInfo class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public OpenMBeanParameterInfo(params object[] args) : base(args) { }

        private static readonly IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
        /// </summary>
        public override bool IsBridgeCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
        /// </summary>
        public override bool IsBridgeInterface => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region IOpenMBeanParameterInfo
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IOpenMBeanParameterInfo
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/OpenMBeanParameterInfo.html#getDefaultValue()"/> 
        /// </summary>
        object DefaultValue { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/OpenMBeanParameterInfo.html#getDescription()"/> 
        /// </summary>
        Java.Lang.String Description { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/OpenMBeanParameterInfo.html#getLegalValues()"/> 
        /// </summary>
        Java.Util.Set<object> LegalValues { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/OpenMBeanParameterInfo.html#getMaxValue()"/> 
        /// </summary>
        Java.Lang.Comparable<object> MaxValue { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/OpenMBeanParameterInfo.html#getMinValue()"/> 
        /// </summary>
        Java.Lang.Comparable<object> MinValue { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/OpenMBeanParameterInfo.html#getName()"/> 
        /// </summary>
        Java.Lang.String Name { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/OpenMBeanParameterInfo.html#getOpenType()"/> 
        /// </summary>
        Javax.Management.Openmbean.OpenType<object> OpenType { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/OpenMBeanParameterInfo.html#hasDefaultValue()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        bool HasDefaultValue();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/OpenMBeanParameterInfo.html#hasLegalValues()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        bool HasLegalValues();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/OpenMBeanParameterInfo.html#hasMaxValue()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        bool HasMaxValue();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/OpenMBeanParameterInfo.html#hasMinValue()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        bool HasMinValue();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/OpenMBeanParameterInfo.html#isValue(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        bool IsValue(object arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region OpenMBeanParameterInfo
    public partial class OpenMBeanParameterInfo : Javax.Management.Openmbean.IOpenMBeanParameterInfo
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/OpenMBeanParameterInfo.html#getDefaultValue()"/> 
        /// </summary>
        public object DefaultValue
        {
            get { return IExecuteWithSignature("getDefaultValue", "()Ljava/lang/Object;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/OpenMBeanParameterInfo.html#getDescription()"/> 
        /// </summary>
        public Java.Lang.String Description
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getDescription", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/OpenMBeanParameterInfo.html#getLegalValues()"/> 
        /// </summary>
        public Java.Util.Set<object> LegalValues
        {
            get { return IExecuteWithSignature<Java.Util.Set<object>>("getLegalValues", "()Ljava/util/Set;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/OpenMBeanParameterInfo.html#getMaxValue()"/> 
        /// </summary>
        public Java.Lang.Comparable<object> MaxValue
        {
            get { return IExecuteWithSignature<Java.Lang.Comparable<object>>("getMaxValue", "()Ljava/lang/Comparable;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/OpenMBeanParameterInfo.html#getMinValue()"/> 
        /// </summary>
        public Java.Lang.Comparable<object> MinValue
        {
            get { return IExecuteWithSignature<Java.Lang.Comparable<object>>("getMinValue", "()Ljava/lang/Comparable;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/OpenMBeanParameterInfo.html#getName()"/> 
        /// </summary>
        public Java.Lang.String Name
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getName", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/OpenMBeanParameterInfo.html#getOpenType()"/> 
        /// </summary>
        public Javax.Management.Openmbean.OpenType<object> OpenType
        {
            get { return IExecuteWithSignature<Javax.Management.Openmbean.OpenType<object>>("getOpenType", "()Ljavax/management/openmbean/OpenType;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/OpenMBeanParameterInfo.html#hasDefaultValue()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasDefaultValue()
        {
            return IExecuteWithSignature<bool>("hasDefaultValue", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/OpenMBeanParameterInfo.html#hasLegalValues()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasLegalValues()
        {
            return IExecuteWithSignature<bool>("hasLegalValues", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/OpenMBeanParameterInfo.html#hasMaxValue()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasMaxValue()
        {
            return IExecuteWithSignature<bool>("hasMaxValue", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/OpenMBeanParameterInfo.html#hasMinValue()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasMinValue()
        {
            return IExecuteWithSignature<bool>("hasMinValue", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/OpenMBeanParameterInfo.html#isValue(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsValue(object arg0)
        {
            return IExecuteWithSignature<bool>("isValue", "(Ljava/lang/Object;)Z", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}