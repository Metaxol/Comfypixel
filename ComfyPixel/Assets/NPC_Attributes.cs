﻿
using UnityEngine;
using UnityEngine.UI;

public class NPC_Attributes : MonoBehaviour {

    //NPC attributes, more will be added 
    public TextAsset Dialogue;
    public Sprite[] Sprites;
    public Image choose_sprite;
    public Image chosen_sprite;

    //variabled for NPC's to handle dialogue
    private Image dialogue_box;
    private Image sprite_box;

    private PlayerController playerController;
    private Utility utility;
    private Dialogue_System Dialogue_System;

    private void Update()
    {
        //keep adding changing sprites/other special events in this switch statement for the npc's that need it
        if(playerController.NPC_name == name)
        {
            switch (playerController.NPC_name)
            {
                case "NPC":
                    switch (utility.current_line)
                    {
                        //just for testing purposes
                        case 0:
                            sprite_box.sprite = Sprites[0];
                            break;
                        case 1:
                            sprite_box.sprite = Sprites[1];
                            break;
                        case 3:
                            do
                            {
                                utility.spawn_Buttons(choose_sprite, 2,
                                                    new Vector3[] { new Vector3(), new Vector3() },
                                                    new Quaternion[] { new Quaternion(), new Quaternion() });
                            } while (false);
                            break;
                    }
                    break;
            }
        }
    }

    private void Awake()
    {
        dialogue_box = GameObject.Find("dialogue_box").GetComponent<Image>();
        sprite_box = GameObject.Find("sprite_box").GetComponent<Image>();

        utility = FindObjectOfType<Utility>();
        playerController = FindObjectOfType<PlayerController>();
    }
}
