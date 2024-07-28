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
*  This file is generated by MASES.JNetReflector (ver. 2.5.6.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Management.Modelmbean
{
    #region ModelMBeanInfoSupport
    public partial class ModelMBeanInfoSupport
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/modelmbean/ModelMBeanInfoSupport.html#%3Cinit%3E(java.lang.String,java.lang.String,javax.management.modelmbean.ModelMBeanAttributeInfo[],javax.management.modelmbean.ModelMBeanConstructorInfo[],javax.management.modelmbean.ModelMBeanOperationInfo[],javax.management.modelmbean.ModelMBeanNotificationInfo[],javax.management.Descriptor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Javax.Management.Modelmbean.ModelMBeanAttributeInfo"/></param>
        /// <param name="arg3"><see cref="Javax.Management.Modelmbean.ModelMBeanConstructorInfo"/></param>
        /// <param name="arg4"><see cref="Javax.Management.Modelmbean.ModelMBeanOperationInfo"/></param>
        /// <param name="arg5"><see cref="Javax.Management.Modelmbean.ModelMBeanNotificationInfo"/></param>
        /// <param name="arg6"><see cref="Javax.Management.Descriptor"/></param>
        public ModelMBeanInfoSupport(Java.Lang.String arg0, Java.Lang.String arg1, Javax.Management.Modelmbean.ModelMBeanAttributeInfo[] arg2, Javax.Management.Modelmbean.ModelMBeanConstructorInfo[] arg3, Javax.Management.Modelmbean.ModelMBeanOperationInfo[] arg4, Javax.Management.Modelmbean.ModelMBeanNotificationInfo[] arg5, Javax.Management.Descriptor arg6)
            : base(arg0, arg1, arg2, arg3, arg4, arg5, arg6)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/modelmbean/ModelMBeanInfoSupport.html#%3Cinit%3E(java.lang.String,java.lang.String,javax.management.modelmbean.ModelMBeanAttributeInfo[],javax.management.modelmbean.ModelMBeanConstructorInfo[],javax.management.modelmbean.ModelMBeanOperationInfo[],javax.management.modelmbean.ModelMBeanNotificationInfo[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Javax.Management.Modelmbean.ModelMBeanAttributeInfo"/></param>
        /// <param name="arg3"><see cref="Javax.Management.Modelmbean.ModelMBeanConstructorInfo"/></param>
        /// <param name="arg4"><see cref="Javax.Management.Modelmbean.ModelMBeanOperationInfo"/></param>
        /// <param name="arg5"><see cref="Javax.Management.Modelmbean.ModelMBeanNotificationInfo"/></param>
        public ModelMBeanInfoSupport(Java.Lang.String arg0, Java.Lang.String arg1, Javax.Management.Modelmbean.ModelMBeanAttributeInfo[] arg2, Javax.Management.Modelmbean.ModelMBeanConstructorInfo[] arg3, Javax.Management.Modelmbean.ModelMBeanOperationInfo[] arg4, Javax.Management.Modelmbean.ModelMBeanNotificationInfo[] arg5)
            : base(arg0, arg1, arg2, arg3, arg4, arg5)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/modelmbean/ModelMBeanInfoSupport.html#%3Cinit%3E(javax.management.modelmbean.ModelMBeanInfo)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.Modelmbean.ModelMBeanInfo"/></param>
        public ModelMBeanInfoSupport(Javax.Management.Modelmbean.ModelMBeanInfo arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Management.Modelmbean.ModelMBeanInfoSupport"/> to <see cref="Javax.Management.Modelmbean.ModelMBeanInfo"/>
        /// </summary>
        public static implicit operator Javax.Management.Modelmbean.ModelMBeanInfo(Javax.Management.Modelmbean.ModelMBeanInfoSupport t) => t.Cast<Javax.Management.Modelmbean.ModelMBeanInfo>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/modelmbean/ModelMBeanInfoSupport.html#getMBeanDescriptor()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/modelmbean/ModelMBeanInfoSupport.html#setMBeanDescriptor(javax.management.Descriptor)"/>
        /// </summary>
        public Javax.Management.Descriptor MBeanDescriptor
        {
            get { return IExecuteWithSignature<Javax.Management.Descriptor>("getMBeanDescriptor", "()Ljavax/management/Descriptor;"); } set { IExecuteWithSignature("setMBeanDescriptor", "(Ljavax/management/Descriptor;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/modelmbean/ModelMBeanInfoSupport.html#getDescriptor(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Management.Descriptor"/></returns>
        /// <exception cref="Javax.Management.MBeanException"/>
        /// <exception cref="Javax.Management.RuntimeOperationsException"/>
        public Javax.Management.Descriptor GetDescriptor(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            return IExecute<Javax.Management.Descriptor>("getDescriptor", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/modelmbean/ModelMBeanInfoSupport.html#getDescriptor(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Management.Descriptor"/></returns>
        /// <exception cref="Javax.Management.MBeanException"/>
        /// <exception cref="Javax.Management.RuntimeOperationsException"/>
        public Javax.Management.Descriptor GetDescriptor(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Javax.Management.Descriptor>("getDescriptor", "(Ljava/lang/String;)Ljavax/management/Descriptor;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/modelmbean/ModelMBeanInfoSupport.html#getDescriptors(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Management.Descriptor"/></returns>
        /// <exception cref="Javax.Management.MBeanException"/>
        /// <exception cref="Javax.Management.RuntimeOperationsException"/>
        public Javax.Management.Descriptor[] GetDescriptors(Java.Lang.String arg0)
        {
            return IExecuteWithSignatureArray<Javax.Management.Descriptor>("getDescriptors", "(Ljava/lang/String;)[Ljavax/management/Descriptor;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/modelmbean/ModelMBeanInfoSupport.html#getAttribute(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Management.Modelmbean.ModelMBeanAttributeInfo"/></returns>
        /// <exception cref="Javax.Management.MBeanException"/>
        /// <exception cref="Javax.Management.RuntimeOperationsException"/>
        public Javax.Management.Modelmbean.ModelMBeanAttributeInfo GetAttribute(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Javax.Management.Modelmbean.ModelMBeanAttributeInfo>("getAttribute", "(Ljava/lang/String;)Ljavax/management/modelmbean/ModelMBeanAttributeInfo;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/modelmbean/ModelMBeanInfoSupport.html#getConstructor(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Management.Modelmbean.ModelMBeanConstructorInfo"/></returns>
        /// <exception cref="Javax.Management.MBeanException"/>
        /// <exception cref="Javax.Management.RuntimeOperationsException"/>
        public Javax.Management.Modelmbean.ModelMBeanConstructorInfo GetConstructor(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Javax.Management.Modelmbean.ModelMBeanConstructorInfo>("getConstructor", "(Ljava/lang/String;)Ljavax/management/modelmbean/ModelMBeanConstructorInfo;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/modelmbean/ModelMBeanInfoSupport.html#getNotification(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Management.Modelmbean.ModelMBeanNotificationInfo"/></returns>
        /// <exception cref="Javax.Management.MBeanException"/>
        /// <exception cref="Javax.Management.RuntimeOperationsException"/>
        public Javax.Management.Modelmbean.ModelMBeanNotificationInfo GetNotification(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Javax.Management.Modelmbean.ModelMBeanNotificationInfo>("getNotification", "(Ljava/lang/String;)Ljavax/management/modelmbean/ModelMBeanNotificationInfo;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/modelmbean/ModelMBeanInfoSupport.html#getOperation(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Management.Modelmbean.ModelMBeanOperationInfo"/></returns>
        /// <exception cref="Javax.Management.MBeanException"/>
        /// <exception cref="Javax.Management.RuntimeOperationsException"/>
        public Javax.Management.Modelmbean.ModelMBeanOperationInfo GetOperation(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Javax.Management.Modelmbean.ModelMBeanOperationInfo>("getOperation", "(Ljava/lang/String;)Ljavax/management/modelmbean/ModelMBeanOperationInfo;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/modelmbean/ModelMBeanInfoSupport.html#setDescriptor(javax.management.Descriptor,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.Descriptor"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Javax.Management.MBeanException"/>
        /// <exception cref="Javax.Management.RuntimeOperationsException"/>
        public void SetDescriptor(Javax.Management.Descriptor arg0, Java.Lang.String arg1)
        {
            IExecute("setDescriptor", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/modelmbean/ModelMBeanInfoSupport.html#setDescriptors(javax.management.Descriptor[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.Descriptor"/></param>
        /// <exception cref="Javax.Management.MBeanException"/>
        /// <exception cref="Javax.Management.RuntimeOperationsException"/>
        public void SetDescriptors(Javax.Management.Descriptor[] arg0)
        {
            IExecuteWithSignature("setDescriptors", "([Ljavax/management/Descriptor;)V", new object[] { arg0 });
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}