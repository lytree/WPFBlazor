using APP.Shared;
using HandyControl.Controls;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP;

internal class PlatformsService : IPlatformsService
{
	public async Task<string[]> FileBrowser(bool multiple, string filter)
	{
		return await Task.Run(() =>
		{
			var fileDialog = new OpenFileDialog()
			{
				Multiselect = multiple,
				Title = "选择文件",
				Filter = filter,
				InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)
			};
			if (fileDialog.ShowDialog() == true)
			{
				return fileDialog.FileNames;
			}
			return [];
		});
	}

	public async Task<string[]> FolderBrowser(bool multiple)
	{
		return await Task.Run(() =>
		{
			var folderDialog = new OpenFolderDialog
			{
				Multiselect = multiple,
				Title = "选择文件夹",
				InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)
			};

			if (folderDialog.ShowDialog() == true)
			{
				var folderName = folderDialog.FolderNames;
				return folderName;
			}
			return [];
		});
	}
}
