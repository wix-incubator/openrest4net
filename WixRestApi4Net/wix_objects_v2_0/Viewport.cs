﻿using System;

namespace wixrest.v2_0
{
    public class Viewport
    {
        public int? width;
        public double? initialScale;
        public double? maximumScale;

        public Viewport(int width, double initialScale, double maximumScale)
        {
            this.width = width;
            this.initialScale = initialScale;
            this.maximumScale = maximumScale;
        }

        /** Empty constructor required for initialization from JSON-encoded string. */
        public Viewport() { }
    }
}