using System;
using System.Drawing;
using System.Windows.Forms;

using SeaBattle;
using SeaBattle.Args;

using SeaWar_GameForm.SeaBattleController;
using SeaWar_GameForm.SeaBattleController.Args;


namespace SeaWar_GameForm {
    public partial class Form1 : Form {

        private SeaWarController game;
        private bool IsHintActive { get; set; }
        private bool IsTotalFind { get; set; }

        public Form1() {
            InitializeComponent();

            game = new SeaWarController(new Game(), this, new Point(130, 50), new Size(45, 45));
            game.SetCageDistance(2);

            // SUBSCRIBE TO EVENTS -->
            game.OnMyCellCageClick += GameController_OnMyCellCageClick;
            game.OnMyCellCageMouseEnter += GameController_OnCellCageMouseEnter;
            game.OnMyCellCageMouseLeave += GameController_OnCellCageMouseLeave;
            game.OnEnemyCellCageClick += GameController_OnEnemyCellCageClick;
            game.OnEnemyCellCageMouseEnter += GameController_OnCellCageMouseEnter;
            game.OnEnemyCellCageMouseLeave += GameController_OnCellCageMouseLeave;
            game.OnCellCageKeyDown += On_KeyDown;
            game.OnTurn += Game_OnTurn;
            game.OnScore += GameController_OnScore;
            game.OnGameReady += GameController_OnGameReady;
            game.OnGameOver += Game_OnGameOver;
            game.OnHintShots += Game_OnHintShot;
            game.History.OnHistoryAdded += History_OnHistoryAdded;

            // START GAME -->
            game.NewGame();
        }

        private void History_OnHistoryAdded(Step Step) {
            String Text = Step.Shot == Shot.Kill ? "Killed" : Step.Shot == Shot.Miss ? "Missed" : Step.Shot == Shot.Hit ? "Hit" : "Hint";
            String Coordinate = "";
            if (Step.IsEnemyStep)
                Coordinate = $"{game.VerticalSymbols[Step.Coordinate.X]}{game.HorisontalSymbols[Step.Coordinate.Y]}";
            else
                Coordinate = $"{game.VerticalSymbols[Step.Coordinate.Y]}{game.HorisontalSymbols[Step.Coordinate.X]}";
            listHistory.Items.Insert(0, $"{(Step.IsEnemyStep ? $"Enemy " : "Me ") + $"({Coordinate}):"} {Text}");
        }

        private void Game_OnHintShot(HintShotsControllerArgs e) {
            if (e.Control.IsEnemyShip) {
                pbSearchShip.Visible = false;
                IsHintActive = false;
            }
            foreach (ShipBox item in e.Area)
                item.HintColor();
        }

        private void Game_OnGameOver(ScoreArgs Score) => MessageBox.Show("Game Over");

        private void Game_OnTurn(Game.Turn Turn) {
            lbTurn.Text = Turn == Game.Turn.Enemy ? "Enemy turn" : "Your turn";
            lbTurn.ForeColor = Turn == Game.Turn.Enemy ? Color.DarkRed : Color.DarkBlue;
            menuStrip1.Focus();
        }

        private void GameController_OnEnemyCellCageClick(ShipBox cage, MouseEventArgs e) {
            if (IsHintActive)
                game.SetHintShot(cage.Position, false);
            else {
                if (game.IsStartBattle && game.Turn == Game.Turn.My)
                    cage.EnterBattleColor(true);
                game.SetMyShot(cage.Position);
            }
        }

        private void GameController_OnScore(ScoreArgs Score) {
            lbMyCount1Ship.Text = $"{Score.CountMyShips.Count1DeckShip}/{game.Settings.Default1DeckShip}";
            lbMyCount2Ship.Text = $"{Score.CountMyShips.Count2DeckShip }/{game.Settings.Default2DeckShip}";
            lbMyCount3Ship.Text = $"{Score.CountMyShips.Count3DeckShip }/{game.Settings.Default3DeckShip}";
            lbMyCount4Ship.Text = $"{Score.CountMyShips.Count4DeckShip}/{game.Settings.Default4DeckShip}";

            lbEnemyCount1Ship.Text = $"{Score.CountEnemyShips.Count1DeckShip}/{game.Settings.Default1DeckShip}";
            lbEnemyCount2Ship.Text = $"{Score.CountEnemyShips.Count2DeckShip }/{game.Settings.Default2DeckShip}";
            lbEnemyCount3Ship.Text = $"{Score.CountEnemyShips.Count3DeckShip}/{game.Settings.Default3DeckShip}";
            lbEnemyCount4Ship.Text = $"{Score.CountEnemyShips.Count4DeckShip }/{game.Settings.Default4DeckShip}";

            lbMyTotal.Text = $"Total: {Score.CountMyShips.GetTotal() } / {game.Settings.GetTotalShips()}";
            lbEnemyTotal.Text = $"Total: {Score.CountEnemyShips.GetTotal() } / {game.Settings.GetTotalShips()}";
        }

