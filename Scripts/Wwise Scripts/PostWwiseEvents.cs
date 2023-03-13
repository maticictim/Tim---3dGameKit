using UnityEngine;

public class PostWwiseEvents : MonoBehaviour
{
    public AK.Wwise.Event world_pressurepad;
    public AK.Wwise.Event world_healthbox_open;
    public AK.Wwise.Event world_cristal_activate;
    public AK.Wwise.Event world_destructablebox;
    public AK.Wwise.Event world_staff_pickup;
    public AK.Wwise.Event world_dropship_end;
    public AK.Wwise.Event world_dropship_end_stop;


    public void play_world_dropship_lvl2 ()
    {
        world_dropship_end.Post(gameObject);
    }

    public void play_world_dropship_stop()
    {
        world_dropship_end_stop.Post(gameObject);
    }

    public void play_pressurepad ()
    {
        world_pressurepad.Post(gameObject);
    }

    public void healthbox_open ()
    {
        world_healthbox_open.Post (this.gameObject);
    }

    public void cristal_activate ()
    {
        world_cristal_activate.Post(gameObject);
    }

    public void destructablebox ()
    {
        world_destructablebox.Post(gameObject);
    }

    public void staff_pickup()
    {
        world_staff_pickup.Post(gameObject);
    }
}
