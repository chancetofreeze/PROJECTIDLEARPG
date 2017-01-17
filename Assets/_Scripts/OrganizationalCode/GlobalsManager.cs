﻿using UnityEngine;
using System.Collections;

public class GlobalsManager : Singleton<GlobalsManager>
{
    //this class holds any reference that will need to be called over and over by different
    //classes used in different areas of the code. this eliminates the need to update references when they're changed.
    //just update the value here and all the references elsewhere get updated.
	protected GlobalsManager() { }

    public GameObject PLAYER_GAME_OBJECT;
    public Transform PLAYER_TRANSFORM;
    public Rigidbody2D PLAYER_RIGIDBODY;
    public Vector2 PLAYER_VELOCITY;
    public bool PLAYER_FACING_RIGHT; // false is left
    //stuff for jumping
    public Vector2 PLAYER_JUMP_FORCE;
    public bool IS_GROUNDED;
    public Transform GROUND_CHECK;
    public LayerMask GROUND_LAYER;
    public float GROUND_RADIUS;
    public int GRAVITY_VALUE = 10;
    //stuff for camera
    public Camera CURRENT_CAMERA;
    public Transform CURRENT_CAMERA_TRANSFORM;
}
