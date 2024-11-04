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

namespace Java.Text
{
    #region MessageFormat declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/MessageFormat.html"/>
    /// </summary>
    public partial class MessageFormat : Java.Text.Format
    {
        const string _bridgeClassName = "java.text.MessageFormat";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public MessageFormat() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public MessageFormat(params object[] args) : base(args) { }

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
        #region Field declaration
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/MessageFormat.Field.html"/>
        /// </summary>
        public partial class Field : Java.Text.Format.Field
        {
            const string _bridgeClassName = "java.text.MessageFormat$Field";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public Field() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public Field(params object[] args) : base(args) { }

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

    #region MessageFormat implementation
    public partial class MessageFormat
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/MessageFormat.html#%3Cinit%3E(java.lang.String,java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Util.Locale"/></param>
        public MessageFormat(Java.Lang.String arg0, Java.Util.Locale arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/MessageFormat.html#%3Cinit%3E(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public MessageFormat(Java.Lang.String arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/MessageFormat.html#format(java.lang.String,java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String Format(Java.Lang.String arg0, params object[] arg1)
        {
            if (arg1.Length == 0) return SExecuteWithSignature<Java.Lang.String>(LocalBridgeClazz, "format", "(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;", arg0); else return SExecuteWithSignature<Java.Lang.String>(LocalBridgeClazz, "format", "(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;", arg0, arg1);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/MessageFormat.html#getFormats()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/MessageFormat.html#setFormats(java.text.Format[])"/>
        /// </summary>
        public Java.Text.Format[] Formats
        {
            get { return IExecuteWithSignatureArray<Java.Text.Format>("getFormats", "()[Ljava/text/Format;"); } set { IExecuteWithSignature("setFormats", "([Ljava/text/Format;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/MessageFormat.html#getFormatsByArgumentIndex()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/MessageFormat.html#setFormatsByArgumentIndex(java.text.Format[])"/>
        /// </summary>
        public Java.Text.Format[] FormatsByArgumentIndex
        {
            get { return IExecuteWithSignatureArray<Java.Text.Format>("getFormatsByArgumentIndex", "()[Ljava/text/Format;"); } set { IExecuteWithSignature("setFormatsByArgumentIndex", "([Ljava/text/Format;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/MessageFormat.html#getLocale()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/MessageFormat.html#setLocale(java.util.Locale)"/>
        /// </summary>
        public Java.Util.Locale Locale
        {
            get { return IExecuteWithSignature<Java.Util.Locale>("getLocale", "()Ljava/util/Locale;"); } set { IExecuteWithSignature("setLocale", "(Ljava/util/Locale;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/MessageFormat.html#format(java.lang.Object[],java.lang.StringBuffer,java.text.FieldPosition)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="Java.Lang.StringBuffer"/></param>
        /// <param name="arg2"><see cref="Java.Text.FieldPosition"/></param>
        /// <returns><see cref="Java.Lang.StringBuffer"/></returns>
        public Java.Lang.StringBuffer Format(object[] arg0, Java.Lang.StringBuffer arg1, Java.Text.FieldPosition arg2)
        {
            return IExecuteWithSignature<Java.Lang.StringBuffer>("format", "([Ljava/lang/Object;Ljava/lang/StringBuffer;Ljava/text/FieldPosition;)Ljava/lang/StringBuffer;", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/MessageFormat.html#parse(java.lang.String,java.text.ParsePosition)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Text.ParsePosition"/></param>
        /// <returns><see cref="object"/></returns>
        public object[] Parse(Java.Lang.String arg0, Java.Text.ParsePosition arg1)
        {
            return IExecuteWithSignatureArray<object>("parse", "(Ljava/lang/String;Ljava/text/ParsePosition;)[Ljava/lang/Object;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/MessageFormat.html#parse(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Java.Text.ParseException"/>
        public object[] Parse(Java.Lang.String arg0)
        {
            return IExecuteWithSignatureArray<object>("parse", "(Ljava/lang/String;)[Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/MessageFormat.html#toPattern()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String ToPattern()
        {
            return IExecuteWithSignature<Java.Lang.String>("toPattern", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/MessageFormat.html#applyPattern(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void ApplyPattern(Java.Lang.String arg0)
        {
            IExecuteWithSignature("applyPattern", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/MessageFormat.html#setFormat(int,java.text.Format)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Text.Format"/></param>
        public void SetFormat(int arg0, Java.Text.Format arg1)
        {
            IExecuteWithSignature("setFormat", "(ILjava/text/Format;)V", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/MessageFormat.html#setFormatByArgumentIndex(int,java.text.Format)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Text.Format"/></param>
        public void SetFormatByArgumentIndex(int arg0, Java.Text.Format arg1)
        {
            IExecuteWithSignature("setFormatByArgumentIndex", "(ILjava/text/Format;)V", arg0, arg1);
        }

        #endregion

        #region Nested classes
        #region Field implementation
        public partial class Field
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/MessageFormat.Field.html#ARGUMENT"/>
            /// </summary>
            public static Java.Text.MessageFormat.Field ARGUMENT { get { if (!_ARGUMENTReady) { _ARGUMENTContent = SGetField<Java.Text.MessageFormat.Field>(LocalBridgeClazz, "ARGUMENT"); _ARGUMENTReady = true; } return _ARGUMENTContent; } }
            private static Java.Text.MessageFormat.Field _ARGUMENTContent = default;
            private static bool _ARGUMENTReady = false; // this is used because in case of generics 

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

    
        #endregion

        // TODO: complete the class
    }
    #endregion
}