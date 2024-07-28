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
*  This file is generated by MASES.JNetReflector (ver. 2.5.6.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Rmi
{
    #region Naming
    public partial class Naming
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/Naming.html#list(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        /// <exception cref="Java.Rmi.RemoteException"/>
        /// <exception cref="Java.Net.MalformedURLException"/>
        public static Java.Lang.String[] List(Java.Lang.String arg0)
        {
            return SExecuteWithSignatureArray<Java.Lang.String>(LocalBridgeClazz, "list", "(Ljava/lang/String;)[Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/Naming.html#lookup(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Rmi.Remote"/></returns>
        /// <exception cref="Java.Rmi.NotBoundException"/>
        /// <exception cref="Java.Net.MalformedURLException"/>
        /// <exception cref="Java.Rmi.RemoteException"/>
        public static Java.Rmi.Remote Lookup(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Rmi.Remote>(LocalBridgeClazz, "lookup", "(Ljava/lang/String;)Ljava/rmi/Remote;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/Naming.html#bind(java.lang.String,java.rmi.Remote)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Rmi.Remote"/></param>
        /// <exception cref="Java.Rmi.AlreadyBoundException"/>
        /// <exception cref="Java.Net.MalformedURLException"/>
        /// <exception cref="Java.Rmi.RemoteException"/>
        public static void Bind(Java.Lang.String arg0, Java.Rmi.Remote arg1)
        {
            SExecute(LocalBridgeClazz, "bind", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/Naming.html#rebind(java.lang.String,java.rmi.Remote)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Rmi.Remote"/></param>
        /// <exception cref="Java.Rmi.RemoteException"/>
        /// <exception cref="Java.Net.MalformedURLException"/>
        public static void Rebind(Java.Lang.String arg0, Java.Rmi.Remote arg1)
        {
            SExecute(LocalBridgeClazz, "rebind", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/Naming.html#unbind(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Java.Rmi.RemoteException"/>
        /// <exception cref="Java.Rmi.NotBoundException"/>
        /// <exception cref="Java.Net.MalformedURLException"/>
        public static void Unbind(Java.Lang.String arg0)
        {
            SExecuteWithSignature(LocalBridgeClazz, "unbind", "(Ljava/lang/String;)V", arg0);
        }

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}