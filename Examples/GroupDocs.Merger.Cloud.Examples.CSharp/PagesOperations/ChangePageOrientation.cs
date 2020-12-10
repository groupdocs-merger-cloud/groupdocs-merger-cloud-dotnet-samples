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
    /// This example demonstrates how to change document page orientation.
    /// </summary>
    public class ChangePageOrientation
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

                var options = new OrientationOptions
                {
                    FileInfo = fileInfo,
                    OutputPath = "Output/change-page-orientation.docx",
                    Pages = new List<int?> { 2, 4 },
                    Mode = OrientationOptions.ModeEnum.Landscape
                };
                var request = new OrientationRequest(options);

                var response = apiInstance.Orientation(request);

				Console.WriteLine("Output file path: " + response.Path);
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception while calling api: " + e.Message);
			}
		}
	}
}