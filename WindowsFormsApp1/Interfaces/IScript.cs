using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Interfaces
{
    internal interface IScript
    {

        //updates once per frame
        void Update();

        //called once when the game starts
        void Start();

    }
}
