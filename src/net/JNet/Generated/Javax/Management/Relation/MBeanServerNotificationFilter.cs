/*
*  Copyright 2023 MASES s.r.l.
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
*  This file is generated by MASES.JNetReflector (ver. 1.5.4.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Management.Relation
{
    #region MBeanServerNotificationFilter
    public partial class MBeanServerNotificationFilter
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/MBeanServerNotificationFilter.html#getDisabledObjectNames()"/> 
        /// </summary>
        public Java.Util.Vector<Javax.Management.ObjectName> DisabledObjectNames
        {
            get { return IExecute<Java.Util.Vector<Javax.Management.ObjectName>>("getDisabledObjectNames"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/MBeanServerNotificationFilter.html#getEnabledObjectNames()"/> 
        /// </summary>
        public Java.Util.Vector<Javax.Management.ObjectName> EnabledObjectNames
        {
            get { return IExecute<Java.Util.Vector<Javax.Management.ObjectName>>("getEnabledObjectNames"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/MBeanServerNotificationFilter.html#disableAllObjectNames()"/>
        /// </summary>
        public void DisableAllObjectNames()
        {
            IExecute("disableAllObjectNames");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/MBeanServerNotificationFilter.html#disableObjectName(javax.management.ObjectName)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.ObjectName"/></param>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        public void DisableObjectName(Javax.Management.ObjectName arg0)
        {
            IExecute("disableObjectName", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/MBeanServerNotificationFilter.html#enableAllObjectNames()"/>
        /// </summary>
        public void EnableAllObjectNames()
        {
            IExecute("enableAllObjectNames");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/MBeanServerNotificationFilter.html#enableObjectName(javax.management.ObjectName)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.ObjectName"/></param>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        public void EnableObjectName(Javax.Management.ObjectName arg0)
        {
            IExecute("enableObjectName", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}