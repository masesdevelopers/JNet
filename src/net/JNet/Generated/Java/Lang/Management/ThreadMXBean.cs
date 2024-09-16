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
*  This file is generated by MASES.JNetReflector (ver. 2.5.8.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Lang.Management
{
    #region ThreadMXBean declaration
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadMXBean.html"/>
    /// </summary>
    public partial class ThreadMXBean : Java.Lang.Management.PlatformManagedObject
    {
        const string _bridgeClassName = "java.lang.management.ThreadMXBean";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        [global::System.Obsolete("ThreadMXBean class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public ThreadMXBean() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        [global::System.Obsolete("ThreadMXBean class represents, in .NET, an instance of a JVM interface or abstract class. This public initializer is needed for JCOBridge internal use, other uses can produce unidentible behaviors.")]
        public ThreadMXBean(params object[] args) : base(args) { }

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
        public override bool IsBridgeInterface => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region IThreadMXBean
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IThreadMXBean : Java.Lang.Management.IPlatformManagedObject
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadMXBean.html#getAllThreadIds()"/> 
        /// </summary>
        long[] AllThreadIds { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadMXBean.html#getCurrentThreadCpuTime()"/> 
        /// </summary>
        long CurrentThreadCpuTime { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadMXBean.html#getCurrentThreadUserTime()"/> 
        /// </summary>
        long CurrentThreadUserTime { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadMXBean.html#getDaemonThreadCount()"/> 
        /// </summary>
        int DaemonThreadCount { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadMXBean.html#getPeakThreadCount()"/> 
        /// </summary>
        int PeakThreadCount { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadMXBean.html#getThreadCount()"/> 
        /// </summary>
        int ThreadCount { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadMXBean.html#getTotalStartedThreadCount()"/> 
        /// </summary>
        long TotalStartedThreadCount { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadMXBean.html#isCurrentThreadCpuTimeSupported()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        bool IsCurrentThreadCpuTimeSupported();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadMXBean.html#isObjectMonitorUsageSupported()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        bool IsObjectMonitorUsageSupported();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadMXBean.html#isSynchronizerUsageSupported()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        bool IsSynchronizerUsageSupported();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadMXBean.html#isThreadContentionMonitoringEnabled()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        bool IsThreadContentionMonitoringEnabled();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadMXBean.html#isThreadContentionMonitoringSupported()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        bool IsThreadContentionMonitoringSupported();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadMXBean.html#isThreadCpuTimeEnabled()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        bool IsThreadCpuTimeEnabled();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadMXBean.html#isThreadCpuTimeSupported()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        bool IsThreadCpuTimeSupported();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadMXBean.html#getThreadInfo(long,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.Management.ThreadInfo"/></returns>
        Java.Lang.Management.ThreadInfo GetThreadInfo(long arg0, int arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadMXBean.html#getThreadInfo(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Lang.Management.ThreadInfo"/></returns>
        Java.Lang.Management.ThreadInfo GetThreadInfo(long arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadMXBean.html#dumpAllThreads(boolean,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <returns><see cref="Java.Lang.Management.ThreadInfo"/></returns>
        Java.Lang.Management.ThreadInfo[] DumpAllThreads(bool arg0, bool arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadMXBean.html#getThreadInfo(long[],boolean,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        /// <returns><see cref="Java.Lang.Management.ThreadInfo"/></returns>
        Java.Lang.Management.ThreadInfo[] GetThreadInfo(long[] arg0, bool arg1, bool arg2);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadMXBean.html#getThreadInfo(long[],int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.Management.ThreadInfo"/></returns>
        Java.Lang.Management.ThreadInfo[] GetThreadInfo(long[] arg0, int arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadMXBean.html#getThreadInfo(long[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Lang.Management.ThreadInfo"/></returns>
        Java.Lang.Management.ThreadInfo[] GetThreadInfo(long[] arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadMXBean.html#getThreadCpuTime(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="long"/></returns>
        long GetThreadCpuTime(long arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadMXBean.html#getThreadUserTime(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="long"/></returns>
        long GetThreadUserTime(long arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadMXBean.html#findDeadlockedThreads()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        long[] FindDeadlockedThreads();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadMXBean.html#findMonitorDeadlockedThreads()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        long[] FindMonitorDeadlockedThreads();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadMXBean.html#resetPeakThreadCount()"/>
        /// </summary>
        void ResetPeakThreadCount();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadMXBean.html#setThreadContentionMonitoringEnabled(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        void SetThreadContentionMonitoringEnabled(bool arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadMXBean.html#setThreadCpuTimeEnabled(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        void SetThreadCpuTimeEnabled(bool arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadMXBean.html#dumpAllThreads(boolean,boolean,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.Management.ThreadInfo"/></returns>
        Java.Lang.Management.ThreadInfo[] DumpAllThreads(bool arg0, bool arg1, int arg2);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadMXBean.html#getThreadInfo(long[],boolean,boolean,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.Management.ThreadInfo"/></returns>
        Java.Lang.Management.ThreadInfo[] GetThreadInfo(long[] arg0, bool arg1, bool arg2, int arg3);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ThreadMXBean implementation
    public partial class ThreadMXBean : Java.Lang.Management.IThreadMXBean
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadMXBean.html#getAllThreadIds()"/> 
        /// </summary>
        public long[] AllThreadIds
        {
            get { return IExecuteWithSignatureArray<long>("getAllThreadIds", "()[J"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadMXBean.html#getCurrentThreadCpuTime()"/> 
        /// </summary>
        public long CurrentThreadCpuTime
        {
            get { return IExecuteWithSignature<long>("getCurrentThreadCpuTime", "()J"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadMXBean.html#getCurrentThreadUserTime()"/> 
        /// </summary>
        public long CurrentThreadUserTime
        {
            get { return IExecuteWithSignature<long>("getCurrentThreadUserTime", "()J"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadMXBean.html#getDaemonThreadCount()"/> 
        /// </summary>
        public int DaemonThreadCount
        {
            get { return IExecuteWithSignature<int>("getDaemonThreadCount", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadMXBean.html#getPeakThreadCount()"/> 
        /// </summary>
        public int PeakThreadCount
        {
            get { return IExecuteWithSignature<int>("getPeakThreadCount", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadMXBean.html#getThreadCount()"/> 
        /// </summary>
        public int ThreadCount
        {
            get { return IExecuteWithSignature<int>("getThreadCount", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadMXBean.html#getTotalStartedThreadCount()"/> 
        /// </summary>
        public long TotalStartedThreadCount
        {
            get { return IExecuteWithSignature<long>("getTotalStartedThreadCount", "()J"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadMXBean.html#isCurrentThreadCpuTimeSupported()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsCurrentThreadCpuTimeSupported()
        {
            return IExecuteWithSignature<bool>("isCurrentThreadCpuTimeSupported", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadMXBean.html#isObjectMonitorUsageSupported()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsObjectMonitorUsageSupported()
        {
            return IExecuteWithSignature<bool>("isObjectMonitorUsageSupported", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadMXBean.html#isSynchronizerUsageSupported()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsSynchronizerUsageSupported()
        {
            return IExecuteWithSignature<bool>("isSynchronizerUsageSupported", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadMXBean.html#isThreadContentionMonitoringEnabled()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsThreadContentionMonitoringEnabled()
        {
            return IExecuteWithSignature<bool>("isThreadContentionMonitoringEnabled", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadMXBean.html#isThreadContentionMonitoringSupported()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsThreadContentionMonitoringSupported()
        {
            return IExecuteWithSignature<bool>("isThreadContentionMonitoringSupported", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadMXBean.html#isThreadCpuTimeEnabled()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsThreadCpuTimeEnabled()
        {
            return IExecuteWithSignature<bool>("isThreadCpuTimeEnabled", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadMXBean.html#isThreadCpuTimeSupported()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsThreadCpuTimeSupported()
        {
            return IExecuteWithSignature<bool>("isThreadCpuTimeSupported", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadMXBean.html#getThreadInfo(long,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.Management.ThreadInfo"/></returns>
        public Java.Lang.Management.ThreadInfo GetThreadInfo(long arg0, int arg1)
        {
            return IExecute<Java.Lang.Management.ThreadInfo>("getThreadInfo", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadMXBean.html#getThreadInfo(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Lang.Management.ThreadInfo"/></returns>
        public Java.Lang.Management.ThreadInfo GetThreadInfo(long arg0)
        {
            return IExecuteWithSignature<Java.Lang.Management.ThreadInfo>("getThreadInfo", "(J)Ljava/lang/management/ThreadInfo;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadMXBean.html#dumpAllThreads(boolean,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <returns><see cref="Java.Lang.Management.ThreadInfo"/></returns>
        public Java.Lang.Management.ThreadInfo[] DumpAllThreads(bool arg0, bool arg1)
        {
            return IExecuteArray<Java.Lang.Management.ThreadInfo>("dumpAllThreads", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadMXBean.html#getThreadInfo(long[],boolean,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        /// <returns><see cref="Java.Lang.Management.ThreadInfo"/></returns>
        public Java.Lang.Management.ThreadInfo[] GetThreadInfo(long[] arg0, bool arg1, bool arg2)
        {
            return IExecuteArray<Java.Lang.Management.ThreadInfo>("getThreadInfo", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadMXBean.html#getThreadInfo(long[],int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.Management.ThreadInfo"/></returns>
        public Java.Lang.Management.ThreadInfo[] GetThreadInfo(long[] arg0, int arg1)
        {
            return IExecuteArray<Java.Lang.Management.ThreadInfo>("getThreadInfo", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadMXBean.html#getThreadInfo(long[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Lang.Management.ThreadInfo"/></returns>
        public Java.Lang.Management.ThreadInfo[] GetThreadInfo(long[] arg0)
        {
            return IExecuteWithSignatureArray<Java.Lang.Management.ThreadInfo>("getThreadInfo", "([J)[Ljava/lang/management/ThreadInfo;", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadMXBean.html#getThreadCpuTime(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="long"/></returns>
        public long GetThreadCpuTime(long arg0)
        {
            return IExecuteWithSignature<long>("getThreadCpuTime", "(J)J", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadMXBean.html#getThreadUserTime(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="long"/></returns>
        public long GetThreadUserTime(long arg0)
        {
            return IExecuteWithSignature<long>("getThreadUserTime", "(J)J", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadMXBean.html#findDeadlockedThreads()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long[] FindDeadlockedThreads()
        {
            return IExecuteWithSignatureArray<long>("findDeadlockedThreads", "()[J");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadMXBean.html#findMonitorDeadlockedThreads()"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long[] FindMonitorDeadlockedThreads()
        {
            return IExecuteWithSignatureArray<long>("findMonitorDeadlockedThreads", "()[J");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadMXBean.html#resetPeakThreadCount()"/>
        /// </summary>
        public void ResetPeakThreadCount()
        {
            IExecuteWithSignature("resetPeakThreadCount", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadMXBean.html#setThreadContentionMonitoringEnabled(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetThreadContentionMonitoringEnabled(bool arg0)
        {
            IExecuteWithSignature("setThreadContentionMonitoringEnabled", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadMXBean.html#setThreadCpuTimeEnabled(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetThreadCpuTimeEnabled(bool arg0)
        {
            IExecuteWithSignature("setThreadCpuTimeEnabled", "(Z)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadMXBean.html#dumpAllThreads(boolean,boolean,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.Management.ThreadInfo"/></returns>
        public Java.Lang.Management.ThreadInfo[] DumpAllThreads(bool arg0, bool arg1, int arg2)
        {
            return IExecuteArray<Java.Lang.Management.ThreadInfo>("dumpAllThreads", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/ThreadMXBean.html#getThreadInfo(long[],boolean,boolean,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.Management.ThreadInfo"/></returns>
        public Java.Lang.Management.ThreadInfo[] GetThreadInfo(long[] arg0, bool arg1, bool arg2, int arg3)
        {
            return IExecuteArray<Java.Lang.Management.ThreadInfo>("getThreadInfo", arg0, arg1, arg2, arg3);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}