﻿using System;
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

namespace Mine_Sweeper
{
    /// <summary>
    /// Interaction logic for MineSweeper.xaml
    /// </summary>
    public partial class MineSweeper : Window
    {
        private List<List<Block>> gridLayout = new List<List<Block>> { };
        private int gamesWon = 0;
        private int gamesLost = 0;
        private int mineCount = 0;
        private int gridCount = 0;
        private int clickCount = 0;
        private int layoutDim = 0;
        private int fontSize = 20;
        //private int diffcultyLevel = 0;
        private DifficultyLevel difficulty;
        private enum DifficultyLevel
        {                
            Newbie = 0,
            Amatuer = 1,
            Pro = 2
        };
        
        public MineSweeper()
        {
            InitializeComponent();
        }

        private void setLayoutSizeAndLevelByDifficulty()
        {
            if ((bool)radioButtonLow.IsChecked)
            {
                this.layoutDim = 7;
                //this.diffcultyLevel = 0;
                this.difficulty = DifficultyLevel.Newbie;
                this.fontSize = 20;
            }
            else if ((bool)radioButtonMedium.IsChecked)
            {
                this.layoutDim = 10;
                //this.diffcultyLevel = 1;
                this.difficulty = DifficultyLevel.Amatuer;
                this.fontSize = 15;
            }
            else if ((bool)radioButtonHigh.IsChecked)
            {
                this.layoutDim = 15;
                //this.diffcultyLevel = 2;
                this.difficulty = DifficultyLevel.Pro;
                this.fontSize = 12;
            }
        }

        private void ResetGridLayoutByDifficulty(int difficultyLevel = 0)
        {
            //layoutGrid.Children.Clear();
            
            int minMines = 0;
            int maxMines = 3;

            switch (this.difficulty)
            {
                case DifficultyLevel.Newbie:
                    minMines = 0; maxMines = 3;
                    break;
                case DifficultyLevel.Amatuer:
                    minMines = 1; maxMines = 4;
                    break;
                case DifficultyLevel.Pro:
                    minMines = 2; maxMines = 5;
                    break;
                default:
                    break;
            }

            Random random = new Random();
            this.gridLayout = new List<List<Block>> { };

            for (int i = 0; i < this.layoutDim; i++)
            {
                List<Block> gridRow = new List<Block> { };
                for (int j = 0; j < this.layoutDim; j++)
                {
                    Block block = new Block(i, j, false, 0);
                    gridRow.Add(block);

                }
                int randCount = random.Next(minMines, maxMines);
                for (int c = 0; c < randCount; c++)
                {
                    int randomRowCellIndex = random.Next(gridRow.Count);
                    gridRow[randomRowCellIndex].isLandmine = true;
                    this.mineCount++;
                }

                gridLayout.Add(gridRow);
            }

            this.ReassignWeights();

        }

        private void ReassignWeights()
        {
            for (int iRow = 0; iRow < gridLayout.Count; iRow++)
            {
                for (int iCol = 0; iCol < gridLayout[0].Count; iCol++)
                {
                    int value = 0;

                    //Left
                    value += iCol > 0 && gridLayout[iRow][iCol - 1].isLandmine ? 1 : 0;
                    //Up
                    value += iRow > 0 && gridLayout[iRow -1 ][iCol].isLandmine ? 1 : 0;
                    //Right
                    value += iCol < gridLayout[0].Count-1 && gridLayout[iRow][iCol + 1].isLandmine ? 1 : 0;
                    //Down
                    value += iRow < gridLayout.Count-1 && gridLayout[iRow + 1][iCol].isLandmine ? 1 : 0;

                    //Left-Up
                    value += iCol > 0 & iRow > 0 && gridLayout[iRow - 1][iCol - 1].isLandmine ? 1 : 0;
                    //Right-Down
                    value += iCol < gridLayout[0].Count-1 && iRow < gridLayout.Count-1 && gridLayout[iRow + 1][iCol + 1].isLandmine ? 1 : 0;
                    //Right-Up
                    value += iCol < gridLayout[0].Count-1 && iRow > 0 && gridLayout[iRow - 1][iCol + 1].isLandmine ? 1 : 0;
                    //Left-Down
                    value += iCol > 0 && iRow < gridLayout.Count-1 && gridLayout[iRow + 1][iCol - 1].isLandmine ? 1 : 0;

                    gridLayout[iRow][iCol].value = value;
                }
            }
        }

