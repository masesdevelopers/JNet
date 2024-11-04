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
*  This file is generated by MASES.JNetReflector (ver. 2.5.10.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Print.Attribute.Standard
{
    #region PrinterStateReasons declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/PrinterStateReasons.html"/>
    /// </summary>
    public partial class PrinterStateReasons : Java.Util.HashMap<Javax.Print.Attribute.Standard.PrinterStateReason, Javax.Print.Attribute.Standard.Severity>
    {
        const string _bridgeClassName = "javax.print.attribute.standard.PrinterStateReasons";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public PrinterStateReasons() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public PrinterStateReasons(params object[] args) : base(args) { }

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
        public override bool IsBridgeStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region PrinterStateReasons implementation
    public partial class PrinterStateReasons
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/PrinterStateReasons.html#%3Cinit%3E(int,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        public PrinterStateReasons(int arg0, float arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/PrinterStateReasons.html#%3Cinit%3E(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public PrinterStateReasons(int arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/PrinterStateReasons.html#%3Cinit%3E(java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        public PrinterStateReasons(Java.Util.Map<Javax.Print.Attribute.Standard.PrinterStateReason, Javax.Print.Attribute.Standard.Severity> arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Print.Attribute.Standard.PrinterStateReasons"/> to <see cref="Javax.Print.Attribute.PrintServiceAttribute"/>
        /// </summary>
        public static implicit operator Javax.Print.Attribute.PrintServiceAttribute(Javax.Print.Attribute.Standard.PrinterStateReasons t) => t.Cast<Javax.Print.Attribute.PrintServiceAttribute>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/PrinterStateReasons.html#getCategory()"/> 
        /// </summary>
        public Java.Lang.Class Category
        {
            get { return IExecuteWithSignature<Java.Lang.Class>("getCategory", "()Ljava/lang/Class;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/PrinterStateReasons.html#getName()"/> 
        /// </summary>
        public Java.Lang.String Name
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getName", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/PrinterStateReasons.html#printerStateReasonSet(javax.print.attribute.standard.Severity)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Print.Attribute.Standard.Severity"/></param>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<Javax.Print.Attribute.Standard.PrinterStateReason> PrinterStateReasonSetMethod(Javax.Print.Attribute.Standard.Severity arg0)
        {
            return IExecuteWithSignature<Java.Util.Set<Javax.Print.Attribute.Standard.PrinterStateReason>>("printerStateReasonSet", "(Ljavax/print/attribute/standard/Severity;)Ljava/util/Set;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/PrinterStateReasons.html#put(javax.print.attribute.standard.PrinterStateReason,javax.print.attribute.standard.Severity)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Print.Attribute.Standard.PrinterStateReason"/></param>
        /// <param name="arg1"><see cref="Javax.Print.Attribute.Standard.Severity"/></param>
        /// <returns><see cref="Javax.Print.Attribute.Standard.Severity"/></returns>
        public Javax.Print.Attribute.Standard.Severity Put(Javax.Print.Attribute.Standard.PrinterStateReason arg0, Javax.Print.Attribute.Standard.Severity arg1)
        {
            return IExecuteWithSignature<Javax.Print.Attribute.Standard.Severity>("put", "(Ljavax/print/attribute/standard/PrinterStateReason;Ljavax/print/attribute/standard/Severity;)Ljavax/print/attribute/standard/Severity;", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}