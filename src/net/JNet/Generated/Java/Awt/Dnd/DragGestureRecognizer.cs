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
*  This file is generated by MASES.JNetReflector (ver. 1.5.4.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Awt.Dnd
{
    #region DragGestureRecognizer
    public partial class DragGestureRecognizer
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Awt.Dnd.DragGestureRecognizer"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Java.Awt.Dnd.DragGestureRecognizer t) => t.Cast<Java.Io.Serializable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DragGestureRecognizer.html#getComponent()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DragGestureRecognizer.html#setComponent(java.awt.Component)"/>
        /// </summary>
        public Java.Awt.Component Component
        {
            get { return IExecute<Java.Awt.Component>("getComponent"); } set { IExecute("setComponent", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DragGestureRecognizer.html#getDragSource()"/> 
        /// </summary>
        public Java.Awt.Dnd.DragSource DragSource
        {
            get { return IExecute<Java.Awt.Dnd.DragSource>("getDragSource"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DragGestureRecognizer.html#getSourceActions()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DragGestureRecognizer.html#setSourceActions(int)"/>
        /// </summary>
        public int SourceActions
        {
            get { return IExecute<int>("getSourceActions"); } set { IExecute("setSourceActions", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DragGestureRecognizer.html#getTriggerEvent()"/> 
        /// </summary>
        public Java.Awt.EventNs.InputEvent TriggerEvent
        {
            get { return IExecute<Java.Awt.EventNs.InputEvent>("getTriggerEvent"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DragGestureRecognizer.html#addDragGestureListener(java.awt.dnd.DragGestureListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Dnd.DragGestureListener"/></param>
        /// <exception cref="Java.Util.TooManyListenersException"/>
        public void AddDragGestureListener(Java.Awt.Dnd.DragGestureListener arg0)
        {
            IExecute("addDragGestureListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DragGestureRecognizer.html#removeDragGestureListener(java.awt.dnd.DragGestureListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Dnd.DragGestureListener"/></param>
        public void RemoveDragGestureListener(Java.Awt.Dnd.DragGestureListener arg0)
        {
            IExecute("removeDragGestureListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DragGestureRecognizer.html#resetRecognizer()"/>
        /// </summary>
        public void ResetRecognizer()
        {
            IExecute("resetRecognizer");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}