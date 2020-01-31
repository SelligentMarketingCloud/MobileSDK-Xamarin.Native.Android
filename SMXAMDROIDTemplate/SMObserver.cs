using System;
using Android.Content;

namespace SMXAMDROIDTemplate
{
    public class SMObserver : Java.Lang.Object
    {
        protected WeakReference<Context> _context;
        public SMObserver(Context context)
        {
            _context = new WeakReference<Context>(context);
        }
    }
}
