using System;
using System.Collections.Generic;
using WixRestApi4Net.wix_objects_v2_0;

namespace wixrest.v2_0
{
    /**
     * A possible modification to an item, e.g. "choice of sides" for a happy-meal
     * or "degree of cooking" for a hamburger.
     * @author DL
     */
    public class Variation
    {
        public const string VARIATION_DISPLAY_TYPE_DIFF = "diff";
        public const string VARIATION_DISPLAY_TYPE_CHOICE = "choice";
        /**
         * Variations that are not displayed to the customer, just to the restaurant.
         * Similar to a hidden field in an HTML form.
         */
        public const string VARIATION_DISPLAY_TYPE_HIDDEN = "hidden";

        /** The variations's name in various locales, e.g. "sides", "degree of cooking". */
        public WixText title;

        /** Minimum number of items to select. */
        public int? minNumAllowed;

        /** Maximum number of items to select. */
        public int? maxNumAllowed;

        /** Items' base prices. Non-referenced items are free by default. */
        public IDictionary<string, int> prices;

        /** item ids. */
        public IList<string> itemIds;

        /** Default selected item ids. */
        public IList<string> defaults;

        /** Display type for human-readable printing. */
        public string displayType;
    }
}