        private void GameController_OnMyCellCageClick(ShipBox cage, MouseEventArgs e) {
            if (!game.IsStartBattle) {
                if (e.Button == MouseButtons.Right) {
                    game.SetMyMark(cage.Position);
                    return;
                }
                if (game.CanSetShip(cage.Position)) {
                    game.SetShip(cage.Position);
                    cage.IsShip = !cage.IsShip;
                    cage.EnterColor();
                }
            }
        }

        private void GameController_OnGameReady(bool IsGameReady) {
            btnReady.Enabled = IsGameReady;
        }

        private void GameController_OnCellCageMouseEnter(ShipBox cage) {
            game.SetActiveSymbols(cage);
            if (!game.IsStartBattle) {
                cage.EnterColor();
                if (!cage.IsEnemyShip)
                    if (game.CanSetShip(cage.Position))
                        cage.ClearErrorText();
                    else
                        cage.SetErrorText();
            }
            else {
                if (cage.IsEnemyShip) {
                    if (IsHintActive || IsTotalFind) {
                        foreach (ShipBox ship in game.GetHint(cage.Position, !cage.IsEnemyShip))
                            if (ship.IsShip && IsTotalFind)
                                ship.EnterColor(true);
                            else
                                ship.EnterBattleColor();

                    }
                    else
                        cage.EnterBattleColor();
                }
            }
        }

        private void GameController_OnCellCageMouseLeave(ShipBox cage) {
            game.RemoveActiveSymbols(cage);
            if (!game.IsStartBattle) {
                cage.LeaveColor();
                cage.ClearErrorText();
            }
            else {
                if (IsHintActive || IsTotalFind) {
                    foreach (ShipBox ship in game.GetHint(cage.Position, !cage.IsEnemyShip))
                        if (ship.IsShip && IsTotalFind)
                            ship.LeaveColor(true);
                        else
                            ship.LeaveBattleColor();
                }
                else
                    cage.LeaveBattleColor();
            }
        }

        private void NewGame_Click(object sender, EventArgs e) {
            lbTurn.Visible = false;
            btnRandShips.Visible = btnReady.Visible = true;
            pbSearchShip.Visible = false;
            pbSearchShip.BackColor = Color.Transparent;
            listHistory.Items.Clear();
            game.NewGame();
        }

        private void StartBattle_Click(object sender, EventArgs e) {
            pbSearchShip.Visible = tHint.Checked;
            lbTurn.Visible = true;
            btnRandShips.Visible = btnReady.Visible = false;
            game.StartBattle();
        }

        private void ArtificialIntelligence_Click(object sender, EventArgs e) {
            ToolStripMenuItem menu = sender as ToolStripMenuItem;
            menu.Checked = !menu.Checked;
            game.Settings.IsAI = menu.Checked;
        }

        private void SmartEnemyShot_Click(object sender, EventArgs e) {
            ToolStripMenuItem menu = sender as ToolStripMenuItem;
            menu.Checked = !menu.Checked;
            game.Settings.IsSmartFinishShip = menu.Checked;
        }

        private void Exit_Click(object sender, EventArgs e) => Close();

        private void PbSearchShip_Click(object sender, EventArgs e) {
            PictureBox pb = sender as PictureBox;
            IsHintActive = !IsHintActive;
            pb.BackColor = IsHintActive ? Color.LightBlue : Color.Transparent;
        }

        private void HintToolStripMenuItem_Click(object sender, EventArgs e) {
            ToolStripMenuItem tool = sender as ToolStripMenuItem;
            tool.Checked = !tool.Checked;
            game.Settings.IsHint = tool.Checked;
        }

        private void On_KeyDown(object sender, KeyEventArgs e) {
            if (e.Control && e.KeyCode == Keys.F)
                IsTotalFind = !IsTotalFind;
        }

        private void panel_Paint(object sender, PaintEventArgs e) {
            ControlPaint.DrawBorder(e.Graphics, panel1.ClientRectangle, Color.DarkBlue, ButtonBorderStyle.Solid);
        }

        private void panel17_Paint(object sender, PaintEventArgs e) {
            ControlPaint.DrawBorder(e.Graphics, panel1.ClientRectangle, Color.DarkRed, ButtonBorderStyle.Solid);
        }

        private void RandomMyShips_Click(object sender, EventArgs e) {
            game.SetRandomShips(false);
            game.CheckGameReady();
            GameController_OnScore(game.GetScore());
        }
    }
}
