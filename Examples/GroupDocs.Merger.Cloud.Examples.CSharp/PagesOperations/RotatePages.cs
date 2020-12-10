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
    /// This example demonstrates how to rotate document pages.
    /// </summary>
    public class RotatePages
    {
		public static void Run()
		{
            var configuration = Common.GetConfig();
            var apiInstance = new PagesApi(configuration);

			try
			{
				var fileInfo = new FileInfo
                {
						FilePath = "Pdf/ten-pages.pdf"
                };

                var options = new RotateOptions
                {
                    FileInfo = fileInfo,
                    OutputPath = "Output/rotate-pages.pdf",
                    Pages = new List<int?> { 2, 4 },
                    Mode = RotateOptions.ModeEnum.Rotate90
                };
                var request = new RotateRequest(options);

                var response = apiInstance.Rotate(request);

				Console.WriteLine("Output file path: " + response.Path);
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception while calling api: " + e.Message);
			}
		}
	}
}