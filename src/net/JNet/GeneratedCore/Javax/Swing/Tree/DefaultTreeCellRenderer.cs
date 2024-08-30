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

namespace Javax.Swing.Tree
{
    #region DefaultTreeCellRenderer definition
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeCellRenderer.html"/>
    /// </summary>
    public partial class DefaultTreeCellRenderer : Javax.Swing.JLabel
    {
        const string _bridgeClassName = "javax.swing.tree.DefaultTreeCellRenderer";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public DefaultTreeCellRenderer() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public DefaultTreeCellRenderer(params object[] args) : base(args) { }

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

    #region DefaultTreeCellRenderer
    public partial class DefaultTreeCellRenderer
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Swing.Tree.DefaultTreeCellRenderer"/> to <see cref="Javax.Swing.Tree.TreeCellRenderer"/>
        /// </summary>
        public static implicit operator Javax.Swing.Tree.TreeCellRenderer(Javax.Swing.Tree.DefaultTreeCellRenderer t) => t.Cast<Javax.Swing.Tree.TreeCellRenderer>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeCellRenderer.html#getBackgroundNonSelectionColor()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeCellRenderer.html#setBackgroundNonSelectionColor(java.awt.Color)"/>
        /// </summary>
        public Java.Awt.Color BackgroundNonSelectionColor
        {
            get { return IExecuteWithSignature<Java.Awt.Color>("getBackgroundNonSelectionColor", "()Ljava/awt/Color;"); } set { IExecuteWithSignature("setBackgroundNonSelectionColor", "(Ljava/awt/Color;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeCellRenderer.html#getBackgroundSelectionColor()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeCellRenderer.html#setBackgroundSelectionColor(java.awt.Color)"/>
        /// </summary>
        public Java.Awt.Color BackgroundSelectionColor
        {
            get { return IExecuteWithSignature<Java.Awt.Color>("getBackgroundSelectionColor", "()Ljava/awt/Color;"); } set { IExecuteWithSignature("setBackgroundSelectionColor", "(Ljava/awt/Color;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeCellRenderer.html#getBorderSelectionColor()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeCellRenderer.html#setBorderSelectionColor(java.awt.Color)"/>
        /// </summary>
        public Java.Awt.Color BorderSelectionColor
        {
            get { return IExecuteWithSignature<Java.Awt.Color>("getBorderSelectionColor", "()Ljava/awt/Color;"); } set { IExecuteWithSignature("setBorderSelectionColor", "(Ljava/awt/Color;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeCellRenderer.html#getClosedIcon()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeCellRenderer.html#setClosedIcon(javax.swing.Icon)"/>
        /// </summary>
        public Javax.Swing.Icon ClosedIcon
        {
            get { return IExecuteWithSignature<Javax.Swing.Icon>("getClosedIcon", "()Ljavax/swing/Icon;"); } set { IExecuteWithSignature("setClosedIcon", "(Ljavax/swing/Icon;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeCellRenderer.html#getDefaultClosedIcon()"/> 
        /// </summary>
        public Javax.Swing.Icon DefaultClosedIcon
        {
            get { return IExecuteWithSignature<Javax.Swing.Icon>("getDefaultClosedIcon", "()Ljavax/swing/Icon;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeCellRenderer.html#getDefaultLeafIcon()"/> 
        /// </summary>
        public Javax.Swing.Icon DefaultLeafIcon
        {
            get { return IExecuteWithSignature<Javax.Swing.Icon>("getDefaultLeafIcon", "()Ljavax/swing/Icon;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeCellRenderer.html#getDefaultOpenIcon()"/> 
        /// </summary>
        public Javax.Swing.Icon DefaultOpenIcon
        {
            get { return IExecuteWithSignature<Javax.Swing.Icon>("getDefaultOpenIcon", "()Ljavax/swing/Icon;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeCellRenderer.html#getLeafIcon()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeCellRenderer.html#setLeafIcon(javax.swing.Icon)"/>
        /// </summary>
        public Javax.Swing.Icon LeafIcon
        {
            get { return IExecuteWithSignature<Javax.Swing.Icon>("getLeafIcon", "()Ljavax/swing/Icon;"); } set { IExecuteWithSignature("setLeafIcon", "(Ljavax/swing/Icon;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeCellRenderer.html#getOpenIcon()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeCellRenderer.html#setOpenIcon(javax.swing.Icon)"/>
        /// </summary>
        public Javax.Swing.Icon OpenIcon
        {
            get { return IExecuteWithSignature<Javax.Swing.Icon>("getOpenIcon", "()Ljavax/swing/Icon;"); } set { IExecuteWithSignature("setOpenIcon", "(Ljavax/swing/Icon;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeCellRenderer.html#getTextNonSelectionColor()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeCellRenderer.html#setTextNonSelectionColor(java.awt.Color)"/>
        /// </summary>
        public Java.Awt.Color TextNonSelectionColor
        {
            get { return IExecuteWithSignature<Java.Awt.Color>("getTextNonSelectionColor", "()Ljava/awt/Color;"); } set { IExecuteWithSignature("setTextNonSelectionColor", "(Ljava/awt/Color;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeCellRenderer.html#getTextSelectionColor()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeCellRenderer.html#setTextSelectionColor(java.awt.Color)"/>
        /// </summary>
        public Java.Awt.Color TextSelectionColor
        {
            get { return IExecuteWithSignature<Java.Awt.Color>("getTextSelectionColor", "()Ljava/awt/Color;"); } set { IExecuteWithSignature("setTextSelectionColor", "(Ljava/awt/Color;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeCellRenderer.html#getTreeCellRendererComponent(javax.swing.JTree,java.lang.Object,boolean,boolean,boolean,int,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JTree"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        /// <param name="arg3"><see cref="bool"/></param>
        /// <param name="arg4"><see cref="bool"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <param name="arg6"><see cref="bool"/></param>
        /// <returns><see cref="Java.Awt.Component"/></returns>
        public Java.Awt.Component GetTreeCellRendererComponent(Javax.Swing.JTree arg0, object arg1, bool arg2, bool arg3, bool arg4, int arg5, bool arg6)
        {
            return IExecute<Java.Awt.Component>("getTreeCellRendererComponent", arg0, arg1, arg2, arg3, arg4, arg5, arg6);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}