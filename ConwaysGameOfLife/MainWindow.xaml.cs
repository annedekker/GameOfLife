using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace ConwaysGameOfLife
{
    
    public partial class MainWindow : Window
    {
        private GameOfLife lifeGame = new GameOfLife();

        private DispatcherTimer autoPlayTimer = new DispatcherTimer();

        public double fieldViewResolution = 200;
        private double fieldViewWidth { get { return fieldView.ActualWidth; } }
        private double fieldViewHeight { get { return fieldView.ActualHeight; } }
        private int fieldViewMoveX = 0;
        private int fieldViewMoveY = 0;

        private SolidColorBrush liveCellColor = Brushes.Aqua;
        private SolidColorBrush deadCellColor = Brushes.SteelBlue;
        private SolidColorBrush backgroundColor = Brushes.Black;
        private SolidColorBrush gridLineColor = Brushes.White;

        private bool drawDeadCells = true;
        private bool drawGridLines = false;

        private string editorColor = "live";

        private int randomSize = 1;
        private int autoPlaySpeed = 200;

        // Init

        public MainWindow()
        {
            InitializeComponent();

            PatternBox.ItemsSource = LifePatterns.Patterns;

            this.DataContext = this;

            autoPlayTimer.Tick += AutoPlayTimer_Tick;
            autoPlayTimer.Interval = new TimeSpan(0, 0, 0, 0, autoPlaySpeed);

            liveCellColorButton.Background = liveCellColor;
            deadCellColorButton.Background = deadCellColor;
            backgroundColorButton.Background = backgroundColor;
            gridLineColorButton.Background = gridLineColor;

            ColorRSlider.Value = Colors.Aqua.R;
            ColorGSlider.Value = Colors.Aqua.G;
            ColorBSlider.Value = Colors.Aqua.B;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            DrawLifeField();
        }

        // Mouse Controls

        private void MainWindow_MouseMoved(object sender, MouseEventArgs e)
        {
            Point position = Mouse.GetPosition(fieldView);

            // Check if mouse inside field view
            if (position.X < 0 || position.X > fieldViewWidth ||
                position.Y < 0 || position.Y > fieldViewHeight) return;
            // Check if mouse not over visible settings panel
            if (settingsPanel.Visibility == Visibility.Visible)
            {
                Point panelpos = Mouse.GetPosition(settingsPanel);
                if (panelpos.X >= 0 && panelpos.X <= settingsPanel.ActualWidth ||
                    panelpos.Y >= 0 && panelpos.Y <= settingsPanel.ActualHeight) return;
            }
            // Check if mouse not over visible drawing panel
            if (drawingPanel.Visibility == Visibility.Visible)
            {
                Point panelpos = Mouse.GetPosition(drawingPanel);
                if (panelpos.X >= 0 && panelpos.X <= drawingPanel.ActualWidth ||
                    panelpos.Y >= 0 && panelpos.Y <= drawingPanel.ActualHeight) return;
            }

            double cellSize = fieldViewWidth / fieldViewResolution;
            string mouseX = MouseXtoCellX(position.X, cellSize).ToString();
            string mouseY = MouseYtoCellY(position.Y, cellSize).ToString();

            UpdateFieldInfoLabel("Mouse Position: " + mouseX + ", " + mouseY);
        }

        private void MainWindow_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Point position = Mouse.GetPosition(fieldView);

            // Check if mouse inside field view
            if (position.X < 0 || position.X > fieldViewWidth ||
                position.Y < 0 || position.Y > fieldViewHeight) return;
            // Check if mouse not over visible settings panel
            if (settingsPanel.Visibility == Visibility.Visible)
            {
                Point panelpos = Mouse.GetPosition(settingsPanel);
                if (panelpos.X >= 0 && panelpos.X <= settingsPanel.ActualWidth ||
                    panelpos.Y >= 0 && panelpos.Y <= settingsPanel.ActualHeight) return;
            }
            // Check if mouse not over visible drawing panel
            if (drawingPanel.Visibility == Visibility.Visible)
            {
                Point panelpos = Mouse.GetPosition(drawingPanel);
                if (panelpos.X >= 0 && panelpos.X <= drawingPanel.ActualWidth ||
                    panelpos.Y >= 0 && panelpos.Y <= drawingPanel.ActualHeight) return;
            }

            // Do magic
            double cellSize = fieldViewWidth / fieldViewResolution;

            lifeGame.SwitchCell(new XY(MouseXtoCellX(position.X, cellSize), MouseYtoCellY(position.Y, cellSize)));

            DrawLifeField();
        }

        private int MouseXtoCellX(double mouseX, double cellSize)
        {
            int x;
            if (mouseX >= (fieldViewWidth / 2 + fieldViewMoveX) - cellSize / 2 &&
                mouseX <= (fieldViewWidth / 2 + fieldViewMoveX) + cellSize / 2)
            {
                x = 0;
            }
            else if (mouseX >= (fieldViewWidth / 2 + fieldViewMoveX) + cellSize / 2)
            {
                x = (Int32)((mouseX - (fieldViewWidth / 2 + fieldViewMoveX) + (cellSize / 2)) / cellSize);
            }
            else
            {
                x = (Int32)((mouseX - (fieldViewWidth / 2 + fieldViewMoveX) - (cellSize / 2)) / cellSize);
            }
            return x;
        }

        private int MouseYtoCellY(double mouseY, double cellSize)
        {
            int y;
            if (mouseY >= (fieldViewHeight / 2 + fieldViewMoveY) - cellSize / 2 &&
                mouseY <= (fieldViewHeight / 2 + fieldViewMoveY) + cellSize / 2)
            {
                y = 0;
            }
            else if (mouseY >= (fieldViewHeight / 2 + fieldViewMoveY) + cellSize / 2)
            {
                y = (Int32)((mouseY - (fieldViewHeight / 2 + fieldViewMoveY) + (cellSize / 2)) / cellSize);
            }
            else
            {
                y = (Int32)((mouseY - (fieldViewHeight / 2 + fieldViewMoveY) - (cellSize / 2)) / cellSize);
            }
            return y;
        }

        // Controls - Time

        private void NextGenButton_Click(object sender, EventArgs e)
        {
            lifeGame.NextGeneration();
            DrawLifeField();
        }

        private void AutoPlayButton_Click(object sender, EventArgs e)
        {
            if ((sender as Button).Content.ToString().Equals("Start"))
            {
                (sender as Button).Content = "Stop";
                autoPlayTimer.Start();
                nextGenButton.IsEnabled = false;
                autoPlaySpeedSlider.IsEnabled = false;
            }
            else
            {
                (sender as Button).Content = "Start";
                autoPlayTimer.Stop();
                nextGenButton.IsEnabled = true;
                autoPlaySpeedSlider.IsEnabled = true;
            }
        }

        private void AutoPlayTimer_Tick(object sender, EventArgs e)
        {
            lifeGame.NextGeneration();
            DrawLifeField();
        }

        // Controls - Field

        private void MainWindow_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            DrawLifeField();
        }
        
        private void FieldMoveButton_Click(object sender, EventArgs e)
        {
            if ((sender as Button).Name.Contains("UpButton"))
            {
                fieldViewMoveY += 10;
            }
            else if ((sender as Button).Name.Contains("DownButton"))
            {
                fieldViewMoveY -= 10;
            }
            else if ((sender as Button).Name.Contains("LeftButton"))
            {
                fieldViewMoveX += 10;
            }
            else
            {
                fieldViewMoveX -= 10;
            }

            UpdateFieldInfoLabel();
            DrawLifeField();
        }

        private void CenterFieldView_Click(object sender, EventArgs e)
        {
            fieldViewMoveX = 0;
            fieldViewMoveY = 0;

            DrawLifeField();
        }

        private void ClearFieldView_Click(object sender, EventArgs e)
        {
            fieldVisuals.Visuals.Clear();

            lifeGame.Clear();

            UpdateGameInfoLabel();
        }

        private void LoadPattern_Click(object sender, EventArgs e)
        {
            string selection = (string)PatternBox.SelectedItem;

            lifeGame.LoadPattern(selection);

            DrawLifeField();
        }

        private void RandomField_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            lifeGame.Clear();

            for (int x = (randomSize * -1); x <= randomSize; x++)
            {
                for (int y = (randomSize * -1); y <= randomSize; y++)
                {
                    if (rnd.NextDouble() > 0.7)
                    {
                        lifeGame.SwitchCell(new XY(x, y));
                    }
                }
            }

            DrawLifeField();
            UpdateGameInfoLabel();
        }

        // Controls - Panels

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            if (settingsPanel.Visibility == Visibility.Visible) settingsPanel.Visibility = Visibility.Collapsed;
            else settingsPanel.Visibility = Visibility.Visible;
        }

        private void DrawingButton_Click(object sender, EventArgs e)
        {
            if (drawingPanel.Visibility == Visibility.Visible) drawingPanel.Visibility = Visibility.Collapsed;
            else drawingPanel.Visibility = Visibility.Visible;
        }

        // Settings

        private void FieldResolutionSlider_Changed(object sender, EventArgs e)
        {
            int value = (Int32)(sender as Slider).Value;

            fieldViewResolution = value;
            fieldResolutionLabel.Content = "Field Resolution [" + fieldViewResolution.ToString() + " cells/height]";

            DrawLifeField();
        }

        private void RandomSizeSlider_Changed(object sender, EventArgs e)
        {
            randomSize = (Int32)(sender as Slider).Value;

            randomSizeLabel.Content = "Random Generation Size [" + (randomSize * 2 + 1).ToString() + "x"+ (randomSize * 2 + 1).ToString() + "]";
        }

        private void AutoPlaySpeedSlider_Changed(object sender, EventArgs e)
        {
            autoPlaySpeed = (Int32)(sender as Slider).Value;
            autoPlayTimer.Interval = new TimeSpan(0, 0, 0, 0, autoPlaySpeed);

            autoPlaySpeedLabel.Content = "Auto-Play Speed [" + autoPlaySpeed.ToString() + " milisec per turn]";
        }

        // Settings - Game Rules

        private void Underpopulation_Click(object sender, EventArgs e)
        {
            if ((sender as Button).Name.Contains("UpButton"))
            {
                (underpopDownButton).IsEnabled = true;

                lifeGame.UnderPopulation++;

                if (lifeGame.UnderPopulation == 8) (sender as Button).IsEnabled = false;
            }
            else
            {
                (underpopUpButton).IsEnabled = true;

                lifeGame.UnderPopulation--;

                if (lifeGame.OverPopulation == 0) (sender as Button).IsEnabled = false;
            }

            underpopulationLabel.Content = "<= " + lifeGame.UnderPopulation.ToString();
        }

        private void Overpopulation_Click(object sender, EventArgs e)
        {
            if ((sender as Button).Name.Contains("UpButton"))
            {
                overpopulationDownButton.IsEnabled = true;

                lifeGame.OverPopulation++;

                if (lifeGame.OverPopulation == 8) (sender as Button).IsEnabled = false;
            }
            else
            {
                overpopulationUpButton.IsEnabled = true;

                lifeGame.OverPopulation--;

                if (lifeGame.OverPopulation == 0) (sender as Button).IsEnabled = false;
            }

            overpopulationLabel.Content = "=> " + lifeGame.OverPopulation.ToString();
        }

        private void Birthpopulation_Checked(object sender, EventArgs e)
        {
            List<int> boxes = new List<int>();

            try
            {
                if (birthPopulation1Checkbox.IsChecked == true) boxes.Add(1);
                if (birthPopulation2Checkbox.IsChecked == true) boxes.Add(2);
                if (birthPopulation3Checkbox.IsChecked == true) boxes.Add(3);
                if (birthPopulation4Checkbox.IsChecked == true) boxes.Add(4);
                if (birthPopulation5Checkbox.IsChecked == true) boxes.Add(5);
                if (birthPopulation6Checkbox.IsChecked == true) boxes.Add(6);
                if (birthPopulation7Checkbox.IsChecked == true) boxes.Add(7);
                if (birthPopulation8Checkbox.IsChecked == true) boxes.Add(8);
            }
            catch (NullReferenceException) { return; }

            lifeGame.BirthPopulation = boxes.ToArray();

            if (lifeGame.BirthPopulation.Length < 1) birthPopulationLabel.Content = "Birth Population []";
            else
            {
                birthPopulationLabel.Content = "Birth Population [ " + lifeGame.BirthPopulation[0].ToString();
                for (int i = 1; i < lifeGame.BirthPopulation.Length; i++)
                {
                    birthPopulationLabel.Content += ", " + lifeGame.BirthPopulation[i].ToString();
                }
                birthPopulationLabel.Content += " ]";
            }
        }

        // Settings - Drawing and Colors

        private void DrawFieldItems_Checked(object sender, EventArgs e)
        {
            try
            {
                drawDeadCells = (drawDeadCellBox.IsChecked == true);
                drawGridLines = (drawGridLinesBox.IsChecked == true);
            }
            catch (NullReferenceException) { return; }

            DrawLifeField();

            deadCellColorButton.IsEnabled = drawDeadCells;
            gridLineColorButton.IsEnabled = drawGridLines;
        }

        private void DrawBackground_Checked(object sender, EventArgs e)
        {
            if ((sender as CheckBox).IsChecked == true)
            {
                fieldView.Background = backgroundColor;
                backgroundColorButton.IsEnabled = true;
            }
            else
            {
                fieldView.Background = null;
                backgroundColorButton.IsEnabled = true;
            }
        }

        private void ColorSelector_Click(object sender, EventArgs e)
        {
            if ((sender as Button).Name.Contains("live"))
            {
                editorColor = "live";
                ColorVisual.Fill = liveCellColor;
                ColorRSlider.Value = liveCellColor.Color.R;
                ColorGSlider.Value = liveCellColor.Color.G;
                ColorBSlider.Value = liveCellColor.Color.B;
            }
            else if ((sender as Button).Name.Contains("dead"))
            {
                editorColor = "dead";
                ColorVisual.Fill = deadCellColor;
                ColorRSlider.Value = deadCellColor.Color.R;
                ColorGSlider.Value = deadCellColor.Color.G;
                ColorBSlider.Value = deadCellColor.Color.B;
            }
            else if ((sender as Button).Name.Contains("background"))
            {
                editorColor = "background";
                ColorVisual.Fill = backgroundColor;
                ColorRSlider.Value = backgroundColor.Color.R;
                ColorGSlider.Value = backgroundColor.Color.G;
                ColorBSlider.Value = backgroundColor.Color.B;
            }
            else
            {
                editorColor = "grid";
                ColorVisual.Fill = gridLineColor;
                ColorRSlider.Value = gridLineColor.Color.R;
                ColorGSlider.Value = gridLineColor.Color.G;
                ColorBSlider.Value = gridLineColor.Color.B;
            }
        }

        private void ColorRGBSlider_Changed(object sender, EventArgs e)
        {
            Color newcolor = Color.FromRgb(
                (Byte)ColorRSlider.Value,
                (Byte)ColorGSlider.Value,
                (Byte)ColorBSlider.Value);

            ColorVisual.Fill = new SolidColorBrush(newcolor);
        }

        private void SetColor_Click(object sender, EventArgs e)
        {
            Color newcolor = Color.FromRgb(
                (Byte)ColorRSlider.Value,
                (Byte)ColorGSlider.Value,
                (Byte)ColorBSlider.Value);

            switch (editorColor)
            {
                default:
                case "live":
                    liveCellColor = new SolidColorBrush(newcolor);
                    liveCellColorButton.Background = liveCellColor;
                    break;
                case "dead":
                    deadCellColor = new SolidColorBrush(newcolor);
                    deadCellColorButton.Background = deadCellColor;
                    break;
                case "background":
                    backgroundColor = new SolidColorBrush(newcolor);
                    backgroundColorButton.Background = backgroundColor;
                    if (drawBackgroundBox.IsChecked == true) fieldView.Background = backgroundColor;
                    break;
                case "grid":
                    gridLineColor = new SolidColorBrush(newcolor);
                    gridLineColorButton.Background = gridLineColor;
                    break;
            }

            DrawLifeField();
        }

        // Drawing & UI Updates

        private void DrawLifeField()
        {
            UpdateGameInfoLabel();

            double centerX = fieldViewWidth / 2;
            double centerY = fieldViewHeight / 2;

            double cellSize = fieldViewWidth / fieldViewResolution;
            double critterSize = cellSize - (cellSize / 5);
            double critterMargin = cellSize / 10;

            fieldVisuals.Visuals.Clear();

            DrawCritters(lifeGame.LiveCells, centerX, centerY, cellSize, critterSize, critterMargin, liveCellColor);

            if (drawDeadCells)
            {
                DrawCritters(lifeGame.DeadCells, centerX, centerY, cellSize, critterSize, critterMargin, deadCellColor);
            }
        }

        private void DrawCritters(HashSet<XY> critters, double centerX, double centerY, double cellSize, double critterSize, double critterMargin, SolidColorBrush critterColor)
        {
            DrawingVisual dvisual = new DrawingVisual();
            using (DrawingContext dc = dvisual.RenderOpen())
            {
                foreach (XY cell in critters)
                {
                    double x = (centerX + fieldViewMoveX) - (cellSize / 2) + (cell.X * cellSize) + critterMargin;
                    double y = (centerY + fieldViewMoveY) - (cellSize / 2) + (cell.Y * cellSize) + critterMargin;

                    if (x < 0 || (x + cellSize) > fieldViewWidth ||
                        y < 0 || (y + cellSize) > fieldViewHeight) continue;

                    dc.DrawRectangle(critterColor, null, new Rect(
                        x, y, critterSize, critterSize));
                }
            }
            fieldVisuals.Visuals.Add(dvisual);
        }

        private void UpdateGameInfoLabel()
        {
            try
            {
                infoLabelRight.Content = "Alive : " + lifeGame.LiveCells.Count.ToString() +
                "   Dead : " + lifeGame.DeadCells.Count.ToString() +
                "   Generation : " + lifeGame.DeadCells.Count.ToString();
            }
            catch (NullReferenceException) { return; }
        }

        private void UpdateFieldInfoLabel(string mousepos = "Mouse Position: 0, 0")
        {
            infoLabelLeft.Content = "Field Center: " + fieldViewMoveX.ToString() + ", " + fieldViewMoveY.ToString() + "   " + mousepos;
        }

        
    }
}
