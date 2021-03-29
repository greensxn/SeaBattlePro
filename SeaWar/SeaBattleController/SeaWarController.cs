using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

using SeaBattle;
using SeaBattle.Args;
using SeaWar_GameForm.SeaBattleController.Args;

namespace SeaWar_GameForm.SeaBattleController {

    class SeaWarController {
        public String[] VerticalSymbols { get; set; }
        public String[] HorisontalSymbols { get; set; }
        public Customization Settings {
            get => Game.Settings;
            set => Game.Settings = value;
        }
        public Moves History {
            get => Game.History;
            set => Game.History = value;
        }
        public int CageDistance { get; private set; } = 4;
        public Color MyCellColor { get; set; } = Color.Gainsboro;
        public Color EnemyCellColor { get; set; } = Color.FromArgb(235, 235, 235);
        public Game.Turn Turn { get; set; }
        public bool IsGameReady {
            get => isGameReady;
            set {
                isGameReady = value;
                OnGameReady?.Invoke(isGameReady);
            }
        }
        public bool IsStartBattle {
            get => isStartBattle;
            set {
                isStartBattle = value;
                OnGameStarted?.Invoke();
            }
        }
        public void SetCageDistance(int value) {
            CageDistance = value;
            RemoveCell();
            SetCell();
        }
        public event Action<ShipBox, MouseEventArgs> OnMyCellCageClick;
        public event Action<ShipBox> OnMyCellCageMouseEnter;
        public event Action<ShipBox> OnMyCellCageMouseLeave;
        public event Action<ShipBox, MouseEventArgs> OnEnemyCellCageClick;
        public event Action<ShipBox> OnEnemyCellCageMouseEnter;
        public event Action<ShipBox> OnEnemyCellCageMouseLeave;
        public event Action<ShipBox, KeyEventArgs> OnCellCageKeyDown;
        public event Action OnGameStarted;
        public event Action OnHintShooted;
        public event Action<ShipBox, PlayerScoreArgs> OnSetShip;
        public event Action<ShipBox, PlayerScoreArgs> OnRemoveShip;
        public event Action<bool> OnGameReady;
        public event Action<Game.Turn> OnTurn;
        public event Action<KillShipControllerArgs> OnKillShip;
        public event Action<ShipHitControllerArgs> OnHitShip;
        public event Action<ShipMissShotControllerArgs> OnMissShotShip;
        public event Action<HintShotsControllerArgs> OnHintShots;
        public event Action<MyShotControllerArgs> OnMyShot;
        public event Action<EnemyShotControllerArgs> OnEnemyShot;
        public event Action<ScoreArgs> OnGameOver;
        public event Action<ScoreArgs> OnScore;

        private List<ShipBox> MyCell { get; set; }
        private List<ShipBox> EnemyCell { get; set; }
        private List<ShipBox> MySymbols { get; set; }
        private List<ShipBox> EnemySymbols { get; set; }
        private bool isStartBattle = false;
        private bool isGameReady = false;
        private Game Game;
        private Form MainForm;
        private Point Location;
        private Size CageSize;


        public SeaWarController(Game Game, Form MainForm, Point Location, Size CageSize) {
            this.Game = Game;
            this.MainForm = MainForm;
            this.Location = Location;
            this.CageSize = CageSize;
            VerticalSymbols = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J" };
            HorisontalSymbols = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };
            MyCell = new List<ShipBox>();
            EnemyCell = new List<ShipBox>();
            MySymbols = new List<ShipBox>();
            EnemySymbols = new List<ShipBox>();

            // SUBSCRIBE TO EVENTS -->
            Game.OnGameStarted += Game_OnGameStarted;
            Game.OnHintShooted += Game_OnHintShooted;
            Game.OnSetShip += Game_OnSetShip;
            Game.OnRemoveShip += Game_OnRemoveShip;
            Game.OnGameReady += Game_OnGameReady;
            Game.OnTurn += Game_OnTurn;
            Game.OnSetRandomShips += Game_OnSetRandomShips;
            Game.OnKillShip += Game_OnKillShip;
            Game.OnHitShip += Game_OnHitShip;
            Game.OnMissShotShip += Game_OnMissShotShip;
            Game.OnHintShots += Game_OnHintShots;
            Game.OnMyShot += Game_OnMyShot;
            Game.OnEnemyShot += Game_OnEnemyShot;
            Game.OnGameOver += Game_OnGameOver;
            Game.OnScore += Game_OnScore;
        }

        public void SetShip(Coordinate position) {
            ShipBox cage = MyCell.Where(c => c.Position == position).FirstOrDefault();

            if (!Game.CanSetMyShip(new Coordinate(position.X, position.Y)))
                return;
            else if (Game.CheckMyShip(position.X, position.Y)) {
                Game.RemoveMyShip(new Coordinate(position.X, position.Y));
                Game.CheckGameReady();
                return;
            }

            Game.SetMyShip(new Coordinate(position.X, position.Y));
            Game.CheckGameReady();
            return;
        }

