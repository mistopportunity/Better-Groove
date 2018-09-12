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
	public sealed partial class AlbumOverviewPage:Page {
		public AlbumOverviewPage() {
			this.InitializeComponent();
		}
		private void Page_SizeChanged(object sender,SizeChangedEventArgs e) {
			if(e.NewSize.Width > e.NewSize.Height) {
				if(!(e.PreviousSize.Width > e.PreviousSize.Height)) {
					VisualStateManager.GoToState(this,"WideState",false);
				}
			} else {
				if(!(e.PreviousSize.Height > e.PreviousSize.Width)) {
					VisualStateManager.GoToState(this,"TallState",false);
				}
			}
		}
	}
}
