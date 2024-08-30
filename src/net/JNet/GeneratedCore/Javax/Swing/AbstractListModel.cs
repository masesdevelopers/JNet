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
    #region AbstractListModel
    public partial class AbstractListModel
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Swing.AbstractListModel"/> to <see cref="Javax.Swing.ListModel"/>
        /// </summary>
        public static implicit operator Javax.Swing.ListModel(Javax.Swing.AbstractListModel t) => t.Cast<Javax.Swing.ListModel>();
        /// <summary>
        /// Converter from <see cref="Javax.Swing.AbstractListModel"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Javax.Swing.AbstractListModel t) => t.Cast<Java.Io.Serializable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractListModel.html#getListDataListeners()"/> 
        /// </summary>
        public Javax.Swing.Event.ListDataListener[] ListDataListeners
        {
            get { return IExecuteWithSignatureArray<Javax.Swing.Event.ListDataListener>("getListDataListeners", "()[Ljavax/swing/event/ListDataListener;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractListModel.html#getListeners(java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <returns><see cref="Java.Util.EventListener"/></returns>
        public Java.Util.EventListener[] GetListeners(Java.Lang.Class arg0)
        {
            return IExecuteArray<Java.Util.EventListener>("getListeners", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractListModel.html#addListDataListener(javax.swing.event.ListDataListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.ListDataListener"/></param>
        public void AddListDataListener(Javax.Swing.Event.ListDataListener arg0)
        {
            IExecuteWithSignature("addListDataListener", "(Ljavax/swing/event/ListDataListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractListModel.html#removeListDataListener(javax.swing.event.ListDataListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.ListDataListener"/></param>
        public void RemoveListDataListener(Javax.Swing.Event.ListDataListener arg0)
        {
            IExecuteWithSignature("removeListDataListener", "(Ljavax/swing/event/ListDataListener;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region AbstractListModel<E>
    public partial class AbstractListModel<E>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Swing.AbstractListModel{E}"/> to <see cref="Javax.Swing.ListModel{E}"/>
        /// </summary>
        public static implicit operator Javax.Swing.ListModel<E>(Javax.Swing.AbstractListModel<E> t) => t.Cast<Javax.Swing.ListModel<E>>();
        /// <summary>
        /// Converter from <see cref="Javax.Swing.AbstractListModel{E}"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Javax.Swing.AbstractListModel<E> t) => t.Cast<Java.Io.Serializable>();
        /// <summary>
        /// Converter from <see cref="Javax.Swing.AbstractListModel{E}"/> to <see cref="Javax.Swing.AbstractListModel"/>
        /// </summary>
        public static implicit operator Javax.Swing.AbstractListModel(Javax.Swing.AbstractListModel<E> t) => t.Cast<Javax.Swing.AbstractListModel>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractListModel.html#getListDataListeners()"/> 
        /// </summary>
        public Javax.Swing.Event.ListDataListener[] ListDataListeners
        {
            get { return IExecuteWithSignatureArray<Javax.Swing.Event.ListDataListener>("getListDataListeners", "()[Ljavax/swing/event/ListDataListener;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractListModel.html#getListeners(java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <typeparam name="T"><see cref="Java.Util.IEventListener"/></typeparam>
        /// <returns><typeparamref name="T"/></returns>
        public T[] GetListeners<T>(Java.Lang.Class arg0) where T : Java.Util.IEventListener, new()
        {
            return IExecuteArray<T>("getListeners", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractListModel.html#addListDataListener(javax.swing.event.ListDataListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.ListDataListener"/></param>
        public void AddListDataListener(Javax.Swing.Event.ListDataListener arg0)
        {
            IExecuteWithSignature("addListDataListener", "(Ljavax/swing/event/ListDataListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractListModel.html#removeListDataListener(javax.swing.event.ListDataListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.ListDataListener"/></param>
        public void RemoveListDataListener(Javax.Swing.Event.ListDataListener arg0)
        {
            IExecuteWithSignature("removeListDataListener", "(Ljavax/swing/event/ListDataListener;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}