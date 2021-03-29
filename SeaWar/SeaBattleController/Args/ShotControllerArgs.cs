namespace SeaWar_GameForm.SeaBattleController.Args {
    public class ShotControllerArgs {
        public ShipBox Control { get; set; }
        public ShotControllerArgs(ShipBox Control) => this.Control = Control;
    }
}
