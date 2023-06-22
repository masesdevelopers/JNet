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
*  This file is generated by MASES.JNetReflector (ver. 2.0.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Lang.Management
{
    #region IMemoryManagerMXBean
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IMemoryManagerMXBean : Java.Lang.Management.IPlatformManagedObject
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/MemoryManagerMXBean.html#getMemoryPoolNames()"/> 
        /// </summary>
        string[] MemoryPoolNames { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/MemoryManagerMXBean.html#getName()"/> 
        /// </summary>
        string Name { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/MemoryManagerMXBean.html#isValid()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        bool IsValid();

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region MemoryManagerMXBean
    public partial class MemoryManagerMXBean : Java.Lang.Management.IMemoryManagerMXBean
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/MemoryManagerMXBean.html#getMemoryPoolNames()"/> 
        /// </summary>
        public string[] MemoryPoolNames
        {
            get { return IExecuteArray<string>("getMemoryPoolNames"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/MemoryManagerMXBean.html#getName()"/> 
        /// </summary>
        public string Name
        {
            get { return IExecute<string>("getName"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/MemoryManagerMXBean.html#isValid()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsValid()
        {
            return IExecute<bool>("isValid");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}