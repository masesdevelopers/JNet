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

namespace Java.Rmi.Server
{
    #region IRMIFailureHandler
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IRMIFailureHandler
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/server/RMIFailureHandler.html#failure(java.lang.Exception)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Exception"/></param>
        /// <returns><see cref="bool"/></returns>
        bool Failure(MASES.JCOBridge.C2JBridge.JVMBridgeException arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region RMIFailureHandler
    public partial class RMIFailureHandler : Java.Rmi.Server.IRMIFailureHandler
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/server/RMIFailureHandler.html#failure(java.lang.Exception)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Exception"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Failure(MASES.JCOBridge.C2JBridge.JVMBridgeException arg0)
        {
            return IExecuteWithSignature<bool>("failure", "(Ljava/lang/Exception;)Z", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}