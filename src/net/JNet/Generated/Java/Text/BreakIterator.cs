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

namespace Java.Text
{
    #region BreakIterator declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/BreakIterator.html"/>
    /// </summary>
    public partial class BreakIterator : Java.Lang.Cloneable
    {
        const string _bridgeClassName = "java.text.BreakIterator";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("BreakIterator class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public BreakIterator() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("BreakIterator class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public BreakIterator(params object[] args) : base(args) { }

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

    #region BreakIterator implementation
    public partial class BreakIterator
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/BreakIterator.html#DONE"/>
        /// </summary>
        public static int DONE { get { if (!_DONEReady) { _DONEContent = SGetField<int>(LocalBridgeClazz, "DONE"); _DONEReady = true; } return _DONEContent; } }
        private static int _DONEContent = default;
        private static bool _DONEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/BreakIterator.html#getAvailableLocales()"/> 
        /// </summary>
        public static Java.Util.Locale[] AvailableLocales
        {
            get { return SExecuteWithSignatureArray<Java.Util.Locale>(LocalBridgeClazz, "getAvailableLocales", "()[Ljava/util/Locale;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/BreakIterator.html#getCharacterInstance()"/> 
        /// </summary>
        public static Java.Text.BreakIterator CharacterInstance
        {
            get { return SExecuteWithSignature<Java.Text.BreakIterator>(LocalBridgeClazz, "getCharacterInstance", "()Ljava/text/BreakIterator;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/BreakIterator.html#getLineInstance()"/> 
        /// </summary>
        public static Java.Text.BreakIterator LineInstance
        {
            get { return SExecuteWithSignature<Java.Text.BreakIterator>(LocalBridgeClazz, "getLineInstance", "()Ljava/text/BreakIterator;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/BreakIterator.html#getSentenceInstance()"/> 
        /// </summary>
        public static Java.Text.BreakIterator SentenceInstance
        {
            get { return SExecuteWithSignature<Java.Text.BreakIterator>(LocalBridgeClazz, "getSentenceInstance", "()Ljava/text/BreakIterator;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/BreakIterator.html#getWordInstance()"/> 
        /// </summary>
        public static Java.Text.BreakIterator WordInstance
        {
            get { return SExecuteWithSignature<Java.Text.BreakIterator>(LocalBridgeClazz, "getWordInstance", "()Ljava/text/BreakIterator;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/BreakIterator.html#getCharacterInstance(java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="Java.Text.BreakIterator"/></returns>
        public static Java.Text.BreakIterator GetCharacterInstance(Java.Util.Locale arg0)
        {
            return SExecuteWithSignature<Java.Text.BreakIterator>(LocalBridgeClazz, "getCharacterInstance", "(Ljava/util/Locale;)Ljava/text/BreakIterator;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/BreakIterator.html#getLineInstance(java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="Java.Text.BreakIterator"/></returns>
        public static Java.Text.BreakIterator GetLineInstance(Java.Util.Locale arg0)
        {
            return SExecuteWithSignature<Java.Text.BreakIterator>(LocalBridgeClazz, "getLineInstance", "(Ljava/util/Locale;)Ljava/text/BreakIterator;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/BreakIterator.html#getSentenceInstance(java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="Java.Text.BreakIterator"/></returns>
        public static Java.Text.BreakIterator GetSentenceInstance(Java.Util.Locale arg0)
        {
            return SExecuteWithSignature<Java.Text.BreakIterator>(LocalBridgeClazz, "getSentenceInstance", "(Ljava/util/Locale;)Ljava/text/BreakIterator;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/BreakIterator.html#getWordInstance(java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
        /// <returns><see cref="Java.Text.BreakIterator"/></returns>
        public static Java.Text.BreakIterator GetWordInstance(Java.Util.Locale arg0)
        {
            return SExecuteWithSignature<Java.Text.BreakIterator>(LocalBridgeClazz, "getWordInstance", "(Ljava/util/Locale;)Ljava/text/BreakIterator;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/BreakIterator.html#getText()"/> 
        /// </summary>
        public Java.Text.CharacterIterator Text
        {
            get { return IExecuteWithSignature<Java.Text.CharacterIterator>("getText", "()Ljava/text/CharacterIterator;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/BreakIterator.html#current()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int Current()
        {
            return IExecuteWithSignature<int>("current", "()I");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/BreakIterator.html#first()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int First()
        {
            return IExecuteWithSignature<int>("first", "()I");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/BreakIterator.html#following(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int Following(int arg0)
        {
            return IExecuteWithSignature<int>("following", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/BreakIterator.html#last()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int Last()
        {
            return IExecuteWithSignature<int>("last", "()I");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/BreakIterator.html#next()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int Next()
        {
            return IExecuteWithSignature<int>("next", "()I");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/BreakIterator.html#next(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int Next(int arg0)
        {
            return IExecuteWithSignature<int>("next", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/BreakIterator.html#previous()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int Previous()
        {
            return IExecuteWithSignature<int>("previous", "()I");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/BreakIterator.html#setText(java.text.CharacterIterator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Text.CharacterIterator"/></param>
        public void SetText(Java.Text.CharacterIterator arg0)
        {
            IExecuteWithSignature("setText", "(Ljava/text/CharacterIterator;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/BreakIterator.html#isBoundary(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsBoundary(int arg0)
        {
            return IExecuteWithSignature<bool>("isBoundary", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/BreakIterator.html#preceding(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int Preceding(int arg0)
        {
            return IExecuteWithSignature<int>("preceding", "(I)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/BreakIterator.html#setText(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public void SetText(Java.Lang.String arg0)
        {
            IExecuteWithSignature("setText", "(Ljava/lang/String;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}