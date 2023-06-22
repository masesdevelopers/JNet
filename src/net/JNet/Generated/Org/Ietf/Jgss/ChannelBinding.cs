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

namespace Org.Ietf.Jgss
{
    #region ChannelBinding
    public partial class ChannelBinding
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/ChannelBinding.html#%3Cinit%3E(byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        public ChannelBinding(byte[] arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/ChannelBinding.html#%3Cinit%3E(java.net.InetAddress,java.net.InetAddress,byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.InetAddress"/></param>
        /// <param name="arg1"><see cref="Java.Net.InetAddress"/></param>
        /// <param name="arg2"><see cref="byte"/></param>
        public ChannelBinding(Java.Net.InetAddress arg0, Java.Net.InetAddress arg1, byte[] arg2)
            : base(arg0, arg1, arg2)
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/ChannelBinding.html#getAcceptorAddress()"/> 
        /// </summary>
        public Java.Net.InetAddress AcceptorAddress
        {
            get { return IExecute<Java.Net.InetAddress>("getAcceptorAddress"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/ChannelBinding.html#getApplicationData()"/> 
        /// </summary>
        public byte[] ApplicationData
        {
            get { return IExecuteArray<byte>("getApplicationData"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.security.jgss/org/ietf/jgss/ChannelBinding.html#getInitiatorAddress()"/> 
        /// </summary>
        public Java.Net.InetAddress InitiatorAddress
        {
            get { return IExecute<Java.Net.InetAddress>("getInitiatorAddress"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}