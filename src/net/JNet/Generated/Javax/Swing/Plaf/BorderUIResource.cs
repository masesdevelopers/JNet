/*
*  Copyright 2023 MASES s.r.l.
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
*  This file is generated by MASES.JNetReflector (ver. 1.5.4.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Swing.Plaf
{
    #region BorderUIResource
    public partial class BorderUIResource
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/BorderUIResource.html#%3Cinit%3E(javax.swing.border.Border)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Border.Border"/></param>
        public BorderUIResource(Javax.Swing.Border.Border arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Swing.Plaf.BorderUIResource"/> to <see cref="Javax.Swing.Border.Border"/>
        /// </summary>
        public static implicit operator Javax.Swing.Border.Border(Javax.Swing.Plaf.BorderUIResource t) => t.Cast<Javax.Swing.Border.Border>();
        /// <summary>
        /// Converter from <see cref="Javax.Swing.Plaf.BorderUIResource"/> to <see cref="Javax.Swing.Plaf.UIResource"/>
        /// </summary>
        public static implicit operator Javax.Swing.Plaf.UIResource(Javax.Swing.Plaf.BorderUIResource t) => t.Cast<Javax.Swing.Plaf.UIResource>();
        /// <summary>
        /// Converter from <see cref="Javax.Swing.Plaf.BorderUIResource"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Javax.Swing.Plaf.BorderUIResource t) => t.Cast<Java.Io.Serializable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/BorderUIResource.html#getBlackLineBorderUIResource()"/> 
        /// </summary>
        public static Javax.Swing.Border.Border BlackLineBorderUIResource
        {
            get { return SExecute<Javax.Swing.Border.Border>(LocalClazz, "getBlackLineBorderUIResource"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/BorderUIResource.html#getEtchedBorderUIResource()"/> 
        /// </summary>
        public static Javax.Swing.Border.Border GetEtchedBorderUIResource
        {
            get { return SExecute<Javax.Swing.Border.Border>(LocalClazz, "getEtchedBorderUIResource"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/BorderUIResource.html#getLoweredBevelBorderUIResource()"/> 
        /// </summary>
        public static Javax.Swing.Border.Border LoweredBevelBorderUIResource
        {
            get { return SExecute<Javax.Swing.Border.Border>(LocalClazz, "getLoweredBevelBorderUIResource"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/BorderUIResource.html#getRaisedBevelBorderUIResource()"/> 
        /// </summary>
        public static Javax.Swing.Border.Border RaisedBevelBorderUIResource
        {
            get { return SExecute<Javax.Swing.Border.Border>(LocalClazz, "getRaisedBevelBorderUIResource"); }
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/BorderUIResource.html#isBorderOpaque()"/> 
        /// </summary>
        public bool IsBorderOpaque
        {
            get { return IExecute<bool>("isBorderOpaque"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/BorderUIResource.html#getBorderInsets(java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <returns><see cref="Java.Awt.Insets"/></returns>
        public Java.Awt.Insets GetBorderInsets(Java.Awt.Component arg0)
        {
            return IExecute<Java.Awt.Insets>("getBorderInsets", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/BorderUIResource.html#paintBorder(java.awt.Component,java.awt.Graphics,int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Graphics"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        public void PaintBorder(Java.Awt.Component arg0, Java.Awt.Graphics arg1, int arg2, int arg3, int arg4, int arg5)
        {
            IExecute("paintBorder", arg0, arg1, arg2, arg3, arg4, arg5);
        }

        #endregion

        #region Nested classes
        #region BevelBorderUIResource
        public partial class BevelBorderUIResource
        {
            #region Constructors
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/BorderUIResource.BevelBorderUIResource.html#%3Cinit%3E(int,java.awt.Color,java.awt.Color,java.awt.Color,java.awt.Color)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <param name="arg1"><see cref="Java.Awt.Color"/></param>
            /// <param name="arg2"><see cref="Java.Awt.Color"/></param>
            /// <param name="arg3"><see cref="Java.Awt.Color"/></param>
            /// <param name="arg4"><see cref="Java.Awt.Color"/></param>
            public BevelBorderUIResource(int arg0, Java.Awt.Color arg1, Java.Awt.Color arg2, Java.Awt.Color arg3, Java.Awt.Color arg4)
                : base(arg0, arg1, arg2, arg3, arg4)
            {
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/BorderUIResource.BevelBorderUIResource.html#%3Cinit%3E(int,java.awt.Color,java.awt.Color)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <param name="arg1"><see cref="Java.Awt.Color"/></param>
            /// <param name="arg2"><see cref="Java.Awt.Color"/></param>
            public BevelBorderUIResource(int arg0, Java.Awt.Color arg1, Java.Awt.Color arg2)
                : base(arg0, arg1, arg2)
            {
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/BorderUIResource.BevelBorderUIResource.html#%3Cinit%3E(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            public BevelBorderUIResource(int arg0)
                : base(arg0)
            {
            }

            #endregion

            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Javax.Swing.Plaf.BorderUIResource.BevelBorderUIResource"/> to <see cref="Javax.Swing.Plaf.UIResource"/>
            /// </summary>
            public static implicit operator Javax.Swing.Plaf.UIResource(Javax.Swing.Plaf.BorderUIResource.BevelBorderUIResource t) => t.Cast<Javax.Swing.Plaf.UIResource>();

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region CompoundBorderUIResource
        public partial class CompoundBorderUIResource
        {
            #region Constructors
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/BorderUIResource.CompoundBorderUIResource.html#%3Cinit%3E(javax.swing.border.Border,javax.swing.border.Border)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.Border.Border"/></param>
            /// <param name="arg1"><see cref="Javax.Swing.Border.Border"/></param>
            public CompoundBorderUIResource(Javax.Swing.Border.Border arg0, Javax.Swing.Border.Border arg1)
                : base(arg0, arg1)
            {
            }

            #endregion

            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Javax.Swing.Plaf.BorderUIResource.CompoundBorderUIResource"/> to <see cref="Javax.Swing.Plaf.UIResource"/>
            /// </summary>
            public static implicit operator Javax.Swing.Plaf.UIResource(Javax.Swing.Plaf.BorderUIResource.CompoundBorderUIResource t) => t.Cast<Javax.Swing.Plaf.UIResource>();

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region EmptyBorderUIResource
        public partial class EmptyBorderUIResource
        {
            #region Constructors
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/BorderUIResource.EmptyBorderUIResource.html#%3Cinit%3E(int,int,int,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <param name="arg2"><see cref="int"/></param>
            /// <param name="arg3"><see cref="int"/></param>
            public EmptyBorderUIResource(int arg0, int arg1, int arg2, int arg3)
                : base(arg0, arg1, arg2, arg3)
            {
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/BorderUIResource.EmptyBorderUIResource.html#%3Cinit%3E(java.awt.Insets)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Awt.Insets"/></param>
            public EmptyBorderUIResource(Java.Awt.Insets arg0)
                : base(arg0)
            {
            }

            #endregion

            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Javax.Swing.Plaf.BorderUIResource.EmptyBorderUIResource"/> to <see cref="Javax.Swing.Plaf.UIResource"/>
            /// </summary>
            public static implicit operator Javax.Swing.Plaf.UIResource(Javax.Swing.Plaf.BorderUIResource.EmptyBorderUIResource t) => t.Cast<Javax.Swing.Plaf.UIResource>();

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region EtchedBorderUIResource
        public partial class EtchedBorderUIResource
        {
            #region Constructors
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/BorderUIResource.EtchedBorderUIResource.html#%3Cinit%3E(int,java.awt.Color,java.awt.Color)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <param name="arg1"><see cref="Java.Awt.Color"/></param>
            /// <param name="arg2"><see cref="Java.Awt.Color"/></param>
            public EtchedBorderUIResource(int arg0, Java.Awt.Color arg1, Java.Awt.Color arg2)
                : base(arg0, arg1, arg2)
            {
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/BorderUIResource.EtchedBorderUIResource.html#%3Cinit%3E(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            public EtchedBorderUIResource(int arg0)
                : base(arg0)
            {
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/BorderUIResource.EtchedBorderUIResource.html#%3Cinit%3E(java.awt.Color,java.awt.Color)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Awt.Color"/></param>
            /// <param name="arg1"><see cref="Java.Awt.Color"/></param>
            public EtchedBorderUIResource(Java.Awt.Color arg0, Java.Awt.Color arg1)
                : base(arg0, arg1)
            {
            }

            #endregion

            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Javax.Swing.Plaf.BorderUIResource.EtchedBorderUIResource"/> to <see cref="Javax.Swing.Plaf.UIResource"/>
            /// </summary>
            public static implicit operator Javax.Swing.Plaf.UIResource(Javax.Swing.Plaf.BorderUIResource.EtchedBorderUIResource t) => t.Cast<Javax.Swing.Plaf.UIResource>();

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region LineBorderUIResource
        public partial class LineBorderUIResource
        {
            #region Constructors
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/BorderUIResource.LineBorderUIResource.html#%3Cinit%3E(java.awt.Color,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Awt.Color"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            public LineBorderUIResource(Java.Awt.Color arg0, int arg1)
                : base(arg0, arg1)
            {
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/BorderUIResource.LineBorderUIResource.html#%3Cinit%3E(java.awt.Color)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Awt.Color"/></param>
            public LineBorderUIResource(Java.Awt.Color arg0)
                : base(arg0)
            {
            }

            #endregion

            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Javax.Swing.Plaf.BorderUIResource.LineBorderUIResource"/> to <see cref="Javax.Swing.Plaf.UIResource"/>
            /// </summary>
            public static implicit operator Javax.Swing.Plaf.UIResource(Javax.Swing.Plaf.BorderUIResource.LineBorderUIResource t) => t.Cast<Javax.Swing.Plaf.UIResource>();

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region MatteBorderUIResource
        public partial class MatteBorderUIResource
        {
            #region Constructors
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/BorderUIResource.MatteBorderUIResource.html#%3Cinit%3E(int,int,int,int,java.awt.Color)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <param name="arg2"><see cref="int"/></param>
            /// <param name="arg3"><see cref="int"/></param>
            /// <param name="arg4"><see cref="Java.Awt.Color"/></param>
            public MatteBorderUIResource(int arg0, int arg1, int arg2, int arg3, Java.Awt.Color arg4)
                : base(arg0, arg1, arg2, arg3, arg4)
            {
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/BorderUIResource.MatteBorderUIResource.html#%3Cinit%3E(int,int,int,int,javax.swing.Icon)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <param name="arg2"><see cref="int"/></param>
            /// <param name="arg3"><see cref="int"/></param>
            /// <param name="arg4"><see cref="Javax.Swing.Icon"/></param>
            public MatteBorderUIResource(int arg0, int arg1, int arg2, int arg3, Javax.Swing.Icon arg4)
                : base(arg0, arg1, arg2, arg3, arg4)
            {
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/BorderUIResource.MatteBorderUIResource.html#%3Cinit%3E(javax.swing.Icon)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.Icon"/></param>
            public MatteBorderUIResource(Javax.Swing.Icon arg0)
                : base(arg0)
            {
            }

            #endregion

            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Javax.Swing.Plaf.BorderUIResource.MatteBorderUIResource"/> to <see cref="Javax.Swing.Plaf.UIResource"/>
            /// </summary>
            public static implicit operator Javax.Swing.Plaf.UIResource(Javax.Swing.Plaf.BorderUIResource.MatteBorderUIResource t) => t.Cast<Javax.Swing.Plaf.UIResource>();

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region TitledBorderUIResource
        public partial class TitledBorderUIResource
        {
            #region Constructors
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/BorderUIResource.TitledBorderUIResource.html#%3Cinit%3E(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="string"/></param>
            public TitledBorderUIResource(string arg0)
                : base(arg0)
            {
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/BorderUIResource.TitledBorderUIResource.html#%3Cinit%3E(javax.swing.border.Border,java.lang.String,int,int,java.awt.Font,java.awt.Color)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.Border.Border"/></param>
            /// <param name="arg1"><see cref="string"/></param>
            /// <param name="arg2"><see cref="int"/></param>
            /// <param name="arg3"><see cref="int"/></param>
            /// <param name="arg4"><see cref="Java.Awt.Font"/></param>
            /// <param name="arg5"><see cref="Java.Awt.Color"/></param>
            public TitledBorderUIResource(Javax.Swing.Border.Border arg0, string arg1, int arg2, int arg3, Java.Awt.Font arg4, Java.Awt.Color arg5)
                : base(arg0, arg1, arg2, arg3, arg4, arg5)
            {
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/BorderUIResource.TitledBorderUIResource.html#%3Cinit%3E(javax.swing.border.Border,java.lang.String,int,int,java.awt.Font)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.Border.Border"/></param>
            /// <param name="arg1"><see cref="string"/></param>
            /// <param name="arg2"><see cref="int"/></param>
            /// <param name="arg3"><see cref="int"/></param>
            /// <param name="arg4"><see cref="Java.Awt.Font"/></param>
            public TitledBorderUIResource(Javax.Swing.Border.Border arg0, string arg1, int arg2, int arg3, Java.Awt.Font arg4)
                : base(arg0, arg1, arg2, arg3, arg4)
            {
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/BorderUIResource.TitledBorderUIResource.html#%3Cinit%3E(javax.swing.border.Border,java.lang.String,int,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.Border.Border"/></param>
            /// <param name="arg1"><see cref="string"/></param>
            /// <param name="arg2"><see cref="int"/></param>
            /// <param name="arg3"><see cref="int"/></param>
            public TitledBorderUIResource(Javax.Swing.Border.Border arg0, string arg1, int arg2, int arg3)
                : base(arg0, arg1, arg2, arg3)
            {
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/BorderUIResource.TitledBorderUIResource.html#%3Cinit%3E(javax.swing.border.Border,java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.Border.Border"/></param>
            /// <param name="arg1"><see cref="string"/></param>
            public TitledBorderUIResource(Javax.Swing.Border.Border arg0, string arg1)
                : base(arg0, arg1)
            {
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/BorderUIResource.TitledBorderUIResource.html#%3Cinit%3E(javax.swing.border.Border)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.Border.Border"/></param>
            public TitledBorderUIResource(Javax.Swing.Border.Border arg0)
                : base(arg0)
            {
            }

            #endregion

            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Javax.Swing.Plaf.BorderUIResource.TitledBorderUIResource"/> to <see cref="Javax.Swing.Plaf.UIResource"/>
            /// </summary>
            public static implicit operator Javax.Swing.Plaf.UIResource(Javax.Swing.Plaf.BorderUIResource.TitledBorderUIResource t) => t.Cast<Javax.Swing.Plaf.UIResource>();

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods

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