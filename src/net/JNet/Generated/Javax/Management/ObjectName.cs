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

namespace Javax.Management
{
    #region ObjectName
    public partial class ObjectName
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/ObjectName.html#%3Cinit%3E(java.lang.String,java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Javax.Management.MalformedObjectNameException"/>
        public ObjectName(Java.Lang.String arg0, Java.Lang.String arg1, Java.Lang.String arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/ObjectName.html#%3Cinit%3E(java.lang.String,java.util.Hashtable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Util.Hashtable"/></param>
        /// <exception cref="Javax.Management.MalformedObjectNameException"/>
        public ObjectName(Java.Lang.String arg0, Java.Util.Hashtable<Java.Lang.String, Java.Lang.String> arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/ObjectName.html#%3Cinit%3E(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Javax.Management.MalformedObjectNameException"/>
        public ObjectName(Java.Lang.String arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Management.ObjectName"/> to <see cref="Java.Lang.Comparable"/>
        /// </summary>
        public static implicit operator Java.Lang.Comparable(Javax.Management.ObjectName t) => t.Cast<Java.Lang.Comparable>();
        /// <summary>
        /// Converter from <see cref="Javax.Management.ObjectName"/> to <see cref="Javax.Management.QueryExp"/>
        /// </summary>
        public static implicit operator Javax.Management.QueryExp(Javax.Management.ObjectName t) => t.Cast<Javax.Management.QueryExp>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/ObjectName.html#WILDCARD"/>
        /// </summary>
        public static Javax.Management.ObjectName WILDCARD { get { if (!_WILDCARDReady) { _WILDCARDContent = SGetField<Javax.Management.ObjectName>(LocalBridgeClazz, "WILDCARD"); _WILDCARDReady = true; } return _WILDCARDContent; } }
        private static Javax.Management.ObjectName _WILDCARDContent = default;
        private static bool _WILDCARDReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/ObjectName.html#quote(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String Quote(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Lang.String>(LocalBridgeClazz, "quote", "(Ljava/lang/String;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/ObjectName.html#unquote(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String Unquote(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Lang.String>(LocalBridgeClazz, "unquote", "(Ljava/lang/String;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/ObjectName.html#getInstance(java.lang.String,java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Management.ObjectName"/></returns>
        /// <exception cref="Javax.Management.MalformedObjectNameException"/>
        public static Javax.Management.ObjectName GetInstance(Java.Lang.String arg0, Java.Lang.String arg1, Java.Lang.String arg2)
        {
            return SExecute<Javax.Management.ObjectName>(LocalBridgeClazz, "getInstance", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/ObjectName.html#getInstance(java.lang.String,java.util.Hashtable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Util.Hashtable"/></param>
        /// <returns><see cref="Javax.Management.ObjectName"/></returns>
        /// <exception cref="Javax.Management.MalformedObjectNameException"/>
        public static Javax.Management.ObjectName GetInstance(Java.Lang.String arg0, Java.Util.Hashtable<Java.Lang.String, Java.Lang.String> arg1)
        {
            return SExecute<Javax.Management.ObjectName>(LocalBridgeClazz, "getInstance", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/ObjectName.html#getInstance(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Management.ObjectName"/></returns>
        /// <exception cref="Javax.Management.MalformedObjectNameException"/>
        /// <exception cref="Java.Lang.NullPointerException"/>
        public static Javax.Management.ObjectName GetInstance(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Javax.Management.ObjectName>(LocalBridgeClazz, "getInstance", "(Ljava/lang/String;)Ljavax/management/ObjectName;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/ObjectName.html#getInstance(javax.management.ObjectName)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.ObjectName"/></param>
        /// <returns><see cref="Javax.Management.ObjectName"/></returns>
        public static Javax.Management.ObjectName GetInstance(Javax.Management.ObjectName arg0)
        {
            return SExecuteWithSignature<Javax.Management.ObjectName>(LocalBridgeClazz, "getInstance", "(Ljavax/management/ObjectName;)Ljavax/management/ObjectName;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/ObjectName.html#getCanonicalKeyPropertyListString()"/> 
        /// </summary>
        public Java.Lang.String CanonicalKeyPropertyListString
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getCanonicalKeyPropertyListString", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/ObjectName.html#getCanonicalName()"/> 
        /// </summary>
        public Java.Lang.String CanonicalName
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getCanonicalName", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/ObjectName.html#getDomain()"/> 
        /// </summary>
        public Java.Lang.String Domain
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getDomain", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/ObjectName.html#getKeyPropertyList()"/> 
        /// </summary>
        public Java.Util.Hashtable<Java.Lang.String, Java.Lang.String> KeyPropertyList
        {
            get { return IExecuteWithSignature<Java.Util.Hashtable<Java.Lang.String, Java.Lang.String>>("getKeyPropertyList", "()Ljava/util/Hashtable;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/ObjectName.html#getKeyPropertyListString()"/> 
        /// </summary>
        public Java.Lang.String KeyPropertyListString
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getKeyPropertyListString", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/ObjectName.html#apply(javax.management.ObjectName)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.ObjectName"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Apply(Javax.Management.ObjectName arg0)
        {
            return IExecuteWithSignature<bool>("apply", "(Ljavax/management/ObjectName;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/ObjectName.html#isDomainPattern()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsDomainPattern()
        {
            return IExecuteWithSignature<bool>("isDomainPattern", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/ObjectName.html#isPattern()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsPattern()
        {
            return IExecuteWithSignature<bool>("isPattern", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/ObjectName.html#isPropertyListPattern()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsPropertyListPattern()
        {
            return IExecuteWithSignature<bool>("isPropertyListPattern", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/ObjectName.html#isPropertyPattern()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsPropertyPattern()
        {
            return IExecuteWithSignature<bool>("isPropertyPattern", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/ObjectName.html#isPropertyValuePattern()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsPropertyValuePattern()
        {
            return IExecuteWithSignature<bool>("isPropertyValuePattern", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/ObjectName.html#isPropertyValuePattern(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsPropertyValuePattern(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<bool>("isPropertyValuePattern", "(Ljava/lang/String;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/ObjectName.html#compareTo(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="int"/></returns>
        public int CompareTo(object arg0)
        {
            return IExecuteWithSignature<int>("compareTo", "(Ljava/lang/Object;)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/ObjectName.html#compareTo(javax.management.ObjectName)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.ObjectName"/></param>
        /// <returns><see cref="int"/></returns>
        public int CompareTo(Javax.Management.ObjectName arg0)
        {
            return IExecuteWithSignature<int>("compareTo", "(Ljavax/management/ObjectName;)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/ObjectName.html#getKeyProperty(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetKeyProperty(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("getKeyProperty", "(Ljava/lang/String;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/ObjectName.html#setMBeanServer(javax.management.MBeanServer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.MBeanServer"/></param>
        public void SetMBeanServer(Javax.Management.MBeanServer arg0)
        {
            IExecuteWithSignature("setMBeanServer", "(Ljavax/management/MBeanServer;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}