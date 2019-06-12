﻿using Google.Apis.Auth.OAuth2;
using Google.Apis.Sheets.v4;
using Google.Apis.Sheets.v4.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace islaam_db_client
{
    public class IslaamDBClient
    {
        private readonly APICaller ApiCaller;

        public readonly PersonAPI PersonAPI;

        public IslaamDBClient(string APIKey)
        {
            ApiCaller = new APICaller(APIKey);
            PersonAPI = new PersonAPI(ApiCaller);
        }
    }
}