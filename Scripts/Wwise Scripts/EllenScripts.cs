using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EllenScripts : MonoBehaviour
{

    public AK.Wwise.Event ellen_combo_01;
    public AK.Wwise.Event ellen_combo_02;
    public AK.Wwise.Event ellen_combo_03;
    public AK.Wwise.Event ellen_combo_04;
    public AK.Wwise.Event ellen_death;
    public AK.Wwise.Event ellen_footstep;
    public AK.Wwise.Event ellen_footstep_anim;
    public AK.Wwise.Event ellen_hurt;
    public AK.Wwise.Event ellen_jump;
    public AK.Wwise.Event ellen_land;
    public AK.Wwise.Event ellen_idle_01_beg;
    public AK.Wwise.Event ellen_idle_01_end;
    public AK.Wwise.Event ellen_idle_02;
    public AK.Wwise.Event ellen_idle_03;
    public AK.Wwise.Event ellen_turn_180;
    public AK.Wwise.Event ellen_turn_135;
    public AK.Wwise.Event ellen_turn_90;
    public AK.Wwise.Event ellen_turn_45;
    public AK.Wwise.Event ellen_stand_up;
    public AK.Wwise.Event ellen_land_run;
    public AK.Wwise.Event ellen_land_roll;
    public AK.Wwise.Event ellen_run_forward;
    public AK.Wwise.Event ellen_run_side;
    public AK.Wwise.Event ellen_quick_turn;
    public AK.Wwise.Event RA_idle_1_beg;
    public AK.Wwise.Event RA_idle_1_end;
    public AK.Wwise.Event RA_idle_2_beg;
    public AK.Wwise.Event RA_idle_2_end;

    void play_ellen_combo_01 ()
    {
        ellen_combo_01.Post (this.gameObject);
    }

    void play_ellen_combo_02()
    {
        ellen_combo_02.Post(this.gameObject);
    }

    void play_ellen_combo_03()
    {
        ellen_combo_03.Post(this.gameObject);
    }

    void play_ellen_combo_04()
    {
        ellen_combo_04.Post(this.gameObject);
    }

    void play_RA_idle_1_beg ()
    {
        RA_idle_1_beg.Post(gameObject);
    }

    void play_RA_idle_1_end()
    {
        RA_idle_1_end.Post(gameObject);
    }

    void play_RA_idle_2_beg()
    {
        RA_idle_2_beg.Post(gameObject);
    }

    void play_RA_idle_2_end()
    {
        RA_idle_2_end.Post(gameObject);
    }
    void play_ellen_death ()
    {
        ellen_death.Post(gameObject);
    }

    void play_ellen_footstep ()
    {
        ellen_footstep.Post(gameObject);
    }

    void play_ellen_footstep_anim()
    {
        ellen_footstep_anim.Post(gameObject);
    }

    void play_ellen_hurt ()
    {
        ellen_hurt.Post(gameObject);
    }

    void play_ellen_jump ()
    {
        ellen_jump.Post(gameObject);
    }

    void play_ellen_land()
    {
        ellen_land.Post(gameObject);
    }

    void play_ellen_idle_01_beg ()
    {
        ellen_idle_01_beg.Post(gameObject);
    }

    void play_ellen_idle_01_end()
    {
        ellen_idle_01_end.Post(gameObject);
    }

    void play_ellen_idle_02()
    {
        ellen_idle_02.Post(gameObject);
    }

    void play_ellen_idle_03 ()
    {
        ellen_idle_03.Post(gameObject);
    }

    void play_ellen_turn_180()
    {
        ellen_turn_180.Post(gameObject);
    }

    void play_ellen_turn_135 ()
    {
        ellen_turn_135.Post(gameObject);
    }

    void play_ellen_turn_90()
    {
        ellen_turn_90.Post(gameObject);
    }

    void play_ellen_turn_45 ()
    {
        ellen_turn_45.Post(gameObject);
    }

    void play_ellen_stand_up ()
    {
        ellen_stand_up.Post(gameObject);
    }

    void play_ellen_land_run ()
    {
        ellen_land_run.Post(gameObject);
    }

    void play_ellen_land_roll ()
    {
        ellen_land_roll.Post(gameObject);
    }


    void play_ellen_run_forward ()
    {
        ellen_run_forward.Post(gameObject);
    }

    void play_ellen_run_side ()
    {
        ellen_run_side.Post(gameObject);
    }

    void play_ellen_quick_turn ()
    {
        ellen_quick_turn.Post(gameObject);
    }
}