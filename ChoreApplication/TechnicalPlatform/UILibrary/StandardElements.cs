using System.Drawing;
using System.Windows.Forms;

namespace ChoreApplication.TechnicalPlatform.UILibrary
{
    internal class StandardElements
    {
        /// <summary>
        /// Creates a standard label.
        /// </summary>
        /// <param name="labelText">Text displayed in label</param>
        /// <param name="isBold">True if text should be bold</param>
        /// <param name="location">Relative location in container</param>
        /// <returns>Label</returns>
        public static Label AddLabel(string labelText, bool isBold, Point location)
        {
            //Sets label with properties
            var label = new Label
            {
                Text = labelText,
                MaximumSize = new Size(310, 20),
                AutoEllipsis = true,
                AutoSize = true,
            };

            //Sets location
            label.Location = location;

            //Sets font 
            if (!isBold)
            {
                label.Font = Properties.Settings.Default.StandardFont;
                return label;
            }
            if (isBold)
            {
                label.Font = Properties.Settings.Default.StandardFontBold;
                return label;
            }
            return label;
        }

        /// <summary>
        /// Creates a standard panel.
        /// </summary>
        public static Panel AddPanel(Point location, int width, int height)
        {
            //Creates panel and sets properties
            Panel currentPanel = new Panel
            {
                Name = "panel",
                Location = location,
                BorderStyle = BorderStyle.FixedSingle,
                Size = new Size(width, height),
                AutoSize = true,
            };
            return currentPanel;
        }

        /// <summary>
        /// Creates a button with image.
        /// </summary>
        /// <param name="location">Relative location in container</param>
        /// <param name="tag">Tag of the button</param>
        /// <param name="image">Image location</param>
        /// <returns>Image button</returns>
        public static Button AddImageButton(Point location, object tag, Bitmap image)
        {
            //Creates the button wit properties
            var currentButton = new Button
            {
                Location = location,
                Size = new Size(30, 30),
                Tag = tag,
                FlatStyle = FlatStyle.Flat,
                BackgroundImage = image,
                BackgroundImageLayout = ImageLayout.Zoom,
                AutoSize = true,
            };

            //Set curser on hover
            currentButton.Cursor = Cursors.Hand;
            currentButton.FlatAppearance.BorderSize = 0;
            currentButton.FlatAppearance.MouseOverBackColor = SystemColors.Window;
            currentButton.FlatAppearance.MouseDownBackColor = SystemColors.Window;

            return currentButton;
        }
    }
}
