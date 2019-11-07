using GroupDocs.Merger.Cloud.Sdk.Api;
using GroupDocs.Merger.Cloud.Sdk.Client;
using GroupDocs.Merger.Cloud.Sdk.Model.Requests;
using System;
using GroupDocs.Merger.Cloud.Sdk.Model;
using FileInfo = GroupDocs.Merger.Cloud.Sdk.Model.FileInfo;

namespace GroupDocs.Merger.Cloud.Examples.CSharp
{
    /// <summary>
    /// This example demonstrates how to update document password.
    /// </summary>
    public class UpdateDocumentPassword
    {
		public static void Run()
		{
            var configuration = new Configuration(Common.MyAppSid, Common.MyAppKey);           
            var apiInstance = new SecurityApi(configuration);

			try
			{
				var fileInfo = new FileInfo
                {
					FilePath = "WordProcessing/password-protected.docx",
                    Password = "password"
                };

                var options = new UpdatePasswordOptions
                {
                    FileInfo = fileInfo,
                    OutputPath = "output/update-password.docx",
                    NewPassword = "NewPassword"
                };

                var request = new UpdatePasswordRequest(options);
                var response = apiInstance.UpdatePassword(request);

				Console.WriteLine("Output file path: " + response.Path);
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception while calling api: " + e.Message);
			}
		}
	}
}