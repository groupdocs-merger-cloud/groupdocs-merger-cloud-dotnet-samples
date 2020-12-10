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
    /// This example demonstrates how to generate document pages preview.
    /// </summary>
    public class PreviewDocument
	{
		public static void Run()
		{
            var configuration = Common.GetConfig();
            var apiInstance = new DocumentApi(configuration);

			try
			{
				var fileInfo = new FileInfo
                {
						FilePath = "WordProcessing/four-pages.docx"
                };

                var options = new PreviewOptions()
                {
                    FileInfo = fileInfo,
                    OutputPath = "Output/preview-page",
                    Pages = new List<int?> { 1, 3 },
                    Format = PreviewOptions.FormatEnum.Png
                };

                var request = new PreviewRequest(options);
                var response = apiInstance.Preview(request);

                foreach (var document in response.Documents)
                {
                    Console.WriteLine("Output file path: " + document.Path);
                }
            }
			catch (Exception e)
			{
				Console.WriteLine("Exception while calling api: " + e.Message);
			}
		}
	}
}