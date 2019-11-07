using GroupDocs.Merger.Cloud.Sdk.Api;
using GroupDocs.Merger.Cloud.Sdk.Client;
using GroupDocs.Merger.Cloud.Sdk.Model.Requests;
using System;
using GroupDocs.Merger.Cloud.Sdk.Model;
using FileInfo = GroupDocs.Merger.Cloud.Sdk.Model.FileInfo;

namespace GroupDocs.Merger.Cloud.Examples.CSharp
{
    /// <summary>
    /// This example demonstrates how to add password to document.
    /// </summary>
    public class AddDocumentPassword
    {
		public static void Run()
		{
            var configuration = new Configuration(Common.MyAppSid, Common.MyAppKey);
            var apiInstance = new SecurityApi(configuration);

			try
			{
				var fileInfo = new FileInfo
                {
					FilePath = "WordProcessing/one-page.docx",
                    Password = "Password"
                };

                var options = new Options
                {
                    FileInfo = fileInfo,
                    OutputPath = "output/add-password.docx"
                };

                var request = new AddPasswordRequest(options);
                var response = apiInstance.AddPassword(request);

				Console.WriteLine("Output file path: " + response.Path);
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception while calling api: " + e.Message);
			}
		}
	}
}