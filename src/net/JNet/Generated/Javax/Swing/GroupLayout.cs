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

namespace Javax.Swing
{
    #region GroupLayout
    public partial class GroupLayout
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/GroupLayout.html#%3Cinit%3E(java.awt.Container)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Container"/></param>
        public GroupLayout(Java.Awt.Container arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/GroupLayout.html#DEFAULT_SIZE"/>
        /// </summary>
        public static int DEFAULT_SIZE { get { if (!_DEFAULT_SIZEReady) { _DEFAULT_SIZEContent = SGetField<int>(LocalBridgeClazz, "DEFAULT_SIZE"); _DEFAULT_SIZEReady = true; } return _DEFAULT_SIZEContent; } }
        private static int _DEFAULT_SIZEContent = default;
        private static bool _DEFAULT_SIZEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/GroupLayout.html#PREFERRED_SIZE"/>
        /// </summary>
        public static int PREFERRED_SIZE { get { if (!_PREFERRED_SIZEReady) { _PREFERRED_SIZEContent = SGetField<int>(LocalBridgeClazz, "PREFERRED_SIZE"); _PREFERRED_SIZEReady = true; } return _PREFERRED_SIZEContent; } }
        private static int _PREFERRED_SIZEContent = default;
        private static bool _PREFERRED_SIZEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/GroupLayout.html#getAutoCreateContainerGaps()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/GroupLayout.html#setAutoCreateContainerGaps(boolean)"/>
        /// </summary>
        public bool AutoCreateContainerGaps
        {
            get { return IExecuteWithSignature<bool>("getAutoCreateContainerGaps", "()Z"); } set { IExecuteWithSignature("setAutoCreateContainerGaps", "(Z)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/GroupLayout.html#getAutoCreateGaps()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/GroupLayout.html#setAutoCreateGaps(boolean)"/>
        /// </summary>
        public bool AutoCreateGaps
        {
            get { return IExecuteWithSignature<bool>("getAutoCreateGaps", "()Z"); } set { IExecuteWithSignature("setAutoCreateGaps", "(Z)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/GroupLayout.html#getHonorsVisibility()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/GroupLayout.html#setHonorsVisibility(boolean)"/>
        /// </summary>
        public bool HonorsVisibility
        {
            get { return IExecuteWithSignature<bool>("getHonorsVisibility", "()Z"); } set { IExecuteWithSignature("setHonorsVisibility", "(Z)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/GroupLayout.html#getLayoutStyle()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/GroupLayout.html#setLayoutStyle(javax.swing.LayoutStyle)"/>
        /// </summary>
        public Javax.Swing.LayoutStyle LayoutStyle
        {
            get { return IExecuteWithSignature<Javax.Swing.LayoutStyle>("getLayoutStyle", "()Ljavax/swing/LayoutStyle;"); } set { IExecuteWithSignature("setLayoutStyle", "(Ljavax/swing/LayoutStyle;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/GroupLayout.html#getLayoutAlignmentX(java.awt.Container)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Container"/></param>
        /// <returns><see cref="float"/></returns>
        public float GetLayoutAlignmentX(Java.Awt.Container arg0)
        {
            return IExecuteWithSignature<float>("getLayoutAlignmentX", "(Ljava/awt/Container;)F", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/GroupLayout.html#getLayoutAlignmentY(java.awt.Container)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Container"/></param>
        /// <returns><see cref="float"/></returns>
        public float GetLayoutAlignmentY(Java.Awt.Container arg0)
        {
            return IExecuteWithSignature<float>("getLayoutAlignmentY", "(Ljava/awt/Container;)F", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/GroupLayout.html#maximumLayoutSize(java.awt.Container)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Container"/></param>
        /// <returns><see cref="Java.Awt.Dimension"/></returns>
        public Java.Awt.Dimension MaximumLayoutSize(Java.Awt.Container arg0)
        {
            return IExecuteWithSignature<Java.Awt.Dimension>("maximumLayoutSize", "(Ljava/awt/Container;)Ljava/awt/Dimension;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/GroupLayout.html#minimumLayoutSize(java.awt.Container)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Container"/></param>
        /// <returns><see cref="Java.Awt.Dimension"/></returns>
        public Java.Awt.Dimension MinimumLayoutSize(Java.Awt.Container arg0)
        {
            return IExecuteWithSignature<Java.Awt.Dimension>("minimumLayoutSize", "(Ljava/awt/Container;)Ljava/awt/Dimension;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/GroupLayout.html#preferredLayoutSize(java.awt.Container)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Container"/></param>
        /// <returns><see cref="Java.Awt.Dimension"/></returns>
        public Java.Awt.Dimension PreferredLayoutSize(Java.Awt.Container arg0)
        {
            return IExecuteWithSignature<Java.Awt.Dimension>("preferredLayoutSize", "(Ljava/awt/Container;)Ljava/awt/Dimension;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/GroupLayout.html#createBaselineGroup(boolean,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <returns><see cref="Javax.Swing.GroupLayout.ParallelGroup"/></returns>
        public Javax.Swing.GroupLayout.ParallelGroup CreateBaselineGroup(bool arg0, bool arg1)
        {
            return IExecute<Javax.Swing.GroupLayout.ParallelGroup>("createBaselineGroup", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/GroupLayout.html#createParallelGroup()"/>
        /// </summary>
        /// <returns><see cref="Javax.Swing.GroupLayout.ParallelGroup"/></returns>
        public Javax.Swing.GroupLayout.ParallelGroup CreateParallelGroup()
        {
            return IExecuteWithSignature<Javax.Swing.GroupLayout.ParallelGroup>("createParallelGroup", "()Ljavax/swing/GroupLayout$ParallelGroup;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/GroupLayout.html#createParallelGroup(javax.swing.GroupLayout.Alignment,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.GroupLayout.Alignment"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <returns><see cref="Javax.Swing.GroupLayout.ParallelGroup"/></returns>
        public Javax.Swing.GroupLayout.ParallelGroup CreateParallelGroup(Javax.Swing.GroupLayout.Alignment arg0, bool arg1)
        {
            return IExecute<Javax.Swing.GroupLayout.ParallelGroup>("createParallelGroup", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/GroupLayout.html#createParallelGroup(javax.swing.GroupLayout.Alignment)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.GroupLayout.Alignment"/></param>
        /// <returns><see cref="Javax.Swing.GroupLayout.ParallelGroup"/></returns>
        public Javax.Swing.GroupLayout.ParallelGroup CreateParallelGroup(Javax.Swing.GroupLayout.Alignment arg0)
        {
            return IExecuteWithSignature<Javax.Swing.GroupLayout.ParallelGroup>("createParallelGroup", "(Ljavax/swing/GroupLayout$Alignment;)Ljavax/swing/GroupLayout$ParallelGroup;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/GroupLayout.html#createSequentialGroup()"/>
        /// </summary>
        /// <returns><see cref="Javax.Swing.GroupLayout.SequentialGroup"/></returns>
        public Javax.Swing.GroupLayout.SequentialGroup CreateSequentialGroup()
        {
            return IExecuteWithSignature<Javax.Swing.GroupLayout.SequentialGroup>("createSequentialGroup", "()Ljavax/swing/GroupLayout$SequentialGroup;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/GroupLayout.html#addLayoutComponent(java.awt.Component,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        public void AddLayoutComponent(Java.Awt.Component arg0, object arg1)
        {
            IExecute("addLayoutComponent", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/GroupLayout.html#addLayoutComponent(java.lang.String,java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Component"/></param>
        public void AddLayoutComponent(Java.Lang.String arg0, Java.Awt.Component arg1)
        {
            IExecute("addLayoutComponent", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/GroupLayout.html#invalidateLayout(java.awt.Container)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Container"/></param>
        public void InvalidateLayout(Java.Awt.Container arg0)
        {
            IExecuteWithSignature("invalidateLayout", "(Ljava/awt/Container;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/GroupLayout.html#layoutContainer(java.awt.Container)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Container"/></param>
        public void LayoutContainer(Java.Awt.Container arg0)
        {
            IExecuteWithSignature("layoutContainer", "(Ljava/awt/Container;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/GroupLayout.html#linkSize(int,java.awt.Component[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Component"/></param>
        public void LinkSize(int arg0, params Java.Awt.Component[] arg1)
        {
            if (arg1.Length == 0) IExecute("linkSize", arg0); else IExecute("linkSize", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/GroupLayout.html#linkSize(java.awt.Component[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        public void LinkSize(params Java.Awt.Component[] arg0)
        {
            if (arg0.Length == 0) IExecuteWithSignature("linkSize", "([Ljava/awt/Component;)V"); else IExecuteWithSignature("linkSize", "([Ljava/awt/Component;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/GroupLayout.html#removeLayoutComponent(java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        public void RemoveLayoutComponent(Java.Awt.Component arg0)
        {
            IExecuteWithSignature("removeLayoutComponent", "(Ljava/awt/Component;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/GroupLayout.html#replace(java.awt.Component,java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Component"/></param>
        public void Replace(Java.Awt.Component arg0, Java.Awt.Component arg1)
        {
            IExecute("replace", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/GroupLayout.html#setHonorsVisibility(java.awt.Component,java.lang.Boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Boolean"/></param>
        public void SetHonorsVisibility(Java.Awt.Component arg0, Java.Lang.Boolean arg1)
        {
            IExecute("setHonorsVisibility", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/GroupLayout.html#setHorizontalGroup(javax.swing.GroupLayout.Group)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.GroupLayout.Group"/></param>
        public void SetHorizontalGroup(Javax.Swing.GroupLayout.Group arg0)
        {
            IExecuteWithSignature("setHorizontalGroup", "(Ljavax/swing/GroupLayout$Group;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/GroupLayout.html#setVerticalGroup(javax.swing.GroupLayout.Group)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.GroupLayout.Group"/></param>
        public void SetVerticalGroup(Javax.Swing.GroupLayout.Group arg0)
        {
            IExecuteWithSignature("setVerticalGroup", "(Ljavax/swing/GroupLayout$Group;)V", arg0);
        }

        #endregion

        #region Nested classes
        #region Alignment
        public partial class Alignment
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/GroupLayout.Alignment.html#BASELINE"/>
            /// </summary>
            public static Javax.Swing.GroupLayout.Alignment BASELINE { get { if (!_BASELINEReady) { _BASELINEContent = SGetField<Javax.Swing.GroupLayout.Alignment>(LocalBridgeClazz, "BASELINE"); _BASELINEReady = true; } return _BASELINEContent; } }
            private static Javax.Swing.GroupLayout.Alignment _BASELINEContent = default;
            private static bool _BASELINEReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/GroupLayout.Alignment.html#CENTER"/>
            /// </summary>
            public static Javax.Swing.GroupLayout.Alignment CENTER { get { if (!_CENTERReady) { _CENTERContent = SGetField<Javax.Swing.GroupLayout.Alignment>(LocalBridgeClazz, "CENTER"); _CENTERReady = true; } return _CENTERContent; } }
            private static Javax.Swing.GroupLayout.Alignment _CENTERContent = default;
            private static bool _CENTERReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/GroupLayout.Alignment.html#LEADING"/>
            /// </summary>
            public static Javax.Swing.GroupLayout.Alignment LEADING { get { if (!_LEADINGReady) { _LEADINGContent = SGetField<Javax.Swing.GroupLayout.Alignment>(LocalBridgeClazz, "LEADING"); _LEADINGReady = true; } return _LEADINGContent; } }
            private static Javax.Swing.GroupLayout.Alignment _LEADINGContent = default;
            private static bool _LEADINGReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/GroupLayout.Alignment.html#TRAILING"/>
            /// </summary>
            public static Javax.Swing.GroupLayout.Alignment TRAILING { get { if (!_TRAILINGReady) { _TRAILINGContent = SGetField<Javax.Swing.GroupLayout.Alignment>(LocalBridgeClazz, "TRAILING"); _TRAILINGReady = true; } return _TRAILINGContent; } }
            private static Javax.Swing.GroupLayout.Alignment _TRAILINGContent = default;
            private static bool _TRAILINGReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/GroupLayout.Alignment.html#valueOf(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Javax.Swing.GroupLayout.Alignment"/></returns>
            public static Javax.Swing.GroupLayout.Alignment ValueOf(Java.Lang.String arg0)
            {
                return SExecuteWithSignature<Javax.Swing.GroupLayout.Alignment>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Ljavax/swing/GroupLayout$Alignment;", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/GroupLayout.Alignment.html#values()"/>
            /// </summary>
            /// <returns><see cref="Javax.Swing.GroupLayout.Alignment"/></returns>
            public static Javax.Swing.GroupLayout.Alignment[] Values()
            {
                return SExecuteWithSignatureArray<Javax.Swing.GroupLayout.Alignment>(LocalBridgeClazz, "values", "()[Ljavax/swing/GroupLayout$Alignment;");
            }

            #endregion

            #region Instance methods

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region Group
        public partial class Group
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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/GroupLayout.Group.html#addComponent(java.awt.Component,int,int,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <param name="arg2"><see cref="int"/></param>
            /// <param name="arg3"><see cref="int"/></param>
            /// <returns><see cref="Javax.Swing.GroupLayout.Group"/></returns>
            public Javax.Swing.GroupLayout.Group AddComponent(Java.Awt.Component arg0, int arg1, int arg2, int arg3)
            {
                return IExecute<Javax.Swing.GroupLayout.Group>("addComponent", arg0, arg1, arg2, arg3);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/GroupLayout.Group.html#addComponent(java.awt.Component)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
            /// <returns><see cref="Javax.Swing.GroupLayout.Group"/></returns>
            public Javax.Swing.GroupLayout.Group AddComponent(Java.Awt.Component arg0)
            {
                return IExecuteWithSignature<Javax.Swing.GroupLayout.Group>("addComponent", "(Ljava/awt/Component;)Ljavax/swing/GroupLayout$Group;", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/GroupLayout.Group.html#addGap(int,int,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <param name="arg2"><see cref="int"/></param>
            /// <returns><see cref="Javax.Swing.GroupLayout.Group"/></returns>
            public Javax.Swing.GroupLayout.Group AddGap(int arg0, int arg1, int arg2)
            {
                return IExecute<Javax.Swing.GroupLayout.Group>("addGap", arg0, arg1, arg2);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/GroupLayout.Group.html#addGap(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Javax.Swing.GroupLayout.Group"/></returns>
            public Javax.Swing.GroupLayout.Group AddGap(int arg0)
            {
                return IExecuteWithSignature<Javax.Swing.GroupLayout.Group>("addGap", "(I)Ljavax/swing/GroupLayout$Group;", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/GroupLayout.Group.html#addGroup(javax.swing.GroupLayout.Group)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.GroupLayout.Group"/></param>
            /// <returns><see cref="Javax.Swing.GroupLayout.Group"/></returns>
            public Javax.Swing.GroupLayout.Group AddGroup(Javax.Swing.GroupLayout.Group arg0)
            {
                return IExecuteWithSignature<Javax.Swing.GroupLayout.Group>("addGroup", "(Ljavax/swing/GroupLayout$Group;)Ljavax/swing/GroupLayout$Group;", arg0);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region ParallelGroup
        public partial class ParallelGroup
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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/GroupLayout.ParallelGroup.html#addComponent(java.awt.Component,javax.swing.GroupLayout.Alignment,int,int,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
            /// <param name="arg1"><see cref="Javax.Swing.GroupLayout.Alignment"/></param>
            /// <param name="arg2"><see cref="int"/></param>
            /// <param name="arg3"><see cref="int"/></param>
            /// <param name="arg4"><see cref="int"/></param>
            /// <returns><see cref="Javax.Swing.GroupLayout.ParallelGroup"/></returns>
            public Javax.Swing.GroupLayout.ParallelGroup AddComponent(Java.Awt.Component arg0, Javax.Swing.GroupLayout.Alignment arg1, int arg2, int arg3, int arg4)
            {
                return IExecute<Javax.Swing.GroupLayout.ParallelGroup>("addComponent", arg0, arg1, arg2, arg3, arg4);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/GroupLayout.ParallelGroup.html#addComponent(java.awt.Component,javax.swing.GroupLayout.Alignment)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
            /// <param name="arg1"><see cref="Javax.Swing.GroupLayout.Alignment"/></param>
            /// <returns><see cref="Javax.Swing.GroupLayout.ParallelGroup"/></returns>
            public Javax.Swing.GroupLayout.ParallelGroup AddComponent(Java.Awt.Component arg0, Javax.Swing.GroupLayout.Alignment arg1)
            {
                return IExecute<Javax.Swing.GroupLayout.ParallelGroup>("addComponent", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/GroupLayout.ParallelGroup.html#addGroup(javax.swing.GroupLayout.Alignment,javax.swing.GroupLayout.Group)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.GroupLayout.Alignment"/></param>
            /// <param name="arg1"><see cref="Javax.Swing.GroupLayout.Group"/></param>
            /// <returns><see cref="Javax.Swing.GroupLayout.ParallelGroup"/></returns>
            public Javax.Swing.GroupLayout.ParallelGroup AddGroup(Javax.Swing.GroupLayout.Alignment arg0, Javax.Swing.GroupLayout.Group arg1)
            {
                return IExecute<Javax.Swing.GroupLayout.ParallelGroup>("addGroup", arg0, arg1);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region SequentialGroup
        public partial class SequentialGroup
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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/GroupLayout.SequentialGroup.html#addComponent(boolean,java.awt.Component,int,int,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <param name="arg1"><see cref="Java.Awt.Component"/></param>
            /// <param name="arg2"><see cref="int"/></param>
            /// <param name="arg3"><see cref="int"/></param>
            /// <param name="arg4"><see cref="int"/></param>
            /// <returns><see cref="Javax.Swing.GroupLayout.SequentialGroup"/></returns>
            public Javax.Swing.GroupLayout.SequentialGroup AddComponent(bool arg0, Java.Awt.Component arg1, int arg2, int arg3, int arg4)
            {
                return IExecute<Javax.Swing.GroupLayout.SequentialGroup>("addComponent", arg0, arg1, arg2, arg3, arg4);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/GroupLayout.SequentialGroup.html#addComponent(boolean,java.awt.Component)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <param name="arg1"><see cref="Java.Awt.Component"/></param>
            /// <returns><see cref="Javax.Swing.GroupLayout.SequentialGroup"/></returns>
            public Javax.Swing.GroupLayout.SequentialGroup AddComponent(bool arg0, Java.Awt.Component arg1)
            {
                return IExecute<Javax.Swing.GroupLayout.SequentialGroup>("addComponent", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/GroupLayout.SequentialGroup.html#addContainerGap()"/>
            /// </summary>
            /// <returns><see cref="Javax.Swing.GroupLayout.SequentialGroup"/></returns>
            public Javax.Swing.GroupLayout.SequentialGroup AddContainerGap()
            {
                return IExecuteWithSignature<Javax.Swing.GroupLayout.SequentialGroup>("addContainerGap", "()Ljavax/swing/GroupLayout$SequentialGroup;");
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/GroupLayout.SequentialGroup.html#addContainerGap(int,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <returns><see cref="Javax.Swing.GroupLayout.SequentialGroup"/></returns>
            public Javax.Swing.GroupLayout.SequentialGroup AddContainerGap(int arg0, int arg1)
            {
                return IExecute<Javax.Swing.GroupLayout.SequentialGroup>("addContainerGap", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/GroupLayout.SequentialGroup.html#addGroup(boolean,javax.swing.GroupLayout.Group)"/>
            /// </summary>
            /// <param name="arg0"><see cref="bool"/></param>
            /// <param name="arg1"><see cref="Javax.Swing.GroupLayout.Group"/></param>
            /// <returns><see cref="Javax.Swing.GroupLayout.SequentialGroup"/></returns>
            public Javax.Swing.GroupLayout.SequentialGroup AddGroup(bool arg0, Javax.Swing.GroupLayout.Group arg1)
            {
                return IExecute<Javax.Swing.GroupLayout.SequentialGroup>("addGroup", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/GroupLayout.SequentialGroup.html#addPreferredGap(javax.swing.JComponent,javax.swing.JComponent,javax.swing.LayoutStyle.ComponentPlacement,int,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.JComponent"/></param>
            /// <param name="arg1"><see cref="Javax.Swing.JComponent"/></param>
            /// <param name="arg2"><see cref="Javax.Swing.LayoutStyle.ComponentPlacement"/></param>
            /// <param name="arg3"><see cref="int"/></param>
            /// <param name="arg4"><see cref="int"/></param>
            /// <returns><see cref="Javax.Swing.GroupLayout.SequentialGroup"/></returns>
            public Javax.Swing.GroupLayout.SequentialGroup AddPreferredGap(Javax.Swing.JComponent arg0, Javax.Swing.JComponent arg1, Javax.Swing.LayoutStyle.ComponentPlacement arg2, int arg3, int arg4)
            {
                return IExecute<Javax.Swing.GroupLayout.SequentialGroup>("addPreferredGap", arg0, arg1, arg2, arg3, arg4);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/GroupLayout.SequentialGroup.html#addPreferredGap(javax.swing.JComponent,javax.swing.JComponent,javax.swing.LayoutStyle.ComponentPlacement)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.JComponent"/></param>
            /// <param name="arg1"><see cref="Javax.Swing.JComponent"/></param>
            /// <param name="arg2"><see cref="Javax.Swing.LayoutStyle.ComponentPlacement"/></param>
            /// <returns><see cref="Javax.Swing.GroupLayout.SequentialGroup"/></returns>
            public Javax.Swing.GroupLayout.SequentialGroup AddPreferredGap(Javax.Swing.JComponent arg0, Javax.Swing.JComponent arg1, Javax.Swing.LayoutStyle.ComponentPlacement arg2)
            {
                return IExecute<Javax.Swing.GroupLayout.SequentialGroup>("addPreferredGap", arg0, arg1, arg2);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/GroupLayout.SequentialGroup.html#addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement,int,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.LayoutStyle.ComponentPlacement"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <param name="arg2"><see cref="int"/></param>
            /// <returns><see cref="Javax.Swing.GroupLayout.SequentialGroup"/></returns>
            public Javax.Swing.GroupLayout.SequentialGroup AddPreferredGap(Javax.Swing.LayoutStyle.ComponentPlacement arg0, int arg1, int arg2)
            {
                return IExecute<Javax.Swing.GroupLayout.SequentialGroup>("addPreferredGap", arg0, arg1, arg2);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/GroupLayout.SequentialGroup.html#addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.LayoutStyle.ComponentPlacement"/></param>
            /// <returns><see cref="Javax.Swing.GroupLayout.SequentialGroup"/></returns>
            public Javax.Swing.GroupLayout.SequentialGroup AddPreferredGap(Javax.Swing.LayoutStyle.ComponentPlacement arg0)
            {
                return IExecuteWithSignature<Javax.Swing.GroupLayout.SequentialGroup>("addPreferredGap", "(Ljavax/swing/LayoutStyle$ComponentPlacement;)Ljavax/swing/GroupLayout$SequentialGroup;", arg0);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

    
        #endregion

        // TODO: complete the class
    }
    #endregion
}