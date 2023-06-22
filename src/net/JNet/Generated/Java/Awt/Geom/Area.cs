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
*  This file is generated by MASES.JNetReflector (ver. 2.0.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Awt.Geom
{
    #region Area
    public partial class Area
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Area.html#%3Cinit%3E(java.awt.Shape)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Shape"/></param>
        public Area(Java.Awt.Shape arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Awt.Geom.Area"/> to <see cref="Java.Awt.Shape"/>
        /// </summary>
        public static implicit operator Java.Awt.Shape(Java.Awt.Geom.Area t) => t.Cast<Java.Awt.Shape>();
        /// <summary>
        /// Converter from <see cref="Java.Awt.Geom.Area"/> to <see cref="Java.Lang.Cloneable"/>
        /// </summary>
        public static implicit operator Java.Lang.Cloneable(Java.Awt.Geom.Area t) => t.Cast<Java.Lang.Cloneable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Area.html#getBounds()"/> 
        /// </summary>
        public Java.Awt.Rectangle Bounds
        {
            get { return IExecute<Java.Awt.Rectangle>("getBounds"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Area.html#getBounds2D()"/> 
        /// </summary>
        public Java.Awt.Geom.Rectangle2D Bounds2D
        {
            get { return IExecute<Java.Awt.Geom.Rectangle2D>("getBounds2D"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Area.html#contains(double,double,double,double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <param name="arg1"><see cref="double"/></param>
        /// <param name="arg2"><see cref="double"/></param>
        /// <param name="arg3"><see cref="double"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Contains(double arg0, double arg1, double arg2, double arg3)
        {
            return IExecute<bool>("contains", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Area.html#contains(double,double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <param name="arg1"><see cref="double"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Contains(double arg0, double arg1)
        {
            return IExecute<bool>("contains", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Area.html#contains(java.awt.geom.Point2D)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Geom.Point2D"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Contains(Java.Awt.Geom.Point2D arg0)
        {
            return IExecute<bool>("contains", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Area.html#contains(java.awt.geom.Rectangle2D)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Geom.Rectangle2D"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Contains(Java.Awt.Geom.Rectangle2D arg0)
        {
            return IExecute<bool>("contains", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Area.html#intersects(double,double,double,double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <param name="arg1"><see cref="double"/></param>
        /// <param name="arg2"><see cref="double"/></param>
        /// <param name="arg3"><see cref="double"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Intersects(double arg0, double arg1, double arg2, double arg3)
        {
            return IExecute<bool>("intersects", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Area.html#intersects(java.awt.geom.Rectangle2D)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Geom.Rectangle2D"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Intersects(Java.Awt.Geom.Rectangle2D arg0)
        {
            return IExecute<bool>("intersects", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Area.html#isEmpty()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsEmpty()
        {
            return IExecute<bool>("isEmpty");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Area.html#isPolygonal()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsPolygonal()
        {
            return IExecute<bool>("isPolygonal");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Area.html#isRectangular()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsRectangular()
        {
            return IExecute<bool>("isRectangular");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Area.html#isSingular()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsSingular()
        {
            return IExecute<bool>("isSingular");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Area.html#createTransformedArea(java.awt.geom.AffineTransform)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Geom.AffineTransform"/></param>
        /// <returns><see cref="Java.Awt.Geom.Area"/></returns>
        public Java.Awt.Geom.Area CreateTransformedArea(Java.Awt.Geom.AffineTransform arg0)
        {
            return IExecute<Java.Awt.Geom.Area>("createTransformedArea", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Area.html#getPathIterator(java.awt.geom.AffineTransform,double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Geom.AffineTransform"/></param>
        /// <param name="arg1"><see cref="double"/></param>
        /// <returns><see cref="Java.Awt.Geom.PathIterator"/></returns>
        public Java.Awt.Geom.PathIterator GetPathIterator(Java.Awt.Geom.AffineTransform arg0, double arg1)
        {
            return IExecute<Java.Awt.Geom.PathIterator>("getPathIterator", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Area.html#getPathIterator(java.awt.geom.AffineTransform)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Geom.AffineTransform"/></param>
        /// <returns><see cref="Java.Awt.Geom.PathIterator"/></returns>
        public Java.Awt.Geom.PathIterator GetPathIterator(Java.Awt.Geom.AffineTransform arg0)
        {
            return IExecute<Java.Awt.Geom.PathIterator>("getPathIterator", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Area.html#add(java.awt.geom.Area)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Geom.Area"/></param>
        public void Add(Java.Awt.Geom.Area arg0)
        {
            IExecute("add", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Area.html#exclusiveOr(java.awt.geom.Area)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Geom.Area"/></param>
        public void ExclusiveOr(Java.Awt.Geom.Area arg0)
        {
            IExecute("exclusiveOr", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Area.html#intersect(java.awt.geom.Area)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Geom.Area"/></param>
        public void Intersect(Java.Awt.Geom.Area arg0)
        {
            IExecute("intersect", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Area.html#reset()"/>
        /// </summary>
        public void Reset()
        {
            IExecute("reset");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Area.html#subtract(java.awt.geom.Area)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Geom.Area"/></param>
        public void Subtract(Java.Awt.Geom.Area arg0)
        {
            IExecute("subtract", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/geom/Area.html#transform(java.awt.geom.AffineTransform)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Geom.AffineTransform"/></param>
        public void Transform(Java.Awt.Geom.AffineTransform arg0)
        {
            IExecute("transform", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}