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
*  This file is generated by MASES.JNetReflector (ver. 2.5.9.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Print.Attribute.Standard
{
    #region JobStateReason declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/JobStateReason.html"/>
    /// </summary>
    public partial class JobStateReason : Javax.Print.Attribute.EnumSyntax
    {
        const string _bridgeClassName = "javax.print.attribute.standard.JobStateReason";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public JobStateReason() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public JobStateReason(params object[] args) : base(args) { }

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

    #region JobStateReason implementation
    public partial class JobStateReason
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Print.Attribute.Standard.JobStateReason"/> to <see cref="Javax.Print.Attribute.Attribute"/>
        /// </summary>
        public static implicit operator Javax.Print.Attribute.Attribute(Javax.Print.Attribute.Standard.JobStateReason t) => t.Cast<Javax.Print.Attribute.Attribute>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/JobStateReason.html#ABORTED_BY_SYSTEM"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.JobStateReason ABORTED_BY_SYSTEM { get { if (!_ABORTED_BY_SYSTEMReady) { _ABORTED_BY_SYSTEMContent = SGetField<Javax.Print.Attribute.Standard.JobStateReason>(LocalBridgeClazz, "ABORTED_BY_SYSTEM"); _ABORTED_BY_SYSTEMReady = true; } return _ABORTED_BY_SYSTEMContent; } }
        private static Javax.Print.Attribute.Standard.JobStateReason _ABORTED_BY_SYSTEMContent = default;
        private static bool _ABORTED_BY_SYSTEMReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/JobStateReason.html#COMPRESSION_ERROR"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.JobStateReason COMPRESSION_ERROR { get { if (!_COMPRESSION_ERRORReady) { _COMPRESSION_ERRORContent = SGetField<Javax.Print.Attribute.Standard.JobStateReason>(LocalBridgeClazz, "COMPRESSION_ERROR"); _COMPRESSION_ERRORReady = true; } return _COMPRESSION_ERRORContent; } }
        private static Javax.Print.Attribute.Standard.JobStateReason _COMPRESSION_ERRORContent = default;
        private static bool _COMPRESSION_ERRORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/JobStateReason.html#DOCUMENT_ACCESS_ERROR"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.JobStateReason DOCUMENT_ACCESS_ERROR { get { if (!_DOCUMENT_ACCESS_ERRORReady) { _DOCUMENT_ACCESS_ERRORContent = SGetField<Javax.Print.Attribute.Standard.JobStateReason>(LocalBridgeClazz, "DOCUMENT_ACCESS_ERROR"); _DOCUMENT_ACCESS_ERRORReady = true; } return _DOCUMENT_ACCESS_ERRORContent; } }
        private static Javax.Print.Attribute.Standard.JobStateReason _DOCUMENT_ACCESS_ERRORContent = default;
        private static bool _DOCUMENT_ACCESS_ERRORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/JobStateReason.html#DOCUMENT_FORMAT_ERROR"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.JobStateReason DOCUMENT_FORMAT_ERROR { get { if (!_DOCUMENT_FORMAT_ERRORReady) { _DOCUMENT_FORMAT_ERRORContent = SGetField<Javax.Print.Attribute.Standard.JobStateReason>(LocalBridgeClazz, "DOCUMENT_FORMAT_ERROR"); _DOCUMENT_FORMAT_ERRORReady = true; } return _DOCUMENT_FORMAT_ERRORContent; } }
        private static Javax.Print.Attribute.Standard.JobStateReason _DOCUMENT_FORMAT_ERRORContent = default;
        private static bool _DOCUMENT_FORMAT_ERRORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/JobStateReason.html#JOB_CANCELED_AT_DEVICE"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.JobStateReason JOB_CANCELED_AT_DEVICE { get { if (!_JOB_CANCELED_AT_DEVICEReady) { _JOB_CANCELED_AT_DEVICEContent = SGetField<Javax.Print.Attribute.Standard.JobStateReason>(LocalBridgeClazz, "JOB_CANCELED_AT_DEVICE"); _JOB_CANCELED_AT_DEVICEReady = true; } return _JOB_CANCELED_AT_DEVICEContent; } }
        private static Javax.Print.Attribute.Standard.JobStateReason _JOB_CANCELED_AT_DEVICEContent = default;
        private static bool _JOB_CANCELED_AT_DEVICEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/JobStateReason.html#JOB_CANCELED_BY_OPERATOR"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.JobStateReason JOB_CANCELED_BY_OPERATOR { get { if (!_JOB_CANCELED_BY_OPERATORReady) { _JOB_CANCELED_BY_OPERATORContent = SGetField<Javax.Print.Attribute.Standard.JobStateReason>(LocalBridgeClazz, "JOB_CANCELED_BY_OPERATOR"); _JOB_CANCELED_BY_OPERATORReady = true; } return _JOB_CANCELED_BY_OPERATORContent; } }
        private static Javax.Print.Attribute.Standard.JobStateReason _JOB_CANCELED_BY_OPERATORContent = default;
        private static bool _JOB_CANCELED_BY_OPERATORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/JobStateReason.html#JOB_CANCELED_BY_USER"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.JobStateReason JOB_CANCELED_BY_USER { get { if (!_JOB_CANCELED_BY_USERReady) { _JOB_CANCELED_BY_USERContent = SGetField<Javax.Print.Attribute.Standard.JobStateReason>(LocalBridgeClazz, "JOB_CANCELED_BY_USER"); _JOB_CANCELED_BY_USERReady = true; } return _JOB_CANCELED_BY_USERContent; } }
        private static Javax.Print.Attribute.Standard.JobStateReason _JOB_CANCELED_BY_USERContent = default;
        private static bool _JOB_CANCELED_BY_USERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/JobStateReason.html#JOB_COMPLETED_SUCCESSFULLY"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.JobStateReason JOB_COMPLETED_SUCCESSFULLY { get { if (!_JOB_COMPLETED_SUCCESSFULLYReady) { _JOB_COMPLETED_SUCCESSFULLYContent = SGetField<Javax.Print.Attribute.Standard.JobStateReason>(LocalBridgeClazz, "JOB_COMPLETED_SUCCESSFULLY"); _JOB_COMPLETED_SUCCESSFULLYReady = true; } return _JOB_COMPLETED_SUCCESSFULLYContent; } }
        private static Javax.Print.Attribute.Standard.JobStateReason _JOB_COMPLETED_SUCCESSFULLYContent = default;
        private static bool _JOB_COMPLETED_SUCCESSFULLYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/JobStateReason.html#JOB_COMPLETED_WITH_ERRORS"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.JobStateReason JOB_COMPLETED_WITH_ERRORS { get { if (!_JOB_COMPLETED_WITH_ERRORSReady) { _JOB_COMPLETED_WITH_ERRORSContent = SGetField<Javax.Print.Attribute.Standard.JobStateReason>(LocalBridgeClazz, "JOB_COMPLETED_WITH_ERRORS"); _JOB_COMPLETED_WITH_ERRORSReady = true; } return _JOB_COMPLETED_WITH_ERRORSContent; } }
        private static Javax.Print.Attribute.Standard.JobStateReason _JOB_COMPLETED_WITH_ERRORSContent = default;
        private static bool _JOB_COMPLETED_WITH_ERRORSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/JobStateReason.html#JOB_COMPLETED_WITH_WARNINGS"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.JobStateReason JOB_COMPLETED_WITH_WARNINGS { get { if (!_JOB_COMPLETED_WITH_WARNINGSReady) { _JOB_COMPLETED_WITH_WARNINGSContent = SGetField<Javax.Print.Attribute.Standard.JobStateReason>(LocalBridgeClazz, "JOB_COMPLETED_WITH_WARNINGS"); _JOB_COMPLETED_WITH_WARNINGSReady = true; } return _JOB_COMPLETED_WITH_WARNINGSContent; } }
        private static Javax.Print.Attribute.Standard.JobStateReason _JOB_COMPLETED_WITH_WARNINGSContent = default;
        private static bool _JOB_COMPLETED_WITH_WARNINGSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/JobStateReason.html#JOB_DATA_INSUFFICIENT"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.JobStateReason JOB_DATA_INSUFFICIENT { get { if (!_JOB_DATA_INSUFFICIENTReady) { _JOB_DATA_INSUFFICIENTContent = SGetField<Javax.Print.Attribute.Standard.JobStateReason>(LocalBridgeClazz, "JOB_DATA_INSUFFICIENT"); _JOB_DATA_INSUFFICIENTReady = true; } return _JOB_DATA_INSUFFICIENTContent; } }
        private static Javax.Print.Attribute.Standard.JobStateReason _JOB_DATA_INSUFFICIENTContent = default;
        private static bool _JOB_DATA_INSUFFICIENTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/JobStateReason.html#JOB_HOLD_UNTIL_SPECIFIED"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.JobStateReason JOB_HOLD_UNTIL_SPECIFIED { get { if (!_JOB_HOLD_UNTIL_SPECIFIEDReady) { _JOB_HOLD_UNTIL_SPECIFIEDContent = SGetField<Javax.Print.Attribute.Standard.JobStateReason>(LocalBridgeClazz, "JOB_HOLD_UNTIL_SPECIFIED"); _JOB_HOLD_UNTIL_SPECIFIEDReady = true; } return _JOB_HOLD_UNTIL_SPECIFIEDContent; } }
        private static Javax.Print.Attribute.Standard.JobStateReason _JOB_HOLD_UNTIL_SPECIFIEDContent = default;
        private static bool _JOB_HOLD_UNTIL_SPECIFIEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/JobStateReason.html#JOB_INCOMING"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.JobStateReason JOB_INCOMING { get { if (!_JOB_INCOMINGReady) { _JOB_INCOMINGContent = SGetField<Javax.Print.Attribute.Standard.JobStateReason>(LocalBridgeClazz, "JOB_INCOMING"); _JOB_INCOMINGReady = true; } return _JOB_INCOMINGContent; } }
        private static Javax.Print.Attribute.Standard.JobStateReason _JOB_INCOMINGContent = default;
        private static bool _JOB_INCOMINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/JobStateReason.html#JOB_INTERPRETING"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.JobStateReason JOB_INTERPRETING { get { if (!_JOB_INTERPRETINGReady) { _JOB_INTERPRETINGContent = SGetField<Javax.Print.Attribute.Standard.JobStateReason>(LocalBridgeClazz, "JOB_INTERPRETING"); _JOB_INTERPRETINGReady = true; } return _JOB_INTERPRETINGContent; } }
        private static Javax.Print.Attribute.Standard.JobStateReason _JOB_INTERPRETINGContent = default;
        private static bool _JOB_INTERPRETINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/JobStateReason.html#JOB_OUTGOING"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.JobStateReason JOB_OUTGOING { get { if (!_JOB_OUTGOINGReady) { _JOB_OUTGOINGContent = SGetField<Javax.Print.Attribute.Standard.JobStateReason>(LocalBridgeClazz, "JOB_OUTGOING"); _JOB_OUTGOINGReady = true; } return _JOB_OUTGOINGContent; } }
        private static Javax.Print.Attribute.Standard.JobStateReason _JOB_OUTGOINGContent = default;
        private static bool _JOB_OUTGOINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/JobStateReason.html#JOB_PRINTING"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.JobStateReason JOB_PRINTING { get { if (!_JOB_PRINTINGReady) { _JOB_PRINTINGContent = SGetField<Javax.Print.Attribute.Standard.JobStateReason>(LocalBridgeClazz, "JOB_PRINTING"); _JOB_PRINTINGReady = true; } return _JOB_PRINTINGContent; } }
        private static Javax.Print.Attribute.Standard.JobStateReason _JOB_PRINTINGContent = default;
        private static bool _JOB_PRINTINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/JobStateReason.html#JOB_QUEUED"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.JobStateReason JOB_QUEUED { get { if (!_JOB_QUEUEDReady) { _JOB_QUEUEDContent = SGetField<Javax.Print.Attribute.Standard.JobStateReason>(LocalBridgeClazz, "JOB_QUEUED"); _JOB_QUEUEDReady = true; } return _JOB_QUEUEDContent; } }
        private static Javax.Print.Attribute.Standard.JobStateReason _JOB_QUEUEDContent = default;
        private static bool _JOB_QUEUEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/JobStateReason.html#JOB_QUEUED_FOR_MARKER"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.JobStateReason JOB_QUEUED_FOR_MARKER { get { if (!_JOB_QUEUED_FOR_MARKERReady) { _JOB_QUEUED_FOR_MARKERContent = SGetField<Javax.Print.Attribute.Standard.JobStateReason>(LocalBridgeClazz, "JOB_QUEUED_FOR_MARKER"); _JOB_QUEUED_FOR_MARKERReady = true; } return _JOB_QUEUED_FOR_MARKERContent; } }
        private static Javax.Print.Attribute.Standard.JobStateReason _JOB_QUEUED_FOR_MARKERContent = default;
        private static bool _JOB_QUEUED_FOR_MARKERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/JobStateReason.html#JOB_RESTARTABLE"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.JobStateReason JOB_RESTARTABLE { get { if (!_JOB_RESTARTABLEReady) { _JOB_RESTARTABLEContent = SGetField<Javax.Print.Attribute.Standard.JobStateReason>(LocalBridgeClazz, "JOB_RESTARTABLE"); _JOB_RESTARTABLEReady = true; } return _JOB_RESTARTABLEContent; } }
        private static Javax.Print.Attribute.Standard.JobStateReason _JOB_RESTARTABLEContent = default;
        private static bool _JOB_RESTARTABLEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/JobStateReason.html#JOB_TRANSFORMING"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.JobStateReason JOB_TRANSFORMING { get { if (!_JOB_TRANSFORMINGReady) { _JOB_TRANSFORMINGContent = SGetField<Javax.Print.Attribute.Standard.JobStateReason>(LocalBridgeClazz, "JOB_TRANSFORMING"); _JOB_TRANSFORMINGReady = true; } return _JOB_TRANSFORMINGContent; } }
        private static Javax.Print.Attribute.Standard.JobStateReason _JOB_TRANSFORMINGContent = default;
        private static bool _JOB_TRANSFORMINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/JobStateReason.html#PRINTER_STOPPED"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.JobStateReason PRINTER_STOPPED { get { if (!_PRINTER_STOPPEDReady) { _PRINTER_STOPPEDContent = SGetField<Javax.Print.Attribute.Standard.JobStateReason>(LocalBridgeClazz, "PRINTER_STOPPED"); _PRINTER_STOPPEDReady = true; } return _PRINTER_STOPPEDContent; } }
        private static Javax.Print.Attribute.Standard.JobStateReason _PRINTER_STOPPEDContent = default;
        private static bool _PRINTER_STOPPEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/JobStateReason.html#PRINTER_STOPPED_PARTLY"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.JobStateReason PRINTER_STOPPED_PARTLY { get { if (!_PRINTER_STOPPED_PARTLYReady) { _PRINTER_STOPPED_PARTLYContent = SGetField<Javax.Print.Attribute.Standard.JobStateReason>(LocalBridgeClazz, "PRINTER_STOPPED_PARTLY"); _PRINTER_STOPPED_PARTLYReady = true; } return _PRINTER_STOPPED_PARTLYContent; } }
        private static Javax.Print.Attribute.Standard.JobStateReason _PRINTER_STOPPED_PARTLYContent = default;
        private static bool _PRINTER_STOPPED_PARTLYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/JobStateReason.html#PROCESSING_TO_STOP_POINT"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.JobStateReason PROCESSING_TO_STOP_POINT { get { if (!_PROCESSING_TO_STOP_POINTReady) { _PROCESSING_TO_STOP_POINTContent = SGetField<Javax.Print.Attribute.Standard.JobStateReason>(LocalBridgeClazz, "PROCESSING_TO_STOP_POINT"); _PROCESSING_TO_STOP_POINTReady = true; } return _PROCESSING_TO_STOP_POINTContent; } }
        private static Javax.Print.Attribute.Standard.JobStateReason _PROCESSING_TO_STOP_POINTContent = default;
        private static bool _PROCESSING_TO_STOP_POINTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/JobStateReason.html#QUEUED_IN_DEVICE"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.JobStateReason QUEUED_IN_DEVICE { get { if (!_QUEUED_IN_DEVICEReady) { _QUEUED_IN_DEVICEContent = SGetField<Javax.Print.Attribute.Standard.JobStateReason>(LocalBridgeClazz, "QUEUED_IN_DEVICE"); _QUEUED_IN_DEVICEReady = true; } return _QUEUED_IN_DEVICEContent; } }
        private static Javax.Print.Attribute.Standard.JobStateReason _QUEUED_IN_DEVICEContent = default;
        private static bool _QUEUED_IN_DEVICEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/JobStateReason.html#RESOURCES_ARE_NOT_READY"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.JobStateReason RESOURCES_ARE_NOT_READY { get { if (!_RESOURCES_ARE_NOT_READYReady) { _RESOURCES_ARE_NOT_READYContent = SGetField<Javax.Print.Attribute.Standard.JobStateReason>(LocalBridgeClazz, "RESOURCES_ARE_NOT_READY"); _RESOURCES_ARE_NOT_READYReady = true; } return _RESOURCES_ARE_NOT_READYContent; } }
        private static Javax.Print.Attribute.Standard.JobStateReason _RESOURCES_ARE_NOT_READYContent = default;
        private static bool _RESOURCES_ARE_NOT_READYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/JobStateReason.html#SERVICE_OFF_LINE"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.JobStateReason SERVICE_OFF_LINE { get { if (!_SERVICE_OFF_LINEReady) { _SERVICE_OFF_LINEContent = SGetField<Javax.Print.Attribute.Standard.JobStateReason>(LocalBridgeClazz, "SERVICE_OFF_LINE"); _SERVICE_OFF_LINEReady = true; } return _SERVICE_OFF_LINEContent; } }
        private static Javax.Print.Attribute.Standard.JobStateReason _SERVICE_OFF_LINEContent = default;
        private static bool _SERVICE_OFF_LINEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/JobStateReason.html#SUBMISSION_INTERRUPTED"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.JobStateReason SUBMISSION_INTERRUPTED { get { if (!_SUBMISSION_INTERRUPTEDReady) { _SUBMISSION_INTERRUPTEDContent = SGetField<Javax.Print.Attribute.Standard.JobStateReason>(LocalBridgeClazz, "SUBMISSION_INTERRUPTED"); _SUBMISSION_INTERRUPTEDReady = true; } return _SUBMISSION_INTERRUPTEDContent; } }
        private static Javax.Print.Attribute.Standard.JobStateReason _SUBMISSION_INTERRUPTEDContent = default;
        private static bool _SUBMISSION_INTERRUPTEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/JobStateReason.html#UNSUPPORTED_COMPRESSION"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.JobStateReason UNSUPPORTED_COMPRESSION { get { if (!_UNSUPPORTED_COMPRESSIONReady) { _UNSUPPORTED_COMPRESSIONContent = SGetField<Javax.Print.Attribute.Standard.JobStateReason>(LocalBridgeClazz, "UNSUPPORTED_COMPRESSION"); _UNSUPPORTED_COMPRESSIONReady = true; } return _UNSUPPORTED_COMPRESSIONContent; } }
        private static Javax.Print.Attribute.Standard.JobStateReason _UNSUPPORTED_COMPRESSIONContent = default;
        private static bool _UNSUPPORTED_COMPRESSIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/JobStateReason.html#UNSUPPORTED_DOCUMENT_FORMAT"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.JobStateReason UNSUPPORTED_DOCUMENT_FORMAT { get { if (!_UNSUPPORTED_DOCUMENT_FORMATReady) { _UNSUPPORTED_DOCUMENT_FORMATContent = SGetField<Javax.Print.Attribute.Standard.JobStateReason>(LocalBridgeClazz, "UNSUPPORTED_DOCUMENT_FORMAT"); _UNSUPPORTED_DOCUMENT_FORMATReady = true; } return _UNSUPPORTED_DOCUMENT_FORMATContent; } }
        private static Javax.Print.Attribute.Standard.JobStateReason _UNSUPPORTED_DOCUMENT_FORMATContent = default;
        private static bool _UNSUPPORTED_DOCUMENT_FORMATReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/JobStateReason.html#getCategory()"/> 
        /// </summary>
        public Java.Lang.Class Category
        {
            get { return IExecuteWithSignature<Java.Lang.Class>("getCategory", "()Ljava/lang/Class;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/JobStateReason.html#getName()"/> 
        /// </summary>
        public Java.Lang.String Name
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getName", "()Ljava/lang/String;"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}