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

namespace Java.Text
{
    #region CharacterIterator definition
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/CharacterIterator.html"/>
    /// </summary>
    public partial class CharacterIterator : Java.Lang.Cloneable
    {
        const string _bridgeClassName = "java.text.CharacterIterator";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("CharacterIterator class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public CharacterIterator() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("CharacterIterator class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public CharacterIterator(params object[] args) : base(args) { }

        private static readonly IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new InvalidOperationException($"Class {_bridgeClassName} was not found.");

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
        public override bool IsBridgeInterface => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region ICharacterIterator
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface ICharacterIterator : Java.Lang.ICloneable
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/CharacterIterator.html#getBeginIndex()"/> 
        /// </summary>
        int BeginIndex { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/CharacterIterator.html#getEndIndex()"/> 
        /// </summary>
        int EndIndex { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/CharacterIterator.html#getIndex()"/> 
        /// </summary>
        int Index { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/CharacterIterator.html#current()"/>
        /// </summary>
        /// <returns><see cref="char"/></returns>
        char Current();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/CharacterIterator.html#first()"/>
        /// </summary>
        /// <returns><see cref="char"/></returns>
        char First();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/CharacterIterator.html#last()"/>
        /// </summary>
        /// <returns><see cref="char"/></returns>
        char Last();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/CharacterIterator.html#next()"/>
        /// </summary>
        /// <returns><see cref="char"/></returns>
        char Next();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/CharacterIterator.html#previous()"/>
        /// </summary>
        /// <returns><see cref="char"/></returns>
        char Previous();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/CharacterIterator.html#setIndex(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="char"/></returns>
        char SetIndex(int arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region CharacterIterator
    public partial class CharacterIterator : Java.Text.ICharacterIterator
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/CharacterIterator.html#DONE"/>
        /// </summary>
        public static char DONE { get { if (!_DONEReady) { _DONEContent = SGetField<char>(LocalBridgeClazz, "DONE"); _DONEReady = true; } return _DONEContent; } }
        private static char _DONEContent = default;
        private static bool _DONEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/CharacterIterator.html#getBeginIndex()"/> 
        /// </summary>
        public int BeginIndex
        {
            get { return IExecuteWithSignature<int>("getBeginIndex", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/CharacterIterator.html#getEndIndex()"/> 
        /// </summary>
        public int EndIndex
        {
            get { return IExecuteWithSignature<int>("getEndIndex", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/CharacterIterator.html#getIndex()"/> 
        /// </summary>
        public int Index
        {
            get { return IExecuteWithSignature<int>("getIndex", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/CharacterIterator.html#current()"/>
        /// </summary>
        /// <returns><see cref="char"/></returns>
        public char Current()
        {
            return IExecuteWithSignature<char>("current", "()C");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/CharacterIterator.html#first()"/>
        /// </summary>
        /// <returns><see cref="char"/></returns>
        public char First()
        {
            return IExecuteWithSignature<char>("first", "()C");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/CharacterIterator.html#last()"/>
        /// </summary>
        /// <returns><see cref="char"/></returns>
        public char Last()
        {
            return IExecuteWithSignature<char>("last", "()C");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/CharacterIterator.html#next()"/>
        /// </summary>
        /// <returns><see cref="char"/></returns>
        public char Next()
        {
            return IExecuteWithSignature<char>("next", "()C");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/CharacterIterator.html#previous()"/>
        /// </summary>
        /// <returns><see cref="char"/></returns>
        public char Previous()
        {
            return IExecuteWithSignature<char>("previous", "()C");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/text/CharacterIterator.html#setIndex(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="char"/></returns>
        public char SetIndex(int arg0)
        {
            return IExecuteWithSignature<char>("setIndex", "(I)C", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}