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

namespace Java.Beans
{
    #region PropertyEditorSupport definition
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/PropertyEditorSupport.html"/>
    /// </summary>
    public partial class PropertyEditorSupport : Java.Beans.PropertyEditor
    {
        const string _bridgeClassName = "java.beans.PropertyEditorSupport";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public PropertyEditorSupport() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public PropertyEditorSupport(params object[] args) : base(args) { }

        private static readonly IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new InvalidOperationException($"Class {_bridgeClassName} was not found.");

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

    }
    #endregion

    #region PropertyEditorSupport
    public partial class PropertyEditorSupport
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/PropertyEditorSupport.html#%3Cinit%3E(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        public PropertyEditorSupport(object arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/PropertyEditorSupport.html#getAsText()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/PropertyEditorSupport.html#setAsText(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String AsText
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getAsText", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setAsText", "(Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/PropertyEditorSupport.html#getCustomEditor()"/> 
        /// </summary>
        public Java.Awt.Component CustomEditor
        {
            get { return IExecuteWithSignature<Java.Awt.Component>("getCustomEditor", "()Ljava/awt/Component;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/PropertyEditorSupport.html#getJavaInitializationString()"/> 
        /// </summary>
        public Java.Lang.String JavaInitializationString
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getJavaInitializationString", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/PropertyEditorSupport.html#getSource()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/PropertyEditorSupport.html#setSource(java.lang.Object)"/>
        /// </summary>
        public object Source
        {
            get { return IExecuteWithSignature("getSource", "()Ljava/lang/Object;"); } set { IExecuteWithSignature("setSource", "(Ljava/lang/Object;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/PropertyEditorSupport.html#getTags()"/> 
        /// </summary>
        public Java.Lang.String[] Tags
        {
            get { return IExecuteWithSignatureArray<Java.Lang.String>("getTags", "()[Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/PropertyEditorSupport.html#getValue()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/PropertyEditorSupport.html#setValue(java.lang.Object)"/>
        /// </summary>
        public object Value
        {
            get { return IExecuteWithSignature("getValue", "()Ljava/lang/Object;"); } set { IExecuteWithSignature("setValue", "(Ljava/lang/Object;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/PropertyEditorSupport.html#isPaintable()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsPaintable()
        {
            return IExecuteWithSignature<bool>("isPaintable", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/PropertyEditorSupport.html#supportsCustomEditor()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool SupportsCustomEditor()
        {
            return IExecuteWithSignature<bool>("supportsCustomEditor", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/PropertyEditorSupport.html#addPropertyChangeListener(java.beans.PropertyChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Beans.PropertyChangeListener"/></param>
        public void AddPropertyChangeListener(Java.Beans.PropertyChangeListener arg0)
        {
            IExecuteWithSignature("addPropertyChangeListener", "(Ljava/beans/PropertyChangeListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/PropertyEditorSupport.html#removePropertyChangeListener(java.beans.PropertyChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Beans.PropertyChangeListener"/></param>
        public void RemovePropertyChangeListener(Java.Beans.PropertyChangeListener arg0)
        {
            IExecuteWithSignature("removePropertyChangeListener", "(Ljava/beans/PropertyChangeListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/PropertyEditorSupport.html#firePropertyChange()"/>
        /// </summary>
        public void FirePropertyChange()
        {
            IExecuteWithSignature("firePropertyChange", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/PropertyEditorSupport.html#paintValue(java.awt.Graphics,java.awt.Rectangle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Graphics"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Rectangle"/></param>
        public void PaintValue(Java.Awt.Graphics arg0, Java.Awt.Rectangle arg1)
        {
            IExecute("paintValue", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}