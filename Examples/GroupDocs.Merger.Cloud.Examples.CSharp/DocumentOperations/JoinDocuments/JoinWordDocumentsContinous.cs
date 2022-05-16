using System;
using System.Collections.Generic;
using GroupDocs.Merger.Cloud.Sdk.Api;
using GroupDocs.Merger.Cloud.Sdk.Model;
using GroupDocs.Merger.Cloud.Sdk.Model.Requests;
using FileInfo = GroupDocs.Merger.Cloud.Sdk.Model.FileInfo;

namespace GroupDocs.Merger.Cloud.Examples.CSharp.DocumentOperations.JoinDocuments
{
    /// <summary>
    /// This example demonstrates how to join word document continously, without adding new page between documents.
    /// </summary>
    public class JoinWordDocumentsContinous
    {
		public static void Run()
		{
			var configuration = Common.GetConfig();
            var apiInstance = new DocumentApi(configuration);

			try
			{
                var item1 = new JoinItem
                {
                    FileInfo = new FileInfo
                    {
                        FilePath = "WordProcessing/four-pages.docx"
                    }
                };

                var item2 = new JoinItem
                {
                    FileInfo = new FileInfo
                    {
                        FilePath = "WordProcessing/one-page.docx"
                    },
                    WordJoinMode = JoinItem.WordJoinModeEnum.Continuous
                };

                var options = new JoinOptions
                {
                    JoinItems = new List<JoinItem> { item1, item2 },
                    OutputPath = "Output/joined_continous.docx",
                    
                };

                var request = new JoinRequest(options);
                var response = apiInstance.Join(request);

                Console.WriteLine("Output file path: " + response.Path);
            }
			catch (Exception e)
			{
				Console.WriteLine("Exception while calling api: " + e.Message);
			}
		}
	}
}