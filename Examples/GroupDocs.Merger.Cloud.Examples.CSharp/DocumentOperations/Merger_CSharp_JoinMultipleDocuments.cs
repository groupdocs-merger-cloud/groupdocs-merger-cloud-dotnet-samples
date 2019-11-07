using GroupDocs.Merger.Cloud.Sdk.Api;
using GroupDocs.Merger.Cloud.Sdk.Client;
using GroupDocs.Merger.Cloud.Sdk.Model;
using GroupDocs.Merger.Cloud.Sdk.Model.Requests;
using System;
using System.Collections.Generic;
using FileInfo = GroupDocs.Merger.Cloud.Sdk.Model.FileInfo;

namespace GroupDocs.Merger.Cloud.Examples.CSharp
{
    /// <summary>
    /// This example demonstrates how to join multiple documents into one document.
    /// </summary>
    public class JoinMultipleDocuments
    {
		public static void Run()
		{
			var configuration = new Configuration(Common.MyAppSid, Common.MyAppKey);
            var apiInstance = new DocumentApi(configuration);

			try
			{
                var item1 = new JoinItem
                {
                    FileInfo = new FileInfo
                    {
                        FilePath = "WordProcessing/four-pages.docx"
                    }
                };

                var item2 = new JoinItem
                {
                    FileInfo = new FileInfo
                    {
                        FilePath = "WordProcessing/one-page.docx"
                    }
                };

                var options = new JoinOptions
                {
                    JoinItems = new List<JoinItem> { item1, item2 },
                    OutputPath = "Output/joined.docx"
                };

                var request = new JoinRequest(options);
                var response = apiInstance.Join(request);

                Console.WriteLine("Output file path: " + response.Path);
            }
			catch (Exception e)
			{
				Console.WriteLine("Exception while calling api: " + e.Message);
			}
		}
	}
}