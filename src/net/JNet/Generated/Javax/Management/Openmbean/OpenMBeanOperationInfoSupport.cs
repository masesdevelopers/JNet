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
*  This file is generated by MASES.JNetReflector (ver. 1.5.5.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Management.Openmbean
{
    #region OpenMBeanOperationInfoSupport
    public partial class OpenMBeanOperationInfoSupport
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/OpenMBeanOperationInfoSupport.html#%3Cinit%3E(java.lang.String,java.lang.String,javax.management.openmbean.OpenMBeanParameterInfo[],javax.management.openmbean.OpenType,int,javax.management.Descriptor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="Javax.Management.Openmbean.OpenMBeanParameterInfo"/></param>
        /// <param name="arg3"><see cref="Javax.Management.Openmbean.OpenType"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="Javax.Management.Descriptor"/></param>
        public OpenMBeanOperationInfoSupport(string arg0, string arg1, Javax.Management.Openmbean.OpenMBeanParameterInfo[] arg2, Javax.Management.Openmbean.OpenType arg3, int arg4, Javax.Management.Descriptor arg5)
            : base(arg0, arg1, arg2, arg3, arg4, arg5)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/OpenMBeanOperationInfoSupport.html#%3Cinit%3E(java.lang.String,java.lang.String,javax.management.openmbean.OpenMBeanParameterInfo[],javax.management.openmbean.OpenType,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="Javax.Management.Openmbean.OpenMBeanParameterInfo"/></param>
        /// <param name="arg3"><see cref="Javax.Management.Openmbean.OpenType"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        public OpenMBeanOperationInfoSupport(string arg0, string arg1, Javax.Management.Openmbean.OpenMBeanParameterInfo[] arg2, Javax.Management.Openmbean.OpenType arg3, int arg4)
            : base(arg0, arg1, arg2, arg3, arg4)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Management.Openmbean.OpenMBeanOperationInfoSupport"/> to <see cref="Javax.Management.Openmbean.OpenMBeanOperationInfo"/>
        /// </summary>
        public static implicit operator Javax.Management.Openmbean.OpenMBeanOperationInfo(Javax.Management.Openmbean.OpenMBeanOperationInfoSupport t) => t.Cast<Javax.Management.Openmbean.OpenMBeanOperationInfo>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/OpenMBeanOperationInfoSupport.html#getReturnOpenType()"/> 
        /// </summary>
        public Javax.Management.Openmbean.OpenType ReturnOpenType
        {
            get { return IExecute<Javax.Management.Openmbean.OpenType>("getReturnOpenType"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}