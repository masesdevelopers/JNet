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
    #region JLayeredPane declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JLayeredPane.html"/>
    /// </summary>
    public partial class JLayeredPane : Javax.Swing.JComponent
    {
        const string _bridgeClassName = "javax.swing.JLayeredPane";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public JLayeredPane() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public JLayeredPane(params object[] args) : base(args) { }

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

    #region JLayeredPane implementation
    public partial class JLayeredPane
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Swing.JLayeredPane"/> to <see cref="Javax.Accessibility.Accessible"/>
        /// </summary>
        public static implicit operator Javax.Accessibility.Accessible(Javax.Swing.JLayeredPane t) => t.Cast<Javax.Accessibility.Accessible>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JLayeredPane.html#DEFAULT_LAYER"/>
        /// </summary>
        public static Java.Lang.Integer DEFAULT_LAYER { get { if (!_DEFAULT_LAYERReady) { _DEFAULT_LAYERContent = SGetField<Java.Lang.Integer>(LocalBridgeClazz, "DEFAULT_LAYER"); _DEFAULT_LAYERReady = true; } return _DEFAULT_LAYERContent; } }
        private static Java.Lang.Integer _DEFAULT_LAYERContent = default;
        private static bool _DEFAULT_LAYERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JLayeredPane.html#DRAG_LAYER"/>
        /// </summary>
        public static Java.Lang.Integer DRAG_LAYER { get { if (!_DRAG_LAYERReady) { _DRAG_LAYERContent = SGetField<Java.Lang.Integer>(LocalBridgeClazz, "DRAG_LAYER"); _DRAG_LAYERReady = true; } return _DRAG_LAYERContent; } }
        private static Java.Lang.Integer _DRAG_LAYERContent = default;
        private static bool _DRAG_LAYERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JLayeredPane.html#FRAME_CONTENT_LAYER"/>
        /// </summary>
        public static Java.Lang.Integer FRAME_CONTENT_LAYER { get { if (!_FRAME_CONTENT_LAYERReady) { _FRAME_CONTENT_LAYERContent = SGetField<Java.Lang.Integer>(LocalBridgeClazz, "FRAME_CONTENT_LAYER"); _FRAME_CONTENT_LAYERReady = true; } return _FRAME_CONTENT_LAYERContent; } }
        private static Java.Lang.Integer _FRAME_CONTENT_LAYERContent = default;
        private static bool _FRAME_CONTENT_LAYERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JLayeredPane.html#MODAL_LAYER"/>
        /// </summary>
        public static Java.Lang.Integer MODAL_LAYER { get { if (!_MODAL_LAYERReady) { _MODAL_LAYERContent = SGetField<Java.Lang.Integer>(LocalBridgeClazz, "MODAL_LAYER"); _MODAL_LAYERReady = true; } return _MODAL_LAYERContent; } }
        private static Java.Lang.Integer _MODAL_LAYERContent = default;
        private static bool _MODAL_LAYERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JLayeredPane.html#PALETTE_LAYER"/>
        /// </summary>
        public static Java.Lang.Integer PALETTE_LAYER { get { if (!_PALETTE_LAYERReady) { _PALETTE_LAYERContent = SGetField<Java.Lang.Integer>(LocalBridgeClazz, "PALETTE_LAYER"); _PALETTE_LAYERReady = true; } return _PALETTE_LAYERContent; } }
        private static Java.Lang.Integer _PALETTE_LAYERContent = default;
        private static bool _PALETTE_LAYERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JLayeredPane.html#POPUP_LAYER"/>
        /// </summary>
        public static Java.Lang.Integer POPUP_LAYER { get { if (!_POPUP_LAYERReady) { _POPUP_LAYERContent = SGetField<Java.Lang.Integer>(LocalBridgeClazz, "POPUP_LAYER"); _POPUP_LAYERReady = true; } return _POPUP_LAYERContent; } }
        private static Java.Lang.Integer _POPUP_LAYERContent = default;
        private static bool _POPUP_LAYERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JLayeredPane.html#LAYER_PROPERTY"/>
        /// </summary>
        public static Java.Lang.String LAYER_PROPERTY { get { if (!_LAYER_PROPERTYReady) { _LAYER_PROPERTYContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "LAYER_PROPERTY"); _LAYER_PROPERTYReady = true; } return _LAYER_PROPERTYContent; } }
        private static Java.Lang.String _LAYER_PROPERTYContent = default;
        private static bool _LAYER_PROPERTYReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JLayeredPane.html#getLayer(javax.swing.JComponent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JComponent"/></param>
        /// <returns><see cref="int"/></returns>
        public static int GetLayer(Javax.Swing.JComponent arg0)
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "getLayer", "(Ljavax/swing/JComponent;)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JLayeredPane.html#getLayeredPaneAbove(java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <returns><see cref="Javax.Swing.JLayeredPane"/></returns>
        public static Javax.Swing.JLayeredPane GetLayeredPaneAbove(Java.Awt.Component arg0)
        {
            return SExecuteWithSignature<Javax.Swing.JLayeredPane>(LocalBridgeClazz, "getLayeredPaneAbove", "(Ljava/awt/Component;)Ljavax/swing/JLayeredPane;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JLayeredPane.html#putLayer(javax.swing.JComponent,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JComponent"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public static void PutLayer(Javax.Swing.JComponent arg0, int arg1)
        {
            SExecuteWithSignature(LocalBridgeClazz, "putLayer", "(Ljavax/swing/JComponent;I)V", arg0, arg1);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JLayeredPane.html#getComponentCountInLayer(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetComponentCountInLayer(int arg0)
        {
            return IExecuteWithSignature<int>("getComponentCountInLayer", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JLayeredPane.html#getIndexOf(java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetIndexOf(Java.Awt.Component arg0)
        {
            return IExecuteWithSignature<int>("getIndexOf", "(Ljava/awt/Component;)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JLayeredPane.html#getLayer(java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetLayer(Java.Awt.Component arg0)
        {
            return IExecuteWithSignature<int>("getLayer", "(Ljava/awt/Component;)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JLayeredPane.html#getPosition(java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetPosition(Java.Awt.Component arg0)
        {
            return IExecuteWithSignature<int>("getPosition", "(Ljava/awt/Component;)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JLayeredPane.html#highestLayer()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int HighestLayer()
        {
            return IExecuteWithSignature<int>("highestLayer", "()I");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JLayeredPane.html#lowestLayer()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int LowestLayer()
        {
            return IExecuteWithSignature<int>("lowestLayer", "()I");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JLayeredPane.html#getComponentsInLayer(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.Component"/></returns>
        public Java.Awt.Component[] GetComponentsInLayer(int arg0)
        {
            return IExecuteWithSignatureArray<Java.Awt.Component>("getComponentsInLayer", "(I)[Ljava/awt/Component;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JLayeredPane.html#moveToBack(java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        public void MoveToBack(Java.Awt.Component arg0)
        {
            IExecuteWithSignature("moveToBack", "(Ljava/awt/Component;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JLayeredPane.html#moveToFront(java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        public void MoveToFront(Java.Awt.Component arg0)
        {
            IExecuteWithSignature("moveToFront", "(Ljava/awt/Component;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JLayeredPane.html#setLayer(java.awt.Component,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public void SetLayer(Java.Awt.Component arg0, int arg1, int arg2)
        {
            IExecuteWithSignature("setLayer", "(Ljava/awt/Component;II)V", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JLayeredPane.html#setLayer(java.awt.Component,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void SetLayer(Java.Awt.Component arg0, int arg1)
        {
            IExecuteWithSignature("setLayer", "(Ljava/awt/Component;I)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JLayeredPane.html#setPosition(java.awt.Component,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void SetPosition(Java.Awt.Component arg0, int arg1)
        {
            IExecuteWithSignature("setPosition", "(Ljava/awt/Component;I)V", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}