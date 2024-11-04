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
*  This file is generated by MASES.JNetReflector (ver. 2.5.10.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Awt
{
    #region SystemTray declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/SystemTray.html"/>
    /// </summary>
    public partial class SystemTray : MASES.JCOBridge.C2JBridge.JVMBridgeBase<SystemTray>
    {
        const string _bridgeClassName = "java.awt.SystemTray";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public SystemTray() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public SystemTray(params object[] args) : base(args) { }

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

    }
    #endregion

    #region SystemTray implementation
    public partial class SystemTray
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/SystemTray.html#getSystemTray()"/> 
        /// </summary>
        public static Java.Awt.SystemTray GetSystemTray
        {
            get { return SExecuteWithSignature<Java.Awt.SystemTray>(LocalBridgeClazz, "getSystemTray", "()Ljava/awt/SystemTray;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/SystemTray.html#isSupported()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public static bool IsSupported()
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "isSupported", "()Z");
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/SystemTray.html#getTrayIcons()"/> 
        /// </summary>
        public Java.Awt.TrayIcon[] TrayIcons
        {
            get { return IExecuteWithSignatureArray<Java.Awt.TrayIcon>("getTrayIcons", "()[Ljava/awt/TrayIcon;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/SystemTray.html#getTrayIconSize()"/> 
        /// </summary>
        public Java.Awt.Dimension TrayIconSize
        {
            get { return IExecuteWithSignature<Java.Awt.Dimension>("getTrayIconSize", "()Ljava/awt/Dimension;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/SystemTray.html#getPropertyChangeListeners(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Beans.PropertyChangeListener"/></returns>
        public Java.Beans.PropertyChangeListener[] GetPropertyChangeListeners(Java.Lang.String arg0)
        {
            return IExecuteWithSignatureArray<Java.Beans.PropertyChangeListener>("getPropertyChangeListeners", "(Ljava/lang/String;)[Ljava/beans/PropertyChangeListener;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/SystemTray.html#addPropertyChangeListener(java.lang.String,java.beans.PropertyChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Beans.PropertyChangeListener"/></param>
        public void AddPropertyChangeListener(Java.Lang.String arg0, Java.Beans.PropertyChangeListener arg1)
        {
            IExecuteWithSignature("addPropertyChangeListener", "(Ljava/lang/String;Ljava/beans/PropertyChangeListener;)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/SystemTray.html#removePropertyChangeListener(java.lang.String,java.beans.PropertyChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Beans.PropertyChangeListener"/></param>
        public void RemovePropertyChangeListener(Java.Lang.String arg0, Java.Beans.PropertyChangeListener arg1)
        {
            IExecuteWithSignature("removePropertyChangeListener", "(Ljava/lang/String;Ljava/beans/PropertyChangeListener;)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/SystemTray.html#add(java.awt.TrayIcon)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.TrayIcon"/></param>
        /// <exception cref="Java.Awt.AWTException"/>
        public void Add(Java.Awt.TrayIcon arg0)
        {
            IExecuteWithSignature("add", "(Ljava/awt/TrayIcon;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/SystemTray.html#remove(java.awt.TrayIcon)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.TrayIcon"/></param>
        public void Remove(Java.Awt.TrayIcon arg0)
        {
            IExecuteWithSignature("remove", "(Ljava/awt/TrayIcon;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}