using SeaBattle;
using System.Collections.Generic;

namespace SeaWar_GameForm.SeaBattleController {
    interface ICellElement {
        List<Coordinate> Coordinates { get; set; }
        bool IsShip { get; set; }
        bool IsShooted { get; set; }
        void SetMark();
        void SetShoot();
    }
}
