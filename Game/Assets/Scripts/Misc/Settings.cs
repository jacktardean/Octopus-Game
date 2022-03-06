﻿using UnityEngine;

public static class Settings
{
    // Player Animation Parameters

    public static int xInput;
    public static int yInput;
    public static int isWalking;
    public static int isRunning;
    public static int toolEffect;
    public static int isUsingToolRight;
    public static int isUsingToolLeft;
    public static int isUsingToolUp;
    public static int isUsingToolDown;
    public static int isLiftingToolLeft;
    public static int isLiftingToolRight;
    public static int isLiftingToolUp;
    public static int isLiftingToolDown;
    public static int isSwingingToolLeft;
    public static int isSwingingToolRight;
    public static int isSwingingToolUp;
    public static int isSwingingToolDown;
    public static int isPickingLeft;
    public static int isPickingRight;
    public static int isPickingUp;
    public static int isPickingDown;

    // Shared Animation Parameters (Player and NPC's)

    public static int idleUp;
    public static int idleDown;
    public static int idleLeft;
    public static int idleRight;

    // Static Constructor
    static Settings()
    {
        // Player Animation Parameters

        xInput = Animator.StringToHash("xInput");
        yInput = Animator.StringToHash("yInput");
        isWalking = Animator.StringToHash("isWalking");
        isRunning = Animator.StringToHash("isRunning");
        toolEffect = Animator.StringToHash("toolEffect");
        isUsingToolRight = Animator.StringToHash("isUsingToolRight");
        isUsingToolLeft = Animator.StringToHash("isUsingToolLeft");
        isUsingToolUp = Animator.StringToHash("isUsingToolUp");
        isUsingToolDown = Animator.StringToHash("isUsingToolDown");
        isLiftingToolLeft = Animator.StringToHash("isLiftingToolLeft");
        isLiftingToolRight = Animator.StringToHash("isLiftingToolRight");
        isLiftingToolUp = Animator.StringToHash("isLiftingToolUp");
        isLiftingToolDown = Animator.StringToHash("isLiftingToolDown");
        isSwingingToolLeft = Animator.StringToHash("isSwingingToolLeft");
        isSwingingToolRight = Animator.StringToHash("isSwingingToolRight");
        isSwingingToolUp = Animator.StringToHash("isSwingingToolUp");
        isSwingingToolDown = Animator.StringToHash("isSwingingToolDown");
        isPickingLeft = Animator.StringToHash("isPickingLeft");
        isPickingRight = Animator.StringToHash("isPickingRight");
        isPickingUp = Animator.StringToHash("isPickingUp");
        isPickingDown = Animator.StringToHash("isPickingDown");

        // Shared Animation Parameters (Player and NPC's)

        idleUp = Animator.StringToHash("idleUp");
        idleDown = Animator.StringToHash("idleDown");
        idleLeft = Animator.StringToHash("idleLeft");
        idleRight = Animator.StringToHash("idleRight");
    }
}