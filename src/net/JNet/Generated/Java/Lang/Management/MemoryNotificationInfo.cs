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
*  This file is generated by MASES.JNetReflector (ver. 2.2.1.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Lang.Management
{
    #region MemoryNotificationInfo
    public partial class MemoryNotificationInfo
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/MemoryNotificationInfo.html#%3Cinit%3E(java.lang.String,java.lang.management.MemoryUsage,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Management.MemoryUsage"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        public MemoryNotificationInfo(string arg0, Java.Lang.Management.MemoryUsage arg1, long arg2)
            : base(arg0, arg1, arg2)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/MemoryNotificationInfo.html#MEMORY_COLLECTION_THRESHOLD_EXCEEDED"/>
        /// </summary>
        public static string MEMORY_COLLECTION_THRESHOLD_EXCEEDED { get { return SGetField<string>(LocalBridgeClazz, "MEMORY_COLLECTION_THRESHOLD_EXCEEDED"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/MemoryNotificationInfo.html#MEMORY_THRESHOLD_EXCEEDED"/>
        /// </summary>
        public static string MEMORY_THRESHOLD_EXCEEDED { get { return SGetField<string>(LocalBridgeClazz, "MEMORY_THRESHOLD_EXCEEDED"); } }

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/MemoryNotificationInfo.html#from(javax.management.openmbean.CompositeData)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.Openmbean.CompositeData"/></param>
        /// <returns><see cref="Java.Lang.Management.MemoryNotificationInfo"/></returns>
        public static Java.Lang.Management.MemoryNotificationInfo From(Javax.Management.Openmbean.CompositeData arg0)
        {
            return SExecute<Java.Lang.Management.MemoryNotificationInfo>(LocalBridgeClazz, "from", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/MemoryNotificationInfo.html#getCount()"/> 
        /// </summary>
        public long Count
        {
            get { return IExecute<long>("getCount"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/MemoryNotificationInfo.html#getPoolName()"/> 
        /// </summary>
        public string PoolName
        {
            get { return IExecute<string>("getPoolName"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/MemoryNotificationInfo.html#getUsage()"/> 
        /// </summary>
        public Java.Lang.Management.MemoryUsage Usage
        {
            get { return IExecute<Java.Lang.Management.MemoryUsage>("getUsage"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}