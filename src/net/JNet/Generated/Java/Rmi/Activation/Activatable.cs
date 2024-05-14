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

namespace Java.Rmi.Activation
{
    #region Activatable
    public partial class Activatable
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/activation/Activatable.html#inactive(java.rmi.activation.ActivationID)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Rmi.Activation.ActivationID"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Rmi.Activation.UnknownObjectException"/>
        /// <exception cref="Java.Rmi.Activation.ActivationException"/>
        /// <exception cref="Java.Rmi.RemoteException"/>
        public static bool Inactive(Java.Rmi.Activation.ActivationID arg0)
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "inactive", "(Ljava/rmi/activation/ActivationID;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/activation/Activatable.html#unexportObject(java.rmi.Remote,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Rmi.Remote"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Rmi.NoSuchObjectException"/>
        public static bool UnexportObject(Java.Rmi.Remote arg0, bool arg1)
        {
            return SExecute<bool>(LocalBridgeClazz, "unexportObject", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/activation/Activatable.html#exportObject(java.rmi.Remote,java.lang.String,java.rmi.MarshalledObject,boolean,int,java.rmi.server.RMIClientSocketFactory,java.rmi.server.RMIServerSocketFactory)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Rmi.Remote"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Rmi.MarshalledObject"/></param>
        /// <param name="arg3"><see cref="bool"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="Java.Rmi.Server.RMIClientSocketFactory"/></param>
        /// <param name="arg6"><see cref="Java.Rmi.Server.RMIServerSocketFactory"/></param>
        /// <returns><see cref="Java.Rmi.Activation.ActivationID"/></returns>
        /// <exception cref="Java.Rmi.Activation.ActivationException"/>
        /// <exception cref="Java.Rmi.RemoteException"/>
        public static Java.Rmi.Activation.ActivationID ExportObject(Java.Rmi.Remote arg0, Java.Lang.String arg1, Java.Rmi.MarshalledObject<object> arg2, bool arg3, int arg4, Java.Rmi.Server.RMIClientSocketFactory arg5, Java.Rmi.Server.RMIServerSocketFactory arg6)
        {
            return SExecute<Java.Rmi.Activation.ActivationID>(LocalBridgeClazz, "exportObject", arg0, arg1, arg2, arg3, arg4, arg5, arg6);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/activation/Activatable.html#exportObject(java.rmi.Remote,java.lang.String,java.rmi.MarshalledObject,boolean,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Rmi.Remote"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Rmi.MarshalledObject"/></param>
        /// <param name="arg3"><see cref="bool"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <returns><see cref="Java.Rmi.Activation.ActivationID"/></returns>
        /// <exception cref="Java.Rmi.Activation.ActivationException"/>
        /// <exception cref="Java.Rmi.RemoteException"/>
        public static Java.Rmi.Activation.ActivationID ExportObject(Java.Rmi.Remote arg0, Java.Lang.String arg1, Java.Rmi.MarshalledObject<object> arg2, bool arg3, int arg4)
        {
            return SExecute<Java.Rmi.Activation.ActivationID>(LocalBridgeClazz, "exportObject", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/activation/Activatable.html#exportObject(java.rmi.Remote,java.rmi.activation.ActivationID,int,java.rmi.server.RMIClientSocketFactory,java.rmi.server.RMIServerSocketFactory)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Rmi.Remote"/></param>
        /// <param name="arg1"><see cref="Java.Rmi.Activation.ActivationID"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="Java.Rmi.Server.RMIClientSocketFactory"/></param>
        /// <param name="arg4"><see cref="Java.Rmi.Server.RMIServerSocketFactory"/></param>
        /// <returns><see cref="Java.Rmi.Remote"/></returns>
        /// <exception cref="Java.Rmi.RemoteException"/>
        public static Java.Rmi.Remote ExportObject(Java.Rmi.Remote arg0, Java.Rmi.Activation.ActivationID arg1, int arg2, Java.Rmi.Server.RMIClientSocketFactory arg3, Java.Rmi.Server.RMIServerSocketFactory arg4)
        {
            return SExecute<Java.Rmi.Remote>(LocalBridgeClazz, "exportObject", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/activation/Activatable.html#exportObject(java.rmi.Remote,java.rmi.activation.ActivationID,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Rmi.Remote"/></param>
        /// <param name="arg1"><see cref="Java.Rmi.Activation.ActivationID"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Java.Rmi.Remote"/></returns>
        /// <exception cref="Java.Rmi.RemoteException"/>
        public static Java.Rmi.Remote ExportObject(Java.Rmi.Remote arg0, Java.Rmi.Activation.ActivationID arg1, int arg2)
        {
            return SExecute<Java.Rmi.Remote>(LocalBridgeClazz, "exportObject", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/activation/Activatable.html#register(java.rmi.activation.ActivationDesc)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Rmi.Activation.ActivationDesc"/></param>
        /// <returns><see cref="Java.Rmi.Remote"/></returns>
        /// <exception cref="Java.Rmi.Activation.UnknownGroupException"/>
        /// <exception cref="Java.Rmi.Activation.ActivationException"/>
        /// <exception cref="Java.Rmi.RemoteException"/>
        public static Java.Rmi.Remote Register(Java.Rmi.Activation.ActivationDesc arg0)
        {
            return SExecuteWithSignature<Java.Rmi.Remote>(LocalBridgeClazz, "register", "(Ljava/rmi/activation/ActivationDesc;)Ljava/rmi/Remote;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/activation/Activatable.html#unregister(java.rmi.activation.ActivationID)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Rmi.Activation.ActivationID"/></param>
        /// <exception cref="Java.Rmi.Activation.UnknownObjectException"/>
        /// <exception cref="Java.Rmi.Activation.ActivationException"/>
        /// <exception cref="Java.Rmi.RemoteException"/>
        public static void Unregister(Java.Rmi.Activation.ActivationID arg0)
        {
            SExecuteWithSignature(LocalBridgeClazz, "unregister", "(Ljava/rmi/activation/ActivationID;)V", arg0);
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