        private void buttonPlay_Click(object sender, RoutedEventArgs e)
        {
            buttonPlay.Content = "Reset";
            labelWon.Background = Brushes.White;
            labelLost.Background = Brushes.White;            
            layoutGrid.IsEnabled = true;
            layoutGrid.Children.Clear();
            layoutGrid.RowDefinitions.Clear();
            layoutGrid.ColumnDefinitions.Clear();
            this.gridCount = 0;
            this.mineCount = 0;
            this.clickCount = 0;
            setLayoutSizeAndLevelByDifficulty();

            for (int i = 0; i < this.layoutDim; i++)
            {
                layoutGrid.RowDefinitions.Add(new RowDefinition());
                layoutGrid.ColumnDefinitions.Add(new ColumnDefinition());
                for (int j = 0; j < this.layoutDim; j++)
                {
                    Button b = new Button();
                    b.Name = "button_" + i + "_" + j;
                    
                    Grid.SetRow(b, i);
                    Grid.SetColumn(b, j);

                    b.PreviewMouseLeftButtonDown += new MouseButtonEventHandler(gridButton_LeftMouseButtonDown);
                    b.MouseRightButtonDown += new MouseButtonEventHandler(gridButton_RightMouseButtonDown);
                    
                    //b.Background = (Brush)(buttonPlay.Background);
                    b.Background = Brushes.BlueViolet;
                    b.FontSize = this.fontSize;
                    b.FontWeight = FontWeights.Bold;
                    
                    layoutGrid.Children.Add(b);
                    
                    this.gridCount++;
                }
                
            }

            this.ResetGridLayoutByDifficulty();
            /*
            for (int iRow = 0; iRow < gridLayout.Count; iRow++)
            {
                for (int iCol = 0; iCol < gridLayout[0].Count; iCol++)
                {
                    if (!gridLayout[iRow][iCol].isLandmine)
                    {
                        string btnName = "button_" + iRow.ToString() + "_" + iCol.ToString();
                        int btnIndex = (layoutDim * iRow) + iCol;
                        Button btn = (Button)layoutGrid.Children[btnIndex];

                        btn.Content = gridLayout[iRow][iCol].value.ToString();
                        
                    }
                }
            }
            */
        }
        
        private Image getImageResource(string resourceType)
        {
            string resourcePath = "";
            switch (resourceType)
            {
                case "flag":
                    //resourcePath = "Resources/flag-zoomout.png";
                    //resourcePath = "Resources/flag-zoomout-bg.png";
                    resourcePath = "Resources/flag-zoomout-in-bg.png";
                    break;
                case "mineBlast":
                    resourcePath = "Resources/blast.gif";
                    break;
                case "mine":                    
                    resourcePath = "Resources/mine.png";
                    break;
                default:
                    break;
            }
            BitmapImage btm = new BitmapImage(new Uri(resourcePath, UriKind.Relative));
            Image img = new Image();
            img.Source = btm;
            img.Stretch = Stretch.Fill;
            return img;
        }

