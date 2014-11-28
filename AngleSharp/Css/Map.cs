﻿namespace AngleSharp.Css
{
    using AngleSharp.DOM;
    using AngleSharp.DOM.Css;
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// A collection of mappings for CSS (keywords to constants).
    /// </summary>
    static class Map
    {
        #region Dictionaries

        public static readonly Dictionary<String, LineStyle> LineStyles = new Dictionary<String, LineStyle>(StringComparer.OrdinalIgnoreCase);
        public static readonly Dictionary<String, BoxModel> BoxModels = new Dictionary<String, BoxModel>(StringComparer.OrdinalIgnoreCase);
        public static readonly Dictionary<String, TransitionFunction> TransitionFunctions = new Dictionary<String, TransitionFunction>(StringComparer.OrdinalIgnoreCase);
        public static readonly Dictionary<String, AnimationFillStyle> AnimationFillStyles = new Dictionary<String, AnimationFillStyle>(StringComparer.OrdinalIgnoreCase);
        public static readonly Dictionary<String, AnimationDirection> AnimationDirections = new Dictionary<String, AnimationDirection>(StringComparer.OrdinalIgnoreCase);
        public static readonly Dictionary<String, Visibility> Visibilities = new Dictionary<String, Visibility>(StringComparer.OrdinalIgnoreCase);
        public static readonly Dictionary<String, ListStyle> ListStyles = new Dictionary<String, ListStyle>(StringComparer.OrdinalIgnoreCase);
        public static readonly Dictionary<String, ListPosition> ListPositions = new Dictionary<String, ListPosition>(StringComparer.OrdinalIgnoreCase);
        public static readonly Dictionary<String, FontSize> FontSizes = new Dictionary<String, FontSize>(StringComparer.OrdinalIgnoreCase);
        public static readonly Dictionary<String, TextDecorationStyle> TextDecorationStyles = new Dictionary<String, TextDecorationStyle>(StringComparer.OrdinalIgnoreCase);
        public static readonly Dictionary<String, TextDecorationLine> TextDecorationLines = new Dictionary<String, TextDecorationLine>(StringComparer.OrdinalIgnoreCase);
        public static readonly Dictionary<String, BorderRepeat> BorderRepeatModes = new Dictionary<String, BorderRepeat>(StringComparer.OrdinalIgnoreCase);
        public static readonly Dictionary<String, String> DefaultFontFamilies = new Dictionary<String, String>(StringComparer.OrdinalIgnoreCase);
        public static readonly Dictionary<String, BackgroundAttachment> BackgroundAttachments = new Dictionary<String, BackgroundAttachment>(StringComparer.OrdinalIgnoreCase);
        public static readonly Dictionary<String, FontStyle> FontStyles = new Dictionary<String, FontStyle>(StringComparer.OrdinalIgnoreCase);
        public static readonly Dictionary<String, FontStretch> FontStretches = new Dictionary<String, FontStretch>(StringComparer.OrdinalIgnoreCase);
        public static readonly Dictionary<String, BreakMode> BreakModes = new Dictionary<String, BreakMode>(StringComparer.OrdinalIgnoreCase);
        public static readonly Dictionary<String, BreakMode> PageBreakModes = new Dictionary<String, BreakMode>(StringComparer.OrdinalIgnoreCase);
        public static readonly Dictionary<String, BreakMode> BreakInsideModes = new Dictionary<String, BreakMode>(StringComparer.OrdinalIgnoreCase);
        public static readonly Dictionary<String, Single> HorizontalModes = new Dictionary<String, Single>(StringComparer.OrdinalIgnoreCase);
        public static readonly Dictionary<String, Single> VerticalModes = new Dictionary<String, Single>(StringComparer.OrdinalIgnoreCase);
        public static readonly Dictionary<String, UnicodeMode> UnicodeModes = new Dictionary<String, UnicodeMode>(StringComparer.OrdinalIgnoreCase);

        #endregion

        #region Initial Population

        static Map()
        {
            LineStyles.Add(Keywords.None, LineStyle.None);
            LineStyles.Add(Keywords.Solid, LineStyle.Solid);
            LineStyles.Add(Keywords.Double, LineStyle.Double);
            LineStyles.Add(Keywords.Dotted, LineStyle.Dotted);
            LineStyles.Add(Keywords.Dashed, LineStyle.Dashed);
            LineStyles.Add(Keywords.Inset, LineStyle.Inset);
            LineStyles.Add(Keywords.Outset, LineStyle.Outset);
            LineStyles.Add(Keywords.Ridge, LineStyle.Ridge);
            LineStyles.Add(Keywords.Groove, LineStyle.Groove);
            LineStyles.Add(Keywords.Hidden, LineStyle.Hidden);

            BoxModels.Add(Keywords.BorderBox, BoxModel.BorderBox);
            BoxModels.Add(Keywords.PaddingBox, BoxModel.PaddingBox);
            BoxModels.Add(Keywords.ContentBox, BoxModel.ContentBox);

            TransitionFunctions.Add(Keywords.Ease, TransitionFunction.Ease);
            TransitionFunctions.Add(Keywords.EaseIn, TransitionFunction.EaseIn);
            TransitionFunctions.Add(Keywords.EaseOut, TransitionFunction.EaseOut);
            TransitionFunctions.Add(Keywords.EaseInOut, TransitionFunction.EaseInOut);
            TransitionFunctions.Add(Keywords.Linear, TransitionFunction.Linear);
            TransitionFunctions.Add(Keywords.StepStart, TransitionFunction.StepStart);
            TransitionFunctions.Add(Keywords.StepEnd, TransitionFunction.StepEnd);

            AnimationFillStyles.Add(Keywords.None, AnimationFillStyle.None);
            AnimationFillStyles.Add(Keywords.Forwards, AnimationFillStyle.Forwards);
            AnimationFillStyles.Add(Keywords.Backwards, AnimationFillStyle.Backwards);
            AnimationFillStyles.Add(Keywords.Both, AnimationFillStyle.Both);

            AnimationDirections.Add(Keywords.Normal, AnimationDirection.Normal);
            AnimationDirections.Add(Keywords.Reverse, AnimationDirection.Reverse);
            AnimationDirections.Add(Keywords.Alternate, AnimationDirection.Alternate);
            AnimationDirections.Add(Keywords.AlternateReverse, AnimationDirection.AlternateReverse);

            Visibilities.Add(Keywords.Visible, Visibility.Visible);
            Visibilities.Add(Keywords.Hidden, Visibility.Hidden);
            Visibilities.Add(Keywords.Collapse, Visibility.Collapse);

            ListStyles.Add(Keywords.Disc, ListStyle.Disc);
            ListStyles.Add(Keywords.Circle, ListStyle.Circle);
            ListStyles.Add(Keywords.Square, ListStyle.Square);
            ListStyles.Add(Keywords.Decimal, ListStyle.Decimal);
            ListStyles.Add(Keywords.DecimalLeadingZero, ListStyle.DecimalLeadingZero);
            ListStyles.Add(Keywords.LowerRoman, ListStyle.LowerRoman);
            ListStyles.Add(Keywords.UpperRoman, ListStyle.UpperRoman);
            ListStyles.Add(Keywords.LowerGreek, ListStyle.LowerGreek);
            ListStyles.Add(Keywords.LowerLatin, ListStyle.LowerLatin);
            ListStyles.Add(Keywords.UpperLatin, ListStyle.UpperLatin);
            ListStyles.Add(Keywords.Armenian, ListStyle.Armenian);
            ListStyles.Add(Keywords.Georgian, ListStyle.Georgian);
            ListStyles.Add(Keywords.LowerAlpha, ListStyle.LowerLatin);
            ListStyles.Add(Keywords.UpperAlpha, ListStyle.UpperLatin);
            ListStyles.Add(Keywords.None, ListStyle.None);

            ListPositions.Add(Keywords.Inside, ListPosition.Inside);
            ListPositions.Add(Keywords.Outside, ListPosition.Outside);

            FontSizes.Add(Keywords.XxSmall, FontSize.Tiny);
            FontSizes.Add(Keywords.XSmall, FontSize.Little);
            FontSizes.Add(Keywords.Small, FontSize.Small);
            FontSizes.Add(Keywords.Medium, FontSize.Medium);
            FontSizes.Add(Keywords.Large, FontSize.Large);
            FontSizes.Add(Keywords.XLarge, FontSize.Big);
            FontSizes.Add(Keywords.XxLarge, FontSize.Huge);
            FontSizes.Add(Keywords.Larger, FontSize.Smaller);
            FontSizes.Add(Keywords.Smaller, FontSize.Larger);

            TextDecorationStyles.Add(Keywords.Solid, TextDecorationStyle.Solid);
            TextDecorationStyles.Add(Keywords.Double, TextDecorationStyle.Double);
            TextDecorationStyles.Add(Keywords.Dotted, TextDecorationStyle.Dotted);
            TextDecorationStyles.Add(Keywords.Dashed, TextDecorationStyle.Dashed);
            TextDecorationStyles.Add(Keywords.Wavy, TextDecorationStyle.Wavy);

            TextDecorationLines.Add(Keywords.Underline, TextDecorationLine.Underline);
            TextDecorationLines.Add(Keywords.Overline, TextDecorationLine.Overline);
            TextDecorationLines.Add(Keywords.LineThrough, TextDecorationLine.LineThrough);
            TextDecorationLines.Add(Keywords.Blink, TextDecorationLine.Blink);

            BorderRepeatModes.Add(Keywords.Stretch, BorderRepeat.Stretch);
            BorderRepeatModes.Add(Keywords.Repeat, BorderRepeat.Repeat);
            BorderRepeatModes.Add(Keywords.Round, BorderRepeat.Round);

            DefaultFontFamilies.Add(Keywords.Serif, "Times New Roman");
            DefaultFontFamilies.Add(Keywords.SansSerif, "Arial");
            DefaultFontFamilies.Add(Keywords.Monospace, "Consolas");
            DefaultFontFamilies.Add(Keywords.Cursive, "Cursive");
            DefaultFontFamilies.Add(Keywords.Fantasy, "Comic Sans");

            BackgroundAttachments.Add(Keywords.Fixed, BackgroundAttachment.Fixed);
            BackgroundAttachments.Add(Keywords.Local, BackgroundAttachment.Local);
            BackgroundAttachments.Add(Keywords.Scroll, BackgroundAttachment.Scroll);

            FontStyles.Add(Keywords.Normal, FontStyle.Normal);
            FontStyles.Add(Keywords.Italic, FontStyle.Italic);
            FontStyles.Add(Keywords.Oblique, FontStyle.Oblique);

            FontStretches.Add(Keywords.Normal, FontStretch.Normal);
            FontStretches.Add(Keywords.UltraCondensed, FontStretch.UltraCondensed);
            FontStretches.Add(Keywords.ExtraCondensed, FontStretch.ExtraCondensed);
            FontStretches.Add(Keywords.Condensed, FontStretch.Condensed);
            FontStretches.Add(Keywords.SemiCondensed, FontStretch.SemiCondensed);
            FontStretches.Add(Keywords.SemiExpanded, FontStretch.SemiExpanded);
            FontStretches.Add(Keywords.Expanded, FontStretch.Expanded);
            FontStretches.Add(Keywords.ExtraExpanded, FontStretch.ExtraExpanded);
            FontStretches.Add(Keywords.UltraExpanded, FontStretch.UltraExpanded);

            BreakModes.Add(Keywords.Auto, BreakMode.Auto);
            BreakModes.Add(Keywords.Always, BreakMode.Always);
            BreakModes.Add(Keywords.Avoid, BreakMode.Avoid);
            BreakModes.Add(Keywords.Left, BreakMode.Left);
            BreakModes.Add(Keywords.Right, BreakMode.Right);
            BreakModes.Add(Keywords.Page, BreakMode.Page);
            BreakModes.Add(Keywords.Column, BreakMode.Column);
            BreakModes.Add(Keywords.AvoidPage, BreakMode.AvoidPage);
            BreakModes.Add(Keywords.AvoidColumn, BreakMode.AvoidColumn);

            PageBreakModes.Add(Keywords.Auto, BreakMode.Auto);
            PageBreakModes.Add(Keywords.Always, BreakMode.Always);
            PageBreakModes.Add(Keywords.Avoid, BreakMode.Avoid);
            PageBreakModes.Add(Keywords.Left, BreakMode.Left);
            PageBreakModes.Add(Keywords.Right, BreakMode.Right);

            BreakInsideModes.Add(Keywords.Auto, BreakMode.Auto);
            BreakInsideModes.Add(Keywords.Avoid, BreakMode.Avoid);
            BreakInsideModes.Add(Keywords.AvoidPage, BreakMode.AvoidPage);
            BreakInsideModes.Add(Keywords.AvoidColumn, BreakMode.AvoidColumn);
            BreakInsideModes.Add(Keywords.AvoidRegion, BreakMode.AvoidRegion);

            HorizontalModes.Add(Keywords.Left, 0f);
            HorizontalModes.Add(Keywords.Center, 0.5f);
            HorizontalModes.Add(Keywords.Right, 1f);

            VerticalModes.Add(Keywords.Top, 0f);
            VerticalModes.Add(Keywords.Center, 0.5f);
            VerticalModes.Add(Keywords.Bottom, 1f);

            UnicodeModes.Add(Keywords.Normal, UnicodeMode.Normal);
            UnicodeModes.Add(Keywords.Embed, UnicodeMode.Embed);
            UnicodeModes.Add(Keywords.Isolate, UnicodeMode.Isolate);
            UnicodeModes.Add(Keywords.IsolateOverride, UnicodeMode.IsolateOverride);
            UnicodeModes.Add(Keywords.BidiOverride, UnicodeMode.BidiOverride);
            UnicodeModes.Add(Keywords.Plaintext, UnicodeMode.Plaintext);
        }

        #endregion
    }
}