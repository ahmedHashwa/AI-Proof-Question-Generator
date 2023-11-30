using System.ComponentModel;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AIProofGen
{
    public partial class ConversionForm : Form, INotifyPropertyChanged
    {
        private ConversionForm()
        {
            InitializeComponent();
            CutOffIndexTextBox.DataBindings.Add(nameof(TextBox.Text), this, nameof(CutOffIndex));
            CutOffIndexTrackBar.DataBindings.Add(nameof(TrackBar.Value), this, nameof(CutOffIndex));
            PointsPerCharacterTextBox.DataBindings.Add(nameof(TextBox.Text), this, nameof(PointsPerCharacter));
            PointsPerCharacterTrackBar.DataBindings.Add(nameof(TrackBar.Value), this, nameof(PointsPerCharacter));
            FontSizeTextBox.DataBindings.Add(nameof(TextBox.Text), this, nameof(FontSize));
            FontSizeTrackBar.DataBindings.Add(nameof(TrackBar.Value), this, nameof(FontSize));
        }


        public bool UseGlobalKeyForImageConversion
        {
            get => UseGlobalKeyConvertToImageCheckBox.Checked;
            set => UseGlobalKeyConvertToImageCheckBox.Checked = value;
        }
        public bool UseGlobalKeyForTextReplacement
        {
            get => UseGlobalKeyReplaceTextCheckBox.Checked;
            set => UseGlobalKeyReplaceTextCheckBox.Checked = value;
        }
        public static ConversionForm Instance { get; } = new();


        public static string GetRandomString()
        {
            var randomName = Path.GetRandomFileName();
            randomName = randomName.Replace(".", string.Empty);
            return randomName;
        }

        public int FontSize
        {
            get => _fontSize;
            set => SetField(ref _fontSize, value);
        }

        public int PointsPerCharacter
        {
            get => _pointsPerCharacter;
            set => SetField(ref _pointsPerCharacter, value);
        }

        public int CutOffIndex
        {
            get => _cutOffIndex;
            set => SetField(ref _cutOffIndex, value);
        }

        private void Convert_Click(object sender, EventArgs e)
        {
            ConvertClipboardTextToImage();
        }

        private static string _lastSentence = string.Empty;
        private int _cutOffIndex = 20;
        private int _fontSize = 24;
        private int _pointsPerCharacter = 15;



        public static void ConvertClipboardTextToImage()
        {
            var cutOffIndex = Instance.CutOffIndex;
            var fontSize = Instance.FontSize;
            var pointsPerCharacter = Instance.PointsPerCharacter;
            var antiCheatingSentences = Instance.AntiCheatingLabelsTextBox.Lines;
            var text = Instance.UseClipboardCheckBox.CheckState switch
            {
                CheckState.Checked => Clipboard.GetText(),
                CheckState.Unchecked => Instance.SourceTextBox.Text,
                _ => null
            };
            if (string.IsNullOrWhiteSpace(text))
            {
                return;
            }
            // Get text from clipboard

            for (var i = cutOffIndex; i < text.Length; i += cutOffIndex)
            {
                var spaceIndex = text.LastIndexOf(' ', i);
                if (spaceIndex > 0)
                {
                    text = text[..spaceIndex] + Environment.NewLine + text[(spaceIndex + 1)..];
                }
            }
            var font = new Font(FontFamily.GenericMonospace, fontSize, FontStyle.Bold);
            // Measure the size of the text
            using var tempBitmap = new Bitmap(1, 1, PixelFormat.Format32bppArgb);
            using var tempGraphics = Graphics.FromImage(tempBitmap);
            var textSize = tempGraphics.MeasureString(text, font);
            // Create a new bitmap with the size of the text
            var bitmap = new Bitmap((int)Math.Ceiling(textSize.Width), (int)Math.Ceiling(textSize.Height), PixelFormat.Format32bppArgb);
            bitmap.MakeTransparent();
            // Draw the text onto the Bitmap
            using var g = Graphics.FromImage(bitmap);
            g.Clear(Color.Transparent);
            var rand = new Random();

            ////g.SmoothingMode = SmoothingMode.AntiAlias;
            ////g.TextRenderingHint = TextRenderingHint.AntiAlias;

            var newFont = new Font(FontFamily.GenericMonospace, 40, FontStyle.Bold);
        TryAgain:
            var antiCheatingSentence = antiCheatingSentences?[rand.Next(0, antiCheatingSentences.Length)] ?? "Don't Cheat";
            if (_lastSentence == antiCheatingSentence)
                goto TryAgain;
            _lastSentence = antiCheatingSentence;
            DrawDiagonalString(g, antiCheatingSentence, newFont, Brushes.DarkGray, new RectangleF(10, 10, textSize.Width - 20, textSize.Height - 20));


            g.DrawString(text, font, Brushes.SlateGray, 5, 5);
            g.DrawString(text, font, Brushes.Black, 0, 0);
            for (var i = 0; i < text.Length * pointsPerCharacter; i++)
            {
                var r = rand.Next(1, 10);
                float x = rand.Next(0, (int)textSize.Width);
                float y = rand.Next(0, (int)textSize.Height);
                g.FillEllipse(Brushes.Gray, x, y, r, r);
            }

            Instance.PreviewPictureBox.Image = bitmap;
            if (Instance.SetClipboardCheckBox.CheckState == CheckState.Checked)
            {
                SetClipboardImage(bitmap);

            }
        }
        private static void DrawDiagonalString(Graphics g, string text, Font font, Brush brush, RectangleF rect)
        {
            var textSize = g.MeasureString(text, font);
            var diagonalLength = (float)Math.Sqrt(rect.Width * rect.Width + rect.Height * rect.Height);
            var fontSize = diagonalLength / textSize.Width * font.Size;
            var resizedFont = new Font(font.FontFamily, fontSize, font.Style);
            var newSize = g.MeasureString(text, resizedFont);
            using (resizedFont)
            {
                var angle = (float)(Math.Atan2(rect.Height, rect.Width) * 180 / Math.PI);
                g.TranslateTransform(rect.Left + rect.Width / 2, rect.Top + rect.Height / 2);
                g.RotateTransform(angle);
                g.DrawString(text, resizedFont, brush, -newSize.Width / 2, -newSize.Height / 2);
                g.ResetTransform();
            }
        }
        /// <summary>
        /// Copies the given image to the clipboard as PNG, DIB and standard Bitmap format.
        /// </summary>
        /// <param name="image">Image to put on the clipboard.</param>
        /// <param name="imageNoTr">Optional specifically nontransparent version of the image to put on the clipboard.</param>
        /// <param name="data">Clipboard data object to put the image into. Might already contain other stuff. Leave null to create a new one.</param>
        public static void SetClipboardImage(Bitmap image, Bitmap? imageNoTr = null, DataObject? data = null)
        {
            Clipboard.Clear();
            data ??= new DataObject();
            imageNoTr ??= image;
            using var pngMemStream = new MemoryStream();
            using var dibMemStream = new MemoryStream();
            // As standard bitmap, without transparency support
            data.SetData(DataFormats.Bitmap, true, imageNoTr);
            // As PNG. Gimp will prefer this over the other two.
            image.Save(pngMemStream, ImageFormat.Png);
            data.SetData("PNG", false, pngMemStream);
            // As DIB. This is (wrongly) accepted as ARGB by many applications.
            var dibData = ConvertToDib(image);
            dibMemStream.Write(dibData, 0, dibData.Length);
            data.SetData(DataFormats.Dib, false, dibMemStream);
            // The 'copy=true' argument means the MemoryStreams can be safely disposed after the operation.
            Clipboard.SetDataObject(data, true);
        }
        /// <summary>
        /// Converts the image to Device Independent Bitmap format of type BITFIELDS.
        /// This is (wrongly) accepted by many applications as containing transparency,
        /// so I'm abusing it for that.
        /// </summary>
        /// <param name="image">Image to convert to DIB</param>
        /// <returns>The image converted to DIB, in bytes.</returns>
        public static byte[] ConvertToDib(Image image)
        {
            var width = image.Width;
            var height = image.Height;
            // Ensure image is 32bppARGB by painting it on a new 32bppARGB image.
            using var bm32b = new Bitmap(image.Width, image.Height, PixelFormat.Format32bppArgb);
            using var gr = Graphics.FromImage(bm32b);
            gr.DrawImage(image, new Rectangle(0, 0, bm32b.Width, bm32b.Height));
            // Bitmap format has its lines reversed.
            bm32b.RotateFlip(RotateFlipType.Rotate180FlipX);
            var bm32BData = GetImageData(bm32b, out _);
            // BITMAPINFOHEADER struct for DIB.
            var hdrSize = 0x28;
            var fullImage = new byte[hdrSize + 12 + bm32BData.Length];
            //Int32 biSize;
            WriteIntToByteArray(fullImage, 0x00, 4, true, (uint)hdrSize);
            //Int32 biWidth;
            WriteIntToByteArray(fullImage, 0x04, 4, true, (uint)width);
            //Int32 biHeight;
            WriteIntToByteArray(fullImage, 0x08, 4, true, (uint)height);
            //Int16 biPlanes;
            WriteIntToByteArray(fullImage, 0x0C, 2, true, 1);
            //Int16 biBitCount;
            WriteIntToByteArray(fullImage, 0x0E, 2, true, 32);
            //BITMAPCOMPRESSION biCompression = BITMAPCOMPRESSION.BITFIELDS;
            WriteIntToByteArray(fullImage, 0x10, 4, true, 3);
            //Int32 biSizeImage;
            WriteIntToByteArray(fullImage, 0x14, 4, true, (uint)bm32BData.Length);
            // These are all 0. Since .net clears new arrays, don't bother writing them.
            //Int32 biXPelsPerMeter = 0;
            //Int32 biYPelsPerMeter = 0;
            //Int32 biClrUsed = 0;
            //Int32 biClrImportant = 0;
            // The aforementioned "BITFIELDS": colour masks applied to the Int32 pixel value to get the R, G and B values.
            WriteIntToByteArray(fullImage, hdrSize + 0, 4, true, 0x00FF0000);
            WriteIntToByteArray(fullImage, hdrSize + 4, 4, true, 0x0000FF00);
            WriteIntToByteArray(fullImage, hdrSize + 8, 4, true, 0x000000FF);
            Array.Copy(bm32BData, 0, fullImage, hdrSize + 12, bm32BData.Length);
            return fullImage;
        }
        public static void WriteIntToByteArray(byte[] data, int startIndex, int bytes, bool littleEndian, uint value)
        {
            var lastByte = bytes - 1;
            if (data.Length < startIndex + bytes)
                throw new ArgumentOutOfRangeException(nameof(startIndex), "Data array is too small to write a " + bytes + "-byte value at offset " + startIndex + ".");
            for (var index = 0; index < bytes; index++)
            {
                var offs = startIndex + (littleEndian ? index : lastByte - index);
                data[offs] = (byte)(value >> (8 * index) & 0xFF);
            }
        }/// <summary>
         /// Gets the raw bytes from an image.
         /// </summary>
         /// <param name="sourceImage">The image to get the bytes from.</param>
         /// <param name="stride">Stride of the retrieved image data.</param>
         /// <returns>The raw bytes of the image</returns>
        public static byte[] GetImageData(Bitmap sourceImage, out int stride)
        {
            var sourceData = sourceImage.LockBits(new Rectangle(0, 0, sourceImage.Width, sourceImage.Height), ImageLockMode.ReadOnly, sourceImage.PixelFormat);
            stride = sourceData.Stride;
            var data = new byte[stride * sourceImage.Height];
            Marshal.Copy(sourceData.Scan0, data, 0, data.Length);
            sourceImage.UnlockBits(sourceData);
            return data;
        }
        private void ConversionForm_Load(object sender, EventArgs e)
        {
            SourceTextBox.Text = Clipboard.GetText();

        }

        private void CutOffIndexTextBox_TextChanged(object sender, EventArgs e)
        {
            _ = int.TryParse(CutOffIndexTextBox.Text, out _cutOffIndex);
        }

        private void TextSizeTextBox_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(FontSizeTextBox.Text, out _fontSize);

        }




        private void CopyToClipboardButton_Click(object sender, EventArgs e)
        {
            if (PreviewPictureBox.Image is Bitmap image)
                SetClipboardImage(image);
        }

        private void UseClipboardCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            switch (UseClipboardCheckBox.CheckState)
            {
                case CheckState.Unchecked:
                    SourceTextBox.Enabled = true;
                    break;
                case CheckState.Checked:
                    SourceTextBox.Enabled = false;

                    break;
                case CheckState.Indeterminate:
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void AppNotifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            Show();
        }

        private void ConversionForm_SizeChanged(object sender, EventArgs e)
        {
            if (WindowState== FormWindowState.Minimized)
            {
                Hide();
            }
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string? propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value)) return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
    }
}