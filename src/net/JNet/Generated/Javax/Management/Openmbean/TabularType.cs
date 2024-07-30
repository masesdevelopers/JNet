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
*  This file is generated by MASES.JNetReflector (ver. 2.5.7.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Management.Openmbean
{
    #region TabularType
    public partial class TabularType
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/TabularType.html#%3Cinit%3E(java.lang.String,java.lang.String,javax.management.openmbean.CompositeType,java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Javax.Management.Openmbean.CompositeType"/></param>
        /// <param name="arg3"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Javax.Management.Openmbean.OpenDataException"/>
        public TabularType(Java.Lang.String arg0, Java.Lang.String arg1, Javax.Management.Openmbean.CompositeType arg2, Java.Lang.String[] arg3)
            : base(arg0, arg1, arg2, arg3)
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/TabularType.html#getIndexNames()"/> 
        /// </summary>
        public Java.Util.List<Java.Lang.String> IndexNames
        {
            get { return IExecuteWithSignature<Java.Util.List<Java.Lang.String>>("getIndexNames", "()Ljava/util/List;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/openmbean/TabularType.html#getRowType()"/> 
        /// </summary>
        public Javax.Management.Openmbean.CompositeType RowType
        {
            get { return IExecuteWithSignature<Javax.Management.Openmbean.CompositeType>("getRowType", "()Ljavax/management/openmbean/CompositeType;"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}