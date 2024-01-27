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
*  This file is generated by MASES.JNetReflector (ver. 2.2.4.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Util
{
    #region LinkedList
    public partial class LinkedList
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/LinkedList.html#%3Cinit%3E(java.util.Collection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        public LinkedList(Java.Util.Collection arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Util.LinkedList"/> to <see cref="Java.Util.List"/>
        /// </summary>
        public static implicit operator Java.Util.List(Java.Util.LinkedList t) => t.Cast<Java.Util.List>();
        /// <summary>
        /// Converter from <see cref="Java.Util.LinkedList"/> to <see cref="Java.Util.Deque"/>
        /// </summary>
        public static implicit operator Java.Util.Deque(Java.Util.LinkedList t) => t.Cast<Java.Util.Deque>();
        /// <summary>
        /// Converter from <see cref="Java.Util.LinkedList"/> to <see cref="Java.Lang.Cloneable"/>
        /// </summary>
        public static implicit operator Java.Lang.Cloneable(Java.Util.LinkedList t) => t.Cast<Java.Lang.Cloneable>();
        /// <summary>
        /// Converter from <see cref="Java.Util.LinkedList"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Java.Util.LinkedList t) => t.Cast<Java.Io.Serializable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/LinkedList.html#getFirst()"/> 
        /// </summary>
        public object First
        {
            get { return IExecute("getFirst"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/LinkedList.html#getLast()"/> 
        /// </summary>
        public object Last
        {
            get { return IExecute("getLast"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/LinkedList.html#offer(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Offer(object arg0)
        {
            return IExecute<bool>("offer", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/LinkedList.html#offerFirst(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool OfferFirst(object arg0)
        {
            return IExecute<bool>("offerFirst", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/LinkedList.html#offerLast(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool OfferLast(object arg0)
        {
            return IExecute<bool>("offerLast", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/LinkedList.html#removeFirstOccurrence(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool RemoveFirstOccurrence(object arg0)
        {
            return IExecute<bool>("removeFirstOccurrence", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/LinkedList.html#removeLastOccurrence(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool RemoveLastOccurrence(object arg0)
        {
            return IExecute<bool>("removeLastOccurrence", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/LinkedList.html#element()"/>
        /// </summary>

        /// <returns><see cref="object"/></returns>
        public object Element()
        {
            return IExecute("element");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/LinkedList.html#peek()"/>
        /// </summary>

        /// <returns><see cref="object"/></returns>
        public object Peek()
        {
            return IExecute("peek");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/LinkedList.html#peekFirst()"/>
        /// </summary>

        /// <returns><see cref="object"/></returns>
        public object PeekFirst()
        {
            return IExecute("peekFirst");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/LinkedList.html#peekLast()"/>
        /// </summary>

        /// <returns><see cref="object"/></returns>
        public object PeekLast()
        {
            return IExecute("peekLast");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/LinkedList.html#poll()"/>
        /// </summary>

        /// <returns><see cref="object"/></returns>
        public object Poll()
        {
            return IExecute("poll");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/LinkedList.html#pollFirst()"/>
        /// </summary>

        /// <returns><see cref="object"/></returns>
        public object PollFirst()
        {
            return IExecute("pollFirst");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/LinkedList.html#pollLast()"/>
        /// </summary>

        /// <returns><see cref="object"/></returns>
        public object PollLast()
        {
            return IExecute("pollLast");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/LinkedList.html#pop()"/>
        /// </summary>

        /// <returns><see cref="object"/></returns>
        public object Pop()
        {
            return IExecute("pop");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/LinkedList.html#remove()"/>
        /// </summary>

        /// <returns><see cref="object"/></returns>
        public object Remove()
        {
            return IExecute("remove");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/LinkedList.html#removeFirst()"/>
        /// </summary>

        /// <returns><see cref="object"/></returns>
        public object RemoveFirst()
        {
            return IExecute("removeFirst");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/LinkedList.html#removeLast()"/>
        /// </summary>

        /// <returns><see cref="object"/></returns>
        public object RemoveLast()
        {
            return IExecute("removeLast");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/LinkedList.html#descendingIterator()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Iterator"/></returns>
        public Java.Util.Iterator DescendingIteratorMethod()
        {
            return IExecute<Java.Util.Iterator>("descendingIterator");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/LinkedList.html#addFirst(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        public void AddFirst(object arg0)
        {
            IExecute("addFirst", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/LinkedList.html#addLast(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        public void AddLast(object arg0)
        {
            IExecute("addLast", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/LinkedList.html#push(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        public void Push(object arg0)
        {
            IExecute("push", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region LinkedList<E>
    public partial class LinkedList<E>
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/LinkedList.html#%3Cinit%3E(java.util.Collection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        public LinkedList(Java.Util.Collection<E> arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Util.LinkedList{E}"/> to <see cref="Java.Util.List{E}"/>
        /// </summary>
        public static implicit operator Java.Util.List<E>(Java.Util.LinkedList<E> t) => t.Cast<Java.Util.List<E>>();
        /// <summary>
        /// Converter from <see cref="Java.Util.LinkedList{E}"/> to <see cref="Java.Util.Deque{E}"/>
        /// </summary>
        public static implicit operator Java.Util.Deque<E>(Java.Util.LinkedList<E> t) => t.Cast<Java.Util.Deque<E>>();
        /// <summary>
        /// Converter from <see cref="Java.Util.LinkedList{E}"/> to <see cref="Java.Lang.Cloneable"/>
        /// </summary>
        public static implicit operator Java.Lang.Cloneable(Java.Util.LinkedList<E> t) => t.Cast<Java.Lang.Cloneable>();
        /// <summary>
        /// Converter from <see cref="Java.Util.LinkedList{E}"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Java.Util.LinkedList<E> t) => t.Cast<Java.Io.Serializable>();
        /// <summary>
        /// Converter from <see cref="Java.Util.LinkedList{E}"/> to <see cref="Java.Util.LinkedList"/>
        /// </summary>
        public static implicit operator Java.Util.LinkedList(Java.Util.LinkedList<E> t) => t.Cast<Java.Util.LinkedList>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/LinkedList.html#getFirst()"/> 
        /// </summary>
        public E First
        {
            get { return IExecute<E>("getFirst"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/LinkedList.html#getLast()"/> 
        /// </summary>
        public E Last
        {
            get { return IExecute<E>("getLast"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/LinkedList.html#offer(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="E"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Offer(E arg0)
        {
            return IExecute<bool>("offer", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/LinkedList.html#offerFirst(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="E"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool OfferFirst(E arg0)
        {
            return IExecute<bool>("offerFirst", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/LinkedList.html#offerLast(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="E"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool OfferLast(E arg0)
        {
            return IExecute<bool>("offerLast", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/LinkedList.html#removeFirstOccurrence(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool RemoveFirstOccurrence(object arg0)
        {
            return IExecute<bool>("removeFirstOccurrence", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/LinkedList.html#removeLastOccurrence(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool RemoveLastOccurrence(object arg0)
        {
            return IExecute<bool>("removeLastOccurrence", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/LinkedList.html#element()"/>
        /// </summary>

        /// <returns><typeparamref name="E"/></returns>
        public E Element()
        {
            return IExecute<E>("element");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/LinkedList.html#peek()"/>
        /// </summary>

        /// <returns><typeparamref name="E"/></returns>
        public E Peek()
        {
            return IExecute<E>("peek");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/LinkedList.html#peekFirst()"/>
        /// </summary>

        /// <returns><typeparamref name="E"/></returns>
        public E PeekFirst()
        {
            return IExecute<E>("peekFirst");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/LinkedList.html#peekLast()"/>
        /// </summary>

        /// <returns><typeparamref name="E"/></returns>
        public E PeekLast()
        {
            return IExecute<E>("peekLast");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/LinkedList.html#poll()"/>
        /// </summary>

        /// <returns><typeparamref name="E"/></returns>
        public E Poll()
        {
            return IExecute<E>("poll");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/LinkedList.html#pollFirst()"/>
        /// </summary>

        /// <returns><typeparamref name="E"/></returns>
        public E PollFirst()
        {
            return IExecute<E>("pollFirst");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/LinkedList.html#pollLast()"/>
        /// </summary>

        /// <returns><typeparamref name="E"/></returns>
        public E PollLast()
        {
            return IExecute<E>("pollLast");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/LinkedList.html#pop()"/>
        /// </summary>

        /// <returns><typeparamref name="E"/></returns>
        public E Pop()
        {
            return IExecute<E>("pop");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/LinkedList.html#remove()"/>
        /// </summary>

        /// <returns><typeparamref name="E"/></returns>
        public E Remove()
        {
            return IExecute<E>("remove");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/LinkedList.html#removeFirst()"/>
        /// </summary>

        /// <returns><typeparamref name="E"/></returns>
        public E RemoveFirst()
        {
            return IExecute<E>("removeFirst");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/LinkedList.html#removeLast()"/>
        /// </summary>

        /// <returns><typeparamref name="E"/></returns>
        public E RemoveLast()
        {
            return IExecute<E>("removeLast");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/LinkedList.html#descendingIterator()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Iterator"/></returns>
        public Java.Util.Iterator<E> DescendingIteratorMethod()
        {
            return IExecute<Java.Util.Iterator<E>>("descendingIterator");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/LinkedList.html#addFirst(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="E"/></param>
        public void AddFirst(E arg0)
        {
            IExecute("addFirst", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/LinkedList.html#addLast(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="E"/></param>
        public void AddLast(E arg0)
        {
            IExecute("addLast", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/LinkedList.html#push(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="E"/></param>
        public void Push(E arg0)
        {
            IExecute("push", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}