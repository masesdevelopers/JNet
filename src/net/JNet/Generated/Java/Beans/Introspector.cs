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

namespace Java.Beans
{
    #region Introspector
    public partial class Introspector
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/Introspector.html#IGNORE_ALL_BEANINFO"/>
        /// </summary>
        public static int IGNORE_ALL_BEANINFO { get { if (!_IGNORE_ALL_BEANINFOReady) { _IGNORE_ALL_BEANINFOContent = SGetField<int>(LocalBridgeClazz, "IGNORE_ALL_BEANINFO"); _IGNORE_ALL_BEANINFOReady = true; } return _IGNORE_ALL_BEANINFOContent; } }
        private static int _IGNORE_ALL_BEANINFOContent = default;
        private static bool _IGNORE_ALL_BEANINFOReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/Introspector.html#IGNORE_IMMEDIATE_BEANINFO"/>
        /// </summary>
        public static int IGNORE_IMMEDIATE_BEANINFO { get { if (!_IGNORE_IMMEDIATE_BEANINFOReady) { _IGNORE_IMMEDIATE_BEANINFOContent = SGetField<int>(LocalBridgeClazz, "IGNORE_IMMEDIATE_BEANINFO"); _IGNORE_IMMEDIATE_BEANINFOReady = true; } return _IGNORE_IMMEDIATE_BEANINFOContent; } }
        private static int _IGNORE_IMMEDIATE_BEANINFOContent = default;
        private static bool _IGNORE_IMMEDIATE_BEANINFOReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/Introspector.html#USE_ALL_BEANINFO"/>
        /// </summary>
        public static int USE_ALL_BEANINFO { get { if (!_USE_ALL_BEANINFOReady) { _USE_ALL_BEANINFOContent = SGetField<int>(LocalBridgeClazz, "USE_ALL_BEANINFO"); _USE_ALL_BEANINFOReady = true; } return _USE_ALL_BEANINFOContent; } }
        private static int _USE_ALL_BEANINFOContent = default;
        private static bool _USE_ALL_BEANINFOReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/Introspector.html#getBeanInfoSearchPath()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/Introspector.html#setBeanInfoSearchPath(java.lang.String[])"/>
        /// </summary>
        public static Java.Lang.String[] BeanInfoSearchPath
        {
            get { return SExecuteWithSignatureArray<Java.Lang.String>(LocalBridgeClazz, "getBeanInfoSearchPath", "()[Ljava/lang/String;"); } set { SExecuteWithSignature(LocalBridgeClazz, "setBeanInfoSearchPath", "([Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/Introspector.html#getBeanInfo(java.lang.Class,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Beans.BeanInfo"/></returns>
        /// <exception cref="Java.Beans.IntrospectionException"/>
        public static Java.Beans.BeanInfo GetBeanInfo(Java.Lang.Class arg0, int arg1)
        {
            return SExecute<Java.Beans.BeanInfo>(LocalBridgeClazz, "getBeanInfo", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/Introspector.html#getBeanInfo(java.lang.Class,java.lang.Class,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Class"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Java.Beans.BeanInfo"/></returns>
        /// <exception cref="Java.Beans.IntrospectionException"/>
        public static Java.Beans.BeanInfo GetBeanInfo(Java.Lang.Class arg0, Java.Lang.Class arg1, int arg2)
        {
            return SExecute<Java.Beans.BeanInfo>(LocalBridgeClazz, "getBeanInfo", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/Introspector.html#getBeanInfo(java.lang.Class,java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Class"/></param>
        /// <returns><see cref="Java.Beans.BeanInfo"/></returns>
        /// <exception cref="Java.Beans.IntrospectionException"/>
        public static Java.Beans.BeanInfo GetBeanInfo(Java.Lang.Class arg0, Java.Lang.Class arg1)
        {
            return SExecute<Java.Beans.BeanInfo>(LocalBridgeClazz, "getBeanInfo", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/Introspector.html#getBeanInfo(java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <returns><see cref="Java.Beans.BeanInfo"/></returns>
        /// <exception cref="Java.Beans.IntrospectionException"/>
        public static Java.Beans.BeanInfo GetBeanInfo(Java.Lang.Class arg0)
        {
            return SExecuteWithSignature<Java.Beans.BeanInfo>(LocalBridgeClazz, "getBeanInfo", "(Ljava/lang/Class;)Ljava/beans/BeanInfo;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/Introspector.html#decapitalize(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String Decapitalize(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Lang.String>(LocalBridgeClazz, "decapitalize", "(Ljava/lang/String;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/Introspector.html#flushCaches()"/>
        /// </summary>
        public static void FlushCaches()
        {
            SExecuteWithSignature(LocalBridgeClazz, "flushCaches", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/Introspector.html#flushFromCaches(java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        public static void FlushFromCaches(Java.Lang.Class arg0)
        {
            SExecuteWithSignature(LocalBridgeClazz, "flushFromCaches", "(Ljava/lang/Class;)V", arg0);
        }

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}