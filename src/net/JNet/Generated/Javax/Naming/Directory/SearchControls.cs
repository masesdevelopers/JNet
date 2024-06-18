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
*  This file is generated by MASES.JNetReflector (ver. 2.5.3.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Naming.Directory
{
    #region SearchControls
    public partial class SearchControls
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/SearchControls.html#%3Cinit%3E(int,long,int,java.lang.String[],boolean,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="Java.Lang.String"/></param>
        /// <param name="arg4"><see cref="bool"/></param>
        /// <param name="arg5"><see cref="bool"/></param>
        public SearchControls(int arg0, long arg1, int arg2, Java.Lang.String[] arg3, bool arg4, bool arg5)
            : base(arg0, arg1, arg2, arg3, arg4, arg5)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/SearchControls.html#OBJECT_SCOPE"/>
        /// </summary>
        public static int OBJECT_SCOPE { get { if (!_OBJECT_SCOPEReady) { _OBJECT_SCOPEContent = SGetField<int>(LocalBridgeClazz, "OBJECT_SCOPE"); _OBJECT_SCOPEReady = true; } return _OBJECT_SCOPEContent; } }
        private static int _OBJECT_SCOPEContent = default;
        private static bool _OBJECT_SCOPEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/SearchControls.html#ONELEVEL_SCOPE"/>
        /// </summary>
        public static int ONELEVEL_SCOPE { get { if (!_ONELEVEL_SCOPEReady) { _ONELEVEL_SCOPEContent = SGetField<int>(LocalBridgeClazz, "ONELEVEL_SCOPE"); _ONELEVEL_SCOPEReady = true; } return _ONELEVEL_SCOPEContent; } }
        private static int _ONELEVEL_SCOPEContent = default;
        private static bool _ONELEVEL_SCOPEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/SearchControls.html#SUBTREE_SCOPE"/>
        /// </summary>
        public static int SUBTREE_SCOPE { get { if (!_SUBTREE_SCOPEReady) { _SUBTREE_SCOPEContent = SGetField<int>(LocalBridgeClazz, "SUBTREE_SCOPE"); _SUBTREE_SCOPEReady = true; } return _SUBTREE_SCOPEContent; } }
        private static int _SUBTREE_SCOPEContent = default;
        private static bool _SUBTREE_SCOPEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/SearchControls.html#getCountLimit()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/SearchControls.html#setCountLimit(long)"/>
        /// </summary>
        public long CountLimit
        {
            get { return IExecuteWithSignature<long>("getCountLimit", "()J"); } set { IExecuteWithSignature("setCountLimit", "(J)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/SearchControls.html#getDerefLinkFlag()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/SearchControls.html#setDerefLinkFlag(boolean)"/>
        /// </summary>
        public bool DerefLinkFlag
        {
            get { return IExecuteWithSignature<bool>("getDerefLinkFlag", "()Z"); } set { IExecuteWithSignature("setDerefLinkFlag", "(Z)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/SearchControls.html#getReturningAttributes()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/SearchControls.html#setReturningAttributes(java.lang.String[])"/>
        /// </summary>
        public Java.Lang.String[] ReturningAttributes
        {
            get { return IExecuteWithSignatureArray<Java.Lang.String>("getReturningAttributes", "()[Ljava/lang/String;"); } set { IExecuteWithSignature("setReturningAttributes", "([Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/SearchControls.html#getReturningObjFlag()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/SearchControls.html#setReturningObjFlag(boolean)"/>
        /// </summary>
        public bool ReturningObjFlag
        {
            get { return IExecuteWithSignature<bool>("getReturningObjFlag", "()Z"); } set { IExecuteWithSignature("setReturningObjFlag", "(Z)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/SearchControls.html#getSearchScope()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/SearchControls.html#setSearchScope(int)"/>
        /// </summary>
        public int SearchScope
        {
            get { return IExecuteWithSignature<int>("getSearchScope", "()I"); } set { IExecuteWithSignature("setSearchScope", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/SearchControls.html#getTimeLimit()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/directory/SearchControls.html#setTimeLimit(int)"/>
        /// </summary>
        public int TimeLimit
        {
            get { return IExecuteWithSignature<int>("getTimeLimit", "()I"); } set { IExecuteWithSignature("setTimeLimit", "(I)V", value); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}