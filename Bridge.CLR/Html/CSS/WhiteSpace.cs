﻿namespace Bridge.CLR.Html
{
    /// <summary>
    /// The white-space CSS property is used to to describe how whitespace inside the element is handled.
    /// </summary>
    [Bridge.CLR.Ignore]
    [Bridge.CLR.EnumEmit(EnumEmit.StringNameLowerCase)]
    [Bridge.CLR.Name("String")]
    public enum WhiteSpace
    {
        /// <summary>
        /// 
        /// </summary>
        Inherit,

        /// <summary>
        /// Sequences of whitespace are collapsed. Newline characters in the source are handled as other whitespace. Breaks lines as necessary to fill line boxes.
        /// </summary>
        Normal, 
        
        /// <summary>
        /// Collapses whitespace as for normal, but suppresses line breaks (text wrapping) within text.
        /// </summary>
        NoWrap,

        /// <summary>
        /// Sequences of whitespace are preserved, lines are only broken at newline characters in the source and at br elements.
        /// </summary>
        Pre,

        /// <summary>
        /// Sequences of whitespace are preserved. Lines are broken at newline characters, at br, and as necessary to fill line boxes.
        /// </summary>
        [Bridge.CLR.Name("pre-wrap")]
        PreWrap,

        /// <summary>
        /// Sequences of whitespace are collapsed. Lines are broken at newline characters, at <br>, and as necessary to fill line boxes.
        /// </summary>
        [Bridge.CLR.Name("pre-line")]
        PreLine
    }
}