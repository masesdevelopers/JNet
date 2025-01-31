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

namespace Javax.Swing
{
    #region JViewport declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JViewport.html"/>
    /// </summary>
    public partial class JViewport : Javax.Swing.JComponent
    {
        const string _bridgeClassName = "javax.swing.JViewport";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public JViewport() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public JViewport(params object[] args) : base(args) { }

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

    #region JViewport implementation
    public partial class JViewport
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Swing.JViewport"/> to <see cref="Javax.Accessibility.Accessible"/>
        /// </summary>
        public static implicit operator Javax.Accessibility.Accessible(Javax.Swing.JViewport t) => t.Cast<Javax.Accessibility.Accessible>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JViewport.html#BACKINGSTORE_SCROLL_MODE"/>
        /// </summary>
        public static int BACKINGSTORE_SCROLL_MODE { get { if (!_BACKINGSTORE_SCROLL_MODEReady) { _BACKINGSTORE_SCROLL_MODEContent = SGetField<int>(LocalBridgeClazz, "BACKINGSTORE_SCROLL_MODE"); _BACKINGSTORE_SCROLL_MODEReady = true; } return _BACKINGSTORE_SCROLL_MODEContent; } }
        private static int _BACKINGSTORE_SCROLL_MODEContent = default;
        private static bool _BACKINGSTORE_SCROLL_MODEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JViewport.html#BLIT_SCROLL_MODE"/>
        /// </summary>
        public static int BLIT_SCROLL_MODE { get { if (!_BLIT_SCROLL_MODEReady) { _BLIT_SCROLL_MODEContent = SGetField<int>(LocalBridgeClazz, "BLIT_SCROLL_MODE"); _BLIT_SCROLL_MODEReady = true; } return _BLIT_SCROLL_MODEContent; } }
        private static int _BLIT_SCROLL_MODEContent = default;
        private static bool _BLIT_SCROLL_MODEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JViewport.html#SIMPLE_SCROLL_MODE"/>
        /// </summary>
        public static int SIMPLE_SCROLL_MODE { get { if (!_SIMPLE_SCROLL_MODEReady) { _SIMPLE_SCROLL_MODEContent = SGetField<int>(LocalBridgeClazz, "SIMPLE_SCROLL_MODE"); _SIMPLE_SCROLL_MODEReady = true; } return _SIMPLE_SCROLL_MODEContent; } }
        private static int _SIMPLE_SCROLL_MODEContent = default;
        private static bool _SIMPLE_SCROLL_MODEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JViewport.html#getChangeListeners()"/> 
        /// </summary>
        public Javax.Swing.Event.ChangeListener[] ChangeListeners
        {
            get { return IExecuteWithSignatureArray<Javax.Swing.Event.ChangeListener>("getChangeListeners", "()[Ljavax/swing/event/ChangeListener;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JViewport.html#getExtentSize()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JViewport.html#setExtentSize(java.awt.Dimension)"/>
        /// </summary>
        public Java.Awt.Dimension ExtentSize
        {
            get { return IExecuteWithSignature<Java.Awt.Dimension>("getExtentSize", "()Ljava/awt/Dimension;"); } set { IExecuteWithSignature("setExtentSize", "(Ljava/awt/Dimension;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JViewport.html#getScrollMode()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JViewport.html#setScrollMode(int)"/>
        /// </summary>
        public int ScrollMode
        {
            get { return IExecuteWithSignature<int>("getScrollMode", "()I"); } set { IExecuteWithSignature("setScrollMode", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JViewport.html#getView()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JViewport.html#setView(java.awt.Component)"/>
        /// </summary>
        public Java.Awt.Component View
        {
            get { return IExecuteWithSignature<Java.Awt.Component>("getView", "()Ljava/awt/Component;"); } set { IExecuteWithSignature("setView", "(Ljava/awt/Component;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JViewport.html#getViewPosition()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JViewport.html#setViewPosition(java.awt.Point)"/>
        /// </summary>
        public Java.Awt.Point ViewPosition
        {
            get { return IExecuteWithSignature<Java.Awt.Point>("getViewPosition", "()Ljava/awt/Point;"); } set { IExecuteWithSignature("setViewPosition", "(Ljava/awt/Point;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JViewport.html#getViewRect()"/> 
        /// </summary>
        public Java.Awt.Rectangle ViewRect
        {
            get { return IExecuteWithSignature<Java.Awt.Rectangle>("getViewRect", "()Ljava/awt/Rectangle;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JViewport.html#getViewSize()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JViewport.html#setViewSize(java.awt.Dimension)"/>
        /// </summary>
        public Java.Awt.Dimension ViewSize
        {
            get { return IExecuteWithSignature<Java.Awt.Dimension>("getViewSize", "()Ljava/awt/Dimension;"); } set { IExecuteWithSignature("setViewSize", "(Ljava/awt/Dimension;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JViewport.html#toViewCoordinates(java.awt.Dimension)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Dimension"/></param>
        /// <returns><see cref="Java.Awt.Dimension"/></returns>
        public Java.Awt.Dimension ToViewCoordinates(Java.Awt.Dimension arg0)
        {
            return IExecuteWithSignature<Java.Awt.Dimension>("toViewCoordinates", "(Ljava/awt/Dimension;)Ljava/awt/Dimension;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JViewport.html#toViewCoordinates(java.awt.Point)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Point"/></param>
        /// <returns><see cref="Java.Awt.Point"/></returns>
        public Java.Awt.Point ToViewCoordinates(Java.Awt.Point arg0)
        {
            return IExecuteWithSignature<Java.Awt.Point>("toViewCoordinates", "(Ljava/awt/Point;)Ljava/awt/Point;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JViewport.html#addChangeListener(javax.swing.event.ChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.ChangeListener"/></param>
        public void AddChangeListener(Javax.Swing.Event.ChangeListener arg0)
        {
            IExecuteWithSignature("addChangeListener", "(Ljavax/swing/event/ChangeListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JViewport.html#removeChangeListener(javax.swing.event.ChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.ChangeListener"/></param>
        public void RemoveChangeListener(Javax.Swing.Event.ChangeListener arg0)
        {
            IExecuteWithSignature("removeChangeListener", "(Ljavax/swing/event/ChangeListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JViewport.html#setUI(javax.swing.plaf.ViewportUI)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Plaf.ViewportUI"/></param>
        public void SetUI(Javax.Swing.Plaf.ViewportUI arg0)
        {
            IExecuteWithSignature("setUI", "(Ljavax/swing/plaf/ViewportUI;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}