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
*  This file is generated by MASES.JNetReflector (ver. 2.2.5.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Naming
{
    #region IContext
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IContext
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/Context.html#getEnvironment()"/> 
        /// </summary>
        Java.Util.Hashtable<object, object> Environment { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/Context.html#getNameInNamespace()"/> 
        /// </summary>
        Java.Lang.String NameInNamespace { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/Context.html#addToEnvironment(java.lang.String,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        object AddToEnvironment(Java.Lang.String arg0, object arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/Context.html#lookup(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        object Lookup(Java.Lang.String arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/Context.html#lookup(javax.naming.Name)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Name"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        object Lookup(Javax.Naming.Name arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/Context.html#lookupLink(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        object LookupLink(Java.Lang.String arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/Context.html#lookupLink(javax.naming.Name)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Name"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        object LookupLink(Javax.Naming.Name arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/Context.html#removeFromEnvironment(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        object RemoveFromEnvironment(Java.Lang.String arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/Context.html#composeName(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        Java.Lang.String ComposeName(Java.Lang.String arg0, Java.Lang.String arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/Context.html#createSubcontext(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Naming.Context"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        Javax.Naming.Context CreateSubcontext(Java.Lang.String arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/Context.html#createSubcontext(javax.naming.Name)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Name"/></param>
        /// <returns><see cref="Javax.Naming.Context"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        Javax.Naming.Context CreateSubcontext(Javax.Naming.Name arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/Context.html#composeName(javax.naming.Name,javax.naming.Name)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Name"/></param>
        /// <param name="arg1"><see cref="Javax.Naming.Name"/></param>
        /// <returns><see cref="Javax.Naming.Name"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        Javax.Naming.Name ComposeName(Javax.Naming.Name arg0, Javax.Naming.Name arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/Context.html#getNameParser(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Naming.NameParser"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        Javax.Naming.NameParser GetNameParser(Java.Lang.String arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/Context.html#getNameParser(javax.naming.Name)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Name"/></param>
        /// <returns><see cref="Javax.Naming.NameParser"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        Javax.Naming.NameParser GetNameParser(Javax.Naming.Name arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/Context.html#listBindings(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Naming.NamingEnumeration"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        Javax.Naming.NamingEnumeration<Javax.Naming.Binding> ListBindings(Java.Lang.String arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/Context.html#listBindings(javax.naming.Name)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Name"/></param>
        /// <returns><see cref="Javax.Naming.NamingEnumeration"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        Javax.Naming.NamingEnumeration<Javax.Naming.Binding> ListBindings(Javax.Naming.Name arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/Context.html#list(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Naming.NamingEnumeration"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        Javax.Naming.NamingEnumeration<Javax.Naming.NameClassPair> List(Java.Lang.String arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/Context.html#list(javax.naming.Name)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Name"/></param>
        /// <returns><see cref="Javax.Naming.NamingEnumeration"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        Javax.Naming.NamingEnumeration<Javax.Naming.NameClassPair> List(Javax.Naming.Name arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/Context.html#bind(java.lang.String,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <exception cref="Javax.Naming.NamingException"/>
        void Bind(Java.Lang.String arg0, object arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/Context.html#bind(javax.naming.Name,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Name"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <exception cref="Javax.Naming.NamingException"/>
        void Bind(Javax.Naming.Name arg0, object arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/Context.html#close()"/>
        /// </summary>

        /// <exception cref="Javax.Naming.NamingException"/>
        void Close();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/Context.html#destroySubcontext(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Javax.Naming.NamingException"/>
        void DestroySubcontext(Java.Lang.String arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/Context.html#destroySubcontext(javax.naming.Name)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Name"/></param>
        /// <exception cref="Javax.Naming.NamingException"/>
        void DestroySubcontext(Javax.Naming.Name arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/Context.html#rebind(java.lang.String,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <exception cref="Javax.Naming.NamingException"/>
        void Rebind(Java.Lang.String arg0, object arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/Context.html#rebind(javax.naming.Name,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Name"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <exception cref="Javax.Naming.NamingException"/>
        void Rebind(Javax.Naming.Name arg0, object arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/Context.html#rename(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Javax.Naming.NamingException"/>
        void Rename(Java.Lang.String arg0, Java.Lang.String arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/Context.html#rename(javax.naming.Name,javax.naming.Name)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Name"/></param>
        /// <param name="arg1"><see cref="Javax.Naming.Name"/></param>
        /// <exception cref="Javax.Naming.NamingException"/>
        void Rename(Javax.Naming.Name arg0, Javax.Naming.Name arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/Context.html#unbind(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Javax.Naming.NamingException"/>
        void Unbind(Java.Lang.String arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/Context.html#unbind(javax.naming.Name)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Name"/></param>
        /// <exception cref="Javax.Naming.NamingException"/>
        void Unbind(Javax.Naming.Name arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region Context
    public partial class Context : Javax.Naming.IContext
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/Context.html#AUTHORITATIVE"/>
        /// </summary>
        public static Java.Lang.String AUTHORITATIVE { get { if (!_AUTHORITATIVEReady) { _AUTHORITATIVEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "AUTHORITATIVE"); _AUTHORITATIVEReady = true; } return _AUTHORITATIVEContent; } }
        private static Java.Lang.String _AUTHORITATIVEContent = default;
        private static bool _AUTHORITATIVEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/Context.html#BATCHSIZE"/>
        /// </summary>
        public static Java.Lang.String BATCHSIZE { get { if (!_BATCHSIZEReady) { _BATCHSIZEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "BATCHSIZE"); _BATCHSIZEReady = true; } return _BATCHSIZEContent; } }
        private static Java.Lang.String _BATCHSIZEContent = default;
        private static bool _BATCHSIZEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/Context.html#DNS_URL"/>
        /// </summary>
        public static Java.Lang.String DNS_URL { get { if (!_DNS_URLReady) { _DNS_URLContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "DNS_URL"); _DNS_URLReady = true; } return _DNS_URLContent; } }
        private static Java.Lang.String _DNS_URLContent = default;
        private static bool _DNS_URLReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/Context.html#INITIAL_CONTEXT_FACTORY"/>
        /// </summary>
        public static Java.Lang.String INITIAL_CONTEXT_FACTORY { get { if (!_INITIAL_CONTEXT_FACTORYReady) { _INITIAL_CONTEXT_FACTORYContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "INITIAL_CONTEXT_FACTORY"); _INITIAL_CONTEXT_FACTORYReady = true; } return _INITIAL_CONTEXT_FACTORYContent; } }
        private static Java.Lang.String _INITIAL_CONTEXT_FACTORYContent = default;
        private static bool _INITIAL_CONTEXT_FACTORYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/Context.html#LANGUAGE"/>
        /// </summary>
        public static Java.Lang.String LANGUAGE { get { if (!_LANGUAGEReady) { _LANGUAGEContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "LANGUAGE"); _LANGUAGEReady = true; } return _LANGUAGEContent; } }
        private static Java.Lang.String _LANGUAGEContent = default;
        private static bool _LANGUAGEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/Context.html#OBJECT_FACTORIES"/>
        /// </summary>
        public static Java.Lang.String OBJECT_FACTORIES { get { if (!_OBJECT_FACTORIESReady) { _OBJECT_FACTORIESContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "OBJECT_FACTORIES"); _OBJECT_FACTORIESReady = true; } return _OBJECT_FACTORIESContent; } }
        private static Java.Lang.String _OBJECT_FACTORIESContent = default;
        private static bool _OBJECT_FACTORIESReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/Context.html#PROVIDER_URL"/>
        /// </summary>
        public static Java.Lang.String PROVIDER_URL { get { if (!_PROVIDER_URLReady) { _PROVIDER_URLContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "PROVIDER_URL"); _PROVIDER_URLReady = true; } return _PROVIDER_URLContent; } }
        private static Java.Lang.String _PROVIDER_URLContent = default;
        private static bool _PROVIDER_URLReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/Context.html#REFERRAL"/>
        /// </summary>
        public static Java.Lang.String REFERRAL { get { if (!_REFERRALReady) { _REFERRALContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "REFERRAL"); _REFERRALReady = true; } return _REFERRALContent; } }
        private static Java.Lang.String _REFERRALContent = default;
        private static bool _REFERRALReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/Context.html#SECURITY_AUTHENTICATION"/>
        /// </summary>
        public static Java.Lang.String SECURITY_AUTHENTICATION { get { if (!_SECURITY_AUTHENTICATIONReady) { _SECURITY_AUTHENTICATIONContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "SECURITY_AUTHENTICATION"); _SECURITY_AUTHENTICATIONReady = true; } return _SECURITY_AUTHENTICATIONContent; } }
        private static Java.Lang.String _SECURITY_AUTHENTICATIONContent = default;
        private static bool _SECURITY_AUTHENTICATIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/Context.html#SECURITY_CREDENTIALS"/>
        /// </summary>
        public static Java.Lang.String SECURITY_CREDENTIALS { get { if (!_SECURITY_CREDENTIALSReady) { _SECURITY_CREDENTIALSContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "SECURITY_CREDENTIALS"); _SECURITY_CREDENTIALSReady = true; } return _SECURITY_CREDENTIALSContent; } }
        private static Java.Lang.String _SECURITY_CREDENTIALSContent = default;
        private static bool _SECURITY_CREDENTIALSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/Context.html#SECURITY_PRINCIPAL"/>
        /// </summary>
        public static Java.Lang.String SECURITY_PRINCIPAL { get { if (!_SECURITY_PRINCIPALReady) { _SECURITY_PRINCIPALContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "SECURITY_PRINCIPAL"); _SECURITY_PRINCIPALReady = true; } return _SECURITY_PRINCIPALContent; } }
        private static Java.Lang.String _SECURITY_PRINCIPALContent = default;
        private static bool _SECURITY_PRINCIPALReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/Context.html#SECURITY_PROTOCOL"/>
        /// </summary>
        public static Java.Lang.String SECURITY_PROTOCOL { get { if (!_SECURITY_PROTOCOLReady) { _SECURITY_PROTOCOLContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "SECURITY_PROTOCOL"); _SECURITY_PROTOCOLReady = true; } return _SECURITY_PROTOCOLContent; } }
        private static Java.Lang.String _SECURITY_PROTOCOLContent = default;
        private static bool _SECURITY_PROTOCOLReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/Context.html#STATE_FACTORIES"/>
        /// </summary>
        public static Java.Lang.String STATE_FACTORIES { get { if (!_STATE_FACTORIESReady) { _STATE_FACTORIESContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "STATE_FACTORIES"); _STATE_FACTORIESReady = true; } return _STATE_FACTORIESContent; } }
        private static Java.Lang.String _STATE_FACTORIESContent = default;
        private static bool _STATE_FACTORIESReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/Context.html#URL_PKG_PREFIXES"/>
        /// </summary>
        public static Java.Lang.String URL_PKG_PREFIXES { get { if (!_URL_PKG_PREFIXESReady) { _URL_PKG_PREFIXESContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "URL_PKG_PREFIXES"); _URL_PKG_PREFIXESReady = true; } return _URL_PKG_PREFIXESContent; } }
        private static Java.Lang.String _URL_PKG_PREFIXESContent = default;
        private static bool _URL_PKG_PREFIXESReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/Context.html#getEnvironment()"/> 
        /// </summary>
        public Java.Util.Hashtable<object, object> Environment
        {
            get { return IExecute<Java.Util.Hashtable<object, object>>("getEnvironment"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/Context.html#getNameInNamespace()"/> 
        /// </summary>
        public Java.Lang.String NameInNamespace
        {
            get { return IExecute<Java.Lang.String>("getNameInNamespace"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/Context.html#addToEnvironment(java.lang.String,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        public object AddToEnvironment(Java.Lang.String arg0, object arg1)
        {
            return IExecute("addToEnvironment", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/Context.html#lookup(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        public object Lookup(Java.Lang.String arg0)
        {
            return IExecute("lookup", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/Context.html#lookup(javax.naming.Name)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Name"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        public object Lookup(Javax.Naming.Name arg0)
        {
            return IExecute("lookup", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/Context.html#lookupLink(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        public object LookupLink(Java.Lang.String arg0)
        {
            return IExecute("lookupLink", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/Context.html#lookupLink(javax.naming.Name)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Name"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        public object LookupLink(Javax.Naming.Name arg0)
        {
            return IExecute("lookupLink", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/Context.html#removeFromEnvironment(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        public object RemoveFromEnvironment(Java.Lang.String arg0)
        {
            return IExecute("removeFromEnvironment", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/Context.html#composeName(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        public Java.Lang.String ComposeName(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            return IExecute<Java.Lang.String>("composeName", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/Context.html#createSubcontext(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Naming.Context"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        public Javax.Naming.Context CreateSubcontext(Java.Lang.String arg0)
        {
            return IExecute<Javax.Naming.Context>("createSubcontext", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/Context.html#createSubcontext(javax.naming.Name)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Name"/></param>
        /// <returns><see cref="Javax.Naming.Context"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        public Javax.Naming.Context CreateSubcontext(Javax.Naming.Name arg0)
        {
            return IExecute<Javax.Naming.Context>("createSubcontext", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/Context.html#composeName(javax.naming.Name,javax.naming.Name)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Name"/></param>
        /// <param name="arg1"><see cref="Javax.Naming.Name"/></param>
        /// <returns><see cref="Javax.Naming.Name"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        public Javax.Naming.Name ComposeName(Javax.Naming.Name arg0, Javax.Naming.Name arg1)
        {
            return IExecute<Javax.Naming.Name>("composeName", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/Context.html#getNameParser(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Naming.NameParser"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        public Javax.Naming.NameParser GetNameParser(Java.Lang.String arg0)
        {
            return IExecute<Javax.Naming.NameParser>("getNameParser", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/Context.html#getNameParser(javax.naming.Name)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Name"/></param>
        /// <returns><see cref="Javax.Naming.NameParser"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        public Javax.Naming.NameParser GetNameParser(Javax.Naming.Name arg0)
        {
            return IExecute<Javax.Naming.NameParser>("getNameParser", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/Context.html#listBindings(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Naming.NamingEnumeration"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        public Javax.Naming.NamingEnumeration<Javax.Naming.Binding> ListBindings(Java.Lang.String arg0)
        {
            return IExecute<Javax.Naming.NamingEnumeration<Javax.Naming.Binding>>("listBindings", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/Context.html#listBindings(javax.naming.Name)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Name"/></param>
        /// <returns><see cref="Javax.Naming.NamingEnumeration"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        public Javax.Naming.NamingEnumeration<Javax.Naming.Binding> ListBindings(Javax.Naming.Name arg0)
        {
            return IExecute<Javax.Naming.NamingEnumeration<Javax.Naming.Binding>>("listBindings", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/Context.html#list(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Naming.NamingEnumeration"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        public Javax.Naming.NamingEnumeration<Javax.Naming.NameClassPair> List(Java.Lang.String arg0)
        {
            return IExecute<Javax.Naming.NamingEnumeration<Javax.Naming.NameClassPair>>("list", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/Context.html#list(javax.naming.Name)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Name"/></param>
        /// <returns><see cref="Javax.Naming.NamingEnumeration"/></returns>
        /// <exception cref="Javax.Naming.NamingException"/>
        public Javax.Naming.NamingEnumeration<Javax.Naming.NameClassPair> List(Javax.Naming.Name arg0)
        {
            return IExecute<Javax.Naming.NamingEnumeration<Javax.Naming.NameClassPair>>("list", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/Context.html#bind(java.lang.String,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <exception cref="Javax.Naming.NamingException"/>
        public void Bind(Java.Lang.String arg0, object arg1)
        {
            IExecute("bind", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/Context.html#bind(javax.naming.Name,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Name"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <exception cref="Javax.Naming.NamingException"/>
        public void Bind(Javax.Naming.Name arg0, object arg1)
        {
            IExecute("bind", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/Context.html#close()"/>
        /// </summary>

        /// <exception cref="Javax.Naming.NamingException"/>
        public void Close()
        {
            IExecute("close");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/Context.html#destroySubcontext(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Javax.Naming.NamingException"/>
        public void DestroySubcontext(Java.Lang.String arg0)
        {
            IExecute("destroySubcontext", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/Context.html#destroySubcontext(javax.naming.Name)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Name"/></param>
        /// <exception cref="Javax.Naming.NamingException"/>
        public void DestroySubcontext(Javax.Naming.Name arg0)
        {
            IExecute("destroySubcontext", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/Context.html#rebind(java.lang.String,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <exception cref="Javax.Naming.NamingException"/>
        public void Rebind(Java.Lang.String arg0, object arg1)
        {
            IExecute("rebind", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/Context.html#rebind(javax.naming.Name,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Name"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <exception cref="Javax.Naming.NamingException"/>
        public void Rebind(Javax.Naming.Name arg0, object arg1)
        {
            IExecute("rebind", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/Context.html#rename(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Javax.Naming.NamingException"/>
        public void Rename(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            IExecute("rename", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/Context.html#rename(javax.naming.Name,javax.naming.Name)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Name"/></param>
        /// <param name="arg1"><see cref="Javax.Naming.Name"/></param>
        /// <exception cref="Javax.Naming.NamingException"/>
        public void Rename(Javax.Naming.Name arg0, Javax.Naming.Name arg1)
        {
            IExecute("rename", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/Context.html#unbind(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Javax.Naming.NamingException"/>
        public void Unbind(Java.Lang.String arg0)
        {
            IExecute("unbind", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/Context.html#unbind(javax.naming.Name)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Name"/></param>
        /// <exception cref="Javax.Naming.NamingException"/>
        public void Unbind(Javax.Naming.Name arg0)
        {
            IExecute("unbind", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}