        private List<Block> FindNeighbor_0s(Block currentBlock)
        {
            List<Block> neighbour_0_blocks = new List<Block> { };

            int iRow = currentBlock.posX;
            int iCol = currentBlock.posY;

            //Left
            if (iCol > 0 && gridLayout[iRow][iCol - 1].value == 0 && !gridLayout[iRow][iCol - 1].isClicked) neighbour_0_blocks.Add(gridLayout[iRow][iCol - 1]);
            //Up
            if (iRow > 0 && gridLayout[iRow - 1][iCol].value == 0 && !gridLayout[iRow - 1][iCol].isClicked) neighbour_0_blocks.Add(gridLayout[iRow - 1][iCol]);
            //Right
            if (iCol < gridLayout[0].Count - 1 && gridLayout[iRow][iCol + 1].value == 0 && !gridLayout[iRow][iCol + 1].isClicked) neighbour_0_blocks.Add(gridLayout[iRow][iCol + 1]);
            //Down
            if (iRow < gridLayout.Count - 1 && gridLayout[iRow + 1][iCol].value == 0 && !gridLayout[iRow + 1][iCol].isClicked) neighbour_0_blocks.Add(gridLayout[iRow + 1][iCol]);

            ////Left-Up
            //if (iCol > 0 & iRow > 0 && gridLayout[iRow - 1][iCol - 1].value == 0 && !gridLayout[iRow - 1][iCol - 1].isClicked) neighbour_0_blocks.Add(gridLayout[iRow - 1][iCol - 1]);
            ////Right-Down
            //if (iCol < gridLayout[0].Count - 1 && iRow < gridLayout.Count - 1 && gridLayout[iRow + 1][iCol + 1].value == 0 && !gridLayout[iRow + 1][iCol + 1].isClicked) neighbour_0_blocks.Add(gridLayout[iRow + 1][iCol + 1]);
            ////Right-Up
            //if (iCol < gridLayout[0].Count - 1 && iRow > 0 && gridLayout[iRow - 1][iCol + 1].value == 0 && !gridLayout[iRow - 1][iCol + 1].isClicked) neighbour_0_blocks.Add(gridLayout[iRow - 1][iCol + 1]);
            ////Left-Down
            //if (iCol > 0 && iRow < gridLayout.Count - 1 && gridLayout[iRow + 1][iCol - 1].value == 0 && !gridLayout[iRow + 1][iCol - 1].isClicked) neighbour_0_blocks.Add(gridLayout[iRow + 1][iCol - 1]);
            
            return neighbour_0_blocks;
        }

        private List<Block> FindNeighbors(Block currentBlock)
        {
            List<Block> neighbour_blocks = new List<Block> { };

            int iRow = currentBlock.posX;
            int iCol = currentBlock.posY;

            //Left
            if (iCol > 0 && !gridLayout[iRow][iCol - 1].isClicked) neighbour_blocks.Add(gridLayout[iRow][iCol - 1]);
            //Up
            if (iRow > 0 && !gridLayout[iRow - 1][iCol].isClicked) neighbour_blocks.Add(gridLayout[iRow - 1][iCol]);
            //Right
            if (iCol < gridLayout[0].Count - 1 && !gridLayout[iRow][iCol + 1].isClicked) neighbour_blocks.Add(gridLayout[iRow][iCol + 1]);
            //Down
            if (iRow < gridLayout.Count - 1 && !gridLayout[iRow + 1][iCol].isClicked) neighbour_blocks.Add(gridLayout[iRow + 1][iCol]);

            //Left-Up
            if (iCol > 0 & iRow > 0 && !gridLayout[iRow - 1][iCol - 1].isClicked) neighbour_blocks.Add(gridLayout[iRow - 1][iCol - 1]);
            //Right-Down
            if (iCol < gridLayout[0].Count - 1 && iRow < gridLayout.Count - 1 && !gridLayout[iRow + 1][iCol + 1].isClicked) neighbour_blocks.Add(gridLayout[iRow + 1][iCol + 1]);
            //Right-Up
            if (iCol < gridLayout[0].Count - 1 && iRow > 0 && !gridLayout[iRow - 1][iCol + 1].isClicked) neighbour_blocks.Add(gridLayout[iRow - 1][iCol + 1]);
            //Left-Down
            if (iCol > 0 && iRow < gridLayout.Count - 1 && !gridLayout[iRow + 1][iCol - 1].isClicked) neighbour_blocks.Add(gridLayout[iRow + 1][iCol - 1]);

            return neighbour_blocks;
        }

        private void DisplayAllMines(string reason, Button btnClicked)
        {
            for (int iRow = 0; iRow < gridLayout.Count; iRow++)
            {
                for (int iCol = 0; iCol < gridLayout[0].Count; iCol++)
                {
                    if (gridLayout[iRow][iCol].isLandmine)
                    {
                        string btnName = "button_" + iRow.ToString() + "_" + iCol.ToString();
                        int btnIndex = (layoutDim * iRow) + iCol;
                        Button btn = (Button)layoutGrid.Children[btnIndex];
                        if (btn.Name == btnName)
                        {
                            if (reason == "Won")
                            {
                                btn.Content = this.getImageResource("mine");
                            }
                            else if (reason == "Lost" && btn.Name != btnClicked.Name)
                            {
                                btn.Content = this.getImageResource("mine");
                            }                            
                        }
                    }
                }
            }
        }

