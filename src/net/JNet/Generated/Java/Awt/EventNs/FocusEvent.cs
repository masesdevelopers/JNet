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
*  This file is generated by MASES.JNetReflector (ver. 2.5.11.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Awt.EventNs
{
    #region FocusEvent declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/FocusEvent.html"/>
    /// </summary>
    public partial class FocusEvent : Java.Awt.EventNs.ComponentEvent
    {
        const string _bridgeClassName = "java.awt.event.FocusEvent";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public FocusEvent() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public FocusEvent(params object[] args) : base(args) { }

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
        #region Cause declaration
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/FocusEvent.Cause.html"/>
        /// </summary>
        public partial class Cause : Java.Lang.Enum<Java.Awt.EventNs.FocusEvent.Cause>
        {
            const string _bridgeClassName = "java.awt.event.FocusEvent$Cause";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public Cause() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public Cause(params object[] args) : base(args) { }

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

    #region FocusEvent implementation
    public partial class FocusEvent
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/FocusEvent.html#%3Cinit%3E(java.awt.Component,int,boolean,java.awt.Component,java.awt.event.FocusEvent.Cause)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        /// <param name="arg3"><see cref="Java.Awt.Component"/></param>
        /// <param name="arg4"><see cref="Java.Awt.EventNs.FocusEvent.Cause"/></param>
        public FocusEvent(Java.Awt.Component arg0, int arg1, bool arg2, Java.Awt.Component arg3, Java.Awt.EventNs.FocusEvent.Cause arg4)
            : base(arg0, arg1, arg2, arg3, arg4)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/FocusEvent.html#%3Cinit%3E(java.awt.Component,int,boolean,java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        /// <param name="arg3"><see cref="Java.Awt.Component"/></param>
        public FocusEvent(Java.Awt.Component arg0, int arg1, bool arg2, Java.Awt.Component arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/FocusEvent.html#%3Cinit%3E(java.awt.Component,int,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        public FocusEvent(Java.Awt.Component arg0, int arg1, bool arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/FocusEvent.html#%3Cinit%3E(java.awt.Component,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public FocusEvent(Java.Awt.Component arg0, int arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/FocusEvent.html#FOCUS_FIRST"/>
        /// </summary>
        public static int FOCUS_FIRST { get { if (!_FOCUS_FIRSTReady) { _FOCUS_FIRSTContent = SGetField<int>(LocalBridgeClazz, "FOCUS_FIRST"); _FOCUS_FIRSTReady = true; } return _FOCUS_FIRSTContent; } }
        private static int _FOCUS_FIRSTContent = default;
        private static bool _FOCUS_FIRSTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/FocusEvent.html#FOCUS_GAINED"/>
        /// </summary>
        public static int FOCUS_GAINED { get { if (!_FOCUS_GAINEDReady) { _FOCUS_GAINEDContent = SGetField<int>(LocalBridgeClazz, "FOCUS_GAINED"); _FOCUS_GAINEDReady = true; } return _FOCUS_GAINEDContent; } }
        private static int _FOCUS_GAINEDContent = default;
        private static bool _FOCUS_GAINEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/FocusEvent.html#FOCUS_LAST"/>
        /// </summary>
        public static int FOCUS_LAST { get { if (!_FOCUS_LASTReady) { _FOCUS_LASTContent = SGetField<int>(LocalBridgeClazz, "FOCUS_LAST"); _FOCUS_LASTReady = true; } return _FOCUS_LASTContent; } }
        private static int _FOCUS_LASTContent = default;
        private static bool _FOCUS_LASTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/FocusEvent.html#FOCUS_LOST"/>
        /// </summary>
        public static int FOCUS_LOST { get { if (!_FOCUS_LOSTReady) { _FOCUS_LOSTContent = SGetField<int>(LocalBridgeClazz, "FOCUS_LOST"); _FOCUS_LOSTReady = true; } return _FOCUS_LOSTContent; } }
        private static int _FOCUS_LOSTContent = default;
        private static bool _FOCUS_LOSTReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/FocusEvent.html#getCause()"/> 
        /// </summary>
        public Java.Awt.EventNs.FocusEvent.Cause GetCause
        {
            get { return IExecuteWithSignature<Java.Awt.EventNs.FocusEvent.Cause>("getCause", "()Ljava/awt/event/FocusEvent$Cause;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/FocusEvent.html#getOppositeComponent()"/> 
        /// </summary>
        public Java.Awt.Component OppositeComponent
        {
            get { return IExecuteWithSignature<Java.Awt.Component>("getOppositeComponent", "()Ljava/awt/Component;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/FocusEvent.html#isTemporary()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsTemporary()
        {
            return IExecuteWithSignature<bool>("isTemporary", "()Z");
        }

        #endregion

        #region Nested classes
        #region Cause implementation
        public partial class Cause
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/FocusEvent.Cause.html#ACTIVATION"/>
            /// </summary>
            public static Java.Awt.EventNs.FocusEvent.Cause ACTIVATION { get { if (!_ACTIVATIONReady) { _ACTIVATIONContent = SGetField<Java.Awt.EventNs.FocusEvent.Cause>(LocalBridgeClazz, "ACTIVATION"); _ACTIVATIONReady = true; } return _ACTIVATIONContent; } }
            private static Java.Awt.EventNs.FocusEvent.Cause _ACTIVATIONContent = default;
            private static bool _ACTIVATIONReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/FocusEvent.Cause.html#CLEAR_GLOBAL_FOCUS_OWNER"/>
            /// </summary>
            public static Java.Awt.EventNs.FocusEvent.Cause CLEAR_GLOBAL_FOCUS_OWNER { get { if (!_CLEAR_GLOBAL_FOCUS_OWNERReady) { _CLEAR_GLOBAL_FOCUS_OWNERContent = SGetField<Java.Awt.EventNs.FocusEvent.Cause>(LocalBridgeClazz, "CLEAR_GLOBAL_FOCUS_OWNER"); _CLEAR_GLOBAL_FOCUS_OWNERReady = true; } return _CLEAR_GLOBAL_FOCUS_OWNERContent; } }
            private static Java.Awt.EventNs.FocusEvent.Cause _CLEAR_GLOBAL_FOCUS_OWNERContent = default;
            private static bool _CLEAR_GLOBAL_FOCUS_OWNERReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/FocusEvent.Cause.html#MOUSE_EVENT"/>
            /// </summary>
            public static Java.Awt.EventNs.FocusEvent.Cause MOUSE_EVENT { get { if (!_MOUSE_EVENTReady) { _MOUSE_EVENTContent = SGetField<Java.Awt.EventNs.FocusEvent.Cause>(LocalBridgeClazz, "MOUSE_EVENT"); _MOUSE_EVENTReady = true; } return _MOUSE_EVENTContent; } }
            private static Java.Awt.EventNs.FocusEvent.Cause _MOUSE_EVENTContent = default;
            private static bool _MOUSE_EVENTReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/FocusEvent.Cause.html#ROLLBACK"/>
            /// </summary>
            public static Java.Awt.EventNs.FocusEvent.Cause ROLLBACK { get { if (!_ROLLBACKReady) { _ROLLBACKContent = SGetField<Java.Awt.EventNs.FocusEvent.Cause>(LocalBridgeClazz, "ROLLBACK"); _ROLLBACKReady = true; } return _ROLLBACKContent; } }
            private static Java.Awt.EventNs.FocusEvent.Cause _ROLLBACKContent = default;
            private static bool _ROLLBACKReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/FocusEvent.Cause.html#TRAVERSAL"/>
            /// </summary>
            public static Java.Awt.EventNs.FocusEvent.Cause TRAVERSAL { get { if (!_TRAVERSALReady) { _TRAVERSALContent = SGetField<Java.Awt.EventNs.FocusEvent.Cause>(LocalBridgeClazz, "TRAVERSAL"); _TRAVERSALReady = true; } return _TRAVERSALContent; } }
            private static Java.Awt.EventNs.FocusEvent.Cause _TRAVERSALContent = default;
            private static bool _TRAVERSALReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/FocusEvent.Cause.html#TRAVERSAL_BACKWARD"/>
            /// </summary>
            public static Java.Awt.EventNs.FocusEvent.Cause TRAVERSAL_BACKWARD { get { if (!_TRAVERSAL_BACKWARDReady) { _TRAVERSAL_BACKWARDContent = SGetField<Java.Awt.EventNs.FocusEvent.Cause>(LocalBridgeClazz, "TRAVERSAL_BACKWARD"); _TRAVERSAL_BACKWARDReady = true; } return _TRAVERSAL_BACKWARDContent; } }
            private static Java.Awt.EventNs.FocusEvent.Cause _TRAVERSAL_BACKWARDContent = default;
            private static bool _TRAVERSAL_BACKWARDReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/FocusEvent.Cause.html#TRAVERSAL_DOWN"/>
            /// </summary>
            public static Java.Awt.EventNs.FocusEvent.Cause TRAVERSAL_DOWN { get { if (!_TRAVERSAL_DOWNReady) { _TRAVERSAL_DOWNContent = SGetField<Java.Awt.EventNs.FocusEvent.Cause>(LocalBridgeClazz, "TRAVERSAL_DOWN"); _TRAVERSAL_DOWNReady = true; } return _TRAVERSAL_DOWNContent; } }
            private static Java.Awt.EventNs.FocusEvent.Cause _TRAVERSAL_DOWNContent = default;
            private static bool _TRAVERSAL_DOWNReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/FocusEvent.Cause.html#TRAVERSAL_FORWARD"/>
            /// </summary>
            public static Java.Awt.EventNs.FocusEvent.Cause TRAVERSAL_FORWARD { get { if (!_TRAVERSAL_FORWARDReady) { _TRAVERSAL_FORWARDContent = SGetField<Java.Awt.EventNs.FocusEvent.Cause>(LocalBridgeClazz, "TRAVERSAL_FORWARD"); _TRAVERSAL_FORWARDReady = true; } return _TRAVERSAL_FORWARDContent; } }
            private static Java.Awt.EventNs.FocusEvent.Cause _TRAVERSAL_FORWARDContent = default;
            private static bool _TRAVERSAL_FORWARDReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/FocusEvent.Cause.html#TRAVERSAL_UP"/>
            /// </summary>
            public static Java.Awt.EventNs.FocusEvent.Cause TRAVERSAL_UP { get { if (!_TRAVERSAL_UPReady) { _TRAVERSAL_UPContent = SGetField<Java.Awt.EventNs.FocusEvent.Cause>(LocalBridgeClazz, "TRAVERSAL_UP"); _TRAVERSAL_UPReady = true; } return _TRAVERSAL_UPContent; } }
            private static Java.Awt.EventNs.FocusEvent.Cause _TRAVERSAL_UPContent = default;
            private static bool _TRAVERSAL_UPReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/FocusEvent.Cause.html#UNEXPECTED"/>
            /// </summary>
            public static Java.Awt.EventNs.FocusEvent.Cause UNEXPECTED { get { if (!_UNEXPECTEDReady) { _UNEXPECTEDContent = SGetField<Java.Awt.EventNs.FocusEvent.Cause>(LocalBridgeClazz, "UNEXPECTED"); _UNEXPECTEDReady = true; } return _UNEXPECTEDContent; } }
            private static Java.Awt.EventNs.FocusEvent.Cause _UNEXPECTEDContent = default;
            private static bool _UNEXPECTEDReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/FocusEvent.Cause.html#UNKNOWN"/>
            /// </summary>
            public static Java.Awt.EventNs.FocusEvent.Cause UNKNOWN { get { if (!_UNKNOWNReady) { _UNKNOWNContent = SGetField<Java.Awt.EventNs.FocusEvent.Cause>(LocalBridgeClazz, "UNKNOWN"); _UNKNOWNReady = true; } return _UNKNOWNContent; } }
            private static Java.Awt.EventNs.FocusEvent.Cause _UNKNOWNContent = default;
            private static bool _UNKNOWNReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/FocusEvent.Cause.html#valueOf(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Java.Awt.EventNs.FocusEvent.Cause"/></returns>
            public static Java.Awt.EventNs.FocusEvent.Cause ValueOf(Java.Lang.String arg0)
            {
                return SExecuteWithSignature<Java.Awt.EventNs.FocusEvent.Cause>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Ljava/awt/event/FocusEvent$Cause;", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/FocusEvent.Cause.html#values()"/>
            /// </summary>
            /// <returns><see cref="Java.Awt.EventNs.FocusEvent.Cause"/></returns>
            public static Java.Awt.EventNs.FocusEvent.Cause[] Values()
            {
                return SExecuteWithSignatureArray<Java.Awt.EventNs.FocusEvent.Cause>(LocalBridgeClazz, "values", "()[Ljava/awt/event/FocusEvent$Cause;");
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