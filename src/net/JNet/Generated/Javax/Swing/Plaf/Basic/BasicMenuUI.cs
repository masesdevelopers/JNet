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

namespace Javax.Swing.Plaf.Basic
{
    #region BasicMenuUI declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicMenuUI.html"/>
    /// </summary>
    public partial class BasicMenuUI : Javax.Swing.Plaf.Basic.BasicMenuItemUI
    {
        const string _bridgeClassName = "javax.swing.plaf.basic.BasicMenuUI";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public BasicMenuUI() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public BasicMenuUI(params object[] args) : base(args) { }

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
        #region ChangeHandler declaration
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicMenuUI.ChangeHandler.html"/>
        /// </summary>
        public partial class ChangeHandler : MASES.JCOBridge.C2JBridge.JVMBridgeBase<ChangeHandler>
        {
            const string _bridgeClassName = "javax.swing.plaf.basic.BasicMenuUI$ChangeHandler";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public ChangeHandler() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public ChangeHandler(params object[] args) : base(args) { }

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

    
    }
    #endregion

    #region BasicMenuUI implementation
    public partial class BasicMenuUI
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

        #endregion

        #region Nested classes
        #region ChangeHandler implementation
        public partial class ChangeHandler
        {
            #region Constructors
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicMenuUI.ChangeHandler.html#%3Cinit%3E(javax.swing.plaf.basic.BasicMenuUI,javax.swing.JMenu,javax.swing.plaf.basic.BasicMenuUI)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.Plaf.Basic.BasicMenuUI"/></param>
            /// <param name="arg1"><see cref="Javax.Swing.JMenu"/></param>
            /// <param name="arg2"><see cref="Javax.Swing.Plaf.Basic.BasicMenuUI"/></param>
            public ChangeHandler(Javax.Swing.Plaf.Basic.BasicMenuUI arg0, Javax.Swing.JMenu arg1, Javax.Swing.Plaf.Basic.BasicMenuUI arg2)
                : base(arg0, arg1, arg2)
            {
            }

            #endregion

            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Javax.Swing.Plaf.Basic.BasicMenuUI.ChangeHandler"/> to <see cref="Javax.Swing.Event.ChangeListener"/>
            /// </summary>
            public static implicit operator Javax.Swing.Event.ChangeListener(Javax.Swing.Plaf.Basic.BasicMenuUI.ChangeHandler t) => t.Cast<Javax.Swing.Event.ChangeListener>();

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicMenuUI.ChangeHandler.html#isSelected"/>
            /// </summary>
            public bool isSelected { get { return IGetField<bool>("isSelected"); } set { ISetField("isSelected", value); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicMenuUI.ChangeHandler.html#wasFocused"/>
            /// </summary>
            public Java.Awt.Component wasFocused { get { return IGetField<Java.Awt.Component>("wasFocused"); } set { ISetField("wasFocused", value); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicMenuUI.ChangeHandler.html#menu"/>
            /// </summary>
            public Javax.Swing.JMenu menu { get { return IGetField<Javax.Swing.JMenu>("menu"); } set { ISetField("menu", value); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicMenuUI.ChangeHandler.html#ui"/>
            /// </summary>
            public Javax.Swing.Plaf.Basic.BasicMenuUI ui { get { return IGetField<Javax.Swing.Plaf.Basic.BasicMenuUI>("ui"); } set { ISetField("ui", value); } }

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicMenuUI.ChangeHandler.html#stateChanged(javax.swing.event.ChangeEvent)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.Event.ChangeEvent"/></param>
            public void StateChanged(Javax.Swing.Event.ChangeEvent arg0)
            {
                IExecuteWithSignature("stateChanged", "(Ljavax/swing/event/ChangeEvent;)V", arg0);
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