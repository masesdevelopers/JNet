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

namespace Java.Nio.Channels
{
    #region IMulticastChannel
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IMulticastChannel : Java.Nio.Channels.INetworkChannel
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/MulticastChannel.html#join(java.net.InetAddress,java.net.NetworkInterface,java.net.InetAddress)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.InetAddress"/></param>
        /// <param name="arg1"><see cref="Java.Net.NetworkInterface"/></param>
        /// <param name="arg2"><see cref="Java.Net.InetAddress"/></param>
        /// <returns><see cref="Java.Nio.Channels.MembershipKey"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        Java.Nio.Channels.MembershipKey Join(Java.Net.InetAddress arg0, Java.Net.NetworkInterface arg1, Java.Net.InetAddress arg2);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/MulticastChannel.html#join(java.net.InetAddress,java.net.NetworkInterface)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.InetAddress"/></param>
        /// <param name="arg1"><see cref="Java.Net.NetworkInterface"/></param>
        /// <returns><see cref="Java.Nio.Channels.MembershipKey"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        Java.Nio.Channels.MembershipKey Join(Java.Net.InetAddress arg0, Java.Net.NetworkInterface arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/MulticastChannel.html#close()"/>
        /// </summary>
        /// <exception cref="Java.Io.IOException"/>
        void Close();

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region MulticastChannel
    public partial class MulticastChannel : Java.Nio.Channels.IMulticastChannel
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/MulticastChannel.html#join(java.net.InetAddress,java.net.NetworkInterface,java.net.InetAddress)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.InetAddress"/></param>
        /// <param name="arg1"><see cref="Java.Net.NetworkInterface"/></param>
        /// <param name="arg2"><see cref="Java.Net.InetAddress"/></param>
        /// <returns><see cref="Java.Nio.Channels.MembershipKey"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Nio.Channels.MembershipKey Join(Java.Net.InetAddress arg0, Java.Net.NetworkInterface arg1, Java.Net.InetAddress arg2)
        {
            return IExecute<Java.Nio.Channels.MembershipKey>("join", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/MulticastChannel.html#join(java.net.InetAddress,java.net.NetworkInterface)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.InetAddress"/></param>
        /// <param name="arg1"><see cref="Java.Net.NetworkInterface"/></param>
        /// <returns><see cref="Java.Nio.Channels.MembershipKey"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Nio.Channels.MembershipKey Join(Java.Net.InetAddress arg0, Java.Net.NetworkInterface arg1)
        {
            return IExecute<Java.Nio.Channels.MembershipKey>("join", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/MulticastChannel.html#close()"/>
        /// </summary>
        /// <exception cref="Java.Io.IOException"/>
        public void Close()
        {
            IExecuteWithSignature("close", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}