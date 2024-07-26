using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZombieShooter
{
    public class MapSelectedEventArgs : EventArgs
    {
        public string SelectedMap { get; }

        public MapSelectedEventArgs(string selectedMap = null)
        {
            SelectedMap = selectedMap;
        }
    }
}
