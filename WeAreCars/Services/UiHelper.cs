using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace WeAreCars.Services
{
    /// <summary>
    /// Small helpers for styling controls consistently across the application.
    /// </summary>
    public static class UiHelper
    {
        private static readonly Color BorderGrey = Color.FromArgb(150, 150, 145);   // visible on white
        private static readonly Color BorderFocus = Color.FromArgb(38, 38, 36);     // charcoal while typing

        /// <summary>
        /// Wraps a TextBox in a panel that draws a rounded border around it.
        /// Call this once, after InitializeComponent(). The border turns charcoal
        /// while the box has focus. Assumes the box sits on a white background.
        /// </summary>
        public static void RoundTextBox(TextBox box, int radius = 10)
        {
            Control parent = box.Parent;

           
            box.BorderStyle = BorderStyle.None;
            box.BackColor = Color.White;

            
            int frameHeight = Math.Max(box.PreferredHeight + 16, 38);

            Panel frame = new Panel();
            frame.Bounds = new Rectangle(box.Left, box.Top, box.Width, frameHeight);
            frame.Anchor = box.Anchor;
            frame.TabIndex = box.TabIndex;
            frame.TabStop = false;
            frame.BackColor = Color.White;
            parent.Controls.Add(frame);

            // Move the textbox inside the frame, centred vertically
            box.Parent = frame;
            box.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            box.Location = new Point(14, (frameHeight - box.PreferredHeight) / 2);
            box.Width = frame.Width - 14 - 30;   

            // Draw the rounded border; redraw when focus changes so the colour updates
            frame.Paint += (sender, e) =>
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                Rectangle area = new Rectangle(0, 0, frame.Width - 1, frame.Height - 1);

                using (GraphicsPath path = RoundedRectangle(area, radius))
                using (Pen pen = new Pen(box.Focused ? BorderFocus : BorderGrey, 1.5f))
                {
                    e.Graphics.DrawPath(pen, path);
                }
            };
            box.Enter += (sender, e) => frame.Invalidate();
            box.Leave += (sender, e) => frame.Invalidate();

            // Clicking anywhere on the frame puts the cursor in the textbox
            frame.Click += (sender, e) => box.Focus();
        }

        /// <summary>Builds the outline of a rectangle with rounded corners.</summary>
        private static GraphicsPath RoundedRectangle(Rectangle r, int radius)
        {
            int d = radius * 2;   // arcs are drawn inside a square of this size
            GraphicsPath path = new GraphicsPath();
            path.AddArc(r.X, r.Y, d, d, 180, 90);
            path.AddArc(r.Right - d, r.Y, d, d, 270, 90);
            path.AddArc(r.Right - d, r.Bottom - d, d, d, 0, 90);
            path.AddArc(r.X, r.Bottom - d, d, d, 90, 90);
            path.CloseFigure();
            return path;
        }
    }
}