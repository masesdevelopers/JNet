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
    #region MBeanServerFactory
    public partial class MBeanServerFactory
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/MBeanServerFactory.html#getClassLoaderRepository(javax.management.MBeanServer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.MBeanServer"/></param>
        /// <returns><see cref="Javax.Management.Loading.ClassLoaderRepository"/></returns>
        public static Javax.Management.Loading.ClassLoaderRepository GetClassLoaderRepository(Javax.Management.MBeanServer arg0)
        {
            return SExecuteWithSignature<Javax.Management.Loading.ClassLoaderRepository>(LocalBridgeClazz, "getClassLoaderRepository", "(Ljavax/management/MBeanServer;)Ljavax/management/loading/ClassLoaderRepository;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/MBeanServerFactory.html#createMBeanServer()"/>
        /// </summary>
        /// <returns><see cref="Javax.Management.MBeanServer"/></returns>
        public static Javax.Management.MBeanServer CreateMBeanServer()
        {
            return SExecuteWithSignature<Javax.Management.MBeanServer>(LocalBridgeClazz, "createMBeanServer", "()Ljavax/management/MBeanServer;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/MBeanServerFactory.html#createMBeanServer(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Management.MBeanServer"/></returns>
        public static Javax.Management.MBeanServer CreateMBeanServer(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Javax.Management.MBeanServer>(LocalBridgeClazz, "createMBeanServer", "(Ljava/lang/String;)Ljavax/management/MBeanServer;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/MBeanServerFactory.html#newMBeanServer()"/>
        /// </summary>
        /// <returns><see cref="Javax.Management.MBeanServer"/></returns>
        public static Javax.Management.MBeanServer NewMBeanServer()
        {
            return SExecuteWithSignature<Javax.Management.MBeanServer>(LocalBridgeClazz, "newMBeanServer", "()Ljavax/management/MBeanServer;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/MBeanServerFactory.html#newMBeanServer(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Management.MBeanServer"/></returns>
        public static Javax.Management.MBeanServer NewMBeanServer(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Javax.Management.MBeanServer>(LocalBridgeClazz, "newMBeanServer", "(Ljava/lang/String;)Ljavax/management/MBeanServer;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/MBeanServerFactory.html#findMBeanServer(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Util.ArrayList"/></returns>
        public static Java.Util.ArrayList<Javax.Management.MBeanServer> FindMBeanServer(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Util.ArrayList<Javax.Management.MBeanServer>>(LocalBridgeClazz, "findMBeanServer", "(Ljava/lang/String;)Ljava/util/ArrayList;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/MBeanServerFactory.html#releaseMBeanServer(javax.management.MBeanServer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.MBeanServer"/></param>
        public static void ReleaseMBeanServer(Javax.Management.MBeanServer arg0)
        {
            SExecuteWithSignature(LocalBridgeClazz, "releaseMBeanServer", "(Ljavax/management/MBeanServer;)V", arg0);
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