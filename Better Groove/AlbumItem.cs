using System;
using System.Threading.Tasks;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Media;

namespace Better_Groove {

	public sealed class AlbumItem:DependencyObject {

		public static readonly DependencyProperty NameProperty =
			DependencyProperty.Register(
				"Name",
				typeof(string),
				typeof(AlbumItem),
				new PropertyMetadata(string.Empty)
			);

		public static readonly DependencyProperty PictureProperty =
			DependencyProperty.Register(
				"Picture",
				typeof(ImageBrush),
				typeof(AlbumItem),
				new PropertyMetadata(null)
			);


		private string _name;
		public string Name {
			get {
				return (string)GetValue(NameProperty);
			}
			set {
				_name = value;
				SetValue(NameProperty,value);

			}
		}

		private ImageBrush _pictureBrush;
		public ImageBrush Picture {
			get {
				return _pictureBrush;
			}
		}

		public async void SetPictureBrush(StorageFile imageFile) {
			await Task.Delay(1000);
			_pictureBrush = null;
			SetValue(PictureProperty,null);
		}

	}
}
