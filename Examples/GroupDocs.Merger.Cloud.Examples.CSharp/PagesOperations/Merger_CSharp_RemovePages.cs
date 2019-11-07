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
    /// This example demonstrates how to remove document pages.
    /// </summary>
    public class RemovePages
    {
		public static void Run()
		{
            var configuration = new Configuration(Common.MyAppSid, Common.MyAppKey);
            var apiInstance = new PagesApi(configuration);

			try
			{
				var fileInfo = new FileInfo
                {
						FilePath = "WordProcessing/four-pages.docx"
                };

                var options = new RemoveOptions
                {
                    FileInfo = fileInfo,
                    OutputPath = "Output/remove-pages.docx",
                    Pages = new List<int?> { 2, 4 }
                };
                var request = new RemoveRequest(options);

                var response = apiInstance.Remove(request);

				Console.WriteLine("Output file path: " + response.Path);
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception while calling api: " + e.Message);
			}
		}
	}
}