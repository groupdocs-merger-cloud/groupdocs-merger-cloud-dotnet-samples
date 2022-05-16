using GroupDocs.Merger.Cloud.Sdk.Api;
using GroupDocs.Merger.Cloud.Sdk.Client;
using GroupDocs.Merger.Cloud.Sdk.Model;
using GroupDocs.Merger.Cloud.Sdk.Model.Requests;
using System;

namespace GroupDocs.Merger.Cloud.Examples.CSharp
{
    /// <summary>
    /// This example demonstrates how to get document info.
    /// </summary>
    public class GetDocumentInformation
    {
		public static void Run()
		{
            var configuration = Common.GetConfig();
            var apiInstance = new InfoApi(configuration);

			try
			{
				var fileInfo = new FileInfo
                {
						FilePath = "WordProcessing/password-protected.docx",
						Password = "password"
					};

				var request = new GetInfoRequest(fileInfo);

				var response = apiInstance.GetInfo(request);
				Console.WriteLine("InfoResult.Pages.Count: " + response.Pages.Count);
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception while calling InfoApi: " + e.Message);
			}
		}
	}
}