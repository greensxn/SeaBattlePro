using System.Collections.Generic;

namespace SeaWar_GameForm.SeaBattleController.Args {
    class HintShotsControllerArgs : ShotControllerArgs {
        public List<ShipBox> Area { get; }
        public HintShotsControllerArgs(ShipBox Control, List<ShipBox> Area) : base(Control) => this.Area = Area;
    }
}
