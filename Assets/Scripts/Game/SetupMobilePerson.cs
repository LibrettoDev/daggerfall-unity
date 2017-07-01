﻿// Project:         Daggerfall Tools For Unity
// Copyright:       Copyright (C) 2009-2017 Daggerfall Workshop
// Web Site:        http://www.dfworkshop.net
// License:         MIT License (http://www.opensource.org/licenses/mit-license.php)
// Source Code:     https://github.com/Interkarma/daggerfall-unity
// Original Author: Gavin Clayton (interkarma@dfworkshop.net)
// Contributors:    
// 
// Notes:
//

using UnityEngine;
using DaggerfallWorkshop.Game.Entity;

namespace DaggerfallWorkshop
{
    /// <summary>
    /// Configure an NPC from script or from editor.
    /// </summary>
    public class SetupMobilePerson : MonoBehaviour
    {
        public DisplayRaces race = DisplayRaces.Breton;
        public Genders gender = Genders.Male;

        public enum DisplayRaces
        {
            Breton = 1,
            Redguard = 2,
            Nord = 3,
        }

        public void ApplyPersonSettings()
        {
            DaggerfallMobilePerson mobilePerson = GetMobilePersonChildScript();
            if (mobilePerson)
            {
                mobilePerson.SetPerson((Races)race, gender);
            }
        }

        public DaggerfallMobilePerson GetMobilePersonChildScript()
        {
            return GetComponentInChildren<DaggerfallMobilePerson>();
        }
    }
}