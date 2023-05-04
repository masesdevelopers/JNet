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
*  This file is generated by MASES.JNetReflector (ver. 1.5.5.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Print.Attribute.Standard
{
    #region PrinterStateReason
    public partial class PrinterStateReason
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Print.Attribute.Standard.PrinterStateReason"/> to <see cref="Javax.Print.Attribute.Attribute"/>
        /// </summary>
        public static implicit operator Javax.Print.Attribute.Attribute(Javax.Print.Attribute.Standard.PrinterStateReason t) => t.Cast<Javax.Print.Attribute.Attribute>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/PrinterStateReason.html#CONNECTING_TO_DEVICE"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.PrinterStateReason CONNECTING_TO_DEVICE { get { return SGetField<Javax.Print.Attribute.Standard.PrinterStateReason>(LocalBridgeClazz, "CONNECTING_TO_DEVICE"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/PrinterStateReason.html#COVER_OPEN"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.PrinterStateReason COVER_OPEN { get { return SGetField<Javax.Print.Attribute.Standard.PrinterStateReason>(LocalBridgeClazz, "COVER_OPEN"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/PrinterStateReason.html#DEVELOPER_EMPTY"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.PrinterStateReason DEVELOPER_EMPTY { get { return SGetField<Javax.Print.Attribute.Standard.PrinterStateReason>(LocalBridgeClazz, "DEVELOPER_EMPTY"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/PrinterStateReason.html#DEVELOPER_LOW"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.PrinterStateReason DEVELOPER_LOW { get { return SGetField<Javax.Print.Attribute.Standard.PrinterStateReason>(LocalBridgeClazz, "DEVELOPER_LOW"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/PrinterStateReason.html#DOOR_OPEN"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.PrinterStateReason DOOR_OPEN { get { return SGetField<Javax.Print.Attribute.Standard.PrinterStateReason>(LocalBridgeClazz, "DOOR_OPEN"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/PrinterStateReason.html#FUSER_OVER_TEMP"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.PrinterStateReason FUSER_OVER_TEMP { get { return SGetField<Javax.Print.Attribute.Standard.PrinterStateReason>(LocalBridgeClazz, "FUSER_OVER_TEMP"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/PrinterStateReason.html#FUSER_UNDER_TEMP"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.PrinterStateReason FUSER_UNDER_TEMP { get { return SGetField<Javax.Print.Attribute.Standard.PrinterStateReason>(LocalBridgeClazz, "FUSER_UNDER_TEMP"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/PrinterStateReason.html#INPUT_TRAY_MISSING"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.PrinterStateReason INPUT_TRAY_MISSING { get { return SGetField<Javax.Print.Attribute.Standard.PrinterStateReason>(LocalBridgeClazz, "INPUT_TRAY_MISSING"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/PrinterStateReason.html#INTERLOCK_OPEN"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.PrinterStateReason INTERLOCK_OPEN { get { return SGetField<Javax.Print.Attribute.Standard.PrinterStateReason>(LocalBridgeClazz, "INTERLOCK_OPEN"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/PrinterStateReason.html#INTERPRETER_RESOURCE_UNAVAILABLE"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.PrinterStateReason INTERPRETER_RESOURCE_UNAVAILABLE { get { return SGetField<Javax.Print.Attribute.Standard.PrinterStateReason>(LocalBridgeClazz, "INTERPRETER_RESOURCE_UNAVAILABLE"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/PrinterStateReason.html#MARKER_SUPPLY_EMPTY"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.PrinterStateReason MARKER_SUPPLY_EMPTY { get { return SGetField<Javax.Print.Attribute.Standard.PrinterStateReason>(LocalBridgeClazz, "MARKER_SUPPLY_EMPTY"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/PrinterStateReason.html#MARKER_SUPPLY_LOW"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.PrinterStateReason MARKER_SUPPLY_LOW { get { return SGetField<Javax.Print.Attribute.Standard.PrinterStateReason>(LocalBridgeClazz, "MARKER_SUPPLY_LOW"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/PrinterStateReason.html#MARKER_WASTE_ALMOST_FULL"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.PrinterStateReason MARKER_WASTE_ALMOST_FULL { get { return SGetField<Javax.Print.Attribute.Standard.PrinterStateReason>(LocalBridgeClazz, "MARKER_WASTE_ALMOST_FULL"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/PrinterStateReason.html#MARKER_WASTE_FULL"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.PrinterStateReason MARKER_WASTE_FULL { get { return SGetField<Javax.Print.Attribute.Standard.PrinterStateReason>(LocalBridgeClazz, "MARKER_WASTE_FULL"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/PrinterStateReason.html#MEDIA_EMPTY"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.PrinterStateReason MEDIA_EMPTY { get { return SGetField<Javax.Print.Attribute.Standard.PrinterStateReason>(LocalBridgeClazz, "MEDIA_EMPTY"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/PrinterStateReason.html#MEDIA_JAM"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.PrinterStateReason MEDIA_JAM { get { return SGetField<Javax.Print.Attribute.Standard.PrinterStateReason>(LocalBridgeClazz, "MEDIA_JAM"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/PrinterStateReason.html#MEDIA_LOW"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.PrinterStateReason MEDIA_LOW { get { return SGetField<Javax.Print.Attribute.Standard.PrinterStateReason>(LocalBridgeClazz, "MEDIA_LOW"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/PrinterStateReason.html#MEDIA_NEEDED"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.PrinterStateReason MEDIA_NEEDED { get { return SGetField<Javax.Print.Attribute.Standard.PrinterStateReason>(LocalBridgeClazz, "MEDIA_NEEDED"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/PrinterStateReason.html#MOVING_TO_PAUSED"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.PrinterStateReason MOVING_TO_PAUSED { get { return SGetField<Javax.Print.Attribute.Standard.PrinterStateReason>(LocalBridgeClazz, "MOVING_TO_PAUSED"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/PrinterStateReason.html#OPC_LIFE_OVER"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.PrinterStateReason OPC_LIFE_OVER { get { return SGetField<Javax.Print.Attribute.Standard.PrinterStateReason>(LocalBridgeClazz, "OPC_LIFE_OVER"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/PrinterStateReason.html#OPC_NEAR_EOL"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.PrinterStateReason OPC_NEAR_EOL { get { return SGetField<Javax.Print.Attribute.Standard.PrinterStateReason>(LocalBridgeClazz, "OPC_NEAR_EOL"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/PrinterStateReason.html#OTHER"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.PrinterStateReason OTHER { get { return SGetField<Javax.Print.Attribute.Standard.PrinterStateReason>(LocalBridgeClazz, "OTHER"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/PrinterStateReason.html#OUTPUT_AREA_ALMOST_FULL"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.PrinterStateReason OUTPUT_AREA_ALMOST_FULL { get { return SGetField<Javax.Print.Attribute.Standard.PrinterStateReason>(LocalBridgeClazz, "OUTPUT_AREA_ALMOST_FULL"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/PrinterStateReason.html#OUTPUT_AREA_FULL"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.PrinterStateReason OUTPUT_AREA_FULL { get { return SGetField<Javax.Print.Attribute.Standard.PrinterStateReason>(LocalBridgeClazz, "OUTPUT_AREA_FULL"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/PrinterStateReason.html#OUTPUT_TRAY_MISSING"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.PrinterStateReason OUTPUT_TRAY_MISSING { get { return SGetField<Javax.Print.Attribute.Standard.PrinterStateReason>(LocalBridgeClazz, "OUTPUT_TRAY_MISSING"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/PrinterStateReason.html#PAUSED"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.PrinterStateReason PAUSED { get { return SGetField<Javax.Print.Attribute.Standard.PrinterStateReason>(LocalBridgeClazz, "PAUSED"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/PrinterStateReason.html#SHUTDOWN"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.PrinterStateReason SHUTDOWN { get { return SGetField<Javax.Print.Attribute.Standard.PrinterStateReason>(LocalBridgeClazz, "SHUTDOWN"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/PrinterStateReason.html#SPOOL_AREA_FULL"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.PrinterStateReason SPOOL_AREA_FULL { get { return SGetField<Javax.Print.Attribute.Standard.PrinterStateReason>(LocalBridgeClazz, "SPOOL_AREA_FULL"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/PrinterStateReason.html#STOPPED_PARTLY"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.PrinterStateReason STOPPED_PARTLY { get { return SGetField<Javax.Print.Attribute.Standard.PrinterStateReason>(LocalBridgeClazz, "STOPPED_PARTLY"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/PrinterStateReason.html#STOPPING"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.PrinterStateReason STOPPING { get { return SGetField<Javax.Print.Attribute.Standard.PrinterStateReason>(LocalBridgeClazz, "STOPPING"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/PrinterStateReason.html#TIMED_OUT"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.PrinterStateReason TIMED_OUT { get { return SGetField<Javax.Print.Attribute.Standard.PrinterStateReason>(LocalBridgeClazz, "TIMED_OUT"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/PrinterStateReason.html#TONER_EMPTY"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.PrinterStateReason TONER_EMPTY { get { return SGetField<Javax.Print.Attribute.Standard.PrinterStateReason>(LocalBridgeClazz, "TONER_EMPTY"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/PrinterStateReason.html#TONER_LOW"/>
        /// </summary>
        public static Javax.Print.Attribute.Standard.PrinterStateReason TONER_LOW { get { return SGetField<Javax.Print.Attribute.Standard.PrinterStateReason>(LocalBridgeClazz, "TONER_LOW"); } }

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/PrinterStateReason.html#getCategory()"/> 
        /// </summary>
        public Java.Lang.Class Category
        {
            get { return IExecute<Java.Lang.Class>("getCategory"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/attribute/standard/PrinterStateReason.html#getName()"/> 
        /// </summary>
        public string Name
        {
            get { return IExecute<string>("getName"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}