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
*  This file is generated by MASES.JNetReflector (ver. 2.5.6.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Naming
{
    #region NameClassPair
    public partial class NameClassPair
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/NameClassPair.html#%3Cinit%3E(java.lang.String,java.lang.String,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        public NameClassPair(Java.Lang.String arg0, Java.Lang.String arg1, bool arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/NameClassPair.html#%3Cinit%3E(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        public NameClassPair(Java.Lang.String arg0, Java.Lang.String arg1)
            : base(arg0, arg1)
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/NameClassPair.html#getClassName()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/NameClassPair.html#setClassName(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String ClassName
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getClassName", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setClassName", "(Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/NameClassPair.html#getName()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/NameClassPair.html#setName(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String Name
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getName", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setName", "(Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/NameClassPair.html#getNameInNamespace()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/NameClassPair.html#setNameInNamespace(java.lang.String)"/>
        /// </summary>
        public Java.Lang.String NameInNamespace
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getNameInNamespace", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setNameInNamespace", "(Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/NameClassPair.html#isRelative()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsRelative()
        {
            return IExecuteWithSignature<bool>("isRelative", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/NameClassPair.html#setRelative(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetRelative(bool arg0)
        {
            IExecuteWithSignature("setRelative", "(Z)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}