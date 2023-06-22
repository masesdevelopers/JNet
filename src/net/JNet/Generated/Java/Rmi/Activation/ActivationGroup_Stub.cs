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

namespace Java.Rmi.Activation
{
    #region ActivationGroup_Stub
    public partial class ActivationGroup_Stub
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/activation/ActivationGroup_Stub.html#%3Cinit%3E(java.rmi.server.RemoteRef)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Rmi.Server.RemoteRef"/></param>
        public ActivationGroup_Stub(Java.Rmi.Server.RemoteRef arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Rmi.Activation.ActivationGroup_Stub"/> to <see cref="Java.Rmi.Activation.ActivationInstantiator"/>
        /// </summary>
        public static implicit operator Java.Rmi.Activation.ActivationInstantiator(Java.Rmi.Activation.ActivationGroup_Stub t) => t.Cast<Java.Rmi.Activation.ActivationInstantiator>();
        /// <summary>
        /// Converter from <see cref="Java.Rmi.Activation.ActivationGroup_Stub"/> to <see cref="Java.Rmi.Remote"/>
        /// </summary>
        public static implicit operator Java.Rmi.Remote(Java.Rmi.Activation.ActivationGroup_Stub t) => t.Cast<Java.Rmi.Remote>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/activation/ActivationGroup_Stub.html#newInstance(java.rmi.activation.ActivationID,java.rmi.activation.ActivationDesc)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Rmi.Activation.ActivationID"/></param>
        /// <param name="arg1"><see cref="Java.Rmi.Activation.ActivationDesc"/></param>
        /// <returns><see cref="Java.Rmi.MarshalledObject"/></returns>
        /// <exception cref="Java.Rmi.RemoteException"/>
        /// <exception cref="Java.Rmi.Activation.ActivationException"/>
        public Java.Rmi.MarshalledObject NewInstance(Java.Rmi.Activation.ActivationID arg0, Java.Rmi.Activation.ActivationDesc arg1)
        {
            return IExecute<Java.Rmi.MarshalledObject>("newInstance", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}