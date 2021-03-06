﻿using System;

namespace Telesign.Example.AppVerify
{
    class GetStatusByExternalId
    {
        static void Main(string[] args)
        {
            string customerId = "FFFFFFFF-EEEE-DDDD-1234-AB1234567890";
            string apiKey = "EXAMPLETE8sTgg45yusumoN6BYsBVkh+yRJ5czgsnCehZaOYldPJdmFh6NeX8kunZ2zU1YWaUw/0wV6xfw==";

            string externalId = "external_id";

            try
            {
                AppVerifyClient appVerifyClient = new AppVerifyClient(customerId, apiKey);
                RestClient.TelesignResponse telesignResponse = appVerifyClient.Status(externalId);

                if (telesignResponse.OK)
                {
                    Console.WriteLine(string.Format("AppVerify transaction with external_id {0} has status code {1} and status description {2}.",
                            externalId,
                            telesignResponse.Json["status"]["code"],
                            telesignResponse.Json["status"]["description"]));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            Console.WriteLine("Press any key to quit.");
            Console.ReadKey();
        }
    }
}
