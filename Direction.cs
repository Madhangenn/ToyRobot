using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    class Direction
    {
        private static int currentDirection;
        public static int CurrentDirection
        {
            get { return currentDirection; }

            set { currentDirection = value; }
           }

        public int getDirectionCodeByBtnName(string btn)
        {
            int value;
            switch (btn)
            {
                case "btnNorth":
                    value = Config.North;
                    break;
                case "btnEast":
                    value = Config.East;
                    break;
                case "btnSouth":
                    value = Config.South;
                    break;
                case "btnWest":
                    value = Config.West;
                    break;
                default:
                    // default value NORTH if invalid input
                    value = Config.North;  
                    break;
            }

            return value;

        }


        public string getDirectionNameByCode(int code)
        {
            string value;
            switch (code)
            {
                case Config.North:
                    value = Config.DirectionNorth;
                    break;
                case Config.East:
                    value = Config.DirectionEast;
                    break;
                case Config.South:
                    value = Config.DirectionSouth;
                    break;
                case Config.West:
                    value = Config.DirectionWest;
                    break;
                default:
                    // default value NORTH if invalid input
                    value = Config.DirectionNorth; 
                    break;
            }

            return value;

        }


    }

}



