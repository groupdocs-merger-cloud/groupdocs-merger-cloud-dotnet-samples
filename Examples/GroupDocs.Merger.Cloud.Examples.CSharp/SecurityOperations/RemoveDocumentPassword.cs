using GroupDocs.Merger.Cloud.Sdk.Api;
using GroupDocs.Merger.Cloud.Sdk.Client;
using GroupDocs.Merger.Cloud.Sdk.Model.Requests;
using System;
using GroupDocs.Merger.Cloud.Sdk.Model;
using FileInfo = GroupDocs.Merger.Cloud.Sdk.Model.FileInfo;

namespace GroupDocs.Merger.Cloud.Examples.CSharp
{
    /// <summary>
    /// This example demonstrates how to remove document password.
    /// </summary>
    public class RemoveDocumentPassword
    {
		public static void Run()
		{
            var configuration = Common.GetConfig();
            var apiInstance = new SecurityApi(configuration);

			try
			{
				var fileInfo = new FileInfo
                {
					FilePath = "WordProcessing/password-protected.docx",
                    Password = "password"
                };

                var options = new Options
                {
                    FileInfo = fileInfo,
                    OutputPath = "output/remove-password.docx"
                };

                var request = new RemovePasswordRequest(options);
                var response = apiInstance.RemovePassword(request);

				Console.WriteLine("Output file path: " + response.Path);
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception while calling api: " + e.Message);
			}
		}
	}
}