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
*  This file is generated by MASES.JNetReflector (ver. 2.5.9.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Swing.Text.Html
{
    #region StyleSheet declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/StyleSheet.html"/>
    /// </summary>
    public partial class StyleSheet : Javax.Swing.Text.StyleContext
    {
        const string _bridgeClassName = "javax.swing.text.html.StyleSheet";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public StyleSheet() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public StyleSheet(params object[] args) : base(args) { }

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
        #region BoxPainter declaration
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/StyleSheet.BoxPainter.html"/>
        /// </summary>
        public partial class BoxPainter : Java.Io.Serializable
        {
            const string _bridgeClassName = "javax.swing.text.html.StyleSheet$BoxPainter";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public BoxPainter() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public BoxPainter(params object[] args) : base(args) { }

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

        #region ListPainter declaration
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/StyleSheet.ListPainter.html"/>
        /// </summary>
        public partial class ListPainter : Java.Io.Serializable
        {
            const string _bridgeClassName = "javax.swing.text.html.StyleSheet$ListPainter";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public ListPainter() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public ListPainter(params object[] args) : base(args) { }

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

    #region StyleSheet implementation
    public partial class StyleSheet
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/StyleSheet.html#getIndexOfSize(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <returns><see cref="int"/></returns>
        public static int GetIndexOfSize(float arg0)
        {
            return SExecute<int>(LocalBridgeClazz, "getIndexOfSize", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/StyleSheet.html#getBase()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/StyleSheet.html#setBase(java.net.URL)"/>
        /// </summary>
        public Java.Net.URL Base
        {
            get { return IExecute<Java.Net.URL>("getBase"); } set { IExecute("setBase", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/StyleSheet.html#getStyleSheets()"/> 
        /// </summary>
        public Javax.Swing.Text.Html.StyleSheet[] StyleSheets
        {
            get { return IExecuteArray<Javax.Swing.Text.Html.StyleSheet>("getStyleSheets"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/StyleSheet.html#addCSSAttributeFromHTML(javax.swing.text.MutableAttributeSet,javax.swing.text.html.CSS.Attribute,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Text.MutableAttributeSet"/></param>
        /// <param name="arg1"><see cref="Javax.Swing.Text.Html.CSS.Attribute"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool AddCSSAttributeFromHTML(Javax.Swing.Text.MutableAttributeSet arg0, Javax.Swing.Text.Html.CSS.Attribute arg1, Java.Lang.String arg2)
        {
            return IExecute<bool>("addCSSAttributeFromHTML", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/StyleSheet.html#getPointSize(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="float"/></returns>
        public float GetPointSize(int arg0)
        {
            return IExecute<float>("getPointSize", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/StyleSheet.html#getPointSize(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="float"/></returns>
        public float GetPointSize(Java.Lang.String arg0)
        {
            return IExecute<float>("getPointSize", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/StyleSheet.html#stringToColor(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Awt.Color"/></returns>
        public Java.Awt.Color StringToColor(Java.Lang.String arg0)
        {
            return IExecute<Java.Awt.Color>("stringToColor", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/StyleSheet.html#getDeclaration(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Swing.Text.AttributeSet"/></returns>
        public Javax.Swing.Text.AttributeSet GetDeclaration(Java.Lang.String arg0)
        {
            return IExecute<Javax.Swing.Text.AttributeSet>("getDeclaration", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/StyleSheet.html#getViewAttributes(javax.swing.text.View)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Text.View"/></param>
        /// <returns><see cref="Javax.Swing.Text.AttributeSet"/></returns>
        public Javax.Swing.Text.AttributeSet GetViewAttributes(Javax.Swing.Text.View arg0)
        {
            return IExecute<Javax.Swing.Text.AttributeSet>("getViewAttributes", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/StyleSheet.html#translateHTMLToCSS(javax.swing.text.AttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Text.AttributeSet"/></param>
        /// <returns><see cref="Javax.Swing.Text.AttributeSet"/></returns>
        public Javax.Swing.Text.AttributeSet TranslateHTMLToCSS(Javax.Swing.Text.AttributeSet arg0)
        {
            return IExecute<Javax.Swing.Text.AttributeSet>("translateHTMLToCSS", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/StyleSheet.html#getBoxPainter(javax.swing.text.AttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Text.AttributeSet"/></param>
        /// <returns><see cref="Javax.Swing.Text.Html.StyleSheet.BoxPainter"/></returns>
        public Javax.Swing.Text.Html.StyleSheet.BoxPainter GetBoxPainter(Javax.Swing.Text.AttributeSet arg0)
        {
            return IExecute<Javax.Swing.Text.Html.StyleSheet.BoxPainter>("getBoxPainter", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/StyleSheet.html#getListPainter(javax.swing.text.AttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Text.AttributeSet"/></param>
        /// <returns><see cref="Javax.Swing.Text.Html.StyleSheet.ListPainter"/></returns>
        public Javax.Swing.Text.Html.StyleSheet.ListPainter GetListPainter(Javax.Swing.Text.AttributeSet arg0)
        {
            return IExecute<Javax.Swing.Text.Html.StyleSheet.ListPainter>("getListPainter", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/StyleSheet.html#getRule(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Swing.Text.Style"/></returns>
        public Javax.Swing.Text.Style GetRule(Java.Lang.String arg0)
        {
            return IExecute<Javax.Swing.Text.Style>("getRule", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/StyleSheet.html#getRule(javax.swing.text.html.HTML.Tag,javax.swing.text.Element)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Text.Html.HTML.Tag"/></param>
        /// <param name="arg1"><see cref="Javax.Swing.Text.Element"/></param>
        /// <returns><see cref="Javax.Swing.Text.Style"/></returns>
        public Javax.Swing.Text.Style GetRule(Javax.Swing.Text.Html.HTML.Tag arg0, Javax.Swing.Text.Element arg1)
        {
            return IExecute<Javax.Swing.Text.Style>("getRule", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/StyleSheet.html#addCSSAttribute(javax.swing.text.MutableAttributeSet,javax.swing.text.html.CSS.Attribute,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Text.MutableAttributeSet"/></param>
        /// <param name="arg1"><see cref="Javax.Swing.Text.Html.CSS.Attribute"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        public void AddCSSAttribute(Javax.Swing.Text.MutableAttributeSet arg0, Javax.Swing.Text.Html.CSS.Attribute arg1, Java.Lang.String arg2)
        {
            IExecute("addCSSAttribute", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/StyleSheet.html#addRule(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void AddRule(Java.Lang.String arg0)
        {
            IExecute("addRule", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/StyleSheet.html#addStyleSheet(javax.swing.text.html.StyleSheet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Text.Html.StyleSheet"/></param>
        public void AddStyleSheet(Javax.Swing.Text.Html.StyleSheet arg0)
        {
            IExecute("addStyleSheet", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/StyleSheet.html#importStyleSheet(java.net.URL)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.URL"/></param>
        public void ImportStyleSheet(Java.Net.URL arg0)
        {
            IExecute("importStyleSheet", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/StyleSheet.html#loadRules(java.io.Reader,java.net.URL)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.Reader"/></param>
        /// <param name="arg1"><see cref="Java.Net.URL"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void LoadRules(Java.Io.Reader arg0, Java.Net.URL arg1)
        {
            IExecute("loadRules", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/StyleSheet.html#removeStyleSheet(javax.swing.text.html.StyleSheet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Text.Html.StyleSheet"/></param>
        public void RemoveStyleSheet(Javax.Swing.Text.Html.StyleSheet arg0)
        {
            IExecute("removeStyleSheet", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/StyleSheet.html#setBaseFontSize(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetBaseFontSize(int arg0)
        {
            IExecute("setBaseFontSize", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/StyleSheet.html#setBaseFontSize(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void SetBaseFontSize(Java.Lang.String arg0)
        {
            IExecute("setBaseFontSize", arg0);
        }

        #endregion

        #region Nested classes
        #region BoxPainter implementation
        public partial class BoxPainter
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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/StyleSheet.BoxPainter.html#getInset(int,javax.swing.text.View)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <param name="arg1"><see cref="Javax.Swing.Text.View"/></param>
            /// <returns><see cref="float"/></returns>
            public float GetInset(int arg0, Javax.Swing.Text.View arg1)
            {
                return IExecute<float>("getInset", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/StyleSheet.BoxPainter.html#paint(java.awt.Graphics,float,float,float,float,javax.swing.text.View)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Awt.Graphics"/></param>
            /// <param name="arg1"><see cref="float"/></param>
            /// <param name="arg2"><see cref="float"/></param>
            /// <param name="arg3"><see cref="float"/></param>
            /// <param name="arg4"><see cref="float"/></param>
            /// <param name="arg5"><see cref="Javax.Swing.Text.View"/></param>
            public void Paint(Java.Awt.Graphics arg0, float arg1, float arg2, float arg3, float arg4, Javax.Swing.Text.View arg5)
            {
                IExecute("paint", arg0, arg1, arg2, arg3, arg4, arg5);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region ListPainter implementation
        public partial class ListPainter
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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/StyleSheet.ListPainter.html#paint(java.awt.Graphics,float,float,float,float,javax.swing.text.View,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Awt.Graphics"/></param>
            /// <param name="arg1"><see cref="float"/></param>
            /// <param name="arg2"><see cref="float"/></param>
            /// <param name="arg3"><see cref="float"/></param>
            /// <param name="arg4"><see cref="float"/></param>
            /// <param name="arg5"><see cref="Javax.Swing.Text.View"/></param>
            /// <param name="arg6"><see cref="int"/></param>
            public void Paint(Java.Awt.Graphics arg0, float arg1, float arg2, float arg3, float arg4, Javax.Swing.Text.View arg5, int arg6)
            {
                IExecute("paint", arg0, arg1, arg2, arg3, arg4, arg5, arg6);
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