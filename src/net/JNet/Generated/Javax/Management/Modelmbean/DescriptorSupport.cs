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

namespace Javax.Management.Modelmbean
{
    #region DescriptorSupport
    public partial class DescriptorSupport
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/modelmbean/DescriptorSupport.html#%3Cinit%3E(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <exception cref="Javax.Management.MBeanException"/>
        /// <exception cref="Javax.Management.RuntimeOperationsException"/>
        public DescriptorSupport(int arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/modelmbean/DescriptorSupport.html#%3Cinit%3E(java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public DescriptorSupport(params Java.Lang.String[] arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/modelmbean/DescriptorSupport.html#%3Cinit%3E(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Javax.Management.MBeanException"/>
        /// <exception cref="Javax.Management.RuntimeOperationsException"/>
        /// <exception cref="Javax.Management.Modelmbean.XMLParseException"/>
        public DescriptorSupport(Java.Lang.String arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/modelmbean/DescriptorSupport.html#%3Cinit%3E(javax.management.modelmbean.DescriptorSupport)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.Modelmbean.DescriptorSupport"/></param>
        public DescriptorSupport(Javax.Management.Modelmbean.DescriptorSupport arg0)
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/modelmbean/DescriptorSupport.html#getFieldNames()"/> 
        /// </summary>
        public Java.Lang.String[] FieldNames
        {
            get { return IExecuteWithSignatureArray<Java.Lang.String>("getFieldNames", "()[Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/modelmbean/DescriptorSupport.html#getFields()"/> 
        /// </summary>
        public Java.Lang.String[] Fields
        {
            get { return IExecuteWithSignatureArray<Java.Lang.String>("getFields", "()[Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/modelmbean/DescriptorSupport.html#isValid()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Javax.Management.RuntimeOperationsException"/>
        public bool IsValid()
        {
            return IExecuteWithSignature<bool>("isValid", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/modelmbean/DescriptorSupport.html#getFieldValue(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Javax.Management.RuntimeOperationsException"/>
        public object GetFieldValue(Java.Lang.String arg0)
        {
            return IExecuteWithSignature("getFieldValue", "(Ljava/lang/String;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/modelmbean/DescriptorSupport.html#getFieldValues(java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="object"/></returns>
        public object[] GetFieldValues(params Java.Lang.String[] arg0)
        {
            if (arg0.Length == 0) return IExecuteWithSignatureArray<object>("getFieldValues", "([Ljava/lang/String;)[Ljava/lang/Object;"); else return IExecuteWithSignatureArray<object>("getFieldValues", "([Ljava/lang/String;)[Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/modelmbean/DescriptorSupport.html#toXMLString()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String ToXMLString()
        {
            return IExecuteWithSignature<Java.Lang.String>("toXMLString", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/modelmbean/DescriptorSupport.html#removeField(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void RemoveField(Java.Lang.String arg0)
        {
            IExecuteWithSignature("removeField", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/modelmbean/DescriptorSupport.html#setField(java.lang.String,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <exception cref="Javax.Management.RuntimeOperationsException"/>
        public void SetField(Java.Lang.String arg0, object arg1)
        {
            IExecute("setField", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/modelmbean/DescriptorSupport.html#setFields(java.lang.String[],java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <exception cref="Javax.Management.RuntimeOperationsException"/>
        public void SetFields(Java.Lang.String[] arg0, object[] arg1)
        {
            IExecute("setFields", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}