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

namespace Java.Io
{
    #region ObjectInputFilter declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectInputFilter.html"/>
    /// </summary>
    public partial class ObjectInputFilter : MASES.JCOBridge.C2JBridge.JVMBridgeBase<ObjectInputFilter>
    {
        const string _bridgeClassName = "java.io.ObjectInputFilter";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("ObjectInputFilter class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public ObjectInputFilter() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("ObjectInputFilter class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public ObjectInputFilter(params object[] args) : base(args) { }

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
        public override bool IsBridgeInterface => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;

        // TODO: complete the class
        #region Config declaration
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectInputFilter.Config.html"/>
        /// </summary>
        public partial class Config : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Config>
        {
            const string _bridgeClassName = "java.io.ObjectInputFilter$Config";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public Config() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public Config(params object[] args) : base(args) { }

            private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
            private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

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
            public override bool IsBridgeStatic => true;

            // TODO: complete the class

        }
        #endregion

        #region FilterInfo declaration
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectInputFilter.FilterInfo.html"/>
        /// </summary>
        public partial class FilterInfo : MASES.JCOBridge.C2JBridge.JVMBridgeBase<FilterInfo>
        {
            const string _bridgeClassName = "java.io.ObjectInputFilter$FilterInfo";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            [global::System.Obsolete("FilterInfo class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
            public FilterInfo() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            [global::System.Obsolete("FilterInfo class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
            public FilterInfo(params object[] args) : base(args) { }

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
            public override bool IsBridgeInterface => true;
            /// <summary>
            /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
            /// </summary>
            public override bool IsBridgeStatic => true;

            // TODO: complete the class

        }
        #endregion

        #region Status declaration
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectInputFilter.Status.html"/>
        /// </summary>
        public partial class Status : Java.Lang.Enum<Java.Io.ObjectInputFilter.Status>
        {
            const string _bridgeClassName = "java.io.ObjectInputFilter$Status";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public Status() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public Status(params object[] args) : base(args) { }

            private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
            private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

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
            public override bool IsBridgeStatic => true;

            // TODO: complete the class

        }
        #endregion

    
    }
    #endregion

    #region IObjectInputFilter
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IObjectInputFilter
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectInputFilter.html#checkInput(java.io.ObjectInputFilter.FilterInfo)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.ObjectInputFilter.FilterInfo"/></param>
        /// <returns><see cref="Java.Io.ObjectInputFilter.Status"/></returns>
        Java.Io.ObjectInputFilter.Status CheckInput(Java.Io.ObjectInputFilter.FilterInfo arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ObjectInputFilter implementation
    public partial class ObjectInputFilter : Java.Io.IObjectInputFilter
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectInputFilter.html#checkInput(java.io.ObjectInputFilter.FilterInfo)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.ObjectInputFilter.FilterInfo"/></param>
        /// <returns><see cref="Java.Io.ObjectInputFilter.Status"/></returns>
        public Java.Io.ObjectInputFilter.Status CheckInput(Java.Io.ObjectInputFilter.FilterInfo arg0)
        {
            return IExecuteWithSignature<Java.Io.ObjectInputFilter.Status>("checkInput", "(Ljava/io/ObjectInputFilter$FilterInfo;)Ljava/io/ObjectInputFilter$Status;", arg0);
        }

        #endregion

        #region Nested classes
        #region Config implementation
        public partial class Config
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectInputFilter.Config.html#getSerialFilter()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectInputFilter.Config.html#setSerialFilter(java.io.ObjectInputFilter)"/>
            /// </summary>
            public static Java.Io.ObjectInputFilter SerialFilter
            {
                get { return SExecuteWithSignature<Java.Io.ObjectInputFilter>(LocalBridgeClazz, "getSerialFilter", "()Ljava/io/ObjectInputFilter;"); } set { SExecuteWithSignature(LocalBridgeClazz, "setSerialFilter", "(Ljava/io/ObjectInputFilter;)V", value); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectInputFilter.Config.html#createFilter(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Java.Io.ObjectInputFilter"/></returns>
            public static Java.Io.ObjectInputFilter CreateFilter(Java.Lang.String arg0)
            {
                return SExecuteWithSignature<Java.Io.ObjectInputFilter>(LocalBridgeClazz, "createFilter", "(Ljava/lang/String;)Ljava/io/ObjectInputFilter;", arg0);
            }

            #endregion

            #region Instance methods

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region FilterInfo implementation
        public partial class FilterInfo
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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectInputFilter.FilterInfo.html#serialClass()"/>
            /// </summary>
            /// <returns><see cref="Java.Lang.Class"/></returns>
            public Java.Lang.Class SerialClass()
            {
                return IExecuteWithSignature<Java.Lang.Class>("serialClass", "()Ljava/lang/Class;");
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectInputFilter.FilterInfo.html#arrayLength()"/>
            /// </summary>
            /// <returns><see cref="long"/></returns>
            public long ArrayLength()
            {
                return IExecuteWithSignature<long>("arrayLength", "()J");
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectInputFilter.FilterInfo.html#depth()"/>
            /// </summary>
            /// <returns><see cref="long"/></returns>
            public long Depth()
            {
                return IExecuteWithSignature<long>("depth", "()J");
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectInputFilter.FilterInfo.html#references()"/>
            /// </summary>
            /// <returns><see cref="long"/></returns>
            public long References()
            {
                return IExecuteWithSignature<long>("references", "()J");
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectInputFilter.FilterInfo.html#streamBytes()"/>
            /// </summary>
            /// <returns><see cref="long"/></returns>
            public long StreamBytes()
            {
                return IExecuteWithSignature<long>("streamBytes", "()J");
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region Status implementation
        public partial class Status
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectInputFilter.Status.html#ALLOWED"/>
            /// </summary>
            public static Java.Io.ObjectInputFilter.Status ALLOWED { get { if (!_ALLOWEDReady) { _ALLOWEDContent = SGetField<Java.Io.ObjectInputFilter.Status>(LocalBridgeClazz, "ALLOWED"); _ALLOWEDReady = true; } return _ALLOWEDContent; } }
            private static Java.Io.ObjectInputFilter.Status _ALLOWEDContent = default;
            private static bool _ALLOWEDReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectInputFilter.Status.html#REJECTED"/>
            /// </summary>
            public static Java.Io.ObjectInputFilter.Status REJECTED { get { if (!_REJECTEDReady) { _REJECTEDContent = SGetField<Java.Io.ObjectInputFilter.Status>(LocalBridgeClazz, "REJECTED"); _REJECTEDReady = true; } return _REJECTEDContent; } }
            private static Java.Io.ObjectInputFilter.Status _REJECTEDContent = default;
            private static bool _REJECTEDReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectInputFilter.Status.html#UNDECIDED"/>
            /// </summary>
            public static Java.Io.ObjectInputFilter.Status UNDECIDED { get { if (!_UNDECIDEDReady) { _UNDECIDEDContent = SGetField<Java.Io.ObjectInputFilter.Status>(LocalBridgeClazz, "UNDECIDED"); _UNDECIDEDReady = true; } return _UNDECIDEDContent; } }
            private static Java.Io.ObjectInputFilter.Status _UNDECIDEDContent = default;
            private static bool _UNDECIDEDReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectInputFilter.Status.html#valueOf(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Java.Io.ObjectInputFilter.Status"/></returns>
            public static Java.Io.ObjectInputFilter.Status ValueOf(Java.Lang.String arg0)
            {
                return SExecuteWithSignature<Java.Io.ObjectInputFilter.Status>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Ljava/io/ObjectInputFilter$Status;", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectInputFilter.Status.html#values()"/>
            /// </summary>
            /// <returns><see cref="Java.Io.ObjectInputFilter.Status"/></returns>
            public static Java.Io.ObjectInputFilter.Status[] Values()
            {
                return SExecuteWithSignatureArray<Java.Io.ObjectInputFilter.Status>(LocalBridgeClazz, "values", "()[Ljava/io/ObjectInputFilter$Status;");
            }

            #endregion

            #region Instance methods

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

    
        #endregion

        // TODO: complete the class
    }
    #endregion
}