using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP.Shared;

public interface IPlatformsService
{
	public Task<string[]> FolderBrowser(bool multiple);

	public Task<string[]> FileBrowser(bool multiple, string filter = "所有文件(*.*)|*.*");
}
