using System;
using System.Collections.Generic;
using GroupDocs.Merger.Cloud.Sdk.Api;
using GroupDocs.Merger.Cloud.Sdk.Model;
using GroupDocs.Merger.Cloud.Sdk.Model.Requests;
using FileInfo = GroupDocs.Merger.Cloud.Sdk.Model.FileInfo;

namespace GroupDocs.Merger.Cloud.Examples.CSharp.DocumentOperations
{
    /// <summary>
    /// This example demonstrates how to import attachment into pdf document
    /// </summary>
    public class ImportAttachment
    {
        public static void Run()
        {
            var configuration = Common.GetConfig();
            var apiInstance = new DocumentApi(configuration);

            try
            {
                var options = new ImportOptions
                {
                    FileInfo = new FileInfo
                    {
                        FilePath = "Pdf/one-page-password.pdf",
                        Password = "password"
                    },
                    Attachments = new List<string> { "Txt/document.txt" },
                    OutputPath = "Output/with-attachment.pdf"
                };

                var request = new ImportRequest(options);
                var response = apiInstance.Import(request);

                Console.WriteLine("Output file path: " + response.Path);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception while calling api: " + e.Message);
            }
        }
    }
}