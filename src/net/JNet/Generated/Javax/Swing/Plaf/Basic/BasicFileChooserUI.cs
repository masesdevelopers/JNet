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

namespace Javax.Swing.Plaf.Basic
{
    #region BasicFileChooserUI declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicFileChooserUI.html"/>
    /// </summary>
    public partial class BasicFileChooserUI : Javax.Swing.Plaf.FileChooserUI
    {
        const string _bridgeClassName = "javax.swing.plaf.basic.BasicFileChooserUI";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public BasicFileChooserUI() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public BasicFileChooserUI(params object[] args) : base(args) { }

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

    #region BasicFileChooserUI implementation
    public partial class BasicFileChooserUI
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicFileChooserUI.html#%3Cinit%3E(javax.swing.JFileChooser)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JFileChooser"/></param>
        public BasicFileChooserUI(Javax.Swing.JFileChooser arg0)
            : base(arg0)
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicFileChooserUI.html#getAccessoryPanel()"/> 
        /// </summary>
        public Javax.Swing.JPanel AccessoryPanel
        {
            get { return IExecuteWithSignature<Javax.Swing.JPanel>("getAccessoryPanel", "()Ljavax/swing/JPanel;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicFileChooserUI.html#getDirectoryName()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicFileChooserUI.html#setDirectoryName(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String DirectoryName
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getDirectoryName", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setDirectoryName", "(Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicFileChooserUI.html#getFileChooser()"/> 
        /// </summary>
        public Javax.Swing.JFileChooser FileChooser
        {
            get { return IExecuteWithSignature<Javax.Swing.JFileChooser>("getFileChooser", "()Ljavax/swing/JFileChooser;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicFileChooserUI.html#getFileName()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicFileChooserUI.html#setFileName(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String FileName
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getFileName", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setFileName", "(Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicFileChooserUI.html#getApproveSelectionAction()"/> 
        /// </summary>
        public Javax.Swing.Action GetApproveSelectionAction
        {
            get { return IExecuteWithSignature<Javax.Swing.Action>("getApproveSelectionAction", "()Ljavax/swing/Action;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicFileChooserUI.html#getCancelSelectionAction()"/> 
        /// </summary>
        public Javax.Swing.Action GetCancelSelectionAction
        {
            get { return IExecuteWithSignature<Javax.Swing.Action>("getCancelSelectionAction", "()Ljavax/swing/Action;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicFileChooserUI.html#getChangeToParentDirectoryAction()"/> 
        /// </summary>
        public Javax.Swing.Action GetChangeToParentDirectoryAction
        {
            get { return IExecuteWithSignature<Javax.Swing.Action>("getChangeToParentDirectoryAction", "()Ljavax/swing/Action;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicFileChooserUI.html#getGoHomeAction()"/> 
        /// </summary>
        public Javax.Swing.Action GetGoHomeAction
        {
            get { return IExecuteWithSignature<Javax.Swing.Action>("getGoHomeAction", "()Ljavax/swing/Action;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicFileChooserUI.html#getNewFolderAction()"/> 
        /// </summary>
        public Javax.Swing.Action GetNewFolderAction
        {
            get { return IExecuteWithSignature<Javax.Swing.Action>("getNewFolderAction", "()Ljavax/swing/Action;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicFileChooserUI.html#getUpdateAction()"/> 
        /// </summary>
        public Javax.Swing.Action GetUpdateAction
        {
            get { return IExecuteWithSignature<Javax.Swing.Action>("getUpdateAction", "()Ljavax/swing/Action;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicFileChooserUI.html#getModel()"/> 
        /// </summary>
        public Javax.Swing.Plaf.Basic.BasicDirectoryModel Model
        {
            get { return IExecuteWithSignature<Javax.Swing.Plaf.Basic.BasicDirectoryModel>("getModel", "()Ljavax/swing/plaf/basic/BasicDirectoryModel;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicFileChooserUI.html#getApproveButtonMnemonic(javax.swing.JFileChooser)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JFileChooser"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetApproveButtonMnemonic(Javax.Swing.JFileChooser arg0)
        {
            return IExecuteWithSignature<int>("getApproveButtonMnemonic", "(Ljavax/swing/JFileChooser;)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicFileChooserUI.html#createPropertyChangeListener(javax.swing.JFileChooser)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JFileChooser"/></param>
        /// <returns><see cref="Java.Beans.PropertyChangeListener"/></returns>
        public Java.Beans.PropertyChangeListener CreatePropertyChangeListener(Javax.Swing.JFileChooser arg0)
        {
            return IExecuteWithSignature<Java.Beans.PropertyChangeListener>("createPropertyChangeListener", "(Ljavax/swing/JFileChooser;)Ljava/beans/PropertyChangeListener;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicFileChooserUI.html#createPropertyChangeListener(javax.swing.JFileChooser)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JFileChooser"/></param>
        /// <returns><see cref="Java.Beans.PropertyChangeListener"/></returns>
        public Java.Beans.PropertyChangeListener CreatePropertyChangeListenerDirect(Javax.Swing.JFileChooser arg0)
        {
            return IExecuteWithSignature<Java.Beans.PropertyChangeListenerDirect, Java.Beans.PropertyChangeListener>("createPropertyChangeListener", "(Ljavax/swing/JFileChooser;)Ljava/beans/PropertyChangeListener;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicFileChooserUI.html#getApproveButtonToolTipText(javax.swing.JFileChooser)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JFileChooser"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetApproveButtonToolTipText(Javax.Swing.JFileChooser arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("getApproveButtonToolTipText", "(Ljavax/swing/JFileChooser;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicFileChooserUI.html#createListSelectionListener(javax.swing.JFileChooser)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JFileChooser"/></param>
        /// <returns><see cref="Javax.Swing.Event.ListSelectionListener"/></returns>
        public Javax.Swing.Event.ListSelectionListener CreateListSelectionListener(Javax.Swing.JFileChooser arg0)
        {
            return IExecuteWithSignature<Javax.Swing.Event.ListSelectionListener>("createListSelectionListener", "(Ljavax/swing/JFileChooser;)Ljavax/swing/event/ListSelectionListener;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicFileChooserUI.html#createListSelectionListener(javax.swing.JFileChooser)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JFileChooser"/></param>
        /// <returns><see cref="Javax.Swing.Event.ListSelectionListener"/></returns>
        public Javax.Swing.Event.ListSelectionListener CreateListSelectionListenerDirect(Javax.Swing.JFileChooser arg0)
        {
            return IExecuteWithSignature<Javax.Swing.Event.ListSelectionListenerDirect, Javax.Swing.Event.ListSelectionListener>("createListSelectionListener", "(Ljavax/swing/JFileChooser;)Ljavax/swing/event/ListSelectionListener;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicFileChooserUI.html#clearIconCache()"/>
        /// </summary>
        public void ClearIconCache()
        {
            IExecuteWithSignature("clearIconCache", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicFileChooserUI.html#installComponents(javax.swing.JFileChooser)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JFileChooser"/></param>
        public void InstallComponents(Javax.Swing.JFileChooser arg0)
        {
            IExecuteWithSignature("installComponents", "(Ljavax/swing/JFileChooser;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicFileChooserUI.html#uninstallComponents(javax.swing.JFileChooser)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JFileChooser"/></param>
        public void UninstallComponents(Javax.Swing.JFileChooser arg0)
        {
            IExecuteWithSignature("uninstallComponents", "(Ljavax/swing/JFileChooser;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}