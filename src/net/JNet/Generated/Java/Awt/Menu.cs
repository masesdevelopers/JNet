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
    #region Menu declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Menu.html"/>
    /// </summary>
    public partial class Menu : Java.Awt.MenuItem
    {
        const string _bridgeClassName = "java.awt.Menu";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public Menu() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public Menu(params object[] args) : base(args) { }

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

    #region Menu implementation
    public partial class Menu
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Menu.html#%3Cinit%3E(java.lang.String,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <exception cref="Java.Awt.HeadlessException"/>
        public Menu(Java.Lang.String arg0, bool arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Menu.html#%3Cinit%3E(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Java.Awt.HeadlessException"/>
        public Menu(Java.Lang.String arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Awt.Menu"/> to <see cref="Java.Awt.MenuContainer"/>
        /// </summary>
        public static implicit operator Java.Awt.MenuContainer(Java.Awt.Menu t) => t.Cast<Java.Awt.MenuContainer>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Menu.html#getItemCount()"/> 
        /// </summary>
        public int ItemCount
        {
            get { return IExecuteWithSignature<int>("getItemCount", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Menu.html#isTearOff()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsTearOff()
        {
            return IExecuteWithSignature<bool>("isTearOff", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Menu.html#add(java.awt.MenuItem)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.MenuItem"/></param>
        /// <returns><see cref="Java.Awt.MenuItem"/></returns>
        public Java.Awt.MenuItem Add(Java.Awt.MenuItem arg0)
        {
            return IExecuteWithSignature<Java.Awt.MenuItem>("add", "(Ljava/awt/MenuItem;)Ljava/awt/MenuItem;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Menu.html#getItem(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.MenuItem"/></returns>
        public Java.Awt.MenuItem GetItem(int arg0)
        {
            return IExecuteWithSignature<Java.Awt.MenuItem>("getItem", "(I)Ljava/awt/MenuItem;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Menu.html#add(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void Add(Java.Lang.String arg0)
        {
            IExecuteWithSignature("add", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Menu.html#addSeparator()"/>
        /// </summary>
        public void AddSeparator()
        {
            IExecuteWithSignature("addSeparator", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Menu.html#insert(java.awt.MenuItem,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.MenuItem"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void Insert(Java.Awt.MenuItem arg0, int arg1)
        {
            IExecuteWithSignature("insert", "(Ljava/awt/MenuItem;I)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Menu.html#insert(java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void Insert(Java.Lang.String arg0, int arg1)
        {
            IExecuteWithSignature("insert", "(Ljava/lang/String;I)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Menu.html#insertSeparator(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void InsertSeparator(int arg0)
        {
            IExecuteWithSignature("insertSeparator", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Menu.html#remove(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void Remove(int arg0)
        {
            IExecuteWithSignature("remove", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Menu.html#remove(java.awt.MenuComponent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.MenuComponent"/></param>
        public void Remove(Java.Awt.MenuComponent arg0)
        {
            IExecuteWithSignature("remove", "(Ljava/awt/MenuComponent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Menu.html#removeAll()"/>
        /// </summary>
        public void RemoveAll()
        {
            IExecuteWithSignature("removeAll", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}