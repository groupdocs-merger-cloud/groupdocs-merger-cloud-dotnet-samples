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
    /// This example demonstrates how to extract document pages by specifying their numbers.
    /// </summary>
    public class ExtractPagesByNumbers
    {
		public static void Run()
		{
            var configuration = new Configuration(Common.MyAppSid, Common.MyAppKey);
            var apiInstance = new PagesApi(configuration);

			try
			{
				var fileInfo = new FileInfo
                {
						FilePath = "WordProcessing/sample-10-pages.docx"
                };

                var options = new ExtractOptions
                {
                    FileInfo = fileInfo,
                    OutputPath = "Output/extract-pages-by-numbers.docx",
                    Pages = new List<int?> { 2, 4, 7 }
                };
                var request = new ExtractRequest(options);

                var response = apiInstance.Extract(request);

				Console.WriteLine("Output file path: " + response.Path);
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception while calling api: " + e.Message);
			}
		}
	}
}