        private SolidColorBrush GetButtonForegroundColor(string btnContent)
        {
            SolidColorBrush foregroundColor = Brushes.White;

            switch (btnContent)
            {
                case "1":
                    foregroundColor = Brushes.Blue;
                    break;
                case "2":
                    foregroundColor = Brushes.Green;
                    break;
                case "3":
                    foregroundColor = Brushes.Red;
                    break;
                case "4":
                    foregroundColor = Brushes.DarkBlue;
                    break;
                case "5":
                    foregroundColor = Brushes.Brown;
                    break;
                case "6":
                    foregroundColor = Brushes.Cyan;
                    break;
                case "7":
                    foregroundColor = Brushes.Black;
                    break;
                case "8":
                    foregroundColor = Brushes.Gray;
                    break;
                default:
                    break;
            }

            return foregroundColor;
        }

            

    private void PressButton(Button btn)
        {
            if (btn == null || btn.IsEnabled == false) return;
            
            string btnName = btn.Name;
            
            string[] btnNameSplit = btnName.Split('_');
            int rowIndex = Convert.ToInt32(btnNameSplit.GetValue(1));
            int colIndex = Convert.ToInt32(btnNameSplit.GetValue(2));
                        
            // Disable button
            btn.IsEnabled = false;

            Block currentBlock = gridLayout[rowIndex][colIndex];
            currentBlock.isClicked = true;

            // If not a mine, update underlying text
            if (!currentBlock.isLandmine)
            {
                btn.Content = Convert.ToInt32(currentBlock.value.ToString()) > 0 ? currentBlock.value.ToString() : "";
                //btn.Foreground = Brushes.Black;
                btn.Foreground = GetButtonForegroundColor(btn.Content.ToString());

                this.clickCount++;

                if (this.clickCount == this.gridCount - this.mineCount)
                {
                    // Game over! Game won!
                    this.gamesWon++;
                    this.labelWonScore.Content = (this.gamesWon).ToString();
                    layoutGrid.IsEnabled = false;
                    this.DisplayAllMines("Won", btn);
                    labelWon.Background = Brushes.LightGreen;
                }
                else if (currentBlock.value == 0)
                {
                    //List<Block> neighbour_0_blocks = this.FindNeighbor_0s(currentBlock);
                    List<Block> neighbour_blocks = this.FindNeighbors(currentBlock);
                    //foreach (Block block in neighbour_0_blocks)
                    foreach (Block block in neighbour_blocks)
                    {
                        string nbrBtnName = "button_" + block.posX.ToString() + "_" + block.posY.ToString();
                        int indexOfBtn = layoutDim * block.posX + block.posY; // because buttons were added to layoutGrid row by row
                        Button nbrButton = (Button)layoutGrid.Children[indexOfBtn];
                        if (nbrButton.Name == nbrBtnName)
                        {
                            this.PressButton(nbrButton);
                        }                        
                    }
                }

            }
            // else, update background image, end game, update score
            else
            {
                btn.Content = this.getImageResource("mineBlast");
                this.gamesLost++;
                this.labelLostScore.Content = (this.gamesLost).ToString();
                layoutGrid.IsEnabled = false;
                this.DisplayAllMines("Lost", btn);
                labelLost.Background = Brushes.IndianRed;
            }
        }

        private void gridButton_LeftMouseButtonDown(object sender, MouseButtonEventArgs e)
        {            
            this.PressButton((Button)sender);            
        }

        private void gridButton_RightMouseButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (((Button)sender).Content == null || ((Button)sender).Content == "")
            {
                ((Button)sender).Content = this.getImageResource("flag");
            }
            else
            {
                ((Button)sender).Content = "";
            }            
        }
        
        private void Contact_Click(object sender, RoutedEventArgs e)
        {
            Hyperlink source = sender as Hyperlink;

            if (source != null)
            {
                System.Diagnostics.Process.Start(source.NavigateUri.ToString());
            }
        }
    }
}
