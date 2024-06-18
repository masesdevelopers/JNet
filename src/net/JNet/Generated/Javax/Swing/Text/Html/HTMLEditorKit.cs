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
*  This file is generated by MASES.JNetReflector (ver. 2.5.3.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Swing.Text.Html
{
    #region HTMLEditorKit
    public partial class HTMLEditorKit
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Swing.Text.Html.HTMLEditorKit"/> to <see cref="Javax.Accessibility.Accessible"/>
        /// </summary>
        public static implicit operator Javax.Accessibility.Accessible(Javax.Swing.Text.Html.HTMLEditorKit t) => t.Cast<Javax.Accessibility.Accessible>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/HTMLEditorKit.html#BOLD_ACTION"/>
        /// </summary>
        public static Java.Lang.String BOLD_ACTION { get { if (!_BOLD_ACTIONReady) { _BOLD_ACTIONContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "BOLD_ACTION"); _BOLD_ACTIONReady = true; } return _BOLD_ACTIONContent; } }
        private static Java.Lang.String _BOLD_ACTIONContent = default;
        private static bool _BOLD_ACTIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/HTMLEditorKit.html#COLOR_ACTION"/>
        /// </summary>
        public static Java.Lang.String COLOR_ACTION { get { if (!_COLOR_ACTIONReady) { _COLOR_ACTIONContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "COLOR_ACTION"); _COLOR_ACTIONReady = true; } return _COLOR_ACTIONContent; } }
        private static Java.Lang.String _COLOR_ACTIONContent = default;
        private static bool _COLOR_ACTIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/HTMLEditorKit.html#DEFAULT_CSS"/>
        /// </summary>
        public static Java.Lang.String DEFAULT_CSS { get { if (!_DEFAULT_CSSReady) { _DEFAULT_CSSContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "DEFAULT_CSS"); _DEFAULT_CSSReady = true; } return _DEFAULT_CSSContent; } }
        private static Java.Lang.String _DEFAULT_CSSContent = default;
        private static bool _DEFAULT_CSSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/HTMLEditorKit.html#FONT_CHANGE_BIGGER"/>
        /// </summary>
        public static Java.Lang.String FONT_CHANGE_BIGGER { get { if (!_FONT_CHANGE_BIGGERReady) { _FONT_CHANGE_BIGGERContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "FONT_CHANGE_BIGGER"); _FONT_CHANGE_BIGGERReady = true; } return _FONT_CHANGE_BIGGERContent; } }
        private static Java.Lang.String _FONT_CHANGE_BIGGERContent = default;
        private static bool _FONT_CHANGE_BIGGERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/HTMLEditorKit.html#FONT_CHANGE_SMALLER"/>
        /// </summary>
        public static Java.Lang.String FONT_CHANGE_SMALLER { get { if (!_FONT_CHANGE_SMALLERReady) { _FONT_CHANGE_SMALLERContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "FONT_CHANGE_SMALLER"); _FONT_CHANGE_SMALLERReady = true; } return _FONT_CHANGE_SMALLERContent; } }
        private static Java.Lang.String _FONT_CHANGE_SMALLERContent = default;
        private static bool _FONT_CHANGE_SMALLERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/HTMLEditorKit.html#IMG_ALIGN_BOTTOM"/>
        /// </summary>
        public static Java.Lang.String IMG_ALIGN_BOTTOM { get { if (!_IMG_ALIGN_BOTTOMReady) { _IMG_ALIGN_BOTTOMContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "IMG_ALIGN_BOTTOM"); _IMG_ALIGN_BOTTOMReady = true; } return _IMG_ALIGN_BOTTOMContent; } }
        private static Java.Lang.String _IMG_ALIGN_BOTTOMContent = default;
        private static bool _IMG_ALIGN_BOTTOMReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/HTMLEditorKit.html#IMG_ALIGN_MIDDLE"/>
        /// </summary>
        public static Java.Lang.String IMG_ALIGN_MIDDLE { get { if (!_IMG_ALIGN_MIDDLEReady) { _IMG_ALIGN_MIDDLEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "IMG_ALIGN_MIDDLE"); _IMG_ALIGN_MIDDLEReady = true; } return _IMG_ALIGN_MIDDLEContent; } }
        private static Java.Lang.String _IMG_ALIGN_MIDDLEContent = default;
        private static bool _IMG_ALIGN_MIDDLEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/HTMLEditorKit.html#IMG_ALIGN_TOP"/>
        /// </summary>
        public static Java.Lang.String IMG_ALIGN_TOP { get { if (!_IMG_ALIGN_TOPReady) { _IMG_ALIGN_TOPContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "IMG_ALIGN_TOP"); _IMG_ALIGN_TOPReady = true; } return _IMG_ALIGN_TOPContent; } }
        private static Java.Lang.String _IMG_ALIGN_TOPContent = default;
        private static bool _IMG_ALIGN_TOPReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/HTMLEditorKit.html#IMG_BORDER"/>
        /// </summary>
        public static Java.Lang.String IMG_BORDER { get { if (!_IMG_BORDERReady) { _IMG_BORDERContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "IMG_BORDER"); _IMG_BORDERReady = true; } return _IMG_BORDERContent; } }
        private static Java.Lang.String _IMG_BORDERContent = default;
        private static bool _IMG_BORDERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/HTMLEditorKit.html#ITALIC_ACTION"/>
        /// </summary>
        public static Java.Lang.String ITALIC_ACTION { get { if (!_ITALIC_ACTIONReady) { _ITALIC_ACTIONContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ITALIC_ACTION"); _ITALIC_ACTIONReady = true; } return _ITALIC_ACTIONContent; } }
        private static Java.Lang.String _ITALIC_ACTIONContent = default;
        private static bool _ITALIC_ACTIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/HTMLEditorKit.html#LOGICAL_STYLE_ACTION"/>
        /// </summary>
        public static Java.Lang.String LOGICAL_STYLE_ACTION { get { if (!_LOGICAL_STYLE_ACTIONReady) { _LOGICAL_STYLE_ACTIONContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "LOGICAL_STYLE_ACTION"); _LOGICAL_STYLE_ACTIONReady = true; } return _LOGICAL_STYLE_ACTIONContent; } }
        private static Java.Lang.String _LOGICAL_STYLE_ACTIONContent = default;
        private static bool _LOGICAL_STYLE_ACTIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/HTMLEditorKit.html#PARA_INDENT_LEFT"/>
        /// </summary>
        public static Java.Lang.String PARA_INDENT_LEFT { get { if (!_PARA_INDENT_LEFTReady) { _PARA_INDENT_LEFTContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "PARA_INDENT_LEFT"); _PARA_INDENT_LEFTReady = true; } return _PARA_INDENT_LEFTContent; } }
        private static Java.Lang.String _PARA_INDENT_LEFTContent = default;
        private static bool _PARA_INDENT_LEFTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/HTMLEditorKit.html#PARA_INDENT_RIGHT"/>
        /// </summary>
        public static Java.Lang.String PARA_INDENT_RIGHT { get { if (!_PARA_INDENT_RIGHTReady) { _PARA_INDENT_RIGHTContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "PARA_INDENT_RIGHT"); _PARA_INDENT_RIGHTReady = true; } return _PARA_INDENT_RIGHTContent; } }
        private static Java.Lang.String _PARA_INDENT_RIGHTContent = default;
        private static bool _PARA_INDENT_RIGHTReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/HTMLEditorKit.html#getAccessibleContext()"/> 
        /// </summary>
        public Javax.Accessibility.AccessibleContext AccessibleContext
        {
            get { return IExecuteWithSignature<Javax.Accessibility.AccessibleContext>("getAccessibleContext", "()Ljavax/accessibility/AccessibleContext;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/HTMLEditorKit.html#getDefaultCursor()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/HTMLEditorKit.html#setDefaultCursor(java.awt.Cursor)"/>
        /// </summary>
        public Java.Awt.Cursor DefaultCursor
        {
            get { return IExecuteWithSignature<Java.Awt.Cursor>("getDefaultCursor", "()Ljava/awt/Cursor;"); } set { IExecuteWithSignature("setDefaultCursor", "(Ljava/awt/Cursor;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/HTMLEditorKit.html#getLinkCursor()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/HTMLEditorKit.html#setLinkCursor(java.awt.Cursor)"/>
        /// </summary>
        public Java.Awt.Cursor LinkCursor
        {
            get { return IExecuteWithSignature<Java.Awt.Cursor>("getLinkCursor", "()Ljava/awt/Cursor;"); } set { IExecuteWithSignature("setLinkCursor", "(Ljava/awt/Cursor;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/HTMLEditorKit.html#getStyleSheet()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/HTMLEditorKit.html#setStyleSheet(javax.swing.text.html.StyleSheet)"/>
        /// </summary>
        public Javax.Swing.Text.Html.StyleSheet StyleSheet
        {
            get { return IExecuteWithSignature<Javax.Swing.Text.Html.StyleSheet>("getStyleSheet", "()Ljavax/swing/text/html/StyleSheet;"); } set { IExecuteWithSignature("setStyleSheet", "(Ljavax/swing/text/html/StyleSheet;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/HTMLEditorKit.html#isAutoFormSubmission()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsAutoFormSubmission()
        {
            return IExecuteWithSignature<bool>("isAutoFormSubmission", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/HTMLEditorKit.html#insertHTML(javax.swing.text.html.HTMLDocument,int,java.lang.String,int,int,javax.swing.text.html.HTML.Tag)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Text.Html.HTMLDocument"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="Javax.Swing.Text.Html.HTML.Tag"/></param>
        /// <exception cref="Javax.Swing.Text.BadLocationException"/>
        /// <exception cref="Java.Io.IOException"/>
        public void InsertHTML(Javax.Swing.Text.Html.HTMLDocument arg0, int arg1, Java.Lang.String arg2, int arg3, int arg4, Javax.Swing.Text.Html.HTML.Tag arg5)
        {
            IExecute("insertHTML", arg0, arg1, arg2, arg3, arg4, arg5);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/HTMLEditorKit.html#setAutoFormSubmission(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetAutoFormSubmission(bool arg0)
        {
            IExecuteWithSignature("setAutoFormSubmission", "(Z)V", arg0);
        }

        #endregion

        #region Nested classes
        #region HTMLFactory
        public partial class HTMLFactory
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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/HTMLEditorKit.HTMLFactory.html#create(javax.swing.text.Element)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.Text.Element"/></param>
            /// <returns><see cref="Javax.Swing.Text.View"/></returns>
            public Javax.Swing.Text.View Create(Javax.Swing.Text.Element arg0)
            {
                return IExecuteWithSignature<Javax.Swing.Text.View>("create", "(Ljavax/swing/text/Element;)Ljavax/swing/text/View;", arg0);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region HTMLTextAction
        public partial class HTMLTextAction
        {
            #region Constructors
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/HTMLEditorKit.HTMLTextAction.html#%3Cinit%3E(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            public HTMLTextAction(Java.Lang.String arg0)
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

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region InsertHTMLTextAction
        public partial class InsertHTMLTextAction
        {
            #region Constructors
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/HTMLEditorKit.InsertHTMLTextAction.html#%3Cinit%3E(java.lang.String,java.lang.String,javax.swing.text.html.HTML.Tag,javax.swing.text.html.HTML.Tag,javax.swing.text.html.HTML.Tag,javax.swing.text.html.HTML.Tag)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <param name="arg1"><see cref="Java.Lang.String"/></param>
            /// <param name="arg2"><see cref="Javax.Swing.Text.Html.HTML.Tag"/></param>
            /// <param name="arg3"><see cref="Javax.Swing.Text.Html.HTML.Tag"/></param>
            /// <param name="arg4"><see cref="Javax.Swing.Text.Html.HTML.Tag"/></param>
            /// <param name="arg5"><see cref="Javax.Swing.Text.Html.HTML.Tag"/></param>
            public InsertHTMLTextAction(Java.Lang.String arg0, Java.Lang.String arg1, Javax.Swing.Text.Html.HTML.Tag arg2, Javax.Swing.Text.Html.HTML.Tag arg3, Javax.Swing.Text.Html.HTML.Tag arg4, Javax.Swing.Text.Html.HTML.Tag arg5)
                : base(arg0, arg1, arg2, arg3, arg4, arg5)
            {
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/HTMLEditorKit.InsertHTMLTextAction.html#%3Cinit%3E(java.lang.String,java.lang.String,javax.swing.text.html.HTML.Tag,javax.swing.text.html.HTML.Tag)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <param name="arg1"><see cref="Java.Lang.String"/></param>
            /// <param name="arg2"><see cref="Javax.Swing.Text.Html.HTML.Tag"/></param>
            /// <param name="arg3"><see cref="Javax.Swing.Text.Html.HTML.Tag"/></param>
            public InsertHTMLTextAction(Java.Lang.String arg0, Java.Lang.String arg1, Javax.Swing.Text.Html.HTML.Tag arg2, Javax.Swing.Text.Html.HTML.Tag arg3)
                : base(arg0, arg1, arg2, arg3)
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

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region Parser
        public partial class Parser
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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/HTMLEditorKit.Parser.html#parse(java.io.Reader,javax.swing.text.html.HTMLEditorKit.ParserCallback,boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Io.Reader"/></param>
            /// <param name="arg1"><see cref="Javax.Swing.Text.Html.HTMLEditorKit.ParserCallback"/></param>
            /// <param name="arg2"><see cref="bool"/></param>
            /// <exception cref="Java.Io.IOException"/>
            public void Parse(Java.Io.Reader arg0, Javax.Swing.Text.Html.HTMLEditorKit.ParserCallback arg1, bool arg2)
            {
                IExecute("parse", arg0, arg1, arg2);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region ParserCallback
        public partial class ParserCallback
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/HTMLEditorKit.ParserCallback.html#IMPLIED"/>
            /// </summary>
            public static object IMPLIED { get { if (!_IMPLIEDReady) { _IMPLIEDContent = SGetField(LocalBridgeClazz, "IMPLIED"); _IMPLIEDReady = true; } return _IMPLIEDContent; } }
            private static object _IMPLIEDContent = default;
            private static bool _IMPLIEDReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/HTMLEditorKit.ParserCallback.html#flush()"/>
            /// </summary>
            /// <exception cref="Javax.Swing.Text.BadLocationException"/>
            public void Flush()
            {
                IExecuteWithSignature("flush", "()V");
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/HTMLEditorKit.ParserCallback.html#handleComment(char[],int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="char"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            public void HandleComment(char[] arg0, int arg1)
            {
                IExecute("handleComment", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/HTMLEditorKit.ParserCallback.html#handleEndOfLineString(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            public void HandleEndOfLineString(Java.Lang.String arg0)
            {
                IExecuteWithSignature("handleEndOfLineString", "(Ljava/lang/String;)V", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/HTMLEditorKit.ParserCallback.html#handleEndTag(javax.swing.text.html.HTML.Tag,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.Text.Html.HTML.Tag"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            public void HandleEndTag(Javax.Swing.Text.Html.HTML.Tag arg0, int arg1)
            {
                IExecute("handleEndTag", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/HTMLEditorKit.ParserCallback.html#handleError(java.lang.String,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            public void HandleError(Java.Lang.String arg0, int arg1)
            {
                IExecute("handleError", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/HTMLEditorKit.ParserCallback.html#handleSimpleTag(javax.swing.text.html.HTML.Tag,javax.swing.text.MutableAttributeSet,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.Text.Html.HTML.Tag"/></param>
            /// <param name="arg1"><see cref="Javax.Swing.Text.MutableAttributeSet"/></param>
            /// <param name="arg2"><see cref="int"/></param>
            public void HandleSimpleTag(Javax.Swing.Text.Html.HTML.Tag arg0, Javax.Swing.Text.MutableAttributeSet arg1, int arg2)
            {
                IExecute("handleSimpleTag", arg0, arg1, arg2);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/HTMLEditorKit.ParserCallback.html#handleStartTag(javax.swing.text.html.HTML.Tag,javax.swing.text.MutableAttributeSet,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.Text.Html.HTML.Tag"/></param>
            /// <param name="arg1"><see cref="Javax.Swing.Text.MutableAttributeSet"/></param>
            /// <param name="arg2"><see cref="int"/></param>
            public void HandleStartTag(Javax.Swing.Text.Html.HTML.Tag arg0, Javax.Swing.Text.MutableAttributeSet arg1, int arg2)
            {
                IExecute("handleStartTag", arg0, arg1, arg2);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/HTMLEditorKit.ParserCallback.html#handleText(char[],int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="char"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            public void HandleText(char[] arg0, int arg1)
            {
                IExecute("handleText", arg0, arg1);
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