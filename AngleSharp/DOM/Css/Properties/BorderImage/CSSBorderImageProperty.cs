﻿namespace AngleSharp.DOM.Css.Properties
{
    using System;

    /// <summary>
    /// More information available at:
    /// https://developer.mozilla.org/en-US/docs/Web/CSS/border-image
    /// </summary>
    public sealed class CSSBorderImageProperty : CSSProperty
    {
        #region Fields

        CSSBorderImageOutsetProperty _outset;
        CSSBorderImageRepeatProperty _repeat;
        CSSBorderImageSliceProperty _slice;
        CSSBorderImageSourceProperty _source;
        CSSBorderImageWidthProperty _width;

        #endregion

        #region ctor

        internal CSSBorderImageProperty()
            : base(PropertyNames.BorderImage)
        {
            _inherited = false;
            _outset = new CSSBorderImageOutsetProperty();
            _repeat = new CSSBorderImageRepeatProperty();
            _slice = new CSSBorderImageSliceProperty();
            _source = new CSSBorderImageSourceProperty();
            _width = new CSSBorderImageWidthProperty();
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets the outset property of the border-image.
        /// </summary>
        public CSSBorderImageOutsetProperty Outset
        {
            get { return _outset; }
        }

        /// <summary>
        /// Gets the repeat property of the border-image.
        /// </summary>
        public CSSBorderImageRepeatProperty Repeat
        {
            get { return _repeat; }
        }

        /// <summary>
        /// Gets the slice property of the border-image.
        /// </summary>
        public CSSBorderImageSliceProperty Slice
        {
            get { return _slice; }
        }

        /// <summary>
        /// Gets the source property of the border-image.
        /// </summary>
        public CSSBorderImageSourceProperty Source
        {
            get { return _source; }
        }

        /// <summary>
        /// Gets the width property of the border-image.
        /// </summary>
        public CSSBorderImageWidthProperty Width
        {
            get { return _width; }
        }

        #endregion

        #region Methods

        protected override Boolean IsValid(CSSValue value)
        {
            if (value != CSSValue.Inherit)
                return false;

            return true;
        }

        #endregion
    }
}
