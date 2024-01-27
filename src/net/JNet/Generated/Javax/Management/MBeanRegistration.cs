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
*  This file is generated by MASES.JNetReflector (ver. 2.2.4.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Management
{
    #region IMBeanRegistration
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IMBeanRegistration
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/MBeanRegistration.html#preRegister(javax.management.MBeanServer,javax.management.ObjectName)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.MBeanServer"/></param>
        /// <param name="arg1"><see cref="Javax.Management.ObjectName"/></param>
        /// <returns><see cref="Javax.Management.ObjectName"/></returns>
        /// <exception cref="Java.Lang.Exception"/>
        Javax.Management.ObjectName PreRegister(Javax.Management.MBeanServer arg0, Javax.Management.ObjectName arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/MBeanRegistration.html#postDeregister()"/>
        /// </summary>
        void PostDeregister();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/MBeanRegistration.html#postRegister(java.lang.Boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Boolean"/></param>
        void PostRegister(Java.Lang.Boolean arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/MBeanRegistration.html#preDeregister()"/>
        /// </summary>

        /// <exception cref="Java.Lang.Exception"/>
        void PreDeregister();

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region MBeanRegistration
    public partial class MBeanRegistration : Javax.Management.IMBeanRegistration
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/MBeanRegistration.html#preRegister(javax.management.MBeanServer,javax.management.ObjectName)"/>
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/MBeanRegistration.html#postDeregister()"/>
        /// </summary>
        public void PostDeregister()
        {
            IExecute("postDeregister");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/MBeanRegistration.html#postRegister(java.lang.Boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Boolean"/></param>
        public void PostRegister(Java.Lang.Boolean arg0)
        {
            IExecute("postRegister", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/MBeanRegistration.html#preDeregister()"/>
        /// </summary>

        /// <exception cref="Java.Lang.Exception"/>
        public void PreDeregister()
        {
            IExecute("preDeregister");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}