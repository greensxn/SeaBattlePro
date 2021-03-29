using System.Collections.Generic;

namespace SeaWar_GameForm.SeaBattleController.Args {
    class KillShipControllerArgs : ShotControllerArgs {
        public List<ShipBox> Marks { get; }
        public KillShipControllerArgs(ShipBox Control, List<ShipBox> Marks) : base(Control) {
            this.Control = Control;
            this.Marks = Marks;
        }
    }
}
