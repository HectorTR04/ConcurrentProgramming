using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticManagementSystem
{
    /// <summary>
    /// Class with constant strings used to update producer and consumer statuses, because who wants
    /// a code filled with a bunch of random strings.
    /// </summary>
    public class ConstStrings
    {
        public const string PRODUCING = "PRODUCING";
        public const string WAITING = "WAITING";
        public const string NOT_PRODUCING = "NOT PRODUCING";
        public const string CONSUMING = "CONSUMING";
        public const string NOT_CONSUMING = "NOT CONSUMING";
        public const string PRODUCTS_LOADED = "Products Loaded: ";
        public const string EMPTY = "Empty :( ";
    }
}
