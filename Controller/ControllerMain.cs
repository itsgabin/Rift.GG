﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rift.GG.API;
using Rift.GG.Utils;

namespace Rift.GG.Controller
{
    public class ControllerMain
    {
        public bool GetSummoner(string summonerName)
        {
            Summoner_V4 summoner_V4 = new Summoner_V4(Constants.Region);

            var summoner = summoner_V4.GetSummonerByName(summonerName);

            Constants.Summoner = summoner;

            return summoner != null;
        }
    }
}
