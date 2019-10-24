using System;

namespace GroupDocs.Merger.Cloud.Examples.CSharp
{
	public class RunExamples
	{
		public static void Main(string[] args)
		{
            //// ***********************************************************
            ////          GroupDocs.Merger Cloud API Examples
            //// ***********************************************************

            //TODO: Get your AppSID and AppKey at https://dashboard.groupdocs.cloud (free registration is required).
            Common.MyAppSid = "XXXXX-XXXXX-XXXXX";
            Common.MyAppKey = "XXXXXXXXXX";
            Common.MyStorage = "First Storage";

            // Uploading sample test files from local disk to cloud storage
            Common.UploadSampleTestFiles();
           

            #region Get all supported file types
            GetSupportedFileTypes.Run();
            #endregion

            #region Get info for the selected document
            GetDocumentInformation.Run();
            #endregion

            #region Document operations
            JoinMultipleDocuments.Run();
            JoinPagesFromVariousDocuments.Run();
            PreviewDocument.Run();
            SplitToSinglePages.Run();
            SplitToSinglePagesByRange.Run();
            SplitToSinglePagesByRangeWithFilter.Run();
            SplitToMultiPageDocuments.Run();
            #endregion

            #region Pages operations
            ChangePageOrientation.Run();
            ExtractPagesByNumbers.Run();
            ExtractPagesByRange.Run();
            MovePage.Run();
            RemovePages.Run();
            RotatePages.Run();
            SwapPages.Run();
            #endregion

            #region Security operations
            AddDocumentPassword.Run();
            CheckDocumentPasswordProtection.Run();
            RemoveDocumentPassword.Run();
            UpdateDocumentPassword.Run();
            #endregion

            Console.WriteLine("Completed!");
            Console.ReadKey();
        }
	}
}