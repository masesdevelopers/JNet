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

namespace Javax.Print
{
    #region ServiceUIFactory declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/ServiceUIFactory.html"/>
    /// </summary>
    public partial class ServiceUIFactory : MASES.JCOBridge.C2JBridge.JVMBridgeBase<ServiceUIFactory>
    {
        const string _bridgeClassName = "javax.print.ServiceUIFactory";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("ServiceUIFactory class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public ServiceUIFactory() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("ServiceUIFactory class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public ServiceUIFactory(params object[] args) : base(args) { }

        private static readonly IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => true;
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

    }
    #endregion

    #region ServiceUIFactory implementation
    public partial class ServiceUIFactory
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/ServiceUIFactory.html#ABOUT_UIROLE"/>
        /// </summary>
        public static int ABOUT_UIROLE { get { if (!_ABOUT_UIROLEReady) { _ABOUT_UIROLEContent = SGetField<int>(LocalBridgeClazz, "ABOUT_UIROLE"); _ABOUT_UIROLEReady = true; } return _ABOUT_UIROLEContent; } }
        private static int _ABOUT_UIROLEContent = default;
        private static bool _ABOUT_UIROLEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/ServiceUIFactory.html#ADMIN_UIROLE"/>
        /// </summary>
        public static int ADMIN_UIROLE { get { if (!_ADMIN_UIROLEReady) { _ADMIN_UIROLEContent = SGetField<int>(LocalBridgeClazz, "ADMIN_UIROLE"); _ADMIN_UIROLEReady = true; } return _ADMIN_UIROLEContent; } }
        private static int _ADMIN_UIROLEContent = default;
        private static bool _ADMIN_UIROLEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/ServiceUIFactory.html#MAIN_UIROLE"/>
        /// </summary>
        public static int MAIN_UIROLE { get { if (!_MAIN_UIROLEReady) { _MAIN_UIROLEContent = SGetField<int>(LocalBridgeClazz, "MAIN_UIROLE"); _MAIN_UIROLEReady = true; } return _MAIN_UIROLEContent; } }
        private static int _MAIN_UIROLEContent = default;
        private static bool _MAIN_UIROLEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/ServiceUIFactory.html#RESERVED_UIROLE"/>
        /// </summary>
        public static int RESERVED_UIROLE { get { if (!_RESERVED_UIROLEReady) { _RESERVED_UIROLEContent = SGetField<int>(LocalBridgeClazz, "RESERVED_UIROLE"); _RESERVED_UIROLEReady = true; } return _RESERVED_UIROLEContent; } }
        private static int _RESERVED_UIROLEContent = default;
        private static bool _RESERVED_UIROLEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/ServiceUIFactory.html#DIALOG_UI"/>
        /// </summary>
        public static Java.Lang.String DIALOG_UI { get { if (!_DIALOG_UIReady) { _DIALOG_UIContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "DIALOG_UI"); _DIALOG_UIReady = true; } return _DIALOG_UIContent; } }
        private static Java.Lang.String _DIALOG_UIContent = default;
        private static bool _DIALOG_UIReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/ServiceUIFactory.html#JCOMPONENT_UI"/>
        /// </summary>
        public static Java.Lang.String JCOMPONENT_UI { get { if (!_JCOMPONENT_UIReady) { _JCOMPONENT_UIContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "JCOMPONENT_UI"); _JCOMPONENT_UIReady = true; } return _JCOMPONENT_UIContent; } }
        private static Java.Lang.String _JCOMPONENT_UIContent = default;
        private static bool _JCOMPONENT_UIReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/ServiceUIFactory.html#JDIALOG_UI"/>
        /// </summary>
        public static Java.Lang.String JDIALOG_UI { get { if (!_JDIALOG_UIReady) { _JDIALOG_UIContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "JDIALOG_UI"); _JDIALOG_UIReady = true; } return _JDIALOG_UIContent; } }
        private static Java.Lang.String _JDIALOG_UIContent = default;
        private static bool _JDIALOG_UIReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/ServiceUIFactory.html#PANEL_UI"/>
        /// </summary>
        public static Java.Lang.String PANEL_UI { get { if (!_PANEL_UIReady) { _PANEL_UIContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "PANEL_UI"); _PANEL_UIReady = true; } return _PANEL_UIContent; } }
        private static Java.Lang.String _PANEL_UIContent = default;
        private static bool _PANEL_UIReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/ServiceUIFactory.html#getUI(int,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="object"/></returns>
        public object GetUI(int arg0, Java.Lang.String arg1)
        {
            return IExecute("getUI", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/ServiceUIFactory.html#getUIClassNamesForRole(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String[] GetUIClassNamesForRole(int arg0)
        {
            return IExecuteWithSignatureArray<Java.Lang.String>("getUIClassNamesForRole", "(I)[Ljava/lang/String;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}