        public void SetRandomShips(bool IsEnemyShips) => Game.SetShips(IsEnemyShips);

        public bool CanSetShip(Coordinate position) => Game.CanSetMyShip(new Coordinate(position.X, position.Y));

        public ScoreArgs GetScore() => Game.Score;

        public bool SetMyShot(Coordinate position) {
            ShipBox enemyCage = EnemyCell.Where(c => c.Position == position).FirstOrDefault();
            if (Game.IsEnemyTurn || !IsStartBattle || enemyCage.IsMark || enemyCage.IsShooted || Game.IsGameOver)
                return false;

            return Game.SetMyShot(new Coordinate(position.X, position.Y));
        }

        public List<ShipBox> GetHint(Coordinate position, bool IsEnemyShot) {
            List<ShipBox> ships = new List<ShipBox>();
            foreach (Coordinate coordinates in Game.GetHintArea(position, IsEnemyShot))
                ships.Add(EnemyCell.Where(c => c.Position == coordinates).FirstOrDefault());
            return ships;
        }

        public void SetHintShot(Coordinate position, bool IsEnemyShot) {
            Coordinate[] xx = Game.GetHintArea(new Coordinate(position.X, position.Y), IsEnemyShot);
            if (Game.IsEnemyTurn || !IsStartBattle || Game.IsGameOver || xx.Length < 1)
                return;

            Game.SetHintShot(position, IsEnemyShot);
        }

        public void StartBattle() {
            if (!IsGameReady)
                return;
            Game.SetShips(true);
            MyCell.ForEach(e => {
                if (e.IsMark)
                    e.ResetSettings();
            });
            EnemyCell.ForEach(e => e.Color = Color.Gainsboro);
            Game.StartBattle();
        }

        public void SetMyMark(Coordinate position) {
            ShipBox cage = MyCell.Where(c => c.Position == position).FirstOrDefault();
            if (cage.IsMark)
                cage.RemoveMark();
            else
                cage.SetMark();
        }

        public void NewGame() {
            Game.NewGame();
            SetSymbols(true);
            SetSymbols(false);
            RemoveCell();
            SetCell();
            isGameReady = IsStartBattle = false;
            Game.CheckGameReady();
            MyCell.ForEach(c => {
                c.ResetSettings();
                c.BackColor = MyCellColor;
            });
            EnemyCell.ForEach(c => {
                c.ResetSettings();
                c.BackColor = EnemyCellColor;
            });
            Turn = Game.IsEnemyTurn ? Game.Turn.Enemy : Game.Turn.My;
            OnScore?.Invoke(GetScore());
        }

        public void SetActiveSymbols(ShipBox Ship) {
            List<ShipBox> symbols = Ship.IsEnemyShip ?
                EnemySymbols.Where(s => s.Position.Y == Ship.Position.X || s.Position.X == Ship.Position.Y).ToList() :
                MySymbols.Where(s => s.Position.Y == Ship.Position.Y || s.Position.X == Ship.Position.X).ToList();
            foreach (ShipBox item in symbols)
                if (Ship.IsEnemyShip)
                    item.TextColor = Color.DarkRed;
                else
                    item.TextColor = Color.DarkBlue;
        }

        public void RemoveActiveSymbols(ShipBox Ship) {
            List<ShipBox> symbols = Ship.IsEnemyShip ?
                EnemySymbols.Where(s => s.Position.X == Ship.Position.Y || s.Position.Y == Ship.Position.X).ToList() :
                MySymbols.Where(s => s.Position.X == Ship.Position.X || s.Position.Y == Ship.Position.Y).ToList();
            foreach (ShipBox item in symbols)
                item.TextColor = Color.Gray;
        }

