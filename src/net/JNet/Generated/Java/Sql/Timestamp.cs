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

namespace Java.Sql
{
    #region Timestamp
    public partial class Timestamp
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Timestamp.html#%3Cinit%3E(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        public Timestamp(long arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Timestamp.html#valueOf(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Sql.Timestamp"/></returns>
        public static Java.Sql.Timestamp ValueOf(Java.Lang.String arg0)
        {
            return SExecute<Java.Sql.Timestamp>(LocalBridgeClazz, "valueOf", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Timestamp.html#valueOf(java.time.LocalDateTime)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Time.LocalDateTime"/></param>
        /// <returns><see cref="Java.Sql.Timestamp"/></returns>
        public static Java.Sql.Timestamp ValueOf(Java.Time.LocalDateTime arg0)
        {
            return SExecute<Java.Sql.Timestamp>(LocalBridgeClazz, "valueOf", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Timestamp.html#getNanos()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Timestamp.html#setNanos(int)"/>
        /// </summary>
        public int Nanos
        {
            get { return IExecute<int>("getNanos"); } set { IExecute("setNanos", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Timestamp.html#after(java.sql.Timestamp)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Sql.Timestamp"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool After(Java.Sql.Timestamp arg0)
        {
            return IExecute<bool>("after", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Timestamp.html#before(java.sql.Timestamp)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Sql.Timestamp"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Before(Java.Sql.Timestamp arg0)
        {
            return IExecute<bool>("before", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Timestamp.html#compareTo(java.sql.Timestamp)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Sql.Timestamp"/></param>
        /// <returns><see cref="int"/></returns>
        public int CompareTo(Java.Sql.Timestamp arg0)
        {
            return IExecute<int>("compareTo", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Timestamp.html#toLocalDateTime()"/>
        /// </summary>

        /// <returns><see cref="Java.Time.LocalDateTime"/></returns>
        public Java.Time.LocalDateTime ToLocalDateTime()
        {
            return IExecute<Java.Time.LocalDateTime>("toLocalDateTime");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}