using System;
using System.Collections.Generic;
using GroupDocs.Merger.Cloud.Sdk.Api;
using GroupDocs.Merger.Cloud.Sdk.Model;
using GroupDocs.Merger.Cloud.Sdk.Model.Requests;
using FileInfo = GroupDocs.Merger.Cloud.Sdk.Model.FileInfo;

namespace GroupDocs.Merger.Cloud.Examples.CSharp.DocumentOperations.JoinDocuments
{
    /// <summary>
    /// This example demonstrates how to join specific pages from several source documents.
    /// </summary>
    public class JoinPagesFromVariousDocuments
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
                        FilePath = "WordProcessing/sample-10-pages.docx"
                    },
                    Pages = new List<int?> {  3, 6, 8 }
                };

                var item2 = new JoinItem
                {
                    FileInfo = new FileInfo
                    {
                        FilePath = "WordProcessing/four-pages.docx"
                    },
                    StartPageNumber= 1,
                    EndPageNumber = 4,
                    RangeMode = JoinItem.RangeModeEnum.OddPages 
                };

                var options = new JoinOptions
                {
                    JoinItems = new List<JoinItem> { item1, item2 },
                    OutputPath = "Output/joined-pages.docx"
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