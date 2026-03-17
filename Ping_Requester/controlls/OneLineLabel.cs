using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingRequester.Client.controlls
{
    /// <summary>
    /// Represents a custom label in which text draws on one verticaly centered line.
    /// </summary>
    public class OneLineLabel : Label
    {
        private ToolTip _toolTip = new ToolTip();
        private bool _isTextTruncated = false;

        public OneLineLabel()
        {
            this.AutoSize = false;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            TextFormatFlags flags = TextFormatFlags.SingleLine |
                                   TextFormatFlags.VerticalCenter |
                                   TextFormatFlags.EndEllipsis;

            if (this.TextAlign == ContentAlignment.MiddleCenter) flags |= TextFormatFlags.HorizontalCenter;
            if (this.TextAlign == ContentAlignment.MiddleRight) flags |= TextFormatFlags.Right;

            Size textSize = TextRenderer.MeasureText(this.Text, this.Font);
            _isTextTruncated = textSize.Width > this.ClientSize.Width;

            TextRenderer.DrawText(e.Graphics, this.Text, this.Font, this.ClientRectangle, this.ForeColor, flags);
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);

            if (_isTextTruncated && !string.IsNullOrEmpty(this.Text))
            {
                _toolTip.SetToolTip(this, this.Text);
            }
            else
            {
                _toolTip.SetToolTip(this, null);
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing) _toolTip?.Dispose();
            base.Dispose(disposing);
        }
    }
}
