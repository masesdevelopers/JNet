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
    #region IRuntimeMXBean
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IRuntimeMXBean : Java.Lang.Management.IPlatformManagedObject
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/RuntimeMXBean.html#getBootClassPath()"/> 
        /// </summary>
        Java.Lang.String BootClassPath { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/RuntimeMXBean.html#getClassPath()"/> 
        /// </summary>
        Java.Lang.String ClassPath { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/RuntimeMXBean.html#getInputArguments()"/> 
        /// </summary>
        Java.Util.List<Java.Lang.String> InputArguments { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/RuntimeMXBean.html#getLibraryPath()"/> 
        /// </summary>
        Java.Lang.String LibraryPath { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/RuntimeMXBean.html#getManagementSpecVersion()"/> 
        /// </summary>
        Java.Lang.String ManagementSpecVersion { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/RuntimeMXBean.html#getName()"/> 
        /// </summary>
        Java.Lang.String Name { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/RuntimeMXBean.html#getPid()"/> 
        /// </summary>
        long Pid { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/RuntimeMXBean.html#getSpecName()"/> 
        /// </summary>
        Java.Lang.String SpecName { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/RuntimeMXBean.html#getSpecVendor()"/> 
        /// </summary>
        Java.Lang.String SpecVendor { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/RuntimeMXBean.html#getSpecVersion()"/> 
        /// </summary>
        Java.Lang.String SpecVersion { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/RuntimeMXBean.html#getStartTime()"/> 
        /// </summary>
        long StartTime { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/RuntimeMXBean.html#getSystemProperties()"/> 
        /// </summary>
        Java.Util.Map<Java.Lang.String, Java.Lang.String> SystemProperties { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/RuntimeMXBean.html#getUptime()"/> 
        /// </summary>
        long Uptime { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/RuntimeMXBean.html#getVmName()"/> 
        /// </summary>
        Java.Lang.String VmName { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/RuntimeMXBean.html#getVmVendor()"/> 
        /// </summary>
        Java.Lang.String VmVendor { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/RuntimeMXBean.html#getVmVersion()"/> 
        /// </summary>
        Java.Lang.String VmVersion { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/RuntimeMXBean.html#isBootClassPathSupported()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        bool IsBootClassPathSupported();

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region RuntimeMXBean
    public partial class RuntimeMXBean : Java.Lang.Management.IRuntimeMXBean
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/RuntimeMXBean.html#getBootClassPath()"/> 
        /// </summary>
        public Java.Lang.String BootClassPath
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getBootClassPath", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/RuntimeMXBean.html#getClassPath()"/> 
        /// </summary>
        public Java.Lang.String ClassPath
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getClassPath", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/RuntimeMXBean.html#getInputArguments()"/> 
        /// </summary>
        public Java.Util.List<Java.Lang.String> InputArguments
        {
            get { return IExecuteWithSignature<Java.Util.List<Java.Lang.String>>("getInputArguments", "()Ljava/util/List;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/RuntimeMXBean.html#getLibraryPath()"/> 
        /// </summary>
        public Java.Lang.String LibraryPath
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getLibraryPath", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/RuntimeMXBean.html#getManagementSpecVersion()"/> 
        /// </summary>
        public Java.Lang.String ManagementSpecVersion
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getManagementSpecVersion", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/RuntimeMXBean.html#getName()"/> 
        /// </summary>
        public Java.Lang.String Name
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getName", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/RuntimeMXBean.html#getPid()"/> 
        /// </summary>
        public long Pid
        {
            get { return IExecuteWithSignature<long>("getPid", "()J"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/RuntimeMXBean.html#getSpecName()"/> 
        /// </summary>
        public Java.Lang.String SpecName
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getSpecName", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/RuntimeMXBean.html#getSpecVendor()"/> 
        /// </summary>
        public Java.Lang.String SpecVendor
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getSpecVendor", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/RuntimeMXBean.html#getSpecVersion()"/> 
        /// </summary>
        public Java.Lang.String SpecVersion
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getSpecVersion", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/RuntimeMXBean.html#getStartTime()"/> 
        /// </summary>
        public long StartTime
        {
            get { return IExecuteWithSignature<long>("getStartTime", "()J"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/RuntimeMXBean.html#getSystemProperties()"/> 
        /// </summary>
        public Java.Util.Map<Java.Lang.String, Java.Lang.String> SystemProperties
        {
            get { return IExecuteWithSignature<Java.Util.Map<Java.Lang.String, Java.Lang.String>>("getSystemProperties", "()Ljava/util/Map;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/RuntimeMXBean.html#getUptime()"/> 
        /// </summary>
        public long Uptime
        {
            get { return IExecuteWithSignature<long>("getUptime", "()J"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/RuntimeMXBean.html#getVmName()"/> 
        /// </summary>
        public Java.Lang.String VmName
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getVmName", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/RuntimeMXBean.html#getVmVendor()"/> 
        /// </summary>
        public Java.Lang.String VmVendor
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getVmVendor", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/RuntimeMXBean.html#getVmVersion()"/> 
        /// </summary>
        public Java.Lang.String VmVersion
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getVmVersion", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/java/lang/management/RuntimeMXBean.html#isBootClassPathSupported()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsBootClassPathSupported()
        {
            return IExecuteWithSignature<bool>("isBootClassPathSupported", "()Z");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}