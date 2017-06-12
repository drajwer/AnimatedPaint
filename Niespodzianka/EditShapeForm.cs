using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Niespodzianka.Shapes
{
    public partial class EditShapeForm : Form
    {
        public string ItemName { get; set; }
        public AnimatedShape AnimatedShape { get; set; }
        private Color _actualColor;
        public EditShapeForm(ListViewItem item)
        {
            InitializeComponent();
            ItemName = item.SubItems[0].Text;
            AnimatedShape = item.Tag as AnimatedShape;
            if (AnimatedShape?.EndingShape is Circle)
            {
                Circle circle = (Circle) AnimatedShape.EndingShape;
                radiusTextBox.Visible = true;
                radiusTextBox.Text = circle.Radius.ToString();
                radiusLabel.Visible = true;
            }
            textBox1.Text = ItemName;
            _actualColor = AnimatedShape.EndingShape.Color;
            DialogResult = DialogResult.Cancel;
            InitTrackbars();
            pictureBox1.BackColor = _actualColor;
        }

        private void InitTrackbars()
        {
            SetTrackBar(redTrackBar, _actualColor.R);
            SetTrackBar(greenTrackBar, _actualColor.G);
            SetTrackBar(blueTrackBar, _actualColor.B);
        }
        private void SetTrackBar(TrackBar trackBar, int value)
        {
            trackBar.Value = value;
            trackBar.ValueChanged += TrackBar_ValueChanged;
        }
        private void TrackBar_ValueChanged(object sender, EventArgs e)
        {
            byte R = (byte)redTrackBar.Value;
            byte G = (byte)greenTrackBar.Value;
            byte B = (byte)blueTrackBar.Value;
            _actualColor = Color.FromArgb(R, G, B);
            pictureBox1.BackColor = _actualColor;

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            ItemName = textBox1.Text;
            if (AnimatedShape?.EndingShape is Circle)
            {
                Circle circle = (Circle)AnimatedShape.EndingShape;
                circle.Radius = Convert.ToInt32(radiusTextBox.Text);

            }
            AnimatedShape.EndingShape.Color = _actualColor;
            Close();
        }
    }
}
