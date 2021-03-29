using SeaBattle;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SeaWar_GameForm.SeaBattleController {
    public partial class ShipBox : UserControl, ICellElement {

        public event Action<ShipBox> IsMouseEnter;
        public event Action<ShipBox> IsMouseLeave;
        public event Action<ShipBox, MouseEventArgs> IsMouseClick;
        public event Action<ShipBox, KeyEventArgs> IsKeyDown;

        private bool IsEnter { get; set; } = false;
        public bool IsMark { get; set; } = false;
        public bool IsEnemyShip { get; set; } = false;
        public bool IsShip { get; set; } = false;
        public bool IsShooted { get; set; } = false;

        public ShipBox() {
            InitializeComponent();
            Coordinates = new List<Coordinate>();
            SetEvent(this);
        }

        public List<Coordinate> Coordinates { get; set; }
        public Coordinate Position { get; set; }

        public void SetShoot() {
            lbShoot.Text = "X";
            lbShoot.Visible = IsShooted = true;
        }

        public void ResetSettings() {
            lbShoot.Text = "";
            lbShoot.Visible = IsMark = IsShooted = IsShip = false;
        }

        public void SetErrorText() {
            if (!IsMark && !IsShip) {
                lbShoot.Text = "❌";
                lbShoot.ForeColor = Color.FromArgb(180, 180, 180);
                lbShoot.Visible = true;
            }
        }

        public void ClearErrorText() {
            if (lbShoot.Text == "❌") {
                lbShoot.Text = "";
                lbShoot.ForeColor = Color.Black;
                lbShoot.Visible = false;
            }
        }

        public void SetMark() {
            lbShoot.Text = "•";
            lbShoot.Visible = IsMark = true;
        }

        public void RemoveMark() {
            lbShoot.Text = "";
            lbShoot.Visible = IsMark = false;
        }

        public void EnterColor(bool IsShowShip = false) {
            if (IsEnemyShip && !IsShowShip)
                return;
            if (!IsShip)
                Color = Color.FromArgb(205, 205, 205);
            else
                Color = Color.AliceBlue;
        }

        public void HintColor() {
            if (IsShip)
                Color = Color.AliceBlue;
            else
                Color = Color.Gainsboro;
        }

        public void LeaveColor(bool IsHideShip = false) {
            if (IsHideShip) {
                if (IsShooted)
                    Color = Color.AliceBlue;
                else
                    Color = Color.Gainsboro;
                return;
            }
            if (IsEnemyShip)
                return;
            if (IsShip)
                Color = Color.AliceBlue;
            else
                Color = Color.Gainsboro;
        }

        public void EnterBattleColor(bool IsShot = false) {
            if (IsEnemyShip) {
                if (IsShip && IsShooted || IsShot && IsShip)
                    Color = Color.AliceBlue;
                else
                    Color = Color.FromArgb(205, 205, 205);
            }
        }

        public void LeaveBattleColor() {
            if (IsEnemyShip) {
                if (IsShooted)
                    Color = Color.AliceBlue;
                else
                    Color = Color.Gainsboro;
            }
        }

        public Color Color {
            get {
                return lbShoot.BackColor;
            }
            set {
                lbShoot.BackColor = value;
                BackColor = value;
            }
        }

        public Color TextColor {
            get {
                return lbShoot.ForeColor;
            }
            set {
                lbShoot.ForeColor = value;
            }
        }

        public ContentAlignment TextAlign {
            get {
                return lbShoot.TextAlign;
            }
            set {
                lbShoot.TextAlign = value;
            }
        }

        public void SetText(string text) {
            lbShoot.Text = text;
            lbShoot.Visible = true;
        }

        public void ResetText(string text) {
            lbShoot.Text = "";
            lbShoot.Visible = false;
        }

        public override Font Font {
            get {
                return lbShoot.Font;
            }
            set {
                lbShoot.Font = value;
            }
        }

        private void SetEvent(Control mainControl, params Control[] Exceptions) {
            foreach (Control control in mainControl.Controls)
                SetEvent(control, Exceptions);

            if (!Exceptions.Contains(mainControl)) {
                mainControl.MouseClick += OnMouseClick;
                mainControl.MouseEnter += OnMouseEnter;
                mainControl.MouseLeave += OnMouseLeave;
                mainControl.KeyDown += OnKeyDown;
            }
        }

        private void OnMouseEnter(object sender, EventArgs e) {
            if (!IsEnter) {
                IsEnter = true;
                IsMouseEnter?.Invoke(this);
            }
        }

        private void OnMouseClick(object sender, MouseEventArgs e) {
            IsMouseClick?.Invoke(this, e);
        }

        private void OnMouseLeave(object sender, EventArgs e) {
            if (ClientRectangle.Contains(PointToClient(Control.MousePosition)))
                return;
            else {
                IsEnter = false;
                IsMouseLeave?.Invoke(this);
            }
        }

        private void OnKeyDown(object sender, KeyEventArgs e) {
            IsKeyDown?.Invoke(this, e);
        }
    }
}
