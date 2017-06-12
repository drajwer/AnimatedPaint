using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Niespodzianka.Helper;
using Niespodzianka.Shapes;

namespace Niespodzianka
{
    public partial class Form1 : Form
    {
        int lineWidth = 2;
        private bool _drawingStarted;
        private readonly List<AnimatedShape> _animatedShapes;
        private Line _actualLine;
        private Circle _actualCircle;
        private Color _actualColor;
        private int _linesCount;
        private int _circlesCount;
        private Button startShapeButton;
        private Button endShapeButton;
        private BackgroundWorker worker;
        private BgrWorkerHelper bgrWorkerHelper;
        Stopwatch stopwatch = new Stopwatch();
        public Form1()
        {
            InitializeComponent();
            startShapeButton = InitShapeButton();
            endShapeButton = InitShapeButton();
            MinimumSize = new Size(1000, 600);
            _animatedShapes = new List<AnimatedShape>();
            _actualColor = Color.Black;
            startingFramePictureBox.MouseClick += pictureBox1_Click;
            startingFramePictureBox.MouseMove += PictureBox1_MouseMove;
            pictureBoxColorPreview.BackColor = _actualColor;
            worker = new BackgroundWorker();
            worker.DoWork += Worker_DoWork;
            worker.RunWorkerCompleted += WorkerOnRunWorkerCompleted;
            bgrWorkerHelper = new BgrWorkerHelper();
            FPSCounterLabel.Visible = true;

            InitListView(startingFrameListView);
            InitListView(endingFrameListView);
            endingFrameListView.MouseClick += EndingFrameListView_Click;
            endingFrameListView.DoubleClick += EndingFrameListView_DoubleClick;
            endingFrameListView.MouseDown += EndingFrameListView_MouseDown;
        }

        private void WorkerOnRunWorkerCompleted(object sender, RunWorkerCompletedEventArgs runWorkerCompletedEventArgs)
        {
            lock (bgrWorkerHelper)
            {
                bgrWorkerHelper.IsRunning = false;
            }
            StartAnimationButton.Text = "Start";
            FPSCounterLabel.Text = "";
        }

        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            PerformAnimation();
        }

        private void EndingFrameListView_MouseDown(object sender, MouseEventArgs e)
        {
            HideShapeButtons();
        }

        private void EndingFrameListView_Click(object sender, EventArgs e)
        {
            HideShapeButtons();

            ListViewItem focusedItem = endingFrameListView.FocusedItem;
            AnimatedShape animatedShape = focusedItem.Tag as AnimatedShape;
            if (animatedShape == null)
                return;
            startShapeButton.Visible = true;
            startShapeButton.Tag = new ShapeButtonHelper(ShapeButtonHelper.Position.Start, animatedShape.EndingShape);
            if (animatedShape.EndingShape is Line)
            {
                Line line = (Line)animatedShape.EndingShape;
                endShapeButton.Visible = true;
                endShapeButton.Tag = new ShapeButtonHelper(ShapeButtonHelper.Position.End, animatedShape.EndingShape);
                endShapeButton.Location = new Point(line.End.X - endShapeButton.Width / 2, line.End.Y - endShapeButton.Height / 2);
                startShapeButton.Location = new Point(line.Start.X - startShapeButton.Width / 2, line.Start.Y - startShapeButton.Height / 2);
            }
            else if (animatedShape.EndingShape is Circle)
            {
                Circle circle = (Circle)animatedShape.EndingShape;
                startShapeButton.Location = new Point(circle.Center.X - startShapeButton.Width / 2, circle.Center.Y - startShapeButton.Height / 2);
            }
            endingFramePictureBox.Refresh();
        }

        private void HideShapeButtons()
        {
            startShapeButton.Tag = null;
            startShapeButton.Visible = false;
            endShapeButton.Tag = null;
            endShapeButton.Visible = false;
        }

        private Button InitShapeButton()
        {
            Button btn = new Button
            {
                Parent = endingFramePictureBox,
                Visible = false
            };
            btn.Bounds = new Rectangle(0, 0, 8, 8);
            btn.ForeColor = Color.Purple;
            btn.FlatStyle = FlatStyle.Flat;
            btn.BackColor = Color.Purple;
            btn.MouseDown += ShapeBtn_MouseDown;
            btn.MouseMove += ShapeBtn_MouseMove;
            return btn;
        }

        private void ShapeBtn_MouseMove(object sender, MouseEventArgs e)
        {
            Button btn = sender as Button;
            ShapeButtonHelper helper = btn?.Tag as ShapeButtonHelper;
            if (helper == null)
                return;
            if (e.Button == MouseButtons.Left)
            {
                btn.Left = e.X + btn.Left - helper.MouseDownLocation.X;
                btn.Top = e.Y + btn.Top - helper.MouseDownLocation.Y;
                helper.MoveShape(new Point(btn.Location.X + btn.Width / 2, btn.Location.Y + btn.Height / 2));
            }
            endingFramePictureBox.Refresh();
        }

