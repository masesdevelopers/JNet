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

namespace Javax.Swing
{
    #region JScrollPane declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JScrollPane.html"/>
    /// </summary>
    public partial class JScrollPane : Javax.Swing.JComponent
    {
        const string _bridgeClassName = "javax.swing.JScrollPane";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public JScrollPane() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public JScrollPane(params object[] args) : base(args) { }

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

    #region JScrollPane implementation
    public partial class JScrollPane
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JScrollPane.html#%3Cinit%3E(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public JScrollPane(int arg0, int arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JScrollPane.html#%3Cinit%3E(java.awt.Component,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public JScrollPane(Java.Awt.Component arg0, int arg1, int arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JScrollPane.html#%3Cinit%3E(java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        public JScrollPane(Java.Awt.Component arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Swing.JScrollPane"/> to <see cref="Javax.Swing.ScrollPaneConstants"/>
        /// </summary>
        public static implicit operator Javax.Swing.ScrollPaneConstants(Javax.Swing.JScrollPane t) => t.Cast<Javax.Swing.ScrollPaneConstants>();
        /// <summary>
        /// Converter from <see cref="Javax.Swing.JScrollPane"/> to <see cref="Javax.Accessibility.Accessible"/>
        /// </summary>
        public static implicit operator Javax.Accessibility.Accessible(Javax.Swing.JScrollPane t) => t.Cast<Javax.Accessibility.Accessible>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JScrollPane.html#getColumnHeader()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JScrollPane.html#setColumnHeader(javax.swing.JViewport)"/>
        /// </summary>
        public Javax.Swing.JViewport ColumnHeader
        {
            get { return IExecuteWithSignature<Javax.Swing.JViewport>("getColumnHeader", "()Ljavax/swing/JViewport;"); } set { IExecuteWithSignature("setColumnHeader", "(Ljavax/swing/JViewport;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JScrollPane.html#getHorizontalScrollBar()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JScrollPane.html#setHorizontalScrollBar(javax.swing.JScrollBar)"/>
        /// </summary>
        public Javax.Swing.JScrollBar HorizontalScrollBar
        {
            get { return IExecuteWithSignature<Javax.Swing.JScrollBar>("getHorizontalScrollBar", "()Ljavax/swing/JScrollBar;"); } set { IExecuteWithSignature("setHorizontalScrollBar", "(Ljavax/swing/JScrollBar;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JScrollPane.html#getHorizontalScrollBarPolicy()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JScrollPane.html#setHorizontalScrollBarPolicy(int)"/>
        /// </summary>
        public int HorizontalScrollBarPolicy
        {
            get { return IExecuteWithSignature<int>("getHorizontalScrollBarPolicy", "()I"); } set { IExecuteWithSignature("setHorizontalScrollBarPolicy", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JScrollPane.html#getRowHeader()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JScrollPane.html#setRowHeader(javax.swing.JViewport)"/>
        /// </summary>
        public Javax.Swing.JViewport RowHeader
        {
            get { return IExecuteWithSignature<Javax.Swing.JViewport>("getRowHeader", "()Ljavax/swing/JViewport;"); } set { IExecuteWithSignature("setRowHeader", "(Ljavax/swing/JViewport;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JScrollPane.html#getVerticalScrollBar()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JScrollPane.html#setVerticalScrollBar(javax.swing.JScrollBar)"/>
        /// </summary>
        public Javax.Swing.JScrollBar VerticalScrollBar
        {
            get { return IExecuteWithSignature<Javax.Swing.JScrollBar>("getVerticalScrollBar", "()Ljavax/swing/JScrollBar;"); } set { IExecuteWithSignature("setVerticalScrollBar", "(Ljavax/swing/JScrollBar;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JScrollPane.html#getVerticalScrollBarPolicy()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JScrollPane.html#setVerticalScrollBarPolicy(int)"/>
        /// </summary>
        public int VerticalScrollBarPolicy
        {
            get { return IExecuteWithSignature<int>("getVerticalScrollBarPolicy", "()I"); } set { IExecuteWithSignature("setVerticalScrollBarPolicy", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JScrollPane.html#getViewport()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JScrollPane.html#setViewport(javax.swing.JViewport)"/>
        /// </summary>
        public Javax.Swing.JViewport Viewport
        {
            get { return IExecuteWithSignature<Javax.Swing.JViewport>("getViewport", "()Ljavax/swing/JViewport;"); } set { IExecuteWithSignature("setViewport", "(Ljavax/swing/JViewport;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JScrollPane.html#getViewportBorder()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JScrollPane.html#setViewportBorder(javax.swing.border.Border)"/>
        /// </summary>
        public Javax.Swing.Border.Border ViewportBorder
        {
            get { return IExecuteWithSignature<Javax.Swing.Border.Border>("getViewportBorder", "()Ljavax/swing/border/Border;"); } set { IExecuteWithSignature("setViewportBorder", "(Ljavax/swing/border/Border;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JScrollPane.html#getViewportBorderBounds()"/> 
        /// </summary>
        public Java.Awt.Rectangle ViewportBorderBounds
        {
            get { return IExecuteWithSignature<Java.Awt.Rectangle>("getViewportBorderBounds", "()Ljava/awt/Rectangle;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JScrollPane.html#isWheelScrollingEnabled()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsWheelScrollingEnabled()
        {
            return IExecuteWithSignature<bool>("isWheelScrollingEnabled", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JScrollPane.html#getCorner(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Awt.Component"/></returns>
        public Java.Awt.Component GetCorner(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Awt.Component>("getCorner", "(Ljava/lang/String;)Ljava/awt/Component;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JScrollPane.html#createHorizontalScrollBar()"/>
        /// </summary>
        /// <returns><see cref="Javax.Swing.JScrollBar"/></returns>
        public Javax.Swing.JScrollBar CreateHorizontalScrollBar()
        {
            return IExecuteWithSignature<Javax.Swing.JScrollBar>("createHorizontalScrollBar", "()Ljavax/swing/JScrollBar;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JScrollPane.html#createVerticalScrollBar()"/>
        /// </summary>
        /// <returns><see cref="Javax.Swing.JScrollBar"/></returns>
        public Javax.Swing.JScrollBar CreateVerticalScrollBar()
        {
            return IExecuteWithSignature<Javax.Swing.JScrollBar>("createVerticalScrollBar", "()Ljavax/swing/JScrollBar;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JScrollPane.html#setColumnHeaderView(java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        public void SetColumnHeaderView(Java.Awt.Component arg0)
        {
            IExecuteWithSignature("setColumnHeaderView", "(Ljava/awt/Component;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JScrollPane.html#setCorner(java.lang.String,java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Component"/></param>
        public void SetCorner(Java.Lang.String arg0, Java.Awt.Component arg1)
        {
            IExecuteWithSignature("setCorner", "(Ljava/lang/String;Ljava/awt/Component;)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JScrollPane.html#setRowHeaderView(java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        public void SetRowHeaderView(Java.Awt.Component arg0)
        {
            IExecuteWithSignature("setRowHeaderView", "(Ljava/awt/Component;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JScrollPane.html#setUI(javax.swing.plaf.ScrollPaneUI)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Plaf.ScrollPaneUI"/></param>
        public void SetUI(Javax.Swing.Plaf.ScrollPaneUI arg0)
        {
            IExecuteWithSignature("setUI", "(Ljavax/swing/plaf/ScrollPaneUI;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JScrollPane.html#setViewportView(java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        public void SetViewportView(Java.Awt.Component arg0)
        {
            IExecuteWithSignature("setViewportView", "(Ljava/awt/Component;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JScrollPane.html#setWheelScrollingEnabled(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetWheelScrollingEnabled(bool arg0)
        {
            IExecuteWithSignature("setWheelScrollingEnabled", "(Z)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}