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

namespace Java.Util.Prefs
{
    #region PreferenceChangeListener declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.prefs/java/util/prefs/PreferenceChangeListener.html"/>
    /// </summary>
    public partial class PreferenceChangeListener : Java.Util.EventListener
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public PreferenceChangeListener() { InitializeHandlers(); }

        const string _bridgeClassName = "org.mases.jnet.generated.java.util.prefs.PreferenceChangeListener";
        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");
        
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;

    
        // TODO: complete the class

    }
    #endregion

    #region PreferenceChangeListenerDirect declaration
    /// <summary>
    /// Direct override of <see cref="PreferenceChangeListener"/> or its generic type if there is one
    /// </summary>
    public partial class PreferenceChangeListenerDirect : PreferenceChangeListener
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_AutoInit.htm"/>
        /// </summary>
        public override bool AutoInit => false;

        /// <inheritdoc />
        protected override void InitializeHandlers() { }

        const string _bridgeClassName = "java.util.prefs.PreferenceChangeListener";
        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
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
    }
    #endregion

    #region IPreferenceChangeListener
    /// <summary>
    /// .NET interface for org.mases.jnet.generated.java.util.prefs.PreferenceChangeListener implementing <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.prefs/java/util/prefs/PreferenceChangeListener.html"/>
    /// </summary>
    public partial interface IPreferenceChangeListener
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.prefs/java/util/prefs/PreferenceChangeListener.html#preferenceChange(java.util.prefs.PreferenceChangeEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Prefs.PreferenceChangeEvent"/></param>
        void PreferenceChange(Java.Util.Prefs.PreferenceChangeEvent arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region PreferenceChangeListener implementation
    public partial class PreferenceChangeListener : Java.Util.Prefs.IPreferenceChangeListener
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
        /// Handlers initializer for <see cref="PreferenceChangeListener"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("preferenceChange", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Util.Prefs.PreferenceChangeEvent>>>(PreferenceChangeEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.prefs/java/util/prefs/PreferenceChangeListener.html#preferenceChange(java.util.prefs.PreferenceChangeEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnPreferenceChange"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<Java.Util.Prefs.PreferenceChangeEvent> OnPreferenceChange { get; set; } = null;

        void PreferenceChangeEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Util.Prefs.PreferenceChangeEvent>> data)
        {
            var methodToExecute = (OnPreferenceChange != null) ? OnPreferenceChange : PreferenceChange;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.prefs/java/util/prefs/PreferenceChangeListener.html#preferenceChange(java.util.prefs.PreferenceChangeEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Prefs.PreferenceChangeEvent"/></param>
        public virtual void PreferenceChange(Java.Util.Prefs.PreferenceChangeEvent arg0)
        {
            
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region PreferenceChangeListenerDirect implementation
    public partial class PreferenceChangeListenerDirect : Java.Util.Prefs.IPreferenceChangeListener
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.prefs/java/util/prefs/PreferenceChangeListener.html#preferenceChange(java.util.prefs.PreferenceChangeEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Prefs.PreferenceChangeEvent"/></param>
        public override void PreferenceChange(Java.Util.Prefs.PreferenceChangeEvent arg0)
        {
            IExecuteWithSignature("preferenceChange", "(Ljava/util/prefs/PreferenceChangeEvent;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}