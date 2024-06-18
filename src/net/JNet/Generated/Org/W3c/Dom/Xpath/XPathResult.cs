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

namespace Org.W3c.Dom.Xpath
{
    #region IXPathResult
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IXPathResult
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/xpath/XPathResult.html#getBooleanValue()"/> 
        /// </summary>
        bool BooleanValue { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/xpath/XPathResult.html#getInvalidIteratorState()"/> 
        /// </summary>
        bool InvalidIteratorState { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/xpath/XPathResult.html#getNumberValue()"/> 
        /// </summary>
        double NumberValue { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/xpath/XPathResult.html#getResultType()"/> 
        /// </summary>
        short ResultType { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/xpath/XPathResult.html#getSingleNodeValue()"/> 
        /// </summary>
        Org.W3c.Dom.Node SingleNodeValue { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/xpath/XPathResult.html#getSnapshotLength()"/> 
        /// </summary>
        int SnapshotLength { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/xpath/XPathResult.html#getStringValue()"/> 
        /// </summary>
        Java.Lang.String StringValue { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/xpath/XPathResult.html#iterateNext()"/>
        /// </summary>
        /// <returns><see cref="Org.W3c.Dom.Node"/></returns>
        /// <exception cref="Org.W3c.Dom.Xpath.XPathException"/>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        Org.W3c.Dom.Node IterateNext();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/xpath/XPathResult.html#snapshotItem(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Org.W3c.Dom.Node"/></returns>
        /// <exception cref="Org.W3c.Dom.Xpath.XPathException"/>
        Org.W3c.Dom.Node SnapshotItem(int arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region XPathResult
    public partial class XPathResult : Org.W3c.Dom.Xpath.IXPathResult
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/xpath/XPathResult.html#ANY_TYPE"/>
        /// </summary>
        public static short ANY_TYPE { get { if (!_ANY_TYPEReady) { _ANY_TYPEContent = SGetField<short>(LocalBridgeClazz, "ANY_TYPE"); _ANY_TYPEReady = true; } return _ANY_TYPEContent; } }
        private static short _ANY_TYPEContent = default;
        private static bool _ANY_TYPEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/xpath/XPathResult.html#ANY_UNORDERED_NODE_TYPE"/>
        /// </summary>
        public static short ANY_UNORDERED_NODE_TYPE { get { if (!_ANY_UNORDERED_NODE_TYPEReady) { _ANY_UNORDERED_NODE_TYPEContent = SGetField<short>(LocalBridgeClazz, "ANY_UNORDERED_NODE_TYPE"); _ANY_UNORDERED_NODE_TYPEReady = true; } return _ANY_UNORDERED_NODE_TYPEContent; } }
        private static short _ANY_UNORDERED_NODE_TYPEContent = default;
        private static bool _ANY_UNORDERED_NODE_TYPEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/xpath/XPathResult.html#BOOLEAN_TYPE"/>
        /// </summary>
        public static short BOOLEAN_TYPE { get { if (!_BOOLEAN_TYPEReady) { _BOOLEAN_TYPEContent = SGetField<short>(LocalBridgeClazz, "BOOLEAN_TYPE"); _BOOLEAN_TYPEReady = true; } return _BOOLEAN_TYPEContent; } }
        private static short _BOOLEAN_TYPEContent = default;
        private static bool _BOOLEAN_TYPEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/xpath/XPathResult.html#FIRST_ORDERED_NODE_TYPE"/>
        /// </summary>
        public static short FIRST_ORDERED_NODE_TYPE { get { if (!_FIRST_ORDERED_NODE_TYPEReady) { _FIRST_ORDERED_NODE_TYPEContent = SGetField<short>(LocalBridgeClazz, "FIRST_ORDERED_NODE_TYPE"); _FIRST_ORDERED_NODE_TYPEReady = true; } return _FIRST_ORDERED_NODE_TYPEContent; } }
        private static short _FIRST_ORDERED_NODE_TYPEContent = default;
        private static bool _FIRST_ORDERED_NODE_TYPEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/xpath/XPathResult.html#NUMBER_TYPE"/>
        /// </summary>
        public static short NUMBER_TYPE { get { if (!_NUMBER_TYPEReady) { _NUMBER_TYPEContent = SGetField<short>(LocalBridgeClazz, "NUMBER_TYPE"); _NUMBER_TYPEReady = true; } return _NUMBER_TYPEContent; } }
        private static short _NUMBER_TYPEContent = default;
        private static bool _NUMBER_TYPEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/xpath/XPathResult.html#ORDERED_NODE_ITERATOR_TYPE"/>
        /// </summary>
        public static short ORDERED_NODE_ITERATOR_TYPE { get { if (!_ORDERED_NODE_ITERATOR_TYPEReady) { _ORDERED_NODE_ITERATOR_TYPEContent = SGetField<short>(LocalBridgeClazz, "ORDERED_NODE_ITERATOR_TYPE"); _ORDERED_NODE_ITERATOR_TYPEReady = true; } return _ORDERED_NODE_ITERATOR_TYPEContent; } }
        private static short _ORDERED_NODE_ITERATOR_TYPEContent = default;
        private static bool _ORDERED_NODE_ITERATOR_TYPEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/xpath/XPathResult.html#ORDERED_NODE_SNAPSHOT_TYPE"/>
        /// </summary>
        public static short ORDERED_NODE_SNAPSHOT_TYPE { get { if (!_ORDERED_NODE_SNAPSHOT_TYPEReady) { _ORDERED_NODE_SNAPSHOT_TYPEContent = SGetField<short>(LocalBridgeClazz, "ORDERED_NODE_SNAPSHOT_TYPE"); _ORDERED_NODE_SNAPSHOT_TYPEReady = true; } return _ORDERED_NODE_SNAPSHOT_TYPEContent; } }
        private static short _ORDERED_NODE_SNAPSHOT_TYPEContent = default;
        private static bool _ORDERED_NODE_SNAPSHOT_TYPEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/xpath/XPathResult.html#STRING_TYPE"/>
        /// </summary>
        public static short STRING_TYPE { get { if (!_STRING_TYPEReady) { _STRING_TYPEContent = SGetField<short>(LocalBridgeClazz, "STRING_TYPE"); _STRING_TYPEReady = true; } return _STRING_TYPEContent; } }
        private static short _STRING_TYPEContent = default;
        private static bool _STRING_TYPEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/xpath/XPathResult.html#UNORDERED_NODE_ITERATOR_TYPE"/>
        /// </summary>
        public static short UNORDERED_NODE_ITERATOR_TYPE { get { if (!_UNORDERED_NODE_ITERATOR_TYPEReady) { _UNORDERED_NODE_ITERATOR_TYPEContent = SGetField<short>(LocalBridgeClazz, "UNORDERED_NODE_ITERATOR_TYPE"); _UNORDERED_NODE_ITERATOR_TYPEReady = true; } return _UNORDERED_NODE_ITERATOR_TYPEContent; } }
        private static short _UNORDERED_NODE_ITERATOR_TYPEContent = default;
        private static bool _UNORDERED_NODE_ITERATOR_TYPEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/xpath/XPathResult.html#UNORDERED_NODE_SNAPSHOT_TYPE"/>
        /// </summary>
        public static short UNORDERED_NODE_SNAPSHOT_TYPE { get { if (!_UNORDERED_NODE_SNAPSHOT_TYPEReady) { _UNORDERED_NODE_SNAPSHOT_TYPEContent = SGetField<short>(LocalBridgeClazz, "UNORDERED_NODE_SNAPSHOT_TYPE"); _UNORDERED_NODE_SNAPSHOT_TYPEReady = true; } return _UNORDERED_NODE_SNAPSHOT_TYPEContent; } }
        private static short _UNORDERED_NODE_SNAPSHOT_TYPEContent = default;
        private static bool _UNORDERED_NODE_SNAPSHOT_TYPEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/xpath/XPathResult.html#getBooleanValue()"/> 
        /// </summary>
        public bool BooleanValue
        {
            get { return IExecuteWithSignature<bool>("getBooleanValue", "()Z"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/xpath/XPathResult.html#getInvalidIteratorState()"/> 
        /// </summary>
        public bool InvalidIteratorState
        {
            get { return IExecuteWithSignature<bool>("getInvalidIteratorState", "()Z"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/xpath/XPathResult.html#getNumberValue()"/> 
        /// </summary>
        public double NumberValue
        {
            get { return IExecuteWithSignature<double>("getNumberValue", "()D"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/xpath/XPathResult.html#getResultType()"/> 
        /// </summary>
        public short ResultType
        {
            get { return IExecuteWithSignature<short>("getResultType", "()S"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/xpath/XPathResult.html#getSingleNodeValue()"/> 
        /// </summary>
        public Org.W3c.Dom.Node SingleNodeValue
        {
            get { return IExecuteWithSignature<Org.W3c.Dom.Node>("getSingleNodeValue", "()Lorg/w3c/dom/Node;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/xpath/XPathResult.html#getSnapshotLength()"/> 
        /// </summary>
        public int SnapshotLength
        {
            get { return IExecuteWithSignature<int>("getSnapshotLength", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/xpath/XPathResult.html#getStringValue()"/> 
        /// </summary>
        public Java.Lang.String StringValue
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getStringValue", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/xpath/XPathResult.html#iterateNext()"/>
        /// </summary>
        /// <returns><see cref="Org.W3c.Dom.Node"/></returns>
        /// <exception cref="Org.W3c.Dom.Xpath.XPathException"/>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        public Org.W3c.Dom.Node IterateNext()
        {
            return IExecuteWithSignature<Org.W3c.Dom.Node>("iterateNext", "()Lorg/w3c/dom/Node;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/jdk.xml.dom/org/w3c/dom/xpath/XPathResult.html#snapshotItem(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Org.W3c.Dom.Node"/></returns>
        /// <exception cref="Org.W3c.Dom.Xpath.XPathException"/>
        public Org.W3c.Dom.Node SnapshotItem(int arg0)
        {
            return IExecuteWithSignature<Org.W3c.Dom.Node>("snapshotItem", "(I)Lorg/w3c/dom/Node;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}