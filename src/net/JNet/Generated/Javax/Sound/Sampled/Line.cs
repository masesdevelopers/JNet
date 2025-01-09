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

namespace Javax.Sound.Sampled
{
    #region Line declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/Line.html"/>
    /// </summary>
    public partial class Line : Java.Lang.AutoCloseable
    {
        const string _bridgeClassName = "javax.sound.sampled.Line";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("Line class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public Line() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("Line class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public Line(params object[] args) : base(args) { }

        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
        /// </summary>
        public override bool IsBridgeCloseable => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
        /// </summary>
        public override bool IsBridgeInterface => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;

        // TODO: complete the class
        #region Info declaration
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/Line.Info.html"/>
        /// </summary>
        public partial class Info : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Info>
        {
            const string _bridgeClassName = "javax.sound.sampled.Line$Info";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public Info() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public Info(params object[] args) : base(args) { }

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
            public override bool IsBridgeStatic => true;

            // TODO: complete the class

        }
        #endregion

    
    }
    #endregion

    #region ILine
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface ILine : Java.Lang.IAutoCloseable
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/Line.html#getControls()"/> 
        /// </summary>
        Javax.Sound.Sampled.Control[] Controls { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/Line.html#getLineInfo()"/> 
        /// </summary>
        Javax.Sound.Sampled.Line.Info LineInfo { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/Line.html#isControlSupported(javax.sound.sampled.Control.Type)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Sampled.Control.Type"/></param>
        /// <returns><see cref="bool"/></returns>
        bool IsControlSupported(Javax.Sound.Sampled.Control.Type arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/Line.html#isOpen()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        bool IsOpen();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/Line.html#getControl(javax.sound.sampled.Control.Type)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Sampled.Control.Type"/></param>
        /// <returns><see cref="Javax.Sound.Sampled.Control"/></returns>
        Javax.Sound.Sampled.Control GetControl(Javax.Sound.Sampled.Control.Type arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/Line.html#addLineListener(javax.sound.sampled.LineListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Sampled.LineListener"/></param>
        void AddLineListener(Javax.Sound.Sampled.LineListener arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/Line.html#close()"/>
        /// </summary>
        void Close();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/Line.html#open()"/>
        /// </summary>
        /// <exception cref="Javax.Sound.Sampled.LineUnavailableException"/>
        void Open();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/Line.html#removeLineListener(javax.sound.sampled.LineListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Sampled.LineListener"/></param>
        void RemoveLineListener(Javax.Sound.Sampled.LineListener arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region Line implementation
    public partial class Line : Javax.Sound.Sampled.ILine
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/Line.html#getControls()"/> 
        /// </summary>
        public Javax.Sound.Sampled.Control[] Controls
        {
            get { return IExecuteWithSignatureArray<Javax.Sound.Sampled.Control>("getControls", "()[Ljavax/sound/sampled/Control;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/Line.html#getLineInfo()"/> 
        /// </summary>
        public Javax.Sound.Sampled.Line.Info LineInfo
        {
            get { return IExecuteWithSignature<Javax.Sound.Sampled.Line.Info>("getLineInfo", "()Ljavax/sound/sampled/Line$Info;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/Line.html#isControlSupported(javax.sound.sampled.Control.Type)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Sampled.Control.Type"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsControlSupported(Javax.Sound.Sampled.Control.Type arg0)
        {
            return IExecuteWithSignature<bool>("isControlSupported", "(Ljavax/sound/sampled/Control$Type;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/Line.html#isOpen()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsOpen()
        {
            return IExecuteWithSignature<bool>("isOpen", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/Line.html#getControl(javax.sound.sampled.Control.Type)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Sampled.Control.Type"/></param>
        /// <returns><see cref="Javax.Sound.Sampled.Control"/></returns>
        public Javax.Sound.Sampled.Control GetControl(Javax.Sound.Sampled.Control.Type arg0)
        {
            return IExecuteWithSignature<Javax.Sound.Sampled.Control>("getControl", "(Ljavax/sound/sampled/Control$Type;)Ljavax/sound/sampled/Control;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/Line.html#addLineListener(javax.sound.sampled.LineListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Sampled.LineListener"/></param>
        public void AddLineListener(Javax.Sound.Sampled.LineListener arg0)
        {
            IExecuteWithSignature("addLineListener", "(Ljavax/sound/sampled/LineListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/Line.html#close()"/>
        /// </summary>
        public void Close()
        {
            IExecuteWithSignature("close", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/Line.html#open()"/>
        /// </summary>
        /// <exception cref="Javax.Sound.Sampled.LineUnavailableException"/>
        public void Open()
        {
            IExecuteWithSignature("open", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/Line.html#removeLineListener(javax.sound.sampled.LineListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sound.Sampled.LineListener"/></param>
        public void RemoveLineListener(Javax.Sound.Sampled.LineListener arg0)
        {
            IExecuteWithSignature("removeLineListener", "(Ljavax/sound/sampled/LineListener;)V", arg0);
        }

        #endregion

        #region Nested classes
        #region Info implementation
        public partial class Info
        {
            #region Constructors
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/Line.Info.html#%3Cinit%3E(java.lang.Class)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
            public Info(Java.Lang.Class arg0)
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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/Line.Info.html#getLineClass()"/> 
            /// </summary>
            public Java.Lang.Class LineClass
            {
                get { return IExecuteWithSignature<Java.Lang.Class>("getLineClass", "()Ljava/lang/Class;"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/Line.Info.html#matches(javax.sound.sampled.Line.Info)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Sound.Sampled.Line.Info"/></param>
            /// <returns><see cref="bool"/></returns>
            public bool Matches(Javax.Sound.Sampled.Line.Info arg0)
            {
                return IExecuteWithSignature<bool>("matches", "(Ljavax/sound/sampled/Line$Info;)Z", arg0);
            }

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