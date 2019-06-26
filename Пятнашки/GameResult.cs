using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пятнашки
{
    [Serializable]
    public class GameResult
    {

        public string Player { get; set; }
        public DateTime BeginTime { get; set; }
        public int CollectTime { get;  set; }
        public int StepNumber { get; set; }
        public GameResult()
        { }
        public GameResult(string player, DateTime begTime, int collTime, int step)
        {
            Player = player;
            BeginTime = begTime;
            CollectTime = collTime;
            StepNumber = step;
        }
    }
}
