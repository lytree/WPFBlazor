using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace APP.Shared.Pages.Data;

public partial class NBTool
{
	[Inject] IPlatformsService platformsService { get; set; }

	protected override async Task OnInitializedAsync()
	{
		await base.OnInitializedAsync();
	} 

	public async void OpenFolder()
	{
		var dirs = await platformsService.FolderBrowser(true);
		path = new Path(dirs);
		StateHasChanged();
	}
































	class Path(string[] paths)
	{
		public string[] Paths { get; set; } = paths;

		public string PathStr
		{
			get { return string.Join(",", value: Paths); }
			set => PathStr = value;
		}
	}

}
