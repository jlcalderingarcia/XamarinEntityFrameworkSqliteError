using System;
using ProblemExample.Abstractions;

[assembly: Xamarin.Forms.Dependency(typeof(ProblemExample.Droid.Providers.DroidBasePathProvider))]
namespace ProblemExample.Droid.Providers
{
	public class DroidBasePathProvider : IBasePathProvider
	{
		public string BasePath
		{
			get
			{
				return Environment.GetFolderPath(Environment.SpecialFolder.Personal);
			}
		}
	}
}
