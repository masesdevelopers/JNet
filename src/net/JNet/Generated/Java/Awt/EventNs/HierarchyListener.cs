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

namespace Java.Awt.EventNs
{
    #region IHierarchyListener
    /// <summary>
    /// .NET interface for org.mases.jnet.generated.java.awt.event.HierarchyListener implementing <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/HierarchyListener.html"/>
    /// </summary>
    public partial interface IHierarchyListener
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/HierarchyListener.html#hierarchyChanged(java.awt.event.HierarchyEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.HierarchyEvent"/></param>
        void HierarchyChanged(Java.Awt.EventNs.HierarchyEvent arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region HierarchyListener
    public partial class HierarchyListener : Java.Awt.EventNs.IHierarchyListener
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
        /// Handlers initializer for <see cref="HierarchyListener"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("hierarchyChanged", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.HierarchyEvent>>>(HierarchyChangedEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/HierarchyListener.html#hierarchyChanged(java.awt.event.HierarchyEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnHierarchyChanged"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Java.Awt.EventNs.HierarchyEvent> OnHierarchyChanged { get; set; } = null;

        void HierarchyChangedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.HierarchyEvent>> data)
        {
            var methodToExecute = (OnHierarchyChanged != null) ? OnHierarchyChanged : HierarchyChanged;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/HierarchyListener.html#hierarchyChanged(java.awt.event.HierarchyEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.HierarchyEvent"/></param>
        public virtual void HierarchyChanged(Java.Awt.EventNs.HierarchyEvent arg0)
        {
            
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region HierarchyListenerDirect
    public partial class HierarchyListenerDirect : Java.Awt.EventNs.IHierarchyListener
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/HierarchyListener.html#hierarchyChanged(java.awt.event.HierarchyEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.HierarchyEvent"/></param>
        public override void HierarchyChanged(Java.Awt.EventNs.HierarchyEvent arg0)
        {
            IExecuteWithSignature("hierarchyChanged", "(Ljava/awt/event/HierarchyEvent;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}