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
*  This file is generated by MASES.JNetReflector (ver. 2.5.11.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Accessibility
{
    #region AccessibleContext declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleContext.html"/>
    /// </summary>
    public partial class AccessibleContext : MASES.JCOBridge.C2JBridge.JVMBridgeBase<AccessibleContext>
    {
        const string _bridgeClassName = "javax.accessibility.AccessibleContext";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("AccessibleContext class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public AccessibleContext() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("AccessibleContext class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public AccessibleContext(params object[] args) : base(args) { }

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

    #region AccessibleContext implementation
    public partial class AccessibleContext
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleContext.html#ACCESSIBLE_ACTION_PROPERTY"/>
        /// </summary>
        public static Java.Lang.String ACCESSIBLE_ACTION_PROPERTY { get { if (!_ACCESSIBLE_ACTION_PROPERTYReady) { _ACCESSIBLE_ACTION_PROPERTYContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ACCESSIBLE_ACTION_PROPERTY"); _ACCESSIBLE_ACTION_PROPERTYReady = true; } return _ACCESSIBLE_ACTION_PROPERTYContent; } }
        private static Java.Lang.String _ACCESSIBLE_ACTION_PROPERTYContent = default;
        private static bool _ACCESSIBLE_ACTION_PROPERTYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleContext.html#ACCESSIBLE_ACTIVE_DESCENDANT_PROPERTY"/>
        /// </summary>
        public static Java.Lang.String ACCESSIBLE_ACTIVE_DESCENDANT_PROPERTY { get { if (!_ACCESSIBLE_ACTIVE_DESCENDANT_PROPERTYReady) { _ACCESSIBLE_ACTIVE_DESCENDANT_PROPERTYContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ACCESSIBLE_ACTIVE_DESCENDANT_PROPERTY"); _ACCESSIBLE_ACTIVE_DESCENDANT_PROPERTYReady = true; } return _ACCESSIBLE_ACTIVE_DESCENDANT_PROPERTYContent; } }
        private static Java.Lang.String _ACCESSIBLE_ACTIVE_DESCENDANT_PROPERTYContent = default;
        private static bool _ACCESSIBLE_ACTIVE_DESCENDANT_PROPERTYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleContext.html#ACCESSIBLE_CARET_PROPERTY"/>
        /// </summary>
        public static Java.Lang.String ACCESSIBLE_CARET_PROPERTY { get { if (!_ACCESSIBLE_CARET_PROPERTYReady) { _ACCESSIBLE_CARET_PROPERTYContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ACCESSIBLE_CARET_PROPERTY"); _ACCESSIBLE_CARET_PROPERTYReady = true; } return _ACCESSIBLE_CARET_PROPERTYContent; } }
        private static Java.Lang.String _ACCESSIBLE_CARET_PROPERTYContent = default;
        private static bool _ACCESSIBLE_CARET_PROPERTYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleContext.html#ACCESSIBLE_CHILD_PROPERTY"/>
        /// </summary>
        public static Java.Lang.String ACCESSIBLE_CHILD_PROPERTY { get { if (!_ACCESSIBLE_CHILD_PROPERTYReady) { _ACCESSIBLE_CHILD_PROPERTYContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ACCESSIBLE_CHILD_PROPERTY"); _ACCESSIBLE_CHILD_PROPERTYReady = true; } return _ACCESSIBLE_CHILD_PROPERTYContent; } }
        private static Java.Lang.String _ACCESSIBLE_CHILD_PROPERTYContent = default;
        private static bool _ACCESSIBLE_CHILD_PROPERTYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleContext.html#ACCESSIBLE_COMPONENT_BOUNDS_CHANGED"/>
        /// </summary>
        public static Java.Lang.String ACCESSIBLE_COMPONENT_BOUNDS_CHANGED { get { if (!_ACCESSIBLE_COMPONENT_BOUNDS_CHANGEDReady) { _ACCESSIBLE_COMPONENT_BOUNDS_CHANGEDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ACCESSIBLE_COMPONENT_BOUNDS_CHANGED"); _ACCESSIBLE_COMPONENT_BOUNDS_CHANGEDReady = true; } return _ACCESSIBLE_COMPONENT_BOUNDS_CHANGEDContent; } }
        private static Java.Lang.String _ACCESSIBLE_COMPONENT_BOUNDS_CHANGEDContent = default;
        private static bool _ACCESSIBLE_COMPONENT_BOUNDS_CHANGEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleContext.html#ACCESSIBLE_DESCRIPTION_PROPERTY"/>
        /// </summary>
        public static Java.Lang.String ACCESSIBLE_DESCRIPTION_PROPERTY { get { if (!_ACCESSIBLE_DESCRIPTION_PROPERTYReady) { _ACCESSIBLE_DESCRIPTION_PROPERTYContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ACCESSIBLE_DESCRIPTION_PROPERTY"); _ACCESSIBLE_DESCRIPTION_PROPERTYReady = true; } return _ACCESSIBLE_DESCRIPTION_PROPERTYContent; } }
        private static Java.Lang.String _ACCESSIBLE_DESCRIPTION_PROPERTYContent = default;
        private static bool _ACCESSIBLE_DESCRIPTION_PROPERTYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleContext.html#ACCESSIBLE_HYPERTEXT_OFFSET"/>
        /// </summary>
        public static Java.Lang.String ACCESSIBLE_HYPERTEXT_OFFSET { get { if (!_ACCESSIBLE_HYPERTEXT_OFFSETReady) { _ACCESSIBLE_HYPERTEXT_OFFSETContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ACCESSIBLE_HYPERTEXT_OFFSET"); _ACCESSIBLE_HYPERTEXT_OFFSETReady = true; } return _ACCESSIBLE_HYPERTEXT_OFFSETContent; } }
        private static Java.Lang.String _ACCESSIBLE_HYPERTEXT_OFFSETContent = default;
        private static bool _ACCESSIBLE_HYPERTEXT_OFFSETReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleContext.html#ACCESSIBLE_INVALIDATE_CHILDREN"/>
        /// </summary>
        public static Java.Lang.String ACCESSIBLE_INVALIDATE_CHILDREN { get { if (!_ACCESSIBLE_INVALIDATE_CHILDRENReady) { _ACCESSIBLE_INVALIDATE_CHILDRENContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ACCESSIBLE_INVALIDATE_CHILDREN"); _ACCESSIBLE_INVALIDATE_CHILDRENReady = true; } return _ACCESSIBLE_INVALIDATE_CHILDRENContent; } }
        private static Java.Lang.String _ACCESSIBLE_INVALIDATE_CHILDRENContent = default;
        private static bool _ACCESSIBLE_INVALIDATE_CHILDRENReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleContext.html#ACCESSIBLE_NAME_PROPERTY"/>
        /// </summary>
        public static Java.Lang.String ACCESSIBLE_NAME_PROPERTY { get { if (!_ACCESSIBLE_NAME_PROPERTYReady) { _ACCESSIBLE_NAME_PROPERTYContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ACCESSIBLE_NAME_PROPERTY"); _ACCESSIBLE_NAME_PROPERTYReady = true; } return _ACCESSIBLE_NAME_PROPERTYContent; } }
        private static Java.Lang.String _ACCESSIBLE_NAME_PROPERTYContent = default;
        private static bool _ACCESSIBLE_NAME_PROPERTYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleContext.html#ACCESSIBLE_SELECTION_PROPERTY"/>
        /// </summary>
        public static Java.Lang.String ACCESSIBLE_SELECTION_PROPERTY { get { if (!_ACCESSIBLE_SELECTION_PROPERTYReady) { _ACCESSIBLE_SELECTION_PROPERTYContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ACCESSIBLE_SELECTION_PROPERTY"); _ACCESSIBLE_SELECTION_PROPERTYReady = true; } return _ACCESSIBLE_SELECTION_PROPERTYContent; } }
        private static Java.Lang.String _ACCESSIBLE_SELECTION_PROPERTYContent = default;
        private static bool _ACCESSIBLE_SELECTION_PROPERTYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleContext.html#ACCESSIBLE_STATE_PROPERTY"/>
        /// </summary>
        public static Java.Lang.String ACCESSIBLE_STATE_PROPERTY { get { if (!_ACCESSIBLE_STATE_PROPERTYReady) { _ACCESSIBLE_STATE_PROPERTYContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ACCESSIBLE_STATE_PROPERTY"); _ACCESSIBLE_STATE_PROPERTYReady = true; } return _ACCESSIBLE_STATE_PROPERTYContent; } }
        private static Java.Lang.String _ACCESSIBLE_STATE_PROPERTYContent = default;
        private static bool _ACCESSIBLE_STATE_PROPERTYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleContext.html#ACCESSIBLE_TABLE_CAPTION_CHANGED"/>
        /// </summary>
        public static Java.Lang.String ACCESSIBLE_TABLE_CAPTION_CHANGED { get { if (!_ACCESSIBLE_TABLE_CAPTION_CHANGEDReady) { _ACCESSIBLE_TABLE_CAPTION_CHANGEDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ACCESSIBLE_TABLE_CAPTION_CHANGED"); _ACCESSIBLE_TABLE_CAPTION_CHANGEDReady = true; } return _ACCESSIBLE_TABLE_CAPTION_CHANGEDContent; } }
        private static Java.Lang.String _ACCESSIBLE_TABLE_CAPTION_CHANGEDContent = default;
        private static bool _ACCESSIBLE_TABLE_CAPTION_CHANGEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleContext.html#ACCESSIBLE_TABLE_COLUMN_DESCRIPTION_CHANGED"/>
        /// </summary>
        public static Java.Lang.String ACCESSIBLE_TABLE_COLUMN_DESCRIPTION_CHANGED { get { if (!_ACCESSIBLE_TABLE_COLUMN_DESCRIPTION_CHANGEDReady) { _ACCESSIBLE_TABLE_COLUMN_DESCRIPTION_CHANGEDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ACCESSIBLE_TABLE_COLUMN_DESCRIPTION_CHANGED"); _ACCESSIBLE_TABLE_COLUMN_DESCRIPTION_CHANGEDReady = true; } return _ACCESSIBLE_TABLE_COLUMN_DESCRIPTION_CHANGEDContent; } }
        private static Java.Lang.String _ACCESSIBLE_TABLE_COLUMN_DESCRIPTION_CHANGEDContent = default;
        private static bool _ACCESSIBLE_TABLE_COLUMN_DESCRIPTION_CHANGEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleContext.html#ACCESSIBLE_TABLE_COLUMN_HEADER_CHANGED"/>
        /// </summary>
        public static Java.Lang.String ACCESSIBLE_TABLE_COLUMN_HEADER_CHANGED { get { if (!_ACCESSIBLE_TABLE_COLUMN_HEADER_CHANGEDReady) { _ACCESSIBLE_TABLE_COLUMN_HEADER_CHANGEDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ACCESSIBLE_TABLE_COLUMN_HEADER_CHANGED"); _ACCESSIBLE_TABLE_COLUMN_HEADER_CHANGEDReady = true; } return _ACCESSIBLE_TABLE_COLUMN_HEADER_CHANGEDContent; } }
        private static Java.Lang.String _ACCESSIBLE_TABLE_COLUMN_HEADER_CHANGEDContent = default;
        private static bool _ACCESSIBLE_TABLE_COLUMN_HEADER_CHANGEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleContext.html#ACCESSIBLE_TABLE_MODEL_CHANGED"/>
        /// </summary>
        public static Java.Lang.String ACCESSIBLE_TABLE_MODEL_CHANGED { get { if (!_ACCESSIBLE_TABLE_MODEL_CHANGEDReady) { _ACCESSIBLE_TABLE_MODEL_CHANGEDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ACCESSIBLE_TABLE_MODEL_CHANGED"); _ACCESSIBLE_TABLE_MODEL_CHANGEDReady = true; } return _ACCESSIBLE_TABLE_MODEL_CHANGEDContent; } }
        private static Java.Lang.String _ACCESSIBLE_TABLE_MODEL_CHANGEDContent = default;
        private static bool _ACCESSIBLE_TABLE_MODEL_CHANGEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleContext.html#ACCESSIBLE_TABLE_ROW_DESCRIPTION_CHANGED"/>
        /// </summary>
        public static Java.Lang.String ACCESSIBLE_TABLE_ROW_DESCRIPTION_CHANGED { get { if (!_ACCESSIBLE_TABLE_ROW_DESCRIPTION_CHANGEDReady) { _ACCESSIBLE_TABLE_ROW_DESCRIPTION_CHANGEDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ACCESSIBLE_TABLE_ROW_DESCRIPTION_CHANGED"); _ACCESSIBLE_TABLE_ROW_DESCRIPTION_CHANGEDReady = true; } return _ACCESSIBLE_TABLE_ROW_DESCRIPTION_CHANGEDContent; } }
        private static Java.Lang.String _ACCESSIBLE_TABLE_ROW_DESCRIPTION_CHANGEDContent = default;
        private static bool _ACCESSIBLE_TABLE_ROW_DESCRIPTION_CHANGEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleContext.html#ACCESSIBLE_TABLE_ROW_HEADER_CHANGED"/>
        /// </summary>
        public static Java.Lang.String ACCESSIBLE_TABLE_ROW_HEADER_CHANGED { get { if (!_ACCESSIBLE_TABLE_ROW_HEADER_CHANGEDReady) { _ACCESSIBLE_TABLE_ROW_HEADER_CHANGEDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ACCESSIBLE_TABLE_ROW_HEADER_CHANGED"); _ACCESSIBLE_TABLE_ROW_HEADER_CHANGEDReady = true; } return _ACCESSIBLE_TABLE_ROW_HEADER_CHANGEDContent; } }
        private static Java.Lang.String _ACCESSIBLE_TABLE_ROW_HEADER_CHANGEDContent = default;
        private static bool _ACCESSIBLE_TABLE_ROW_HEADER_CHANGEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleContext.html#ACCESSIBLE_TABLE_SUMMARY_CHANGED"/>
        /// </summary>
        public static Java.Lang.String ACCESSIBLE_TABLE_SUMMARY_CHANGED { get { if (!_ACCESSIBLE_TABLE_SUMMARY_CHANGEDReady) { _ACCESSIBLE_TABLE_SUMMARY_CHANGEDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ACCESSIBLE_TABLE_SUMMARY_CHANGED"); _ACCESSIBLE_TABLE_SUMMARY_CHANGEDReady = true; } return _ACCESSIBLE_TABLE_SUMMARY_CHANGEDContent; } }
        private static Java.Lang.String _ACCESSIBLE_TABLE_SUMMARY_CHANGEDContent = default;
        private static bool _ACCESSIBLE_TABLE_SUMMARY_CHANGEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleContext.html#ACCESSIBLE_TEXT_ATTRIBUTES_CHANGED"/>
        /// </summary>
        public static Java.Lang.String ACCESSIBLE_TEXT_ATTRIBUTES_CHANGED { get { if (!_ACCESSIBLE_TEXT_ATTRIBUTES_CHANGEDReady) { _ACCESSIBLE_TEXT_ATTRIBUTES_CHANGEDContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ACCESSIBLE_TEXT_ATTRIBUTES_CHANGED"); _ACCESSIBLE_TEXT_ATTRIBUTES_CHANGEDReady = true; } return _ACCESSIBLE_TEXT_ATTRIBUTES_CHANGEDContent; } }
        private static Java.Lang.String _ACCESSIBLE_TEXT_ATTRIBUTES_CHANGEDContent = default;
        private static bool _ACCESSIBLE_TEXT_ATTRIBUTES_CHANGEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleContext.html#ACCESSIBLE_TEXT_PROPERTY"/>
        /// </summary>
        public static Java.Lang.String ACCESSIBLE_TEXT_PROPERTY { get { if (!_ACCESSIBLE_TEXT_PROPERTYReady) { _ACCESSIBLE_TEXT_PROPERTYContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ACCESSIBLE_TEXT_PROPERTY"); _ACCESSIBLE_TEXT_PROPERTYReady = true; } return _ACCESSIBLE_TEXT_PROPERTYContent; } }
        private static Java.Lang.String _ACCESSIBLE_TEXT_PROPERTYContent = default;
        private static bool _ACCESSIBLE_TEXT_PROPERTYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleContext.html#ACCESSIBLE_VALUE_PROPERTY"/>
        /// </summary>
        public static Java.Lang.String ACCESSIBLE_VALUE_PROPERTY { get { if (!_ACCESSIBLE_VALUE_PROPERTYReady) { _ACCESSIBLE_VALUE_PROPERTYContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ACCESSIBLE_VALUE_PROPERTY"); _ACCESSIBLE_VALUE_PROPERTYReady = true; } return _ACCESSIBLE_VALUE_PROPERTYContent; } }
        private static Java.Lang.String _ACCESSIBLE_VALUE_PROPERTYContent = default;
        private static bool _ACCESSIBLE_VALUE_PROPERTYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleContext.html#ACCESSIBLE_VISIBLE_DATA_PROPERTY"/>
        /// </summary>
        public static Java.Lang.String ACCESSIBLE_VISIBLE_DATA_PROPERTY { get { if (!_ACCESSIBLE_VISIBLE_DATA_PROPERTYReady) { _ACCESSIBLE_VISIBLE_DATA_PROPERTYContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "ACCESSIBLE_VISIBLE_DATA_PROPERTY"); _ACCESSIBLE_VISIBLE_DATA_PROPERTYReady = true; } return _ACCESSIBLE_VISIBLE_DATA_PROPERTYContent; } }
        private static Java.Lang.String _ACCESSIBLE_VISIBLE_DATA_PROPERTYContent = default;
        private static bool _ACCESSIBLE_VISIBLE_DATA_PROPERTYReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleContext.html#getAccessibleAction()"/> 
        /// </summary>
        public Javax.Accessibility.AccessibleAction AccessibleAction
        {
            get { return IExecuteWithSignature<Javax.Accessibility.AccessibleAction>("getAccessibleAction", "()Ljavax/accessibility/AccessibleAction;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleContext.html#getAccessibleChildrenCount()"/> 
        /// </summary>
        public int AccessibleChildrenCount
        {
            get { return IExecuteWithSignature<int>("getAccessibleChildrenCount", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleContext.html#getAccessibleComponent()"/> 
        /// </summary>
        public Javax.Accessibility.AccessibleComponent AccessibleComponent
        {
            get { return IExecuteWithSignature<Javax.Accessibility.AccessibleComponent>("getAccessibleComponent", "()Ljavax/accessibility/AccessibleComponent;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleContext.html#getAccessibleDescription()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleContext.html#setAccessibleDescription(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String AccessibleDescription
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getAccessibleDescription", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setAccessibleDescription", "(Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleContext.html#getAccessibleEditableText()"/> 
        /// </summary>
        public Javax.Accessibility.AccessibleEditableText AccessibleEditableText
        {
            get { return IExecuteWithSignature<Javax.Accessibility.AccessibleEditableText>("getAccessibleEditableText", "()Ljavax/accessibility/AccessibleEditableText;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleContext.html#getAccessibleIcon()"/> 
        /// </summary>
        public Javax.Accessibility.AccessibleIcon[] AccessibleIcon
        {
            get { return IExecuteWithSignatureArray<Javax.Accessibility.AccessibleIcon>("getAccessibleIcon", "()[Ljavax/accessibility/AccessibleIcon;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleContext.html#getAccessibleIndexInParent()"/> 
        /// </summary>
        public int AccessibleIndexInParent
        {
            get { return IExecuteWithSignature<int>("getAccessibleIndexInParent", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleContext.html#getAccessibleName()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleContext.html#setAccessibleName(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String AccessibleName
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getAccessibleName", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setAccessibleName", "(Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleContext.html#getAccessibleParent()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleContext.html#setAccessibleParent(javax.accessibility.Accessible)"/>
        /// </summary>
        public Javax.Accessibility.Accessible AccessibleParent
        {
            get { return IExecuteWithSignature<Javax.Accessibility.Accessible>("getAccessibleParent", "()Ljavax/accessibility/Accessible;"); } set { IExecuteWithSignature("setAccessibleParent", "(Ljavax/accessibility/Accessible;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleContext.html#getAccessibleRelationSet()"/> 
        /// </summary>
        public Javax.Accessibility.AccessibleRelationSet AccessibleRelationSet
        {
            get { return IExecuteWithSignature<Javax.Accessibility.AccessibleRelationSet>("getAccessibleRelationSet", "()Ljavax/accessibility/AccessibleRelationSet;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleContext.html#getAccessibleRole()"/> 
        /// </summary>
        public Javax.Accessibility.AccessibleRole AccessibleRole
        {
            get { return IExecuteWithSignature<Javax.Accessibility.AccessibleRole>("getAccessibleRole", "()Ljavax/accessibility/AccessibleRole;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleContext.html#getAccessibleSelection()"/> 
        /// </summary>
        public Javax.Accessibility.AccessibleSelection AccessibleSelection
        {
            get { return IExecuteWithSignature<Javax.Accessibility.AccessibleSelection>("getAccessibleSelection", "()Ljavax/accessibility/AccessibleSelection;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleContext.html#getAccessibleStateSet()"/> 
        /// </summary>
        public Javax.Accessibility.AccessibleStateSet AccessibleStateSet
        {
            get { return IExecuteWithSignature<Javax.Accessibility.AccessibleStateSet>("getAccessibleStateSet", "()Ljavax/accessibility/AccessibleStateSet;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleContext.html#getAccessibleTable()"/> 
        /// </summary>
        public Javax.Accessibility.AccessibleTable AccessibleTable
        {
            get { return IExecuteWithSignature<Javax.Accessibility.AccessibleTable>("getAccessibleTable", "()Ljavax/accessibility/AccessibleTable;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleContext.html#getAccessibleText()"/> 
        /// </summary>
        public Javax.Accessibility.AccessibleText AccessibleText
        {
            get { return IExecuteWithSignature<Javax.Accessibility.AccessibleText>("getAccessibleText", "()Ljavax/accessibility/AccessibleText;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleContext.html#getAccessibleValue()"/> 
        /// </summary>
        public Javax.Accessibility.AccessibleValue AccessibleValue
        {
            get { return IExecuteWithSignature<Javax.Accessibility.AccessibleValue>("getAccessibleValue", "()Ljavax/accessibility/AccessibleValue;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleContext.html#getLocale()"/> 
        /// </summary>
        public Java.Util.Locale Locale
        {
            get { return IExecuteWithSignature<Java.Util.Locale>("getLocale", "()Ljava/util/Locale;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleContext.html#getAccessibleChild(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Javax.Accessibility.Accessible"/></returns>
        public Javax.Accessibility.Accessible GetAccessibleChild(int arg0)
        {
            return IExecuteWithSignature<Javax.Accessibility.Accessible>("getAccessibleChild", "(I)Ljavax/accessibility/Accessible;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleContext.html#addPropertyChangeListener(java.beans.PropertyChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Beans.PropertyChangeListener"/></param>
        public void AddPropertyChangeListener(Java.Beans.PropertyChangeListener arg0)
        {
            IExecuteWithSignature("addPropertyChangeListener", "(Ljava/beans/PropertyChangeListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleContext.html#firePropertyChange(java.lang.String,java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="object"/></param>
        public void FirePropertyChange(Java.Lang.String arg0, object arg1, object arg2)
        {
            IExecuteWithSignature("firePropertyChange", "(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/accessibility/AccessibleContext.html#removePropertyChangeListener(java.beans.PropertyChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Beans.PropertyChangeListener"/></param>
        public void RemovePropertyChangeListener(Java.Beans.PropertyChangeListener arg0)
        {
            IExecuteWithSignature("removePropertyChangeListener", "(Ljava/beans/PropertyChangeListener;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}