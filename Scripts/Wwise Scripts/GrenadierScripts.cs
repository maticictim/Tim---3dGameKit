using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrenadierScripts : MonoBehaviour
{
    public AK.Wwise.Event grenadier_ranged_attack;
    public AK.Wwise.Event grenadier_footstep;
    public AK.Wwise.Event grenadier_turn_180;
    public AK.Wwise.Event grenadier_turn_120;
    public AK.Wwise.Event grenadier_turn_90;
    public AK.Wwise.Event grenadier_turn_45;
    public AK.Wwise.Event grenadier_EMP_attack;
    public AK.Wwise.Event grenadier_mele_attack;
    public AK.Wwise.Event grenadier_hurt;
    public AK.Wwise.Event grenadier_death;
    public AK.Wwise.Event grenadier_spin_attack;
    public AK.Wwise.Event grenadier_idle;
    public AK.Wwise.Event grenadier_spotted;

    void Play_grenadier_ranged_attack ()
    {
        grenadier_ranged_attack.Post(gameObject);
    }

    void play_grenadier_footstep ()
    {
        grenadier_footstep.Post(gameObject);
    }

    void play_grenadier_turn_180 ()
    {
        grenadier_turn_180.Post(gameObject);
    }

    void play_grenadier_turn_120 ()
    {
        grenadier_turn_120.Post(gameObject);
    }

    void play_grenadier_turn_90 ()
    {
        grenadier_turn_90.Post(gameObject);
    }

    void play_grenadier_turn_45 ()
    {
        grenadier_turn_45.Post(gameObject);
    }

    void play_grenadier_EMP_attack ()
    {
        grenadier_EMP_attack.Post(gameObject);
    }

    void play_grenadier_mele_attack ()
    {
        grenadier_mele_attack.Post(gameObject);
    }

    void play_grenadier_hurt ()
    {
        grenadier_hurt.Post(gameObject);
    }

    void play_grenadier_death ()
    {
        grenadier_death.Post(gameObject);
    }

    void play_grenadier_spin_attack ()
    {
        grenadier_spin_attack.Post(gameObject);
    }

    void play_grenadier_idle()
    {
        grenadier_idle.Post(gameObject);
    }

    void play_grenadier_spotted()
    {
        grenadier_spotted.Post(gameObject);
    }
}