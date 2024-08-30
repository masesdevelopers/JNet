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

namespace Java.Awt
{
    #region Window declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Window.html"/>
    /// </summary>
    public partial class Window : Java.Awt.Container
    {
        const string _bridgeClassName = "java.awt.Window";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public Window() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public Window(params object[] args) : base(args) { }

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
        #region Type declaration
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Window.Type.html"/>
        /// </summary>
        public partial class Type : Java.Lang.Enum<Java.Awt.Window.Type>
        {
            const string _bridgeClassName = "java.awt.Window$Type";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public Type() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public Type(params object[] args) : base(args) { }

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
            public override bool IsBridgeStatic => true;

            // TODO: complete the class

        }
        #endregion

    
    }
    #endregion

    #region Window implementation
    public partial class Window
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Window.html#%3Cinit%3E(java.awt.Frame)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Frame"/></param>
        public Window(Java.Awt.Frame arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Window.html#%3Cinit%3E(java.awt.Window,java.awt.GraphicsConfiguration)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Window"/></param>
        /// <param name="arg1"><see cref="Java.Awt.GraphicsConfiguration"/></param>
        public Window(Java.Awt.Window arg0, Java.Awt.GraphicsConfiguration arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Window.html#%3Cinit%3E(java.awt.Window)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Window"/></param>
        public Window(Java.Awt.Window arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Awt.Window"/> to <see cref="Javax.Accessibility.Accessible"/>
        /// </summary>
        public static implicit operator Javax.Accessibility.Accessible(Java.Awt.Window t) => t.Cast<Javax.Accessibility.Accessible>();

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Window.html#getOwnerlessWindows()"/> 
        /// </summary>
        public static Java.Awt.Window[] OwnerlessWindows
        {
            get { return SExecuteWithSignatureArray<Java.Awt.Window>(LocalBridgeClazz, "getOwnerlessWindows", "()[Ljava/awt/Window;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Window.html#getWindows()"/> 
        /// </summary>
        public static Java.Awt.Window[] Windows
        {
            get { return SExecuteWithSignatureArray<Java.Awt.Window>(LocalBridgeClazz, "getWindows", "()[Ljava/awt/Window;"); }
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Window.html#getBufferStrategy()"/> 
        /// </summary>
        public Java.Awt.ImageNs.BufferStrategy BufferStrategy
        {
            get { return IExecuteWithSignature<Java.Awt.ImageNs.BufferStrategy>("getBufferStrategy", "()Ljava/awt/image/BufferStrategy;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Window.html#getFocusableWindowState()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Window.html#setFocusableWindowState(boolean)"/>
        /// </summary>
        public bool FocusableWindowState
        {
            get { return IExecuteWithSignature<bool>("getFocusableWindowState", "()Z"); } set { IExecuteWithSignature("setFocusableWindowState", "(Z)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Window.html#getFocusOwner()"/> 
        /// </summary>
        public Java.Awt.Component FocusOwner
        {
            get { return IExecuteWithSignature<Java.Awt.Component>("getFocusOwner", "()Ljava/awt/Component;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Window.html#getType()"/> 
        /// </summary>
        public Java.Awt.Window.Type GetType
        {
            get { return IExecuteWithSignature<Java.Awt.Window.Type>("getType", "()Ljava/awt/Window$Type;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Window.html#getIconImages()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Window.html#setIconImages(java.util.List)"/>
        /// </summary>
        public Java.Util.List<Java.Awt.Image> IconImages
        {
            get { return IExecuteWithSignature<Java.Util.List<Java.Awt.Image>>("getIconImages", "()Ljava/util/List;"); } set { IExecuteWithSignature("setIconImages", "(Ljava/util/List;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Window.html#getModalExclusionType()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Window.html#setModalExclusionType(java.awt.Dialog.ModalExclusionType)"/>
        /// </summary>
        public Java.Awt.Dialog.ModalExclusionType ModalExclusionType
        {
            get { return IExecuteWithSignature<Java.Awt.Dialog.ModalExclusionType>("getModalExclusionType", "()Ljava/awt/Dialog$ModalExclusionType;"); } set { IExecuteWithSignature("setModalExclusionType", "(Ljava/awt/Dialog$ModalExclusionType;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Window.html#getMostRecentFocusOwner()"/> 
        /// </summary>
        public Java.Awt.Component MostRecentFocusOwner
        {
            get { return IExecuteWithSignature<Java.Awt.Component>("getMostRecentFocusOwner", "()Ljava/awt/Component;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Window.html#getOpacity()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Window.html#setOpacity(float)"/>
        /// </summary>
        public float Opacity
        {
            get { return IExecuteWithSignature<float>("getOpacity", "()F"); } set { IExecuteWithSignature("setOpacity", "(F)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Window.html#getOwnedWindows()"/> 
        /// </summary>
        public Java.Awt.Window[] OwnedWindows
        {
            get { return IExecuteWithSignatureArray<Java.Awt.Window>("getOwnedWindows", "()[Ljava/awt/Window;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Window.html#getOwner()"/> 
        /// </summary>
        public Java.Awt.Window Owner
        {
            get { return IExecuteWithSignature<Java.Awt.Window>("getOwner", "()Ljava/awt/Window;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Window.html#getShape()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Window.html#setShape(java.awt.Shape)"/>
        /// </summary>
        public Java.Awt.Shape Shape
        {
            get { return IExecuteWithSignature<Java.Awt.Shape>("getShape", "()Ljava/awt/Shape;"); } set { IExecuteWithSignature("setShape", "(Ljava/awt/Shape;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Window.html#getWarningString()"/> 
        /// </summary>
        public Java.Lang.String WarningString
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getWarningString", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Window.html#getWindowFocusListeners()"/> 
        /// </summary>
        public Java.Awt.EventNs.WindowFocusListener[] WindowFocusListeners
        {
            get { return IExecuteWithSignatureArray<Java.Awt.EventNs.WindowFocusListener>("getWindowFocusListeners", "()[Ljava/awt/event/WindowFocusListener;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Window.html#getWindowListeners()"/> 
        /// </summary>
        public Java.Awt.EventNs.WindowListener[] WindowListeners
        {
            get { return IExecuteWithSignatureArray<Java.Awt.EventNs.WindowListener>("getWindowListeners", "()[Ljava/awt/event/WindowListener;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Window.html#getWindowStateListeners()"/> 
        /// </summary>
        public Java.Awt.EventNs.WindowStateListener[] WindowStateListeners
        {
            get { return IExecuteWithSignatureArray<Java.Awt.EventNs.WindowStateListener>("getWindowStateListeners", "()[Ljava/awt/event/WindowStateListener;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Window.html#isActive()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsActive()
        {
            return IExecuteWithSignature<bool>("isActive", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Window.html#isAlwaysOnTopSupported()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsAlwaysOnTopSupported()
        {
            return IExecuteWithSignature<bool>("isAlwaysOnTopSupported", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Window.html#isAutoRequestFocus()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsAutoRequestFocus()
        {
            return IExecuteWithSignature<bool>("isAutoRequestFocus", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Window.html#isFocused()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsFocused()
        {
            return IExecuteWithSignature<bool>("isFocused", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Window.html#isLocationByPlatform()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsLocationByPlatform()
        {
            return IExecuteWithSignature<bool>("isLocationByPlatform", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Window.html#isAlwaysOnTop()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsAlwaysOnTop()
        {
            return IExecuteWithSignature<bool>("isAlwaysOnTop", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Window.html#isFocusableWindow()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsFocusableWindow()
        {
            return IExecuteWithSignature<bool>("isFocusableWindow", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Window.html#setAlwaysOnTop(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <exception cref="Java.Lang.SecurityException"/>
        public void SetAlwaysOnTop(bool arg0)
        {
            IExecuteWithSignature("setAlwaysOnTop", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Window.html#addWindowFocusListener(java.awt.event.WindowFocusListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.WindowFocusListener"/></param>
        public void AddWindowFocusListener(Java.Awt.EventNs.WindowFocusListener arg0)
        {
            IExecuteWithSignature("addWindowFocusListener", "(Ljava/awt/event/WindowFocusListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Window.html#addWindowListener(java.awt.event.WindowListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.WindowListener"/></param>
        public void AddWindowListener(Java.Awt.EventNs.WindowListener arg0)
        {
            IExecuteWithSignature("addWindowListener", "(Ljava/awt/event/WindowListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Window.html#addWindowStateListener(java.awt.event.WindowStateListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.WindowStateListener"/></param>
        public void AddWindowStateListener(Java.Awt.EventNs.WindowStateListener arg0)
        {
            IExecuteWithSignature("addWindowStateListener", "(Ljava/awt/event/WindowStateListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Window.html#removeWindowFocusListener(java.awt.event.WindowFocusListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.WindowFocusListener"/></param>
        public void RemoveWindowFocusListener(Java.Awt.EventNs.WindowFocusListener arg0)
        {
            IExecuteWithSignature("removeWindowFocusListener", "(Ljava/awt/event/WindowFocusListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Window.html#removeWindowListener(java.awt.event.WindowListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.WindowListener"/></param>
        public void RemoveWindowListener(Java.Awt.EventNs.WindowListener arg0)
        {
            IExecuteWithSignature("removeWindowListener", "(Ljava/awt/event/WindowListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Window.html#removeWindowStateListener(java.awt.event.WindowStateListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.WindowStateListener"/></param>
        public void RemoveWindowStateListener(Java.Awt.EventNs.WindowStateListener arg0)
        {
            IExecuteWithSignature("removeWindowStateListener", "(Ljava/awt/event/WindowStateListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Window.html#createBufferStrategy(int,java.awt.BufferCapabilities)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Awt.BufferCapabilities"/></param>
        /// <exception cref="Java.Awt.AWTException"/>
        public void CreateBufferStrategy(int arg0, Java.Awt.BufferCapabilities arg1)
        {
            IExecute("createBufferStrategy", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Window.html#createBufferStrategy(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void CreateBufferStrategy(int arg0)
        {
            IExecuteWithSignature("createBufferStrategy", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Window.html#dispose()"/>
        /// </summary>
        public new void Dispose()
        {
            IExecuteWithSignature("dispose", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Window.html#pack()"/>
        /// </summary>
        public void Pack()
        {
            IExecuteWithSignature("pack", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Window.html#setAutoRequestFocus(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetAutoRequestFocus(bool arg0)
        {
            IExecuteWithSignature("setAutoRequestFocus", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Window.html#setIconImage(java.awt.Image)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Image"/></param>
        public void SetIconImage(Java.Awt.Image arg0)
        {
            IExecuteWithSignature("setIconImage", "(Ljava/awt/Image;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Window.html#setLocationByPlatform(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetLocationByPlatform(bool arg0)
        {
            IExecuteWithSignature("setLocationByPlatform", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Window.html#setLocationRelativeTo(java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        public void SetLocationRelativeTo(Java.Awt.Component arg0)
        {
            IExecuteWithSignature("setLocationRelativeTo", "(Ljava/awt/Component;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Window.html#setType(java.awt.Window.Type)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Window.Type"/></param>
        public void SetType(Java.Awt.Window.Type arg0)
        {
            IExecuteWithSignature("setType", "(Ljava/awt/Window$Type;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Window.html#toBack()"/>
        /// </summary>
        public void ToBack()
        {
            IExecuteWithSignature("toBack", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Window.html#toFront()"/>
        /// </summary>
        public void ToFront()
        {
            IExecuteWithSignature("toFront", "()V");
        }

        #endregion

        #region Nested classes
        #region Type implementation
        public partial class Type
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Window.Type.html#NORMAL"/>
            /// </summary>
            public static Java.Awt.Window.Type NORMAL { get { if (!_NORMALReady) { _NORMALContent = SGetField<Java.Awt.Window.Type>(LocalBridgeClazz, "NORMAL"); _NORMALReady = true; } return _NORMALContent; } }
            private static Java.Awt.Window.Type _NORMALContent = default;
            private static bool _NORMALReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Window.Type.html#POPUP"/>
            /// </summary>
            public static Java.Awt.Window.Type POPUP { get { if (!_POPUPReady) { _POPUPContent = SGetField<Java.Awt.Window.Type>(LocalBridgeClazz, "POPUP"); _POPUPReady = true; } return _POPUPContent; } }
            private static Java.Awt.Window.Type _POPUPContent = default;
            private static bool _POPUPReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Window.Type.html#UTILITY"/>
            /// </summary>
            public static Java.Awt.Window.Type UTILITY { get { if (!_UTILITYReady) { _UTILITYContent = SGetField<Java.Awt.Window.Type>(LocalBridgeClazz, "UTILITY"); _UTILITYReady = true; } return _UTILITYContent; } }
            private static Java.Awt.Window.Type _UTILITYContent = default;
            private static bool _UTILITYReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Window.Type.html#valueOf(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Java.Awt.Window.Type"/></returns>
            public static Java.Awt.Window.Type ValueOf(Java.Lang.String arg0)
            {
                return SExecuteWithSignature<Java.Awt.Window.Type>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Ljava/awt/Window$Type;", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Window.Type.html#values()"/>
            /// </summary>
            /// <returns><see cref="Java.Awt.Window.Type"/></returns>
            public static Java.Awt.Window.Type[] Values()
            {
                return SExecuteWithSignatureArray<Java.Awt.Window.Type>(LocalBridgeClazz, "values", "()[Ljava/awt/Window$Type;");
            }

            #endregion

            #region Instance methods

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

    
        #endregion

        // TODO: complete the class
    }
    #endregion
}