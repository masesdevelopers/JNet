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
*  This file is generated by MASES.JNetReflector (ver. 2.5.9.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Rmi.Activation
{
    #region ActivationGroupDesc declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/activation/ActivationGroupDesc.html"/>
    /// </summary>
    public partial class ActivationGroupDesc : Java.Io.Serializable
    {
        const string _bridgeClassName = "java.rmi.activation.ActivationGroupDesc";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public ActivationGroupDesc() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public ActivationGroupDesc(params object[] args) : base(args) { }

        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
        /// </summary>
        public override bool IsBridgeCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
        /// </summary>
        public override bool IsBridgeInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;

        // TODO: complete the class
        #region CommandEnvironment declaration
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/activation/ActivationGroupDesc.CommandEnvironment.html"/>
        /// </summary>
        public partial class CommandEnvironment : Java.Io.Serializable
        {
            const string _bridgeClassName = "java.rmi.activation.ActivationGroupDesc$CommandEnvironment";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public CommandEnvironment() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public CommandEnvironment(params object[] args) : base(args) { }

            private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
            private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
            /// </summary>
            public override string BridgeClassName => _bridgeClassName;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
            /// </summary>
            public override bool IsBridgeAbstract => false;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
            /// </summary>
            public override bool IsBridgeCloseable => false;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
            /// </summary>
            public override bool IsBridgeInterface => false;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
            /// </summary>
            public override bool IsBridgeStatic => true;

            // TODO: complete the class

        }
        #endregion

    
    }
    #endregion

    #region ActivationGroupDesc implementation
    public partial class ActivationGroupDesc
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/activation/ActivationGroupDesc.html#%3Cinit%3E(java.lang.String,java.lang.String,java.rmi.MarshalledObject,java.util.Properties,java.rmi.activation.ActivationGroupDesc.CommandEnvironment)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Rmi.MarshalledObject"/></param>
        /// <param name="arg3"><see cref="Java.Util.Properties"/></param>
        /// <param name="arg4"><see cref="Java.Rmi.Activation.ActivationGroupDesc.CommandEnvironment"/></param>
        public ActivationGroupDesc(Java.Lang.String arg0, Java.Lang.String arg1, Java.Rmi.MarshalledObject<object> arg2, Java.Util.Properties arg3, Java.Rmi.Activation.ActivationGroupDesc.CommandEnvironment arg4)
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
        public Java.Lang.String ClassName
        {
            get { return IExecute<Java.Lang.String>("getClassName"); }
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
        public Java.Lang.String Location
        {
            get { return IExecute<Java.Lang.String>("getLocation"); }
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
        #region CommandEnvironment implementation
        public partial class CommandEnvironment
        {
            #region Constructors
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/activation/ActivationGroupDesc.CommandEnvironment.html#%3Cinit%3E(java.lang.String,java.lang.String[])"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <param name="arg1"><see cref="Java.Lang.String"/></param>
            public CommandEnvironment(Java.Lang.String arg0, Java.Lang.String[] arg1)
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
            public Java.Lang.String[] CommandOptions
            {
                get { return IExecuteArray<Java.Lang.String>("getCommandOptions"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/activation/ActivationGroupDesc.CommandEnvironment.html#getCommandPath()"/> 
            /// </summary>
            public Java.Lang.String CommandPath
            {
                get { return IExecute<Java.Lang.String>("getCommandPath"); }
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