        private void SetSymbols(bool IsEnemySymbols) {
            for (int j = 0; j < 2; j++) {
                for (int i = 0; i < 10; i++) {
                    ShipBox symbol = new ShipBox();
                    symbol.ForeColor = Color.Gray;
                    symbol.Font = new Font("Bradley Hand ITC", 20, FontStyle.Bold);
                    symbol.TextAlign = ContentAlignment.MiddleCenter;
                    symbol.Size = CageSize;
                    symbol.Position = new Coordinate(j == 0 ? i : -1, j == 1 ? i : -1);
                    if (IsEnemySymbols && j == 0) {
                        symbol.SetText(VerticalSymbols[i]);
                        symbol.Location = new Point(CageSize.Width * 10 + 155 + Location.Y + i * CageSize.Width + (CageDistance * i), Location.X - CageSize.Height - CageDistance);
                    }
                    if (IsEnemySymbols && j == 1) {
                        symbol.SetText(HorisontalSymbols[i]);
                        symbol.Location = new Point(CageSize.Width * 10 + 155 + Location.Y - CageSize.Width - CageDistance, Location.X + i * CageSize.Height + (CageDistance * i));
                    }
                    if (!IsEnemySymbols && j == 0) {
                        symbol.SetText(VerticalSymbols[i]);
                        symbol.Location = new Point(Location.Y - CageSize.Width - CageDistance, Location.X + i * CageSize.Height + (CageDistance * i));
                    }
                    if (!IsEnemySymbols && j == 1) {
                        symbol.SetText(HorisontalSymbols[i]);
                        symbol.Location = new Point(Location.Y + i * CageSize.Width + (CageDistance * i), Location.X - CageSize.Height - CageDistance);
                    }
                    if (IsEnemySymbols)
                        EnemySymbols.Add(symbol);
                    if (!IsEnemySymbols)
                        MySymbols.Add(symbol);
                    MainForm.Controls.Add(symbol);
                }
            }
        }

        public bool CheckGameReady() => Game.CheckGameReady();

        public void SetCell() {
            if (MyCell.Count == 0)
                for (int i = 0; i < 10; i++)
                    for (int j = 0; j < 10; j++) {
                        ShipBox ship = new ShipBox();
                        ship.IsEnemyShip = false;
                        ship.Position = new Coordinate(i, j);
                        ship.Color = Equals(MyCellColor, Color.Gainsboro) ? Color.Gainsboro : MyCellColor;
                        ship.Size = CageSize;
                        ship.Location = new Point(Location.Y + j * CageSize.Width + (CageDistance * j), Location.X + i * CageSize.Height + (CageDistance * i));
                        ship.IsMouseEnter += (s) => OnMyCellCageMouseEnter?.Invoke(s as ShipBox);
                        ship.IsMouseLeave += (s) => OnMyCellCageMouseLeave?.Invoke(s as ShipBox);
                        ship.IsMouseClick += (s, e) => OnMyCellCageClick?.Invoke(s as ShipBox, e);
                        ship.IsKeyDown += (s, e) => OnCellCageKeyDown?.Invoke(s as ShipBox, e);
                        ship.Cursor = Cursors.Hand;

                        MyCell.Add(ship);
                        MainForm.Controls.Add(ship);
                    }
            if (EnemyCell.Count == 0)
                for (int i = 0; i < 10; i++)
                    for (int j = 0; j < 10; j++) {
                        ShipBox ship = new ShipBox();
                        ship.IsEnemyShip = true;
                        ship.Position = new Coordinate(i, j);
                        ship.Color = Equals(EnemyCellColor, Color.FromArgb(235, 235, 235)) ? Color.FromArgb(235, 235, 235) : EnemyCellColor;
                        ship.Size = CageSize;
                        ship.Location = new Point((CageSize.Width * 10 + 155) + (Location.Y + j * CageSize.Width + (CageDistance * j)), Location.X + i * CageSize.Height + (CageDistance * i));
                        ship.IsMouseEnter += (s) => OnEnemyCellCageMouseEnter?.Invoke(s as ShipBox);
                        ship.IsMouseLeave += (s) => OnEnemyCellCageMouseLeave?.Invoke(s as ShipBox);
                        ship.IsMouseClick += (s, e) => OnEnemyCellCageClick?.Invoke(s as ShipBox, e);
                        ship.Cursor = Cursors.Hand;

                        EnemyCell.Add(ship);
                        MainForm.Controls.Add(ship);
                    }
        }

        public void RemoveCell() {
            for (int i = 0; i < 10; i++)
                for (int j = 0; j < 10; j++) {
                    ShipBox background = MainForm.Controls.OfType<ShipBox>().Where(b => b.Position.X == i && b.Position.Y == j).FirstOrDefault();
                    if (background != null)
                        MainForm.Controls.Remove(background);
                }
            MyCell.Clear();

            for (int i = 0; i < 10; i++)
                for (int j = 0; j < 10; j++) {
                    ShipBox background = MainForm.Controls.OfType<ShipBox>().Where(b => b.Position.X == i && b.Position.Y == j).FirstOrDefault();
                    if (background != null)
                        MainForm.Controls.Remove(background);
                }
            EnemyCell.Clear();
        }

