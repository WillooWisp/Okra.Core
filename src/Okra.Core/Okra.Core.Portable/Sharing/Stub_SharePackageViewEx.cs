﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okra.Sharing
{
    public static class SharePackageViewEx
    {
        // *** Static Methods - GetXxx ***

        public static Task<Uri> GetApplicationLinkAsync(this ISharePackageView sharePackageView)
        {
            throw new NotImplementedException();
        }

        public static Task<string> GetHtmlFormatAsync(this ISharePackageView sharePackageView)
        {
            throw new NotImplementedException();
        }

        public static Task<string> GetRtfAsync(this ISharePackageView sharePackageView)
        {
            throw new NotImplementedException();
        }

        public static Task<string> GetTextAsync(this ISharePackageView sharePackageView)
        {
            throw new NotImplementedException();
        }

        public static Task<Uri> GetWebLinkAsync(this ISharePackageView sharePackageView)
        {
            throw new NotImplementedException();
        }
    }
}
