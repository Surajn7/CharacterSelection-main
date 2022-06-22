using UnityEngine;

public class TankModel
{
    private TankController tankController;
 
    public TankModel()
    {

    }

    public void SetTankController(TankController tank_controller)
    {
        tankController = tank_controller;
    }
}
