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

namespace Org.W3c.Dom.Ranges
{
    #region IRange
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IRange
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ranges/Range.html#getCollapsed()"/> 
        /// </summary>
        bool Collapsed { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ranges/Range.html#getCommonAncestorContainer()"/> 
        /// </summary>
        Org.W3c.Dom.Node CommonAncestorContainer { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ranges/Range.html#getEndContainer()"/> 
        /// </summary>
        Org.W3c.Dom.Node EndContainer { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ranges/Range.html#getEndOffset()"/> 
        /// </summary>
        int EndOffset { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ranges/Range.html#getStartContainer()"/> 
        /// </summary>
        Org.W3c.Dom.Node StartContainer { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ranges/Range.html#getStartOffset()"/> 
        /// </summary>
        int StartOffset { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ranges/Range.html#cloneContents()"/>
        /// </summary>
        /// <returns><see cref="Org.W3c.Dom.DocumentFragment"/></returns>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        Org.W3c.Dom.DocumentFragment CloneContents();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ranges/Range.html#extractContents()"/>
        /// </summary>
        /// <returns><see cref="Org.W3c.Dom.DocumentFragment"/></returns>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        Org.W3c.Dom.DocumentFragment ExtractContents();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ranges/Range.html#cloneRange()"/>
        /// </summary>
        /// <returns><see cref="Org.W3c.Dom.Ranges.Range"/></returns>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        Org.W3c.Dom.Ranges.Range CloneRange();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ranges/Range.html#compareBoundaryPoints(short,org.w3c.dom.ranges.Range)"/>
        /// </summary>
        /// <param name="arg0"><see cref="short"/></param>
        /// <param name="arg1"><see cref="Org.W3c.Dom.Ranges.Range"/></param>
        /// <returns><see cref="short"/></returns>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        short CompareBoundaryPoints(short arg0, Org.W3c.Dom.Ranges.Range arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ranges/Range.html#collapse(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        void Collapse(bool arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ranges/Range.html#deleteContents()"/>
        /// </summary>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        void DeleteContents();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ranges/Range.html#detach()"/>
        /// </summary>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        void Detach();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ranges/Range.html#insertNode(org.w3c.dom.Node)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.W3c.Dom.Node"/></param>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        /// <exception cref="Org.W3c.Dom.Ranges.RangeException"/>
        void InsertNode(Org.W3c.Dom.Node arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ranges/Range.html#selectNode(org.w3c.dom.Node)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.W3c.Dom.Node"/></param>
        /// <exception cref="Org.W3c.Dom.Ranges.RangeException"/>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        void SelectNode(Org.W3c.Dom.Node arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ranges/Range.html#selectNodeContents(org.w3c.dom.Node)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.W3c.Dom.Node"/></param>
        /// <exception cref="Org.W3c.Dom.Ranges.RangeException"/>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        void SelectNodeContents(Org.W3c.Dom.Node arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ranges/Range.html#setEnd(org.w3c.dom.Node,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.W3c.Dom.Node"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <exception cref="Org.W3c.Dom.Ranges.RangeException"/>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        void SetEnd(Org.W3c.Dom.Node arg0, int arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ranges/Range.html#setEndAfter(org.w3c.dom.Node)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.W3c.Dom.Node"/></param>
        /// <exception cref="Org.W3c.Dom.Ranges.RangeException"/>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        void SetEndAfter(Org.W3c.Dom.Node arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ranges/Range.html#setEndBefore(org.w3c.dom.Node)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.W3c.Dom.Node"/></param>
        /// <exception cref="Org.W3c.Dom.Ranges.RangeException"/>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        void SetEndBefore(Org.W3c.Dom.Node arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ranges/Range.html#setStart(org.w3c.dom.Node,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.W3c.Dom.Node"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <exception cref="Org.W3c.Dom.Ranges.RangeException"/>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        void SetStart(Org.W3c.Dom.Node arg0, int arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ranges/Range.html#setStartAfter(org.w3c.dom.Node)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.W3c.Dom.Node"/></param>
        /// <exception cref="Org.W3c.Dom.Ranges.RangeException"/>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        void SetStartAfter(Org.W3c.Dom.Node arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ranges/Range.html#setStartBefore(org.w3c.dom.Node)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.W3c.Dom.Node"/></param>
        /// <exception cref="Org.W3c.Dom.Ranges.RangeException"/>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        void SetStartBefore(Org.W3c.Dom.Node arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ranges/Range.html#surroundContents(org.w3c.dom.Node)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.W3c.Dom.Node"/></param>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        /// <exception cref="Org.W3c.Dom.Ranges.RangeException"/>
        void SurroundContents(Org.W3c.Dom.Node arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region Range
    public partial class Range : Org.W3c.Dom.Ranges.IRange
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ranges/Range.html#END_TO_END"/>
        /// </summary>
        public static short END_TO_END { get { if (!_END_TO_ENDReady) { _END_TO_ENDContent = SGetField<short>(LocalBridgeClazz, "END_TO_END"); _END_TO_ENDReady = true; } return _END_TO_ENDContent; } }
        private static short _END_TO_ENDContent = default;
        private static bool _END_TO_ENDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ranges/Range.html#END_TO_START"/>
        /// </summary>
        public static short END_TO_START { get { if (!_END_TO_STARTReady) { _END_TO_STARTContent = SGetField<short>(LocalBridgeClazz, "END_TO_START"); _END_TO_STARTReady = true; } return _END_TO_STARTContent; } }
        private static short _END_TO_STARTContent = default;
        private static bool _END_TO_STARTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ranges/Range.html#START_TO_END"/>
        /// </summary>
        public static short START_TO_END { get { if (!_START_TO_ENDReady) { _START_TO_ENDContent = SGetField<short>(LocalBridgeClazz, "START_TO_END"); _START_TO_ENDReady = true; } return _START_TO_ENDContent; } }
        private static short _START_TO_ENDContent = default;
        private static bool _START_TO_ENDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ranges/Range.html#START_TO_START"/>
        /// </summary>
        public static short START_TO_START { get { if (!_START_TO_STARTReady) { _START_TO_STARTContent = SGetField<short>(LocalBridgeClazz, "START_TO_START"); _START_TO_STARTReady = true; } return _START_TO_STARTContent; } }
        private static short _START_TO_STARTContent = default;
        private static bool _START_TO_STARTReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ranges/Range.html#getCollapsed()"/> 
        /// </summary>
        public bool Collapsed
        {
            get { return IExecuteWithSignature<bool>("getCollapsed", "()Z"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ranges/Range.html#getCommonAncestorContainer()"/> 
        /// </summary>
        public Org.W3c.Dom.Node CommonAncestorContainer
        {
            get { return IExecuteWithSignature<Org.W3c.Dom.Node>("getCommonAncestorContainer", "()Lorg/w3c/dom/Node;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ranges/Range.html#getEndContainer()"/> 
        /// </summary>
        public Org.W3c.Dom.Node EndContainer
        {
            get { return IExecuteWithSignature<Org.W3c.Dom.Node>("getEndContainer", "()Lorg/w3c/dom/Node;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ranges/Range.html#getEndOffset()"/> 
        /// </summary>
        public int EndOffset
        {
            get { return IExecuteWithSignature<int>("getEndOffset", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ranges/Range.html#getStartContainer()"/> 
        /// </summary>
        public Org.W3c.Dom.Node StartContainer
        {
            get { return IExecuteWithSignature<Org.W3c.Dom.Node>("getStartContainer", "()Lorg/w3c/dom/Node;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ranges/Range.html#getStartOffset()"/> 
        /// </summary>
        public int StartOffset
        {
            get { return IExecuteWithSignature<int>("getStartOffset", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ranges/Range.html#cloneContents()"/>
        /// </summary>
        /// <returns><see cref="Org.W3c.Dom.DocumentFragment"/></returns>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        public Org.W3c.Dom.DocumentFragment CloneContents()
        {
            return IExecuteWithSignature<Org.W3c.Dom.DocumentFragment>("cloneContents", "()Lorg/w3c/dom/DocumentFragment;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ranges/Range.html#extractContents()"/>
        /// </summary>
        /// <returns><see cref="Org.W3c.Dom.DocumentFragment"/></returns>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        public Org.W3c.Dom.DocumentFragment ExtractContents()
        {
            return IExecuteWithSignature<Org.W3c.Dom.DocumentFragment>("extractContents", "()Lorg/w3c/dom/DocumentFragment;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ranges/Range.html#cloneRange()"/>
        /// </summary>
        /// <returns><see cref="Org.W3c.Dom.Ranges.Range"/></returns>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        public Org.W3c.Dom.Ranges.Range CloneRange()
        {
            return IExecuteWithSignature<Org.W3c.Dom.Ranges.Range>("cloneRange", "()Lorg/w3c/dom/ranges/Range;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ranges/Range.html#compareBoundaryPoints(short,org.w3c.dom.ranges.Range)"/>
        /// </summary>
        /// <param name="arg0"><see cref="short"/></param>
        /// <param name="arg1"><see cref="Org.W3c.Dom.Ranges.Range"/></param>
        /// <returns><see cref="short"/></returns>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        public short CompareBoundaryPoints(short arg0, Org.W3c.Dom.Ranges.Range arg1)
        {
            return IExecute<short>("compareBoundaryPoints", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ranges/Range.html#collapse(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        public void Collapse(bool arg0)
        {
            IExecuteWithSignature("collapse", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ranges/Range.html#deleteContents()"/>
        /// </summary>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        public void DeleteContents()
        {
            IExecuteWithSignature("deleteContents", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ranges/Range.html#detach()"/>
        /// </summary>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        public void Detach()
        {
            IExecuteWithSignature("detach", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ranges/Range.html#insertNode(org.w3c.dom.Node)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.W3c.Dom.Node"/></param>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        /// <exception cref="Org.W3c.Dom.Ranges.RangeException"/>
        public void InsertNode(Org.W3c.Dom.Node arg0)
        {
            IExecuteWithSignature("insertNode", "(Lorg/w3c/dom/Node;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ranges/Range.html#selectNode(org.w3c.dom.Node)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.W3c.Dom.Node"/></param>
        /// <exception cref="Org.W3c.Dom.Ranges.RangeException"/>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        public void SelectNode(Org.W3c.Dom.Node arg0)
        {
            IExecuteWithSignature("selectNode", "(Lorg/w3c/dom/Node;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ranges/Range.html#selectNodeContents(org.w3c.dom.Node)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.W3c.Dom.Node"/></param>
        /// <exception cref="Org.W3c.Dom.Ranges.RangeException"/>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        public void SelectNodeContents(Org.W3c.Dom.Node arg0)
        {
            IExecuteWithSignature("selectNodeContents", "(Lorg/w3c/dom/Node;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ranges/Range.html#setEnd(org.w3c.dom.Node,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.W3c.Dom.Node"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <exception cref="Org.W3c.Dom.Ranges.RangeException"/>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        public void SetEnd(Org.W3c.Dom.Node arg0, int arg1)
        {
            IExecute("setEnd", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ranges/Range.html#setEndAfter(org.w3c.dom.Node)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.W3c.Dom.Node"/></param>
        /// <exception cref="Org.W3c.Dom.Ranges.RangeException"/>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        public void SetEndAfter(Org.W3c.Dom.Node arg0)
        {
            IExecuteWithSignature("setEndAfter", "(Lorg/w3c/dom/Node;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ranges/Range.html#setEndBefore(org.w3c.dom.Node)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.W3c.Dom.Node"/></param>
        /// <exception cref="Org.W3c.Dom.Ranges.RangeException"/>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        public void SetEndBefore(Org.W3c.Dom.Node arg0)
        {
            IExecuteWithSignature("setEndBefore", "(Lorg/w3c/dom/Node;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ranges/Range.html#setStart(org.w3c.dom.Node,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.W3c.Dom.Node"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <exception cref="Org.W3c.Dom.Ranges.RangeException"/>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        public void SetStart(Org.W3c.Dom.Node arg0, int arg1)
        {
            IExecute("setStart", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ranges/Range.html#setStartAfter(org.w3c.dom.Node)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.W3c.Dom.Node"/></param>
        /// <exception cref="Org.W3c.Dom.Ranges.RangeException"/>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        public void SetStartAfter(Org.W3c.Dom.Node arg0)
        {
            IExecuteWithSignature("setStartAfter", "(Lorg/w3c/dom/Node;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ranges/Range.html#setStartBefore(org.w3c.dom.Node)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.W3c.Dom.Node"/></param>
        /// <exception cref="Org.W3c.Dom.Ranges.RangeException"/>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        public void SetStartBefore(Org.W3c.Dom.Node arg0)
        {
            IExecuteWithSignature("setStartBefore", "(Lorg/w3c/dom/Node;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml/org/w3c/dom/ranges/Range.html#surroundContents(org.w3c.dom.Node)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.W3c.Dom.Node"/></param>
        /// <exception cref="Org.W3c.Dom.DOMException"/>
        /// <exception cref="Org.W3c.Dom.Ranges.RangeException"/>
        public void SurroundContents(Org.W3c.Dom.Node arg0)
        {
            IExecuteWithSignature("surroundContents", "(Lorg/w3c/dom/Node;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}