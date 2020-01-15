using System;

namespace mockdraft_2020
{

    public class MockDraftPick
    {
        public int round;
        public string teamCity;
        public string pickNumber;
        public string playerName;
        public string school;
        public string position;
        public string reachValue;
        public int leagifyPoints;

        public MockDraftPick(string pick, string team, string name, string school, string pos, string relativeVal)
        {
            this.pickNumber = pick;
            this.teamCity = team;
            this.round = convertPickToRound(pick);
            this.playerName = name;
            this.school = school;
            this.position = pos;
            this.reachValue = relativeVal;
            this.leagifyPoints = convertPickToPoints(pick);
        }
        public static int convertPickToRound(string pick)
        {
            // I'm not certain if this mock will add compensatory picks. 
            int intpick = 0;
            var canParse = int.TryParse(pick, out intpick);
            if (canParse)
            {
                /* 
                    Picks 1-32 : Round 1
                    Picks 33-64: Round 2
                    Picks 65-96: Round 3
                    Picks 97-128: Round 4
                    Picks 129-159: Round 5
                    Picks 160-191: Round 6
                    Picks 192-223: Round 7
                */
                if(intpick >= 1 && intpick <= 32)
                {
                    return 1;
                } else if (intpick >= 33 && intpick <= 64)
                {
                    return 2;
                } else if (intpick >= 65 && intpick <= 96)
                {
                    return 3;
                } else if (intpick >= 97 && intpick <= 128)
                {
                    return 4;
                } else if (intpick >= 129 && intpick <= 159)
                {
                    return 5;
                } else if (intpick >= 160 && intpick <= 191)
                {
                    return 6;
                } else if (intpick >= 192 && intpick <= 223)
                {
                    return 7;
                }
                return 0;
            }
            else
            {
                return 0;
            }
            
        }
        public static int convertPickToPoints(string pick)
        {
            int intpick = 0;
            var canParse = int.TryParse(pick, out intpick);
            if (canParse)
            {
                /* 
                    Top Pick: 40 Points
                    Picks 2-10: 35 Points
                    Picks 11-20: 30 Points
                    Picks 21-32: 25 Points
                    Picks 33-48: 20 Points
                    Picks 49-64: 15 Points
                    Round 3: 10 Points
                    Round 4: 8 Points
                    Round 5: 7 Points
                    Round 6: 6 Points
                    Round 7: 5 Points
                */
                if(intpick == 1)
                {
                    return 40;
                }
                else if (intpick >= 2 && intpick <= 10)
                {
                    return 35;
                }
                else if (intpick >= 11 && intpick <= 20)
                {
                    return 30;
                }
                else if (intpick >= 21 && intpick <= 32)
                {
                    return 25;
                }
                else if (intpick >= 33 && intpick <= 48)
                {
                    return 20;
                }
                else if (intpick >= 49 && intpick <= 64)
                {
                    return 15;
                } 
                else if (intpick >= 65 && intpick <= 96)
                {
                    return 10;
                } 
                else if (intpick >= 97 && intpick <= 128)
                {
                    return 8;
                } 
                else if (intpick >= 129 && intpick <= 159)
                {
                    return 7;
                } 
                else if (intpick >= 160 && intpick <= 191)
                {
                    return 6;
                } 
                else if (intpick >= 192 && intpick <= 223)
                {
                    return 5;
                }
            }
            return 0;
        }
    }
}