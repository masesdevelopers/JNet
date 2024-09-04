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

namespace Javax.Swing
{
    #region JTabbedPane declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JTabbedPane.html"/>
    /// </summary>
    public partial class JTabbedPane : Javax.Swing.JComponent
    {
        const string _bridgeClassName = "javax.swing.JTabbedPane";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public JTabbedPane() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public JTabbedPane(params object[] args) : base(args) { }

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

    #region JTabbedPane implementation
    public partial class JTabbedPane
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JTabbedPane.html#%3Cinit%3E(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public JTabbedPane(int arg0, int arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JTabbedPane.html#%3Cinit%3E(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public JTabbedPane(int arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Swing.JTabbedPane"/> to <see cref="Javax.Accessibility.Accessible"/>
        /// </summary>
        public static implicit operator Javax.Accessibility.Accessible(Javax.Swing.JTabbedPane t) => t.Cast<Javax.Accessibility.Accessible>();
        /// <summary>
        /// Converter from <see cref="Javax.Swing.JTabbedPane"/> to <see cref="Javax.Swing.SwingConstants"/>
        /// </summary>
        public static implicit operator Javax.Swing.SwingConstants(Javax.Swing.JTabbedPane t) => t.Cast<Javax.Swing.SwingConstants>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JTabbedPane.html#SCROLL_TAB_LAYOUT"/>
        /// </summary>
        public static int SCROLL_TAB_LAYOUT { get { if (!_SCROLL_TAB_LAYOUTReady) { _SCROLL_TAB_LAYOUTContent = SGetField<int>(LocalBridgeClazz, "SCROLL_TAB_LAYOUT"); _SCROLL_TAB_LAYOUTReady = true; } return _SCROLL_TAB_LAYOUTContent; } }
        private static int _SCROLL_TAB_LAYOUTContent = default;
        private static bool _SCROLL_TAB_LAYOUTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JTabbedPane.html#WRAP_TAB_LAYOUT"/>
        /// </summary>
        public static int WRAP_TAB_LAYOUT { get { if (!_WRAP_TAB_LAYOUTReady) { _WRAP_TAB_LAYOUTContent = SGetField<int>(LocalBridgeClazz, "WRAP_TAB_LAYOUT"); _WRAP_TAB_LAYOUTReady = true; } return _WRAP_TAB_LAYOUTContent; } }
        private static int _WRAP_TAB_LAYOUTContent = default;
        private static bool _WRAP_TAB_LAYOUTReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JTabbedPane.html#getChangeListeners()"/> 
        /// </summary>
        public Javax.Swing.Event.ChangeListener[] ChangeListeners
        {
            get { return IExecuteWithSignatureArray<Javax.Swing.Event.ChangeListener>("getChangeListeners", "()[Ljavax/swing/event/ChangeListener;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JTabbedPane.html#getModel()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JTabbedPane.html#setModel(javax.swing.SingleSelectionModel)"/>
        /// </summary>
        public Javax.Swing.SingleSelectionModel Model
        {
            get { return IExecuteWithSignature<Javax.Swing.SingleSelectionModel>("getModel", "()Ljavax/swing/SingleSelectionModel;"); } set { IExecuteWithSignature("setModel", "(Ljavax/swing/SingleSelectionModel;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JTabbedPane.html#getSelectedComponent()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JTabbedPane.html#setSelectedComponent(java.awt.Component)"/>
        /// </summary>
        public Java.Awt.Component SelectedComponent
        {
            get { return IExecuteWithSignature<Java.Awt.Component>("getSelectedComponent", "()Ljava/awt/Component;"); } set { IExecuteWithSignature("setSelectedComponent", "(Ljava/awt/Component;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JTabbedPane.html#getSelectedIndex()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JTabbedPane.html#setSelectedIndex(int)"/>
        /// </summary>
        public int SelectedIndex
        {
            get { return IExecuteWithSignature<int>("getSelectedIndex", "()I"); } set { IExecuteWithSignature("setSelectedIndex", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JTabbedPane.html#getTabCount()"/> 
        /// </summary>
        public int TabCount
        {
            get { return IExecuteWithSignature<int>("getTabCount", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JTabbedPane.html#getTabLayoutPolicy()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JTabbedPane.html#setTabLayoutPolicy(int)"/>
        /// </summary>
        public int TabLayoutPolicy
        {
            get { return IExecuteWithSignature<int>("getTabLayoutPolicy", "()I"); } set { IExecuteWithSignature("setTabLayoutPolicy", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JTabbedPane.html#getTabPlacement()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JTabbedPane.html#setTabPlacement(int)"/>
        /// </summary>
        public int TabPlacement
        {
            get { return IExecuteWithSignature<int>("getTabPlacement", "()I"); } set { IExecuteWithSignature("setTabPlacement", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JTabbedPane.html#getTabRunCount()"/> 
        /// </summary>
        public int TabRunCount
        {
            get { return IExecuteWithSignature<int>("getTabRunCount", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JTabbedPane.html#isEnabledAt(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsEnabledAt(int arg0)
        {
            return IExecuteWithSignature<bool>("isEnabledAt", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JTabbedPane.html#getDisplayedMnemonicIndexAt(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetDisplayedMnemonicIndexAt(int arg0)
        {
            return IExecuteWithSignature<int>("getDisplayedMnemonicIndexAt", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JTabbedPane.html#getMnemonicAt(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetMnemonicAt(int arg0)
        {
            return IExecuteWithSignature<int>("getMnemonicAt", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JTabbedPane.html#indexAtLocation(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int IndexAtLocation(int arg0, int arg1)
        {
            return IExecute<int>("indexAtLocation", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JTabbedPane.html#indexOfComponent(java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <returns><see cref="int"/></returns>
        public int IndexOfComponent(Java.Awt.Component arg0)
        {
            return IExecuteWithSignature<int>("indexOfComponent", "(Ljava/awt/Component;)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JTabbedPane.html#indexOfTab(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="int"/></returns>
        public int IndexOfTab(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<int>("indexOfTab", "(Ljava/lang/String;)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JTabbedPane.html#indexOfTab(javax.swing.Icon)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Icon"/></param>
        /// <returns><see cref="int"/></returns>
        public int IndexOfTab(Javax.Swing.Icon arg0)
        {
            return IExecuteWithSignature<int>("indexOfTab", "(Ljavax/swing/Icon;)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JTabbedPane.html#indexOfTabComponent(java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <returns><see cref="int"/></returns>
        public int IndexOfTabComponent(Java.Awt.Component arg0)
        {
            return IExecuteWithSignature<int>("indexOfTabComponent", "(Ljava/awt/Component;)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JTabbedPane.html#getBackgroundAt(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.Color"/></returns>
        public Java.Awt.Color GetBackgroundAt(int arg0)
        {
            return IExecuteWithSignature<Java.Awt.Color>("getBackgroundAt", "(I)Ljava/awt/Color;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JTabbedPane.html#getForegroundAt(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.Color"/></returns>
        public Java.Awt.Color GetForegroundAt(int arg0)
        {
            return IExecuteWithSignature<Java.Awt.Color>("getForegroundAt", "(I)Ljava/awt/Color;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JTabbedPane.html#getComponentAt(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.Component"/></returns>
        public Java.Awt.Component GetComponentAt(int arg0)
        {
            return IExecuteWithSignature<Java.Awt.Component>("getComponentAt", "(I)Ljava/awt/Component;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JTabbedPane.html#getTabComponentAt(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.Component"/></returns>
        public Java.Awt.Component GetTabComponentAt(int arg0)
        {
            return IExecuteWithSignature<Java.Awt.Component>("getTabComponentAt", "(I)Ljava/awt/Component;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JTabbedPane.html#getBoundsAt(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.Rectangle"/></returns>
        public Java.Awt.Rectangle GetBoundsAt(int arg0)
        {
            return IExecuteWithSignature<Java.Awt.Rectangle>("getBoundsAt", "(I)Ljava/awt/Rectangle;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JTabbedPane.html#getTitleAt(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetTitleAt(int arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("getTitleAt", "(I)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JTabbedPane.html#getToolTipTextAt(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetToolTipTextAt(int arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("getToolTipTextAt", "(I)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JTabbedPane.html#getDisabledIconAt(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Javax.Swing.Icon"/></returns>
        public Javax.Swing.Icon GetDisabledIconAt(int arg0)
        {
            return IExecuteWithSignature<Javax.Swing.Icon>("getDisabledIconAt", "(I)Ljavax/swing/Icon;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JTabbedPane.html#getIconAt(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Javax.Swing.Icon"/></returns>
        public Javax.Swing.Icon GetIconAt(int arg0)
        {
            return IExecuteWithSignature<Javax.Swing.Icon>("getIconAt", "(I)Ljavax/swing/Icon;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JTabbedPane.html#addChangeListener(javax.swing.event.ChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.ChangeListener"/></param>
        public void AddChangeListener(Javax.Swing.Event.ChangeListener arg0)
        {
            IExecuteWithSignature("addChangeListener", "(Ljavax/swing/event/ChangeListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JTabbedPane.html#addTab(java.lang.String,java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Component"/></param>
        public void AddTab(Java.Lang.String arg0, Java.Awt.Component arg1)
        {
            IExecute("addTab", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JTabbedPane.html#addTab(java.lang.String,javax.swing.Icon,java.awt.Component,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Javax.Swing.Icon"/></param>
        /// <param name="arg2"><see cref="Java.Awt.Component"/></param>
        /// <param name="arg3"><see cref="Java.Lang.String"/></param>
        public void AddTab(Java.Lang.String arg0, Javax.Swing.Icon arg1, Java.Awt.Component arg2, Java.Lang.String arg3)
        {
            IExecute("addTab", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JTabbedPane.html#addTab(java.lang.String,javax.swing.Icon,java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Javax.Swing.Icon"/></param>
        /// <param name="arg2"><see cref="Java.Awt.Component"/></param>
        public void AddTab(Java.Lang.String arg0, Javax.Swing.Icon arg1, Java.Awt.Component arg2)
        {
            IExecute("addTab", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JTabbedPane.html#insertTab(java.lang.String,javax.swing.Icon,java.awt.Component,java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Javax.Swing.Icon"/></param>
        /// <param name="arg2"><see cref="Java.Awt.Component"/></param>
        /// <param name="arg3"><see cref="Java.Lang.String"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        public void InsertTab(Java.Lang.String arg0, Javax.Swing.Icon arg1, Java.Awt.Component arg2, Java.Lang.String arg3, int arg4)
        {
            IExecute("insertTab", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JTabbedPane.html#removeChangeListener(javax.swing.event.ChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.ChangeListener"/></param>
        public void RemoveChangeListener(Javax.Swing.Event.ChangeListener arg0)
        {
            IExecuteWithSignature("removeChangeListener", "(Ljavax/swing/event/ChangeListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JTabbedPane.html#removeTabAt(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void RemoveTabAt(int arg0)
        {
            IExecuteWithSignature("removeTabAt", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JTabbedPane.html#setBackgroundAt(int,java.awt.Color)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Color"/></param>
        public void SetBackgroundAt(int arg0, Java.Awt.Color arg1)
        {
            IExecute("setBackgroundAt", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JTabbedPane.html#setComponentAt(int,java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Component"/></param>
        public void SetComponentAt(int arg0, Java.Awt.Component arg1)
        {
            IExecute("setComponentAt", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JTabbedPane.html#setDisabledIconAt(int,javax.swing.Icon)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Javax.Swing.Icon"/></param>
        public void SetDisabledIconAt(int arg0, Javax.Swing.Icon arg1)
        {
            IExecute("setDisabledIconAt", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JTabbedPane.html#setDisplayedMnemonicIndexAt(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void SetDisplayedMnemonicIndexAt(int arg0, int arg1)
        {
            IExecute("setDisplayedMnemonicIndexAt", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JTabbedPane.html#setEnabledAt(int,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        public void SetEnabledAt(int arg0, bool arg1)
        {
            IExecute("setEnabledAt", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JTabbedPane.html#setForegroundAt(int,java.awt.Color)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Color"/></param>
        public void SetForegroundAt(int arg0, Java.Awt.Color arg1)
        {
            IExecute("setForegroundAt", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JTabbedPane.html#setIconAt(int,javax.swing.Icon)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Javax.Swing.Icon"/></param>
        public void SetIconAt(int arg0, Javax.Swing.Icon arg1)
        {
            IExecute("setIconAt", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JTabbedPane.html#setMnemonicAt(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void SetMnemonicAt(int arg0, int arg1)
        {
            IExecute("setMnemonicAt", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JTabbedPane.html#setTabComponentAt(int,java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Component"/></param>
        public void SetTabComponentAt(int arg0, Java.Awt.Component arg1)
        {
            IExecute("setTabComponentAt", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JTabbedPane.html#setTitleAt(int,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        public void SetTitleAt(int arg0, Java.Lang.String arg1)
        {
            IExecute("setTitleAt", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JTabbedPane.html#setToolTipTextAt(int,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        public void SetToolTipTextAt(int arg0, Java.Lang.String arg1)
        {
            IExecute("setToolTipTextAt", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JTabbedPane.html#setUI(javax.swing.plaf.TabbedPaneUI)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Plaf.TabbedPaneUI"/></param>
        public void SetUI(Javax.Swing.Plaf.TabbedPaneUI arg0)
        {
            IExecuteWithSignature("setUI", "(Ljavax/swing/plaf/TabbedPaneUI;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}