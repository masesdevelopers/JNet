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
    #region BoxLayout declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/BoxLayout.html"/>
    /// </summary>
    public partial class BoxLayout : MASES.JCOBridge.C2JBridge.JVMBridgeBase<BoxLayout>
    {
        const string _bridgeClassName = "javax.swing.BoxLayout";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public BoxLayout() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public BoxLayout(params object[] args) : base(args) { }

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

    #region BoxLayout implementation
    public partial class BoxLayout
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/BoxLayout.html#%3Cinit%3E(java.awt.Container,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Container"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public BoxLayout(Java.Awt.Container arg0, int arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Swing.BoxLayout"/> to <see cref="Java.Awt.LayoutManager2"/>
        /// </summary>
        public static implicit operator Java.Awt.LayoutManager2(Javax.Swing.BoxLayout t) => t.Cast<Java.Awt.LayoutManager2>();
        /// <summary>
        /// Converter from <see cref="Javax.Swing.BoxLayout"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Javax.Swing.BoxLayout t) => t.Cast<Java.Io.Serializable>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/BoxLayout.html#LINE_AXIS"/>
        /// </summary>
        public static int LINE_AXIS { get { if (!_LINE_AXISReady) { _LINE_AXISContent = SGetField<int>(LocalBridgeClazz, "LINE_AXIS"); _LINE_AXISReady = true; } return _LINE_AXISContent; } }
        private static int _LINE_AXISContent = default;
        private static bool _LINE_AXISReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/BoxLayout.html#PAGE_AXIS"/>
        /// </summary>
        public static int PAGE_AXIS { get { if (!_PAGE_AXISReady) { _PAGE_AXISContent = SGetField<int>(LocalBridgeClazz, "PAGE_AXIS"); _PAGE_AXISReady = true; } return _PAGE_AXISContent; } }
        private static int _PAGE_AXISContent = default;
        private static bool _PAGE_AXISReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/BoxLayout.html#X_AXIS"/>
        /// </summary>
        public static int X_AXIS { get { if (!_X_AXISReady) { _X_AXISContent = SGetField<int>(LocalBridgeClazz, "X_AXIS"); _X_AXISReady = true; } return _X_AXISContent; } }
        private static int _X_AXISContent = default;
        private static bool _X_AXISReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/BoxLayout.html#Y_AXIS"/>
        /// </summary>
        public static int Y_AXIS { get { if (!_Y_AXISReady) { _Y_AXISContent = SGetField<int>(LocalBridgeClazz, "Y_AXIS"); _Y_AXISReady = true; } return _Y_AXISContent; } }
        private static int _Y_AXISContent = default;
        private static bool _Y_AXISReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/BoxLayout.html#getAxis()"/> 
        /// </summary>
        public int Axis
        {
            get { return IExecuteWithSignature<int>("getAxis", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/BoxLayout.html#getTarget()"/> 
        /// </summary>
        public Java.Awt.Container Target
        {
            get { return IExecuteWithSignature<Java.Awt.Container>("getTarget", "()Ljava/awt/Container;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/BoxLayout.html#maximumLayoutSize(java.awt.Container)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Container"/></param>
        /// <returns><see cref="Java.Awt.Dimension"/></returns>
        public Java.Awt.Dimension MaximumLayoutSize(Java.Awt.Container arg0)
        {
            return IExecuteWithSignature<Java.Awt.Dimension>("maximumLayoutSize", "(Ljava/awt/Container;)Ljava/awt/Dimension;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/BoxLayout.html#minimumLayoutSize(java.awt.Container)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Container"/></param>
        /// <returns><see cref="Java.Awt.Dimension"/></returns>
        public Java.Awt.Dimension MinimumLayoutSize(Java.Awt.Container arg0)
        {
            return IExecuteWithSignature<Java.Awt.Dimension>("minimumLayoutSize", "(Ljava/awt/Container;)Ljava/awt/Dimension;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/BoxLayout.html#preferredLayoutSize(java.awt.Container)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Container"/></param>
        /// <returns><see cref="Java.Awt.Dimension"/></returns>
        public Java.Awt.Dimension PreferredLayoutSize(Java.Awt.Container arg0)
        {
            return IExecuteWithSignature<Java.Awt.Dimension>("preferredLayoutSize", "(Ljava/awt/Container;)Ljava/awt/Dimension;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/BoxLayout.html#getLayoutAlignmentX(java.awt.Container)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Container"/></param>
        /// <returns><see cref="float"/></returns>
        public float GetLayoutAlignmentX(Java.Awt.Container arg0)
        {
            return IExecuteWithSignature<float>("getLayoutAlignmentX", "(Ljava/awt/Container;)F", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/BoxLayout.html#getLayoutAlignmentY(java.awt.Container)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Container"/></param>
        /// <returns><see cref="float"/></returns>
        public float GetLayoutAlignmentY(Java.Awt.Container arg0)
        {
            return IExecuteWithSignature<float>("getLayoutAlignmentY", "(Ljava/awt/Container;)F", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/BoxLayout.html#invalidateLayout(java.awt.Container)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Container"/></param>
        public void InvalidateLayout(Java.Awt.Container arg0)
        {
            IExecuteWithSignature("invalidateLayout", "(Ljava/awt/Container;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/BoxLayout.html#addLayoutComponent(java.awt.Component,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        public void AddLayoutComponent(Java.Awt.Component arg0, object arg1)
        {
            IExecute("addLayoutComponent", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/BoxLayout.html#addLayoutComponent(java.lang.String,java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Component"/></param>
        public void AddLayoutComponent(Java.Lang.String arg0, Java.Awt.Component arg1)
        {
            IExecute("addLayoutComponent", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/BoxLayout.html#layoutContainer(java.awt.Container)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Container"/></param>
        public void LayoutContainer(Java.Awt.Container arg0)
        {
            IExecuteWithSignature("layoutContainer", "(Ljava/awt/Container;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/BoxLayout.html#removeLayoutComponent(java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        public void RemoveLayoutComponent(Java.Awt.Component arg0)
        {
            IExecuteWithSignature("removeLayoutComponent", "(Ljava/awt/Component;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}