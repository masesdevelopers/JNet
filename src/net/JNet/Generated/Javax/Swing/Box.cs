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
    #region Box declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Box.html"/>
    /// </summary>
    public partial class Box : Javax.Swing.JComponent
    {
        const string _bridgeClassName = "javax.swing.Box";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public Box() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public Box(params object[] args) : base(args) { }

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
        #region Filler declaration
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Box.Filler.html"/>
        /// </summary>
        public partial class Filler : Javax.Swing.JComponent
        {
            const string _bridgeClassName = "javax.swing.Box$Filler";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public Filler() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public Filler(params object[] args) : base(args) { }

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

    #region Box implementation
    public partial class Box
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Box.html#%3Cinit%3E(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public Box(int arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Swing.Box"/> to <see cref="Javax.Accessibility.Accessible"/>
        /// </summary>
        public static implicit operator Javax.Accessibility.Accessible(Javax.Swing.Box t) => t.Cast<Javax.Accessibility.Accessible>();

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Box.html#createGlue()"/>
        /// </summary>
        /// <returns><see cref="Java.Awt.Component"/></returns>
        public static Java.Awt.Component CreateGlue()
        {
            return SExecuteWithSignature<Java.Awt.Component>(LocalBridgeClazz, "createGlue", "()Ljava/awt/Component;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Box.html#createHorizontalGlue()"/>
        /// </summary>
        /// <returns><see cref="Java.Awt.Component"/></returns>
        public static Java.Awt.Component CreateHorizontalGlue()
        {
            return SExecuteWithSignature<Java.Awt.Component>(LocalBridgeClazz, "createHorizontalGlue", "()Ljava/awt/Component;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Box.html#createHorizontalStrut(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.Component"/></returns>
        public static Java.Awt.Component CreateHorizontalStrut(int arg0)
        {
            return SExecuteWithSignature<Java.Awt.Component>(LocalBridgeClazz, "createHorizontalStrut", "(I)Ljava/awt/Component;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Box.html#createRigidArea(java.awt.Dimension)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Dimension"/></param>
        /// <returns><see cref="Java.Awt.Component"/></returns>
        public static Java.Awt.Component CreateRigidArea(Java.Awt.Dimension arg0)
        {
            return SExecuteWithSignature<Java.Awt.Component>(LocalBridgeClazz, "createRigidArea", "(Ljava/awt/Dimension;)Ljava/awt/Component;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Box.html#createVerticalGlue()"/>
        /// </summary>
        /// <returns><see cref="Java.Awt.Component"/></returns>
        public static Java.Awt.Component CreateVerticalGlue()
        {
            return SExecuteWithSignature<Java.Awt.Component>(LocalBridgeClazz, "createVerticalGlue", "()Ljava/awt/Component;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Box.html#createVerticalStrut(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.Component"/></returns>
        public static Java.Awt.Component CreateVerticalStrut(int arg0)
        {
            return SExecuteWithSignature<Java.Awt.Component>(LocalBridgeClazz, "createVerticalStrut", "(I)Ljava/awt/Component;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Box.html#createHorizontalBox()"/>
        /// </summary>
        /// <returns><see cref="Javax.Swing.Box"/></returns>
        public static Javax.Swing.Box CreateHorizontalBox()
        {
            return SExecuteWithSignature<Javax.Swing.Box>(LocalBridgeClazz, "createHorizontalBox", "()Ljavax/swing/Box;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Box.html#createVerticalBox()"/>
        /// </summary>
        /// <returns><see cref="Javax.Swing.Box"/></returns>
        public static Javax.Swing.Box CreateVerticalBox()
        {
            return SExecuteWithSignature<Javax.Swing.Box>(LocalBridgeClazz, "createVerticalBox", "()Ljavax/swing/Box;");
        }

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes
        #region Filler implementation
        public partial class Filler
        {
            #region Constructors
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Box.Filler.html#%3Cinit%3E(java.awt.Dimension,java.awt.Dimension,java.awt.Dimension)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Awt.Dimension"/></param>
            /// <param name="arg1"><see cref="Java.Awt.Dimension"/></param>
            /// <param name="arg2"><see cref="Java.Awt.Dimension"/></param>
            public Filler(Java.Awt.Dimension arg0, Java.Awt.Dimension arg1, Java.Awt.Dimension arg2)
                : base(arg0, arg1, arg2)
            {
            }

            #endregion

            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Javax.Swing.Box.Filler"/> to <see cref="Javax.Accessibility.Accessible"/>
            /// </summary>
            public static implicit operator Javax.Accessibility.Accessible(Javax.Swing.Box.Filler t) => t.Cast<Javax.Accessibility.Accessible>();

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/Box.Filler.html#changeShape(java.awt.Dimension,java.awt.Dimension,java.awt.Dimension)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Awt.Dimension"/></param>
            /// <param name="arg1"><see cref="Java.Awt.Dimension"/></param>
            /// <param name="arg2"><see cref="Java.Awt.Dimension"/></param>
            public void ChangeShape(Java.Awt.Dimension arg0, Java.Awt.Dimension arg1, Java.Awt.Dimension arg2)
            {
                IExecuteWithSignature("changeShape", "(Ljava/awt/Dimension;Ljava/awt/Dimension;Ljava/awt/Dimension;)V", arg0, arg1, arg2);
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