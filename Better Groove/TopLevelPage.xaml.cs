using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Better_Groove {
	/// <summary>
	/// An empty page that can be used on its own or navigated to within a Frame.
	/// </summary>
	public sealed partial class TopLevelPage:Page {
		public TopLevelPage() {
			this.InitializeComponent();
		}

		private void NavigationView_SelectionChanged(NavigationView sender,NavigationViewSelectionChangedEventArgs args) {
			if(args.IsSettingsSelected) {
				ContentFrame.Navigate(typeof(SettingsPage));
			} else if(args.SelectedItem == AlbumsMenuItem) {
				Type albumsPageType = typeof(AlbumOverviewPage);
				if(ContentFrame.CurrentSourcePageType != albumsPageType) {
					ContentFrame.Navigate(albumsPageType);
				}
			} else if(args.SelectedItem == SongsMenuItem) {
				Type songsPageType = typeof(SongsOverviewPage);
				if(ContentFrame.CurrentSourcePageType != songsPageType) {
					ContentFrame.Navigate(songsPageType);
				}
			}
		}
		private void Page_Loading(FrameworkElement sender,object args) {
			//save the last application state to open the last used one
			NavigationView.SelectedItem = AlbumsMenuItem;
		}
	}
}