        // EVENTS -->
        private void Game_OnGameStarted() => IsStartBattle = true;
        private void Game_OnTurn(Game.Turn turn) {
            Turn = Game.IsEnemyTurn ? Game.Turn.Enemy : Game.Turn.My;
            OnTurn?.Invoke(Turn);
        }
        private void Game_OnGameReady(bool IsGameReady) => this.IsGameReady = IsGameReady;
        private void Game_OnScore(ScoreArgs e) => OnScore?.Invoke(e);
        private void Game_OnSetShip(Coordinate e) => OnSetShip?.Invoke(MyCell.Where(c => c.Position == e).FirstOrDefault(), Game.Score.CountMyShips);
        private void Game_OnRemoveShip(Coordinate e) => OnRemoveShip?.Invoke(MyCell.Where(c => c.Position == e).FirstOrDefault(), Game.Score.CountMyShips);
        private void Game_OnGameOver(ScoreArgs Score) => OnGameOver?.Invoke(Score);
        private void Game_OnHintShooted() => OnHintShooted?.Invoke();
        private void Game_OnEnemyShot(EnemyShotArgs e) {
            ShipBox ship = MyCell.Where(a => a.Position == e.ShotCoordinate).FirstOrDefault();
            OnEnemyShot?.Invoke(new EnemyShotControllerArgs(ship, e.IsShot));
        }
        private void Game_OnMyShot(MyShotArgs e) {
            ShipBox ship = EnemyCell.Where(a => a.Position == e.ShotCoordinate).FirstOrDefault();
            OnMyShot?.Invoke(new MyShotControllerArgs(ship));
        }
        private void Game_OnHintShots(HintShotsArgs e) {
            ShipBox ship;
            List<ShipBox> area = new List<ShipBox>();
            for (int i = 0; i < e.Area.Length; i++)
                if (e.IsEnemyShot)
                    area.Add(MyCell.Where(a => a.Position == e.Area[i]).FirstOrDefault());
                else
                    area.Add(EnemyCell.Where(a => a.Position == e.Area[i]).FirstOrDefault());

            if (e.IsEnemyShot)
                ship = MyCell.Where(a => a.Position == e.ShotCoordinate).FirstOrDefault();
            else
                ship = EnemyCell.Where(a => a.Position == e.ShotCoordinate).FirstOrDefault();
            OnHintShots?.Invoke(new HintShotsControllerArgs(ship, area));
        }
        private void Game_OnHitShip(ShipHitArgs e) {
            ShipBox ship;
            if (e.IsEnemyShot)
                ship = MyCell.Where(a => a.Position == e.ShotCoordinate).FirstOrDefault();
            else
                ship = EnemyCell.Where(a => a.Position == e.ShotCoordinate).FirstOrDefault();
            ship.SetShoot();
            OnHitShip?.Invoke(new ShipHitControllerArgs(ship));
        }
        private void Game_OnKillShip(ShipKillArgs e) {
            List<ShipBox> marks = new List<ShipBox>();
            ShipBox ship;
            if (e.IsEnemyShot)
                ship = MyCell.Where(a => a.Position == e.ShotCoordinate).FirstOrDefault();
            else
                ship = EnemyCell.Where(a => a.Position == e.ShotCoordinate).FirstOrDefault();
            ship.SetShoot();
            if (e.Marks != null)
                for (int i = 0; i < e.Marks.Length; i++)
                    if (e.IsEnemyShot) {
                        marks.Add(MyCell.Where(a => a.Position == e.Marks[i]).FirstOrDefault());
                        marks[i].SetMark();
                    }
                    else {
                        marks.Add(EnemyCell.Where(a => a.Position == e.Marks[i]).FirstOrDefault());
                        marks[i].SetMark();
                    }
            OnKillShip?.Invoke(new KillShipControllerArgs(ship, marks));
        }
        private void Game_OnMissShotShip(ShipMissShotArgs e) {
            ShipBox ship;
            if (e.IsEnemyShot)
                ship = MyCell.Where(a => a.Position == e.ShotCoordinate).FirstOrDefault();
            else
                ship = EnemyCell.Where(a => a.Position == e.ShotCoordinate).FirstOrDefault();

            ship.SetMark();
            OnMissShotShip?.Invoke(new ShipMissShotControllerArgs(ship));
        }
        private void Game_OnSetRandomShips(Ship ship) {
            if (ship.IsEnemyShip)
                for (int i = 0; i < 10; i++)
                    for (int j = 0; j < 10; j++) {
                        if (Game.EnemyFlot[i, j])
                            EnemyCell.Where(c => c.Position.X == i && c.Position.Y == j).FirstOrDefault().IsShip = true;
                        else
                            EnemyCell.Where(c => c.Position.X == i && c.Position.Y == j).FirstOrDefault().IsShip = false;
                    }
            for (int i = 0; i < 10; i++)
                for (int j = 0; j < 10; j++) {
                    ShipBox cell = MyCell.Where(c => c.Position.X == i && c.Position.Y == j).FirstOrDefault();
                    if (Game.MyFlot[i, j]) {
                        cell.IsShip = true;
                        cell.EnterColor();
                    }
                    else {
                        cell.IsShip = false;
                        cell.LeaveColor();
                    }
                }
        }
    }
}
