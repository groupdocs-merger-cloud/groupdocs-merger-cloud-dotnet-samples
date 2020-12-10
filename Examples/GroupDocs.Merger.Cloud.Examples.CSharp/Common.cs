using System.IO;
using System;
using GroupDocs.Merger.Cloud.Sdk.Api;
using GroupDocs.Merger.Cloud.Sdk.Client;


namespace GroupDocs.Merger.Cloud.Examples.CSharp
{
    internal class Common
	{
		public static string MyClientId;
		public static string MyClientSecret;
		public static string MyStorage;

        public static Configuration GetConfig()
        {
            var config = new Configuration(MyClientId,  MyClientSecret);
            return config;
        }

		public static void UploadSampleTestFiles()
		{
			var storageConfig = GetConfig();
            var storageApi = new StorageApi(storageConfig);
			var folderApi = new FolderApi(storageConfig);
			var fileApi = new FileApi(storageConfig);

			var path = "..\\..\\..\\Resources";

			Console.WriteLine("File Upload Processing...");

			var dirs = Directory.GetDirectories(path, "*", SearchOption.AllDirectories);
			foreach (var dir in dirs)
			{
				var relativeDirPath = dir.Replace(path, string.Empty).Trim(Path.DirectorySeparatorChar);
				var response = storageApi.ObjectExists(new Sdk.Model.Requests.ObjectExistsRequest(relativeDirPath, MyStorage));
				if (response.Exists != null && !response.Exists.Value)
				{
					folderApi.CreateFolder(new Sdk.Model.Requests.CreateFolderRequest(relativeDirPath, MyStorage));
				}
			}

			var files = Directory.GetFiles(path, "*", SearchOption.AllDirectories);
			foreach (var file in files)
			{
				var relativeFilePath = file.Replace(path, string.Empty).Trim(Path.DirectorySeparatorChar);

				var response = storageApi.ObjectExists(new Sdk.Model.Requests.ObjectExistsRequest(relativeFilePath, MyStorage));
				if (response.Exists != null && !response.Exists.Value)
				{
                    var fileStream = File.Open(file, FileMode.Open);

					fileApi.UploadFile(new Sdk.Model.Requests.UploadFileRequest(relativeFilePath, fileStream, MyStorage));
					fileStream.Close();
				}
			}

			Console.WriteLine("File Upload Process Completed.");
		}
	}
}
