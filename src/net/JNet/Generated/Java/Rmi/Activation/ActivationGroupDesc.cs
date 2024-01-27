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
*  This file is generated by MASES.JNetReflector (ver. 2.2.4.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Rmi.Activation
{
    #region ActivationGroupDesc
    public partial class ActivationGroupDesc
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/activation/ActivationGroupDesc.html#%3Cinit%3E(java.lang.String,java.lang.String,java.rmi.MarshalledObject,java.util.Properties,java.rmi.activation.ActivationGroupDesc.CommandEnvironment)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="Java.Rmi.MarshalledObject"/></param>
        /// <param name="arg3"><see cref="Java.Util.Properties"/></param>
        /// <param name="arg4"><see cref="Java.Rmi.Activation.ActivationGroupDesc.CommandEnvironment"/></param>
        public ActivationGroupDesc(string arg0, string arg1, Java.Rmi.MarshalledObject<object> arg2, Java.Util.Properties arg3, Java.Rmi.Activation.ActivationGroupDesc.CommandEnvironment arg4)
            : base(arg0, arg1, arg2, arg3, arg4)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/activation/ActivationGroupDesc.html#%3Cinit%3E(java.util.Properties,java.rmi.activation.ActivationGroupDesc.CommandEnvironment)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Properties"/></param>
        /// <param name="arg1"><see cref="Java.Rmi.Activation.ActivationGroupDesc.CommandEnvironment"/></param>
        public ActivationGroupDesc(Java.Util.Properties arg0, Java.Rmi.Activation.ActivationGroupDesc.CommandEnvironment arg1)
            : base(arg0, arg1)
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/activation/ActivationGroupDesc.html#getClassName()"/> 
        /// </summary>
        public string ClassName
        {
            get { return IExecute<string>("getClassName"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/activation/ActivationGroupDesc.html#getData()"/> 
        /// </summary>
        public Java.Rmi.MarshalledObject<object> Data
        {
            get { return IExecute<Java.Rmi.MarshalledObject<object>>("getData"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/activation/ActivationGroupDesc.html#getCommandEnvironment()"/> 
        /// </summary>
        public Java.Rmi.Activation.ActivationGroupDesc.CommandEnvironment GetCommandEnvironment
        {
            get { return IExecute<Java.Rmi.Activation.ActivationGroupDesc.CommandEnvironment>("getCommandEnvironment"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/activation/ActivationGroupDesc.html#getLocation()"/> 
        /// </summary>
        public string Location
        {
            get { return IExecute<string>("getLocation"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/activation/ActivationGroupDesc.html#getPropertyOverrides()"/> 
        /// </summary>
        public Java.Util.Properties PropertyOverrides
        {
            get { return IExecute<Java.Util.Properties>("getPropertyOverrides"); }
        }

        #endregion

        #region Nested classes
        #region CommandEnvironment
        public partial class CommandEnvironment
        {
            #region Constructors
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/activation/ActivationGroupDesc.CommandEnvironment.html#%3Cinit%3E(java.lang.String,java.lang.String[])"/>
            /// </summary>
            /// <param name="arg0"><see cref="string"/></param>
            /// <param name="arg1"><see cref="string"/></param>
            public CommandEnvironment(string arg0, string[] arg1)
                : base(arg0, arg1)
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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/activation/ActivationGroupDesc.CommandEnvironment.html#getCommandOptions()"/> 
            /// </summary>
            public string[] CommandOptions
            {
                get { return IExecuteArray<string>("getCommandOptions"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/activation/ActivationGroupDesc.CommandEnvironment.html#getCommandPath()"/> 
            /// </summary>
            public string CommandPath
            {
                get { return IExecute<string>("getCommandPath"); }
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

    
        #endregion

        // TODO: complete the class
    }
    #endregion
}