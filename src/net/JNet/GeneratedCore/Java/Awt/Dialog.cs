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
*  This file is generated by MASES.JNetReflector (ver. 2.5.8.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Awt
{
    #region Dialog definition
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Dialog.html"/>
    /// </summary>
    public partial class Dialog : Java.Awt.Window
    {
        const string _bridgeClassName = "java.awt.Dialog";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public Dialog() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public Dialog(params object[] args) : base(args) { }

        private static readonly IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new InvalidOperationException($"Class {_bridgeClassName} was not found.");

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
        #region ModalExclusionType definition
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Dialog.ModalExclusionType.html"/>
        /// </summary>
        public partial class ModalExclusionType : Java.Lang.Enum<Java.Awt.Dialog.ModalExclusionType>
        {
            const string _bridgeClassName = "java.awt.Dialog$ModalExclusionType";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public ModalExclusionType() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public ModalExclusionType(params object[] args) : base(args) { }

            private static readonly IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
            private static IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new InvalidOperationException($"Class {_bridgeClassName} was not found.");

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

        #region ModalityType definition
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Dialog.ModalityType.html"/>
        /// </summary>
        public partial class ModalityType : Java.Lang.Enum<Java.Awt.Dialog.ModalityType>
        {
            const string _bridgeClassName = "java.awt.Dialog$ModalityType";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public ModalityType() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public ModalityType(params object[] args) : base(args) { }

            private static readonly IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
            private static IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new InvalidOperationException($"Class {_bridgeClassName} was not found.");

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

    #region Dialog
    public partial class Dialog
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Dialog.html#%3Cinit%3E(java.awt.Dialog,java.lang.String,boolean,java.awt.GraphicsConfiguration)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Dialog"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        /// <param name="arg3"><see cref="Java.Awt.GraphicsConfiguration"/></param>
        public Dialog(Java.Awt.Dialog arg0, Java.Lang.String arg1, bool arg2, Java.Awt.GraphicsConfiguration arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Dialog.html#%3Cinit%3E(java.awt.Dialog,java.lang.String,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Dialog"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        public Dialog(Java.Awt.Dialog arg0, Java.Lang.String arg1, bool arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Dialog.html#%3Cinit%3E(java.awt.Dialog,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Dialog"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        public Dialog(Java.Awt.Dialog arg0, Java.Lang.String arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Dialog.html#%3Cinit%3E(java.awt.Dialog)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Dialog"/></param>
        public Dialog(Java.Awt.Dialog arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Dialog.html#%3Cinit%3E(java.awt.Frame,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Frame"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        public Dialog(Java.Awt.Frame arg0, bool arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Dialog.html#%3Cinit%3E(java.awt.Frame,java.lang.String,boolean,java.awt.GraphicsConfiguration)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Frame"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        /// <param name="arg3"><see cref="Java.Awt.GraphicsConfiguration"/></param>
        public Dialog(Java.Awt.Frame arg0, Java.Lang.String arg1, bool arg2, Java.Awt.GraphicsConfiguration arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Dialog.html#%3Cinit%3E(java.awt.Frame,java.lang.String,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Frame"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        public Dialog(Java.Awt.Frame arg0, Java.Lang.String arg1, bool arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Dialog.html#%3Cinit%3E(java.awt.Frame,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Frame"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        public Dialog(Java.Awt.Frame arg0, Java.Lang.String arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Dialog.html#%3Cinit%3E(java.awt.Frame)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Frame"/></param>
        public Dialog(Java.Awt.Frame arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Dialog.html#%3Cinit%3E(java.awt.Window,java.awt.Dialog.ModalityType)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Window"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Dialog.ModalityType"/></param>
        public Dialog(Java.Awt.Window arg0, Java.Awt.Dialog.ModalityType arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Dialog.html#%3Cinit%3E(java.awt.Window,java.lang.String,java.awt.Dialog.ModalityType,java.awt.GraphicsConfiguration)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Window"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Awt.Dialog.ModalityType"/></param>
        /// <param name="arg3"><see cref="Java.Awt.GraphicsConfiguration"/></param>
        public Dialog(Java.Awt.Window arg0, Java.Lang.String arg1, Java.Awt.Dialog.ModalityType arg2, Java.Awt.GraphicsConfiguration arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Dialog.html#%3Cinit%3E(java.awt.Window,java.lang.String,java.awt.Dialog.ModalityType)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Window"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Awt.Dialog.ModalityType"/></param>
        public Dialog(Java.Awt.Window arg0, Java.Lang.String arg1, Java.Awt.Dialog.ModalityType arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Dialog.html#%3Cinit%3E(java.awt.Window,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Window"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        public Dialog(Java.Awt.Window arg0, Java.Lang.String arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Dialog.html#%3Cinit%3E(java.awt.Window)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Window"/></param>
        public Dialog(Java.Awt.Window arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Dialog.html#DEFAULT_MODALITY_TYPE"/>
        /// </summary>
        public static Java.Awt.Dialog.ModalityType DEFAULT_MODALITY_TYPE { get { if (!_DEFAULT_MODALITY_TYPEReady) { _DEFAULT_MODALITY_TYPEContent = SGetField<Java.Awt.Dialog.ModalityType>(LocalBridgeClazz, "DEFAULT_MODALITY_TYPE"); _DEFAULT_MODALITY_TYPEReady = true; } return _DEFAULT_MODALITY_TYPEContent; } }
        private static Java.Awt.Dialog.ModalityType _DEFAULT_MODALITY_TYPEContent = default;
        private static bool _DEFAULT_MODALITY_TYPEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Dialog.html#getModalityType()"/> 
        /// </summary>
        public Java.Awt.Dialog.ModalityType GetModalityType
        {
            get { return IExecuteWithSignature<Java.Awt.Dialog.ModalityType>("getModalityType", "()Ljava/awt/Dialog$ModalityType;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Dialog.html#getTitle()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Dialog.html#setTitle(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String Title
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getTitle", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setTitle", "(Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Dialog.html#isModal()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsModal()
        {
            return IExecuteWithSignature<bool>("isModal", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Dialog.html#isResizable()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsResizable()
        {
            return IExecuteWithSignature<bool>("isResizable", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Dialog.html#isUndecorated()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsUndecorated()
        {
            return IExecuteWithSignature<bool>("isUndecorated", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Dialog.html#setModal(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetModal(bool arg0)
        {
            IExecuteWithSignature("setModal", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Dialog.html#setModalityType(java.awt.Dialog.ModalityType)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Dialog.ModalityType"/></param>
        public void SetModalityType(Java.Awt.Dialog.ModalityType arg0)
        {
            IExecuteWithSignature("setModalityType", "(Ljava/awt/Dialog$ModalityType;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Dialog.html#setResizable(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetResizable(bool arg0)
        {
            IExecuteWithSignature("setResizable", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Dialog.html#setUndecorated(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetUndecorated(bool arg0)
        {
            IExecuteWithSignature("setUndecorated", "(Z)V", arg0);
        }

        #endregion

        #region Nested classes
        #region ModalExclusionType
        public partial class ModalExclusionType
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Dialog.ModalExclusionType.html#APPLICATION_EXCLUDE"/>
            /// </summary>
            public static Java.Awt.Dialog.ModalExclusionType APPLICATION_EXCLUDE { get { if (!_APPLICATION_EXCLUDEReady) { _APPLICATION_EXCLUDEContent = SGetField<Java.Awt.Dialog.ModalExclusionType>(LocalBridgeClazz, "APPLICATION_EXCLUDE"); _APPLICATION_EXCLUDEReady = true; } return _APPLICATION_EXCLUDEContent; } }
            private static Java.Awt.Dialog.ModalExclusionType _APPLICATION_EXCLUDEContent = default;
            private static bool _APPLICATION_EXCLUDEReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Dialog.ModalExclusionType.html#NO_EXCLUDE"/>
            /// </summary>
            public static Java.Awt.Dialog.ModalExclusionType NO_EXCLUDE { get { if (!_NO_EXCLUDEReady) { _NO_EXCLUDEContent = SGetField<Java.Awt.Dialog.ModalExclusionType>(LocalBridgeClazz, "NO_EXCLUDE"); _NO_EXCLUDEReady = true; } return _NO_EXCLUDEContent; } }
            private static Java.Awt.Dialog.ModalExclusionType _NO_EXCLUDEContent = default;
            private static bool _NO_EXCLUDEReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Dialog.ModalExclusionType.html#TOOLKIT_EXCLUDE"/>
            /// </summary>
            public static Java.Awt.Dialog.ModalExclusionType TOOLKIT_EXCLUDE { get { if (!_TOOLKIT_EXCLUDEReady) { _TOOLKIT_EXCLUDEContent = SGetField<Java.Awt.Dialog.ModalExclusionType>(LocalBridgeClazz, "TOOLKIT_EXCLUDE"); _TOOLKIT_EXCLUDEReady = true; } return _TOOLKIT_EXCLUDEContent; } }
            private static Java.Awt.Dialog.ModalExclusionType _TOOLKIT_EXCLUDEContent = default;
            private static bool _TOOLKIT_EXCLUDEReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Dialog.ModalExclusionType.html#valueOf(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Java.Awt.Dialog.ModalExclusionType"/></returns>
            public static Java.Awt.Dialog.ModalExclusionType ValueOf(Java.Lang.String arg0)
            {
                return SExecuteWithSignature<Java.Awt.Dialog.ModalExclusionType>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Ljava/awt/Dialog$ModalExclusionType;", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Dialog.ModalExclusionType.html#values()"/>
            /// </summary>
            /// <returns><see cref="Java.Awt.Dialog.ModalExclusionType"/></returns>
            public static Java.Awt.Dialog.ModalExclusionType[] Values()
            {
                return SExecuteWithSignatureArray<Java.Awt.Dialog.ModalExclusionType>(LocalBridgeClazz, "values", "()[Ljava/awt/Dialog$ModalExclusionType;");
            }

            #endregion

            #region Instance methods

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region ModalityType
        public partial class ModalityType
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Dialog.ModalityType.html#APPLICATION_MODAL"/>
            /// </summary>
            public static Java.Awt.Dialog.ModalityType APPLICATION_MODAL { get { if (!_APPLICATION_MODALReady) { _APPLICATION_MODALContent = SGetField<Java.Awt.Dialog.ModalityType>(LocalBridgeClazz, "APPLICATION_MODAL"); _APPLICATION_MODALReady = true; } return _APPLICATION_MODALContent; } }
            private static Java.Awt.Dialog.ModalityType _APPLICATION_MODALContent = default;
            private static bool _APPLICATION_MODALReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Dialog.ModalityType.html#DOCUMENT_MODAL"/>
            /// </summary>
            public static Java.Awt.Dialog.ModalityType DOCUMENT_MODAL { get { if (!_DOCUMENT_MODALReady) { _DOCUMENT_MODALContent = SGetField<Java.Awt.Dialog.ModalityType>(LocalBridgeClazz, "DOCUMENT_MODAL"); _DOCUMENT_MODALReady = true; } return _DOCUMENT_MODALContent; } }
            private static Java.Awt.Dialog.ModalityType _DOCUMENT_MODALContent = default;
            private static bool _DOCUMENT_MODALReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Dialog.ModalityType.html#MODELESS"/>
            /// </summary>
            public static Java.Awt.Dialog.ModalityType MODELESS { get { if (!_MODELESSReady) { _MODELESSContent = SGetField<Java.Awt.Dialog.ModalityType>(LocalBridgeClazz, "MODELESS"); _MODELESSReady = true; } return _MODELESSContent; } }
            private static Java.Awt.Dialog.ModalityType _MODELESSContent = default;
            private static bool _MODELESSReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Dialog.ModalityType.html#TOOLKIT_MODAL"/>
            /// </summary>
            public static Java.Awt.Dialog.ModalityType TOOLKIT_MODAL { get { if (!_TOOLKIT_MODALReady) { _TOOLKIT_MODALContent = SGetField<Java.Awt.Dialog.ModalityType>(LocalBridgeClazz, "TOOLKIT_MODAL"); _TOOLKIT_MODALReady = true; } return _TOOLKIT_MODALContent; } }
            private static Java.Awt.Dialog.ModalityType _TOOLKIT_MODALContent = default;
            private static bool _TOOLKIT_MODALReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Dialog.ModalityType.html#valueOf(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Java.Awt.Dialog.ModalityType"/></returns>
            public static Java.Awt.Dialog.ModalityType ValueOf(Java.Lang.String arg0)
            {
                return SExecuteWithSignature<Java.Awt.Dialog.ModalityType>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Ljava/awt/Dialog$ModalityType;", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Dialog.ModalityType.html#values()"/>
            /// </summary>
            /// <returns><see cref="Java.Awt.Dialog.ModalityType"/></returns>
            public static Java.Awt.Dialog.ModalityType[] Values()
            {
                return SExecuteWithSignatureArray<Java.Awt.Dialog.ModalityType>(LocalBridgeClazz, "values", "()[Ljava/awt/Dialog$ModalityType;");
            }

            #endregion

            #region Instance methods

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