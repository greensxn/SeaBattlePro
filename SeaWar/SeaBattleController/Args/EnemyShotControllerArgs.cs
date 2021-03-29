using SeaBattle.Args;

namespace SeaWar_GameForm.SeaBattleController.Args {
    public class EnemyShotControllerArgs : ShotControllerArgs {
        public bool IsShot { get; }
        public EnemyShotControllerArgs(ShipBox Control, bool IsShot) : base(Control) => this.IsShot = IsShot;
    }
}