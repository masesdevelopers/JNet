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
*  This file is generated by MASES.JNetReflector (ver. 2.5.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Lang
{
    #region ThreadGroup
    public partial class ThreadGroup
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ThreadGroup.html#%3Cinit%3E(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public ThreadGroup(Java.Lang.String arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ThreadGroup.html#%3Cinit%3E(java.lang.ThreadGroup,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.ThreadGroup"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        public ThreadGroup(Java.Lang.ThreadGroup arg0, Java.Lang.String arg1)
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ThreadGroup.html#getMaxPriority()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ThreadGroup.html#setMaxPriority(int)"/>
        /// </summary>
        public int MaxPriority
        {
            get { return IExecuteWithSignature<int>("getMaxPriority", "()I"); } set { IExecuteWithSignature("setMaxPriority", "(I)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ThreadGroup.html#getName()"/> 
        /// </summary>
        public Java.Lang.String Name
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getName", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ThreadGroup.html#getParent()"/> 
        /// </summary>
        public Java.Lang.ThreadGroup Parent
        {
            get { return IExecuteWithSignature<Java.Lang.ThreadGroup>("getParent", "()Ljava/lang/ThreadGroup;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ThreadGroup.html#isDaemon()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsDaemon()
        {
            return IExecuteWithSignature<bool>("isDaemon", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ThreadGroup.html#parentOf(java.lang.ThreadGroup)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.ThreadGroup"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool ParentOf(Java.Lang.ThreadGroup arg0)
        {
            return IExecuteWithSignature<bool>("parentOf", "(Ljava/lang/ThreadGroup;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ThreadGroup.html#checkAccess()"/>
        /// </summary>
        public void CheckAccess()
        {
            IExecuteWithSignature("checkAccess", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ThreadGroup.html#destroy()"/>
        /// </summary>
        public void Destroy()
        {
            IExecuteWithSignature("destroy", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ThreadGroup.html#interrupt()"/>
        /// </summary>
        public void Interrupt()
        {
            IExecuteWithSignature("interrupt", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ThreadGroup.html#setDaemon(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetDaemon(bool arg0)
        {
            IExecuteWithSignature("setDaemon", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ThreadGroup.html#activeCount()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int ActiveCount()
        {
            return IExecuteWithSignature<int>("activeCount", "()I");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ThreadGroup.html#activeGroupCount()"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int ActiveGroupCount()
        {
            return IExecuteWithSignature<int>("activeGroupCount", "()I");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ThreadGroup.html#enumerate(java.lang.Thread[],boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Thread"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <returns><see cref="int"/></returns>
        public int Enumerate(Java.Lang.Thread[] arg0, bool arg1)
        {
            return IExecute<int>("enumerate", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ThreadGroup.html#enumerate(java.lang.Thread[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Thread"/></param>
        /// <returns><see cref="int"/></returns>
        public int Enumerate(Java.Lang.Thread[] arg0)
        {
            return IExecuteWithSignature<int>("enumerate", "([Ljava/lang/Thread;)I", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ThreadGroup.html#enumerate(java.lang.ThreadGroup[],boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.ThreadGroup"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <returns><see cref="int"/></returns>
        public int Enumerate(Java.Lang.ThreadGroup[] arg0, bool arg1)
        {
            return IExecute<int>("enumerate", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ThreadGroup.html#enumerate(java.lang.ThreadGroup[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.ThreadGroup"/></param>
        /// <returns><see cref="int"/></returns>
        public int Enumerate(Java.Lang.ThreadGroup[] arg0)
        {
            return IExecuteWithSignature<int>("enumerate", "([Ljava/lang/ThreadGroup;)I", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ThreadGroup.html#isDestroyed()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsDestroyed()
        {
            return IExecuteWithSignature<bool>("isDestroyed", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ThreadGroup.html#list()"/>
        /// </summary>
        public void List()
        {
            IExecuteWithSignature("list", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/ThreadGroup.html#uncaughtException(java.lang.Thread,java.lang.Throwable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Thread"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Throwable"/></param>
        public void UncaughtException(Java.Lang.Thread arg0, MASES.JCOBridge.C2JBridge.JVMBridgeException arg1)
        {
            IExecute("uncaughtException", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}