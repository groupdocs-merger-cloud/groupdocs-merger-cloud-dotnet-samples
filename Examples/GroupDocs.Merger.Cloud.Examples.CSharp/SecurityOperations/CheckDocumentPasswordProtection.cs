using GroupDocs.Merger.Cloud.Sdk.Api;
using GroupDocs.Merger.Cloud.Sdk.Client;
using GroupDocs.Merger.Cloud.Sdk.Model.Requests;
using System;
using FileInfo = GroupDocs.Merger.Cloud.Sdk.Model.FileInfo;

namespace GroupDocs.Merger.Cloud.Examples.CSharp
{
    /// <summary>
    /// This example demonstrates how to check document password.
    /// </summary>
    public class CheckDocumentPasswordProtection
    {
		public static void Run()
		{
            var configuration = Common.GetConfig();
            var apiInstance = new SecurityApi(configuration);

			try
			{
				var fileInfo = new FileInfo
                {
						FilePath = "WordProcessing/password-protected.docx"
                };

                var request = new CheckPasswordRequest(fileInfo.FilePath);
                var response = apiInstance.CheckPassword(request);

				Console.WriteLine("Check password: " + response.IsPasswordSet);
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception while calling api: " + e.Message);
			}
		}
	}
}