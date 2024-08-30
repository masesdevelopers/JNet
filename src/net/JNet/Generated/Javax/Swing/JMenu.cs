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
    #region JMenu declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JMenu.html"/>
    /// </summary>
    public partial class JMenu : Javax.Swing.JMenuItem
    {
        const string _bridgeClassName = "javax.swing.JMenu";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public JMenu() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public JMenu(params object[] args) : base(args) { }

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

    }
    #endregion

    #region JMenu implementation
    public partial class JMenu
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JMenu.html#%3Cinit%3E(java.lang.String,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        public JMenu(Java.Lang.String arg0, bool arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JMenu.html#%3Cinit%3E(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public JMenu(Java.Lang.String arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JMenu.html#%3Cinit%3E(javax.swing.Action)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Action"/></param>
        public JMenu(Javax.Swing.Action arg0)
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JMenu.html#getDelay()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JMenu.html#setDelay(int)"/>
        /// </summary>
        public int Delay
        {
            get { return IExecuteWithSignature<int>("getDelay", "()I"); } set { IExecuteWithSignature("setDelay", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JMenu.html#getItemCount()"/> 
        /// </summary>
        public int ItemCount
        {
            get { return IExecuteWithSignature<int>("getItemCount", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JMenu.html#getMenuComponentCount()"/> 
        /// </summary>
        public int MenuComponentCount
        {
            get { return IExecuteWithSignature<int>("getMenuComponentCount", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JMenu.html#getMenuComponents()"/> 
        /// </summary>
        public Java.Awt.Component[] MenuComponents
        {
            get { return IExecuteWithSignatureArray<Java.Awt.Component>("getMenuComponents", "()[Ljava/awt/Component;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JMenu.html#getMenuListeners()"/> 
        /// </summary>
        public Javax.Swing.Event.MenuListener[] MenuListeners
        {
            get { return IExecuteWithSignatureArray<Javax.Swing.Event.MenuListener>("getMenuListeners", "()[Ljavax/swing/event/MenuListener;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JMenu.html#getPopupMenu()"/> 
        /// </summary>
        public Javax.Swing.JPopupMenu PopupMenu
        {
            get { return IExecuteWithSignature<Javax.Swing.JPopupMenu>("getPopupMenu", "()Ljavax/swing/JPopupMenu;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JMenu.html#isMenuComponent(java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsMenuComponent(Java.Awt.Component arg0)
        {
            return IExecuteWithSignature<bool>("isMenuComponent", "(Ljava/awt/Component;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JMenu.html#isPopupMenuVisible()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsPopupMenuVisible()
        {
            return IExecuteWithSignature<bool>("isPopupMenuVisible", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JMenu.html#isTearOff()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsTearOff()
        {
            return IExecuteWithSignature<bool>("isTearOff", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JMenu.html#isTopLevelMenu()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsTopLevelMenu()
        {
            return IExecuteWithSignature<bool>("isTopLevelMenu", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JMenu.html#getMenuComponent(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.Component"/></returns>
        public Java.Awt.Component GetMenuComponent(int arg0)
        {
            return IExecuteWithSignature<Java.Awt.Component>("getMenuComponent", "(I)Ljava/awt/Component;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JMenu.html#add(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Swing.JMenuItem"/></returns>
        public Javax.Swing.JMenuItem Add(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Javax.Swing.JMenuItem>("add", "(Ljava/lang/String;)Ljavax/swing/JMenuItem;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JMenu.html#add(javax.swing.Action)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Action"/></param>
        /// <returns><see cref="Javax.Swing.JMenuItem"/></returns>
        public Javax.Swing.JMenuItem Add(Javax.Swing.Action arg0)
        {
            return IExecuteWithSignature<Javax.Swing.JMenuItem>("add", "(Ljavax/swing/Action;)Ljavax/swing/JMenuItem;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JMenu.html#add(javax.swing.JMenuItem)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JMenuItem"/></param>
        /// <returns><see cref="Javax.Swing.JMenuItem"/></returns>
        public Javax.Swing.JMenuItem Add(Javax.Swing.JMenuItem arg0)
        {
            return IExecuteWithSignature<Javax.Swing.JMenuItem>("add", "(Ljavax/swing/JMenuItem;)Ljavax/swing/JMenuItem;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JMenu.html#getItem(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Javax.Swing.JMenuItem"/></returns>
        public Javax.Swing.JMenuItem GetItem(int arg0)
        {
            return IExecuteWithSignature<Javax.Swing.JMenuItem>("getItem", "(I)Ljavax/swing/JMenuItem;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JMenu.html#insert(javax.swing.Action,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Action"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Javax.Swing.JMenuItem"/></returns>
        public Javax.Swing.JMenuItem Insert(Javax.Swing.Action arg0, int arg1)
        {
            return IExecute<Javax.Swing.JMenuItem>("insert", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JMenu.html#insert(javax.swing.JMenuItem,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JMenuItem"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Javax.Swing.JMenuItem"/></returns>
        public Javax.Swing.JMenuItem Insert(Javax.Swing.JMenuItem arg0, int arg1)
        {
            return IExecute<Javax.Swing.JMenuItem>("insert", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JMenu.html#addMenuListener(javax.swing.event.MenuListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.MenuListener"/></param>
        public void AddMenuListener(Javax.Swing.Event.MenuListener arg0)
        {
            IExecuteWithSignature("addMenuListener", "(Ljavax/swing/event/MenuListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JMenu.html#addSeparator()"/>
        /// </summary>
        public void AddSeparator()
        {
            IExecuteWithSignature("addSeparator", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JMenu.html#insert(java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void Insert(Java.Lang.String arg0, int arg1)
        {
            IExecute("insert", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JMenu.html#insertSeparator(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void InsertSeparator(int arg0)
        {
            IExecuteWithSignature("insertSeparator", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JMenu.html#remove(javax.swing.JMenuItem)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JMenuItem"/></param>
        public void Remove(Javax.Swing.JMenuItem arg0)
        {
            IExecuteWithSignature("remove", "(Ljavax/swing/JMenuItem;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JMenu.html#removeMenuListener(javax.swing.event.MenuListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.MenuListener"/></param>
        public void RemoveMenuListener(Javax.Swing.Event.MenuListener arg0)
        {
            IExecuteWithSignature("removeMenuListener", "(Ljavax/swing/event/MenuListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JMenu.html#setMenuLocation(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void SetMenuLocation(int arg0, int arg1)
        {
            IExecute("setMenuLocation", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JMenu.html#setPopupMenuVisible(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetPopupMenuVisible(bool arg0)
        {
            IExecuteWithSignature("setPopupMenuVisible", "(Z)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}