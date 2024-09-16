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
    #region JTextPane declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JTextPane.html"/>
    /// </summary>
    public partial class JTextPane : Javax.Swing.JEditorPane
    {
        const string _bridgeClassName = "javax.swing.JTextPane";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public JTextPane() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public JTextPane(params object[] args) : base(args) { }

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

    #region JTextPane implementation
    public partial class JTextPane
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JTextPane.html#%3Cinit%3E(javax.swing.text.StyledDocument)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Text.StyledDocument"/></param>
        public JTextPane(Javax.Swing.Text.StyledDocument arg0)
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JTextPane.html#getCharacterAttributes()"/> 
        /// </summary>
        public Javax.Swing.Text.AttributeSet CharacterAttributes
        {
            get { return IExecuteWithSignature<Javax.Swing.Text.AttributeSet>("getCharacterAttributes", "()Ljavax/swing/text/AttributeSet;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JTextPane.html#getInputAttributes()"/> 
        /// </summary>
        public Javax.Swing.Text.MutableAttributeSet InputAttributes
        {
            get { return IExecuteWithSignature<Javax.Swing.Text.MutableAttributeSet>("getInputAttributes", "()Ljavax/swing/text/MutableAttributeSet;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JTextPane.html#getLogicalStyle()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JTextPane.html#setLogicalStyle(javax.swing.text.Style)"/>
        /// </summary>
        public Javax.Swing.Text.Style LogicalStyle
        {
            get { return IExecuteWithSignature<Javax.Swing.Text.Style>("getLogicalStyle", "()Ljavax/swing/text/Style;"); } set { IExecuteWithSignature("setLogicalStyle", "(Ljavax/swing/text/Style;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JTextPane.html#getParagraphAttributes()"/> 
        /// </summary>
        public Javax.Swing.Text.AttributeSet ParagraphAttributes
        {
            get { return IExecuteWithSignature<Javax.Swing.Text.AttributeSet>("getParagraphAttributes", "()Ljavax/swing/text/AttributeSet;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JTextPane.html#getStyledDocument()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JTextPane.html#setStyledDocument(javax.swing.text.StyledDocument)"/>
        /// </summary>
        public Javax.Swing.Text.StyledDocument StyledDocument
        {
            get { return IExecuteWithSignature<Javax.Swing.Text.StyledDocument>("getStyledDocument", "()Ljavax/swing/text/StyledDocument;"); } set { IExecuteWithSignature("setStyledDocument", "(Ljavax/swing/text/StyledDocument;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JTextPane.html#addStyle(java.lang.String,javax.swing.text.Style)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Javax.Swing.Text.Style"/></param>
        /// <returns><see cref="Javax.Swing.Text.Style"/></returns>
        public Javax.Swing.Text.Style AddStyle(Java.Lang.String arg0, Javax.Swing.Text.Style arg1)
        {
            return IExecute<Javax.Swing.Text.Style>("addStyle", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JTextPane.html#getStyle(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Swing.Text.Style"/></returns>
        public Javax.Swing.Text.Style GetStyle(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Javax.Swing.Text.Style>("getStyle", "(Ljava/lang/String;)Ljavax/swing/text/Style;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JTextPane.html#insertComponent(java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        public void InsertComponent(Java.Awt.Component arg0)
        {
            IExecuteWithSignature("insertComponent", "(Ljava/awt/Component;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JTextPane.html#insertIcon(javax.swing.Icon)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Icon"/></param>
        public void InsertIcon(Javax.Swing.Icon arg0)
        {
            IExecuteWithSignature("insertIcon", "(Ljavax/swing/Icon;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JTextPane.html#removeStyle(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void RemoveStyle(Java.Lang.String arg0)
        {
            IExecuteWithSignature("removeStyle", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JTextPane.html#setCharacterAttributes(javax.swing.text.AttributeSet,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Text.AttributeSet"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        public void SetCharacterAttributes(Javax.Swing.Text.AttributeSet arg0, bool arg1)
        {
            IExecute("setCharacterAttributes", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JTextPane.html#setParagraphAttributes(javax.swing.text.AttributeSet,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Text.AttributeSet"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        public void SetParagraphAttributes(Javax.Swing.Text.AttributeSet arg0, bool arg1)
        {
            IExecute("setParagraphAttributes", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}