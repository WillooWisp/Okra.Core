﻿using System;
using System.Collections.Generic;
using System.Text;
using Windows.ApplicationModel.DataTransfer;

namespace Okra.Sharing
{
    public static class StandardShareFormats
    {
        public static string ApplicationLink
        {
            get
            {
                return StandardDataFormats.ApplicationLink;
            }
        }

        public static string Html
        {
            get
            {
                return StandardDataFormats.Html;
            }
        }

        public static string Rtf
        {
            get
            {
                return StandardDataFormats.Rtf;
            }
        }

        public static string Text
        {
            get
            {
                return StandardDataFormats.Text;
            }
        }

        public static string WebLink
        {
            get
            {
                return StandardDataFormats.WebLink;
            }
        }
    }
}
