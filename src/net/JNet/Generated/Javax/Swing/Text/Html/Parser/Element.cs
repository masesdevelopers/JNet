/*
*  Copyright 2023 MASES s.r.l.
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
*  This file is generated by MASES.JNetReflector (ver. 2.0.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Swing.Text.Html.Parser
{
    #region Element
    public partial class Element
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Swing.Text.Html.Parser.Element"/> to <see cref="Javax.Swing.Text.Html.Parser.DTDConstants"/>
        /// </summary>
        public static implicit operator Javax.Swing.Text.Html.Parser.DTDConstants(Javax.Swing.Text.Html.Parser.Element t) => t.Cast<Javax.Swing.Text.Html.Parser.DTDConstants>();
        /// <summary>
        /// Converter from <see cref="Javax.Swing.Text.Html.Parser.Element"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Javax.Swing.Text.Html.Parser.Element t) => t.Cast<Java.Io.Serializable>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/parser/Element.html#oEnd"/>
        /// </summary>
        public bool oEnd { get { return IGetField<bool>("oEnd"); } set { ISetField("oEnd", value); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/parser/Element.html#oStart"/>
        /// </summary>
        public bool oStart { get { return IGetField<bool>("oStart"); } set { ISetField("oStart", value); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/parser/Element.html#index"/>
        /// </summary>
        public int index { get { return IGetField<int>("index"); } set { ISetField("index", value); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/parser/Element.html#type"/>
        /// </summary>
        public int type { get { return IGetField<int>("type"); } set { ISetField("type", value); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/parser/Element.html#data"/>
        /// </summary>
        public object data { get { return IGetField("data"); } set { ISetField("data", value); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/parser/Element.html#name"/>
        /// </summary>
        public string name { get { return IGetField<string>("name"); } set { ISetField("name", value); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/parser/Element.html#exclusions"/>
        /// </summary>
        public Java.Util.BitSet exclusions { get { return IGetField<Java.Util.BitSet>("exclusions"); } set { ISetField("exclusions", value); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/parser/Element.html#inclusions"/>
        /// </summary>
        public Java.Util.BitSet inclusions { get { return IGetField<Java.Util.BitSet>("inclusions"); } set { ISetField("inclusions", value); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/parser/Element.html#atts"/>
        /// </summary>
        public Javax.Swing.Text.Html.Parser.AttributeList atts { get { return IGetField<Javax.Swing.Text.Html.Parser.AttributeList>("atts"); } set { ISetField("atts", value); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/parser/Element.html#content"/>
        /// </summary>
        public Javax.Swing.Text.Html.Parser.ContentModel content { get { return IGetField<Javax.Swing.Text.Html.Parser.ContentModel>("content"); } set { ISetField("content", value); } }

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/parser/Element.html#name2type(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="int"/></returns>
        public static int Name2type(string arg0)
        {
            return SExecute<int>(LocalBridgeClazz, "name2type", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/parser/Element.html#getAttributes()"/> 
        /// </summary>
        public Javax.Swing.Text.Html.Parser.AttributeList Attributes
        {
            get { return IExecute<Javax.Swing.Text.Html.Parser.AttributeList>("getAttributes"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/parser/Element.html#getContent()"/> 
        /// </summary>
        public Javax.Swing.Text.Html.Parser.ContentModel Content
        {
            get { return IExecute<Javax.Swing.Text.Html.Parser.ContentModel>("getContent"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/parser/Element.html#getIndex()"/> 
        /// </summary>
        public int Index
        {
            get { return IExecute<int>("getIndex"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/parser/Element.html#getName()"/> 
        /// </summary>
        public string Name
        {
            get { return IExecute<string>("getName"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/parser/Element.html#getType()"/> 
        /// </summary>
        public int Type
        {
            get { return IExecute<int>("getType"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/parser/Element.html#isEmpty()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsEmpty()
        {
            return IExecute<bool>("isEmpty");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/parser/Element.html#omitEnd()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool OmitEnd()
        {
            return IExecute<bool>("omitEnd");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/parser/Element.html#omitStart()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool OmitStart()
        {
            return IExecute<bool>("omitStart");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/parser/Element.html#getAttribute(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Javax.Swing.Text.Html.Parser.AttributeList"/></returns>
        public Javax.Swing.Text.Html.Parser.AttributeList GetAttribute(string arg0)
        {
            return IExecute<Javax.Swing.Text.Html.Parser.AttributeList>("getAttribute", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/html/parser/Element.html#getAttributeByValue(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Javax.Swing.Text.Html.Parser.AttributeList"/></returns>
        public Javax.Swing.Text.Html.Parser.AttributeList GetAttributeByValue(string arg0)
        {
            return IExecute<Javax.Swing.Text.Html.Parser.AttributeList>("getAttributeByValue", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}