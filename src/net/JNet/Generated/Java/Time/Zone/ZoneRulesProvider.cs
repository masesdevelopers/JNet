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

namespace Java.Time.Zone
{
    #region ZoneRulesProvider declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/zone/ZoneRulesProvider.html"/>
    /// </summary>
    public partial class ZoneRulesProvider : MASES.JCOBridge.C2JBridge.JVMBridgeBase<ZoneRulesProvider>
    {
        const string _bridgeClassName = "java.time.zone.ZoneRulesProvider";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("ZoneRulesProvider class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public ZoneRulesProvider() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("ZoneRulesProvider class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public ZoneRulesProvider(params object[] args) : base(args) { }

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

    #region ZoneRulesProvider implementation
    public partial class ZoneRulesProvider
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/zone/ZoneRulesProvider.html#getAvailableZoneIds()"/> 
        /// </summary>
        public static Java.Util.Set<Java.Lang.String> AvailableZoneIds
        {
            get { return SExecuteWithSignature<Java.Util.Set<Java.Lang.String>>(LocalBridgeClazz, "getAvailableZoneIds", "()Ljava/util/Set;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/zone/ZoneRulesProvider.html#refresh()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public static bool Refresh()
        {
            return SExecuteWithSignature<bool>(LocalBridgeClazz, "refresh", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/zone/ZoneRulesProvider.html#getRules(java.lang.String,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <returns><see cref="Java.Time.Zone.ZoneRules"/></returns>
        public static Java.Time.Zone.ZoneRules GetRules(Java.Lang.String arg0, bool arg1)
        {
            return SExecuteWithSignature<Java.Time.Zone.ZoneRules>(LocalBridgeClazz, "getRules", "(Ljava/lang/String;Z)Ljava/time/zone/ZoneRules;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/zone/ZoneRulesProvider.html#getVersions(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Util.NavigableMap"/></returns>
        public static Java.Util.NavigableMap<Java.Lang.String, Java.Time.Zone.ZoneRules> GetVersions(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Util.NavigableMap<Java.Lang.String, Java.Time.Zone.ZoneRules>>(LocalBridgeClazz, "getVersions", "(Ljava/lang/String;)Ljava/util/NavigableMap;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/time/zone/ZoneRulesProvider.html#registerProvider(java.time.zone.ZoneRulesProvider)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.Zone.ZoneRulesProvider"/></param>
        public static void RegisterProvider(Java.Time.Zone.ZoneRulesProvider arg0)
        {
            SExecuteWithSignature(LocalBridgeClazz, "registerProvider", "(Ljava/time/zone/ZoneRulesProvider;)V", arg0);
        }

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}