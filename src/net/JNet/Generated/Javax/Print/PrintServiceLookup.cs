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

namespace Javax.Print
{
    #region PrintServiceLookup declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/PrintServiceLookup.html"/>
    /// </summary>
    public partial class PrintServiceLookup : MASES.JCOBridge.C2JBridge.JVMBridgeBase<PrintServiceLookup>
    {
        const string _bridgeClassName = "javax.print.PrintServiceLookup";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("PrintServiceLookup class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public PrintServiceLookup() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("PrintServiceLookup class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public PrintServiceLookup(params object[] args) : base(args) { }

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

    #region PrintServiceLookup implementation
    public partial class PrintServiceLookup
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/PrintServiceLookup.html#registerService(javax.print.PrintService)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Print.PrintService"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool RegisterService(Javax.Print.PrintService arg0)
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "registerService", "(Ljavax/print/PrintService;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/PrintServiceLookup.html#registerServiceProvider(javax.print.PrintServiceLookup)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Print.PrintServiceLookup"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool RegisterServiceProvider(Javax.Print.PrintServiceLookup arg0)
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "registerServiceProvider", "(Ljavax/print/PrintServiceLookup;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/PrintServiceLookup.html#lookupMultiDocPrintServices(javax.print.DocFlavor[],javax.print.attribute.AttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Print.DocFlavor"/></param>
        /// <param name="arg1"><see cref="Javax.Print.Attribute.AttributeSet"/></param>
        /// <returns><see cref="Javax.Print.MultiDocPrintService"/></returns>
        public static Javax.Print.MultiDocPrintService[] LookupMultiDocPrintServices(Javax.Print.DocFlavor[] arg0, Javax.Print.Attribute.AttributeSet arg1)
        {
            return SExecuteWithSignatureArray<Javax.Print.MultiDocPrintService>(LocalBridgeClazz, "lookupMultiDocPrintServices", "([Ljavax/print/DocFlavor;Ljavax/print/attribute/AttributeSet;)[Ljavax/print/MultiDocPrintService;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/PrintServiceLookup.html#lookupDefaultPrintService()"/>
        /// </summary>
        /// <returns><see cref="Javax.Print.PrintService"/></returns>
        public static Javax.Print.PrintService LookupDefaultPrintService()
        {
            return SExecuteWithSignature<Javax.Print.PrintService>(LocalBridgeClazz, "lookupDefaultPrintService", "()Ljavax/print/PrintService;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/PrintServiceLookup.html#lookupPrintServices(javax.print.DocFlavor,javax.print.attribute.AttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Print.DocFlavor"/></param>
        /// <param name="arg1"><see cref="Javax.Print.Attribute.AttributeSet"/></param>
        /// <returns><see cref="Javax.Print.PrintService"/></returns>
        public static Javax.Print.PrintService[] LookupPrintServices(Javax.Print.DocFlavor arg0, Javax.Print.Attribute.AttributeSet arg1)
        {
            return SExecuteWithSignatureArray<Javax.Print.PrintService>(LocalBridgeClazz, "lookupPrintServices", "(Ljavax/print/DocFlavor;Ljavax/print/attribute/AttributeSet;)[Ljavax/print/PrintService;", arg0, arg1);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/PrintServiceLookup.html#getDefaultPrintService()"/> 
        /// </summary>
        public Javax.Print.PrintService DefaultPrintService
        {
            get { return IExecuteWithSignature<Javax.Print.PrintService>("getDefaultPrintService", "()Ljavax/print/PrintService;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/PrintServiceLookup.html#getPrintServices()"/> 
        /// </summary>
        public Javax.Print.PrintService[] PrintServices
        {
            get { return IExecuteWithSignatureArray<Javax.Print.PrintService>("getPrintServices", "()[Ljavax/print/PrintService;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/PrintServiceLookup.html#getMultiDocPrintServices(javax.print.DocFlavor[],javax.print.attribute.AttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Print.DocFlavor"/></param>
        /// <param name="arg1"><see cref="Javax.Print.Attribute.AttributeSet"/></param>
        /// <returns><see cref="Javax.Print.MultiDocPrintService"/></returns>
        public Javax.Print.MultiDocPrintService[] GetMultiDocPrintServices(Javax.Print.DocFlavor[] arg0, Javax.Print.Attribute.AttributeSet arg1)
        {
            return IExecuteWithSignatureArray<Javax.Print.MultiDocPrintService>("getMultiDocPrintServices", "([Ljavax/print/DocFlavor;Ljavax/print/attribute/AttributeSet;)[Ljavax/print/MultiDocPrintService;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/PrintServiceLookup.html#getPrintServices(javax.print.DocFlavor,javax.print.attribute.AttributeSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Print.DocFlavor"/></param>
        /// <param name="arg1"><see cref="Javax.Print.Attribute.AttributeSet"/></param>
        /// <returns><see cref="Javax.Print.PrintService"/></returns>
        public Javax.Print.PrintService[] GetPrintServices(Javax.Print.DocFlavor arg0, Javax.Print.Attribute.AttributeSet arg1)
        {
            return IExecuteWithSignatureArray<Javax.Print.PrintService>("getPrintServices", "(Ljavax/print/DocFlavor;Ljavax/print/attribute/AttributeSet;)[Ljavax/print/PrintService;", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}