using GroupDocs.Merger.Cloud.Sdk.Api;
using GroupDocs.Merger.Cloud.Sdk.Client;
using GroupDocs.Merger.Cloud.Sdk.Model;
using GroupDocs.Merger.Cloud.Sdk.Model.Requests;
using System;
using FileInfo = GroupDocs.Merger.Cloud.Sdk.Model.FileInfo;

namespace GroupDocs.Merger.Cloud.Examples.CSharp
{
    /// <summary>
    /// This example demonstrates how to split the document to several one-page documents (by start/end page numbers).
    /// </summary>
    public class SplitToSinglePagesByRange
    {
            public static void Run()
            {
                var configuration = new Configuration(Common.MyAppSid, Common.MyAppKey);
                var apiInstance = new DocumentApi(configuration);

                try
                {
                    var fileInfo = new FileInfo
                    {
                        FilePath = "WordProcessing/sample-10-pages.docx"
                    };

                    var options = new SplitOptions
                    {
                        FileInfo = fileInfo,
                        OutputPath = "Output/split-by-start-end-numbers",
                        StartPageNumber = 3,
                        EndPageNumber = 7,
                        Mode = SplitOptions.ModeEnum.Pages
                    };

                    var request = new SplitRequest(options);
                    var response = apiInstance.Split(request);

                    foreach (var document in response.Documents)
                    {
                        Console.WriteLine("Output file path: " + document.Path);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception while calling api: " + e.Message);
                }
            }
        }
    }