        private void ShapeBtn_MouseDown(object sender, MouseEventArgs e)
        {
            Button btn = sender as Button;
            ShapeButtonHelper helper = btn?.Tag as ShapeButtonHelper;
            if (helper == null)
                return;
            if (e.Button == MouseButtons.Left)
            {
                helper.MouseDownLocation = e.Location;
            }
        }



        public sealed override Size MinimumSize
        {
            get { return base.MinimumSize; }
            set { base.MinimumSize = value; }
        }

        private void EndingFrameListView_DoubleClick(object sender, EventArgs e)
        {
            ListViewItem focusedItem = endingFrameListView.FocusedItem;
            if (!focusedItem.Selected)
                return;
            EditShapeForm form = new EditShapeForm(focusedItem);
            DialogResult result = form.ShowDialog(this);
            if (result != DialogResult.OK)
                return;
            focusedItem.SubItems[0] = new ListViewItem.ListViewSubItem(focusedItem, form.ItemName);
            var startingItems = startingFrameListView.Items.Cast<ListViewItem>();
            var item = startingItems.First(x => x.Tag == focusedItem.Tag);
            item.SubItems[0] = new ListViewItem.ListViewSubItem(item, form.ItemName);
            endingFramePictureBox.Refresh();

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void InitListView(ListView listView)
        {
            listView.View = View.Details;
            listView.Columns.Add("Name", listView.Width / 2);
            listView.Columns.Add("Color", listView.Width / 2);
            listView.KeyDown += ListView_KeyPress;
        }

        private void ListView_KeyPress(object sender, KeyEventArgs keyEventArgs)
        {
            if (keyEventArgs.KeyCode != Keys.Delete)
                return;
            ListView listView = sender as ListView;
            if (listView == null)
                throw new NullReferenceException();
            ListViewItem focusedItem = listView.FocusedItem;
            AnimatedShape shape = focusedItem.Tag as AnimatedShape;
            if (!focusedItem.Selected || shape == null)
                return;
            _animatedShapes.Remove(shape);
            RemoveListViewItem(startingFrameListView, shape);
            RemoveListViewItem(endingFrameListView, shape);
            startingFramePictureBox.Refresh();
            endingFramePictureBox.Refresh();

        }

        private void RemoveListViewItem(ListView listView, AnimatedShape shape)
        {
            foreach (ListViewItem item in listView.Items)
            {
                if (item.Tag == shape)
                {
                    listView.Items.Remove(item);
                    break;
                }
            }
        }

        private void PictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!_drawingStarted)
                return;
            _actualLine.End = new Point(e.X, e.Y);
            _actualCircle.SetRadius(_actualLine.End);
            startingFramePictureBox.Refresh();
        }

        private void pictureBox1_Click(object sender, MouseEventArgs e)
        {
            if (!_drawingStarted)
            {
                Point p = new Point(e.X, e.Y);
                _actualLine = new Line()
                {
                    Start = p,
                    Color = Color.Red
                };

                _actualCircle = new Circle()
                {
                    Center = p,
                    Color = Color.Red
                };
            }
            else
            {
                if (linesRadioButton.Checked)
                {
                    AddLine();
                }
                else
                {
                    AddCircle();
                }
                _actualLine = null;
                _actualCircle = null;
            }
            _drawingStarted = !_drawingStarted;
            startingFramePictureBox.Refresh();
        }

        private void AddCircle()
        {
            _actualCircle.Color = _actualColor;
            AnimatedShape shape = new AnimatedShape()
            {
                StartingShape = _actualCircle.Clone(),
                EndingShape = _actualCircle.Clone(),
                CurrentShape = _actualCircle.Clone()
            };
            _animatedShapes.Add(shape);
            ListViewItem item = new ListViewItem(new[] { $"Circle {++_circlesCount} ", $"Color [{_actualColor}]" });
            item.Tag = shape;
            startingFrameListView.Items.Add(item);
            endingFrameListView.Items.Add((ListViewItem)item.Clone());

        }

        private void AddLine()
        {
            _actualLine.Color = _actualColor;
            AnimatedShape shape = new AnimatedShape()
            {
                StartingShape = _actualLine.Clone(),
                EndingShape = _actualLine.Clone(),
                CurrentShape = _actualLine.Clone()
            };
            _animatedShapes.Add(shape);
            ListViewItem item = new ListViewItem(new[] { $"Line {++_linesCount} ", $"Color [{_actualColor}]" })
            {
                Tag = shape
            };
            startingFrameListView.Items.Add(item);
            endingFrameListView.Items.Add((ListViewItem)item.Clone());
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            IShape actualShape = _actualCircle;
            if (linesRadioButton.Checked)
                actualShape = _actualLine;
            actualShape?.Draw(e.Graphics, lineWidth);
            foreach (var animatedShape in _animatedShapes)
            {
                animatedShape.StartingShape.Draw(e.Graphics, lineWidth);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog myDialog = new ColorDialog();
            // Keeps the user from selecting a custom color.
            myDialog.Color = _actualColor;
            myDialog.AllowFullOpen = false;
            DialogResult result = myDialog.ShowDialog(this);
            if (result != DialogResult.OK)
                return;
            _actualColor = myDialog.Color;
            pictureBoxColorPreview.BackColor = _actualColor;
        }

        private void endingFramePictureBox_Click(object sender, EventArgs e)
        {

        }

        private void endingFramePictureBox_Paint(object sender, PaintEventArgs e)
        {

            foreach (var animatedShape in _animatedShapes)
            {
                animatedShape.EndingShape.Draw(e.Graphics, lineWidth);
            }
        }
        private void animationPictureBox_Paint(object sender, PaintEventArgs e)
        {
            if (stopwatch.IsRunning)
            {
                stopwatch.Stop();
                FPSCounterLabel.Text = (1000 / stopwatch.ElapsedMilliseconds).ToString();
                stopwatch.Reset();
            }
            lock (bgrWorkerHelper)
            {
                if(bgrWorkerHelper.IsRunning)
                    stopwatch.Start();
                else
                    stopwatch.Stop();
            }
            lock (_animatedShapes)
            {
                foreach (var animatedShape in _animatedShapes)
                {
                    animatedShape.CurrentShape.Draw(e.Graphics, lineWidth);
                }

            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            lock (_animatedShapes)
            {
                foreach (var animatedShape in _animatedShapes)
                {
                    animatedShape.CurrentShape = animatedShape.StartingShape.Clone();
                }
            }
            lock (bgrWorkerHelper)
            {
                bgrWorkerHelper.Counter = 0;
            }
            stopwatch.Reset();
            animationPictureBox.Refresh();
        }

        private void StartAnimationButton_Click(object sender, EventArgs e)
        {
            if (StartAnimationButton.Text == "Start")
            {
                lock (bgrWorkerHelper)
                    bgrWorkerHelper.IsRunning = true;
                worker.RunWorkerAsync();
                StartAnimationButton.Text = "Stop";
            }
            else
            {
                lock (bgrWorkerHelper)
                    bgrWorkerHelper.IsRunning = false;
                StartAnimationButton.Text = "Start";
            }
        }

        private void PerformAnimation()
        {
            int counter;
            var stopwatch = new Stopwatch();
            lock (bgrWorkerHelper)
            {
                counter = bgrWorkerHelper.Counter;
            }
            int animationLimit = 300;
            Func<object> getTrackbarValue = () => trackBar1.Value;
            Action refreshAnimationPictureBox = () => animationPictureBox.Refresh();
            while (true)
            {
                int value = (int) trackBar1.Invoke(getTrackbarValue);
                int time = (30 * value) / animationLimit;
                Thread.Sleep(time);
                lock (_animatedShapes)
                {
                    foreach (var animatedShape in _animatedShapes)
                    {
                        int r = animatedShape.StartingShape.Color.R + counter * (animatedShape.EndingShape.Color.R - animatedShape.StartingShape.Color.R) / animationLimit;
                        int g = animatedShape.StartingShape.Color.G + counter * (animatedShape.EndingShape.Color.G - animatedShape.StartingShape.Color.G) / animationLimit;
                        int b = animatedShape.StartingShape.Color.B + counter * (animatedShape.EndingShape.Color.B - animatedShape.StartingShape.Color.B) / animationLimit;
                        int x = animatedShape.StartingShape.GetFirstPoint().X + counter * (animatedShape.EndingShape.GetFirstPoint().X - animatedShape.StartingShape.GetFirstPoint().X) / animationLimit;
                        int y = animatedShape.StartingShape.GetFirstPoint().Y + counter * (animatedShape.EndingShape.GetFirstPoint().Y - animatedShape.StartingShape.GetFirstPoint().Y) / animationLimit;
                        int x2 = animatedShape.StartingShape.GetSecondPoint().X + counter * (animatedShape.EndingShape.GetSecondPoint().X - animatedShape.StartingShape.GetSecondPoint().X) / animationLimit;
                        int y2 = animatedShape.StartingShape.GetSecondPoint().Y + counter * (animatedShape.EndingShape.GetSecondPoint().Y - animatedShape.StartingShape.GetSecondPoint().Y) / animationLimit;
                        animatedShape.CurrentShape.Color = Color.FromArgb(r, g, b);
                        animatedShape.CurrentShape.SetFirstPoint(new Point(x, y));
                        animatedShape.CurrentShape.SetSecondPoint(new Point(x2, y2));
                    }
                }

                animationPictureBox.Invoke(refreshAnimationPictureBox);
                lock (bgrWorkerHelper)
                {
                    if(!bgrWorkerHelper.IsRunning)
                        return;
                    if (counter > animationLimit)
                    {
                        bgrWorkerHelper.Counter = 0;
                        return;
                    }
                    counter = ++bgrWorkerHelper.Counter;
                }
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lock (bgrWorkerHelper)
            {
                bgrWorkerHelper.IsRunning = false;
            }
        }
    }
}
