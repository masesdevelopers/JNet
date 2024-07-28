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

namespace Java.Beans.Beancontext
{
    #region BeanContextServiceRevokedEvent
    public partial class BeanContextServiceRevokedEvent
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContextServiceRevokedEvent.html#%3Cinit%3E(java.beans.beancontext.BeanContextServices,java.lang.Class,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Beans.Beancontext.BeanContextServices"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Class"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        public BeanContextServiceRevokedEvent(Java.Beans.Beancontext.BeanContextServices arg0, Java.Lang.Class arg1, bool arg2)
            : base(arg0, arg1, arg2)
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContextServiceRevokedEvent.html#getServiceClass()"/> 
        /// </summary>
        public Java.Lang.Class ServiceClass
        {
            get { return IExecuteWithSignature<Java.Lang.Class>("getServiceClass", "()Ljava/lang/Class;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContextServiceRevokedEvent.html#getSourceAsBeanContextServices()"/> 
        /// </summary>
        public Java.Beans.Beancontext.BeanContextServices SourceAsBeanContextServices
        {
            get { return IExecuteWithSignature<Java.Beans.Beancontext.BeanContextServices>("getSourceAsBeanContextServices", "()Ljava/beans/beancontext/BeanContextServices;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContextServiceRevokedEvent.html#isCurrentServiceInvalidNow()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsCurrentServiceInvalidNow()
        {
            return IExecuteWithSignature<bool>("isCurrentServiceInvalidNow", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContextServiceRevokedEvent.html#isServiceClass(java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsServiceClass(Java.Lang.Class arg0)
        {
            return IExecuteWithSignature<bool>("isServiceClass", "(Ljava/lang/Class;)Z", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}