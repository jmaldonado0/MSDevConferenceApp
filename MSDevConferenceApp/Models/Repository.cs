﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MSDevConferenceApp.Models
{
    public class Repository
    {
        private static List<WebinarInvites> responses = new List<WebinarInvites>();

        public static IEnumerable<WebinarInvites> Responses => responses;

        public static void AddResponse(WebinarInvites response)
        {
            responses.Add(response);
        }
    }
}
