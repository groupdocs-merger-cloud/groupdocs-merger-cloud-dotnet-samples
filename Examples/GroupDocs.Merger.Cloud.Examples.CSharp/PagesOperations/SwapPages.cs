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
    /// This example demonstrates how to swap document pages.
    /// </summary>
    public class SwapPages
    {
		public static void Run()
		{
            var configuration = Common.GetConfig();
            var apiInstance = new PagesApi(configuration);

			try
			{
				var fileInfo = new FileInfo
                {
						FilePath = "WordProcessing/four-pages.docx"
                };

                var options = new SwapOptions
                {
                    FileInfo = fileInfo,
                    OutputPath = "Output/swap-pages.docx",
                    FirstPageNumber = 2,
                    SecondPageNumber = 4
                };
                var request = new SwapRequest(options);

                var response = apiInstance.Swap(request);

				Console.WriteLine("Output file path: " + response.Path);
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception while calling api: " + e.Message);
			}
		}
	}
}