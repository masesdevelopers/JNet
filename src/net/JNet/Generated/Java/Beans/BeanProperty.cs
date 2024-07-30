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
*  This file is generated by MASES.JNetReflector (ver. 2.5.7.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Beans
{
    #region IBeanProperty
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IBeanProperty : Java.Lang.Annotation.IAnnotation
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/BeanProperty.html#bound()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        bool Bound();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/BeanProperty.html#expert()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        bool Expert();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/BeanProperty.html#hidden()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        bool Hidden();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/BeanProperty.html#preferred()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        bool Preferred();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/BeanProperty.html#required()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        bool Required();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/BeanProperty.html#visualUpdate()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        bool VisualUpdate();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/BeanProperty.html#description()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        Java.Lang.String Description();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/BeanProperty.html#enumerationValues()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        Java.Lang.String[] EnumerationValues();

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region BeanProperty
    public partial class BeanProperty : Java.Beans.IBeanProperty
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/BeanProperty.html#bound()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool Bound()
        {
            return IExecuteWithSignature<bool>("bound", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/BeanProperty.html#expert()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool Expert()
        {
            return IExecuteWithSignature<bool>("expert", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/BeanProperty.html#hidden()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool Hidden()
        {
            return IExecuteWithSignature<bool>("hidden", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/BeanProperty.html#preferred()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool Preferred()
        {
            return IExecuteWithSignature<bool>("preferred", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/BeanProperty.html#required()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool Required()
        {
            return IExecuteWithSignature<bool>("required", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/BeanProperty.html#visualUpdate()"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool VisualUpdate()
        {
            return IExecuteWithSignature<bool>("visualUpdate", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/BeanProperty.html#description()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String Description()
        {
            return IExecuteWithSignature<Java.Lang.String>("description", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/BeanProperty.html#enumerationValues()"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String[] EnumerationValues()
        {
            return IExecuteWithSignatureArray<Java.Lang.String>("enumerationValues", "()[Ljava/lang/String;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}