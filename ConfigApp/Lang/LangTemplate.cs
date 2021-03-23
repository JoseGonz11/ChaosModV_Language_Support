﻿using System.Collections.Generic;

namespace ConfigApp
{
    class Template
    {
        public static readonly Dictionary<string, string> EffectConfig = new Dictionary<string, string>()
        {
            { "effectconf_timer_type1", "" },                   //Normal
            { "effectconf_timer_type2", "" },                   //Short
            { "effect_rename", "" },                            //Rename Effect
            { "effect_override_timer_type", "" },               //Override Timed Effect Type
            { "effect_override_timer_manual", "" },             //Override Timed Effect Timer Length (Seconds)
            { "effect_make_permanent", "" },                    //Make Permanent (Might not work well with every effect)
            { "effectconf_effect_weight_mult_title", "" },      //Set Effect Weight Multiplier (Affects chances of this effect occuring) lowest: 1, highest: 10, default: 5
            { "effectconf_exclude_voting_enable_title", "" },   //Exclude Effect from Voting (Twitch)
            { "effectconf_mp3_label", "" },                     //Sound to play when this effect is active:     chaosmod/sounds/
            { "button_save", "" }                               //save
        };
        public static readonly Dictionary<string, string> PopupMSGs = new Dictionary<string, string>()
        {
            { "no_write_permission_msg", "" },  //No permissions to write in the current directory. Try either running the program as admin or allowing write access to the current directory.
            { "no_write_permission_title", "" },//No Write Access
            { "reset_click_msg", "" },          //Are you sure you want to reset your config?
            { "reset_twitch_msg", "" },         //Do you want to reset your Twitch settings too?
            { "reset_complete_msg", "" },       //Config has been reverted to default settings!
            { "save_complete_msg", "" },        //Saved Config!     Make sure to press CTRL + L in-game twice if mod is already running to reload the config.
        };
        public static readonly string[] voteModes = new string[]
        {
            "", //Chat Messages
            "", //Ingame Overlay
            ""  //OBS Overlay
        };
        public static readonly Dictionary<string, string> App = new Dictionary<string, string>()
        {
            { "title", ""},                                                 //ChaosModV Configuration
            { "user_save", ""},                                             //Save
            { "user_reset", ""},                                            //Reset
            { "lang_label", "" },                                           //Language
            { "effects_tab", "" },                                          //Effects
            { "meta_tab", "" },                                             //Meta
            { "misc_tab", "" },                                             //Misc
            { "twitch_tab", ""},                                            //Twitch
            { "more_tab", ""},                                              //More
            { "no_update_available_label", "" },                            //You are on the newest version of the mod!
            { "update_available_label", "" },                               //A new version is available! Visit the GTA5-Mods thread for a download and changelogs.
            { "update_error", ""},                                          //Unable to check for new updates!
            { "meta_cooldown_label", ""},                                   //How often should a new meta start (in seconds)?
            { "meta_duration_label", "" },                                  //How long should meta effects last (in seconds)?
            { "meta_short_label", "" },                                     //How long should short timed meta effects last (in seconds)?
            { "effect_timer", ""},                                          //How often should a new effect start (in seconds)?
            { "effect_duration", ""},                                       //How long should timed effects last (in seconds)?
            { "effect_duration_short", ""},                                 //How long should short timed effects last (in seconds)?
            { "effects_seed", ""},                                          //Random Seed (Leave empty for random seed every time)
            { "timebar_color", ""},                                         //Timer Bar Color
            { "effect_textcolor", ""},                                      //Effect Text Color
            { "effect_timer_color", ""},                                    //Effect Timer Bar Color
            { "timebar_draw", ""},                                          //Don't draw timer bar
            { "effect_text_draw", ""},                                      //Don't draw effect text
            { "clear_effects", ""},                                         //Enable clear active effects shortcut (CTRL + -)
            { "mod_toggle", ""},                                            //Enable toggle mod shortcut (CTRL + L)
            { "effect_menu", ""},                                           //Enable effects menu (allows you to choose effects manually, CTRL + ,)
            { "timebar_pause", "" },                                        //Enable pause timer shortcut (CTRL + .)
            { "twitch_info", "" },                                          //This feature allows Twitch chat to vote for an effect from a collection of random ones each time the timer runs out by making use of Twitch's chat feature.\nThere are specific options you can / must configure below.\nConsult the twitch__readme.txt file included with the mod (inside the README folder) for more information.
            { "twitch_user_agreed", "" },                                   //Enable Twitch Voting
            { "twitch_user_channel_name_label", "" },                       //Channel Name
            { "twitch_user_user_name_label", "" },                          //Username
            { "twitch_user_channel_oauth_label", "" },                      //OAuth Token
            { "twitch_user_effects_secs_before_chat_voting_label", "" },    //Only enable chat voting X seconds before new effect triggers      (Keep at 0 to allow chat to immediately vote, value can't be 1)
            { "twitch_user_overlay_mode_label", "" },                       //Voting Overlay Mode
            { "twitch_user_random_voteable_enable_label", "" },             //Enable "Random Effect" voteable option
            { "proportional_vote", "---------- \" ----------" },            //---------- Proportional Voting Mode ----------
            { "twitch_user_chance_system_enable_label", "" },               //Enable proportional voting mode
            { "twitch_user_chance_system_retain_chance_enable_label", "" }, //Effects without votes should never lose their initial chance
            { "mod_page", "" },                                             //Visit the mod page for more information
            { "donation", "" },                                             //Enjoying the mod? Buy me a coffee! :)
            { "contribute", "" },                                           //Want to contribute to the mod? It's open source!
            { "discord", "" }                                               //Join our Discord for announcements, support and more!
        };
        public static readonly Dictionary<int, string> EffectsCategoryLabels = new Dictionary<int, string>()
        {
            {0, "" },   //Player
            {1, "" },   //Vehicle
            {2, "" },   //Peds
            {3, "" },   //Time
            {4, "" },   //Weather
            {5, "" },   //Misc
            {6, "" }    //Meta
        };
        public static readonly Dictionary<string, string> EffectsMap = new Dictionary<string, string>()
        {
            {"player_suicide", ""},             //Suicide
            {"player_plus2stars",""},           //+2 Wanted Stars
            {"player_5stars",""},               //5 Wanted Stars
            {"player_neverwanted",""},          //Never Wanted
            {"peds_remweps",""},                //Remove Weapons From Everyone
            {"player_heal",""},                 //HESOYAM
            {"player_ignite", ""},              //Ignite Player
            {"spawn_grieferjesus", ""},         //Spawn Griefer Jesus
            {"peds_spawnimrage", ""},           //Spawn Impotent Rage
            {"spawn_grieferjesus2", ""},        //Spawn Extreme Griefer Jesus
            {"peds_ignite", ""},                //Ignite All Nearby Peds
            {"vehs_explode", ""},               //Explode All Nearby Vehicles
            {"player_upupaway", ""},            //Launch Player Up
            {"vehs_upupaway", ""},              //Launch All Vehicles Up
            {"playerveh_lock", ""},             //Lock Player Inside Vehicle
            {"nothing", ""},                    //Nothing
            {"playerveh_killengine", ""},       //Kill Engine Of Every Vehicle
            {"time_morning", ""},               //Set Time To Morning
            {"time_day", ""},                   //Set Time To Daytime
            {"time_evening", ""},               //Set Time To Evening
            {"time_night", ""},                 //Set Time To Night
            {"weather_extrasunny", ""},         //Extra Sunny Weather
            {"weather_stormy", ""},             //Stormy Weather
            {"weather_foggy", ""},              //Foggy Weather
            {"weather_neutral", ""},            //Neutral Weather
            {"weather_snowy", ""},              //Snowy Weather
            {"tp_lsairport", ""},               //Teleport To LS Airport
            {"tp_mazebanktower", ""},           //Teleport To Top Of Maze Bank Tower
            {"tp_fortzancudo", ""},             //Teleport To Fort Zancudo
            {"tp_skyfall", ""},                 //Teleport To Heaven
            {"tp_mountchilliad", ""},           //Teleport To Mount Chiliad
            {"tp_random", ""},                  //Teleport To Random Location
            {"tp_mission", ""},                 //Teleport To Random Mission
            {"tp_fake", ""},                    //Fake Teleport
            {"player_nophone", ""},             //No Phone
            {"player_tpclosestveh", ""},        //Set Player Into Closest Vehicle
            {"playerveh_exit", ""},             //Everyone Exits Their Vehicles
            {"time_x02", ""},                   //x0.2 Gamespeed
            {"time_x05", ""},                   //x0.5 Gamespeed
            {"time_lag", ""},                   //Lag
            {"peds_riot", ""},                  //Peds Riot
            {"vehs_red", ""},                   //Red Traffic
            {"vehs_blue", ""},                  //Blue Traffic
            {"vehs_green", ""},                 //Green Traffic
            {"vehs_chrome", ""},                //Chrome Traffic
            {"vehs_pink", ""},                  //Hot Traffic
            {"vehs_rainbow", ""},               //Rainbow Traffic
            {"player_firstperson", ""},         //First Person
            {"vehs_slippery", ""},              //Slippery Vehicles
            {"vehs_nogravity", ""},             //Vehicles Have No Gravity
            {"player_invincible", ""},          //Invincibility
            {"vehs_x2engine", ""},              //2x Vehicle Engine Speed"
            {"vehs_x10engine", ""},             //10x Vehicle Engine Speed"
            {"vehs_x05engine", ""},             //0.5x Vehicle Engine Speed
            {"spawn_rhino", ""},                //Spawn Rhino
            {"spawn_adder", ""},                //Spawn Adder
            {"spawn_dump", ""},                 //Spawn Dump
            {"spawn_monster", ""},              //Spawn Monster
            {"spawn_bmx", ""},                  //Spawn BMX
            {"spawn_tug", ""},                  //Spawn Tug
            {"spawn_cargo", ""},                //Spawn Cargo Plane
            {"spawn_bus", ""},                  //Spawn Bus
            {"spawn_blimp", ""},                //Spawn Blimp
            {"spawn_buzzard", ""},              //Spawn Buzzard
            {"spawn_faggio", ""},               //Spawn Faggio
            {"spawn_ruiner3", ""},              //Spawn Ruined Ruiner
            {"spawn_baletrailer", ""},          //Spawn Bale Trailer
            {"spawn_romero", ""},               //Where's The Funeral?
            {"spawn_random", ""},               //Spawn Random Vehicle
            {"notraffic", ""},                  //No Traffic
            {"playerveh_explode", ""},          //Detonate Current Vehicle
            {"peds_ghost", ""},                 //Everyone Is A Ghost
            {"vehs_ghost", ""},                 //Invisible Vehicles
            {"no_radar", ""},                   //No Radar
            {"no_hud", ""},                     //No HUD
            {"player_superrun", ""},            //Super Run & Super Jump
            {"player_ragdoll", ""},             //Ragdoll
            {"peds_ragdoll", ""},               //Ragdoll Everyone
            {"peds_sensitivetouch", ""},        //Sensitive Touch
            {"poorboi", ""},                    //Poor Boy
            {"player_famous", ""},              //You Are Famous
            {"player_drunk", ""},               //Drunk
            {"player_ohko", ""},                //One Hit KO
            {"screen_bloom", ""},               //Bloom
            {"screen_lsd", ""},                 //LSD
            {"screen_lowrenderdist", ""},       //Where Did Everything Go?
            {"screen_fog", ""},                 //Extreme Fog
            {"screen_lsnoire", ""},             //LS Noire
            {"screen_bright", ""},              //Deep Fried
            {"screen_mexico", ""},              //Is This What Mexico Looks Like?
            {"screen_fullbright", ""},          //Fullbright
            {"screen_bubblevision", ""},        //Bubble Vision
            {"peds_blind", ""},                 //Blind Peds
            {"vehs_honkboost", ""},             //Honk Boosting
            {"peds_mindmg", ""},                //Minimal Damage
            {"peds_frozen", ""},                //Peds Are Brainless
            {"lowgravity", ""},                 //Low Gravity
            {"verylowgravity", ""},             //Very Low Gravity
            {"insanegravity", ""},              //Insane Gravity
            {"invertgravity", ""},              //Invert Gravity
            {"playerveh_repair", ""},           //Repair All Vehicles
            {"playerveh_poptires", ""},         //Pop Tires Of Every Vehicle
            {"vehs_poptiresconstant", ""},      //Now This Is Some Tire Poppin'
            {"player_nospecial", ""},           //No Special Ability
            {"peds_dance", ""},                 //In The Hood
            {"player_forcedcinematiccam", ""},  //Cinematic Vehicle Cam
            {"peds_flee", ""},                  //All Nearby Peds Are Fleeing
            {"playerveh_breakdoors", ""},       //Break Doors Of Every Vehicle
            {"zombies", ""},                    //Explosive Zombies
            {"meteorrain", ""},                 //Meteor Shower
            {"world_blackout", ""},             //Blackout
            {"time_quickday", ""},              //Timelapse
            {"player_noforwardbackward", ""},   //Disable Forwards / Backwards Movement
            {"player_noleftright", ""},         //Disable Left / Right Movement
            {"player_break", ""},               //Autopilot
            {"peds_giverpg", ""},               //Give Everyone An RPG
            {"peds_stungun", ""},               //Give Everyone A Stun Gun
            {"peds_minigun", ""},               //Give Everyone A Minigun
            {"peds_upnatomizer", ""},           //Give Everyone An Up-N-Atomizer
            {"peds_randomwep", ""},             //Give Everyone A Random Weapon
            {"peds_railgun", ""},               //Give Everyone A Railgun
            {"peds_battleaxe", ""},             //Give Everyone A Battle Axe
            {"player_nosprint", ""},            //No Sprint & No Jump
            {"peds_invincible", ""},            //Everyone Is Invincible
            {"vehs_invincible", ""},            //All Vehicles Are Invulnerable
            {"player_ragdollondmg", ""},        //Player Ragdolls When Shot
            {"vehs_jumpy", ""},                 //Jumpy Vehicles
            {"vehs_lockdoors", ""},             //Lock All Vehicles
            {"chaosmode", ""},                  //Doomsday
            {"player_noragdoll", ""},           //No Ragdoll
            {"vehs_honkconstant", ""},          //All Vehicles Honk
            {"player_tptowaypoint", ""},        //Teleport To Waypoint
            {"peds_sayhi", ""},                 //Friendly Neighborhood
            {"peds_insult", ""},                //Unfriendly Neighborhood
            {"player_explosivecombat", ""},     //Explosive Combat
            {"player_allweps", ""},             //Give All Weapons
            {"peds_aimbot", ""},                //Aimbot Peds
            {"spawn_chop", ""},                 //Spawn Companion Doggo
            {"spawn_chimp", ""},                //Spawn Companion Chimp
            {"spawn_compbrad", ""},             //Spawn Companion Brad
            {"spawn_comprnd", ""},              //Spawn Random Companion
            {"player_nightvision", ""},         //Night Vision
            {"player_heatvision", ""},          //Heat Vision
            {"player_moneydrops", ""},          //Money Rain
            {"playerveh_tprandompeds", ""},     //Teleport Random Peds Into Current Vehicle
            {"peds_revive", ""},                //Revive Dead Peds
            {"world_snow", ""},                 //Snow
            {"world_whalerain", ""},            //Whale Rain
            {"playerveh_maxupgrades", ""},      //Add Max Upgrades To Every Vehicle
            {"playerveh_randupgrades", ""},     //Add Random Upgrades To Every Vehicle
            {"player_arenawarstheme", ""},      //Play Arena Wars Theme
            {"peds_driveby", ""},               //Peds Drive-By Player
            {"player_randclothes", ""},         //Randomize Player Clothes
            {"peds_rainbowweps", ""},           //Rainbow Weapons
            {"traffic_gtao", ""},               //Traffic Magnet
            {"spawn_bluesultan", ""},           //Spawn Blue Sultan
            {"player_setintorandveh", ""},      //Set Player Into Random Vehicle
            {"traffic_fullaccel", ""},          //Full Acceleration
            {"misc_spawnufo", ""},              //Spawn UFO
            {"misc_spawnferriswheel", ""},      //Spawn Ferris Wheel
            {"peds_explosive", ""},             //Explosive Peds
            {"invertvelocity", ""},             //Invert Current Velocity
            {"player_tpeverything", ""},        //Teleport Everything To Player
            {"weather_randomizer", ""},         //Disco Weather
            {"world_lowpoly", ""},              //Low Render Distance
            {"peds_obliterate", ""},            //Obliterate All Nearby Peds
            {"vehs_alarmloop", ""},             //Alarmy Vehicles
            {"veh_randomseat", ""},             //Set Player Into Random Vehicle Seat
            {"veh_30mphlimit", ""},             //30MPH Speed Limit
            {"veh_jesustakethewheel", ""},      //Jesus Take The Wheel
            {"veh_poptire", ""},                //Random Tire Popping
            {"peds_angryalien", ""},            //Spawn Angry Alien
            {"peds_angryjimmy", ""},            //Spawn Jealous Jimmy
            {"vehs_ohko", ""},                  //Vehicles Explode On Impact
            {"vehs_spamdoors", ""},             //Spammy Vehicle Doors
            {"veh_speed_goal", ""},             //Need For Speed
            {"vehs_flyingcars", ""},            //Flying Cars
            {"misc_lester", ""},                //Pwned
            {"misc_credits", ""},               //Roll Credits
            {"misc_earthquake", ""},            //Earthquake
            {"player_tpfront", ""},             //Teleport Player A Few Meters
            {"peds_spawnfancats", ""},          //Spawn Fan Cats
            {"peds_cops", ""},                  //All Peds Are Cops
            {"vehs_rotall", ""},                //Flip All Vehicles
            {"peds_launchnearby", ""},          //Launch All Nearby Peds Up
            {"peds_attackplayer", ""},          //All Peds Attack Player
            {"player_clone", ""},               //Clone Player
            {"peds_slidy", ""},                 //Slidy Peds
            {"peds_spawndancingapes", ""},      //Spawn Dance Troupe
            {"misc_onebullet", ""},             //One Bullet Mags
            {"peds_phones", ""},                //Whose Phone Is Ringing
            {"misc_midas", ""},                 //Midas Touch
            {"peds_spawnrandomhostile", ""},    //Spawn Random Enemy
            {"playerveh_nobrakes", ""},         //No Braking Allowed
            {"peds_portal_gun", ""},            //Portal Guns
            {"misc_fireworks", ""},             //Fireworks!
            {"peds_spawnballasquad", ""},       //Spawn Balla Squad
            {"playerveh_despawn", ""},          //Remove Current Vehicle
            {"peds_scooterbrothers", ""},       //Scooter Brothers
            {"peds_intorandomvehs", ""},        //Set Everyone Into Random Vehicles
            {"player_heavyrecoil", ""},         //Heavy Recoil
            {"peds_catguns", ""},               //Catto Guns
            {"player_forcefield", ""},          //Forcefield
            {"misc_oilleaks", ""},              //Oil Trails
            {"peds_gunsmoke", ""},              //Gunsmoke
            {"player_keeprunning", ""},         //Help My W Key Is Stuck
            {"veh_weapons", ""},                //Vehicles Shoot Rockets
            {"misc_airstrike", ""},             //Airstrike Inbound
            {"peds_mercenaries", ""},           //Mercenaries
            {"peds_loosetrigger", ""},          //Loose Triggers
            {"peds_minions", ""},               //Minions
            {"misc_flamethrower", ""},          //Flamethrowers
            {"misc_dvdscreensaver", ""},        //DVD Screensaver
            {"player_fakedeath", ""},           //Fake Death
            {"time_superhot", ""},              //Superhot
            {"vehs_beyblade", ""},              //Beyblades
            {"peds_killerclowns", ""},          //Killer Clowns
            {"peds_jamesbond", ""},             //Spawn Deadly Agent
            {"player_poof", ""},                //Deadly Aim
            {"player_simeonsays", ""},          //Simeon Says
            {"veh_lockcamera", ""},             //Lock Vehicle Camera
            {"misc_replacevehicle", ""},        //Replace Current Vehicle
            {"player_tired", ""},               //I'm So Tired
            {"player_kickflip", ""},            //Kickflip
            {"misc_superstunt", ""},            //Super Stunt
            {"player_walkonwater", ""},         //Walk On Water
            {"screen_needglasses", ""},         //I Need Glasses
            {"player_flip_camera", ""},         //Turn Turtle
            {"player_quake_fov", ""},           //Quake FOV
            {"player_rapid_fire", ""},          //Rapid Fire
            {"player_on_demand_cartoon", ""},   //On-Demand TV
            {"peds_drive_backwards", ""},       //Peds Drive Backwards
            {"veh_randtraffic", ""},            //Random Traffic
            {"misc_rampjam", ""},               //Ramp Jam
            {"misc_vehicle_rain", ""},          //Vehicle Rain
            {"misc_fakecrash", ""},             //Fake Crash
            {"player_gravity", ""},             //Gravity Field
            {"veh_bouncy", ""},                 //Bouncy Vehicles
            {"peds_stop_stare", ""},            //Stop And Stare
            {"peds_flip", ""},                  //Spinning Peds
            {"player_pacifist", ""},            //Pacifist
            {"peds_busbois", ""},               //Bus Bois
            {"player_dead_eye", ""},            //Dead Eye
            {"player_hacking", ""},             //Realistic Hacking
            {"peds_nailguns", ""},              //Nailguns
            {"veh_brakeboost", ""},             //Brake Boosting
            {"player_bees", ""},                //Bees
            {"player_vr", ""},                  //Virtual Reality
            {"misc_portrait", ""},              //Portrait Mode
            {"misc_highpitch", ""},             //High Pitch
            {"misc_nosky", ""},                 //No Sky
            {"player_gta_2", ""},               //GTA 2
            {"peds_kifflom", ""},               //Kifflom!
            {"meta_timerspeed_0_5x", ""},       //0.5x Timer Speed
            {"meta_timerspeed_2x", ""},         //2x Timer Speed
            {"meta_timerspeed_5x", ""},         //5x Timer Speed
            {"meta_effect_duration_2x", ""},    //2x Effect Duration
            {"meta_effect_duration_0_5x", ""},  //0.5x Effect Duration
            {"meta_hide_chaos_ui", ""},         //What's Happening??
            {"meta_spawn_multiple_effects", ""},//Combo Time
            {"vehs_crumble", ""},               //Crumbling Vehicles
            {"misc_fps_limit", ""},             //Console Experience
            {"meta_nochaos", ""},               //No Chaos
            {"peds_roasting", ""}               //Roasting
        };
    }
}