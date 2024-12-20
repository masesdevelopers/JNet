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
    #region BasicHTML declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicHTML.html"/>
    /// </summary>
    public partial class BasicHTML : MASES.JCOBridge.C2JBridge.JVMBridgeBase<BasicHTML>
    {
        const string _bridgeClassName = "javax.swing.plaf.basic.BasicHTML";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public BasicHTML() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public BasicHTML(params object[] args) : base(args) { }

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

    #region BasicHTML implementation
    public partial class BasicHTML
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicHTML.html#documentBaseKey"/>
        /// </summary>
        public static Java.Lang.String documentBaseKey { get { if (!_documentBaseKeyReady) { _documentBaseKeyContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "documentBaseKey"); _documentBaseKeyReady = true; } return _documentBaseKeyContent; } }
        private static Java.Lang.String _documentBaseKeyContent = default;
        private static bool _documentBaseKeyReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicHTML.html#propertyKey"/>
        /// </summary>
        public static Java.Lang.String propertyKey { get { if (!_propertyKeyReady) { _propertyKeyContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "propertyKey"); _propertyKeyReady = true; } return _propertyKeyContent; } }
        private static Java.Lang.String _propertyKeyContent = default;
        private static bool _propertyKeyReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicHTML.html#isHTMLString(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsHTMLString(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "isHTMLString", "(Ljava/lang/String;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicHTML.html#getHTMLBaseline(javax.swing.text.View,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Text.View"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public static int GetHTMLBaseline(Javax.Swing.Text.View arg0, int arg1, int arg2)
        {
            return SExecuteWithSignature<int>(LocalBridgeClazz, "getHTMLBaseline", "(Ljavax/swing/text/View;II)I", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicHTML.html#createHTMLView(javax.swing.JComponent,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JComponent"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Swing.Text.View"/></returns>
        public static Javax.Swing.Text.View CreateHTMLView(Javax.Swing.JComponent arg0, Java.Lang.String arg1)
        {
            return SExecuteWithSignature<Javax.Swing.Text.View>(LocalBridgeClazz, "createHTMLView", "(Ljavax/swing/JComponent;Ljava/lang/String;)Ljavax/swing/text/View;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicHTML.html#updateRenderer(javax.swing.JComponent,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JComponent"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        public static void UpdateRenderer(Javax.Swing.JComponent arg0, Java.Lang.String arg1)
        {
            SExecuteWithSignature(LocalBridgeClazz, "updateRenderer", "(Ljavax/swing/JComponent;Ljava/lang/String;)V", arg0, arg1);
        }

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}