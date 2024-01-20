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
*  This file is generated by MASES.JNetReflector (ver. 2.2.1.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Sound.Sampled
{
    #region ReverbType
    public partial class ReverbType
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/ReverbType.html#getDecayTime()"/> 
        /// </summary>
        public int DecayTime
        {
            get { return IExecute<int>("getDecayTime"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/ReverbType.html#getEarlyReflectionDelay()"/> 
        /// </summary>
        public int EarlyReflectionDelay
        {
            get { return IExecute<int>("getEarlyReflectionDelay"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/ReverbType.html#getEarlyReflectionIntensity()"/> 
        /// </summary>
        public float EarlyReflectionIntensity
        {
            get { return IExecute<float>("getEarlyReflectionIntensity"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/ReverbType.html#getLateReflectionDelay()"/> 
        /// </summary>
        public int LateReflectionDelay
        {
            get { return IExecute<int>("getLateReflectionDelay"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/ReverbType.html#getLateReflectionIntensity()"/> 
        /// </summary>
        public float LateReflectionIntensity
        {
            get { return IExecute<float>("getLateReflectionIntensity"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/sound/sampled/ReverbType.html#getName()"/> 
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