using System.Drawing;
using System.Windows.Forms;

namespace ChoreApplication.UI.UILibrary
{
    internal class StandardElements
    {
        public static Label AddLabel(string labelText, bool isBold, Point location)
        {
            var label = new Label
            {
                Text = labelText,
                MaximumSize = new Size(310, 20),
                AutoEllipsis = true,
                AutoSize = true,
            };
            label.Location = location;
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

        public static Panel AddPanel(Point location, int width, int height)
        {
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

        public static Button AddImageButton(Point location, object tag, Bitmap image)
        {
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
            currentButton.Cursor = Cursors.Hand;
            currentButton.FlatAppearance.BorderSize = 0;
            currentButton.FlatAppearance.MouseOverBackColor = SystemColors.Window;
            currentButton.FlatAppearance.MouseDownBackColor = SystemColors.Window;

            return currentButton;
        }
    }
}
