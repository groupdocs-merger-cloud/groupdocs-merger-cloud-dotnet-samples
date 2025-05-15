using System;
using System.Collections.Generic;
using GroupDocs.Merger.Cloud.Sdk.Api;
using GroupDocs.Merger.Cloud.Sdk.Model;
using GroupDocs.Merger.Cloud.Sdk.Model.Requests;
using FileInfo = GroupDocs.Merger.Cloud.Sdk.Model.FileInfo;

namespace GroupDocs.Merger.Cloud.Examples.CSharp.DocumentOperations.JoinDocuments
{
    /// <summary>
    /// This example demonstrates how to mix specific pages from several source documents.
    /// </summary>
    public class MixPages
    {
		public static void Run()
		{
            var configuration = Common.GetConfig();
            var apiInstance = new DocumentApi(configuration);

			try
			{
                var options = new MixPagesOptions
                {
                    Files = new List<FileInfo> {
                        new() { FilePath = "WordProcessing/sample-10-pages.docx" },
                        new() { FilePath = "WordProcessing/four-pages.docx" }
                    },
                    FilesPages = new List<MixPagesItem>
                    {
                        new() { FileIndex = 0, Pages = new List<int?> { 1, 2 } },
                        new() { FileIndex = 1, Pages = new List<int?> { 1, 2 } },
                        new() { FileIndex = 0, Pages = new List<int?> { 3, 4 } },
                    },
                    OutputPath = "Output/mixed-pages.docx"
                };

                var request = new MixRequest(options);
                var response = apiInstance.Mix(request);

                Console.WriteLine("Output file path: " + response.Path);
            }
			catch (Exception e)
			{
				Console.WriteLine("Exception while calling api: " + e.Message);
			}
		}
	}
}
