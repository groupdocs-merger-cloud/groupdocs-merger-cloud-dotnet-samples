using GroupDocs.Merger.Cloud.Sdk.Api;
using GroupDocs.Merger.Cloud.Sdk.Client;
using GroupDocs.Merger.Cloud.Sdk.Model;
using GroupDocs.Merger.Cloud.Sdk.Model.Requests;
using System;
using FileInfo = GroupDocs.Merger.Cloud.Sdk.Model.FileInfo;

namespace GroupDocs.Merger.Cloud.Examples.CSharp
{
    /// <summary>
    /// This example demonstrates how to move document page to a new position.
    /// </summary>
    public class MovePage
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

                var options = new MoveOptions
                {
                    FileInfo = fileInfo,
                    OutputPath = "Output/move-pages.docx",
                    PageNumber = 1,
                    NewPageNumber = 2
                };
                var request = new MoveRequest(options);

                var response = apiInstance.Move(request);

				Console.WriteLine("Output file path: " + response.Path);
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception while calling api: " + e.Message);
			}
		}
	}
}